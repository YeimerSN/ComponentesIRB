using Api.Edu.Modelo;
using System.Collections.Generic;

namespace Api.Edu.Interfaces
{
    public interface IModerador
    {
        #region Usuarios
        public void ModerarCrear(Usuario U);
        public void ModerarEditar(Usuario U);
        public void ModerarEliminar(Usuario U);
        public List<Usuario> ModerarLeerU();
        public List<Persona> ModerarLeerE();
        public object ModerarLoggearU(int codigo,string password);
        #endregion

        #region Productos
        public void ModerarCrear(Libro U);
        public void ModerarEditar(Libro U);
        public void ModerarEliminar(Libro U);
        public List<Libro> ModerarLeerL(Libro U);
        public void ModerarCrear(Pelicula U);
        public void ModerarEditar(Pelicula U);
        public void ModerarEliminar(Pelicula U);
        public List<Pelicula> ModerarLeerP(Pelicula U);
        public void ModerarCrear(Genero U);
        public void ModerarEditar(Genero U);
        public void ModerarEliminar(Genero U);
        public List<Genero> ModerarLeerG();
        public List<Prestamo> ModerarLeerPres();
        #endregion

    }
}
