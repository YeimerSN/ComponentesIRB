using Api.Edu.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Edu.Interfaces
{
     public interface IUsuario
    {
        public List<Usuario> getUsuarios();
        public void editarUsuario(Usuario usuario);
        public void eliminarUsuario(Usuario usuario);
        public void agregarUsuario(Usuario usuario);
    }
}
