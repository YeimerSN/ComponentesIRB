using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace Api.Edu.Utilidades
{
    public class Componente
    {
        public Componente(Type fachada, Assembly dll)
        {
            this.fachada = fachada;
            this.dll = dll;
        }
        public Type fachada;
        public Assembly dll;
    }
    public class Cargador
    {
        string dir;
        Dictionary<string, Componente> componentes = new Dictionary<string, Componente>();
        public Cargador(string dir)
        {
            this.dir = dir;
        }
        private Type getTipo(Type[] tipos, string nombre)
        {
            foreach (Type tipo in tipos)
            {
                if ((tipo.IsPublic || tipo.IsNestedPublic) && !tipo.IsAbstract)
                {
                    if (tipo.GetInterface(nombre, true) != null)
                    {
                        return tipo;
                    }
                }
            }
            return null;
        }
        private Componente cargarComponentes(string nombre)
        {
            string[] archivos = Directory.GetFiles(dir, "*.dll");
            if (archivos != null && archivos.Length > 0)
            {
                for (int i = 0; i < archivos.Length; i++)
                {
                    Type tipo = getTipo(Assembly.LoadFile(archivos[i]).GetTypes(), nombre);
                    if (tipo != null)
                    {
                        Componente componente = new Componente(tipo, Assembly.LoadFile(archivos[i]));
                        componentes.Add(nombre, componente);
                        return componente;
                    }
                }
            }
            return null;
        }

        public Type getClase(string nombre)
        {
            if (nombre != null && nombre.Length > 0)
            {
                Componente dll_fachada = null;
                try
                {
                    dll_fachada = componentes[nombre];
                }
                catch (Exception exc)
                {
                    dll_fachada = cargarComponentes(nombre);
                }
                return dll_fachada.fachada;
            }
            return null;
        }
        static void Main(string[] args)
        {
            /*
            string ruta = @"C:\Users\Portatil\source\repos\ProyectoIRB\Api\bin\Debug\net6.0\";  //Revisar
            Cargador car = new Cargador(ruta);
            Type tipo = car.getClase("edu.cableado.IEntrada"); //Revisar
            tipo = car.getClase("edu.cableado.IEntrada");
            dynamic ent = Activator.CreateInstance(tipo);
            ent.recibirInformacion();
            */
        }
        /*public class X : IEntrada
        {
            public void recibirInformacion()
            {
                Console.WriteLine("GUI .... ");
            }
        }*/
    }
}