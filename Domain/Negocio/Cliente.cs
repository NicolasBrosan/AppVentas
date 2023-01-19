using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Negocio
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public int Telefono { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
    }
}
