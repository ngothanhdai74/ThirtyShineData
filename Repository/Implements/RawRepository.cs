using Repository.Database.Default;
using Repository.Database.Default.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implements
{
    public class RawRepository
    {
        private static string GetConnectionString(string db = "20190809") => $"Data Source=10.0.2.76;Database={db};User id=ad_30s;Password=VDrs8XHyz3Rdc7PAiv5Q;MultipleActiveResultSets=True;Trusted_Connection=False;connect timeout=100;Max Pool Size=50";
        private static string GetConnectionString(string server = "10.0.2.76", string db = "20190809", string userId = "ad_30s", string password = "VDrs8XHyz3Rdc7PAiv5Q")
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder["Server"] = server;
            stringBuilder["Database"] = db;
            stringBuilder["User Id"] = userId;
            stringBuilder["Password"] = password;
            return stringBuilder.ToString();
        }
        private static string ConnectionString = $"Data Source=10.0.2.76;Database=20190809;User id=ad_30s;Password=VDrs8XHyz3Rdc7PAiv5Q;MultipleActiveResultSets=True;Trusted_Connection=False;connect timeout=100;Max Pool Size=50";
        public static IEnumerable<IvOrder> GetData()
        {
            string sql = @"select top 100 * from IvOrder where Note = @note";
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            using (SqlCommand command = sqlConnection.CreateCommand())
            {
                sqlConnection.Open();
                command.CommandText = sql;
                var param = command.CreateParameter();
                param.ParameterName = "@note";
                param.Value = "Auto Quantify Supplies";
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                command.Parameters.Add(param);
                //---------------------------------------
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    yield return new IvOrder()
                    {
                        Id = reader["Id"].Cast<int>(),
                        ReceivedDate = reader["receivedDate"].CastNullable<DateTime>(),
                        CreatedDate = reader["CreatedDate"].CastNullable<DateTime>()
                    };
                }
            }
        }
    }
}
