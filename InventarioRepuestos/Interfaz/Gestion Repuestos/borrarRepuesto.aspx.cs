using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace Interfaz.Gestion_Repuestos
{

    public partial class borrarRepuesto : System.Web.UI.Page
    {
        #region atributos
        private static LogicaRepuestos _Logica = new LogicaRepuestos();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewRepuestos.DataSource = _Logica.obtenerRepuestos();
            GridViewRepuestos.DataBind();
        }

        protected void eventoborrarRepuesto(object sender, GridViewDeleteEventArgs e)
        {
            if (!_Logica.borrarRepuesto(e.RowIndex))
            {
                GridViewRepuestos.DataSource = _Logica.obtenerRepuestos();
                GridViewRepuestos.DataBind();
            }
            else
                Response.Write("<SCRIPT>alert('El repuesto no ha sido borrado del sistema.')</SCRIPT>");

        }

        protected void ButtonVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("../menuProvisional.aspx");
        }
    }
}