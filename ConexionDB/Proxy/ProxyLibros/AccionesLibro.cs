using System.Collections.Generic;
using Api.Edu.Modelo;

namespace ConexionDB.Proxy.ProxyLibros
{
    public abstract class AccionesLibro
    {
        //clase Subject
        public abstract void agregarLibro(Libro libro);
        public abstract void eliminarLibro(Libro libro);
        public abstract void editarLibro(Libro libro);
        public abstract List<Libro> leerLibros();
    }
}
