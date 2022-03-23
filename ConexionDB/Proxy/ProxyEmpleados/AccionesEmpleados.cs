using System.Collections.Generic;
using Api.Edu.Modelo;


namespace ConexionDB.Proxy.ProxyEmpleados
{
    public abstract class AccionesEmpleados
    {
        public abstract void agregarEmpleado(Persona persona);
        public abstract void eliminarEmpleado(Persona persona);
        public abstract void editarEmpleado(Persona persona);
        public abstract List<Persona> leerEmpleados();
    }
}
