using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ETS_Data;

namespace ETS.ui
{
    public partial class EditStimulusOrderForm : Form
    {
        private ArrayList orderArray;
        private string order;
        private long interval;
        private int comboY;
        private Order orderType;
        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        public EditStimulusOrderForm(string order, long interval, Order orderType)
        {
            this.order = order;
            this.orderType = orderType;
            this.interval = interval;
            this.orderArray = new ArrayList();
            this.comboY = 20;
            InitializeComponent();
        }
        public ComboBox createCombo()
        {
            ComboBox cb = new ComboBox();
            cb.DataSource = new BindingSource(this.selectStimulusesBindingSource.DataSource, selectStimulusesBindingSource.DataMember);
            cb.DisplayMember = "name";
            cb.FormattingEnabled = true;
            cb.Location = new System.Drawing.Point(13, comboY);
            cb.Name = "cmbStim";
            cb.Size = new System.Drawing.Size(237, 21);
            cb.TabIndex = 0;
            cb.ValueMember = "id";
            cb.SelectedValue = null;
            return cb;
        }
        private void EditStimulusOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stimDataSet.SelectStimuluses' table. You can move, or remove it, as needed.
            this.selectStimulusesTableAdapter.Fill(this.stimDataSet.SelectStimuluses);
            switch (orderType)
            {
                case Order.Fixed:
                    {
                        if (order != null) order = order.Trim();
                        if (!string.IsNullOrEmpty(order))
                        {
                            string[] tokens = order.Split(',');
                            orderArray = new ArrayList();

                            for (int i = 0; i < tokens.Length; i++)
                            {
                                long id = long.Parse(tokens[i]);
                                ComboBox cb = addCombo();
                                cb.SelectedValue = (long)id;
                            }
                        }
                    }
                    break;
                case Order.Probability:
                    {
                    
                    }
                    break;
            }


            updateLabels();
        }
        public ComboBox addCombo()
        {
            ComboBox cb = createCombo();
            orderArray.Add(cb);
            pnlItems.Controls.Add(cb);
            comboY += cb.Height + 5;
            updateLabels();
            return cb;
        }
        public void updateLabels()
        {
            lblInterval.Text = interval + " ms";
            TimeSpan ts = TimeSpan.FromMilliseconds((double)(interval * orderArray.Count));
            lblLength.Text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3} ", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Result = string.Empty;
            for (int i = 0; i < orderArray.Count; i++)
            {
                ComboBox cb = (ComboBox)orderArray[i];
                long id = (long)cb.SelectedValue;
                Result += id.ToString();
                if (i < orderArray.Count - 1)
                {
                    Result += ",";
                }
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddStimul_Click(object sender, EventArgs e)
        {
            addCombo();
        }
    }
}
