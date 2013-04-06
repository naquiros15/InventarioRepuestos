using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesDominio
{
    public class RepuestoVehiculos
    {
        #region atributos
        private int id;
        private int numeroParte;
        private string tipo;
        private int inventario;
        private string descripcion;
        private decimal precio;
        #endregion

        #region propiedades
        public int NumeroParte
        {
            get { return numeroParte; }
            set { numeroParte = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
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
        #endregion

        #region metodos

        public void asignarId(int pId)
        {
            id = pId;
        }

        public int obtenerId()
        {
            return id;
        }

        #endregion

        #region constructores

        public RepuestoVehiculos() { }

        public RepuestoVehiculos(int pNumeroParte, string pIdTipo, int pInventario, string pDescripcion, decimal pPrecio) 
        {
            numeroParte = pNumeroParte;
            tipo = pIdTipo;
            inventario = pInventario;
            descripcion = pDescripcion;
            precio = pPrecio;
        }
        #endregion
    }
}
