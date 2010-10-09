using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ETS_Data
{
    public class SeriesFrame
    {
        private int startIndex;

        public int StartIndex
        {
            get { return startIndex; }
            set { startIndex = value; }
        }
        private int endIndex;

        public int EndIndex
        {
            get { return endIndex; }
            set { endIndex = value; }
        }

        private int stimulIndex;

        public int StimulIndex
        {
            get { return stimulIndex; }
            set { stimulIndex = value; }
        }

        public ArrayList RecordsArray
        {
            get { return null; }
            
        }

        private int series;

        public int Series
        {
            get { return series; }
            set { series = value; }
        }
    }
}
