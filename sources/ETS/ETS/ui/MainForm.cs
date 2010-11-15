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
            DataSet ds = new DataSet("test");
            SqlConnection ccc = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True;User Instance=True");
            ccc.Open();
            SqlCommand select = ccc.CreateCommand();
             select.CommandText = "SELECT * FROM Stimulus";
            object r = select.ExecuteScalar();
            ccc.Close();
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
