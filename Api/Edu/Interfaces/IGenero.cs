using System;
using System.Collections.Generic;
using System.Text;
using Api.Edu.Modelo;

namespace Api.Edu.Interfaces
{
    public interface IGenero
    {
        public List<Genero> getGeneros();
        public void agregarGenero(Genero genero);
        public void editarGenero(Genero genero);
        public void eliminarGenero(Genero genero);
    }
}
