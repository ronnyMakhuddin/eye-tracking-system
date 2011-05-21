using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ETS.ui
{
    public partial class EditTextForm : Form
    {
        public string EditText
        {
            get { return txtText.Text; }
            set { this.txtText.Text = value; }
        }
        public EditTextForm(string text)
        {
            InitializeComponent();
            this.EditText = text;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
      
    }
}
