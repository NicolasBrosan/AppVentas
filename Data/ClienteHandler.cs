using Data.Interface;
using Domain.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class ClienteHandler : ICrud<Cliente>
    {
        ConnectionDB cnn = new ConnectionDB();
        public void Insert(Cliente cliente)
        {
            using(SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var query = "INSERT INTO Cliente (Nombre, Apellido, Telefono, Direccion, Localidad, Provincia, Tarjeta) " +
                        "VALUES (@nombre, @apellido, @telefono, @direccion, @localidad, @provincia, @tarjeta)";
                    SqlParameter nombre = new SqlParameter("Nombre", System.Data.SqlDbType.VarChar) { Value = cliente.Nombre };
                    SqlParameter apellido = new SqlParameter("Apellido", System.Data.SqlDbType.VarChar) { Value = cliente.Apellido };
                    SqlParameter telefono = new SqlParameter("Telefono", System.Data.SqlDbType.Int) { Value = cliente.Telefono };
                    SqlParameter direccion = new SqlParameter("Direccion", System.Data.SqlDbType.VarChar) { Value = cliente.Direccion };
                    SqlParameter localidad = new SqlParameter("Localidad", System.Data.SqlDbType.VarChar) { Value = cliente.Localidad };
                    SqlParameter provincia = new SqlParameter("Provincia", System.Data.SqlDbType.VarChar) { Value = cliente.Provincia };
                    SqlParameter tarjeta = new SqlParameter("Tarjeta", System.Data.SqlDbType.BigInt) { Value = cliente.Tarjeta };

                    conexion.Open();
                    using(SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(nombre);
                        cmd.Parameters.Add(apellido);
                        cmd.Parameters.Add(telefono);
                        cmd.Parameters.Add(direccion);
                        cmd.Parameters.Add(localidad);
                        cmd.Parameters.Add(provincia);
                        cmd.Parameters.Add(tarjeta);

                        int numberOfRows = cmd.ExecuteNonQuery();
                    }

                    conexion.Close();
                }
                catch (Exception)                                  
                {
                    Console.WriteLine("No se pudo insertar los datos");
                }
            }
        }

        public void Update(Cliente cliente)
        {
           using(SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryUpCliente = "UPDATE [DB_VentaLibros].[dbo].[Cliente] SET Nombre = @nombre, Apellido = @apellido, Telefono = @telefono, Direccion = @direccion, Localidad = @localidad, Provincia = @provincia, Tarjeta = @tarjeta " +
                        "WHERE Id = @id";

                    SqlParameter nombre = new SqlParameter("nombre", System.Data.SqlDbType.VarChar) { Value = cliente.Nombre };
                    SqlParameter apellido = new SqlParameter("apellido", System.Data.SqlDbType.VarChar) { Value = cliente.Apellido };
                    SqlParameter telefono = new SqlParameter("telefono", System.Data.SqlDbType.Int) { Value = cliente.Telefono };
                    SqlParameter direccion = new SqlParameter("direccion", System.Data.SqlDbType.VarChar) { Value = cliente.Direccion };
                    SqlParameter localidad = new SqlParameter("localidad", System.Data.SqlDbType.VarChar) { Value = cliente.Localidad };
                    SqlParameter provincia = new SqlParameter("provincia", System.Data.SqlDbType.VarChar) { Value = cliente.Provincia };
                    SqlParameter tarjeta = new SqlParameter("tarjeta", System.Data.SqlDbType.BigInt) { Value = cliente.Tarjeta };
                    SqlParameter id = new SqlParameter("id", System.Data.SqlDbType.Int) { Value = cliente.Id };

                    conexion.Open();
                    using(SqlCommand cmd = new SqlCommand(queryUpCliente, conexion))
                    {
                        cmd.Parameters.Add(nombre);
                        cmd.Parameters.Add(apellido);
                        cmd.Parameters.Add(telefono);
                        cmd.Parameters.Add(direccion);
                        cmd.Parameters.Add(localidad);
                        cmd.Parameters.Add(provincia);
                        cmd.Parameters.Add(tarjeta);
                        cmd.Parameters.Add(id);

                        int numberOfRows = cmd.ExecuteNonQuery();
                    }

                    conexion.Close();

                }
                catch (Exception)
                {
                    Console.WriteLine("No se pudo actualizar");
                }
            }
        }

        public void Delete(int id)
        {
            using(SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryDelCliente = "DELETE FROM Cliente WHERE Id = @id";
                    SqlParameter sqlParameter = new SqlParameter("id", System.Data.SqlDbType.BigInt);
                    sqlParameter.Value = id;

                    conexion.Open();

                    using(SqlCommand cmd = new SqlCommand(queryDelCliente, conexion))
                    {
                        cmd.Parameters.Add(sqlParameter);
                        int NumberOfRows = cmd.ExecuteNonQuery();
                    }

                    conexion.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("No se pudo eliminar el cliente");                    
                }
            }
        }

        public List<Cliente> Get(string nombre, string apellido)
        {
            using(SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryGetCliente = "SELECT * FROM Cliente WHERE Nombre = @nombre AND Apellido = @apellido";
                    
                    using(SqlCommand cmd = new SqlCommand(queryGetCliente, conexion))
                    {
                        conexion.Open();

                        cmd.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = nombre});
                        cmd.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = apellido});
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                Cliente cliente = new Cliente();
                                while (reader.Read())
                                {
                                    cliente.Id = Convert.ToInt32(reader["Id"]);
                                    cliente.Nombre = reader["Nombre"].ToString();
                                    cliente.Apellido = reader["Apellido"].ToString();
                                    cliente.Telefono = Convert.ToInt32(reader["Telefono"]);
                                    cliente.Direccion = reader["Direccion"].ToString();
                                    cliente.Localidad = reader["Localidad"].ToString();
                                    cliente.Provincia = reader["Provincia"].ToString();
                                    cliente.Tarjeta = Convert.ToInt32(reader["Tarjeta"]);
                                }
                                return cliente;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                                        
                }
            }
        }
    }
}
