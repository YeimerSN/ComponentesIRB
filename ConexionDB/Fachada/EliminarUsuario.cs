using ConexionDB.Singleton;
using MySql.Data.MySqlClient;
using Api.Edu.Modelo;

namespace ConexionDB.Fachada
{
    public class EliminarUsuario
    {
        public void eliminarUsuario(Usuario usuario)
        {
            //Intancia del singlenton
            var cadena = ConexionBD.Instance;
            string command = "DELETE FROM `proyectopatrones`.`usuario` WHERE (`idUsuario` = '" + usuario.id + "');";
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
