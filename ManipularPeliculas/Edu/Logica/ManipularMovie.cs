using Api.Edu.Interfaces;
using Api.Edu.Modelo;
using ConexionDB.Patron_Comando;
using System;
using System.Collections.Generic;
using ConexionDB.Proxy.ProxyPelicula;

namespace ManipularPeliculas.Edu.Logica
{
    public class ManipularMovie : IPelicula
    {
        private readonly IComando ap;
        private readonly IComando edp;
        private readonly IComando elp;
        private readonly ControlInventario invocador;
        private readonly MetodosPeliculas mp;

        public ManipularMovie(Pelicula pelicula)
        {
            ap = new AgregarPelicula(pelicula);
            edp = new EditarPelicula(pelicula);
            elp = new EliminarPelicula(pelicula);
            invocador = new ControlInventario(ap, edp, elp);
            mp = new MetodosPeliculas();
        }

        public void agregarPelicula()
        {
            invocador.agregarProducto();
        }

        public void editarPelicula()
        {
            invocador.editarProducto();
        }

        public void eliminarPelicula()
        {
            invocador.eliminarProducto();
        }

        public List<Pelicula> getPeliculas()
        {
            return mp.leerPeliculas();
        }
    }
}
