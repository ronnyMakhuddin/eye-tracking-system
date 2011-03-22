using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETS_Data;

namespace ETS.ui
{
    public partial class SelectTrialform : Form
    {
        private Trial result;

        public Trial Result
        {
            get { return result; }
            set { result = value; }
        }
        public SelectTrialform()
        {
            InitializeComponent();
        }

        private void SelectTrialform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trialsDataSet.SelectTrials' table. You can move, or remove it, as needed.
            this.selectTrialsTableAdapter.Fill(this.trialsDataSet.SelectTrials);

        }

        private void grdTrials_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            result = Trial.Load(grdTrials.SelectedRows.Count > 0 ? grdTrials.SelectedRows[0] : null);
            Close();
        }
    }
}
