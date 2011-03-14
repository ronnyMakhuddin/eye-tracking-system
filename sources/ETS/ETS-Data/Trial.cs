using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace ETS_Data
{
    public class Trial
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private int patientId;

        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private String videoFileName;

        public String VideoFileName
        {
            get { return videoFileName; }
            set { videoFileName = value; }
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
            return result;
        }
    }
}
