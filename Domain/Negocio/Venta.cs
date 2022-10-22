using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Negocio
{
    public class Venta
    {
        public int Id { get; set; }
        public string Comentarios { get; set; }
        public int IdUsuario { get; set; }
    }
}
