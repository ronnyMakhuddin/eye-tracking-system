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
        private const int TIME_CHUNK_MS = 40;
        private string name;
        private long id;
        public Series()
        {
            templates = new ArrayList();
            TemplateCoords = new ArrayList();
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

        private ArrayList templateCoords;

        public ArrayList TemplateCoords
        {
            get { return templateCoords; }
            set { templateCoords = value; }
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
            if (templates.Count > 0)
            {
                int index = templates.Count - 1;
                templates.RemoveAt(index);
            }
        }

        public void SetLastTemplate(Template template)
        {
            RemoveLastTemplate();
            AddTemplate(template);
            
        }
        public Hashtable GetSeriesRecords()
        {
            Hashtable result = new Hashtable();
            for(int i=0;i<Templates.Count; i++){
                Template t = (Template)Templates[i];
                ArrayList coords = (ArrayList)TemplateCoords[i];
                result.Add(t,coords);
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
        public void SetTemplateCoord(int templateIndex, SeriesRecord coord, int timePosition)
        {
            ArrayList coords = (ArrayList)TemplateCoords[templateIndex];
            int index = timePosition / TIME_CHUNK_MS;
            if (index < coords.Count)
            {
                coords[index] = coord;
            }
        }
        public void AddTemplateCoordArray()
        {
            int coordsSize = (int)Length / 40;
            ArrayList coords = new ArrayList(coordsSize);
            for (int i = 0; i < coordsSize; i++)
            {
                coords.Add(null);
            }
            TemplateCoords.Add(coords);
        }
    }
}
