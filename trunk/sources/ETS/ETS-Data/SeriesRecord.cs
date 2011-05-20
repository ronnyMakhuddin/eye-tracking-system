using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;

namespace ETS_Data
{
    public class SeriesRecord
    {
        private long time;

        public long Time
        {
            get { return time; }
            set { time = value; }
        }
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public SeriesRecord()
        {
            X = 0;
            Y = 0;
            Time = 0;
        }
        public SeriesRecord(Rectangle r, long time)
        {
            X = r.Right;
            Y = r.Top;
            Time = time;
        }
    }
}
