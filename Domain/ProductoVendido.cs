using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ProductoVendido
    {
        public int Id { get; set; }
        public int IdLibro { get; set; }
        public int Stock { get; set; }
        public int IdVenta { get; set; }
    }
}
