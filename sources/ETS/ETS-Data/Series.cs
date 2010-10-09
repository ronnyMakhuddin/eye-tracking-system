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
        private ArrayList stimulusArray;

        public ArrayList StimulusArray
        {
            get { return stimulusArray; }
            set { stimulusArray = value; }
        }
        private long minIntervalBetweenStimulus;

        public long MinIntervalBetweenStimulus
        {
            get { return minIntervalBetweenStimulus; }
            set { minIntervalBetweenStimulus = value; }
        }
        private long maxIntervalBetweenStmulus;

        public long MaxIntervalBetweenStmulus
        {
            get { return maxIntervalBetweenStmulus; }
            set { maxIntervalBetweenStmulus = value; }
        }
        private Order orderType;

        public Order OrderType
        {
            get { return orderType; }
            set { orderType = value; }
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
        private ArrayList recordsArray;
        [XmlArrayItem]
        public ArrayList RecordsArray
        {
            get { return recordsArray; }
            set { recordsArray = value; }
        }
        [XmlIgnore]
        public ArrayList FramesArray
        {
            get { return null; }
            
        }

        private int frameBeforeLength;

        public int FrameBeforeLength
        {
            get { return frameBeforeLength; }
            set { frameBeforeLength = value; }
        }
        private int frameAfterLength;

        public int FrameAfterLength
        {
            get { return frameAfterLength; }
            set { frameAfterLength = value; }
        }

        private string videoFileName;

        public string VideoFileName
        {
            get { return videoFileName; }
            set { videoFileName = value; }
        }
        public Series()
        {
            StimulusArray = new ArrayList();
            MinIntervalBetweenStimulus = 0L;
            MaxIntervalBetweenStmulus = 0L;
            OrderType = Order.Fixed;
            TextAfter = string.Empty;
            TextBefore = string.Empty;
            RecordsArray = new ArrayList();
        }
        public void Save(string filename)
        {
            using (Stream stream = File.Open(filename, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Series));
                formatter.Serialize(stream, this);
            }
        }

    }
}
