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


        public DataSet OraConsulta(String SQL)
        {
            OracleConnection conexion = new OracleConnection(this.cadenaConexionOra());
            //OracleConnection conexion = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.1.1.2)(PORT=1521))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=XE)));User ID=TALLER;Password=admin; Unicode=true");
            OracleCommand comando = new OracleCommand(SQL, conexion);
            OracleDataAdapter datos = new OracleDataAdapter(comando);
            DataSet tabla = new DataSet();
            //Excepciones (bloques: try - catch - finally)
            try // Se ejecuta hasta que termine o se genere una excepcion
            {
                conexion.Open();
                datos.Fill(tabla);
            }
            catch (Exception) // atrapa la excepcion que hereden de System.Exception
            {
                return null;
            }
            finally  // se ejecuta si se produce o no una excepcion 
            {
                conexion.Close();
                comando.Dispose();
            }
            return tabla;
        }

    }
}