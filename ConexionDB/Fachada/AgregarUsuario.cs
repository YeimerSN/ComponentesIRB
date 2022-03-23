using ConexionDB.Singleton;
using MySql.Data.MySqlClient;
using Api.Edu.Modelo;

namespace ConexionDB.Fachada
{
    public class AgregarUsuario
    {
        public void agregarUsuario(Usuario usuario)
        {
            //Intancia del singlenton
            var cadena = ConexionBD.Instance;
            string command = "INSERT INTO `proyectopatrones`.`usuario` (`CodLoginUsuario`, `ContraUsuario`, `NombreUsuario`, `DirecUsuario`) VALUES ('" + usuario.codigo + "', '" + usuario.pass + "', '" + usuario.nombre + "', '" + usuario.direccion + "');";
            using (cadena.connection)
            {
                using (MySqlCommand mySqlCommand = new MySqlCommand(command))
                {
                    mySqlCommand.Connection = cadena.connection;
                    cadena.connection.Open();
                    mySqlCommand.ExecuteNonQuery();
                }
            }

        }
    }
}
