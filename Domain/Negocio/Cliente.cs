using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Negocio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public int Tarjeta { get; set; }
    }
}
