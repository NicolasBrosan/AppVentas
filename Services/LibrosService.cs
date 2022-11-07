using Data;
using Domain.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class LibrosService
    {
        public void GuardarLibro(Libro libro)
        {
            var libroHandler = new LibroHandler();
            libroHandler.Insert(libro);
        }
        
    }
}
