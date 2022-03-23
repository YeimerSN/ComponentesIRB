using Api.Edu.Modelo;
using System.Collections.Generic;


namespace ConexionDB.Proxy.ProxyPelicula
{
    public class MetodosPeliculas: ControlPeliculas
    {
        private ControlPeliculas controlPeliculas;

        public override void agregarPelicula(Pelicula pelicula)
        {
            if (controlPeliculas == null)
            {
                controlPeliculas = new ControlPeliculas();
            }
            controlPeliculas.agregarPelicula(pelicula);
        }

        public override void editarPelicula(Pelicula pelicula)
        {
            if (controlPeliculas == null)
            {
                controlPeliculas = new ControlPeliculas();
            }
            controlPeliculas.editarPelicula(pelicula);
        }

        public override void eliminarPelicula(Pelicula pelicula)
        {
            if (controlPeliculas == null)
            {
                controlPeliculas = new ControlPeliculas();
            }
            controlPeliculas.eliminarPelicula(pelicula);
        }

        public override List<Pelicula> leerPeliculas()
        {
            if (controlPeliculas == null)
            {
                controlPeliculas = new ControlPeliculas();
            }
            return controlPeliculas.leerPeliculas();
        }
    }
}
