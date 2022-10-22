using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Negocio
{
    public class Libros
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string Sinopsis { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
    }
}
