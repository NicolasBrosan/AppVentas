using Data;
using Domain.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Services
{
    public class LibrosService
    {
        LibroHandler libroHandler = new LibroHandler();
        public void GuardarLibro(Libro libro)
        {
            libroHandler.Insert(libro);
        }
        public void ModificarLibro(Libro modificarLibro)
        {
            libroHandler.Update(modificarLibro);
        }
        public List<Libro> ObtenerLibros()
        {
            return libroHandler.Get();

        }

        //Sobreescribo Get()
        public List<Libro> ObtenerLibrosPorNombre(string filtro)
        {
            //return libroHandler.Get(filtro);
            var libros = ObtenerLibros();
            var resultado = libros.Where(libro => libro.Nombre.Contains(filtro));

            return resultado.ToList();
        } 
        public Libro ObtenerLibroPorId(int id)
        {
            var libros = ObtenerLibros();
            var resultado = libros.FirstOrDefault(libro => libro.Id == id);
            return resultado;
        }
    }

}
