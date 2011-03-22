using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace ETS_Data
{
    public class Series
    {
        private string name;
        private int seriesConfigId;

        public int SeriesConfigId
        {
            get { return seriesConfigId; }
            set { seriesConfigId = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        

    }
}
