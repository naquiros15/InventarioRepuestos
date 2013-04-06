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
        List<int> _ListaClientes;
        private Cliente _ClienteNuevo;
        List<string> _ListaModelos;
        List<RepuestoD> _RepuestoSeleccionado;
        List<string> _ListaNombresClientes;
        List<string> _ListaApellidosClientes;
        List<FacturaPro> _ListaProformas;
        List<int> _ListaIdProformas;
        Factura _FacturaNueva;
        private decimal _MontoTotal;

        public decimal MontoTotal
        {
            get { return _MontoTotal; }
            set { _MontoTotal = value; }
        }
        bool banderaError;

        #endregion

        #region propiedades

        public List<FacturaPro> ListaProformas
        {
            get { return _ListaProformas; }
            set { _ListaProformas = value; }
        }

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
        public List<RepuestoD> RepuestoSeleccionado
        {
            get { return _RepuestoSeleccionado; }
            set { _RepuestoSeleccionado = value; }
        }

        public List<int> ListaClientes
        {
            get { return _ListaClientes; }
            set { _ListaClientes = value; }
        }

        public List<string> ListaNombresClientes
        {
            get { return _ListaNombresClientes; }
            set { _ListaNombresClientes = value; }
        }

        public List<string> ListaApellidosClientes
        {
            get { return _ListaApellidosClientes; }
            set { _ListaApellidosClientes = value; }
        }
        #endregion

        #region métodos

        public List<string> obtenerClientes()
        {
            _ListaNombresClientes = new List<string>();
            _ListaApellidosClientes = new List<string>();
            _ListaClientes = new List<int>();
            _Lista = new List<string>();
            MySqlDataReader myreader;
            try
            {
                myreader = AccesoDatosFacturacion.obtenerClientes();
                while (myreader.Read())
                {
                    _ListaClientes.Add((int)myreader["IdCliente"]);
                    _Lista.Add(myreader["Identificacion"].ToString());
                    _ListaNombresClientes.Add(myreader["Nombre"].ToString());
                    _ListaApellidosClientes.Add(myreader["Apellido"].ToString());

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



        public Boolean agregarCliente(int id, string nombre, string apellido, int tel, int cel, string dir, string tipo)
        {
            _ClienteNuevo = new Cliente();
            _ClienteNuevo.Cedula = id;
            _ClienteNuevo.Nombre = nombre;
            _ClienteNuevo.Apellido = apellido;
            _ClienteNuevo.Telefono = tel;
            _ClienteNuevo.Celular = cel;
            _ClienteNuevo.Direccion = dir;
            _ClienteNuevo.Tipo = tipo;

            return AccesoDatosFacturacion.agregarCliente(_ClienteNuevo);
        }


        public object obtenerRepuesto(int idRepuesto)
        {
            int cuenta;
            _RepuestoSeleccionado = new List<RepuestoD>();
            MySqlDataReader myreader;

            try
            {
                myreader = AccesoDatosFacturacion.obtenerRepuesto(idRepuesto);
                while (myreader.Read())
                {
                    cuenta = _RepuestoSeleccionado.Count;
                    _RepuestoSeleccionado.Add(new RepuestoD());
                    _RepuestoSeleccionado.ElementAt(cuenta).NumeroParte = (int)myreader[0];
                    _RepuestoSeleccionado.ElementAt(cuenta).Tipo = myreader[1].ToString();
                    _RepuestoSeleccionado.ElementAt(cuenta).Marca = myreader[2].ToString();
                    _RepuestoSeleccionado.ElementAt(cuenta).Modelo = myreader[3].ToString();
                    _RepuestoSeleccionado.ElementAt(cuenta).Estilo = myreader[4].ToString(); ;
                    _RepuestoSeleccionado.ElementAt(cuenta).Combustible = myreader[5].ToString();
                    _RepuestoSeleccionado.ElementAt(cuenta).Inventario = (int)myreader[6];
                    _RepuestoSeleccionado.ElementAt(cuenta).Precio = (decimal)myreader[7];
                    _RepuestoSeleccionado.ElementAt(cuenta).Descripcion = myreader[8].ToString();
                    _RepuestoSeleccionado.ElementAt(cuenta).Año = (int)myreader[9];
                }
                return _RepuestoSeleccionado;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        public List<int> obtenerInventario()
        {
             int cantidad = _RepuestoSeleccionado[0].Inventario;
            List<int> cantidadSel;
            cantidadSel = new List<int>();
            int i = 1;
            while (i <= cantidad)
            {
                cantidadSel.Add(i);
                i++;
            }
            return cantidadSel;
        }

        public decimal obtenerPrecio()
        {
            decimal Precio = _RepuestoSeleccionado[0].Precio;
            return Precio;
        }


        public bool guardarFactura(int pIdCliente, string pEstado, int pCantidad, DateTime pFecha, decimal pMonto, int pUsuarioFactura, int pIdRepuesto)
        {
            _FacturaNueva = new Factura();
            _FacturaNueva.IdCliente = _ListaClientes[pIdCliente-1];
            _FacturaNueva.Estado = pEstado;
            _FacturaNueva.Cantidad = pCantidad;
            _FacturaNueva.Fecha = pFecha;
            _FacturaNueva.Monto = pMonto;
            _FacturaNueva.UsuarioFactura = pUsuarioFactura;
            _FacturaNueva.IdRepuesto = pIdRepuesto;
            if (!AccesoDatosFacturacion.agregarFactura(_FacturaNueva) && !AccesoDatosFacturacion.agregarFacturaDetalles(_FacturaNueva))
            {
                return false;
            }
            else
                return true;
        }

        public object obtenerProformas(int pIndiceCliente)
        {
            int cuenta;
            _ListaProformas = new List<FacturaPro>();
            _ListaIdProformas = new List<int>();
            MySqlDataReader myreader;
            _MontoTotal = 0;

            try
            {
                myreader = AccesoDatosFacturacion.obtenerProformasCliente(_ListaClientes.ElementAt(pIndiceCliente));
                while (myreader.Read())
                {
                    cuenta = _ListaProformas.Count;
                    _ListaProformas.Add(new FacturaPro());
                    _ListaIdProformas.Add((int)myreader[0]);
                    _ListaProformas.ElementAt(cuenta).Estado = myreader[1].ToString();
                    _ListaProformas.ElementAt(cuenta).Monto = decimal.Parse(myreader[2].ToString());
                    _MontoTotal += _ListaProformas.ElementAt(cuenta).Monto;
                    _ListaProformas.ElementAt(cuenta).Fecha = DateTime.Parse(myreader[3].ToString());
                    _ListaProformas.ElementAt(cuenta).Cantidad = int.Parse(myreader[4].ToString());
                    _ListaProformas.ElementAt(cuenta).PrecioUnitario = decimal.Parse(myreader[5].ToString());
                    _ListaProformas.ElementAt(cuenta).NumeroParte = int.Parse(myreader[6].ToString());
                    _ListaProformas.ElementAt(cuenta).DescripcionRepuesto = myreader[7].ToString();
                    _ListaProformas.ElementAt(cuenta).TipoRepuesto = myreader[8].ToString();
                    _ListaProformas.ElementAt(cuenta).Marca = myreader[9].ToString();
                    _ListaProformas.ElementAt(cuenta).Modelo = myreader[10].ToString();
                    _ListaProformas.ElementAt(cuenta).Anio = int.Parse(myreader[11].ToString());
                    _ListaProformas.ElementAt(cuenta).Estilo = myreader[12].ToString();
                    _ListaProformas.ElementAt(cuenta).Combustible = myreader[13].ToString();
                    _ListaProformas.ElementAt(cuenta)._IdRepuesto = int.Parse(myreader[14].ToString());
                }
                return _ListaProformas;
            }
            catch (Exception ex) { return null; }
        }

        public bool pagarProformas(int pCliente)
        {
            foreach (FacturaPro F in _ListaProformas) 
            {
                AccesoDatosFacturacion.decrementarInventario(F.Cantidad, F._IdRepuesto); 
            }
            return AccesoDatosFacturacion.pagarFactura(_ListaClientes[pCliente]);
        }

        public object obtenerFacturas(int pIndiceCliente)
        {
            int cuenta;
            _ListaProformas = new List<FacturaPro>();
            _ListaIdProformas = new List<int>();
            MySqlDataReader myreader;
            _MontoTotal = 0;

            try
            {
                myreader = AccesoDatosFacturacion.obtenerFacturasCliente(_ListaClientes.ElementAt(pIndiceCliente));
                while (myreader.Read())
                {
                    cuenta = _ListaProformas.Count;
                    _ListaProformas.Add(new FacturaPro());
                    _ListaIdProformas.Add((int)myreader[0]);
                    _ListaProformas.ElementAt(cuenta).Estado = myreader[1].ToString();
                    _ListaProformas.ElementAt(cuenta).Monto = decimal.Parse(myreader[2].ToString());
                    _MontoTotal += _ListaProformas.ElementAt(cuenta).Monto;
                    _ListaProformas.ElementAt(cuenta).Fecha = DateTime.Parse(myreader[3].ToString());
                    _ListaProformas.ElementAt(cuenta).Cantidad = int.Parse(myreader[4].ToString());
                    _ListaProformas.ElementAt(cuenta).PrecioUnitario = decimal.Parse(myreader[5].ToString());
                    _ListaProformas.ElementAt(cuenta).NumeroParte = int.Parse(myreader[6].ToString());
                    _ListaProformas.ElementAt(cuenta).DescripcionRepuesto = myreader[7].ToString();
                    _ListaProformas.ElementAt(cuenta).TipoRepuesto = myreader[8].ToString();
                    _ListaProformas.ElementAt(cuenta).Marca = myreader[9].ToString();
                    _ListaProformas.ElementAt(cuenta).Modelo = myreader[10].ToString();
                    _ListaProformas.ElementAt(cuenta).Anio = int.Parse(myreader[11].ToString());
                    _ListaProformas.ElementAt(cuenta).Estilo = myreader[12].ToString();
                    _ListaProformas.ElementAt(cuenta).Combustible = myreader[13].ToString();
                    _ListaProformas.ElementAt(cuenta)._IdRepuesto = int.Parse(myreader[14].ToString());
                }
                return _ListaProformas;
            }
            catch (Exception ex) { return null; }
        }

        public bool borrarProforma(int pIndiceSeleccionado)
        {
            AccesoDatosFacturacion.borrarProforma(_ListaIdProformas[pIndiceSeleccionado]);
            return AccesoDatosFacturacion.borrarProforma(_ListaIdProformas[pIndiceSeleccionado]);
        }
    }
}