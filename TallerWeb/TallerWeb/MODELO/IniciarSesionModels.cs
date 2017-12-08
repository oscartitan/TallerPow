using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TallerWeb.CONTROLADOR;

namespace TallerWeb.MODELO
{
    public class IniciarSesionModels
    {
        ConexionControllers dataload = new ConexionControllers();


        internal DataSet validacionUsuario(string usuario, string contrasena)
        {
            String Sql = "select NOMBRE_USUARIO from TUSUARIOS where USUARIO_USUARIO = '" + usuario + "' and CONTRASENA_USUARIO = '" + contrasena + "'";
            return dataload.OraConsulta(Sql);
        }

    }
}