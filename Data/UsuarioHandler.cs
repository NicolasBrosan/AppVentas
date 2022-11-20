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
                    
                    conexion.Open();
                    
                    using (SqlCommand cmd = new SqlCommand(queryInsertUsuario, conexion))
                    {
                        cmd.Parameters.AddWithValue("@password", usuario.Password);
                        cmd.Parameters.AddWithValue("@mail", usuario.Mail);
                        cmd.Parameters.AddWithValue("@idCliente", usuario.IdCliente);

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

        public Usuario LoginUsuario(string mail, string password)
        {
           var usuario = new Usuario();
            using(SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {                                           
                try
                {
                    var queryLogin = "SELECT * FROM Usuario WHERE Mail = @mail AND Password = @password";

                    conexion.Open();
                    
                    using(SqlCommand cmdLogin = new SqlCommand(queryLogin, conexion))
                    {
                        cmdLogin.Parameters.Add(new SqlParameter("Mail", System.Data.SqlDbType.VarChar) { Value = mail });
                        cmdLogin.Parameters.Add(new SqlParameter("Password", System.Data.SqlDbType.VarChar) { Value = password });
                        cmdLogin.ExecuteNonQuery();

                        using(SqlDataReader reader = cmdLogin.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    usuario.Id = Convert.ToInt32(reader["Id"]);
                                    usuario.Mail = reader["Mail"].ToString();
                                    usuario.Password = reader["Password"].ToString();
                                }
                            }
                        }
                    }
                    conexion.Close();

                    return usuario;
                }
                catch (Exception)
                {
                    usuario.Mail = "El mail o la contraseña es incorrecta";
                    return usuario;                   
                }
            }
        }

        public List<Usuario> Get()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryGetUsuarios = "SELECT * FROM Usuario";
                    using(SqlCommand cmd = new SqlCommand(queryGetUsuarios, conexion))
                    {
                        conexion.Open();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Usuario usuario = new Usuario();
                                    usuario.Mail = reader["Mail"].ToString();
                                    usuario.Password = reader["Password"].ToString();
                                    usuario.IdCliente = Guid.Parse(reader["IdCliente"].ToString());

                                    usuarios.Add(usuario);
                                }
                            }
                        }
                    }
                    conexion.Close();

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                return usuarios;
            }
        }

       
    }
}
