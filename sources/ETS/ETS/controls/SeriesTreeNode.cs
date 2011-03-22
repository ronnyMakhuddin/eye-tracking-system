using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETS_Data;

namespace ETS.controls
{
    public class SeriesTreeNode : TreeNode
    {
        private Series seria;

        public Series Seria
        {
            get { return seria; }
            set { seria = value; }
        }

        public SeriesTreeNode(Series s) : base(s.Name)
        {
            this.seria = s;
        }
    }
}
