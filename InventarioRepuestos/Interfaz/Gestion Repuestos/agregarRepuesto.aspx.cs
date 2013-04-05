using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace Interfaz.Gestion_Repuestos
{
    public partial class agregarRepuestos : System.Web.UI.Page
    {

        #region atributos
        private static LogicaRepuestos _Logica = new LogicaRepuestos();
        #endregion

        #region inicializacion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListTipo.DataSource = _Logica.obtenerTipo();
                DropDownListTipo.DataBind();
                DropDownListMarca.DataSource = _Logica.obtenerMarca();
                DropDownListMarca.DataBind();
                DropDownListAnio.DataSource = _Logica.obtenerAnio();
                DropDownListAnio.DataBind();
                DropDownListModelo.DataSource = _Logica.obtenerModelo(DropDownListMarca.SelectedIndex + 1);
                DropDownListModelo.DataBind();
                DropDownListEstilo.DataSource = _Logica.obtenerEstilo();
                DropDownListEstilo.DataBind();
                DropDownListCombustible.DataSource = _Logica.obtenerCombustible();
                DropDownListCombustible.DataBind();
            }
        }
        #endregion

        #region eventos

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            agregarRespuesto();
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../menuProvisional.aspx");
        }
        protected void DropDownListMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListModelo.DataSource = _Logica.obtenerModelo(DropDownListMarca.SelectedIndex + 1);
            DropDownListModelo.DataBind();
        }

        #endregion

        #region métodos

        private void agregarRespuesto()
        {
            if (!_Logica.agregarRespuesto(Int32.Parse(TextBoxParte.Text), DropDownListTipo.SelectedIndex+1, DropDownListMarca.SelectedIndex+1,
                DropDownListModelo.SelectedIndex, DropDownListEstilo.SelectedIndex+1, DropDownListCombustible.SelectedIndex+1,
                Int32.Parse(DropDownListAnio.Text), Int32.Parse(TextBoxInventario.Text), TextBoxDescripcion.Text, 
                Int32.Parse(TextBoxPrecio.Text)))
            {
                Response.Write("<SCRIPT>alert('Se ha agregado correctamente dentro del sistema.')</SCRIPT>");
                Response.Redirect("../menuProvisional.aspx");
            }
            else
                Response.Write("<SCRIPT>alert('No se ha agregado correctamente dentro del sistema.')</SCRIPT>");

        }


        #endregion

        

     }
}