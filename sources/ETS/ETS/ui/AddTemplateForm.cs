using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETS.tracker;
using ETS.Properties;
using ETS_Data;

namespace ETS.ui
{
    public partial class AddTemplateForm : Form
    {
        private int width;
        private int height;
        private Series seria;
        public AddTemplateForm(Series s)
        {
            InitializeComponent();
            this.width = CaptureManager.Instance.CameraWidth;
            this.height = CaptureManager.Instance.CameraHeight;
            this.seria = s;
            s.AddTemplate(Template.Empty);

            sldRightX.Maximum = height;
            sldRightY.Maximum = height;
            sldLeftX.Maximum = sldRightX.Value;
            sldLeftY.Maximum = sldRightY.Value;

            sldLeftX.Value = 0;
            sldLeftY.Value = 0;
            sldRightX.Value = 0;
            sldRightY.Value = 0;

            txtName.Text = Resources.UNTITLED;
        }
        
        public void RefreshUI()
        {
            Rectangle rect = new Rectangle(sldLeftX.Value, sldLeftY.Value, sldRightX.Value - sldLeftX.Value, sldRightY.Value - sldLeftY.Value);
            if (rect != Rectangle.Empty && rect.Width != 0 && rect.Height != 0)
            {
              seria.SetLastTemplate(new Template(rect, CaptureManager.Instance.CurrentGrayFrame.Copy(rect)));
            }
            sldLeftX.Maximum = sldRightX.Value;
            sldLeftY.Maximum = sldRightY.Value;
            sldRightX.Minimum = sldLeftX.Value;
            sldRightY.Minimum = sldLeftY.Value;


        }
        private void sldLeftX_ValueChanged(int value)
        {
            RefreshUI();
        }

        private void sldLeftY_ValueChanged(int value)
        {
            RefreshUI();
        }

        private void sldRightX_ValueChanged(int value)
        {
            RefreshUI();
        }

        private void sldRightY_ValueChanged(int value)
        {
            RefreshUI();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            seria.GetLastTemplate().Added = true;
            seria.GetLastTemplate().Name = txtName.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            seria.RemoveLastTemplate();
        }
    }
}
