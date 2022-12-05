using Data.Interface;
using Domain.Autenticacion;
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

            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {

                    var query = "INSERT INTO Cliente (Id, Nombre, Apellido, Telefono, Direccion, Localidad, Provincia) " +
                        "VALUES (@id, @nombre, @apellido, @telefono, @direccion, @localidad, @provincia)";

                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", cliente.Id);
                        cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                        cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                        cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                        cmd.Parameters.AddWithValue("@localidad", cliente.Localidad);
                        cmd.Parameters.AddWithValue("@provincia", cliente.Provincia);

                        cmd.ExecuteNonQuery();
                    }

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No se pudo insertar los datos: {ex.Message}");
                }
            }
        }

        public bool Update(Cliente cliente)
        {
            var resultado = false;
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryUpCliente = "UPDATE [DB_VentaLibros].[dbo].[Cliente] SET Nombre = @nombre, Apellido = @apellido, Telefono = @telefono, Direccion = @direccion, Localidad = @localidad, Provincia = @provincia " +
                        "WHERE Id = @id";

                    SqlParameter nombre = new SqlParameter("nombre", System.Data.SqlDbType.VarChar) { Value = cliente.Nombre };
                    SqlParameter apellido = new SqlParameter("apellido", System.Data.SqlDbType.VarChar) { Value = cliente.Apellido };
                    SqlParameter telefono = new SqlParameter("telefono", System.Data.SqlDbType.Int) { Value = cliente.Telefono };
                    SqlParameter direccion = new SqlParameter("direccion", System.Data.SqlDbType.VarChar) { Value = cliente.Direccion };
                    SqlParameter localidad = new SqlParameter("localidad", System.Data.SqlDbType.VarChar) { Value = cliente.Localidad };
                    SqlParameter provincia = new SqlParameter("provincia", System.Data.SqlDbType.VarChar) { Value = cliente.Provincia };
                    SqlParameter id = new SqlParameter("id", System.Data.SqlDbType.Int) { Value = cliente.Id };

                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(queryUpCliente, conexion))
                    {
                        cmd.Parameters.Add(nombre);
                        cmd.Parameters.Add(apellido);
                        cmd.Parameters.Add(telefono);
                        cmd.Parameters.Add(direccion);
                        cmd.Parameters.Add(localidad);
                        cmd.Parameters.Add(provincia);
                        cmd.Parameters.Add(id);

                        int numberOfRows = cmd.ExecuteNonQuery();
                        if (numberOfRows > 0)
                        {
                            resultado = true;
                        }
                    }

                    conexion.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No se pudo actualizar: {ex.Message}");
                }
            }
            return resultado;
        }

        public void Delete(Cliente id)
        {
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryDelCliente = "DELETE FROM Cliente WHERE Id = @id";
                    SqlParameter sqlParameter = new SqlParameter("id", System.Data.SqlDbType.BigInt);
                    sqlParameter.Value = id;

                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(queryDelCliente, conexion))
                    {
                        cmd.Parameters.Add(sqlParameter);
                        int NumberOfRows = cmd.ExecuteNonQuery();
                    }

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No se pudo eliminar el cliente: {ex.Message}");
                }
            }
        }

        public List<Cliente> Get()
        {
            var clientes = new List<Cliente>();

            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryGetCliente = "SELECT * FROM Cliente";

                    using (SqlCommand cmd = new SqlCommand(queryGetCliente, conexion))
                    {
                        conexion.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {

                                while (reader.Read())
                                {
                                    var cliente = new Cliente();
                                    cliente.Id = Guid.Parse(reader["Id"].ToString());
                                    cliente.Nombre = reader["Nombre"].ToString();
                                    cliente.Apellido = reader["Apellido"].ToString();
                                    cliente.Telefono = Convert.ToInt32(reader["Telefono"]);
                                    cliente.Direccion = reader["Direccion"].ToString();
                                    cliente.Localidad = reader["Localidad"].ToString();
                                    cliente.Provincia = reader["Provincia"].ToString();

                                    clientes.Add(cliente);
                                }
                            }

                        }
                        conexion.Close();

                        return clientes;
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
