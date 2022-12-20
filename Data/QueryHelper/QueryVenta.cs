using System;
using System.Collections.Generic;
using System.Text;

namespace Data.QueryHelper
{
    public static class QueryVenta
    {
        public static string InsertVenta { get; set; } = "INSERT INTO Venta (Comentarios, IdUsuario) VALUES (@comentarios, @idUsuario)";
        public static string DeleteVenta { get; set; } = "DELETE FROM Venta WHERE Id = @id";
    }
}
