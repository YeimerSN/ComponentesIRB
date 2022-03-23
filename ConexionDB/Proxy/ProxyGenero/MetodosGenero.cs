using System.Collections.Generic;
using Api.Edu.Modelo;

namespace ConexionDB.Proxy.ProxyGenero
{
    public class MetodosGenero : ControlGenero
    {
        private ControlGenero controlGenero;

        public override void agregarGenero(Genero genero)
        {
            if (controlGenero == null)
            {
                controlGenero = new ControlGenero();
            }
            controlGenero.agregarGenero(genero);
        }

        public override void eliminarGenero(Genero genero)
        {
            if (controlGenero == null)
            {
                controlGenero = new ControlGenero();
            }
            controlGenero.eliminarGenero(genero);
        }

        public override void editarGenero(Genero genero)
        {
            if (controlGenero == null)
            {
                controlGenero = new ControlGenero();
            }
            controlGenero.editarGenero(genero);
        }

        public override List<Genero> leerGenero()
        {
            if (controlGenero == null)
            {
                controlGenero = new ControlGenero();
            }
            return controlGenero.leerGenero();
        }
    }
}
