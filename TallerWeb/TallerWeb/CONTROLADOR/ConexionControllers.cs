using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace TallerWeb.CONTROLADOR
{
    public class ConexionControllers
    {
        public string cadenaConexionOra()
        {
            return ConfigurationManager.ConnectionStrings["conexion_oracle"].ConnectionString;
        }

        public DataSet OraSqlQuery(String SQL)
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

        // Ejecutar metodos 
        public DataTable ExecuteReader(string procedimiento)
        {
            OracleConnection conexion = new OracleConnection(this.cadenaConexionOra());
            DataTable tabla = new DataTable();
            try
            {
                OracleDataReader cursor;
                conexion.Open();
                OracleCommand DbCommand = new OracleCommand(procedimiento, conexion);
                DbCommand.CommandType = CommandType.StoredProcedure;
                OracleDataReader lector = DbCommand.ExecuteReader();
                cursor = DbCommand.ExecuteReader();
                tabla.Load(cursor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
            }
            return tabla;
        }


    }
}