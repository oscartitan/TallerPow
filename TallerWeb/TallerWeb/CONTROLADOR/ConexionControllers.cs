
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
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

        // Ejecutar metodos 
        public int OraProcedimiento(string SQL)
        {
            int registros = 0;
            OracleConnection conexion = new OracleConnection(this.cadenaConexionOra());                        
            conexion.Open();
            System.Data.OracleClient.OracleCommand comando = conexion.CreateCommand();
            System.Data.OracleClient.OracleTransaction transaction = conexion.BeginTransaction();            

            try
            {
                comando.Transaction = transaction;
                comando.CommandText = SQL;
                registros = comando.ExecuteNonQuery();
                
                transaction.Commit();                               
            }
            catch (Exception) // atrapa la excepcion que hereden de System.Exception
            {
                transaction.Rollback();
                registros = 0;
            }
            finally  // se ejecuta si se produce o no una excepcion 
            {                
                conexion.Close();
                comando.Dispose();      
            }

            return registros;
        }


    }
}