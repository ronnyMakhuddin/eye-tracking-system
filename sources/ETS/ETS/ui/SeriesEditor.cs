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
    public partial class SeriesEditor : Form
    {
        private ETS_Data.Series series;

        public SeriesEditor()
        {
            InitializeComponent();
        }

        public SeriesEditor(ETS_Data.Series series):base()
        {
            this.series = series;
        }
    }
}
