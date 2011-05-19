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

        public SeriesEditor(Series s)
        {
            InitializeComponent();
            this.series = s;
            CaptureManager capture = CaptureManager.Instance;
            capture.OnErrorInit += new CaptureManager.InitErrorEventHandler(capture_OnErrorInit);
            capture.OnFinishInit += new CaptureManager.FinishInitEventHandler(capture_OnFinishInit);
            capture.OnImageQuery += new CaptureManager.ImageEventHandler(capture_OnImageQuery);
            capture.OnStartInit += new CaptureManager.StartInitEventHandler(capture_OnStartInit);
             
            if (!capture.Inited)
            {
                capture.CameraWidth = 320;
                capture.CameraHeight = 240;
                capture.Init();
            }

            capture.StartCapture();
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
            if (CaptureManager.Instance != null)
            {
                CaptureManager.Instance.StopCapture();
            }
        }

        private void btnAddTemplate_Click(object sender, EventArgs e)
        {
            AddTemplateForm atf = new AddTemplateForm(series);
            atf.ShowDialog();
        }
    }
}
