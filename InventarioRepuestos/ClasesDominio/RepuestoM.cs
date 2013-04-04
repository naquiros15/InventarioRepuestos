﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesDominio
{
    public class RepuestoM
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
        private string tipo;

        public string Tipo
        {
          get { return tipo; }
          set { tipo = value; }
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
        private string descripcion;

        public string Descripcion
        {
          get { return descripcion; }
          set { descripcion = value; }
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

        public RepuestoM() { }

        public RepuestoM(int pNumeroParte, string pIdMarca, string pIdTipo, string pIdEstilo, string pIdCombustible, int pAnio, int pInventario, string pDescripcion, decimal pPrecio) 
        {
            numeroParte = pNumeroParte;
            marca =pIdMarca ;
            tipo = pIdTipo;
            estilo = pIdEstilo;
            combustible = pIdCombustible;
            anio = pAnio;
            inventario = pInventario;
            descripcion = pDescripcion;
            precio = pPrecio;
        }

        #endregion
    }
}
