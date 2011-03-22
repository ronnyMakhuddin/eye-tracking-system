using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETS_Data;

namespace ETS.controls
{
    class TrialTreeNode : TreeNode
    {
        private Trial trial_;

        public Trial Trial
        {
            get { return trial_; }
            set { trial_ = value; }
        }
        public TrialTreeNode(Trial trial) : base(trial.Name)
        {
            this.Trial = trial;
        }
    }
}
