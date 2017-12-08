using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TallerWeb.CONTROLADOR;

namespace TallerWeb.VISTA
{
    public partial class AdminUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddUsuario_Click(object sender, EventArgs e)
        {
            var registros = IniciarSesionControllers.adicionarUsuario(txtUsuario.Value.ToUpper().Trim(),txtContrasena.Value.ToUpper().Trim(), txtNombre.Value.ToUpper().Trim());
            if ( registros > 0)
            {
                txtContrasena.Value = "";
                txtUsuario.Value = "";
                txtNombre.Value = "";
            }
            else
            {

            }   
        }

        protected void ListarUsuario_Click(object sender, EventArgs e)
        {
           var registros = IniciarSesionControllers.mostrarUsuarios();
           if (registros.Tables[0].Rows.Count > 0)
           {
               GridViewUsuarios.DataSource = registros;
               GridViewUsuarios.DataBind();
           }
           else {
               GridViewUsuarios.DataSource = null;
               GridViewUsuarios.DataBind();
           }
        }
        
    }
}