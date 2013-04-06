using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesDominio
{
    public class Repuesto
    {
        #region atributos
        private int id;
        private int numeroParte;
        private int idTipo;
        private int idMarca;    
        private int idModelo;
        private int idEstilo;
        private int idCombustible;
        private string descripcionVehiculo;
        private int anio;
        private int inventario;
        private string descripcion;
        private decimal precio;
        #endregion

        #region propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int NumeroParte
        {
            get { return numeroParte; }
            set { numeroParte = value; }
        }
        public int IdTipo
        {
            get { return idTipo; }
            set { idTipo = value; }
        }
        public int IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }
        }
        public int IdModelo
        {
            get { return idModelo; }
            set { idModelo = value; }
        }
        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        public int Inventario
        {
            get { return inventario; }
            set { inventario = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int IdEstilo
        {
            get { return idEstilo; }
            set { idEstilo = value; }
        }

        public int IdCombustible
        {
            get { return idCombustible; }
            set { idCombustible = value; }
        }

        public string DescripcionVehiculo
        {
            get { return descripcionVehiculo; }
            set { descripcionVehiculo = value; }
        }
        #endregion

        #region constructores

        public Repuesto() { }

        public Repuesto(int pId, int pNumeroParte, int pIdTipo, int pIdMarca, int pIdModelo, int pIdEstilo, int pIdCombustible, string pDescripcionVehiculo, int pAnio, int pInventario, string pDescripcion, decimal pPrecio) 
        {
            id = pId;
            numeroParte = pNumeroParte;
            idTipo = pIdTipo;
            idMarca =pIdMarca ;
            idModelo = pIdModelo;
            idEstilo = pIdEstilo;
            idCombustible = pIdCombustible;
            descripcionVehiculo = pDescripcionVehiculo;
            anio = pAnio;
            inventario = pInventario;
            descripcion = pDescripcion;
            precio = pPrecio;
        }

        #endregion
    }
}
