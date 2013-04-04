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
        public List<string> _Lista;
        public List<string> _ListaTipos;        
        List<string> _ListaModeloXMarca;
        List<string> _ListaMarcas;
        List<string> _ListaEstilos;
        List<string> _ListaCombustibles;
        List<string> _ListaModelos;
        public List<RepuestoD> _ListaRepuestos;
        public List<RepuestoVehiculos> _ListaRepuestosV;
        public List<RepuestoT> _ListaRepuestosT;
        public List<RepuestoM> _ListaRepuestosM;
        public List<RepuestoMa> _ListaRepuestosMa;
        public List<RepuestoDe> _ListaRepuestosDe;
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

        public List<RepuestoVehiculos> ListaRepuestosV
        {
            get { return _ListaRepuestosV; }
            set { _ListaRepuestosV = value; }
        }

        public List<RepuestoT> ListaRepuestosT
        {
            get { return _ListaRepuestosT; }
            set { _ListaRepuestosT = value; }
        }

        public List<RepuestoM> ListaRepuestosM
        {
          get { return _ListaRepuestosM; }
          set { _ListaRepuestosM = value; }
        }

        public List<RepuestoMa> ListaRepuestosMa
        {
          get { return _ListaRepuestosMa; }
          set { _ListaRepuestosMa = value; }
        }

        public List<RepuestoDe> ListaRepuestosDe
        {
          get { return _ListaRepuestosDe; }
          set { _ListaRepuestosDe = value; }
        }

        public List<string> ListaMarcas
        {
            get { return _ListaMarcas; }
            set { _ListaMarcas = value; }
        }

        public List<string> ListaEstilos
        {
            get { return _ListaEstilos; }
            set { _ListaEstilos = value; }
        }

        public List<string> ListaCombustibles
        {
            get { return _ListaCombustibles; }
            set { _ListaCombustibles = value; }
        }

        public List<string> ListaModeloXMarca
        {
            get { return _ListaModeloXMarca; }
            set { _ListaModeloXMarca = value; }
        }

        public List<string> ListaTipos
        {
            get { return _ListaTipos; }
            set { _ListaTipos = value; }
        }

        #endregion

        #region métodos

        public List<string> obtenerTipo()
        {
            _ListaTipos = new List<string>();
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerTipoRepuestos();
                while (myreader.Read())
                {
                    _ListaTipos.Add(myreader["IdTipo"].ToString());
                    _Lista.Add(myreader["Descripcion"].ToString());
                }
                return _Lista;
            }
            catch (Exception ex) { return null; }
        }


        public List<string> obtenerMarca()
        {
            _ListaMarcas = new List<string>();
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerMarca();
                while (myreader.Read())
                {
                    _ListaMarcas.Add(myreader["IdMarca"].ToString());
                    _Lista.Add(myreader["Descripcion"].ToString());
                }
                return _Lista;
            }
            catch (Exception ex) { return null; }
        }

        //Obtiene el id y la descripcion de los modelos de una marca
        public List<string> obtenerModelo(int marca)
        {
            _ListaModeloXMarca = new List<string>();
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerModelo(marca);
                while (myreader.Read())
                {
                    _ListaModeloXMarca.Add(myreader["IdModelo"].ToString());
                    _Lista.Add(myreader["Descripcion"].ToString());
                }
                return _Lista;
            }
            catch (Exception ex) { return null; }
        }


        public List<string> obtenerEstilo()
        {
            _ListaEstilos = new List<string>();
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerEstilo();
                while (myreader.Read())
                {
                    _ListaEstilos.Add(myreader["IdEstilo"].ToString());
                    _Lista.Add(myreader["Descripcion"].ToString());
                }
                return _Lista;
            }
            catch (Exception ex) { return null; }
        }



        public List<string> obtenerCombustible()
        {
            _ListaCombustibles = new List<string>();
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerCombustible();
                while (myreader.Read())
                {
                    _ListaCombustibles.Add(myreader["IdCombustible"].ToString());
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

        //obtiene todos los modelos almacenados
        public List<string> obtenerModelos()
        {
            _ListaModelos = new List<string>();
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerModelos();
                while (myreader.Read())
                {
                    _ListaModelos.Add(myreader["IdModelo"].ToString());
                    _Lista.Add(myreader["Descripcion"].ToString());
                }
                return _Lista;
            }
            catch (Exception ex) { return null; }
        }

        
        public void PorVehiculo(int pMarca, int pModelo, int pEstilo, int pCombustible, int pAnio)
        {
            int cuenta;
            int idVehiculo = 0;
            _ListaRepuestosV = new List<RepuestoVehiculos>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerRepuestosPorVehiculo(Int32.Parse(_ListaMarcas[pMarca]), Int32.Parse(_ListaModeloXMarca[pModelo]), 
                    Int32.Parse(_ListaEstilos[pEstilo]), Int32.Parse(_ListaCombustibles[pCombustible]), pAnio);
                while (myreader.Read())
                {
                    idVehiculo = (int)myreader[0];
                }
            }
            catch (Exception ex) { }
            try
            {
                myreader = AccesoDatosConsultas.obtenerRepuestosPorVehiculo2(idVehiculo);
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
            }
            catch (Exception ex) {}
        }
        #endregion

        public void PorDescripcion(string pDescripcion)
        {
            int cuenta;
            _ListaRepuestosDe = new List<RepuestoDe>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerRepuestosPorDescripcion(pDescripcion);
                while (myreader.Read())
                {
                    cuenta = _ListaRepuestosDe.Count;
                    _ListaRepuestosDe.Add(new RepuestoDe());
                    _ListaRepuestosDe.ElementAt(cuenta).NumeroParte = (int)myreader[0];
                    _ListaRepuestosDe.ElementAt(cuenta).Tipo = myreader[1].ToString();
                    _ListaRepuestosDe.ElementAt(cuenta).Marca = myreader[2].ToString();
                    _ListaRepuestosDe.ElementAt(cuenta).Modelo = myreader[3].ToString();
                    _ListaRepuestosDe.ElementAt(cuenta).Estilo = myreader[4].ToString(); ;
                    _ListaRepuestosDe.ElementAt(cuenta).Combustible = myreader[5].ToString();
                    _ListaRepuestosDe.ElementAt(cuenta).Inventario = (int)myreader[6];
                    _ListaRepuestosDe.ElementAt(cuenta).Precio = (decimal)myreader[7];
                    _ListaRepuestosDe.ElementAt(cuenta).Año = (int)myreader[8];
                }
            }
            catch (Exception ex) {}
        }

        public void PorMarca(int pMarca)
        {
             int cuenta;
            _ListaRepuestosMa = new List<RepuestoMa>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerRepuestosPorMarca(Int32.Parse(_ListaMarcas[pMarca]));
                while (myreader.Read())
                {
                    cuenta = _ListaRepuestosMa.Count;
                    _ListaRepuestosMa.Add(new RepuestoMa());
                    _ListaRepuestosMa.ElementAt(cuenta).NumeroParte = (int)myreader[0];
                    _ListaRepuestosMa.ElementAt(cuenta).Tipo = myreader[1].ToString();
                    _ListaRepuestosMa.ElementAt(cuenta).Modelo = myreader[2].ToString();
                    _ListaRepuestosMa.ElementAt(cuenta).Estilo = myreader[3].ToString(); ;
                    _ListaRepuestosMa.ElementAt(cuenta).Combustible = myreader[4].ToString();
                    _ListaRepuestosMa.ElementAt(cuenta).Inventario = (int)myreader[5];
                    _ListaRepuestosMa.ElementAt(cuenta).Precio = (decimal)myreader[6];
                    _ListaRepuestosMa.ElementAt(cuenta).Descripcion = myreader[7].ToString();
                    _ListaRepuestosMa.ElementAt(cuenta).Año = (int)myreader[8];
                }
            }
            catch (Exception ex) {}
        }

        public void PorModelo(int pModelo)
        {
            int cuenta;
            _ListaRepuestosM = new List<RepuestoM>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerRepuestosPorModelo(Int32.Parse(_ListaModelos[pModelo]));
                while (myreader.Read())
                {
                    cuenta = _ListaRepuestosM.Count;
                    _ListaRepuestosM.Add(new RepuestoM());
                    _ListaRepuestosM.ElementAt(cuenta).NumeroParte = (int)myreader[0];
                    _ListaRepuestosM.ElementAt(cuenta).Tipo = myreader[1].ToString();
                    _ListaRepuestosM.ElementAt(cuenta).Marca = myreader[2].ToString();
                    _ListaRepuestosM.ElementAt(cuenta).Estilo = myreader[3].ToString(); ;
                    _ListaRepuestosM.ElementAt(cuenta).Combustible = myreader[4].ToString();
                    _ListaRepuestosM.ElementAt(cuenta).Inventario = (int)myreader[5];
                    _ListaRepuestosM.ElementAt(cuenta).Precio = (decimal)myreader[6];
                    _ListaRepuestosM.ElementAt(cuenta).Descripcion = myreader[7].ToString();
                    _ListaRepuestosM.ElementAt(cuenta).Año = (int)myreader[8];
                }
            }
            catch (Exception ex) {}
        }

        public void PorTipo(int pTipo)
        {
            int cuenta;
            _ListaRepuestosT = new List<RepuestoT>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosConsultas.obtenerRepuestosPorTipo(Int32.Parse(_ListaTipos[pTipo]));
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
            }
            catch (Exception ex) {}
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
