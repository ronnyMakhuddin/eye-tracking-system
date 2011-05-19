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
    public partial class EditTrialsForm : Form
    {
        public EditTrialsForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.selectTrialsTableAdapter.Update(this.trialsDataSet);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void EditTrialsForm_Load(object sender, EventArgs e)
        {
  
            // TODO: This line of code loads data into the 'trialsDataSet.SelectTrials' table. You can move, or remove it, as needed.
            this.selectTrialsTableAdapter.Fill(this.trialsDataSet.SelectTrials);
    
        }
    }
}
