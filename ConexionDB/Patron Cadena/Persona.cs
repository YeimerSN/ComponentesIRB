using ConexionDB.Proxy.ProxyEmpleados;
using Api.Edu.Modelo;

namespace ConexionDB.Patron_Cadena
{
    public abstract class Persona
    {
        protected Persona suc;
        public void SetSucc(Persona suc)
        {
            this.suc = suc;
        }
        public abstract Api.Edu.Modelo.Persona EncontrarUsEm(int codigo, string password);
    }
}
