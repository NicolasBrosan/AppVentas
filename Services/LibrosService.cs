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
        public void ActualizarLibro(Libro actualizarLibro)
        {
            libroHandler.Update(actualizarLibro);//Tendría que devolver lo que devuelve el Handler. REVISAR
        }
        public List<Libro> ObtenerLibros()
        {
            return libroHandler.Get();

        }
        public  void EliminarLibro(Libro eliminarId)
        {
            libroHandler.Delete(eliminarId);
        }
        //Sobreescribo Get()
        public List<Libro> ObtenerLibrosPorNombre(string filtro)
        {              
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
