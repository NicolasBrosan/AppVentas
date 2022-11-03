using System;
using System.Collections.Generic;
using System.Text;
using Data.Interface;
using System.Data.SqlClient;
using System.Configuration;
using Domain.Autenticacion;
using System.Data;

namespace Data
{
    public class UsuarioHandler
    {
        ConnectionDB cnn = new ConnectionDB();
        public void RegistrarUsuario (Usuario usuario)
        {
            using(SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryInsertUsuario = "INSERT INTO Usuario (Password, Mail, IdCliente) VALUES (@password, @mail, @idCliente)";
                    var password = new SqlParameter("Password", System.Data.SqlDbType.VarChar) { Value = usuario.Password };
                    var mail = new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail };
                    var idCliente = new SqlParameter("IdCliente", System.Data.SqlDbType.Int) { Value = usuario.IdCliente };

                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(queryInsertUsuario, conexion))
                    {
                        cmd.Parameters.Add(password);
                        cmd.Parameters.Add(mail);
                        cmd.Parameters.Add(idCliente);

                        int numberOfRows = cmd.ExecuteNonQuery();
                    }

                    conexion.Close();

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            
        } 


    }
}
