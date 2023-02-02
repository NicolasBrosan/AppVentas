using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Negocio
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public Cliente IdCliente { get; set; }
        public decimal TotalVenta { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; }
    }
}
