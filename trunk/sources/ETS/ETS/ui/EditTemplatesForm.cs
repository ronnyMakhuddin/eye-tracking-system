using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETS_Data;
using ETS.tracker;
using ETS.controls;

namespace ETS.ui
{
    public partial class EditTemplatesForm : Form
    {
        private Series series;
        public EditTemplatesForm(Series s)
        {
            InitializeComponent();
            this.series = s;
            int y = 5;
            for (int i = 0; i < s.Templates.Count; i++)
            {
                Template t = (Template)s.Templates[i];
               
                TemplateControl tc = new TemplateControl(series, t);
                tc.Location = new System.Drawing.Point(3, y);
                tc.Name = "templateControl"+i;
                tc.Size = new System.Drawing.Size(299, 86);
                tc.TabIndex = 0;

                

                panel. Controls.Add(tc);
                y += tc.Size.Height + 5;
            }
        }
    }
}
