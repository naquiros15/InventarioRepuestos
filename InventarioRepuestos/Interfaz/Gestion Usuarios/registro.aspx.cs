using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace Interfaz.Gestion_Usuarios
{
    public partial class registro : System.Web.UI.Page
    {
        #region atributos
        private static LogicaUsuario _Logica = new LogicaUsuario();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (!_Logica.registrar(TextBoxNombre.Text, TextBoxApellido.Text, TextBoxUsuario.Text, TextBoxContraseña.Text))
            {
                Response.Redirect("inicioSesion.aspx");
            }
            else
                Response.Write("<SCRIPT>alert('Se ha agregado correctamente el usuario dentro del sistema.')</SCRIPT>");
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("inicioSesion.aspx");
        }
    }
}