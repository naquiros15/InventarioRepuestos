using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesDominio
{
    public class Factura
    {
        #region atributos
        private int _id;
        private int _IdCliente;
        private string _Estado;
        private int _Cantidad;    
        private DateTime _Fecha;
        private decimal _Monto;
        private int _UsuarioFactura;
        private int _IdRepuesto;
        #endregion

        #region propiedades
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }
        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        public decimal Monto
        {
            get { return _Monto; }
            set { _Monto = value; }
        }
        public int UsuarioFactura
        {
            get { return _UsuarioFactura; }
            set { _UsuarioFactura = value; }
        }
        public int IdRepuesto
        {
            get { return _IdRepuesto; }
            set { _IdRepuesto = value; }
        }

        #endregion

        #region constructores

        public Factura() { }

        public Factura(int pId, int pCliente, string pEstado, int pCantidad, DateTime pFecha, decimal pMonto, int pUsuarioFactura, int pIdRepuesto) 
        {
            _id = pId;
            _IdCliente = pCliente;
            _Estado = pEstado;
            _Cantidad = pCantidad ;
            _Fecha = pFecha;
            _Monto = pMonto;
            _UsuarioFactura = pUsuarioFactura;
            _IdRepuesto = pIdRepuesto;
        }

        #endregion
    }
}
