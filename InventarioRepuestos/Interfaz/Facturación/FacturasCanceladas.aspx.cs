using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace Interfaz.Facturación
{
    public partial class FacturasCanceladas : System.Web.UI.Page
    {
        #region atributos
        private static LogicaFacturacion _Logica = new LogicaFacturacion();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelNoHayDatos.Visible = false;
            if (!IsPostBack)
            {
                DropDownListClientes.DataSource = _Logica.obtenerClientes();
                DropDownListClientes.DataBind();
            }
        }

        protected void DropDownListClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewProforma.DataSource = _Logica.obtenerFacturas(DropDownListClientes.SelectedIndex);
            GridViewProforma.DataBind();
            if (_Logica.ListaProformas.Count != 0)
            {
                LabelNoHayDatos.Visible = false;
            }
            else
            {
                LabelNoHayDatos.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../MenuProvisional.aspx");
        }
    }
}