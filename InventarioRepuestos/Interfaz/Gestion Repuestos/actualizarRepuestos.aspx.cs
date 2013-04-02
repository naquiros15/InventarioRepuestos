﻿using System;
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

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../menuProvisional.aspx");
        }

        protected void eventoEditarRepuesto(object sender, GridViewUpdatedEventArgs e)
        {
            Response.Redirect("../menuProvisional.aspx");
        }


    }
}