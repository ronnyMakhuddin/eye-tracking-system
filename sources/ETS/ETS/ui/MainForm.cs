﻿using System;
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
using System.Threading;
using ETS_Data;

namespace ETS.ui
{
    public partial class MainForm : Form
    {
        delegate void SetStatusCallback(string status);
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

        public void ConnectToDatabase()
        {
            

            for (int i = 0; i < 10; i++)
            {
                SetStatusLabel("Connecting to database: " + (i+1) + " attempt");
                string status = SqlUtils.OpenFirstConnection();
                SetStatusLabel(status);
                if (!status.Contains("Error"))
                {
                    break;
                }
                Thread.Sleep(500);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(ConnectToDatabase));
            t.Start();
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


            if (trwTrials.SelectedNode is SeriesTreeNode)
            {
                SeriesTreeNode stn = (SeriesTreeNode)trwTrials.SelectedNode;
                SeriesEditor se = new SeriesEditor(stn.Seria);
                Session.Instance.CurrentSeriaId = stn.Seria.Id;
                se.Show();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CaptureManager.Instance.CloseCapture();
        }
        private void SetStatusLabel(string status)
        {
            if (strStatus.InvokeRequired)
            {
                SetStatusCallback clb = new SetStatusCallback(SetStatusLabel);
                strStatus.Invoke(clb, new object[] { status });
            }
            else
            {
                lblDbStatus.Text = status;
            }
        }
    }
}