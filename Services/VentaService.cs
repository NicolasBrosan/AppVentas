using Data;
using Domain.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class VentaService
    {
        LibroHandler libroHandlerEnVenta = new LibroHandler();
        public List<Libro> MostrarLibros()
        {
            return libroHandlerEnVenta.Get();

        }
    }
}
