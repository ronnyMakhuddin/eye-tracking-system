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
    public partial class EditStimulusSetForm : Form
    {
        private Int64 seriesConfigId;
        public EditStimulusSetForm()
        {
            InitializeComponent();
        }
        public EditStimulusSetForm(Int64 seriesConfigID)
        {
            this.seriesConfigId = seriesConfigID;
            InitializeComponent();
            this.selectStimulusSetTableAdapter.Fill((StimulusSetDataSet.SelectStimulusSetDataTable)this.stimulusSetDataSet.Tables[0], seriesConfigID);
        }

    

        private void EditStimulusSetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stimDataSet.SelectStimuluses' table. You can move, or remove it, as needed.
            this.selectStimulusesTableAdapter.Fill(this.stimDataSet.SelectStimuluses);

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            this.selectStimulusSetTableAdapter.Update(this.stimulusSetDataSet);
            Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void grdSet_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex-1; i < e.RowIndex + e.RowCount-1;i++ ){
                if (i >= 0)
                {
                    grdSet["series_config_id", i].Value = seriesConfigId;
                }
            }
        }
    }
}
