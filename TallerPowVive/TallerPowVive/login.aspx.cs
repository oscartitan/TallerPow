﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TallerPowVive.CONTROLADOR;

namespace TallerPowVive
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void validarUsuario_Click(object sender, EventArgs e)
        {

            var valida = IniciarSesionControllers.validacion(txtUsuario.Value.ToUpper(), txtContrasena.Value);
            if (valida.Tables[0].Rows.Count > 0)
            {
                Response.Redirect("vista/AminUsuarios.aspx");
            }
            else
            {
                txtContrasena.Value = "";
                txtUsuario.Value = "";

            }      

        }
    }
}