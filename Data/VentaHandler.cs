using Domain.Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class VentaHandler
    {
        ConnectionDB cnn = new ConnectionDB();

        public void InsertVenta(List<Libro> libro, Venta venta)
        {
            var idVentas = 0;
            try
            {
                using(SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
                {
                    var queryVenta = "INSERT INTO Venta (Comentarios, IdUsuario) VALUES (@comentarios, @idUsuario)";

                    SqlParameter comentarios = new SqlParameter("Comentarios", System.Data.SqlDbType.VarChar) { Value = venta.Comentarios };
                    SqlParameter idUsuario = new SqlParameter("IdUsuario", System.Data.SqlDbType.BigInt) { Value = venta.IdUsuario };

                    conexion.Open();

                    using(SqlCommand cmd = new SqlCommand(queryVenta, conexion))
                    {
                        cmd.Parameters.Add(comentarios);
                        cmd.Parameters.Add(idUsuario);

                        int numberOfRows = cmd.ExecuteNonQuery();
                    }

                    //Ordenar desde la primera compra a la ultima. VER SI FUNCIONA ASI
                    var queryIdVenta = "SELECT TOP (1) Id FROM Venta ORDER BY Id Desc ";
                    using(SqlCommand cmdOrderBy = new SqlCommand(queryIdVenta, conexion))
                    {
                        using(SqlDataReader reader = cmdOrderBy.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //var IdVentas = 0;
                                    idVentas = Convert.ToInt32(reader["Id"]);
                                }
                            }
                        }
                    }

                    //Se recorre la lista de Libro para insertar la venta en ProductoVendido
                    foreach(var libroVendido in libro)
                    {
                        var queryLibroVendido = "INSERT INTO ProductoVendido (IdLibro, Stock, IdVenta) VALUES (@idLibro, @stock, @idVenta)";

                        SqlParameter idLibro = new SqlParameter("IdLibro", System.Data.SqlDbType.BigInt) { Value = libroVendido.Id };
                        SqlParameter stock = new SqlParameter("Stock", System.Data.SqlDbType.BigInt) { Value = libroVendido.Stock };
                        SqlParameter idVenta = new SqlParameter("IdVenta", System.Data.SqlDbType.BigInt) { Value = idVentas };

                        using(SqlCommand cmd = new SqlCommand(queryLibroVendido, conexion))
                        {
                            cmd.Parameters.Add(idLibro);
                            cmd.Parameters.Add(stock);
                            cmd.Parameters.Add(idVenta);

                            int numberOfRows = cmd.ExecuteNonQuery();
                        }

                        //Actualizo el stock de Libro
                        var queryUpdateStock = "UPDATE Libro SET Stock (Stock - @Stock) WHERE Id = @id";

                        SqlParameter id = new SqlParameter("Id", System.Data.SqlDbType.BigInt) { Value = libroVendido.Id };
                        SqlParameter stockVendido = new SqlParameter("Stock", System.Data.SqlDbType.BigInt) { Value = libroVendido.Stock };

                        using(SqlCommand cmd = new SqlCommand(queryUpdateStock, conexion))
                        {
                            cmd.Parameters.Add(id);
                            cmd.Parameters.Add(stockVendido);

                            int numberOfRows = cmd.ExecuteNonQuery();
                        }
                    }

                    conexion.Close();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("No se pudo realizar la operacion");
            }
        }
    }
}
