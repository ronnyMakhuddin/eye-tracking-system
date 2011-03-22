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
        public static void InsertSeries(string name, object id, string dbConnectionString)
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
                    param1.Value = id;
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
                            s.SeriesConfigId = reader.GetInt64(1);
                            s.Name = reader.GetString(2);
                            result.Add(s);
                        }
                    }
                    
                }
            }
            return result;
        }
     
    }
}
