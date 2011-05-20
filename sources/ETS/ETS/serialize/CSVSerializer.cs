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
        public static void SaveSeria(ETS_Data.Series series, FileStream stream)
        {
            using (StreamWriter sr = new StreamWriter(stream))
            {
                for (int i = 0; i < series.Templates.Count; i++)
                {
                    Template t = (Template)series.Templates[i];
                    sr.WriteLine("Template;"+t.Name);
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
