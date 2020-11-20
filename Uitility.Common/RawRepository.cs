using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Uitility.Common
{
    public class BaseRawRepository
    {
        private readonly string ConnectionString;
        public BaseRawRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }
        private string GetConnectionString(string server = "10.0.2.76", string db = "20190809", string userId = "ad_30s", string password = "VDrs8XHyz3Rdc7PAiv5Q")
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder["Server"] = server;
            stringBuilder["Database"] = db;
            stringBuilder["User Id"] = userId;
            stringBuilder["Password"] = password;
            return stringBuilder.ToString();
        }
    }
}
