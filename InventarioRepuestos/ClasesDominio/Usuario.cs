using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesDominio
{
    public class Usuario
    {
        #region atributos
        private string Nombre;

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private string Apellido;

        public string Apellido1
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        private string nombreUsuario;

        public string Usuario1
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        private string Clave;

        public string Clave1
        {
            get { return Clave; }
            set { Clave = value; }
        }
        #endregion

        #region propiedades
       
        #endregion

        #region constructores

        public Usuario() { }

        public Usuario(string pNombre, string pApellido, string pUsuario, string pClave) 
        {
            Nombre = pNombre;
            Apellido = pApellido;
            nombreUsuario = pUsuario;
            Clave = pClave;
        }

        #endregion
    }
}
