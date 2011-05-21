using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using System.Diagnostics;
using ETS.Properties;
using System.Collections;
using System.Windows.Forms;
using ETS_Data;

namespace ETS.tracker
{
    public enum States
    {
        STATE_NOT_INITED,
        STATE_INITED,
        STATE_TRACKING,
        STATE_NONE,
        IDLE,
        ADD_TEMPLATE
    }
    public class CaptureManager
    {
        #region -- Events --
        public delegate void StartInitEventHandler();
        public event StartInitEventHandler OnStartInit;
        public delegate void FinishInitEventHandler();
        public event FinishInitEventHandler OnFinishInit;
        public delegate void InitErrorEventHandler(Exception e);
        public event InitErrorEventHandler OnErrorInit;
        public delegate void ImageEventHandler(Image<Bgr, Byte> image);
        public event ImageEventHandler OnImageQuery;
        public delegate void CurrentTimeChangedEventHandler(int currentTime);
        public event CurrentTimeChangedEventHandler OnTimeChanged;
        public delegate void StimulusEventHandler(Stimulus stimul);
        public event StimulusEventHandler OnStimul;
        
        #endregion
        #region -- Properties --
        private Image<Bgr, Byte> currentFrame;
        public Image<Bgr, Byte> CurrentFrame
        {
            get { return currentFrame; }
            set { currentFrame = value; }
        }
        private Image<Gray, Byte> currentGrayFrame;
        public Image<Gray, Byte> CurrentGrayFrame
        {
            get { return currentGrayFrame; }
            set { currentGrayFrame = value; }
        }

        private Capture cameraCapture;

        public Capture CameraCapture
        {
            get { return cameraCapture; }
            set { cameraCapture = value; }
        }
        public bool Inited
        {
            get { return cameraCapture != null; }
        }
        private States state;

        public States State
        {
            get { return state; }
            set { state = value; }
        }

        private int queryInterval;

        public int QueryInterval
        {
            get { return queryInterval; }
            set { queryInterval = value; }
        }
        private int cameraWidth;

        public int CameraWidth
        {
            get { return cameraWidth; }
            set { cameraWidth = value; }
        }
        private int cameraHeight;

        public int CameraHeight
        {
            get { return cameraHeight; }
            set { cameraHeight = value; }
        }


        private Series seria;

        public Series Seria
        {
            get { return seria; }
            set { seria = value; }
        }

        private int currentTimePosition;

        public int CurrentTimePosition
        {
            get { return currentTimePosition; }
            set { currentTimePosition = value; }
        }

        #endregion

        MemStorage stor;
        private Timer timer;

        public CaptureManager(Series s)
        {
            State = States.STATE_NOT_INITED;
            Seria = s;
            CurrentTimePosition = 0;
            QueryInterval = 40;
            try
            {
                stor = new MemStorage();
            }
            catch (Exception e)
            {
            }
            timer = new Timer();
            timer.Interval = QueryInterval;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        }
        public void Init()
        {
            OnStartInit();
            try
            {

                if (cameraCapture == null)
                {
                    cameraCapture = new Capture();
                }

                State = States.STATE_INITED;
                cameraCapture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, CameraWidth);
                cameraCapture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, CameraHeight);
                OnFinishInit();
            }
            catch (Exception e)
            {
                OnErrorInit(e);
                StopCapture();
                cameraCapture = null;
            }
            finally
            {

            }

        }
        public void StartCapture()
        {
            timer.Start();
        }
        public void StopCapture()
        {
            timer.Enabled = false;
            timer.Stop();
            try
            {
                timer.Dispose();
            }
            finally
            {
            }
            CloseCapture();

        }
        
        
        void timer_Tick(object sender, EventArgs e)
        {
            Image<Bgr, Byte> image = QueryFrame();
            OnImageQuery(image);
            ProcessFrame();
            ProcessStimul();
        }

        private void ProcessStimul()
        {
            Series currentSeria = Session.Instance.CurrentSeria;
            Order order = currentSeria.Config.OrderType;
            switch (order)
            {
                case Order.Fixed:
                    {
                        int interval = (int)currentSeria.Config.MaxInt;
                        int index = CurrentTimePosition / interval -1;
                        if (index >= 0 && index < currentSeria.Config.SelectedStimulusSet.Count)
                        {
                            Stimulus s = (Stimulus)currentSeria.Config.SelectedStimulusSet[index];
                            if (OnStimul != null)
                            {
                                OnStimul(s);
                            }
                        }
                    }
                    break;
                case Order.Probability:
                    break;
            }
        }

        public Image<Bgr, Byte> QueryFrame()
        {
            if (Inited)
            {
                Image<Bgr, Byte> tmp = cameraCapture.QueryFrame();
                if (tmp != null)
                {
                    CurrentGrayFrame = tmp.Convert<Gray, Byte>();
                    CurrentFrame = tmp;
                }
                return tmp;
            }
            return null;
        }
        public void DrawTemplates()
        {
            if (Session.Instance.CurrentTrial == null) return;
            foreach (Template r in Session.Instance.CurrentSeria.Templates)
            {
                CurrentFrame.Draw(r.Rect, new Bgr(0.0, 0.0, 255.0), 1);
            }
        }

        public void ProcessFrame()
        {
            if (CameraCapture != null)
            {
                DrawTemplates();
                DrawMatchingRegions();
                if (State == States.STATE_TRACKING)
                {
                    CurrentTimePosition += QueryInterval;
                    if (OnTimeChanged != null)
                    {
                        OnTimeChanged(CurrentTimePosition);
                    }
                }
                DrawTime();
            }
        }
        public void DrawTime()
        {
            TimeSpan ts = TimeSpan.FromMilliseconds(CurrentTimePosition);
            string time = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3} ", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            MCvFont f = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5);
            Size textSize = f.GetTextSize(time, 0);
            CurrentFrame.Draw(time, ref f, new Point(CurrentFrame.Width - textSize.Width - 10, CurrentFrame.Height - textSize.Height - 10), new Bgr(0, 0, 255));

        }
        public void Reset()
        {
            state = States.STATE_NOT_INITED;
            StopCapture();
            Init();
            StartCapture();
        }

        public void DrawMatchingRegions()
        {
         
            if (Session.Instance.CurrentTrial == null) return;

            for (int i = 0; i < Session.Instance.CurrentSeria.Templates.Count; i++)
            {
                Template t = (Template)Session.Instance.CurrentSeria.Templates[i];
                Rectangle match = GetMatchingRegionForTemplate(t, currentGrayFrame);
                if (t.Added)
                {
                    Session.Instance.CurrentSeria.SetTemplateCoord(i, new SeriesRecord(match, CurrentTimePosition), CurrentTimePosition);
                }
                CurrentFrame.Draw(match, new Bgr(255.0, 0.0, 0.0), 1);
            }

        }
        public Rectangle GetMatchingRegionForTemplate(Template t, Image<Gray, Byte> image)
        {
            Rectangle current = t.QueryCoordinate(image);
            return current;
        }
      

        internal void CloseCapture()
        {
            try
            {
                cameraCapture.Dispose();

            }
            catch (Exception e)
            {
            }
            cameraCapture = null;
        }

        internal void StartTracking()
        {
            State = States.STATE_TRACKING;
        }

        internal void StopTracking()
        {
            State = States.IDLE;
        }
    }

}
