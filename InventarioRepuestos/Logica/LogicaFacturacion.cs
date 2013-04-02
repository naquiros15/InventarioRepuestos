using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using ClasesDominio;
using MySql.Data.MySqlClient;

namespace Logica
{
    public class LogicaFacturacion
    {
        #region atributos

        List<string> _Lista;
        private Cliente _ClienteNuevo;
        List<string> _ListaModelos;
        bool banderaError;

        #endregion

        #region propiedades

        public Cliente ClienteNuevo
        {
            get { return _ClienteNuevo; }
            set { _ClienteNuevo = value; }
        }

        public List<string> ListaModelos
        {
            get { return _ListaModelos; }
            set { _ListaModelos = value; }
        }

        public List<string> Lista
        {
            get { return _Lista; }
            set { _Lista = value; }
        }

        #endregion

        #region métodos

        public List<string> obtenerClientes()
        {
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosFacturacion.obtenerClientes();
                while (myreader.Read())
                {
                    _Lista.Add(myreader["Identificacion"].ToString());

                }
                return _Lista;
            }
            catch (Exception ex) { return null; }
        }

        public List<string> obtenerCantidad()
        {
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosFacturacion.obtenerClientes();
                while (myreader.Read())
                {
                    _Lista.Add(myreader["Identificacion"].ToString());

                }
                return _Lista;
            }
            catch (Exception ex) { return null; }
        }

        public string obtenerFecha()
        {
            string fechaActual = DateTime.Now.ToString();
            return fechaActual;
        }



        public Boolean agregarCliente(int id, int tel, int cel, string dir, string tipo)
        {
            _ClienteNuevo = new Cliente();
            _ClienteNuevo.Cedula = id;
            _ClienteNuevo.Telefono = tel;
            _ClienteNuevo.Celular = cel;
            _ClienteNuevo.Direccion = dir;
            _ClienteNuevo.Tipo = tipo;

            return AccesoDatosFacturacion.agregarCliente(_ClienteNuevo);
        }

        #endregion
    }
}