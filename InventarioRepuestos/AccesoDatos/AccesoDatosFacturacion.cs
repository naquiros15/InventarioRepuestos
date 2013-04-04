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
                string query = "Select idCliente,Identificacion from clientes";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { myreader = null; }

            return myreader;
        }

        public static MySqlDataReader obtenerRepuesto(int idRepuesto)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "select repuestos.NumeroParte, tipoRepuestos.Descripcion, marcas.Descripcion, modelos.Descripcion, estilos.Descripcion, combustibles.Descripcion," +
                 "repuestos.Inventario, repuestos.PrecioUnitario, repuestos.Descripcion, vehiculos.Ano from repuestos inner join tiporepuestos ON tiporepuestos.IdTipo " +
                 "= repuestos.IdTipo and repuestos.IdRepuesto = @param_idRepuesto inner join vehiculos ON repuestos.IdVehiculo = vehiculos.IdVehiculo  inner join modelos ON vehiculos.IdModelo = modelos.IdModelo " +
                 "inner join marcas ON marcas.IdMarca = modelos.IdMarca and vehiculos.IdMarca = marcas.IdMarca  inner join estilos ON vehiculos.IdEstilo = estilos.IdEstilo inner join combustibles ON " +
                 "vehiculos.IdCombustible = combustibles.IdCombustible";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_idRepuesto", idRepuesto);
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { myreader = null; }

            return myreader;
        }

        public static bool agregarFactura(Factura _FacturaNueva)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Insert into facturas (IdCliente, Estado, Monto, Fecha, IdUsuarioFactura) values (@param_IdCliente,@param_Estado"+
                ",@param_Monto,@param_Fecha,@param_UsuarioFactura)";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_IdCliente", _FacturaNueva.IdCliente);
                mycomand.Parameters.AddWithValue("@param_Estado", _FacturaNueva.Estado);
                mycomand.Parameters.AddWithValue("@param_Fecha", _FacturaNueva.Fecha);
                mycomand.Parameters.AddWithValue("@param_Monto", _FacturaNueva.Monto);
                mycomand.Parameters.AddWithValue("@param_UsuarioFactura", _FacturaNueva.UsuarioFactura);
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { banderaError = true; }

            return banderaError;
        }

        public static bool agregarFacturaDetalles(Factura _FacturaNueva)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "insert into facturadetalles (IdFactura, IdRepuesto, Monto, Cantidad) select (select max(IdFactura) from facturas), @param_IdRepuesto, @param_Monto, @param_Cantidad";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Cantidad", _FacturaNueva.Cantidad);
                mycomand.Parameters.AddWithValue("@param_Monto", _FacturaNueva.Monto);
                mycomand.Parameters.AddWithValue("@param_IdRepuesto", _FacturaNueva.IdRepuesto);
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { banderaError = true; }

            return banderaError;
        }
    }
}
