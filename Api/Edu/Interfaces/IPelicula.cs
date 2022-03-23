using Api.Edu.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Edu.Interfaces
{
    public interface IPelicula
    {
        public List<Pelicula> getPeliculas();
        public void agregarPelicula();
        public void editarPelicula();
        public void eliminarPelicula();
    }
}
