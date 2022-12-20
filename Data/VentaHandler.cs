using Data.QueryHelper;
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
            var idVentas = 0;//Es necesario??

            try
            {
                using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
                {
                    var queryVenta = QueryVenta.InsertVenta;

                    SqlParameter comentarios = new SqlParameter("Comentarios", System.Data.SqlDbType.VarChar) { Value = venta.Comentarios };
                    SqlParameter idUsuario = new SqlParameter("IdUsuario", System.Data.SqlDbType.BigInt) { Value = venta.IdUsuario };

                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(queryVenta, conexion))
                    {
                        cmd.Parameters.Add(comentarios);
                        cmd.Parameters.Add(idUsuario);

                        int numberOfRows = cmd.ExecuteNonQuery();
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
                    var queryDeleteVenta = QueryVenta.DeleteVenta;

                    SqlParameter Id = new SqlParameter("Id", System.Data.SqlDbType.BigInt) { Value = id };

                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(queryDeleteVenta, conexion))
                    {
                        cmd.Parameters.Add(Id);
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
