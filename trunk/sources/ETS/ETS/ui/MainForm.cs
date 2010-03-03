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



namespace ETS
{
    public partial class MainForm : Form
    {
        private Capture capture;

        public MainForm()
        {
            InitializeComponent();
            #region if capture is not created, create it now
            if (capture == null)
            {
                try
                {
                    capture = new Capture();

                    CvInvoke.cvSetCaptureProperty(capture.Ptr, Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, FRAME_WIDTH);
                    CvInvoke.cvSetCaptureProperty(capture.Ptr, Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, FRAME_HEIGHT);
                    init();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            #endregion

            if (capture != null)
            {
                Application.Idle += ProcessFrame;
            }

        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            captureImageBox.Size = new Size(this.Size.Width - 20, this.Size.Height - 20);
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            captureImageBox.Image = capture.QueryFrame();
            frame.roi = captureImageBox.Image.Ptr;
            gray.roi = captureImageBox.Image.Ptr;
            if (frame.roi == IntPtr.Zero)
                exit_nicely("cannot query frame!");
            frame.origin = 0;

            if (stage == STAGE_INIT)
                window = new Rectangle(0, 0, frame.width, frame.height);

            CvInvoke.cvCvtColor(frame.roi, gray.roi, Emgu.CV.CvEnum.COLOR_CONVERSION.CV_BGR2GRAY);

            nc = get_connected_components(gray, prev, window, comp);

            if (stage == STAGE_INIT && is_eye_pair(comp, nc, ref eye))
            {

                CvInvoke.cvSetImageROI(gray.roi, eye);
                CvInvoke.cvCopy(gray.roi, tpl.roi, IntPtr.Zero);
                CvInvoke.cvResetImageROI(gray.roi);

                stage = STAGE_TRACKING;
                text_delay = 10;
            }

            if (stage == STAGE_TRACKING)
            {
                found = locate_eye(ref gray, ref tpl, ref window, ref eye);

                if (!found || key == 'r')
                    stage = STAGE_INIT;

                if (is_blink(ref comp, nc, window, eye))
                    text_delay = 10;

                DRAW_RECTS(frame, diff, window, eye);

            }

            CvInvoke.cvShowImage(wnd_name, frame.roi);
            CvInvoke.cvShowImage(wnd_debug, diff.roi);
            CvInvoke.cvCopy(gray.roi, prev.roi, IntPtr.Zero);


        }
        #region -- Test section --

        public static int FRAME_WIDTH = 240;
        public static int FRAME_HEIGHT = 180;
        public static int TPL_WIDTH = 16;
        public static int TPL_HEIGHT = 12;
        public static int WIN_WIDTH = TPL_WIDTH * 2;
        public static int WIN_HEIGHT = TPL_HEIGHT * 2;
        public static double TM_THRESHOLD = 0.4;
        public static int STAGE_INIT = 1;
        public static int STAGE_TRACKING = 2;
        MCvSeq comp;
        Rectangle window, eye;
        int key, nc;
        bool found;
        int text_delay, stage = STAGE_INIT;
        public Point POINT_TL(Rectangle r)
        {
            return new Point(r.X, r.Y);
        }
        public Point POINT_BR(Rectangle r)
        {
            return new Point(r.X + r.Width, r.Y + r.Height);
        }
        //#define POINTS(r)		POINT_TL(r), POINT_BR(r)


        public void DRAW_RECTS(MIplImage f, MIplImage d, Rectangle rw, Rectangle ro){
            do
            {
                MCvScalar color;
                color.v0 = 255;
                color.v1 = 255;
                color.v2 = 255;
                color.v3 = 255;

                CvInvoke.cvRectangle(f.roi, POINT_TL(rw), POINT_BR(rw), color, 1, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, 0);
                CvInvoke.cvRectangle(f.roi, POINT_TL(rw), POINT_BR(rw), color, 1, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, 0);
                CvInvoke.cvRectangle(d.roi, POINT_TL(rw), POINT_BR(rw), color, 1, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, 0);
                CvInvoke.cvRectangle(d.roi, POINT_TL(rw), POINT_BR(rw), color, 1, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, 0);
            } while (true);
}
        /*#define	DRAW_TEXT(f, t, d, use_bg)								\
        if (d)															\
        {																\
            CvSize _size;												\
            cvGetTextSize(t, &font, &_size, NULL);						\
            if (use_bg)													\
            {															\
                cvRectangle(f, cvPoint(0, f.height), 					\
                            cvPoint(_size.width + 5, 					\
                                    f.height - _size.height * 2),		\
                            CV_RGB(255, 0, 0), CV_FILLED, 8, 0);		\
            }															\
            cvPutText(f, t, cvPoint(2, f.height - _size.height / 2),	\
                      &font, CV_RGB(255,255,0));						\
            d--;														\
        }*/


        MIplImage frame, gray, prev, diff, tpl;
        MemStorage storage;
        ConvolutionKernelF kernel;
        MCvFont font;
        string wnd_name = "video";
        string wnd_debug = "diff";

        int get_connected_components(MIplImage img, MIplImage prev, Rectangle window, MCvSeq comp)
        {
            MIplImage _diff;

            CvInvoke.cvZero(diff.roi);

            /* apply search window to images */
            CvInvoke.cvSetImageROI(img.roi, window);
            CvInvoke.cvSetImageROI(prev.roi, window);
            CvInvoke.cvSetImageROI(diff.roi, window);

            /* motion analysis */
            CvInvoke.cvSub(img.roi, prev.roi, diff.roi, IntPtr.Zero);
            CvInvoke.cvThreshold(diff.roi, diff.roi, 5, 255, Emgu.CV.CvEnum.THRESH.CV_THRESH_BINARY);
            CvInvoke.cvMorphologyEx(diff.roi, diff.roi, IntPtr.Zero, kernel.Ptr, Emgu.CV.CvEnum.CV_MORPH_OP.CV_MOP_OPEN, 1);

            /* reset search window */
            CvInvoke.cvResetImageROI(img.roi);
            CvInvoke.cvResetImageROI(prev.roi);
            CvInvoke.cvResetImageROI(diff.roi);

            _diff = new MIplImage();
            CvInvoke.cvCopy(diff.roi, _diff.roi, diff.maskROI);



            /* get connected components */
            MCvContour c = new MCvContour();
            int nc = CvInvoke.cvFindContours(_diff.roi, storage.Ptr, ref comp.ptr, Marshal.SizeOf(c),
                                   Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_CCOMP, Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, new Point(0, 0));

            CvInvoke.cvClearMemStorage(storage);
            CvInvoke.cvReleaseImage(ref _diff.roi);

            return nc;
        }
        bool is_eye_pair(MCvSeq comp, int num, ref Rectangle eye)
        {
            if (comp.ptr == IntPtr.Zero || num != 2)
                return false;

            Rectangle r1 = CvInvoke.cvBoundingRect(comp.ptr, true);
            comp.ptr = comp.h_next;

            if (comp.ptr == IntPtr.Zero)
                return false;

            Rectangle r2 = CvInvoke.cvBoundingRect(comp.ptr, true);

            /* the width of the components are about the same */
            if (Math.Abs(r1.Width - r2.Width) >= 5)
                return false;

            /* the height f the components are about the same */
            if (Math.Abs(r1.Height - r2.Height) >= 5)
                return false;

            /* vertical distance is small */
            if (Math.Abs(r1.Y - r2.Y) >= 5)
                return false;

            /* reasonable horizontal distance, based on the components' width */
            int dist_ratio = Math.Abs(r1.X - r2.X) / r1.Width;
            if (dist_ratio < 2 || dist_ratio > 5)
                return false;

            /* get the centroid of the 1st component */
            Point point = new Point(
                r1.X + (r1.Width / 2),
                r1.Y + (r1.Height / 2)
            );

            /* return eye boundaries */
            eye = new Rectangle(
                point.X - (TPL_WIDTH / 2),
                point.Y - (TPL_HEIGHT / 2),
                TPL_WIDTH,
                TPL_HEIGHT
            );

            return true;
        }
        bool locate_eye(ref MIplImage img, ref MIplImage tpl, ref Rectangle window, ref Rectangle eye)
        {
            MIplImage tm;
            Rectangle win;
            Point minloc = new Point();
            Point maxloc = new Point();
            Point point = new Point();
            double minval = 0.0, maxval = 0.0;
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
                point.X - WIN_WIDTH / 2,
                point.X - WIN_HEIGHT / 2,
                WIN_WIDTH,
                WIN_HEIGHT
            );

            /* make sure that the search window is still within the frame */
            if (win.X < 0)
                win.X = 0;
            if (win.Y < 0)
                win.Y = 0;
            if (win.X + win.Width > img.width)
                win.X = img.width - win.Width;
            if (win.Y + win.Height > img.height)
                win.Y = img.height - win.Height;

            /* create new image for template matching result where: 
               Width  = W - w + 1, and
               Height = H - h + 1 */
            w = win.Width - tpl.width + 1;
            h = win.Height - tpl.height + 1;
            tm.roi = CvInvoke.cvCreateImage(new Size(w, h), Emgu.CV.CvEnum.IPL_DEPTH.IPL_DEPTH_32F, 1);

            /* apply the search window */
            CvInvoke.cvSetImageROI(img.roi, win);

            /* template matching */
            CvInvoke.cvMatchTemplate(img.roi, tpl.roi, tm.roi, Emgu.CV.CvEnum.TM_TYPE.CV_TM_SQDIFF_NORMED);
            CvInvoke.cvMinMaxLoc(tm.roi, ref minval, ref maxval, ref minloc, ref maxloc, IntPtr.Zero);

            /* release things */
            CvInvoke.cvResetImageROI(img.roi);
            CvInvoke.cvReleaseImage(ref tm.roi);

            /* only good matches */
            if (minval > TM_THRESHOLD)
                return false;

            /* return the search window */
            window = win;

            /* return eye location */
            eye = new Rectangle(
                win.X + minloc.X,
                win.Y + minloc.Y,
                TPL_WIDTH,
                TPL_HEIGHT
            );

            return true;
        }


        bool
is_blink(ref MCvSeq comp, int num, Rectangle window, Rectangle eye)
        {
            if (comp.ptr == IntPtr.Zero || num != 1)
                return false;

            Rectangle r1 = CvInvoke.cvBoundingRect(comp.ptr, true);

            /* component is within the search window */
            if (r1.X < window.X)
                return false;
            if (r1.Y < window.Y)
                return false;
            if (r1.X + r1.Width > window.X + window.Width)
                return false;
            if (r1.Y + r1.Height > window.Y + window.Height)
                return false;

            /* get the centroid of eye */
            Point pt = new Point(
                eye.X + eye.Width / 2,
                eye.Y + eye.Height / 2
            );

            /* component is located at the eye's centroid */
            if (pt.X <= r1.X || pt.X >= r1.X + r1.Width)
                return false;
            if (pt.Y <= r1.Y || pt.Y >= r1.Y + r1.Height)
                return false;

            return true;
        }
        void exit_nicely(string msg)
        {


            if (gray.roi != IntPtr.Zero)
                CvInvoke.cvReleaseImage(ref gray.roi);
            if (prev.roi != IntPtr.Zero)
                CvInvoke.cvReleaseImage(ref prev.roi);
            if (diff.roi != IntPtr.Zero)
                CvInvoke.cvReleaseImage(ref diff.roi);
            if (tpl.roi != IntPtr.Zero)
                CvInvoke.cvReleaseImage(ref tpl.roi);

            if (msg != null)
            {
                Application.Exit();
            }

            Application.Exit();
        }

        void init()
        {
            int i;



            storage = new MemStorage();
            if (storage == null)
                exit_nicely("cannot allocate memory storage!");
            frame.roi = CvInvoke.cvQueryFrame(capture.Ptr);
            kernel = new ConvolutionKernelF(3, 3);
            kernel.Ptr = CvInvoke.cvCreateStructuringElementEx(3, 3, 1, 1, Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_CROSS, null);

            gray.roi = CvInvoke.cvCreateImage(CvInvoke.cvGetSize(frame.roi), Emgu.CV.CvEnum.IPL_DEPTH.IPL_DEPTH_8U, 1);
            prev.roi = CvInvoke.cvCreateImage(CvInvoke.cvGetSize(frame.roi), Emgu.CV.CvEnum.IPL_DEPTH.IPL_DEPTH_8U, 1);
            diff.roi = CvInvoke.cvCreateImage(CvInvoke.cvGetSize(frame.roi), Emgu.CV.CvEnum.IPL_DEPTH.IPL_DEPTH_8U, 1);
            tpl.roi = CvInvoke.cvCreateImage(new Size(TPL_WIDTH, TPL_HEIGHT), Emgu.CV.CvEnum.IPL_DEPTH.IPL_DEPTH_8U, 1);


            gray.origin = frame.origin;
            prev.origin = frame.origin;
            diff.origin = frame.origin;


        }
        #endregion

    }
}
