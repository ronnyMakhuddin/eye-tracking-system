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

namespace ETS.tracker
{
    public enum States
    {
        STATE_INIT,
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


        private static CaptureManager instance;

        public static CaptureManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CaptureManager();

                }

                return instance;

            }
        }

        public int CameraWidth
        {
            set
            {
                if (Inited)
                {
                    cameraCapture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, value);
                }
            }
            get
            {
                if (Inited)
                {
                    return (int)cameraCapture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH);
                }
                return 0;
            }
        }

        public int CameraHeight
        {
            set
            {
                if (Inited)
                {
                    cameraCapture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, value);
                }
            }
            get
            {
                if (Inited)
                {
                    return (int)cameraCapture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT);
                }
                return 0;
            }
        }
        private bool isRecording;

        public bool IsRecording
        {
            get { return isRecording; }
        }
        #endregion

        MemStorage stor;
        private Timer timer;

        private CaptureManager()
        {
            State = States.IDLE;
            try
            {
                stor = new MemStorage();
            }
            catch (Exception e)
            {
            }
            timer = new Timer();
            timer.Interval = 100;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
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
          
        }
        void timer_Tick(object sender, EventArgs e)
        {
            Image<Bgr, Byte> image = QueryFrame();
            OnImageQuery(image);
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
            /* foreach (Template r in Session.Instance.CurrentTrial.Templates)
             {
                 CurrentFrame.Draw(r.Rect, new Bgr(0.0, 0.0, 255.0), 1);
             }*/
        }

        public void ProcessFrame()
        {
            DrawTemplates();
            DrawMatchingRegions();
        }

        public void Reset()
        {
            state = States.STATE_INIT;
        }

        public void DrawMatchingRegions()
        {
            ArrayList matches = GetMatchingRegions(currentGrayFrame);
            if (matches == null) return;
            foreach (Rectangle r in matches)
            {
                CurrentFrame.Draw(r, new Bgr(255.0, 0.0, 0.0), 1);

            }
        }
        public ArrayList GetMatchingRegions(Image<Gray, Byte> image)
        {
            if (Session.Instance.CurrentTrial == null) return null;
            ArrayList result = new ArrayList();
            /*  foreach (Template r in Session.Instance.CurrentTrial.Templates)
              {
                  Rectangle current = r.QueryCoordinate(image);
                  result.Add(current);
                  if (r.Added && IsRecording)
                  {
                      r.Coords.Add(current);
                      Session.Instance.CurrentTrial.Modified = true;
                  }
              }*/
            return result;
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
                CameraWidth = 700;
                State = States.STATE_INIT;

                OnFinishInit();
            }
            catch (Exception e)
            {
                OnErrorInit(e);
                cameraCapture = null;
            }
            finally
            {

            }

        }
        public void StartRecording()
        {
            isRecording = true;
        }
        public void StopRecording()
        {
            isRecording = false;
        }
    }

}
