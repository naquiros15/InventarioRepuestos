using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace Interfaz.Facturacion
{
    public partial class agregarCliente : System.Web.UI.Page
    {
        #region atributos
        private static LogicaFacturacion _Logica = new LogicaFacturacion();
        #endregion

        #region inicializacion
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region eventos

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            agregarClienteNuevo();
            Response.Redirect("../menuProvisional.aspx");
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../menuProvisional.aspx");
        }
        #endregion

        #region métodos

        public void agregarClienteNuevo()
        {
            if (!_Logica.agregarCliente(Int32.Parse(TextBoxId.Text), Int32.Parse(TextBoxTel.Text),Int32.Parse(TextBoxCel.Text), TextBoxDir.Text, TextBoxTipo.Text))
            {
                Response.Write("<SCRIPT>alert('Se ha agregado correctamente dentro del sistema.')</SCRIPT>");
                //Response.Redirect("../menuProvisional.aspx");
            }
            else
                Response.Write("<SCRIPT>alert('No se ha agregado el cliente.')</SCRIPT>");

        }

        #endregion
    }
}