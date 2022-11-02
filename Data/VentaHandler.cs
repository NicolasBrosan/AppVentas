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
                using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
                {
                    var queryVenta = "INSERT INTO Venta (Comentarios, IdUsuario) VALUES (@comentarios, @idUsuario)";

                    SqlParameter comentarios = new SqlParameter("Comentarios", System.Data.SqlDbType.VarChar) { Value = venta.Comentarios };
                    SqlParameter idUsuario = new SqlParameter("IdUsuario", System.Data.SqlDbType.BigInt) { Value = venta.IdUsuario };

                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(queryVenta, conexion))
                    {
                        cmd.Parameters.Add(comentarios);
                        cmd.Parameters.Add(idUsuario);

                        int numberOfRows = cmd.ExecuteNonQuery();
                    }

                    //Ordenar desde la primera compra a la ultima. VER SI FUNCIONA ASI
                    var queryIdVenta = "SELECT TOP (1) Id FROM Venta ORDER BY Id Desc ";
                    using (SqlCommand cmdOrderBy = new SqlCommand(queryIdVenta, conexion))
                    {
                        using (SqlDataReader reader = cmdOrderBy.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //var IdVentas = 0; --- ERROR AL HACER ESTO
                                    idVentas = Convert.ToInt32(reader["Id"]);
                                }
                            }
                        }
                    }

                    //Se recorre la lista de Libro para insertar la venta en ProductoVendido
                    foreach (var libroVendido in libro)
                    {
                        var queryLibroVendido = "INSERT INTO ProductoVendido (IdLibro, Stock, IdVenta) VALUES (@idLibro, @stock, @idVenta)";

                        SqlParameter idLibro = new SqlParameter("IdLibro", System.Data.SqlDbType.BigInt) { Value = libroVendido.Id };
                        SqlParameter stock = new SqlParameter("Stock", System.Data.SqlDbType.BigInt) { Value = libroVendido.Stock };
                        SqlParameter idVenta = new SqlParameter("IdVenta", System.Data.SqlDbType.BigInt) { Value = idVentas };

                        using (SqlCommand cmd = new SqlCommand(queryLibroVendido, conexion))
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

                        using (SqlCommand cmd = new SqlCommand(queryUpdateStock, conexion))
                        {
                            cmd.Parameters.Add(id);
                            cmd.Parameters.Add(stockVendido);

                            int numberOfRows = cmd.ExecuteNonQuery();
                        }
                    }

                    conexion.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo realizar la operacion: {ex.Message}");
            }
        }

        public void DeleteVenta(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
                {
                    //Se elimina la venta realizada (venta cancelada)
                    var queryDeleteVenta = "DELETE FROM Venta WHERE Id = @id";
                    SqlParameter Id = new SqlParameter("Id", System.Data.SqlDbType.BigInt) { Value = id };

                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(queryDeleteVenta, conexion))
                    {
                        cmd.Parameters.Add(Id);
                        int numberOfRows = cmd.ExecuteNonQuery();
                    }

                    //Se elimina la venta cancelada en ProductoVendido
                    List<ProductoVendido> listaPV = new List<ProductoVendido>();
                    string queryDeletePV = "DELETE FROM ProductoVendido WHERE IdVenta = @IdVenta";
                    var sqlIdVenta = new SqlParameter("IdVenta", System.Data.SqlDbType.BigInt) { Value = id};

                    conexion.Open();
                    using(SqlCommand cmd = new SqlCommand(queryDeletePV, conexion))
                    {
                        cmd.Parameters.Add(sqlIdVenta);

                        //Si se ejecuta la eliminacion, entonces me tiene que traer la info del libro que se cancelo la venta
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    ProductoVendido pV = new ProductoVendido();
                                    pV.Id = Convert.ToInt32(reader["Id"]);
                                    pV.Stock = Convert.ToInt32(reader["Stock"]);
                                    pV.IdVenta = Convert.ToInt32(reader["IdVenta"]);
                                    pV.IdLibro = Convert.ToInt32(reader["IdLibro"]);

                                    listaPV.Add(pV);
                                }
                            }
                        }
                    }

                    //Recorro la lista de los PVs y agrego a la clase Libro, la venta cancelada (le sumo el stock)
                    foreach (var ventaLibro in listaPV)
                    {
                        var queryLibro = "UPDATE Libro SET Stock = (Stock + @Stock) WHERE Id = @Id";
                        var stockAgregado = new SqlParameter("Stock", System.Data.SqlDbType.BigInt) { Value = ventaLibro.Stock };
                        var idDetalleLibro = new SqlParameter("Id", System.Data.SqlDbType.BigInt) { Value = ventaLibro.IdLibro };
                        SqlParameter[] parameterPV = new SqlParameter[] { stockAgregado, idDetalleLibro };

                        using(SqlCommand cmdParameter = new SqlCommand(queryLibro, conexion))
                        {
                            //Adhiero conjuntamente las variables {stockAgregago} y {idDetalleLibro} al array [parameterPV]
                            cmdParameter.Parameters.AddRange(parameterPV);

                            int numberOfRows = cmdParameter.ExecuteNonQuery();
                        }

                    }

                    //Elimino definitivamente la venta cancelada en PV
                    var queryDelPV = "DELETE FROM ProductoVendido WHERE Id = @Id";
                    var sqlPV = new SqlParameter("Id", System.Data.SqlDbType.BigInt) { Value = id };

                    using(SqlCommand cmd = new SqlCommand(queryDelPV, conexion))
                    {
                        cmd.Parameters.Add(sqlPV);

                        int numberOfRows = cmd.ExecuteNonQuery();
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"No se ha podido eliminar: {ex.Message}");
            }
        }
    }
}
