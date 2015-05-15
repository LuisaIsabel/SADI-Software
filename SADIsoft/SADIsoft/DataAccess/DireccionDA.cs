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
    public class DireccionDA
    {
        private static SqlConnection conn;
        private static SqlCommand com;

       
        //-------------------------------------------------
        // Inserta la direccion y retorna el ultimo Id
        //-------------------------------------------------
        public static int registrarDireccionDB(Direccion dir)
        {

            try
            {
                conn = Conexion.Conectar();
                com = new SqlCommand();
                SqlDataReader dr;

                //transaccion
                string sql = string.Format(@"INSERT INTO Direcciones(Calle,Numero,SectorId,MunicipioId,ProvinciaID) 
                values('{0}','{1}',{2},{3},{4})", dir.Calle, dir.Numero, dir.Sector, dir.Municipio, dir.Provincia);
                com = new SqlCommand(sql, conn);

                int ultimoId = 0;

                if (com.ExecuteNonQuery() != 0)
                {
                    sql = string.Format(@"SELECT SCOPE_IDENTITY() AS [UltimoId]");
                    com = new SqlCommand(sql, conn);
                    dr = com.ExecuteReader();

                    while (dr.Read())
                    {
                        ultimoId = int.Parse(dr["UltimoId"].ToString());
                    }
                    dr.Close();
                    conn.Close();

                }

                return ultimoId;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}