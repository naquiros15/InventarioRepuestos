﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesDominio
{
    public class RepuestoD
   {
        #region atributos

        private int numeroParte;

        public int NumeroParte
        {
          get { return numeroParte; }
          set { numeroParte = value; }
        }
        private string tipo;

        public string Tipo
        {
          get { return tipo; }
          set { tipo = value; }
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

        private String descripcionVehiculo;

        public String DescripcionVehiculo
        {
            get { return descripcionVehiculo; }
            set { descripcionVehiculo = value; }
        }
        #endregion

        #region propiedades
        
        #endregion

        private int id;
        public void asignarId(int pId)
        {
            id = pId;
        }

        public int obtenerId()
        {
            return id;
        }


        #region constructores

        public RepuestoD() { }

        public RepuestoD(int pNumeroParte, string pIdTipo, string pIdMarca, string pIdModelo, string pIdEstilo, string pIdCombustible, int pAnio, int pInventario, string pDescripcion, decimal pPrecio) 
        {
            numeroParte = pNumeroParte;
            tipo = pIdTipo;
            marca =pIdMarca ;
            modelo = pIdModelo;
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
