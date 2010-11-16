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
    public partial class EditSeriesConfigs : Form
    {
        public EditSeriesConfigs()
        {
            InitializeComponent();
        }

        private void EditSeriesConfigs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seriesConfigDataSet.SelectSeriesConfigs' table. You can move, or remove it, as needed.
            this.selectSeriesConfigsTableAdapter.Fill(this.seriesConfigDataSet.SelectSeriesConfigs);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            selectSeriesConfigsTableAdapter.Update(seriesConfigDataSet);
            this.Close();
        }
    }
}
