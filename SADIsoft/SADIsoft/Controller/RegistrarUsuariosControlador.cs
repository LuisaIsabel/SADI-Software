using SADI.DataAccess;
using SADIsoft.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SADI.Controller
{
    public class RegistrarUsuariosControlador
    {
        public  static bool RegistrarUsuario(string email)
        {
            try
            {
                if (UsuarioDA.RegistrarUsuarioDB(email)) return true;

                return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}