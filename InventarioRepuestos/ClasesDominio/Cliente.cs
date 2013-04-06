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
        private string nombre;
        private string apellido;
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

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
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

        public Cliente(int pCedula, string pNombre, string pApellido, int pTelefono, int pCelular, string pDireccion, string pTipo) 
        {
            cedula = pCedula;
            nombre = pNombre;
            apellido = pApellido;
            telefono = pTelefono;
            celular = pCelular;
            direccion = pDireccion;
            tipo = pTipo;
        }

        #endregion
    }
}
