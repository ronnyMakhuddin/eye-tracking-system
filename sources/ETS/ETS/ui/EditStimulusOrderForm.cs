using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ETS.ui
{
    public partial class EditStimulusOrderForm : Form
    {
        private ArrayList orderArray;
        private string order;
        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        public EditStimulusOrderForm(string order)
        {
            this.order = order;


            InitializeComponent();
        }
        public ComboBox createCombo(long id, int y)
        {
            ComboBox cb = new ComboBox();
            cb.DataSource = new BindingSource(this.selectStimulusesBindingSource.DataSource, selectStimulusesBindingSource.DataMember);
            cb.DisplayMember = "name";
            cb.FormattingEnabled = true;
            cb.Location = new System.Drawing.Point(13, y);
            cb.Name = "cmbStim";
            cb.Size = new System.Drawing.Size(237, 21);
            cb.TabIndex = 0;
            cb.ValueMember = "id";
          
            return cb;
        }
        private void EditStimulusOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stimDataSet.SelectStimuluses' table. You can move, or remove it, as needed.
            this.selectStimulusesTableAdapter.Fill(this.stimDataSet.SelectStimuluses);
            string[] tokens = order.Split(',');
            orderArray = new ArrayList();
            int y = 20;
            for (int i = 0; i < tokens.Length; i++)
            {
                long id = long.Parse(tokens[i]);
                ComboBox cb = createCombo(id, y);
                orderArray.Add(cb);
                this.Controls.Add(cb);
                cb.SelectedValue = (long)id;
          
                y += cb.Height + 5;
            }
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
    }
}
