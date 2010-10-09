using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETS_Data
{
    public class Patient
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private string middlename;

        public string Middlename
        {
            get { return middlename; }
            set { middlename = value; }
        }
        private DateTime dob;

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        private int medicalHistoryNumber;

        public int MedicalHistoryNumber
        {
            get { return medicalHistoryNumber; }
            set { medicalHistoryNumber = value; }
        }
    }
}
