using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using ETS.Properties;
using System.IO;

namespace ETS.tracker
{
    public class Trial
    {
        private static Trial instance;
        public static Trial Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Trial();
                }
                return instance;
            }
        }
        public Trial()
        {
            interval = 100;
            templates = new ArrayList();
            Modified = true;
        }

        private long interval;

        public long Interval
        {
            get { return interval; }
            set { interval = value; }
        }
        private ArrayList templates;

        public ArrayList Templates
        {
            get { return templates; }
            set { templates = value; }
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
            get { return modified; }
            set { modified = value; }
        }
        public bool WasSaved
        {
            get { return !string.IsNullOrEmpty(FileName) && File.Exists(FileName); }
        }

        public void AddTemplate(Template t)
        {
            templates.Add(t);
            Modified = true;
        }
        public Template GetLastTemplate()
        {
            return (Template)templates[templates.Count - 1];
        }
        public void RemoveLastTemplate()
        {
            templates.RemoveAt(templates.Count - 1);
        }
        public void SetLastTemplate(Template r)
        {
            templates[templates.Count - 1] = r;
        }
        public void ClearTemplates()
        {
            templates.Clear();
        }

        internal void Save(System.IO.StreamWriter sw, string fileName)
        {
            sw.WriteLine(Name);
            sw.WriteLine(Interval);
            sw.WriteLine(Templates.Count);
            foreach (Template t in Templates)
            {
                t.Save(sw,fileName);
            }
            Modified = false;
        }
        public void Load(System.IO.StreamReader sr, string fileName) 
        {
            Name = sr.ReadLine();
            Interval = long.Parse(sr.ReadLine());
            int count = int.Parse(sr.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Template t = new Template();
                t.Load(sr,fileName);
                Templates.Add(t);
            }
            Modified = false;
        }
    }
}
