using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Security;

namespace Analytics_server.DBAccess
{
    public class DBContext
    {
        private NetworkCredential creds;
        private string connectionString;
        public DBContext()
        {
            creds = new NetworkCredential(Environment.GetEnvironmentVariable("DbUsername"),Environment.GetEnvironmentVariable("DbPassword"));
            
            connectionString = Environment.GetEnvironmentVariable("connString");
            
        }

        

    }
}