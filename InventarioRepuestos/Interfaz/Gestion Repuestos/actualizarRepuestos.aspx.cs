using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace Interfaz.Gestion_Repuestos
{
    public partial class actualizarRepuestos : System.Web.UI.Page
    {
        #region atributos
        private static LogicaRepuestos _Logica = new LogicaRepuestos();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewRepuestos.DataSource = _Logica.obtenerRepuestos();
            GridViewRepuestos.DataBind();
        }

        protected void GridViewRepuestos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            TextBoxParte.Text = _Logica._ListaRepuestos[e.NewSelectedIndex].NumeroParte.ToString();
            TextBoxInventario.Text = _Logica._ListaRepuestos[e.NewSelectedIndex].Inventario.ToString();
            TextBoxDescripcion.Text = _Logica._ListaRepuestos[e.NewSelectedIndex].Descripcion.ToString();
            TextBoxPrecio.Text = _Logica._ListaRepuestos[e.NewSelectedIndex].Precio.ToString();
            TextBoxTipo.Text = _Logica._ListaRepuestos[e.NewSelectedIndex].Tipo.ToString();
            TextBoxMarca.Text = _Logica._ListaRepuestos[e.NewSelectedIndex].Marca.ToString();
            TextBoxModelo.Text = _Logica._ListaRepuestos[e.NewSelectedIndex].Modelo.ToString();
            TextBoxCombustible.Text = _Logica._ListaRepuestos[e.NewSelectedIndex].Combustible.ToString();
            TextBoxEstilo.Text = _Logica._ListaRepuestos[e.NewSelectedIndex].Estilo.ToString();
            TextBoxAnio.Text = _Logica._ListaRepuestos[e.NewSelectedIndex].Año.ToString();
            TextBoxDescripcionV.Text = _Logica._ListaRepuestos[e.NewSelectedIndex].DescripcionVehiculo.ToString();
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Logica.guardarDatosRepuesto(TextBoxParte.Text, TextBoxInventario.Text, TextBoxDescripcion.Text, TextBoxPrecio.Text,
           TextBoxTipo.Text, TextBoxMarca.Text, TextBoxModelo.Text, TextBoxCombustible.Text, TextBoxEstilo.Text, TextBoxAnio.Text,
           TextBoxDescripcionV.Text, _Logica.ListaIdRepuestos[GridViewRepuestos.SelectedIndex]))
                {
                    Response.Write("<SCRIPT>alert('El repuesto no ha sido actualizado.')</SCRIPT>");
                }
                else
                {
                    Response.Write("<SCRIPT>alert('El repuesto ha sido actualizado correctamente.')</SCRIPT>");
                    GridViewRepuestos.DataSource = _Logica.obtenerRepuestos();
                    GridViewRepuestos.DataBind();
                }
            }
            catch(Exception ex)
            {
                if(ex.Source=="Factura")
                {
                     Response.Write("<SCRIPT>alert('"+  ex.Message + "')</SCRIPT>");
                }
               
            }

        }

        protected void ButtonVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("../menuProvisional.aspx");
        }

    }
}