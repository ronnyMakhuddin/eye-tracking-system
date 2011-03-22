using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETS_Data
{
    public class SeriesConfig
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int maxInt;

        public int MaxInt
        {
            get { return maxInt; }
            set { maxInt = value; }
        }
        private int minInt;

        public int MinInt
        {
            get { return minInt; }
            set { minInt = value; }
        }
        private int orderTypeId;

        public int OrderTypeId
        {
            get { return orderTypeId; }
            set { orderTypeId = value; }
        }
        private string textBefore;

        public string TextBefore
        {
            get { return textBefore; }
            set { textBefore = value; }
        }
        private string textAfter;

        public string TextAfter
        {
            get { return textAfter; }
            set { textAfter = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
