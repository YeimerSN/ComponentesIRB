using Api.Edu.Interfaces;
using Api.Edu.Modelo;
using System;
using System.Collections.Generic;
using ConexionDB.Fachada;

namespace ManipularUsuarios.Edu.Logica
{
    public class ManipularU : IUsuario
    {
        private readonly FachadaUsuario fu;
        public ManipularU()
        {
            fu = new FachadaUsuario();
        }
        public void agregarUsuario(Usuario usuario)
        {
            fu.agregarU(usuario);
        }

        public void editarUsuario(Usuario usuario)
        {
            fu.modificarU(usuario);
        }

        public void eliminarUsuario(Usuario usuario)
        {
            fu.eliminarU(usuario);
        }

        public List<Usuario> getUsuarios()
        {
            return fu.listarU();
        }
    }
}
