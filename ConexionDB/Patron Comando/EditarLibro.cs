using ConexionDB.Proxy.ProxyLibros;
using Api.Edu.Modelo;

namespace ConexionDB.Patron_Comando
{
    public class EditarLibro: IComando
    {
        private Libro producto { get; set; }
        public EditarLibro(Libro producto)
        {
            this.producto = producto;
        }
        public void ejecutar()
        {
            //Aca va la logica de editar producto
            MetodosLibro metodosLibro = new MetodosLibro();
            metodosLibro.editarLibro(producto);
        }
    }
}
