using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETS.tracker;
using ETS_Data;

namespace ETS.ui
{
    public partial class SeriesEditor : Form
    {
        private ETS_Data.Series series;
        private CaptureManager capture;
        public SeriesEditor(Series s)
        {
            InitializeComponent();
            this.series = s;
            capture = new CaptureManager(s);
            capture.OnErrorInit += new CaptureManager.InitErrorEventHandler(capture_OnErrorInit);
            capture.OnFinishInit += new CaptureManager.FinishInitEventHandler(capture_OnFinishInit);
            capture.OnImageQuery += new CaptureManager.ImageEventHandler(capture_OnImageQuery);
            capture.OnStartInit += new CaptureManager.StartInitEventHandler(capture_OnStartInit);
            capture.CameraWidth = 640;
            capture.CameraHeight = 480; 
            capture.Init();
            capture.StartCapture();

            slider.InitWithSeries(series);
            
        }

      
       

        void capture_OnImageQuery(Emgu.CV.Image<Emgu.CV.Structure.Bgr, Byte> image)
        {
            if (image != null)
            {
                pbxCapture.Image = image;
            }
        }

        void capture_OnErrorInit(Exception e)
        {
            MessageBox.Show("Exception while camera init: " + e.Message);
        }

        void capture_OnFinishInit()
        {
         
        }

        void capture_OnStartInit()
        {
          
        }

        private void SeriesEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (capture != null)
            {
               capture.StopCapture();
            }
        }

        private void btnAddTemplate_Click(object sender, EventArgs e)
        {
            AddTemplateForm atf = new AddTemplateForm(series, capture);
            atf.ShowDialog();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (!series.ContainsTemplates)
            {

                Util.ShowError("Please, add some template before tracking");
                return;
            }
            if (capture != null)
            {
                capture.StopTracking();
                capture.StartTracking();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.StopTracking();
                capture.Reset();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.StopTracking();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.StopTracking();
                slider.Value = 0;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.StopTracking();
                slider.Value = slider.Maximum;
            }
        }
    }
}
