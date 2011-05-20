using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using ETS_Data.Properties;
using ETS.tracker;
using System.Drawing;

namespace ETS_Data
{
   public class SqlUtils
    {
       public static string OpenFirstConnection()
       {
           using (SqlConnection connection = new SqlConnection(Settings.Default.DBConnectionString))
           {
               try
               {
                   connection.Open();
                   return "Established";
               }
               catch (Exception e)
               {
                   return "Error: "+e.Message;
               }
           }
       }
        public static void InsertSeries(string name, object seriesConfigId, int trialId, string dbConnectionString)
        {
            using (SqlConnection connection = new SqlConnection(dbConnectionString))
            {
                connection.Open();
                using (SqlCommand insert = new SqlCommand())
                {
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.CommandText = "InsertSeries";
                    insert.Connection = connection;
                    SqlParameter param = insert.Parameters.Add("@name", SqlDbType.VarChar, 100);
                    param.Value = name;
                    SqlParameter param1 = insert.Parameters.Add("@seriesConfigId", SqlDbType.BigInt, 1);
                    param1.Value = seriesConfigId;
                    SqlParameter param2 = insert.Parameters.Add("@trialId", SqlDbType.BigInt, 1);
                    param2.Value = trialId;
                    int rows = insert.ExecuteNonQuery();
                }
            }
        }
        public static ArrayList SelectSeries(int trialId, string dbConnectionString)
        {
            ArrayList result = new ArrayList();
            using (SqlConnection connection = new SqlConnection(dbConnectionString))
            {
                connection.Open();
                using (SqlCommand select = new SqlCommand())
                {
                    select.CommandType = CommandType.StoredProcedure;
                    select.CommandText = "SelectSeriesForTrial";
                    select.Connection = connection;

                    SqlParameter param = select.Parameters.Add("@id", SqlDbType.BigInt, 1);
                    param.Value = trialId;

                    using (SqlDataReader reader = select.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Series s = new Series();
                            s.Id = reader.GetInt64(0);
                            long seriesConfigId = reader.GetInt64(1);
                            s.Config = SelectSeriesConfig(seriesConfigId, dbConnectionString);
                            s.Name = reader.GetString(2);
                            ArrayList templates = GetTemplates(s.Id, dbConnectionString);
                            for (int i = 0; i < templates.Count; i++)
                            {
                                Template t = (Template)templates[i];
                                s.SetLastTemplate(t);
                                s.AddTemplateCoordArray();
                            }
                           
                            for (int i = 0; i < s.Templates.Count; i++)
                            {
                                Template t = (Template)s.Templates[i];
                                ArrayList coords = GetRecords(s.Id, t.Id, dbConnectionString);
                                for (int j = 0; j < coords.Count; j++)
                                {
                                    SeriesRecord sr = (SeriesRecord)coords[j];
                                    s.SetTemplateCoord(i, sr, (int)sr.Time);
                                }
                               
                            }
                            result.Add(s);
                        }
                    }
                    
                }
            }
            return result;
        }
        public static ArrayList SelectStimulusSet(long seriesConfigId, string dbConnectionString)
        {
            ArrayList result = new ArrayList();
            using (SqlConnection connection = new SqlConnection(dbConnectionString))
            {
                connection.Open();
                using (SqlCommand select = new SqlCommand())
                {
                    select.CommandType = CommandType.StoredProcedure;
                    select.CommandText = "SelectFullStimulusSetForSeriesConfig";
                    select.Connection = connection;

                    SqlParameter param = select.Parameters.Add("@series_config_id", SqlDbType.BigInt, 1);
                    param.Value = seriesConfigId;

                    using (SqlDataReader reader = select.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Stimulus s = new Stimulus();
                            int i = 0;
                            s.Id = reader.GetInt64(0);
                            s.Name = reader.GetString(1);
                            s.Filename = reader.GetString(2);
                            s.Type = (StimulusType)reader.GetInt64(3);
                            s.Prob = reader.GetDouble(4);
                            reader.GetInt64(5);
                            s.Pos = (Position)reader.GetInt64(6);
                            /*
                             Stimulus.id, Stimulus.name, Stimulus.filename, Stimulus.type, Stimulus.prob,  SeriesStimulus.series_config_id
                             */
                            result.Add(s);
                        }
                    }

                }
            }
            return result;
        }
        public static SeriesConfig SelectSeriesConfig(long id, string dbConnectionString)
        {
            SeriesConfig c = new SeriesConfig();
            using (SqlConnection connection = new SqlConnection(dbConnectionString))
            {
                connection.Open();
                using (SqlCommand select = new SqlCommand())
                {
                    select.CommandType = CommandType.StoredProcedure;
                    select.CommandText = "SelectSeriesConfigForId";
                    select.Connection = connection;

                    SqlParameter param = select.Parameters.Add("@id", SqlDbType.BigInt, 1);
                    param.Value = id;

                    using (SqlDataReader reader = select.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                          
                            c.Id = reader.GetInt64(0);
                            c.MaxInt = reader.GetInt64(1);
                            c.MinInt = reader.GetInt64(2);
                            c.TextBefore = reader.GetString(3);
                            c.TextAfter = reader.GetString(4);
                            c.OrderTypeId = reader.GetInt64(5);
                            c.Name = reader.GetString(6);
                            string order = reader.GetString(8);
                            string[] strIds = order.Split(',');
                            c.StimulusOrder = new ArrayList();
                            for (int i = 0; i < strIds.Length; i++)
                            {
                                c.StimulusOrder.Add(long.Parse(strIds[i]));
                            }
                            c.StimulusSet = SelectStimulusSet(c.Id, dbConnectionString);
                        }
                    }

                }
            }
            
            return c;
        }

        public static void SaveSeries(Series series, string dbConnectionString)
        {
            for (int i = 0; i < series.Templates.Count; i++)
            {
                Template t = (Template)series.Templates[i];
                long id =  SaveTemplate(series, t, dbConnectionString);
                t.Id = id;
            }
            for (int i = 0; i < series.TemplateCoords.Count; i++)
            {
                ArrayList coords = (ArrayList)series.TemplateCoords[i];
                Template t = (Template)series.Templates[i];
                for (int j = 0; j < coords.Count; j++)
                {
                    SeriesRecord r = (SeriesRecord)coords[j];
                    SaveRecord(r, dbConnectionString, series, t.Id);
                }
            }
           
        }


        public static ArrayList GetRecords(long seria_id, long template_id, string dbConnectionString)
        {
            ArrayList result = new ArrayList();
            using (SqlConnection connection = new SqlConnection(dbConnectionString))
            {
                connection.Open();
                using (SqlCommand select = new SqlCommand())
                {
                    select.CommandType = CommandType.StoredProcedure;
                    select.CommandText = "SelectRecordsForSeriaAndTemplate";
                    select.Connection = connection;

                 
                    SqlParameter pId = select.Parameters.Add("@seria_id", SqlDbType.BigInt, 1);
                    pId.Value = seria_id;
                    SqlParameter pTemplateId = select.Parameters.Add("@template_id", SqlDbType.BigInt, 1);
                    pTemplateId.Value = template_id;
                  
                    using (SqlDataReader reader = select.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SeriesRecord sr = new SeriesRecord();
                            sr.X = (int)reader.GetInt64(0);
                            sr.Y = (int)reader.GetInt64(1);
                            sr.Time = (int)reader.GetInt64(2);
                            result.Add(sr);
                        }
                    }


                }
            }

            return result;
        }

        private static void SaveRecord(SeriesRecord r, string dbConnectionString, Series series, long templateId)
        {
            if (r == null)
            {
                return;
            }
            using (SqlConnection connection = new SqlConnection(dbConnectionString))
            {
                connection.Open();
                using (SqlCommand insert = new SqlCommand())
                {
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.CommandText = "InsertSeriesRecord";
                    insert.Connection = connection;
                    /*INSERT INTO SeriesRecords (time, x, y, template_id, series_id) VALUES (@time, @x,  @y, @template_id, @series_id);**/

                    SqlParameter param = insert.Parameters.Add("@time", SqlDbType.BigInt, 1);
                    param.Value = r.Time;
                    SqlParameter param1 = insert.Parameters.Add("@x", SqlDbType.BigInt, 1);
                    param1.Value = r.X;
                    SqlParameter param2 = insert.Parameters.Add("@y", SqlDbType.BigInt, 1);
                    param2.Value = r.Y;
                    SqlParameter param3 = insert.Parameters.Add("@template_id", SqlDbType.BigInt, 1);
                    param3.Value = templateId;
                    SqlParameter param4 = insert.Parameters.Add("@series_id", SqlDbType.BigInt, 1);
                    param4.Value = series.Id;

                    insert.ExecuteNonQuery();
                }
            }
        }
        private static ArrayList GetTemplates(long seriaId, string dbConnectionString)
        {
            ArrayList result = new ArrayList();
            using (SqlConnection connection = new SqlConnection(dbConnectionString))
            {
                connection.Open();
                using (SqlCommand select = new SqlCommand())
                {
                    select.CommandType = CommandType.StoredProcedure;
                    select.CommandText = "SelectTemplatesForSeria";
                    select.Connection = connection;
                    SqlParameter pId = select.Parameters.Add("@seria_id", SqlDbType.BigInt, 1);
                    pId.Value = seriaId;
                    /*
                     SELECT x,y,width,height,name,picture, id FROM Templates WHERE seria_id = @seria_id;
                     */
                    using (SqlDataReader reader = select.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rectangle r = new Rectangle();
                            r.X = reader.GetInt32(0);
                            r.Y = reader.GetInt32(1);
                            r.Width = reader.GetInt32(2);
                            r.Height = reader.GetInt32(3);
                            string name = reader.GetString(4);
                            byte[] picture = reader.GetSqlBinary(5).Value;
                            long id = reader.GetInt64(6);
                            Emgu.CV.Image<Emgu.CV.Structure.Gray,byte> image = new Emgu.CV.Image<Emgu.CV.Structure.Gray,byte>(r.Width,r.Height);
                            image.Bytes = picture;

                            Template t = new Template(r, image);
                            t.Name = name;
                            t.Added = true;
                            t.Id = id;
                            result.Add(t);
                        }
                    }
                }
            }
            return result;

        }
        private static long SaveTemplate(Series series,Template t, string dbConnectionString)
        {
            using (SqlConnection connection = new SqlConnection(dbConnectionString))
            {
                connection.Open();
                using (SqlCommand insert = new SqlCommand())
                {
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.CommandText = "InsertTemplate";
                    insert.Connection = connection;

                    /*INSERT INTO [Templates] (picture, name, x, y, widht, height, seria_id) VALUES (@picture, dob.TRIM(@name), @x, @y, @width, @height, @seria_id);*/

                    SqlParameter pPicture = insert.Parameters.Add("@picture", SqlDbType.VarBinary);
                    pPicture.Value = t.Tpl.Bytes;
                    SqlParameter pName = insert.Parameters.Add("@name", SqlDbType.VarChar, 50);
                    pName.Value = t.Name;
                    SqlParameter pX = insert.Parameters.Add("@x", SqlDbType.Int, 1);
                    pX.Value = t.Rect.X;

                    SqlParameter pY = insert.Parameters.Add("@y", SqlDbType.Int, 1);
                    pY.Value = t.Rect.Y;
                    SqlParameter pWidth = insert.Parameters.Add("@width", SqlDbType.Int, 1);
                    pWidth.Value = t.Rect.Width;
                    SqlParameter pHeight = insert.Parameters.Add("@height", SqlDbType.Int, 1);
                    pHeight.Value = t.Rect.Height;

                    SqlParameter pSeriaId = insert.Parameters.Add("@seria_id", SqlDbType.BigInt, 1);
                    pSeriaId.Value = series.Id;

                    return Int64.Parse(insert.ExecuteScalar().ToString());
                   
                }
            }
        }

      
    }
}
