﻿using ConexionDB.Fachada;

namespace ConexionDB.Patron_Cadena
{
    public class Usuario : Persona
    {
        public override Api.Edu.Modelo.Persona EncontrarUsEm(int codigo, string password)
        {
            var usuarios = new FachadaUsuario().listarU();

            int found = -1;
            bool u = false;
            if (usuarios != null)
            {
                foreach (var item in usuarios)
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
                /* Si es verdadero devuelve el objeto usuario*/
                var obj = usuarios.Find(e => e.codigo == codigo);
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
