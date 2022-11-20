using Domain.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Autenticacion
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public Guid IdCliente { get; set; }

    }
}
