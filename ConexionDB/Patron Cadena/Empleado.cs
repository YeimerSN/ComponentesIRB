﻿using ConexionDB.Proxy.ProxyEmpleados;
using Api.Edu.Modelo;

namespace ConexionDB.Patron_Cadena
{
    public class Empleado : Persona
    {
        public override Api.Edu.Modelo.Persona EncontrarUsEm(int codigo, string password)
        {
            var empleados = new MetodosEmpleados().leerEmpleados();

            int found = -1;
            bool u = false;
            if (empleados != null)
            {
                foreach (var item in empleados)
                {
                    found++;
                    if (item.codigo == codigo && item.pass == password)
                    {
                        u = true;
                    }
                }
            }
            if (u == true)
            {
                /* Si es verdadero devuelve el objeto empleado*/
                var obj = empleados.Find(e => e.codigo == codigo);
                return obj;
            }
            else if (suc != null)
            {
                var obj = suc.EncontrarUsEm(codigo, password);
                return obj;
            }
            return null;
            
        }
    }
}
