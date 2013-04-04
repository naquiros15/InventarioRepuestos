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
        int idRepuesto = 7;
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewRespuestos.DataSource = _Logica.obtenerRepuesto(7);
                GridViewRespuestos.DataBind();
                DropDownListCliente.DataSource = _Logica.obtenerClientes();
                DropDownListCliente.DataBind();
                List<string> Estado;
                Estado = new List<string>();
                Estado.Add("Pago cancelado");
                Estado.Add("Pago Pendiente");
                DropDownListEstado.DataSource = Estado;
                DropDownListEstado.DataBind();
                DropDownListCantidad.DataSource = _Logica.obtenerInventario();
                DropDownListCantidad.DataBind();
                LabelFecha.Text = _Logica.obtenerFecha();
            }
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
            if (!_Logica.guardarFactura(DropDownListCliente.SelectedIndex+1, DropDownListEstado.SelectedValue, DropDownListCantidad.SelectedIndex+1, 
                DateTime.Parse(LabelFecha.Text),Decimal.Parse(LabelMonto.Text), (int)Session["idUsuario"], idRepuesto))
            {
                //_Logica.decrementarInventario(DropDownListCantidad.SelectedIndex + 1);
                Response.Write("<SCRIPT>alert('Se ha agregado correctamente dentro del sistema.')</SCRIPT>");
            }
            else
                Response.Write("<SCRIPT>alert('No se ha podido guardar la factura.')</SCRIPT>");
        }

        protected void DropDownListCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal precio = _Logica.obtenerPrecio();
            decimal Monto = Decimal.Parse(DropDownListCantidad.SelectedValue) * precio;
            LabelMonto.Text = Monto.ToString();
        }

    }
}


/*protected void gvEmpleados_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
{
    int idrepuesto = Convert.ToInt32(DataGridViewRepuestos.DataKeys[e.NewSelectedIndex].Value);

    Response.Redirect(string.Format("factura.aspx?id={0}", idrepuesto));

}*/