using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace Interfaz.Gestion_Usuarios
{
    public partial class inicioSesion : System.Web.UI.Page
    {
        #region atributos
        private static LogicaUsuario _Logica = new LogicaUsuario();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void ButtonEntrar_Click(object sender, EventArgs e)
        {
            if (!_Logica.inicioSesion(TextBoxUsuario.Text, TextBoxClave.Text))
            {

                Session["usuario"] = TextBoxUsuario.Text;
                Session["idUsuario"] = _Logica.IdUsuarioActual;
                Response.Redirect("../menuProvisional.aspx");
            }
            else
                Response.Write("<SCRIPT>alert('No se ha podido iniciar sesión. Usuario y contraseña inválidos.')</SCRIPT>");
        }

        protected void ButtonRegistar_Click(object sender, EventArgs e)
        {
            Response.Redirect("registro.aspx");
        }
    }
}