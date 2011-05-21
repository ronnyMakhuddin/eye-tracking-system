using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ETS_Data
{
    public class SeriesConfig
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private long maxInt;

        public long MaxInt
        {
            get { return maxInt; }
            set { maxInt = value; }
        }
        private long minInt;

        public long MinInt
        {
            get { return minInt; }
            set { minInt = value; }
        }
        private long orderTypeId;

        public long OrderTypeId
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

        private ArrayList stimulusSet;

        public ArrayList StimulusSet
        {
            get { return stimulusSet; }
            set { stimulusSet = value; }
        }

        private ArrayList stimulusOrder;

        public ArrayList StimulusOrder
        {
            get { return stimulusOrder; }
            set { stimulusOrder = value; }
        }

        public Order OrderType
        {
            get {
                return (Order)orderTypeId;
            }
        }
        public ArrayList SelectedStimulusSet
        {
            get {
                ArrayList result = new ArrayList();
                for (int i = 0; i < stimulusOrder.Count; i++)
                {
                    long id = (long)stimulusOrder[i];
                    Stimulus forId = null;
                    foreach (Stimulus s in stimulusSet)
                    {
                        if (s.Id == id)
                        {
                            forId = s;
                            break;
                        }
                    }
                    if (forId != null)
                    {
                        result.Add(forId);
                    }
                }
                return result;
            }
        }
    }
}
