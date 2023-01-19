using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Negocio
{
    public class Libro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string Genero { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Caracteristicas { get; set; }
    }
}
