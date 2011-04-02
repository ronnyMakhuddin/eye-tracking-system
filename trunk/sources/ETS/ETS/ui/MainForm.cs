using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ETS.tracker;
using ETS.controls;

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

        private void miEditSeriesConfigs_Click(object sender, EventArgs e)
        {
            EditSeriesConfigForm esc = new EditSeriesConfigForm();
            esc.Show();
        }

        private void editSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTrialsForm etf = new EditTrialsForm();
            etf.ShowDialog();
        }

        private void miNewTrial_Click(object sender, EventArgs e)
        {
            SelectTrialform stf = new SelectTrialform();
            stf.ShowDialog();
            Session.Instance.CurrentTrial = stf.Result;
            if (Session.Instance.CurrentTrial != null)
            {
                LoadTrialsTreeView();
            }
        }
        public void LoadTrialsTreeView()
        {
            trwTrials.Nodes.Clear();
            TrialTreeNode rootNode = new TrialTreeNode(Session.Instance.CurrentTrial);
            trwTrials.Nodes.Add(rootNode);
            miAddSeries.Visible = true;
        }

        private void miAddSeries_Click(object sender, EventArgs e)
        {
            AddSeriesForm asf = new AddSeriesForm();
            asf.ShowDialog();
            Session.Instance.CurrentTrial.Refresh();
            LoadTrialsTreeView();
        }

        private void trwTrials_DoubleClick(object sender, EventArgs e)
        {
            if (sender is SeriesTreeNode)
            {
                SeriesTreeNode stn = (SeriesTreeNode)sender;
                SeriesEditor se = new SeriesEditor(stn.Seria);
            }
        }
    }
}
