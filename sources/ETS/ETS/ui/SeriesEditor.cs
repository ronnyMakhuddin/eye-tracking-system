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
using ETS.Properties;
using ETS.serialize;
using System.IO;
using System.Threading;

namespace ETS.ui
{
    delegate void EnableFromCallback(bool enable);
      
    public partial class SeriesEditor : Form
    {
        private ETS_Data.Series series;
        private CaptureManager capture;
        private SeriesPlayer player;
        public SeriesEditor(Series s)
        {
            InitializeComponent();
            this.series = s;
            capture = new CaptureManager(s);
            capture.OnErrorInit += new CaptureManager.InitErrorEventHandler(capture_OnErrorInit);
            capture.OnFinishInit += new CaptureManager.FinishInitEventHandler(capture_OnFinishInit);
            capture.OnImageQuery += new CaptureManager.ImageEventHandler(capture_OnImageQuery);
            capture.OnStartInit += new CaptureManager.StartInitEventHandler(capture_OnStartInit);
            capture.OnTimeChanged += new CaptureManager.CurrentTimeChangedEventHandler(capture_OnTimeChanged);
            capture.OnStimul += new CaptureManager.StimulusEventHandler(capture_OnStimul);
            capture.CameraWidth = 640;
            capture.CameraHeight = 480; 
            capture.Init();
            capture.StartCapture();

            slider.InitWithSeries(series);
            slider.ValueChanged += new controls.CaptureSlider.ValueChangedHandler(slider_ValueChanged);

            player = new SeriesPlayer(series);
            player.Show();

           
        }

        void capture_OnStimul(Stimulus stimul)
        {
            player.ShowStimul(stimul);
        }

        void capture_OnTimeChanged(int currentTime)
        {
            slider.Value = currentTime;
            if (slider.Value == slider.Maximum)
            {
                if (capture != null)
                {
                    capture.StopTracking();
                }
            }
        }

        void slider_ValueChanged(int value)
        {
            capture.CurrentTimePosition = value;
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
            if (slider.Value == slider.Maximum)
            {
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
                capture.StopCapture();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            EnableForm(false);
            Thread t = new Thread(new ThreadStart(SaveSeries));
            t.Start();
           
        }
        public void SaveSeries()
        {
            SqlUtils.SaveSeries(series, Settings.Default.DBConnectionString);
            EnableForm(true);
        }
        private void btnEditTemplates_Click(object sender, EventArgs e)
        {
            EditTemplatesForm etf = new EditTemplatesForm(series);
            etf.ShowDialog();
        }

        private void btnSaveCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = series.Name.Trim() + ".CSV";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                CSVSerializer.SaveSeria(series, (FileStream)sfd.OpenFile());
            }
        }
        public void EnableForm(bool enable)
        {
            if (this.InvokeRequired)
            {
                EnableFromCallback clb = new EnableFromCallback(EnableForm);
                this.Invoke(clb, new object[] { enable });
            }
            else
            {
                this.Enabled = enable;
            }
        }
    }
}
