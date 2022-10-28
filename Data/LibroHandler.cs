using Domain.Negocio;
using System;
using System.Data.SqlClient;

namespace Data
{
    public class LibroHandler
    {
        ConnectionDB cnn = new ConnectionDB();
        public void CreateLibro(Libro libro)
        {            
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    string queryLibro = "INSERT INTO Libro (Nombre, Autor, Editorial, Sinopsis, Precio, Stock, IdUsuario) VALUES (@nombre, @autor, @editorial, @sinopsis, @precio, @stock, @idUsuario)";

                    SqlParameter nombre = new SqlParameter("Nombre", System.Data.SqlDbType.VarChar) { Value = libro.Nombre };
                    SqlParameter autor = new SqlParameter("Autor", System.Data.SqlDbType.VarChar) { Value = libro.Autor };
                    SqlParameter editorial = new SqlParameter("Editorial", System.Data.SqlDbType.VarChar) { Value = libro.Editorial };
                    SqlParameter sinopsis = new SqlParameter("Sinopsis", System.Data.SqlDbType.VarChar) { Value = libro.Sinopsis };
                    SqlParameter precio = new SqlParameter("Precio", System.Data.SqlDbType.Decimal) { Value = libro.Precio };
                    SqlParameter stock = new SqlParameter("Stock", System.Data.SqlDbType.Int) { Value = libro.Stock };
                    SqlParameter idUsuario = new SqlParameter("IdUsuario", System.Data.SqlDbType.Int) { Value = libro.IdUsuario };

                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(queryLibro, conexion))
                    {
                        cmd.Parameters.Add(nombre);
                        cmd.Parameters.Add(autor);
                        cmd.Parameters.Add(editorial);
                        cmd.Parameters.Add(sinopsis);
                        cmd.Parameters.Add(precio);
                        cmd.Parameters.Add(stock);
                        cmd.Parameters.Add(idUsuario);
                    }
                    conexion.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("No se pudo realizar la operacion");                          
                }
            }
        }
    }
}
