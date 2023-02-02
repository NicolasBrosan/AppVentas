using Data.Interface;
using Data.QueryHelper;
using Domain.Negocio;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class DetalleVentaHandler : ICrud<DetalleVenta>
    {
        Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly ConnectionDB cnn = new ConnectionDB();

        public void Insert(DetalleVenta detalle)
        {
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    string queryDetalle = QueryDetalleVenta.InsertDetalle;

                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(queryDetalle, conexion))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                        cmd.Parameters.AddWithValue("@precio", detalle.Precio);
                        cmd.Parameters.AddWithValue("@medioDePago", detalle.MedioDePago);
                        cmd.Parameters.AddWithValue("@cuotas", detalle.Cuotas);
                        cmd.Parameters.AddWithValue("@medioDeEnvio", detalle.MedioDeEnvio);

                        cmd.ExecuteNonQuery();
                    }

                    conexion.Close();

                }
                catch (Exception ex)
                {
                    logger.Error($"Error al insertar los detalles de la venta{ex.Message}");
                }
            }
        }

        public bool Update(DetalleVenta detalle)
        {
            var updateResult = false;
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryUpdateDetalle = QueryDetalleVenta.UpdateDetalle;

                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(queryUpdateDetalle, conexion))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                        cmd.Parameters.AddWithValue("@precio", detalle.Precio);
                        cmd.Parameters.AddWithValue("@medioDePago", detalle.MedioDePago);
                        cmd.Parameters.AddWithValue("@cuotas", detalle.Cuotas);
                        cmd.Parameters.AddWithValue("@medioDeEnvio", detalle.MedioDeEnvio);
                        cmd.Parameters.AddWithValue("@idDetalle", detalle.IdDetalle);
                                                
                        int numberOfRow = cmd.ExecuteNonQuery();
                        if(numberOfRow > 0)
                        {
                            updateResult = true;
                        }
                    }

                    conexion.Close();

                }
                catch (Exception ex)
                {

                    logger.Error($"No se pudieron actualizar los datos {ex.Message}");
                }

            }

            return updateResult;
            
        }

        public List<DetalleVenta> Get()
        {
            var detalles = new List<DetalleVenta>();

            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryGetDetalle = QueryDetalleVenta.GetDetalle;

                    using (SqlCommand cmd = new SqlCommand(queryGetDetalle, conexion))
                    {
                        conexion.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                { 
                                    DetalleVenta detalle = new DetalleVenta();
                                    detalle.IdDetalle = Convert.ToInt32(reader["IdDetalle"]);
                                    detalle.Cantidad = Convert.ToInt32(reader["Cantidad"]);
                                    detalle.Precio = Convert.ToDecimal(reader["Precio"]);
                                    detalle.MedioDePago = reader["Medio_de_Pago"].ToString();
                                    detalle.Cuotas = Convert.ToInt32(reader["Cuotas"]);
                                    detalle.MedioDeEnvio = reader["Medio_de_Envio"].ToString();

                                    detalles.Add(detalle);

                                }
                            }
                        }
                        conexion.Close();
                    }
                }
                catch (Exception ex)
                {

                    logger.Error($"No se pudo realizar la operación {ex.Message}");
                }

                return detalles;
            }
        }

        public void Delete(DetalleVenta id)
        {
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    List<string> querys = new List<string>();
                    var queryDeleteDetalle = QueryDetalleVenta.DeleteDetalle;
                    querys.Add(queryDeleteDetalle);

                    conexion.Open();

                    foreach(var query in querys)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("id", id.IdDetalle);
                            int numberOfRow = cmd.ExecuteNonQuery();
                        }
                    }

                    conexion.Close();
                }
                catch (Exception ex)
                {

                    logger.Error($"No se pudo eliminar los detalles solicitados: {ex.Message}");
                }
            }
        }
    }
}
