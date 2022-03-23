using Api.Edu.Interfaces;
using Api.Edu.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using ConexionDB.Proxy.ProxyLibros;

namespace MAnipularLibros.Edu.Logica
{
    public class ManipularL : ILibro
    {
        private readonly MetodosLibro ml; 
        public ManipularL()
        {
            ml = new MetodosLibro();
        }
        public void agregarLibro(Libro libro)
        {
            throw new NotImplementedException();
        }

        public void editarLibro(Libro libro)
        {
            throw new NotImplementedException();
        }

        public void eliminarLibro(Libro libro)
        {
            throw new NotImplementedException();
        }

        public List<Libro> getLibros()
        {
            throw new NotImplementedException();
        }
    }
}
