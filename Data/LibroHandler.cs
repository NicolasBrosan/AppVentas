﻿using Domain.Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Data.Interface;

namespace Data
{
    public class LibroHandler : ICrud<Libro>
    {
        ConnectionDB cnn = new ConnectionDB();
        public void Insert(Libro libro)
        {
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    string queryLibro = "INSERT INTO Libro (Nombre, Autor, Editorial, Sinopsis, Precio, Stock) VALUES (@nombre, @autor, @editorial, @sinopsis, @precio, @stock)";

                    SqlParameter nombre = new SqlParameter("Nombre", System.Data.SqlDbType.VarChar) { Value = libro.Nombre };
                    SqlParameter autor = new SqlParameter("Autor", System.Data.SqlDbType.VarChar) { Value = libro.Autor };
                    SqlParameter editorial = new SqlParameter("Editorial", System.Data.SqlDbType.VarChar) { Value = libro.Editorial };
                    SqlParameter sinopsis = new SqlParameter("Sinopsis", System.Data.SqlDbType.VarChar) { Value = libro.Sinopsis };
                    SqlParameter precio = new SqlParameter("Precio", System.Data.SqlDbType.Decimal) { Value = libro.Precio };
                    SqlParameter stock = new SqlParameter("Stock", System.Data.SqlDbType.Int) { Value = libro.Stock };

                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(queryLibro, conexion))
                    {
                        cmd.Parameters.Add(nombre);
                        cmd.Parameters.Add(autor);
                        cmd.Parameters.Add(editorial);
                        cmd.Parameters.Add(sinopsis);
                        cmd.Parameters.Add(precio);
                        cmd.Parameters.Add(stock);

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

        public bool Update(Libro libro)
        {
            var resultado = false;
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    string queryUpLibro = "UPDATE [DB_VentaLibros].[dbo].[Libro] SET Nombre = @nombre, Autor = @autor, Editorial = @editorial, Sinopsis = @sinopsis, Precio = @precio, Stock = @stock WHERE Id = @id";

                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(queryUpLibro, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", libro.Nombre);
                        cmd.Parameters.AddWithValue("@autor", libro.Autor);
                        cmd.Parameters.AddWithValue("@editorial", libro.Editorial);
                        cmd.Parameters.AddWithValue("@sinopsis", libro.Sinopsis);
                        cmd.Parameters.AddWithValue("@precio", libro.Precio);
                        cmd.Parameters.AddWithValue("@stock", libro.Stock);
                        cmd.Parameters.AddWithValue("@id", libro.Id);

                        var numberOfRows = cmd.ExecuteNonQuery();
                        if(numberOfRows > 0)
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
        public void Delete(Libro id)
        {

            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    List<string> Querys = new List<string>();

                    var queryDeletePV = "DELETE ProductoVendido FROM Libro AS L INNER JOIN ProductoVendido AS PV on L.ID = PV.IDLIBRO WHERE L.ID = @id";
                    Querys.Add(queryDeletePV);

                    string queryDtLibro = "DELETE FROM Libro WHERE Id = @id";
                    Querys.Add(queryDtLibro);

                    conexion.Open();
                    foreach (var query in Querys)
                    {
                        //SqlParameter sqlParameter = new SqlParameter("id", System.Data.SqlDbType.BigInt);
                        //sqlParameter.Value = id;

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
                    Console.WriteLine($"No se pudo eliminar lo solicitado: {ex.Message}");
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
                    var queryGetLibros = "SELECT * FROM Libro";
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
                                    libro.Sinopsis = reader["Sinopsis"].ToString();
                                    libro.Precio = Convert.ToDecimal(reader["Precio"]);
                                    libro.Stock = Convert.ToInt32(reader["Stock"]);

                                    libros.Add(libro);
                                }
                            }
                        }
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No es posible traer la informacion: {ex.Message}");
                }

                return libros;
            }

        }

        public List<Libro> Get(string letra)
        {
            List<Libro> librosFiltrados = new List<Libro>();
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryFiltrar = "SELECT * FROM Libro WHERE Nombre LIKE @nombre";

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
                                    libro.Sinopsis = reader["Sinopsis"].ToString();
                                    libro.Precio = Convert.ToDecimal(reader["Precio"]);
                                    libro.Stock = Convert.ToInt32(reader["Stock"]);

                                    librosFiltrados.Add(libro);

                                }

                            }
                        }
                    }

                    conexion.Close();


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No es posible realizar el filtrado: {ex.Message}");

                }

                return librosFiltrados;
            }
        }

        public List<Libro> GetId(int id)
        {
            var libroId = new List<Libro>();
            using (SqlConnection conexion = new SqlConnection(cnn.CConnection("myConnection")))
            {
                try
                {
                    var queryId = "SELECT * FROM Libro WHERE Id = @id";
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

                    Console.WriteLine($"No se encontro el Id: {ex.Message}");
                }

                return libroId;
            }

        }
    }


}
