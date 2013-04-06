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
                //Obtiene las descripciones de los vehiculos
                DropDownListDDescripcion.DataSource = _Logica.obtenerDDescripcion();
                DropDownListDDescripcion.DataBind();
                //Obtiene las descripciones de los repuestos
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
                Session["NumeroBusqueda"] = 1;
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
            Session["NumeroBusqueda"] = 1;
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
            Session["NumeroBusqueda"] = 2;
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
            Session["NumeroBusqueda"] = 3;
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
            Session["NumeroBusqueda"] = 4;
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
            Session["NumeroBusqueda"] = 5;
        }

        protected void DropDownListMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListModelo.DataSource = _Logica.obtenerModelo(DropDownListMarca.SelectedIndex + 1);
            DropDownListModelo.DataBind();
        }

        protected void botonBuscar_Click(object sender, EventArgs e)
        {
            _Logica.PorVehiculo(DropDownListMarca.SelectedIndex,
            DropDownListModelo.SelectedIndex,DropDownListEstilo.SelectedIndex,
            DropDownListCombustible.SelectedIndex,Int32.Parse(DropDownListAnio.SelectedValue), DropDownListDDescripcion.SelectedValue);
            if (_Logica.ListaRepuestosV.Count == 0)
            {
                LabelNoHayDatos.Visible = true;
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
            else
            {
                LabelNoHayDatos.Visible = false;
                GridView1.DataSource = _Logica.ListaRepuestosV;
                GridView1.DataBind();
            }
                
        }

        protected void botonBuscar3_Click(object sender, EventArgs e)
        {
            _Logica.PorTipo(DropDownListTipos.SelectedIndex);
            if (_Logica._ListaRepuestosT.Count == 0)
            {
                LabelNoHayDatos.Visible = true;
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
            else
            {
                LabelNoHayDatos.Visible = false;
                GridView1.DataSource = _Logica._ListaRepuestosT;
                GridView1.DataBind();
            }
        }

        protected void botonBuscar2_Click(object sender, EventArgs e)
        {
            _Logica.PorModelo(DropDownListModelos.SelectedIndex);
            if (_Logica.ListaRepuestosM.Count == 0)
            {
                LabelNoHayDatos.Visible = true;
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
            else
            {
                LabelNoHayDatos.Visible = false;
                GridView1.DataSource = _Logica._ListaRepuestosM;
                GridView1.DataBind();
            }
        }

        protected void botonBuscar1_Click(object sender, EventArgs e)
        {
            _Logica.PorMarca(DropDownListMarcas.SelectedIndex);
            if (_Logica.ListaRepuestosMa.Count == 0)
            {
                LabelNoHayDatos.Visible = true;
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
            else
            {
                LabelNoHayDatos.Visible = false;
                GridView1.DataSource = _Logica._ListaRepuestosMa;
                GridView1.DataBind();
            }
        }

        protected void botonBuscar0_Click(object sender, EventArgs e)
        {
            _Logica.PorDescripcion(DropDownListDescripcion.SelectedValue);
            if (_Logica.ListaRepuestosDe.Count == 0)
            {
                LabelNoHayDatos.Visible = true;
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
            else
            {
                LabelNoHayDatos.Visible = false;
                GridView1.DataSource = _Logica._ListaRepuestosDe;
                GridView1.DataBind();
            }
        }

        protected void botonFacturar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Facturación/factura.aspx");
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int indiceSeleccion = e.NewSelectedIndex;
            Session["IdRepuesto"] = _Logica.obtenerIdRepuestoSeleccionado(indiceSeleccion, int.Parse(Session["NumeroBusqueda"].ToString()));
            //Response.Redirect("../Facturación/factura.aspx");
        }

    }
}