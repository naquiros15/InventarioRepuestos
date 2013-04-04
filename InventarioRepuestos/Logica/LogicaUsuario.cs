using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using MySql.Data.MySqlClient;
using ClasesDominio;

namespace Logica
{
    public class LogicaUsuario
    {
        #region atributos
        public int IdUsuarioActual = -1;
        private Usuario _UsuarioNuevo;
        #endregion

        public Usuario UsuarioNuevo
        {
            get { return _UsuarioNuevo; }
            set { _UsuarioNuevo = value; }
        }

        public bool inicioSesion(string pUsuario, string pClave)
        {
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosUsuario.inicioSesion(pUsuario,pClave);
                while (myreader.Read())
                {
                    IdUsuarioActual = (int)myreader["IdUsuario"];
                }
                if (!(AccesoDatosUsuario.insertarFechaActual(pUsuario, pClave)) && IdUsuarioActual != -1)
                    return false;
                else
                    return true;
            }
            catch (Exception ex) { return true; }
        }

        public bool registrar(string pNombre, string pApellido, string pUsuario, string pClave)
        {
            _UsuarioNuevo = new Usuario();
            _UsuarioNuevo.Nombre1 = pNombre;
            _UsuarioNuevo.Apellido1 = pApellido;
            _UsuarioNuevo.Usuario1 = pUsuario;
            _UsuarioNuevo.Clave1 = pClave;
            return AccesoDatosUsuario.registrar(_UsuarioNuevo);
        }
    }
}
