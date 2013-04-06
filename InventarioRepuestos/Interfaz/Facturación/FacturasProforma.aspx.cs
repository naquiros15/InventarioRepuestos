using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace Interfaz.Facturación
{
    public partial class FacturasProforma : System.Web.UI.Page
    {
        #region atributos
        private static LogicaFacturacion _Logica = new LogicaFacturacion();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            LabelMonto.Visible = false;
            Label2.Visible = false;
            LabelNoHayDatos.Visible = false;
            if(!IsPostBack)
            {
            DropDownListClientes.DataSource = _Logica.obtenerClientes();
            DropDownListClientes.DataBind();
            }
        }

        protected void ButtonPagar_Click(object sender, EventArgs e)
        {
            if (!_Logica.pagarProformas(DropDownListClientes.SelectedIndex))
            {
                Response.Write("<SCRIPT>alert('Su pago ha sido realizado satisfactoriamente.')</SCRIPT>");
            }
            else
                Response.Write("<SCRIPT>alert('Su pago no ha sido realizado.')</SCRIPT>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../MenuProvisional.aspx");
        }

        protected void DropDownListClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewProforma.DataSource = _Logica.obtenerProformas(DropDownListClientes.SelectedIndex);
            GridViewProforma.DataBind();
            if (_Logica.ListaProformas.Count != 0)
            {
                LabelMonto.Visible = true;
                Label2.Visible = true;
                LabelNoHayDatos.Visible = false;
                LabelMonto.Text = _Logica.MontoTotal.ToString();
            }
            else
            {
                LabelNoHayDatos.Visible = true;
                LabelMonto.Visible = false;
                Label2.Visible = false;
            }
        }

        protected void borrarProforma(object sender, GridViewDeleteEventArgs e)
        {
            if (!_Logica.borrarProforma(e.RowIndex))
            {
                GridViewProforma.DataSource = _Logica.obtenerProformas(DropDownListClientes.SelectedIndex);
                GridViewProforma.DataBind();
            }
            else
                Response.Write("<SCRIPT>alert('El item no ha sido borrado del sistema.')</SCRIPT>");
        }            
    }
}