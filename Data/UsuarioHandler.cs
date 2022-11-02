using System;
using System.Collections.Generic;
using System.Text;
using Data.Interface;
using System.Data.SqlClient;
using System.Configuration;
using Domain.Autenticacion;

namespace Data
{
    public class UsuarioHandler
    {
        ConnectionDB cnn = new ConnectionDB();

        public Usuario InsertForLogin () //Como podria enlazar la info de Cliente con Usuario para hacer el Login??
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
                {
                    var queryData = "";  //¡¡¿?!!
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        } 
    }
}
