using System;
using System.Collections.Generic;
using System.Text;

namespace Data.QueryHelper
{
    public class QueryDetalleVenta
    {
        public static string InsertDetalle { get; set; } = "INSERT INTO DetalleVenta (Cantidad, Precio, Medio_de_Pago, Cuotas, Medio_de_Envio) VALUES (@cantidad, @precio, @medioDePago, @cuotas, @medioDeEnvio)";
        public static string UpdateDetalle { get; set; } = "UPDATE DetalleVenta SET Cantidad = @cantidad, Precio = @precio, Medio_de_Pago = @medioDePago, Cuotas = @cuotas, Medio_de_Envio = @medioDeEnvio WHERE IdDetalle = @idDetalle";
        public static string GetDetalle { get; set; } = "SELECT * FROM DetalleVenta";
        public static string DeleteDetalle { get; set; } = "DELETE FROM DetalleVenta WHERE IdDetalle = @idDetalle";
    }
}
