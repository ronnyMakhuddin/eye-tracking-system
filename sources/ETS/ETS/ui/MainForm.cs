using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ETS.ui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void miClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miViewPatients_Click(object sender, EventArgs e)
        {
            EditPatientsForm epf = new EditPatientsForm();
            epf.Show();
        }

        private void miEditStimuluses_Click(object sender, EventArgs e)
        {
            EditStimulusForm esf = new EditStimulusForm();
            esf.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }
    }
}
