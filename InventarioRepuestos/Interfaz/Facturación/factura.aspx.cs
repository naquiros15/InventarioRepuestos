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
            if (!IsPostBack)
            {
                GridViewRespuestos.DataSource = _Logica.obtenerRepuesto(Int32.Parse(Session["IdRepuesto"].ToString()));
                GridViewRespuestos.DataBind();
                DropDownListCliente.DataSource = _Logica.obtenerClientes();
                DropDownListCliente.DataBind();
                LabelNombre.Text = _Logica.ListaNombresClientes[0] + " " + _Logica.ListaApellidosClientes[0];
                DropDownListCantidad.DataSource = _Logica.obtenerInventario();
                DropDownListCantidad.DataBind();
                LabelFecha.Text = _Logica.obtenerFecha();
                LabelMonto.Text = _Logica.RepuestoSeleccionado[0].Precio.ToString();
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
            if (!_Logica.guardarFactura(DropDownListCliente.SelectedIndex+1, "Pago Pendiente", DropDownListCantidad.SelectedIndex+1,
                DateTime.Parse(LabelFecha.Text), Decimal.Parse(LabelMonto.Text), (int)Session["idUsuario"], (int)Session["IdRepuesto"]))
            {
                Response.Write("<SCRIPT>alert('Se ha agregado correctamente dentro de la factura.')</SCRIPT>");
                Response.Redirect("../Consultas/Consultas.aspx");
            }
            else
                Response.Write("<SCRIPT>alert('No se ha podido guardar.')</SCRIPT>");
        }

        protected void DropDownListCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal precio = _Logica.obtenerPrecio();
            decimal Monto = Decimal.Parse(DropDownListCantidad.SelectedValue) * precio;
            LabelMonto.Text = Monto.ToString();
        }

        protected void DropDownListCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelNombre.Text = _Logica.ListaNombresClientes[DropDownListCliente.SelectedIndex] + " " + _Logica.ListaApellidosClientes[DropDownListCliente.SelectedIndex];
        }

    }
}


