using ConexionDB.Proxy.ProxyPelicula;
using Api.Edu.Modelo;

namespace ConexionDB.Patron_Comando
{
    public class EditarPelicula: IComando
    {
        private Pelicula producto { get; set; }
        public EditarPelicula(Pelicula pelicula)
        {
            producto = pelicula;
        }
        public void ejecutar()
        {
            //Aca va la logica de editar producto
            MetodosPeliculas metodosPeliculas = new MetodosPeliculas();
            metodosPeliculas.editarPelicula(producto);
        }
    }
}
