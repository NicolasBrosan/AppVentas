using System;
using System.Collections.Generic;
using System.Text;

namespace Data.QueryHelper
{
    public static class QueryVenta
    {
        public static string InsertVenta { get; set; } = "INSERT INTO Venta (IdCliente, TotalVenta, IdDetalleVenta) VALUES (@idCliente, @totalVenta, @idDetalleVenta)";
        public static string DeleteVenta { get; set; } = "DELETE FROM Venta WHERE IdVenta = @idVenta";
        public static string GetVenta { get; set; } = "SELECT * FROM Venta";
    }
}
