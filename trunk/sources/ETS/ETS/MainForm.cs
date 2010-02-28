using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;

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
        private void ProcessFrame(object sender, EventArgs arg)
        {
            captureImageBox.Image = capture.QueryFrame();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            captureImageBox.Size = new Size(this.Size.Width - 20, this.Size.Height - 20);
        }
    }
}
