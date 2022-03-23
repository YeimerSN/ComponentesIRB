using System.Collections.Generic;
using Api.Edu.Modelo;

namespace ConexionDB.Proxy.ProxyPelicula
{
    public abstract class AccionesPeliculas
    {
        public abstract void agregarPelicula(Pelicula pelicula);
        public abstract void eliminarPelicula(Pelicula pelicula);
        public abstract void editarPelicula(Pelicula pelicula);
        public abstract List<Pelicula> leerPeliculas();
    }
}
