using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SADI.Model;
using SADI.DataAccess;
using SADIsoft.DataAccess;

namespace SADI.Controller
{
    public class LoginControlador
    {
        public static bool ValidarUsuario(string usuario, string contrasena)
        {
            try
            {
                Usuario us = new Usuario(usuario, contrasena);
                if (UsuarioDA.ValidarUsuarioDB(us)) return true;

                return false;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool CambiarContrasena(string usuario, string contrasena)
        {
            try
            {
                if (UsuarioDA.CambiarContrasenaDB(usuario, contrasena)) return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public static bool IsCuentaValidada(string usuario)
        {

            try
            {
                if (UsuarioDA.isCuentaValidadaDB(usuario))
                {
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static int VerificarUsuario(string usuario, string contrasena)
        {
             try
            {
                Usuario us = new Usuario(usuario, contrasena);
                int i = UsuarioDA.VerificarUsuarioDB(us);

                return i;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }

       
    }
}