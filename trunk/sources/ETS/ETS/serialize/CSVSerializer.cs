using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ETS.tracker;
using System.Collections;
using ETS_Data;

namespace ETS.serialize
{
    public class CSVSerializer
    {
        public static void SerializeStimulus(Stimulus s, StreamWriter sr)
        {
            sr.WriteLine(s.Name + ";" + s.Filename + ";" + s.StringType+";");
        }
        public static void SaveSeria(ETS_Data.Series series, FileStream stream)
        {
            
            using (StreamWriter sr = new StreamWriter(stream))
            {
                //Name
                sr.WriteLine("Seria name;" + series.Name+";");
                //Config
                SeriesConfig config = series.Config;
                sr.WriteLine("Config;");
                sr.WriteLine("Name;" + config.Name+";");
                sr.WriteLine("Max interval;" + config.MaxInt + ";");
                sr.WriteLine("Min interval;" + config.MinInt + ";");
                sr.WriteLine("Order type;" + config.StringOrderType + ";");
                sr.WriteLine("Text before;" + config.TextBefore + ";");
                sr.WriteLine("Text after;" + config.TextAfter + ";");
                //Stimuluses
                sr.WriteLine("Stimuluses set;");
                sr.WriteLine("Name;Filename;Type;");
                foreach (Stimulus s in series.Config.StimulusSet)
                {
                    SerializeStimulus(s,sr);
                }
                //Templates
                for (int i = 0; i < series.Templates.Count; i++)
                {
                    Template t = (Template)series.Templates[i];
                    sr.WriteLine("Template;"+t.Name+";");
                    ArrayList coords = (ArrayList)series.TemplateCoords[i];
                    sr.Write("Time;");
                    for (int j = 0; j < coords.Count; j++)
                    {
                        SeriesRecord r = (SeriesRecord)coords[j];
                        if (r != null)
                        {
                            sr.Write(Util.MsToStandardTimeRepresentation((int)r.Time)+";");
                        }
                    }
                    sr.WriteLine();
                    sr.Write("X;");
                    for (int j = 0; j < coords.Count; j++)
                    {
                        SeriesRecord r = (SeriesRecord)coords[j];
                        if (r != null)
                        {
                            sr.Write(r.X + ";");
                        }
                    }
                    sr.WriteLine();
                    sr.Write("Y;");
                    for (int j = 0; j < coords.Count; j++)
                    {
                        SeriesRecord r = (SeriesRecord)coords[j];
                        if (r != null)
                        {
                            sr.Write(r.Y + ";");
                        }
                    }
                    sr.WriteLine();
                }
                if (series.TemplateCoords.Count > 0)
                {
                    ArrayList coords = (ArrayList)series.TemplateCoords[0];
                    if (coords.Count > 0)
                    {
                        sr.Write("Stimuluses;");
                      
                        for (int j = 0; j < coords.Count; j++)
                        {
                            SeriesRecord r = (SeriesRecord)coords[j];
                            int time = (int)r.Time;
                            Stimulus s = series.GetStimulusForTime(time);
                            if (s == null)
                            {
                                sr.Write(";");
                            }
                            else
                            {
                                sr.Write(s.Name + ";");
                            }
                        }
                    
                    }
                }
                    
            }
            try
            {
                stream.Close();
            }
            catch (Exception e)
            {

            }
        }   
    }
}
