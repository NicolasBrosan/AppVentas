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
                }

            }
            catch (Exception)
            {

                
            }
        }
    }
}
