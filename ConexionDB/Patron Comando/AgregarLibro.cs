using ConexionDB.Proxy.ProxyLibros;
using Api.Edu.Modelo;

namespace ConexionDB.Patron_Comando
{
    public class AgregarLibro:IComando
    {
        private  Libro producto { get; set; }
        public AgregarLibro(Libro libro)
        {
            producto = libro;
        }
        public void ejecutar()
        {
            //Aca va la logica de agregar u producto
            MetodosLibro metodosLibro = new MetodosLibro();
            metodosLibro.agregarLibro(producto);
        }
        
    }
}
