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
    public partial class EditStimulusForm : Form
    {
        public EditStimulusForm()
        {
            InitializeComponent();
        }

        private void EditStimulusForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'positionSet.SelectPositions' table. You can move, or remove it, as needed.
            this.selectPositionsTableAdapter.Fill(this.positionSet.SelectPositions);
            // TODO: This line of code loads data into the 'stimulusTypeDataSet.StimulusType' table. You can move, or remove it, as needed.
            this.stimulusTypeTableAdapter.Fill(this.stimulusTypeDataSet.StimulusType);
            // TODO: This line of code loads data into the 'stimDataSet.SelectStimuluses' table. You can move, or remove it, as needed.
            this.selectStimulusesTableAdapter.Fill(this.stimDataSet.SelectStimuluses);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.selectStimulusesTableAdapter.Update(this.stimDataSet);
            Close();
        }

        private void grdStimuluses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Util.ShowError(e.Exception.Message);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdStimuluses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            DataGridViewCell c = grdStimuluses[e.ColumnIndex, e.RowIndex];
            if (c.ColumnIndex == 1)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filename = ofd.FileName;
                    c.Value = filename;
                }
            }
        }
    }
}
