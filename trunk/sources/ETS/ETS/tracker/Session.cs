using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using ETS.Properties;
using System.IO;
using ETS_Data;

namespace ETS.tracker
{
    public class Session
    {

        private Trial currentTrial;
        public Trial CurrentTrial
        {
            get { return currentTrial; }
            set { currentTrial = value; }
        }
        private long currentSeriaId;

        public long CurrentSeriaId
        {
            get { return currentSeriaId; }
            set { currentSeriaId = value; }
        }
        public Series CurrentSeria
        {
            get {
                Series seria = null;
                foreach (Series s in CurrentTrial.Series)
                {
                    if (s.Id == CurrentSeriaId)
                    {
                        seria = s;
                        break;
                    }
                }
                return seria;
            
            }
        }
        private static Session instance;
        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }
        
    }
}
