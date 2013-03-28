using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interfaz.Gestion_Repuestos
{
    public partial class borrarRespuesto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewRepuestos.DataSource = "hola,fvre,vefvsd,vedsd,vas,cds,vsdz";
            GridViewRepuestos.DataBind();
        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../menuProvisional.aspx");
        }


    }
}