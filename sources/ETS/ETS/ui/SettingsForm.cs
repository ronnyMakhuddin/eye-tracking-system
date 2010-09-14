using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETS.Properties;
using System.Configuration;
using ETS.tracker;

namespace ETS.ui
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            sldRealHeight.Maximum = Screen.PrimaryScreen.WorkingArea.Height;
            sldRealWidth.Maximum = Screen.PrimaryScreen.WorkingArea.Width;
            sldAnalWidth.Maximum = Screen.PrimaryScreen.WorkingArea.Width / 2;
            sldAnalHeight.Maximum = Screen.PrimaryScreen.WorkingArea.Height / 2;

            sldRealHeight.Value = Settings.Default.RealCaptureHeight;
            sldRealWidth.Value = Settings.Default.RealCaptureWidth;
            sldAnalWidth.Value = Settings.Default.AnalyticWidth;
            sldAnalHeight.Value = Settings.Default.AnalyticHeight;

      
         }

    
        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.RealCaptureWidth = sldRealWidth.Value;
            Settings.Default.RealCaptureHeight = sldRealHeight.Value;
            Settings.Default.AnalyticWidth = sldAnalWidth.Value;
            Settings.Default.AnalyticHeight = sldAnalHeight.Value;

            Settings.Default.Save();
        }

        
    }
}
