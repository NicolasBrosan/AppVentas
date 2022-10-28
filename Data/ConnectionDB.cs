using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace Data
{
    public class ConnectionDB
    {
        private string connection;
        public string CConnection(string DB)
        {
            connection = ConfigurationManager.ConnectionStrings[DB].ConnectionString;
            return connection;
        }
        
    }
}
