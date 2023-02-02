using Data.QueryHelper;
using Domain.Negocio;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class VentaHandler
    {
        Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly ConnectionDB cnn = new ConnectionDB();
        
        public void InsertVenta(List<Libro> libro, Venta venta)//Preguntar
        { 
            /*
            try
            {
                using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
                {
                    var queryVenta = QueryVenta.InsertVenta;

                    //SqlParameter idCliente  

                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(queryVenta, conexion))
                    {
                        cmd.Parameters.Add();

                        int numberOfRows = cmd.ExecuteNonQuery();
                    }

                    conexion.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo realizar la operacion: {ex.Message}");
            }
            */
        }

        public void DeleteVenta(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
                {
                    var queryDeleteVenta = QueryVenta.DeleteVenta;

                    SqlParameter idVenta = new SqlParameter("IdVenta", System.Data.SqlDbType.BigInt) { Value = id };

                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(queryDeleteVenta, conexion))
                    {
                        cmd.Parameters.Add(idVenta);
                        int numberOfRows = cmd.ExecuteNonQuery();
                    }                                       

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {

                logger.Error($"No se ha podido eliminar: {ex.Message}");
            }
        }
    }
}
