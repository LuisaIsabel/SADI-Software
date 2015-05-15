using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SADIsoft.DataAccess;
using System.Data.SqlClient;
using System.Data;
using SADI.Model;


namespace SADIsoft.DataAccess
{
    public class UsuarioDA
    {
        private static SqlConnection conn;
        private static SqlCommand com;


        //---------------------------------------------
        // Verifica que el usuario sea valido
        //---------------------------------------------
        public static bool ValidarUsuarioDB(Usuario us)
        {
            try
            {
                conn = Conexion.Conectar();

                string query = string.Format(@"SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = '{0}' AND RandomPass = '{1}'",
                        us.Nombre, us.Contrasena);

                com = new SqlCommand(query, conn);

                int i = Convert.ToInt32(com.ExecuteScalar());

                if (i == 1)
                {
                    return true;
                }
                conn.Close();
                return false; ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //----------------------------------------------------------------------
        // Cambia la contraseña provicional a una nueva contraseña
        //---------------------------------------------------------------------
        public static bool CambiarContrasenaDB(string usuario, string contrasena)
        {
            try
            {
                conn = Conexion.Conectar();
                string query = string.Format(@"UPDATE Usuarios SET contrasena = '{0}', Estado = 1 WHERE NombreUsuario = '{1}'",
                                               contrasena, usuario);
                com = new SqlCommand(query, conn);
                com.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        //--------------------------------------------------
        // 
        //--------------------------------------------------
        public static bool isCuentaValidadaDB(string usuario)
        {
            try
            {
                conn = Conexion.Conectar();

                string query = string.Format(@"SELECT Estado FROM Usuarios WHERE NombreUsuario = '{0}'", usuario);

                com = new SqlCommand(query, conn);


                int i = Convert.ToInt32(com.ExecuteScalar());
                if (i == 1) return true;

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //-----------------------------------------------
        // Verifica el rol del usuario y lo retorna
        //-----------------------------------------------
        internal static int VerificarUsuarioDB(Usuario us)
        {
            try
            {
                conn = Conexion.Conectar();

                string query = string.Format(@"SELECT Tipo FROM Usuarios WHERE NombreUsuario = '{0}' AND Contrasena = '{1}'",
                        us.Nombre, us.Contrasena);

                com = new SqlCommand(query, conn);

                int i = Convert.ToInt32(com.ExecuteScalar());

                conn.Close();
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //------------------------------------------------
        // 
        //------------------------------------------------
        public static bool RegistrarUsuarioDB(string email)
        {
            try
            {
                conn = Conexion.Conectar();

                string query = string.Format(@"INSERT INTO Usuarios(NombreUsuario, RandomPass, Tipo, Estado) VALUES ('{0}','{1}',1,0)",
                    email, Usuario.EnviarEmailUsuario(email));
                com = new SqlCommand(query, conn);

                int i = com.ExecuteNonQuery();
                if (i == 1) return true;

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}