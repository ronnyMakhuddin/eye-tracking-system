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
    public partial class EditSeriesConfigForm : Form
    {
        private const int EDIT_STIMULUS_SET = 9;
        private const int EDIT_STIMULUS_ORDER = 10;
        public EditSeriesConfigForm()
        {
            InitializeComponent();
        }

        private void EditSeriesConfigForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderTypesDataSet.OrderType' table. You can move, or remove it, as needed.
            this.orderTypeTableAdapter.Fill(this.orderTypesDataSet.OrderType);
            // TODO: This line of code loads data into the 'seriesConfigDataSet.SelectSeriesConfigs' table. You can move, or remove it, as needed.
            this.selectSeriesConfigsTableAdapter.Fill(this.seriesConfigDataSet.SelectSeriesConfigs);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.selectSeriesConfigsTableAdapter.Update(this.seriesConfigDataSet);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdConfigs_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Util.ShowError(e.Exception.Message);
        }

        private void grdConfigs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            DataGridViewCell c = grdConfigs[e.ColumnIndex, e.RowIndex];
            if (c is DataGridViewButtonCell)
            {
                if (e.ColumnIndex == EDIT_STIMULUS_SET)
                {
                    Int64 id = (Int64)grdConfigs[1, e.RowIndex].Value;
                    EditStimulusSetForm essf = new EditStimulusSetForm(id);
                    essf.Show();
                }
                else if (e.ColumnIndex == EDIT_STIMULUS_ORDER)
                { 
                    string str = (string)grdConfigs["stimulusOrder", e.RowIndex].Value;
                    long interval = (long)grdConfigs["maxInt", e.RowIndex].Value;
                 
                    EditStimulusOrderForm esof = new EditStimulusOrderForm(str, interval);
                    if (esof.ShowDialog() == DialogResult.OK)
                    {
                        grdConfigs["stimulusOrder", e.RowIndex].Value = esof.Result;
                    }
                    
                }
            }
        }
    }
}
