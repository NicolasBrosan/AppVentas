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
        public int DNI { get; set; } //Se agrega la property después que el resto
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public long Tarjeta { get; set; }
    }
}
