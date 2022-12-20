using System;
using System.Collections.Generic;
using System.Text;

namespace Data.QueryHelper
{
    //Querys Cliente
    public static class QueryCliente
    {
        //las querys las puedo pasar a una clase específica y guardarlas con un nombre descriptivo. Esa clase puede ser estática y solo devolver el string de la query.
        //Las querys pueden ser properties.
        public static string Insert { get; set; } = "INSERT INTO Cliente (Id, Nombre, Apellido, Telefono, Direccion, Localidad, Provincia) " +
                        "VALUES (@id, @nombre, @apellido, @telefono, @direccion, @localidad, @provincia)";

        public static string Update { get; set; } = "UPDATE[DB_VentaLibros].[dbo].[Cliente] SET Nombre = @nombre, Apellido = @apellido, Telefono = @telefono, Direccion = @direccion, Localidad = @localidad, Provincia = @provincia WHERE Id = @id";

        public static string Delete { get; set; } = "DELETE FROM Cliente WHERE Id = @id";

        public static string Get { get; set; } = "SELECT * FROM Cliente";
    }
}
