using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TallerWeb.MODELO;

namespace TallerWeb.CONTROLADOR
{

    public class IniciarSesionControllers
    {        

        // metodo para validar el usuario y contraseña
        public static DataSet validacion(string usuario, string contrasena)
        {
            IniciarSesionModels usu = new IniciarSesionModels();

            try
            {
                return usu.validacionUsuario(usuario, contrasena);
            }
            catch (Exception)
            {
                throw; // para lanzar la exception o complementar la capturada
            }
        }

    }
}