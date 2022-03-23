using Api.Edu.Interfaces;
using Api.Edu.Modelo;
using System;
using System.Collections.Generic;
using ConexionDB.Proxy.ProxyPrestamo;

namespace ManipularPrestamos.Edu.Logica
{
    public class ManipularP : IPrestamo
    {
        private readonly MetodosPrestamos mp;
        public ManipularP()
        {
            mp = new MetodosPrestamos();
        }
        public List<Prestamo> prestamos()
        {
            return mp.leerPrestamo();
        }
    }
}
