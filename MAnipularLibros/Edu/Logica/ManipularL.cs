using Api.Edu.Interfaces;
using Api.Edu.Modelo;
using System;
using System.Collections.Generic;
using ConexionDB.Patron_Comando;
using ConexionDB.Proxy.ProxyLibros;

namespace MAnipularLibros.Edu.Logica
{
    public class ManipularL : ILibro
    {
        private readonly IComando al;
        private readonly IComando edl;
        private readonly IComando el;
        private readonly ControlInventario invocador;
        private readonly MetodosLibro ml;
        public ManipularL(Libro libro)
        {
            al = new AgregarLibro(libro);
            edl = new EditarLibro(libro);
            el = new EliminarLibro(libro);
            invocador = new ControlInventario(al, edl, el);
            ml = new MetodosLibro(); 
        }
        public void agregarLibro()
        {
            invocador.agregarProducto();
        }

        public void editarLibro()
        {
            invocador.editarProducto();
        }

        public void eliminarLibro()
        {
            invocador.eliminarProducto();
        }

        public List<Libro> getLibros()
        {
            return ml.leerLibros();
        }
    }
}
