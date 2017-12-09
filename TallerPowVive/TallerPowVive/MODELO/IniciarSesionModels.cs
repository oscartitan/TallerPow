using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TallerPowVive.CONTROLADOR;

namespace TallerPowVive.MODELO
{
    public class IniciarSesionModels
    {
        ConexionControllers dataload = new ConexionControllers();
        String Sql = String.Empty;

        internal DataSet validacionUsuario(string usuario, string contrasena)
        {            
            Sql = "select NOMBRE_USUARIO from TUSUARIOS where USUARIO_USUARIO = '" + usuario + "' and CONTRASENA_USUARIO = '" + contrasena + "'";
            return dataload.OraConsulta(Sql);
        }

        internal int insertarUsuario(string usuario, string contrasena, string nombre)
        {
            Sql = "insert into TALLER.TUSUARIOS(USUARIO_USUARIO,  CONTRASENA_USUARIO,NOMBRE_USUARIO)" +
                " values('" + usuario.ToUpper().Trim() + "','" + contrasena.Trim() + "',INITCAP('" + nombre + "'))";
            return dataload.OraProcedimiento(Sql);
        }

        internal DataSet listadoUsuarios()
        {
            Sql = "select * from TALLER.TUSUARIOS";
            return dataload.OraConsulta(Sql);
        }

        internal int borrarUsuario(string usuario)
        {
            Sql = "delete TALLER.TUSUARIOS where USUARIO_USUARIO = '" + usuario.ToUpper().Trim() + "'";
            return dataload.OraProcedimiento(Sql);
        }
    }
}