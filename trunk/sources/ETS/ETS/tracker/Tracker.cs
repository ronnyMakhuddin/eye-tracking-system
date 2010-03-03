using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV;

namespace ETS.tracker
{
    public class Tracker
    {
        private CaptureManager captureManager;

        public CaptureManager CaptureManager
        {
            get { return captureManager; }
            set { captureManager = value; }
        }

        public Tracker(CaptureManager manager)
        {
            this.captureManager = manager;
        }
    }
   
}
