using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interfaz.Consultas
{
    public partial class Consultas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 4;
            LinkButton1.BackColor = System.Drawing.Color.LightGray;
            LinkButton2.BackColor = System.Drawing.Color.White;
            LinkButton3.BackColor = System.Drawing.Color.White;
            LinkButton4.BackColor = System.Drawing.Color.White;
            LinkButton5.BackColor = System.Drawing.Color.White;
        }

        protected void botonRegresar0_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Facturación/factura.aspx");
        }

        protected void botonRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../menuProvisional.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
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
            MultiView1.ActiveViewIndex = 0;
            LinkButton1.BackColor = System.Drawing.Color.White;
            LinkButton2.BackColor = System.Drawing.Color.White;
            LinkButton3.BackColor = System.Drawing.Color.White;
            LinkButton4.BackColor = System.Drawing.Color.White;
            LinkButton5.BackColor = System.Drawing.Color.LightGray;
            LabelNoHayDatos.Visible = false;
        }

    }
}