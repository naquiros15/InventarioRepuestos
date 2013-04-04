using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesDominio
{
    public class RepuestoDe
    {
        #region atributos

        private int numeroParte;

        public int NumeroParte
        {
          get { return numeroParte; }
          set { numeroParte = value; }
        }
       
        private string marca;

        public string Marca
        {
          get { return marca; }
          set { marca = value; }
        }
        private string modelo;

        public string Modelo
        {
          get { return modelo; }
          set { modelo = value; }
        }
        private string estilo;

        public string Estilo
        {
          get { return estilo; }
          set { estilo = value; }
        }
        private string combustible;

        public string Combustible
        {
          get { return combustible; }
          set { combustible = value; }
        }
         private int anio;

        public int Año
        {
          get { return anio; }
          set { anio = value; }
        }
            private int inventario;

        public int Inventario
        {
          get { return inventario; }
          set { inventario = value; }
        }
        private string tipo;

        public string Tipo
        {
          get { return tipo; }
          set { tipo = value; }
        }
        private decimal precio;

        public decimal Precio
        {
          get { return precio; }
          set { precio = value; }
        }
        #endregion

        #region propiedades
        
        #endregion

        #region constructores

        public RepuestoDe() { }

        public RepuestoDe(int pNumeroParte, string pIdMarca, string pIdModelo, string pIdEstilo, string pIdCombustible, int pAnio, int pInventario, string pIdTipo, decimal pPrecio) 
        {
            numeroParte = pNumeroParte;
            marca =pIdMarca ;
            modelo = pIdModelo;
            estilo = pIdEstilo;
            combustible = pIdCombustible;
            anio = pAnio;
            inventario = pInventario;
            tipo = pIdTipo;
            precio = pPrecio;
        }

        #endregion
    }
}
