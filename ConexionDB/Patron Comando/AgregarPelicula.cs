using ConexionDB.Proxy.ProxyPelicula;
using Api.Edu.Modelo;

namespace ConexionDB.Patron_Comando
{
    public class AgregarPelicula:IComando
    {
        private  Pelicula producto { get; set; }
        public AgregarPelicula(Pelicula pelicula)
        {
            producto = pelicula;
        }
        public void ejecutar()
        {
            //Aca va la logica de agregar u producto
            MetodosPeliculas metodosPeliculas = new MetodosPeliculas();
            metodosPeliculas.agregarPelicula(producto);
        }
    }
}