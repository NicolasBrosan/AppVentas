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
                }
                catch (Exception)
                {
                                           
                }
            }
        }
    }
}
