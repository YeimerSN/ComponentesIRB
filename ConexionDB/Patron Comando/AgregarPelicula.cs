using ConexionDB.Proxy.ProxyPelicula;
using Api.Edu.Modelo;

namespace ConexionDB.Patron_Comando
{
    public class AgregarPelicula:IComando
    {
        private  Pelicula producto { get; set; }
        public AgregarPelicula(Pelicula producto)
        {
            this.producto = producto;
        }
        public void ejecutar()
        {
            //Aca va la logica de agregar u producto
            MetodosPeliculas metodosPeliculas = new MetodosPeliculas();
            metodosPeliculas.agregarPelicula(producto);
        }
    }
}
//https://es.wikipedia.org/wiki/Command_(patr%C3%B3n_de_dise%C3%B1o)