using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesDominio;
using System;
using System.Collections.Generic;
using AccesoDatos;
using ClasesDominio;
using MySql.Data.MySqlClient;
using AccesoDatos;
using System.Data;


namespace AccesoDatos
{
    public class AccesoDatosRepuestos
    {
        public static bool banderaError;

        public static MySqlDataReader obtenerTipoRepuestos()
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Select * From tiporepuestos";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                myreader = mycomand.ExecuteReader();
            }
            catch (MySqlException ex) {myreader = null;}
            return myreader;
        }

        public static MySqlDataReader obtenerMarca()
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Select * From marcas";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                myreader = mycomand.ExecuteReader();
            }
            catch (MySqlException ex) { myreader = null; }
            return myreader;
        }

        public static MySqlDataReader obtenerModelo(int marca)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Select * From modelos where IdMarca = @param_Marca";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Marca", marca);
                myreader = mycomand.ExecuteReader();
            }
            catch (MySqlException ex) { myreader = null; }
            return myreader;
        }


        public static MySqlDataReader obtenerEstilo()
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Select * From estilos";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                myreader = mycomand.ExecuteReader();
            }
            catch (MySqlException ex) { myreader = null; }
            return myreader;
        }

        public static MySqlDataReader obtenerCombustible()
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Select * From combustibles";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                myreader = mycomand.ExecuteReader();
            }
            catch (MySqlException ex) { myreader = null; }
            return myreader;
        }

        public static MySqlDataReader obtenerRepuestos()
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "select repuestos.NumeroParte, tiporepuestos.Descripcion, marcas.Descripcion, modelos.Descripcion, estilos.Descripcion, combustibles.Descripcion, "+
                "repuestos.Inventario, repuestos.PrecioUnitario, repuestos.Descripcion, vehiculos.Ano from repuestos inner join tiporepuestos ON tiporepuestos.IdTipo"+ 
                "= repuestos.IdTipo inner join vehiculos ON repuestos.IdVehiculo = vehiculos.IdVehiculo  inner join modelos ON vehiculos.IdModelo = modelos.IdModelo "+
                "inner join marcas ON marcas.IdMarca = modelos.IdMarca and vehiculos.IdMarca = marcas.IdMarca  inner join estilos ON vehiculos.IdEstilo = estilos.IdEstilo inner join combustibles ON "+
                "vehiculos.IdCombustible = combustibles.IdCombustible";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                myreader = mycomand.ExecuteReader();
            }
            catch (MySqlException ex) { myreader = null; }

            return myreader;
        }

        public static MySqlDataReader obtenerIdRepuestos()
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "select IdRepuesto from repuestos";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                myreader = mycomand.ExecuteReader();
            }
            catch (MySqlException ex) { myreader = null; }

            return myreader;
        }

        //busca el id del vehiculo del repuesto que se va a agregar
        public static MySqlDataReader buscarIdVehiculo(Repuesto _RespuestoNuevo)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Select IdVehiculo from vehiculos where IdMarca = @param_Marca AND IdModelo = @param_Modelo AND IdEstilo = " +
                "@param_Estilo AND Ano = @param_Anio AND IdCombustible = @param_Combustible";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Marca", _RespuestoNuevo.IdMarca);
                mycomand.Parameters.AddWithValue("@param_Modelo", _RespuestoNuevo.IdModelo);
                mycomand.Parameters.AddWithValue("@param_Estilo", _RespuestoNuevo.IdEstilo);
                mycomand.Parameters.AddWithValue("@param_Combustible", _RespuestoNuevo.IdCombustible);
                mycomand.Parameters.AddWithValue("@param_Anio", _RespuestoNuevo.Anio);
                myreader = mycomand.ExecuteReader();
            }
            catch (MySqlException ex) { myreader = null; }

            return myreader;
        }

        //inserta el repuesto con el id del vehiculo encontrado
        public static bool insertarRepuesto(Repuesto _RespuestoNuevo, int IdVehiculo)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Insert into repuestos (idVehiculo, NumeroParte, IdTipo, Inventario, Descripcion, PrecioUnitario) " +
                "select @param_IdVehiculo, @param_Parte,(Select IdTipo from " +
                "tiporepuestos where IdTipo = @param_Tipo), @param_Inventario, @param_Descripcion, @param_Precio";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Parte", _RespuestoNuevo.NumeroParte);
                mycomand.Parameters.AddWithValue("@param_Tipo", _RespuestoNuevo.IdTipo);
                mycomand.Parameters.AddWithValue("@param_Inventario", _RespuestoNuevo.Inventario);
                mycomand.Parameters.AddWithValue("@param_Precio", _RespuestoNuevo.Precio);
                mycomand.Parameters.AddWithValue("@param_Descripcion", _RespuestoNuevo.Descripcion);
                mycomand.Parameters.AddWithValue("@param_IdVehiculo", IdVehiculo);
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { banderaError = true; }

            return banderaError;
        }

        //inserta el vehiculo del nuevo repuesto que se quiere agregar
        public static bool insertarVehiculo(Repuesto _RepuestoNuevo)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "insert into vehiculos (IdMarca, IdModelo, IdCombustible, IdEstilo, Ano, Descripcion) values (@param_Marca,@param_Modelo, @param_Combustible,@param_Estilo,@param_Anio, 'Descripcion')";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Marca", _RepuestoNuevo.IdMarca);
                mycomand.Parameters.AddWithValue("@param_Modelo", _RepuestoNuevo.IdModelo);
                mycomand.Parameters.AddWithValue("@param_Estilo", _RepuestoNuevo.IdEstilo);
                mycomand.Parameters.AddWithValue("@param_Combustible", _RepuestoNuevo.IdCombustible);
                mycomand.Parameters.AddWithValue("@param_Anio", _RepuestoNuevo.Anio);
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { banderaError = true; }
            return banderaError;
        }

        //inserta el nuevo repuesto con el id del vehiculo que se inserto anteriormente
        public static bool insertarRepuestoNuevoVehiculo(Repuesto _RepuestoNuevo)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Insert into repuestos (idVehiculo, NumeroParte, idTipo, Inventario, Descripcion, PrecioUnitario) select (Select max(idVehiculo) " +
                    "from vehiculos), @param_Parte,(Select IdTipo from tiporepuestos where IdTipo = @param_Tipo), @param_Inventario, @param_Descripcion, @param_Precio";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Parte", _RepuestoNuevo.NumeroParte);
                mycomand.Parameters.AddWithValue("@param_Tipo", _RepuestoNuevo.IdTipo);
                mycomand.Parameters.AddWithValue("@param_Inventario", _RepuestoNuevo.Inventario);
                mycomand.Parameters.AddWithValue("@param_Precio", _RepuestoNuevo.Precio);
                mycomand.Parameters.AddWithValue("@param_Descripcion", _RepuestoNuevo.Descripcion);
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { banderaError = true; }

            return banderaError;
        }

        public static bool borrarRepuesto(int _IdRepuesto)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Delete from repuestos where IdRepuesto = @param_IdRepuesto";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_IdRepuesto", _IdRepuesto);
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { banderaError = true; }

            return banderaError;
        }

        //busca el id del vehiculo del repuesto que va a ser actualizado
        public static MySqlDataReader buscarIdVehiculoRepuestoActualizado(string pMarca, string pModelo, string pCombustible, string pEstilo, string pAnio)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Select IdVehiculo from vehiculos inner join marcas ON vehiculos.IdMarca = marcas.IdMarca inner join modelos ON vehiculos.IdModelo = "+
                "modelos.IdModelo inner join estilos ON vehiculos.IdEstilo = estilos.IdEstilo inner join combustibles ON vehiculos.IdCombustible = combustibles.IdCombustible "+
                "where marcas.Descripcion = @param_Marca AND modelos.Descripcion = @param_Modelo AND estilos.Descripcion = @param_Estilo AND vehiculos.Ano = @param_Anio AND "+
                "combustibles.Descripcion = @param_Combustible";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Marca", pMarca);
                mycomand.Parameters.AddWithValue("@param_Modelo", pModelo);
                mycomand.Parameters.AddWithValue("@param_Estilo", pEstilo);
                mycomand.Parameters.AddWithValue("@param_Combustible", pCombustible);
                mycomand.Parameters.AddWithValue("@param_Anio", pAnio);
                myreader = mycomand.ExecuteReader();
            }
            catch (MySqlException ex) { myreader = null; }

            return myreader;
        }

        //inserta el vehiculo del repuesto que va a ser actualizado
        public static bool insertarVehiculoRepuestoActualizado(string pMarca, string pModelo, string pCombustible, string pEstilo, string pAnio)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "insert into vehiculos (IdMarca, IdModelo, IdCombustible, IdEstilo, Ano, Descripcion) select (select IdMarca from marcas "+
                "where @param_Marca = Descripcion),(select IdModelo from modelos where Descripcion = @param_Modelo), (select IdCombustible from combustibles where " +
                "Descripcion = @param_Combustible) ,(select IdEstilo from estilos where Descripcion = @param_Estilo), pAnio, 'Descripcion'";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Marca", pMarca);
                mycomand.Parameters.AddWithValue("@param_Modelo", pModelo);
                mycomand.Parameters.AddWithValue("@param_Estilo", pCombustible);
                mycomand.Parameters.AddWithValue("@param_Combustible", pEstilo);
                mycomand.Parameters.AddWithValue("@param_Anio",pAnio);
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { banderaError = true; }
            return banderaError;
        }

        //inserta el repuesto utilizando el id del vehiculo que se inserto anteriormente
        public static bool insertarRepuestoActualizadoNuevoVehiculo(string pNumeroParte, string pInventario, string pDescripcion, string pPrecioUnitario, string pTipo)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Insert into repuestos (idVehiculo, NumeroParte, idTipo, Inventario, Descripcion, PrecioUnitario) select (Select max(idVehiculo) " +
                    "from vehiculos), @param_Parte,(Select IdTipo from tiporepuestos where Descripcion = @param_Tipo), @param_Inventario, @param_Descripcion, @param_Precio";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Parte", pNumeroParte);
                mycomand.Parameters.AddWithValue("@param_Tipo", pTipo);
                mycomand.Parameters.AddWithValue("@param_Inventario", pInventario);
                mycomand.Parameters.AddWithValue("@param_Precio", pPrecioUnitario);
                mycomand.Parameters.AddWithValue("@param_Descripcion", pDescripcion);
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { banderaError = true; }

            return banderaError;
        }

        //inserta el repuesto con el id del vehiculo que se había encontrado en la base
        public static bool actualizarRepuesto(string pNumeroParte, string pInventario, string pDescripcion, string pPrecioUnitario, string pTipo, int idVehiculo)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Insert into repuestos (idVehiculo, NumeroParte, IdTipo, Inventario, Descripcion, PrecioUnitario) " +
                "select @param_IdVehiculo, @param_Parte,(Select IdTipo from " +
                "tiporepuestos where Descripcion = @param_Tipo), @param_Inventario, @param_Descripcion, @param_Precio";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Parte", pNumeroParte);
                mycomand.Parameters.AddWithValue("@param_Tipo", pTipo);
                mycomand.Parameters.AddWithValue("@param_Inventario", pInventario);
                mycomand.Parameters.AddWithValue("@param_Precio", pPrecioUnitario);
                mycomand.Parameters.AddWithValue("@param_Descripcion", pDescripcion);
                mycomand.Parameters.AddWithValue("@param_IdVehiculo", idVehiculo);
                myreader = mycomand.ExecuteReader();
                banderaError = false;
            }
            catch (MySqlException ex) { banderaError = true; }

            return banderaError;
        }
    }
}
