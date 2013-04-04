using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using ClasesDominio;

namespace AccesoDatos
{
    public class AccesoDatosUsuario
    {
        public static bool banderaError;

        public static MySqlDataReader inicioSesion(string pUsuario, string pClave)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "select idUsuario from usuarios where Usuario = @param_Usuario and Clave = @param_Clave";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Usuario", pUsuario);
                mycomand.Parameters.AddWithValue("@param_Clave", pClave);
                myreader = mycomand.ExecuteReader();
            }
            catch (MySqlException ex) { myreader = null; }

            return myreader;
        }

        public static bool insertarFechaActual(string pUsuario, string pClave)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "update usuarios set FechaUltimoIngreso = @param_FechaActual where Usuario = @param_Usuario and Clave = @param_Clave";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Usuario", pUsuario);
                mycomand.Parameters.AddWithValue("@param_Clave", pClave);
                mycomand.Parameters.AddWithValue("@param_FechaActual", DateTime.Now);
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { banderaError = true; }
            return banderaError;
        }

        public static bool registrar(Usuario _UsuarioNuevo)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "insert into usuarios (Usuario, Clave, FechaUltimoIngreso, Nombre, Apellido, Activo) values (@param_Usuario,@param_Clave,@param_FechaActual,@param_Nombre,@param_Apellido,@param_Activo)";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Usuario", _UsuarioNuevo.Usuario1);
                mycomand.Parameters.AddWithValue("@param_Clave", _UsuarioNuevo.Clave1);
                mycomand.Parameters.AddWithValue("@param_FechaActual", DateTime.Now);
                mycomand.Parameters.AddWithValue("@param_Nombre", _UsuarioNuevo.Nombre1);
                mycomand.Parameters.AddWithValue("@param_Apellido", _UsuarioNuevo.Apellido1);
                mycomand.Parameters.AddWithValue("@param_Activo", "1");
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { banderaError = true; }
            return banderaError;
        }
    }
}
