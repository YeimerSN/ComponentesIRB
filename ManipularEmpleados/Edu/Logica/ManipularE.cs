using Api.Edu.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ConexionDB.Proxy.ProxyEmpleados;
using Api.Edu.Modelo;

namespace ManipularEmpleados.Edu.Logica
{
    public class ManipularE : IEmpleado
    {
        public List<Persona> GetEmpleados()
        {
            MetodosEmpleados me = new MetodosEmpleados();
            return me.leerEmpleados();
        }
    }
}
