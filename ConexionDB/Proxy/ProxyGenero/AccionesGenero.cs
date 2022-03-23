using System.Collections.Generic;
using Api.Edu.Modelo;

namespace ConexionDB.Proxy.ProxyGenero
{
    public abstract class AccionesGenero
    {
        public abstract void agregarGenero(Genero genero);
        public abstract void eliminarGenero(Genero genero);
        public abstract void editarGenero(Genero genero);
        public abstract List<Genero> leerGenero();
    }
}
