using System;
using System.Collections.Generic;
using System.Text;

namespace Data.QueryHelper
{
    public static class QueryLibro
    {
        public static string Insert { get; set; } = "INSERT INTO Libro (Nombre, Autor, Editorial, Genero, Costo, Precio, Stock, Caracteristicas) VALUES (@nombre, @autor, @editorial, @genero, @costo, @precio, @stock, @caracteristicas)";

        public static string Update { get; set; } = "UPDATE [DB_VentaLibros].[dbo].[Libro] SET Nombre = @nombre, Autor = @autor, Editorial = @editorial, Sinopsis = @sinopsis, Precio = @precio, Stock = @stock WHERE Id = @id";

        public static string Delete { get; set; } = "DELETE FROM Libro WHERE Id = @id";

        public static string Get { get; set; } = "SELECT * FROM Libro";
        public static string GetByName { get; set; } = "SELECT * FROM Libro WHERE Nombre LIKE @nombre";
        public static string GetById { get; set; } = "SELECT * FROM Libro WHERE Id = @id";
    }
}
