using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using ClasesDominio;
using MySql.Data.MySqlClient;

namespace Logica
{
    public class LogicaConsultas
    {
        #region atributos
        List<string> _Lista;
        List<string> _ListaModelos;
        List<RepuestoD> _ListaRepuestos;
        List<RepuestoVehiculos> _ListaRepuestosV;
        List<RepuestoT> _ListaRepuestosT;
        List<int> _ListaIdRepuestos;
        private Repuesto _RepuestoNuevo;
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

        private List<RepuestoVehiculos> ListaRepuestosV
        {
            get { return _ListaRepuestosV; }
            set { _ListaRepuestosV = value; }
        }

        private List<RepuestoT> ListaRepuestosT
        {
            get { return _ListaRepuestosT; }
            set { _ListaRepuestosT = value; }
        }
        #endregion

        #region métodos

        public List<string> obtenerTipo()
        {
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerTipoRepuestos();
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
                myreader = AccesoDatosConsultas.obtenerMarca();
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
                myreader = AccesoDatosConsultas.obtenerModelo(marca);
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
                myreader = AccesoDatosConsultas.obtenerEstilo();
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
                myreader = AccesoDatosConsultas.obtenerCombustible();
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


        public List<string> obtenerDescripcion()
        {
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerDescripcion();
                while (myreader.Read())
                {
                    _Lista.Add(myreader["Descripcion"].ToString());
                }
                return _Lista;
            }
            catch (Exception ex) { return null; }
        }

        public List<string> obtenerModelos()
        {
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerModelos();
                while (myreader.Read())
                {
                    _Lista.Add(myreader["Descripcion"].ToString());
                }
                return _Lista;
            }
            catch (Exception ex) { return null; }
        }

        
        public Object PorVehiculo(int pMarca, int pModelo, int pEstilo, int pCombustible, int pAnio)
        {
            int cuenta;
            _ListaRepuestosV = new List<RepuestoVehiculos>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerRepuestosPorVehiculo(pMarca, pModelo, pEstilo, pCombustible, pAnio);
                while (myreader.Read())
                {
                    cuenta = _ListaRepuestosV.Count;
                    _ListaRepuestosV.Add(new RepuestoVehiculos());
                    _ListaRepuestosV.ElementAt(cuenta).NumeroParte = (int)myreader[0];
                    _ListaRepuestosV.ElementAt(cuenta).Tipo = myreader[1].ToString();
                    _ListaRepuestosV.ElementAt(cuenta).Inventario = (int)myreader[2];
                    _ListaRepuestosV.ElementAt(cuenta).Precio = (decimal)myreader[3];
                    _ListaRepuestosV.ElementAt(cuenta).Descripcion = myreader[4].ToString();
                }
                return _ListaRepuestosV;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        public void PorDescripcion(int p)
        {
            throw new NotImplementedException();
        }

        public void PorMarca(int p)
        {
            throw new NotImplementedException();
        }

        public void PorModelo(int p)
        {
            throw new NotImplementedException();
        }

        public Object PorTipo(int pTipo)
        {
            int cuenta;
            _ListaRepuestosT = new List<RepuestoT>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerRepuestosPorTipo(pTipo);
                while (myreader.Read())
                {
                    cuenta = _ListaRepuestosT.Count;
                    _ListaRepuestosT.Add(new RepuestoT());
                    _ListaRepuestosT.ElementAt(cuenta).NumeroParte = (int)myreader[0];
                    _ListaRepuestosT.ElementAt(cuenta).Marca = myreader[1].ToString();
                    _ListaRepuestosT.ElementAt(cuenta).Modelo = myreader[2].ToString();
                    _ListaRepuestosT.ElementAt(cuenta).Estilo = myreader[3].ToString(); ;
                    _ListaRepuestosT.ElementAt(cuenta).Combustible = myreader[4].ToString();
                    _ListaRepuestosT.ElementAt(cuenta).Inventario = (int)myreader[5];
                    _ListaRepuestosT.ElementAt(cuenta).Precio = (decimal)myreader[6];
                    _ListaRepuestosT.ElementAt(cuenta).Descripcion = myreader[7].ToString();
                    _ListaRepuestosT.ElementAt(cuenta).Año = (int)myreader[8];
                }
                return _ListaRepuestosT;
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
            catch (Exception ex) { }
        }

        public bool borrarRepuesto(int pIndiceRepuesto)
        {
            obtenerIdRepuestos();
            return AccesoDatosRepuestos.borrarRepuesto(_ListaIdRepuestos[pIndiceRepuesto]);
        }
    }
}
