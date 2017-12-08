using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
                return usu.validacionUsuario(usuario, Encripta_Password(contrasena));
            }
            catch (Exception ex)
            {
                throw; // para lanzar la exception o complementar la capturada
            }
        }

        // inserto en la base de datos un usuario
        public static int adicionarUsuario(string usuario, string contrasena, string nombre) {
            IniciarSesionModels usu = new IniciarSesionModels();

            try
            {
                return usu.insertarUsuario(usuario, Encripta_Password(contrasena), nombre);
            }
            catch (Exception ex)
            {
                throw; // para lanzar la exception o complementar la capturada
            }
        }

        // para encriptar la contraseña en hash de 64 
        public static string Encripta_Password(string originalPassword)
        {

            SHA1CryptoServiceProvider cryptoServiceProvider = new SHA1CryptoServiceProvider();
            byte[] bytes = Encoding.UTF8.GetBytes(originalPassword);
            byte[] hash = cryptoServiceProvider.ComputeHash(bytes);
            cryptoServiceProvider.Clear();
            return Convert.ToBase64String(hash);
        }

        // metodo para validar el usuario y contraseña
        public static DataSet mostrarUsuarios()
        {
            IniciarSesionModels usu = new IniciarSesionModels();

            try
            {
                return usu.listadoUsuarios();
            }
            catch (Exception ex)
            {
                throw; // para lanzar la exception o complementar la capturada
            }
        }

        //delete 
        public static int eliminarUsuario(string usuario)
        {
            IniciarSesionModels usu = new IniciarSesionModels();

            try
            {
                return usu.borrarUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw; // para lanzar la exception o complementar la capturada
            }
        }

    }
}