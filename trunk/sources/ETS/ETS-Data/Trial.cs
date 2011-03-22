using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using ETS_Data.Properties;

namespace ETS_Data
{
    public class Trial
    {
        private bool saved;

        public bool Saved
        {
            get { return saved; }
            set { saved = value; }
        }
        
        private int id;

        public int Id
        {
            get { return id; }
            set { 
                id = value;
                Saved = false;
            }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; Saved = false; }
        }
        private int patientId;

        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; Saved = false; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; Saved = false; }
        }
        private String videoFileName;

        public String VideoFileName
        {
            get { return videoFileName; }
            set { videoFileName = value; Saved = false; }
        }

        private ArrayList series;

        public ArrayList Series
        {
            get { return series; }
            set { series = value; }
        }
        
        public Trial()
        {
        }

        public static Trial Load(DataGridViewRow dr)
        {
            if (dr == null)
            {
                return null;
            }
            Trial result = new Trial();
            result.Id = Convert.ToInt32(dr.Cells["clmId"].Value);
            result.Name = (string)dr.Cells["clmTrialName"].Value;
            result.PatientId = Convert.ToInt32(dr.Cells["clmPatientId"].Value);
            result.VideoFileName = (string)dr.Cells["clmVideoFileName"].Value;
            result.Date = Convert.ToDateTime(dr.Cells["clmDate"].Value);
            result.Saved = true;
            //TODO : add series population
            result.series = SqlUtils.SelectSeries(result.Id, Settings.Default.DBConnectionString);
            return result;
        }
        public void Save()
        {
            Saved = true;
        }
    }
}
