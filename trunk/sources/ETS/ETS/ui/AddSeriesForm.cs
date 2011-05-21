using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ETS.Properties;
using ETS_Data;
using ETS.tracker;

namespace ETS.ui
{
    public partial class AddSeriesForm : Form
    {
        private long id = -1;
        private long configId = -1;
        public AddSeriesForm(Series s)
        {
            InitializeComponent();
            this.id = s.Id;
            this.configId = s.Config.Id;
            this.txtSeriesName.Text = s.Name;
           
        }
        public AddSeriesForm()
        {
            InitializeComponent();
        }

        private void AddSeriesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seriesConfigDataSet.SelectSeriesConfigs' table. You can move, or remove it, as needed.
            this.selectSeriesConfigsTableAdapter.Fill(this.seriesConfigDataSet.SelectSeriesConfigs);
            if (id != -1)
            {
                for (int i = 0; i < cmbSeriesConfig.Items.Count; i++)
                {
                    DataRowView dr = (DataRowView)cmbSeriesConfig.Items[i];
                    long itemId = Int64.Parse(dr.Row["id"].ToString());
                    if (itemId == configId)
                    {
                        cmbSeriesConfig.SelectedIndex = i;
                        break;
                    }
                }
                 
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlUtils.InsertSeries(txtSeriesName.Text, ((DataRowView)cmbSeriesConfig.SelectedItem).Row["id"],Session.Instance.CurrentTrial.Id, Settings.Default.DBConnectionString, id);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
