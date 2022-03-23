﻿using System.Collections.Generic;
using Api.Edu.Modelo;

namespace ConexionDB.Fachada
{
    public class FachadaUsuario
    {
        AgregarUsuario agregar;
        EliminarUsuario eliminar;
        ModificarUsuario modificar;
        ListarUsuario listar;

        public FachadaUsuario()
        {
            agregar = new AgregarUsuario();
            eliminar = new EliminarUsuario();
            modificar = new ModificarUsuario();
            listar = new ListarUsuario();
        }

        public void agregarU(Usuario usuario)
        {
            agregar.agregarUsuario(usuario);
        }

        public void eliminarU(Usuario usario)
        {
            eliminar.eliminarUsuario(usario);
        }
        public void modificarU(Usuario usuario)
        {
            modificar.modificarUsuario(usuario);
        }
        public List<Usuario> listarU()
        {
            return listar.listar();
        }
    }
}
