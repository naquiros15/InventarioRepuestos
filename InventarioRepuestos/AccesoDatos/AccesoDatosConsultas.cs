using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class AccesoDatosConsultas
    {
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
            catch (MySqlException ex) { myreader = null; }
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

        public static MySqlDataReader obtenerDescripcion()
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Select Descripcion From repuestos";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                myreader = mycomand.ExecuteReader();
            }
            catch (MySqlException ex) { myreader = null; }
            return myreader;
        }

        public static MySqlDataReader obtenerModelos()
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "Select * From modelos";
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


        public static MySqlDataReader obtenerRepuestosPorVehiculo(int pMarca, int pModelo, int pEstilo, int pCombustible, int pAnio)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "select IdVehiculo from vehiculos where IdMarca = @param_Marca and IdModelo = @param_Modelo and IdEstilo = "+
                    "@param_Estilo and IdCombustible = @param_Combustible and Ano = @param_Anio";
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

        public static MySqlDataReader obtenerRepuestosPorVehiculo2(int pIdVehiculo)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "select repuestos.NumeroParte, tiporepuestos.Descripcion, repuestos.Inventario, repuestos.PrecioUnitario,"+
                "repuestos.Descripcion from repuestos inner join tiporepuestos ON tiporepuestos.IdTipo = repuestos.IdTipo where IdVehiculo = @param_IdVehiculo";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_IdVehiculo", pIdVehiculo);
                myreader = mycomand.ExecuteReader();
            }
            catch (MySqlException ex) { myreader = null; }
            return myreader;
        }


         public static MySqlDataReader obtenerRepuestosPorTipo(int pTipo)
        {
            MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
            MySqlDataReader myreader;
            conn.Open();
            try
            {
                string query = "select repuestos.NumeroParte, marcas.Descripcion, modelos.Descripcion, estilos.Descripcion, combustibles.Descripcion,"+
                "repuestos.Inventario, repuestos.PrecioUnitario, repuestos.Descripcion, vehiculos.Ano from repuestos inner join tiporepuestos ON tiporepuestos.IdTipo "+
                "= repuestos.IdTipo inner join vehiculos ON repuestos.IdVehiculo = vehiculos.IdVehiculo  inner join modelos ON vehiculos.IdModelo = modelos.IdModelo "+
                "inner join marcas ON marcas.IdMarca = modelos.IdMarca and vehiculos.IdMarca = marcas.IdMarca  inner join estilos ON vehiculos.IdEstilo = estilos.IdEstilo "+
                "inner join combustibles ON vehiculos.IdCombustible = combustibles.IdCombustible  where tiporepuestos.IdTipo = @param_Tipo";
                MySqlCommand mycomand = new MySqlCommand(query, conn);
                mycomand.Parameters.AddWithValue("@param_Tipo", pTipo);
                myreader = mycomand.ExecuteReader();
            }
            catch (MySqlException ex) { myreader = null; }
            return myreader;
        }

         public static MySqlDataReader obtenerRepuestosPorModelo(int pModelo)
         {
             MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
             MySqlDataReader myreader;
             conn.Open();
             try
             {
                 string query = "select repuestos.NumeroParte, marcas.Descripcion, modelos.Descripcion, estilos.Descripcion, combustibles.Descripcion, "+
                "repuestos.Inventario, repuestos.PrecioUnitario, repuestos.Descripcion, vehiculos.Ano from repuestos inner join tiporepuestos ON tiporepuestos.IdTipo "+
                "= repuestos.IdTipo inner join vehiculos ON repuestos.IdVehiculo = vehiculos.IdVehiculo  inner join modelos ON vehiculos.IdModelo = modelos.IdModelo "+
                "inner join marcas ON marcas.IdMarca = modelos.IdMarca and vehiculos.IdMarca = marcas.IdMarca  inner join estilos ON vehiculos.IdEstilo = estilos.IdEstilo "+
                 "inner join combustibles ON vehiculos.IdCombustible = combustibles.IdCombustible where @param_Modelo = modelos.IdModelo";
                 MySqlCommand mycomand = new MySqlCommand(query, conn);
                 mycomand.Parameters.AddWithValue("@param_Modelo", pModelo);
                 myreader = mycomand.ExecuteReader();
             }
             catch (MySqlException ex) { myreader = null; }
             return myreader;
         }

         public static MySqlDataReader obtenerRepuestosPorMarca(int pMarca)
         {
             MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
             MySqlDataReader myreader;
             conn.Open();
             try
             {
                 string query = "select repuestos.NumeroParte, marcas.Descripcion, modelos.Descripcion, estilos.Descripcion, combustibles.Descripcion, "+
                "repuestos.Inventario, repuestos.PrecioUnitario, repuestos.Descripcion, vehiculos.Ano from repuestos inner join tiporepuestos ON tiporepuestos.IdTipo "+
                "= repuestos.IdTipo inner join vehiculos ON repuestos.IdVehiculo = vehiculos.IdVehiculo  inner join modelos ON vehiculos.IdModelo = modelos.IdModelo "+
                "inner join marcas ON marcas.IdMarca = modelos.IdMarca and vehiculos.IdMarca = marcas.IdMarca  inner join estilos ON vehiculos.IdEstilo = estilos.IdEstilo inner join combustibles ON "+
                "vehiculos.IdCombustible = combustibles.IdCombustible where @param_Marca = marcas.IdMarca";
                 MySqlCommand mycomand = new MySqlCommand(query, conn);
                 mycomand.Parameters.AddWithValue("@param_Marca", pMarca);
                 myreader = mycomand.ExecuteReader();
             }
             catch (MySqlException ex) { myreader = null; }
             return myreader;
         }

         public static MySqlDataReader obtenerRepuestosPorDescripcion(string pDescripcion)
         {
             MySqlConnection conn = new MySqlConnection(AccesoDatos._Connection);
             MySqlDataReader myreader;
             conn.Open();
             try
             {
                 string query = "select repuestos.NumeroParte, tipoRepuestos.Descripcion, marcas.Descripcion, modelos.Descripcion, estilos.Descripcion, combustibles.Descripcion," +
                 "repuestos.Inventario, repuestos.PrecioUnitario, vehiculos.Ano from repuestos inner join tiporepuestos ON tiporepuestos.IdTipo " +
                 "= repuestos.IdTipo inner join vehiculos ON repuestos.IdVehiculo = vehiculos.IdVehiculo  inner join modelos ON vehiculos.IdModelo = modelos.IdModelo " +
                 "inner join marcas ON marcas.IdMarca = modelos.IdMarca and vehiculos.IdMarca = marcas.IdMarca  inner join estilos ON vehiculos.IdEstilo = estilos.IdEstilo inner join combustibles ON " +
                 "vehiculos.IdCombustible = combustibles.IdCombustible where repuestos.Descripcion = @param_Descripcion";
                 MySqlCommand mycomand = new MySqlCommand(query, conn);
                 mycomand.Parameters.AddWithValue("@param_Descripcion", pDescripcion);
                 myreader = mycomand.ExecuteReader();
             }
             catch (MySqlException ex) { myreader = null; }
             return myreader;
         }
    }
}
