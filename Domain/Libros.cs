using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Libros
    {
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
