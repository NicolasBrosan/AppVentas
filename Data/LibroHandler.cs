using Domain.Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Data.Interface;
using Data.QueryHelper;
using Microsoft.Extensions.Logging;
using NLog;

namespace Data
{
    public class LibroHandler : ICrud<Libro>
    {
        Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly ConnectionDB cnn = new ConnectionDB();//Colocar private readonly
        public void Insert(Libro libro)
        {
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    string queryLibro = QueryLibro.Insert;

                    SqlParameter nombre = new SqlParameter("Nombre", System.Data.SqlDbType.VarChar) { Value = libro.Nombre };
                    SqlParameter autor = new SqlParameter("Autor", System.Data.SqlDbType.VarChar) { Value = libro.Autor };
                    SqlParameter editorial = new SqlParameter("Editorial", System.Data.SqlDbType.VarChar) { Value = libro.Editorial };
                    SqlParameter genero = new SqlParameter("Genero", System.Data.SqlDbType.VarChar) { Value = libro.Genero };
                    SqlParameter costo = new SqlParameter("Costo", System.Data.SqlDbType.Decimal) { Value = libro.Costo };
                    SqlParameter precio = new SqlParameter("Precio", System.Data.SqlDbType.Decimal) { Value = libro.Precio };
                    SqlParameter stock = new SqlParameter("Stock", System.Data.SqlDbType.Int) { Value = libro.Stock };
                    SqlParameter caracteristicas = new SqlParameter("Caracteristicas", System.Data.SqlDbType.VarChar) { Value = libro.Caracteristicas };

                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(queryLibro, conexion))
                    {
                        cmd.Parameters.Add(nombre);
                        cmd.Parameters.Add(autor);
                        cmd.Parameters.Add(editorial);
                        cmd.Parameters.Add(genero);
                        cmd.Parameters.Add(costo);
                        cmd.Parameters.Add(precio);
                        cmd.Parameters.Add(stock);
                        cmd.Parameters.Add(caracteristicas);

                        cmd.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    logger.Error($"No se pudo insertar los datos: {ex.Message}");
                }
            }
        }

        public bool Update(Libro libro)
        {
            var resultado = false;
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    string queryUpLibro = QueryLibro.Update;

                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(queryUpLibro, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", libro.Nombre);
                        cmd.Parameters.AddWithValue("@autor", libro.Autor);
                        cmd.Parameters.AddWithValue("@editorial", libro.Editorial);
                        cmd.Parameters.AddWithValue("@genero", libro.Genero);
                        cmd.Parameters.AddWithValue("@costo", libro.Costo);
                        cmd.Parameters.AddWithValue("@precio", libro.Precio);
                        cmd.Parameters.AddWithValue("@stock", libro.Stock);
                        cmd.Parameters.AddWithValue("@caracteristicas", libro.Caracteristicas);
                        cmd.Parameters.AddWithValue("@id", libro.Id);

                        var numberOfRows = cmd.ExecuteNonQuery();
                        if (numberOfRows > 0)
                        {
                            resultado = true;
                        }
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    logger.Error($"No se pudo actualizar: {ex.Message}");
                }
            }
            return resultado;
        }
        public void Delete(Libro id)
        {

            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    List<string> Querys = new List<string>();

                    string queryDtLibro = QueryLibro.Delete;
                    Querys.Add(queryDtLibro);

                    conexion.Open();
                    foreach (var query in Querys)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", id.Id);
                            int numberOfRows = cmd.ExecuteNonQuery();
                        }
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    logger.Error($"No se pudo eliminar lo solicitado: {ex.Message}");
                }


            }
        }
        public List<Libro> Get()
        {

            List<Libro> libros = new List<Libro>();
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryGetLibros = QueryLibro.Get;
                    using (SqlCommand cmd = new SqlCommand(queryGetLibros, conexion))
                    {
                        conexion.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Libro libro = new Libro();
                                    libro.Id = Convert.ToInt32(reader["Id"]);
                                    libro.Nombre = reader["Nombre"].ToString();
                                    libro.Autor = reader["Autor"].ToString();
                                    libro.Editorial = reader["Editorial"].ToString();
                                    libro.Genero = reader["Genero"].ToString();
                                    libro.Costo = Convert.ToDecimal(reader["Costo"]);
                                    libro.Precio = Convert.ToDecimal(reader["Precio"]);
                                    libro.Stock = Convert.ToInt32(reader["Stock"]);
                                    libro.Caracteristicas = reader["Caracteristicas"].ToString();

                                    libros.Add(libro);
                                }
                            }
                        }
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    logger.Error($"No es posible traer la informacion: {ex.Message}");
                }

                return libros;
            }

        }

        public List<Libro> GetByName(string letra)
        {
            List<Libro> librosFiltrados = new List<Libro>();
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryFiltrar = QueryLibro.GetByName;

                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(queryFiltrar, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", "%" + letra + "%");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Libro libro = new Libro();
                                    libro.Id = Convert.ToInt32(reader["Id"]);
                                    libro.Nombre = reader["Nombre"].ToString();
                                    libro.Autor = reader["Autor"].ToString();
                                    libro.Editorial = reader["Editorial"].ToString();
                                    libro.Genero = reader["Genero"].ToString();
                                    libro.Costo = Convert.ToDecimal(reader["Costo"]);
                                    libro.Precio = Convert.ToDecimal(reader["Precio"]);
                                    libro.Stock = Convert.ToInt32(reader["Stock"]);
                                    libro.Caracteristicas = reader["Caracteristicas"].ToString();

                                    librosFiltrados.Add(libro);

                                }

                            }
                        }
                    }

                    conexion.Close();


                }
                catch (Exception ex)
                {
                    logger.Error($"No es posible realizar el filtrado: {ex.Message}");

                }

                return librosFiltrados;
            }
        }

        public List<Libro> GetById(int id)
        {
            var libroId = new List<Libro>();
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryId = QueryLibro.GetById;
                    SqlParameter bookId = new SqlParameter("Id", System.Data.SqlDbType.Int) { Value = id };

                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(queryId, conexion))
                    {
                        cmd.Parameters.Add(bookId);
                        cmd.ExecuteNonQuery();
                    }

                    conexion.Close();

                }
                catch (Exception ex)
                {

                    logger.Error($"No se encontro el Id: {ex.Message}");
                }

                return libroId;
            }

        }
    }


}
