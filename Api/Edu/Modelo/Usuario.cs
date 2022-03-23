using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Api.Edu.Modelo
{
    public class Usuario: Persona
    {
        public string direccion { get; set; }
    }
}
