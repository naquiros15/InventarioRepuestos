using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesDominio;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class AccesoDatosFacturacion
    {
        public static bool banderaError;

        public static bool agregarCliente(Cliente _ClienteNuevo)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Insert into clientes (Identificacion, Telefono, Celular, Direccion, TipoCliente) values (@param_Cedula,@param_Telefono,@param_Celular,@param_Direccion,@param_Tipo)";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Cedula", _ClienteNuevo.Cedula);
                mycomand.Parameters.AddWithValue("@param_Telefono", _ClienteNuevo.Telefono);
                mycomand.Parameters.AddWithValue("@param_Celular", _ClienteNuevo.Celular);
                mycomand.Parameters.AddWithValue("@param_Direccion", _ClienteNuevo.Direccion);
                mycomand.Parameters.AddWithValue("@param_Tipo", _ClienteNuevo.Tipo);
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { banderaError = true; }

            return banderaError;
        }

        public static MySqlDataReader obtenerClientes()
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Select Identificacion from clientes";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { myreader = null; }

            return myreader;
        }
    }
}
