using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Runtime.InteropServices;
using System.Diagnostics;



namespace ETS
{
    public partial class MainForm : Form
    {
        private Capture capture;

        public Image<Bgr, Byte> tempImage;
        public Image<Gray, Byte> currentFrame;
        public Image<Gray, Byte> prevFrame;
        public Image<Gray, Byte> tpl;

        public Rectangle realFrameRect;
        public Rectangle templateFrameRect;
        public const double FRAME_WIDTH = 240;
        public const double FRAME_HEIGHT = 180;
        public const double TPL_WIDTH = FRAME_WIDTH / MASHTAB;
        public const double TPL_HEIGHT = FRAME_HEIGHT / MASHTAB;
        public const double WIN_WIDTH	=	TPL_WIDTH * 2;
        public const double WIN_HEIGHT = TPL_HEIGHT * 2;
        public const double TM_THRESHOLD = 0.4;

        public Rectangle eye;
        public Rectangle window;
        public const double MASHTAB = 15;
        public States state;
        public MemStorage stor;
        public enum States
        {
            STATE_INIT,
            STATE_TRACKING
        }
        public void Init()
        {
            #region if capture is not created, create it now
            if (capture == null)
            {
                try
                {
                    capture = new Capture();
                    capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, FRAME_WIDTH);
                    capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, FRAME_HEIGHT);

                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            if (capture != null)
            {
                Application.Idle += ProcessFrame;
            }
            #endregion
            stor = new MemStorage();
            prevFrame = capture.QueryGrayFrame();
            realFrameRect = new Rectangle(0,0,(int)FRAME_WIDTH,(int)FRAME_HEIGHT);
            templateFrameRect = new Rectangle(0, 0, (int)(FRAME_WIDTH / MASHTAB), (int)(FRAME_HEIGHT / MASHTAB));
            state = States.STATE_INIT;
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            tempImage = capture.QueryFrame();
            captureImageBox.Image = tempImage;
            currentFrame = tempImage.Convert <Gray,Byte>();
            if (state == States.STATE_INIT)
            {
                window = new Rectangle(0, 0, currentFrame.Width, currentFrame.Height);
            }
            Contour<Point> contours = getConnectedComponents(currentFrame, prevFrame, window);
            switch (state)
            {
                case States.STATE_INIT:
                    {
                       

                        eye = GetEye(contours);
                        if (eye != Rectangle.Empty)
                        {
                            Debug.WriteLine("got template");
                            tpl = currentFrame.Copy(eye);
                            state = States.STATE_TRACKING;
                        }
                    }
                    break;
                case States.STATE_TRACKING:
                    {
                        Rectangle tmp = GetEyeLocation(currentFrame, tpl);
                        if (tmp != Rectangle.Empty)
                        {
                            Debug.WriteLine(eye.X + " | " + eye.Y);
                            CvInvoke.cvRectangle(captureImageBox.Image.Ptr, eye.Location, new Point(eye.X + eye.Width, eye.Y + eye.Height), new MCvScalar(255), 3, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, 0);
                        }
                        //state = States.STATE_INIT;
                    }
                    break;
            }
            prevFrame = currentFrame.Copy();
        }
        public Rectangle GetEye(Contour <Point> contours)
        {
            Contour<Point> first = contours;
            int cnt = 0;
            while (contours != null)
            {
                contours = contours.HNext;
                cnt++;
            }
            contours = first;
            if (contours == null || cnt != 2)
            {
                if (contours != null)
                {
                    Debug.WriteLine(cnt);
                }
                return Rectangle.Empty;
            }
            Debug.WriteLine(cnt);
            Rectangle r1 = contours.BoundingRectangle;

            contours = contours.HNext;

            if (contours == null)
                return Rectangle.Empty;

            Rectangle r2 = contours.BoundingRectangle;

            /* the width of the components are about the same */
            if (Math.Abs(r1.Width - r2.Width) >= 5)
                return Rectangle.Empty;

            /* the height f the components are about the same */
            if (Math.Abs(r1.Height - r2.Height) >= 5)
                return Rectangle.Empty;

            /* vertical distance is small */
            if (Math.Abs(r1.Y - r2.Y) >= 5)
                return Rectangle.Empty;

            /* reasonable horizontal distance, based on the components' width */
            int dist_ratio = Math.Abs(r1.X - r2.X) / r1.Width;
            if (dist_ratio < 2 || dist_ratio > 5)
                return Rectangle.Empty;

            /* get the centroid of the 1st component */
            Point point = new Point(
                r1.X + (r1.Width / 2),
                r1.Y + (r1.Height / 2)
            );


            /* return eye boundaries */
            return new Rectangle(
                point.X - (int)(TPL_WIDTH / 2),
                point.Y - (int)(TPL_HEIGHT / 2),
                (int)TPL_WIDTH,
                (int)TPL_HEIGHT
            );

            
        }

        Rectangle GetEyeLocation(Image<Gray, Byte> img, Image<Gray, Byte> tpl)
        {
            Image<Gray, float> tm;
            Rectangle win;
            Point[] minloc, maxloc;
            Point point;
            double[] minval, maxval;
            int w, h;

            /* get the centroid of eye */
            point = new Point(
                eye.X + eye.Width / 2,
                eye.Y + eye.Height / 2
            );

            /* setup search window 
               replace the predefined WIN_WIDTH and WIN_HEIGHT above 
               for your convenient */
            win = new Rectangle(
                point.X - (int)WIN_WIDTH / 2,
                point.Y - (int)WIN_HEIGHT / 2,
                (int)WIN_WIDTH,
                (int)WIN_HEIGHT
            );

            /* make sure that the search window is still within the frame */
            if (win.X < 0)
                win.X = 0;
            if (win.Y < 0)
                win.Y = 0;
            if (win.X + win.Width > img.Width)
                win.X = img.Width - win.Width;
            if (win.Y + win.Height > img.Height)
                win.Y = img.Height - win.Height;

            /* create new image for template matching result where: 
               width  = W - w + 1, and
               height = H - h + 1 */
            w = win.Width - tpl.Width + 1;
            h = win.Height - tpl.Height + 1;
           
            Rectangle prevROI = img.ROI;
            img.ROI = win;
            tm = img.MatchTemplate(tpl, Emgu.CV.CvEnum.TM_TYPE.CV_TM_SQDIFF_NORMED);

            tm.MinMax(out minval, out maxval, out minloc, out maxloc);

            img.ROI = prevROI;
           
            /* only good matches */
            if (minval[0] > TM_THRESHOLD)
                return Rectangle.Empty;

            /* return the search window */
            window = win;

            /* return eye location */
            eye = new Rectangle(
                win.X + minloc[0].X,
                win.Y + minloc[0].Y,
                (int)TPL_WIDTH,
                (int)TPL_HEIGHT
            );
            return eye;
          
        }

        public Contour<Point> getConnectedComponents(Image<Gray, Byte> currentFrame, Image<Gray, Byte> prevFrame, Rectangle window)
        {
            Image<Gray, Byte> diff = null; 
            Rectangle prevCurFrameRoi = currentFrame.ROI;
            Rectangle prevPrevFrameRoi = prevFrame.ROI;

            currentFrame.ROI = window;
            prevFrame.ROI = window;

            diff = currentFrame.Sub(prevFrame);

            diff = diff.ThresholdBinary(new Gray(5), new Gray(255));
            int[,] k = { {0, 1, 0},
                        {1, -4, 1},
                        {0, 1, 0}};

            StructuringElementEx elem = new StructuringElementEx(k, 1, 1);

            diff = diff.MorphologyEx(elem, Emgu.CV.CvEnum.CV_MORPH_OP.CV_MOP_OPEN, 1);



            currentFrame.ROI = prevCurFrameRoi;
            prevFrame.ROI = prevPrevFrameRoi;
            diff.ROI = prevPrevFrameRoi;
           
            
           
            Contour<Point> contours = diff.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_CCOMP, stor);

            stor.Clear();
            return contours;
        }

        public MainForm()
        {
            InitializeComponent();
            Init();

        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            captureImageBox.Size = new Size(this.Size.Width - 20, this.Size.Height - 20);
        }

      
     
    }
}
