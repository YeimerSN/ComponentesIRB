using Api.Edu.Interfaces;
using ConexionDB.Patron_Cadena;

namespace Logger.Edu.Logica
{
    public class Loggeador : ILogger
    {
        public object loggear(int codigo, string password)
        {
            Persona h1 = new Usuario();
            Persona h2 = new Empleado();

            h1.SetSucc(h2);

            return h1.EncontrarUsEm(codigo, password);

        }
    }
}
