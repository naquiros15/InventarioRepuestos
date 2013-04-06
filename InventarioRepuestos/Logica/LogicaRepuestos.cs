using System;
using System.Collections.Generic;
using System.Linq;
using ClasesDominio;
using MySql.Data.MySqlClient;
using AccesoDatos;

namespace Logica
{
    public class LogicaRepuestos
    {
        #region atributos
        List<string> _Lista;
        List<string> _ListaModelos;
        public List<RepuestoD> _ListaRepuestos;
        List<int> _ListaIdRepuestos;
        private Repuesto _RepuestoNuevo;
        private RepuestoM _RepuestoActualizado;
        bool banderaError;

        #endregion


        #region propiedades
        public Repuesto RepuestoNuevo
        {
            get { return _RepuestoNuevo; }
            set { _RepuestoNuevo = value; }
        }
        public List<RepuestoD> ListaRepuestos
        {
            get { return _ListaRepuestos; }
            set { _ListaRepuestos = value; }
        }
        public List<int> ListaIdRepuestos
        {
            get { return _ListaIdRepuestos; }
            set { _ListaIdRepuestos = value; }
        }

        public List<string> ListaModelos
        {
            get { return _ListaModelos; }
            set { _ListaModelos = value; }
        }

        #endregion


        #region métodos

        public List<string>  obtenerTipo()
        {
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosRepuestos.obtenerTipoRepuestos();
                while (myreader.Read())
                {
                    _Lista.Add(myreader["Descripcion"].ToString());
                }
                return _Lista;
            }
            catch (Exception ex) { return null; }
        }


        public List<string> obtenerMarca()
        {
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosRepuestos.obtenerMarca();
                while (myreader.Read())
                {
                    _Lista.Add(myreader["Descripcion"].ToString());
                }
                return _Lista;
            }
            catch (Exception ex) { return null; }
        }


        public List<string> obtenerModelo(int marca)
        {
            _ListaModelos = new List<string>();
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosRepuestos.obtenerModelo(marca);
                while (myreader.Read())
                {
                    _ListaModelos.Add(myreader["IdModelo"].ToString());
                    _Lista.Add(myreader["Descripcion"].ToString());
                }
                return _Lista;
            }
            catch (Exception ex) { return null; }
        }


        public List<string> obtenerEstilo()
        {
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosRepuestos.obtenerEstilo();
                while (myreader.Read())
                {
                    _Lista.Add(myreader["Descripcion"].ToString());
                }
                return _Lista;
            }
            catch (Exception ex) { return null; }
        }



        public List<string> obtenerCombustible()
        {
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosRepuestos.obtenerCombustible();
                while (myreader.Read())
                {
                    _Lista.Add(myreader["Descripcion"].ToString());
                }
                return _Lista;
            }
            catch (Exception ex) { return null; }
        }



        public List<string> obtenerAnio()
        {
            _Lista = new List<string>();
            int Y = DateTime.Now.Year;
            while (1906 < Y)
            {
                _Lista.Add(Y.ToString());
                Y--;
            }
            return _Lista;
        }

        public Boolean agregarRespuesto(int numeroParte, int idTipo, int idMarca, int idModelo, int idEstilo, int idCombustible, string descripcionV, int anio, int inventario, string descripcion, int precio)
        {
            int idVehiculo = -1;

            _RepuestoNuevo = new Repuesto();
            _RepuestoNuevo.NumeroParte = numeroParte;
            _RepuestoNuevo.IdTipo = idTipo;
            _RepuestoNuevo.IdMarca = idMarca;
            _RepuestoNuevo.IdModelo = Int32.Parse(_ListaModelos[idModelo]);
            _RepuestoNuevo.IdEstilo = idEstilo;
            _RepuestoNuevo.IdCombustible = idCombustible;
            _RepuestoNuevo.DescripcionVehiculo = descripcionV;
            _RepuestoNuevo.Anio = anio;
            _RepuestoNuevo.Inventario = inventario;
            _RepuestoNuevo.Descripcion = descripcion;
            _RepuestoNuevo.Precio = (decimal)precio;

            MySqlDataReader myreader;
            myreader = AccesoDatosRepuestos.buscarIdVehiculo(_RepuestoNuevo);

            while (myreader.Read())
            {
                idVehiculo = (int)myreader[0];
            }
            if(idVehiculo == -1)
            {
                AccesoDatosRepuestos.insertarVehiculo(_RepuestoNuevo);
                return AccesoDatosRepuestos.insertarRepuestoNuevoVehiculo(_RepuestoNuevo);

            }
            else
                return AccesoDatosRepuestos.insertarRepuesto(_RepuestoNuevo, idVehiculo) ;
        }

        public object obtenerRepuestos()
        {
            int cuenta;
            _ListaIdRepuestos = new List<int>();
            _ListaRepuestos = new List<RepuestoD>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosRepuestos.obtenerRepuestos();
                while (myreader.Read())
                {
                    cuenta = _ListaRepuestos.Count;
                    _ListaRepuestos.Add(new RepuestoD());
                    _ListaRepuestos.ElementAt(cuenta).NumeroParte = (int)myreader[0];
                    _ListaRepuestos.ElementAt(cuenta).Tipo = myreader[1].ToString();
                    _ListaRepuestos.ElementAt(cuenta).Marca = myreader[2].ToString();
                    _ListaRepuestos.ElementAt(cuenta).Modelo = myreader[3].ToString();
                    _ListaRepuestos.ElementAt(cuenta).Estilo = myreader[4].ToString(); ;
                    _ListaRepuestos.ElementAt(cuenta).Combustible = myreader[5].ToString();
                    _ListaRepuestos.ElementAt(cuenta).Inventario = (int)myreader[6];
                    _ListaRepuestos.ElementAt(cuenta).Precio = (decimal)myreader[7];
                    _ListaRepuestos.ElementAt(cuenta).Descripcion = myreader[8].ToString();
                    _ListaRepuestos.ElementAt(cuenta).Año = (int)myreader[9];
                    _ListaRepuestos.ElementAt(cuenta).DescripcionVehiculo = myreader[10].ToString();
                    _ListaIdRepuestos.Add((int)myreader[11]);
                }
                return _ListaRepuestos;
            }
            catch (Exception ex) { return null; }
        }

        public void obtenerIdRepuestos()
        {
            int cuenta;
            _ListaIdRepuestos = new List<int>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosRepuestos.obtenerIdRepuestos();
                while (myreader.Read())
                {
                    cuenta = _ListaIdRepuestos.Count;
                    _ListaIdRepuestos.Add((int)myreader[0]);
                }
            }
            catch (Exception ex) {}
        }

        public bool borrarRepuesto(int pIndiceRepuesto)
        {
            obtenerIdRepuestos();
            return AccesoDatosRepuestos.borrarRepuesto(_ListaIdRepuestos[pIndiceRepuesto]);
        }


        public bool guardarDatosRepuesto(string pNumeroParte, string pInventario, string pDescripcion, string pPrecioUnitario, string pTipo, string pMarca, string pModelo, string pCombustible, string pEstilo, string pAnio, string pDescripcionV, int IdRepuesto)
        {
            int idVehiculo = -1;
            MySqlDataReader myreader;
            myreader = AccesoDatosRepuestos.buscarIdVehiculoRepuestoActualizado(pMarca, pModelo, pCombustible, pEstilo, pAnio, pDescripcionV);

            while (myreader.Read())
            {
                idVehiculo = (int)myreader[0];
            }
            //en caso de que el vehiculo del repuesto no exista

            if (idVehiculo == -1)
            {
                 AccesoDatosRepuestos.insertarVehiculoRepuestoActualizado(pMarca, pModelo, pCombustible, pEstilo, pAnio, pDescripcionV);
                 myreader = AccesoDatosRepuestos.seleccionarNuevoVehiculo();
                 while (myreader.Read())
                 {
                     idVehiculo = (int)myreader[0];
                 }
            }
                Repuesto repuestoNuevo = new Repuesto();
                repuestoNuevo.NumeroParte = int.Parse(pNumeroParte);
                repuestoNuevo.Inventario = int.Parse(pInventario);
                repuestoNuevo.Precio = decimal.Parse(pPrecioUnitario);
                repuestoNuevo.Descripcion = pDescripcion;
                AccesoDatosRepuestos.borrarRepuesto(IdRepuesto);
                if (AccesoDatosRepuestos.numeroError == 1451) 
                {
                    AccesoDatosRepuestos.numeroError = 0;
                    Exception e = new Exception("El Repuesto no se puede modificar, debido a que se encuentra dentro de una factura pendiente");
                    e.Source = "Factura";
                    throw e;
                }
                return AccesoDatosRepuestos.actualizarRepuesto(repuestoNuevo, pTipo, idVehiculo);
        }

        #endregion

    }
}
