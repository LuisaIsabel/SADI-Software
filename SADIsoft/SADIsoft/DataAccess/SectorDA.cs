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
    public class SectorDA
    {
        private static SqlConnection conn;
        private static SqlCommand com;
        private static SqlDataReader dr;


        //-------------------------------------------------------
        // Retorna una Lista de los Sectores
        //-------------------------------------------------------
        public static List<Sector> CargarSectores(int MunicipioId)
        {
            conn = Conexion.Conectar();
            List<Sector> lista = new List<Sector>();

            string query = string.Format(@"SELECT SectorId, Nombre FROM Sectores WHERE MunicipioId = {0}",
                MunicipioId);
            com = new SqlCommand(query, conn);
            dr = com.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(CargarSector(dr));
            }

            Sector item = new Sector();
            item.Nombre = "-Seleccione-";

            lista.Insert(0, item);

            conn.Close();
            return lista;

        }


        //-------------------------------------------------
        // Crea un Sector desde la Base de Datos
        //-------------------------------------------------
        private static Sector CargarSector(SqlDataReader dr)
        {
            Sector item = new Sector();
            item.SectorId = Convert.ToInt32(dr["SectorId"]);
            item.Nombre = dr["Nombre"].ToString();

            return item;
        }

    }
}