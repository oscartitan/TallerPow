using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TallerPowVive.CONTROLADOR
{
    public class ConexionControllers
    {

        public string cadenaConexionOra()
        {
            return ConfigurationManager.ConnectionStrings["conexion_oracle"].ConnectionString;
               
        }


    }
}