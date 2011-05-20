using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
using ETS.tracker;

namespace ETS_Data
{
    public class Series
    {
        private string name;
        private long id;
        public Series()
        {
            templates = new ArrayList();
        }
        private SeriesConfig config;

        public SeriesConfig Config
        {
            get { return config; }
            set { config = value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private ArrayList templates;

        public ArrayList Templates
        {
            get { return templates; }
            set { templates = value; }
        }

        

        public void AddTemplate(Template template)
        {
            templates.Add(template);
        }

        public Template GetLastTemplate()
        {
            if (templates.Count > 0)
            {
                return (Template)templates[templates.Count - 1];
            }
            return null;
        }

        public void RemoveLastTemplate()
        {
            templates.RemoveAt(templates.Count - 1);
        }

        public void SetLastTemplate(Template template)
        {
            RemoveLastTemplate();
            AddTemplate(template);
        }
        public Hashtable GetSeriesRecords()
        {
            Hashtable result = new Hashtable();
            foreach (Template t in Templates)
            {
                result.Add(t, t.Coords);
            }
            return result;
        }
        public bool ContainsTemplates
        {
            get {
                return Templates.Count > 0;
            }
        }
        public long Length
        {
            get {
                   return (Config.StimulusSet.Count + 1) * Config.MaxInt;

            }
        }
    }
}
