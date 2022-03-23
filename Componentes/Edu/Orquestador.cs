using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Edu.Interfaces;
using Api.Edu.Utilidades;

namespace Componentes.Edu
{
    public class Orquestador : IModerador
    {
        public void moderar()
        {
            //string ruta = Directory.GetCurrentDirectory();
            string ruta = @"C:\Users\Portatil\source\repos\ProyectoIRB\OrquestadorFinal\Front";
            //ruta = Path.Combine(ruta, "Front");
            Console.WriteLine("Front");
            Cargador car = new Cargador(ruta);
            Type tipo = null;
            try
            {
                tipo = car.getClase("Api.Edu.Interfaces.IComunidad");
                dynamic ent = Activator.CreateInstance(tipo);
                Console.WriteLine(ent.registrarUsuario(new Usuario()));
                Console.WriteLine(ent.modificarUsuario(0, new Usuario()));
                Console.WriteLine(ent.eliminarUsuario(0));
            }
            catch (Exception exc)
            {
                Console.WriteLine("No hay proveedor de interfaz comunidad");
            }

            try
            {
                tipo = car.getClase("Api.Edu.Interfaces.IDomicilio");
                dynamic ent = Activator.CreateInstance(tipo);
                Console.WriteLine(ent.generarDomicilio(0, new Domicilio()));
                Console.WriteLine(ent.cancelarDomicilio(0, new Domicilio()));
            }
            catch (Exception exc)
            {
                Console.WriteLine("No hay proveedor de interfaz domicilio");
            }

            try
            {
                tipo = car.getClase("Api.Edu.Interfaces.IAccecibilidad");
                dynamic ent = Activator.CreateInstance(tipo);
                Console.WriteLine(ent.loggearUsuario(new Usuario()));
            }
            catch (Exception exc)
            {
                Console.WriteLine("No hay proveedor de interfaz accecibilidad");
            }

            //ruta = Directory.GetCurrentDirectory();
            //ruta = Path.Combine(ruta, "Back");
            ruta = @"C:\Users\Portatil\source\repos\ProyectoIRB\OrquestadorFinal\Back";
            Console.WriteLine("");
            Console.WriteLine("Back");
            car = new Cargador(ruta);
            try
            {
                tipo = car.getClase("Api.Edu.Interfaces.IInventario");
                dynamic core = Activator.CreateInstance(tipo);
                Console.WriteLine(core.agregarLibro(new Libro()));
                Console.WriteLine(core.eliminarLibro(0));
            }
            catch (Exception exc)
            {
                Console.WriteLine("No hay proveedor de inventario");
            }

            try
            {
                tipo = car.getClase("Api.Edu.Interfaces.ISolicitudes");
                dynamic core = Activator.CreateInstance(tipo);
                Console.WriteLine(core.generarPrestamo(0, new Usuario()));
                Console.WriteLine(core.devolverPrestamo(0, new Usuario()));
            }
            catch (Exception exc)
            {
                Console.WriteLine("No hay proveedor de solicitudes");
                Console.WriteLine(exc);
            }
        }
        static void Main(string[] args)
        {
            new Orquestador().moderar();
            Console.WriteLine("\nFunciona");
        }
    }
}
