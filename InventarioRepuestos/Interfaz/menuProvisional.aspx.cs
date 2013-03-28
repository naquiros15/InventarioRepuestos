using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interfaz
{
    public partial class menuProvisional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (e.Item.Value == "Agregar Repuesto")
            {
                Response.Redirect("Gestion Repuestos/agregarRepuesto.aspx");
            }
            else if (e.Item.Value == "Borrar Repuesto")
            {
                Response.Redirect("Gestion Repuestos/borrarRepuesto.aspx");
            }
            else if (e.Item.Value == "Actualizar Repuestos")
            {
                Response.Redirect("Gestion Repuestos/actualizarRepuestos.aspx");
            }
            else if (e.Item.Value == "Actualizar Inventario")
            {
                Response.Redirect("Inventario/Actualizar Inventario.aspx");
            }
            else
            {
                Response.Redirect("Consultas/Consultas.aspx");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Gestion Repuestos/agregarRepuesto.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Gestion Repuestos/borrarRespuesto.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Gestion Repuestos/actualizarRepuestos.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inventario/actualizarInventario.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consultas/Consultas.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Gestion Usuarios/inicioSesion.aspx");
        }
    }
}