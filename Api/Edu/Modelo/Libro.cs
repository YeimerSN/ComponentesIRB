﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Edu.Modelo
{
    public class Libro: Producto
    {
        public int paginas { get; set; }
        public  string autores { get; set; }

        public override string getAutor()
        {
            return autores;
        }

        public override string getTamanio()
        {
            return paginas.ToString()+" págs";
        }
    }
}
