using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace ETS_Data
{
   public class SqlUtils
    {
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
                           //long i =  reader.GetInt64(0);
                            //TODO : add series config population
                            /*
                              SeriesConfig.id, 
	SeriesConfig.max_int, 
	SeriesConfig.min_int, 
	SeriesConfig.text_before, 
	SeriesConfig.text_after,  
	SeriesConfig.order_type_id, 
	SeriesConfig.name, 
	SeriesConfig.length, 
	SeriesConfig.stimulusOrder
                             */
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
                        }
                    }

                }
            }
            
            return c;
        }
    }
}
