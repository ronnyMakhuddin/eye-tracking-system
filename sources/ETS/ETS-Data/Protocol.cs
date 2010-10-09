using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Xml.Serialization;

namespace ETS_Data
{
    public class Protocol
    {
        [XmlElement (typeof(Patient))]
        private Patient patientInfo;

        public Patient PatientInfo
        {
            get { return patientInfo; }
            set { patientInfo = value; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private ArrayList seriesArray;
        [XmlArrayItem (typeof(Series))]
        public ArrayList SeriesArray
        {
            get { return seriesArray; }
            set { seriesArray = value; }
        }

        private long timeInterval;

        public long TimeInterval
        {
            get { return timeInterval; }
            set { timeInterval = value; }
        }
        public Protocol()
        {
            Date = DateTime.Now;
            TimeInterval = 100L;
            SeriesArray = new ArrayList();
        }
        public void AddSeries(Series series)
        {
            SeriesArray.Add(series);
        }
        public Series GetSeries(int index)
        {
            if (index > SeriesArray.Count)
            {
                return null;
            }
            return (Series)SeriesArray[index];
        }

        public void Save(string filename)
        {
            using(Stream stream = File.Open(filename, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Protocol));
                formatter.Serialize(stream, this);
            }
         }

        public static Protocol Load(string filename)
        {
            Protocol result = null;
            using (Stream stream = File.Open(filename, FileMode.Open))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Protocol));
                result = (Protocol)formatter.Deserialize(stream);
            }
            return result;
        }
    }
}
