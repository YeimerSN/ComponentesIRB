using System;
using System.Collections.Generic;
using System.Text;
using Api.Edu.Modelo;

namespace Api.Edu.Interfaces
{
    public interface IEmpleado
    {
        public List<Persona> GetEmpleados();
    }
}
