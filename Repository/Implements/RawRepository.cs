﻿using Repository.Database.Default;
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
            var param = new SqlParameter();
            param.ParameterName = "@note";
            param.Value = "Auto Quantify Supplies";
            param.SqlDbType = System.Data.SqlDbType.NVarChar;

            return Reader(m => new IvOrder()
            {
                Id = m["Id"].Cast<int>(),
                ReceivedDate = m["receivedDate"].CastNullable<DateTime>(),
                CreatedDate = m["CreatedDate"].CastNullable<DateTime>()
            }, sql, param);
        }
        protected static IEnumerable<T> Reader<T>(Func<SqlDataReader, T> func, string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            using (SqlCommand command = sqlConnection.CreateCommand())
            {
                sqlConnection.Open();
                command.CommandText = sql;
                command.Parameters.AddRange(parameters);
                //---------------------------------------
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    yield return func(reader);
                }
            }
        }
        protected static object Scalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            using (SqlCommand command = sqlConnection.CreateCommand())
            {
                sqlConnection.Open();
                command.CommandText = sql;
                command.Parameters.AddRange(parameters);
                //---------------------------------------
                return command.ExecuteScalar();
            }
        }
        protected static int Execute(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            using (SqlCommand command = sqlConnection.CreateCommand())
            {
                sqlConnection.Open();
                command.CommandText = sql;
                command.Parameters.AddRange(parameters);
                //---------------------------------------
                return command.ExecuteNonQuery();
            }
        }
    }
}
