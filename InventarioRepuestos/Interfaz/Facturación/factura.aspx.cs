using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace Interfaz.Facturacion
{
    public partial class factura : System.Web.UI.Page
    {
        #region atributos
        private static LogicaFacturacion _Logica = new LogicaFacturacion();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownListCliente.DataSource = _Logica.obtenerClientes();
            DropDownListCliente.DataBind();
            List<string> Estado;
            Estado = new List<string>();
            Estado.Add("Pago cancelado");
            Estado.Add("Pago Pendiente");
            DropDownListEstado.DataSource = Estado;
            DropDownListEstado.DataBind();
            /*DropDownListCantidad.DataSource = _Logica.obtenerCantidad();
            DropDownListCantidad.DataBind();*/
            LabelFecha.Text = _Logica.obtenerFecha();
        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("agregarCliente.aspx");
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../menuProvisional.aspx");
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../menuProvisional.aspx");
        }

    }
}


/*protected void gvEmpleados_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
{
    int idrepuesto = Convert.ToInt32(DataGridViewRepuestos.DataKeys[e.NewSelectedIndex].Value);

    Response.Redirect(string.Format("factura.aspx?id={0}", idrepuesto));

}*/