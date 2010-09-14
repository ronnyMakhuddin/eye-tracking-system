using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using ETS.Properties;
using System.IO;

namespace ETS.tracker
{
    public class Session
    {
        private int currentTrialIndex;

        public int CurrentTrialIndex
        {
            get { return currentTrialIndex; }
            set { currentTrialIndex = value; }
        }


        public Trial CurrentTrial
        {
            get { return Trials != null && Trials.Count != 0 ? (Trial)Trials[currentTrialIndex] : null; }
        }

        private ArrayList trials;

        public ArrayList Trials
        {
            get { return trials; }
            set { trials = value; }
        }

        private static Session instance;
        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }
        private string name;

        public string Name
        {
            get { return string.IsNullOrEmpty(name) ? Resources.UNTITLED : name; }
            set { name = value; }
        }

        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        private bool modified;

        public bool Modified
        {
            get {
                bool trialModified = false;
                foreach (Trial t in Trials)
                {
                    if (t.Modified)
                    {
                        trialModified = true;
                        break;
                    }
                }
                return trialModified || modified;
            }
            set
            {
                modified = value;
                if (value == false)
                {
                    foreach (Trial t in Trials)
                    {
                        t.Modified = value;
                    }
                }
            }
        }
        public bool WasSaved
        {
            get { return !string.IsNullOrEmpty(FileName) && File.Exists(FileName) ; }
        }


        public Session()
        {
            Trials = new ArrayList();
            Trial trial = new Trial();
            Trials.Add(trial);
            currentTrialIndex = 0;
        }


        internal void Save(System.IO.StreamWriter sw)
        {
            sw.WriteLine(Name);
            sw.WriteLine(currentTrialIndex);
            sw.WriteLine(Trials.Count);
            foreach (Trial t in Trials)
            {
                sw.WriteLine(t.FileName);
            }
            Modified = false;
        }
        public void Load(StreamReader sr)
        {
            Name = sr.ReadLine();
            CurrentTrialIndex = int.Parse(sr.ReadLine());
            int count = int.Parse(sr.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string fileName = sr.ReadLine();
                Trial t = new Trial();
                using (StreamReader sri = new StreamReader(fileName))
                {
                    t.Load(sri,fileName);
                }
                Trials.Add(t);
            }
        }

        internal void Clear()
        {
            Trials = new ArrayList();
            Name = string.Empty;
        }
    }
}
