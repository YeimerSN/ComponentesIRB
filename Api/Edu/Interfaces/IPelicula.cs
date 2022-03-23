using Api.Edu.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Edu.Interfaces
{
    public interface IPelicula
    {
        public List<Pelicula> getPeliculas();
        public void agregarPelicula(Pelicula pelicula);
        public void editarPelicula(Pelicula pelicula);
        public void eliminarPelicula(Pelicula pelicula);
    }
}
