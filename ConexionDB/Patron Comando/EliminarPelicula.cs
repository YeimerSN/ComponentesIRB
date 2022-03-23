
using ConexionDB.Proxy.ProxyPelicula;
using Api.Edu.Modelo;

namespace ConexionDB.Patron_Comando
{
    public class EliminarPelicula : IComando
    {
        private Pelicula producto { get; set; }
        public EliminarPelicula(Pelicula producto)
        {
            this.producto = producto;
        }
        public void ejecutar()
        {
            //Aca va la logica de eliminar producto
            MetodosPeliculas metodosPeliculas = new MetodosPeliculas();
            metodosPeliculas.eliminarPelicula(producto);
        }
    }
}
