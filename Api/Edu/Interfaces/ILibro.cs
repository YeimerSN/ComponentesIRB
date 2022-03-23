using Api.Edu.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Edu.Interfaces
{
    public interface ILibro
    {
        public List<Libro> getLibros();
        public void agregarLibro(Libro libro);
        public void editarLibro(Libro libro);
        public void eliminarLibro(Libro libro);
    }
}
