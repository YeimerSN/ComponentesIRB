using Api.Edu.Interfaces;
using Api.Edu.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using ConexionDB.Proxy.ProxyGenero;

namespace ManipularGenero.Edu.Logica
{
    public class ManipularG : IGenero
    {
        private readonly MetodosGenero mg;
        public ManipularG()
        {
            mg = new MetodosGenero();
        }
        public void agregarGenero(Genero genero)
        {
            mg.agregarGenero(genero);
        }

        public void editarGenero(Genero genero)
        {
            mg.editarGenero(genero);
        }

        public void eliminarGenero(Genero genero)
        {
            mg.eliminarGenero(genero);
        }

        public List<Genero> getGeneros()
        {
            return mg.leerGenero();
        }
    }
}
