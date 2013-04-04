using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace Interfaz.Consultas
{
    public partial class Consultas : System.Web.UI.Page
    {

        #region atributos
        private static LogicaConsultas _Logica = new LogicaConsultas();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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
                DropDownListDescripcion.DataSource = _Logica.obtenerDescripcion();
                DropDownListDescripcion.DataBind();
                DropDownListTipos.DataSource = _Logica.obtenerTipo();
                DropDownListTipos.DataBind();
                DropDownListModelos.DataSource = _Logica.obtenerModelos();
                DropDownListModelos.DataBind();
                DropDownListMarcas.DataSource = _Logica.obtenerMarca();
                DropDownListMarcas.DataBind();
                MultiView1.ActiveViewIndex = 4;
                LinkButton1.BackColor = System.Drawing.Color.LightGray;
                LinkButton2.BackColor = System.Drawing.Color.White;
                LinkButton3.BackColor = System.Drawing.Color.White;
                LinkButton4.BackColor = System.Drawing.Color.White;
                LinkButton5.BackColor = System.Drawing.Color.White;
            }
            
        }

        protected void botonRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../menuProvisional.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = "";
            GridView1.DataBind();
            MultiView1.ActiveViewIndex = 4;
            LinkButton1.BackColor = System.Drawing.Color.LightGray;
            LinkButton2.BackColor = System.Drawing.Color.White;
            LinkButton3.BackColor = System.Drawing.Color.White;
            LinkButton4.BackColor = System.Drawing.Color.White;
            LinkButton5.BackColor = System.Drawing.Color.White;
            LabelNoHayDatos.Visible = false;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = "";
            GridView1.DataBind();
            MultiView1.ActiveViewIndex = 3;
            LinkButton1.BackColor = System.Drawing.Color.White;
            LinkButton2.BackColor = System.Drawing.Color.LightGray;
            LinkButton3.BackColor = System.Drawing.Color.White;
            LinkButton4.BackColor = System.Drawing.Color.White;
            LinkButton5.BackColor = System.Drawing.Color.White;
            LabelNoHayDatos.Visible = false;
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = "";
            GridView1.DataBind();
            MultiView1.ActiveViewIndex = 2;
            LinkButton1.BackColor = System.Drawing.Color.White;
            LinkButton2.BackColor = System.Drawing.Color.White;
            LinkButton3.BackColor = System.Drawing.Color.LightGray;
            LinkButton4.BackColor = System.Drawing.Color.White;
            LinkButton5.BackColor = System.Drawing.Color.White;
            LabelNoHayDatos.Visible = false;
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = "";
            GridView1.DataBind();
            MultiView1.ActiveViewIndex = 1;
            LinkButton1.BackColor = System.Drawing.Color.White;
            LinkButton2.BackColor = System.Drawing.Color.White;
            LinkButton3.BackColor = System.Drawing.Color.White;
            LinkButton4.BackColor = System.Drawing.Color.LightGray;
            LinkButton5.BackColor = System.Drawing.Color.White;
            LabelNoHayDatos.Visible = false;
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = "";
            GridView1.DataBind();
            MultiView1.ActiveViewIndex = 0;
            LinkButton1.BackColor = System.Drawing.Color.White;
            LinkButton2.BackColor = System.Drawing.Color.White;
            LinkButton3.BackColor = System.Drawing.Color.White;
            LinkButton4.BackColor = System.Drawing.Color.White;
            LinkButton5.BackColor = System.Drawing.Color.LightGray;
            LabelNoHayDatos.Visible = false;
        }

        protected void DropDownListMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListModelo.DataSource = _Logica.obtenerModelo(DropDownListMarca.SelectedIndex + 1);
            DropDownListModelo.DataBind();
        }

        protected void botonBuscar_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = _Logica.PorVehiculo(DropDownListMarca.SelectedIndex+1,
            DropDownListModelo.SelectedIndex+1,DropDownListEstilo.SelectedIndex+1,
            DropDownListCombustible.SelectedIndex+1,Int32.Parse(DropDownListAnio.SelectedValue));
            GridView1.DataBind();

        }

        protected void botonBuscar3_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = _Logica.PorTipo(DropDownListTipos.SelectedIndex+1);
            GridView1.DataBind();
        }

        protected void botonBuscar2_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = _Logica.PorModelo(DropDownListModelos.SelectedValue);
            GridView1.DataBind();
        }

        protected void botonBuscar1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = _Logica.PorMarca(DropDownListMarcas.SelectedValue);
            GridView1.DataBind();
        }

        protected void botonBuscar0_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = _Logica.PorDescripcion(DropDownListDescripcion.SelectedValue);
            GridView1.DataBind();
        }

        protected void botonFacturar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Facturación/factura.aspx");
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            //int idrepuesto = e.NewSelectedIndex;
            /*int idRepuesto = Convert.ToInt32(GridView1.DataKeys[e.NewSelectedIndex].Value);
            Response.Redirect(string.Format("../Facturación/factura.aspx?id={0}", idRepuesto));*/
        }

    }
}