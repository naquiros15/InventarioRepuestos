using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interfaz.Gestion_Repuestos
{
    public partial class agregarRepuestos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            agregarRespuesto();
           
        }

        private void agregarRespuesto() 
        {
            //Response.Write("<SCRIPT>alert('Se ha agregado correctamente dentro del sistema.')</SCRIPT>");
            Response.Redirect("../menuProvisional.aspx");
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../menuProvisional.aspx");
        }
    }
}