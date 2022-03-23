using System.Collections.Generic;
using Api.Edu.Modelo;

namespace ConexionDB.Proxy.ProxyLibros
{
    public class MetodosLibro : ControlLibros
    {
        private ControlLibros controlLibros;

        public override void agregarLibro(Libro libro)
        {
            if (controlLibros == null)
            {
                controlLibros = new ControlLibros();
            }
            controlLibros.agregarLibro(libro);
        }

        public override void eliminarLibro(Libro libro)
        {
            if (controlLibros == null)
            {
                controlLibros = new ControlLibros();
            }
            controlLibros.eliminarLibro(libro);
        }

        public override void editarLibro(Libro libro)
        {
            if (controlLibros == null)
            {
                controlLibros = new ControlLibros();
            }
            controlLibros.editarLibro(libro);
        }

        public override List<Libro> leerLibros()
        {
            if (controlLibros == null)
            {
                controlLibros = new ControlLibros();
            }
            return controlLibros.leerLibros();
        }
    }
}
