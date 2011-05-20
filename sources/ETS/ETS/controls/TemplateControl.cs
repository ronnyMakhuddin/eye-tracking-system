using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETS_Data;
using ETS.tracker;

namespace ETS.controls
{
    public partial class TemplateControl : UserControl
    {
        private Series series;
        private Template template;
        public TemplateControl()
        { InitializeComponent(); }
        public TemplateControl(Series series, Template template)
        {
            InitializeComponent();
            this.series = series;
            this.template = template;
            image.Image = template.Tpl;
            grpItems.Text = template.Name;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want delete template and all data recorded for this template?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                series.DeleteTemplate(template);
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
