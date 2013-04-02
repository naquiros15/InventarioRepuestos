using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesDominio
{
    public class Cliente
    {
        
        #region atributos
        private int id;
        private int cedula;
        private int telefono;
        private int celular;
        private string direccion;
        private string tipo;
        #endregion

        #region propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public int Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        #endregion

        #region constructores

        public Cliente() { }

        public Cliente(int pCedula, int pTelefono, int pCelular, string pDireccion, string pTipo) 
        {
            cedula = pCedula;
            telefono = pTelefono;
            celular = pCelular;
            direccion = pDireccion;
            tipo = pTipo;
        }

        #endregion
    }
}
