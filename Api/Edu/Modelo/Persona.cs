using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Edu.Modelo
{
    public class Persona
    {
        public int id { get; set; }
        public int codigo { get; set; }

        public string nombre { get; set; }
        public string pass { get; set; }
    }
}
