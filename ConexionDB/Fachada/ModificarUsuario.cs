using MySql.Data.MySqlClient;
using ConexionDB.Singleton;
using Api.Edu.Modelo;

namespace ConexionDB.Fachada
{
    public class ModificarUsuario
    {
        public void modificarUsuario(Usuario usuario)
        {
            //Intancia del singlenton
            var cadena = ConexionBD.Instance;
            string command = "UPDATE `proyectopatrones`.`usuario` SET `CodLoginUsuario` = '" + usuario.codigo + "', `ContraUsuario` = '" + usuario.pass + "', `NombreUsuario` = '" + usuario.nombre + "', `DirecUsuario` = '" + usuario.direccion + "' WHERE (`idUsuario` = '" + usuario.id + "');";
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
