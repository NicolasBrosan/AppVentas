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
            try
            {
                connection = ConfigurationManager.ConnectionStrings[DB].ConnectionString;
                return connection;

            }
            catch (Exception ex)
            {
                var aviso = $"No se puede conectar a la BD {ex.Message}";
                return aviso;
            }
            
        }

    }
}
