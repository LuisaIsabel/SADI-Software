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
    public class PropietarioDA
    {
        private static SqlConnection conn;
        private static SqlCommand com;
        private static SqlDataReader dr;

       
        //--------------------------------------------------------
        // Inserta un nuevo propietario en la Base de Datos
        //--------------------------------------------------------
        public static void RegistrarPropietarioDB(Propietario prop)
        {
            try
            {
                conn = Conexion.Conectar();
                com = new SqlCommand();
                com.Connection = conn;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "USP_Registrar_Propietario";

                com.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = prop.Nombre;
                com.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = prop.Apellido;
                com.Parameters.Add("@Telefono1", SqlDbType.VarChar).Value = prop.Telefono1;
                com.Parameters.Add("@Telefono2", SqlDbType.VarChar).Value = prop.Telefono2;
                com.Parameters.Add("@Email", SqlDbType.VarChar).Value = prop.Email;
                com.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = prop.Cedula;
                com.Parameters.Add("@Calle", SqlDbType.VarChar).Value = prop.Direccion.Calle;
                com.Parameters.Add("@Numero", SqlDbType.VarChar).Value = prop.Direccion.Numero;
                com.Parameters.Add("@SectorId", SqlDbType.Int).Value = prop.Direccion.Sector;
                com.Parameters.Add("@MunicipioId", SqlDbType.Int).Value = prop.Direccion.Municipio;
                com.Parameters.Add("@ProvinciaId", SqlDbType.Int).Value = prop.Direccion.Provincia;

                int usuarioId = Convert.ToInt32(com.ExecuteScalar());

                if (prop.Email != "")
                {
                    RegistrarRandomPropietario(Usuario.EnviarEmailUsuario(prop.Email), usuarioId);
                }


                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //------------------------------------------------------------
        // Actualiza una Contrasena Temporal en la DB
        //------------------------------------------------------------
        private static void RegistrarRandomPropietario(string p, int u)
        {
            try
            {
                conn = Conexion.Conectar();
                string query = string.Format(@"UPDATE Usuarios SET RandomPass = '{0}' WHERE UsuarioId = {1} ",
                    p, u);
                SqlCommand com = new SqlCommand(query, conn);
                com.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //--------------------------------------------------------
        // Busca un Propietario por el Id y lo retorna
        //--------------------------------------------------------
        public static Propietario BuscarPorIdDB(int idPropietario)
        {
            try
            {
                conn = Conexion.Conectar();
                string query = string.Format(@"SELECT P.Telefono1, P.Telefono2, U.NombreUsuario, D.Calle, D.Numero,
                Pr.ProvinciaId, M.MunicipioId, S.SectorId FROM Propietarios AS P LEFT JOIN Usuarios AS U ON 
                p.UsuarioId = U.UsuarioId INNER JOIN Direcciones AS D ON P.DireccionId = D.DireccionId 
                INNER JOIN Provincias AS Pr ON D.ProvinciaId = Pr.ProvinciaId INNER JOIN Municipios AS M ON D.MunicipioId = M.MunicipioId
                INNER JOIN Sectores AS S ON D.SectorId = S.SectorId WHERE P.PropietarioId = {0}", idPropietario);

                com = new SqlCommand(query, conn);
                dr = com.ExecuteReader();

                Propietario p = new Propietario();
                p.Direccion = new Direccion();

                while (dr.Read())
                {

                    p.Telefono1 = dr["Telefono1"].ToString();
                    p.Telefono2 = dr["Telefono2"].ToString();
                    p.Email = dr["NombreUsuario"].ToString();
                    p.Direccion.Calle = dr["Telefono1"].ToString();
                    p.Direccion.Numero = dr["Numero"].ToString();
                    p.Direccion.Provincia = Convert.ToInt32(dr["ProvinciaId"]);
                    p.Direccion.Municipio = Convert.ToInt32(dr["MunicipioId"]);
                    p.Direccion.Sector = Convert.ToInt32(dr["SectorId"]);
                }
                conn.Close();
                dr.Close();
                return p;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //-----------------------------------------------------------------------------------------
        // Actualiza los datos del propietario, retiornando una cadena con el Id y los telefonos
        //-----------------------------------------------------------------------------------------
        public static string ActualizarPropietarioDB(int id, string tel1, string tel2, string email)
        {
            try
            {
                conn = Conexion.Conectar();
                com = new SqlCommand();
                com.Connection = conn;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "USP_Actualizar_Propietario";

                com.Parameters.Add("@PropietarioId", SqlDbType.Int).Value = id;
                com.Parameters.Add("@Tel1", SqlDbType.VarChar).Value = tel1;
                com.Parameters.Add("@Tel2", SqlDbType.VarChar).Value = tel2;
                com.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;

                int usu = Convert.ToInt32(com.ExecuteScalar());

                if (email != "")
                {
                    RegistrarRandomPropietario(Usuario.EnviarEmailUsuario(email), usu);

                }
                conn.Close();

                return id + tel1 + tel2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //---------------------------------------------
        // Retorna una lista de Propietarios
        //---------------------------------------------
        public static List<Propietario> CargarPropietariosDB()
        {
            try
            {
                List<Propietario> lista = new List<Propietario>();

                conn = Conexion.Conectar();
                string query = string.Format(@"SElECT PropietarioId, Nombre + ' ' + Apellido AS Nombre	FROM Propietarios");
                com = new SqlCommand(query, conn);
                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(AgregarPropietario(dr));
                }
                Propietario item = new Propietario();
                item.Nombre = "- Seleccione -";
                lista.Insert(0, item);

                dr.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //------------------------------------------------------------
        // Crea un nuevo propietario
        //------------------------------------------------------------
        private static Propietario AgregarPropietario(SqlDataReader dr)
        {
            Propietario propietario = new Propietario();
            propietario.Nombre = dr["Nombre"].ToString();
            propietario.PropietarioId = Convert.ToInt32(dr["PropietarioID"]);

            return propietario;
        }

    }
}