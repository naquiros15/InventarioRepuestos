using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesDominio
{
    public class FacturaPro
    {
        #region atributos
        private int _id;
        private int _IdCliente;

        private DateTime _Fecha;

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        private string _Estado;

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        private int _Cantidad;
        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        private decimal _PrecioUnitario;

        public decimal PrecioUnitario
        {
            get { return _PrecioUnitario; }
            set { _PrecioUnitario = value; }
        }

        private decimal _Monto;
        public decimal Monto
        {
            get { return _Monto; }
            set { _Monto = value; }
        }

        private int _NumeroParte;

        public int NumeroParte
        {
            get { return _NumeroParte; }
            set { _NumeroParte = value; }
        }
        private string _DescripcionRepuesto;

        public string DescripcionRepuesto
        {
            get { return _DescripcionRepuesto; }
            set { _DescripcionRepuesto = value; }
        }
        private string _TipoRepuesto;

        public string TipoRepuesto
        {
            get { return _TipoRepuesto; }
            set { _TipoRepuesto = value; }
        }
        private string _Marca;

        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }
        private string _Modelo;

        public string Modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }
        private int _Anio;

        public int Anio
        {
            get { return _Anio; }
            set { _Anio = value; }
        }
        private string _Estilo;

        public string Estilo
        {
            get { return _Estilo; }
            set { _Estilo = value; }
        }
        private string _Combustible;

        public string Combustible
        {
            get { return _Combustible; }
            set { _Combustible = value; }
        }

        public int _IdRepuesto;
        #endregion

        #region propiedades

        #endregion

        #region constructores

        public FacturaPro() { }

        public FacturaPro(int pId, int pCliente, string pEstado, int pCantidad, DateTime pFecha, decimal pMonto, int pUsuarioFactura, int pIdRepuesto) 
        {
            _id = pId;
            _IdCliente = pCliente;
            _Estado = pEstado;
            _Cantidad = pCantidad ;
            _Fecha = pFecha;
            _Monto = pMonto;
        }

        #endregion
    }
}
