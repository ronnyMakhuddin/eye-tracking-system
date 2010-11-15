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
    public partial class EditPatientsForm : Form
    {
        public EditPatientsForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditPatientsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientsDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.patientsDataSet.Patients);
        
        }

        private void grdPatients_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Util.ShowError(e.Exception.Message);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            patientsTableAdapter.Update(patientsDataSet);
            Close();
        }
    }
}
