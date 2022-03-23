﻿using ConexionDB.Singleton;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Api.Edu.Modelo;

namespace ConexionDB.Proxy.ProxyPrestamo
{
    public class ControlPrestamos : AccionesPrestamos
    {
        public override void agregarPrestamo(Prestamo prestamo)
        {
            //Intancia del singlenton
            var cadena = ConexionBD.Instance;
            string command = "INSERT INTO prestamo (idPrestamo, idLibroP, idPeliculaP, idUsuario) VALUES ('"+prestamo.idPrestamo+"', '"+prestamo.idLibroP+"', '"+prestamo.idPeliculaP+"', '"+prestamo.idUsuario+"')";
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

        public override void editarPrestamo(Prestamo prestamo)
        {
            //Intancia del singlenton
            var cadena = ConexionBD.Instance;
            string command = "UPDATE `proyectopatrones`.`prestamo` SET `idLibroP` = '" + prestamo.idLibroP + "', `idPeliculaP` = '" + prestamo.idPeliculaP + "', `idUsuario` = '" + prestamo.idUsuario + "' WHERE (`idPrestamo` = '" + prestamo.idPrestamo + "');";
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

        public override void eliminarPrestamo(Prestamo prestamo)
        {
            //Intancia del singlenton
            var cadena = ConexionBD.Instance;
            string command = "DELETE FROM `proyectopatrones`.`prestamo` WHERE (`idPrestamo` = '" + prestamo.idPrestamo + "');";
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

        public override List<Prestamo> leerPrestamo()
        {
            //Intancia del singlenton
            var cadena = ConexionBD.Instance;
            string command = "SELECT * FROM proyectopatrones.prestamo;";
            List<Prestamo> listaPrestamo = new List<Prestamo>();
            var conexion = cadena.connection;
            try
            {
                conexion.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(command, conexion);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    var a = new Prestamo();
                    a.idPrestamo = Int32.Parse(mySqlDataReader[0].ToString());
                    try
                    {
                        a.idLibroP = Int32.Parse(mySqlDataReader[1].ToString());
                    }
                    catch (Exception)
                    {

                        a.idLibroP = null;
                    }
                    try
                    {
                        a.idPeliculaP = Int32.Parse(mySqlDataReader[2].ToString());
                    }
                    catch (Exception)
                    {

                        a.idPeliculaP = null;
                    }
                    a.idUsuario = Int32.Parse(mySqlDataReader[3].ToString());
                    listaPrestamo.Add(a);
                    //Console.WriteLine(mySqlDataReader[0] + "--" + mySqlDataReader[1]);
                }
                mySqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conexion.Close();
            return listaPrestamo;
        }
    }
}
