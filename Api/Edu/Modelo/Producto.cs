
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Edu.Modelo
{
    public abstract class Producto
    {
        public int id{ get; set; }

        public string nombre{ get; set; }

        public string genero{ get; set; }
        public abstract string getTamanio();
        public abstract string getAutor();

    }
}
