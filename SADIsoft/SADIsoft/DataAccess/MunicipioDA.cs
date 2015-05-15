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
    public class MunicipioDA
    {
        private static SqlConnection conn;
        private static SqlCommand com;
        private static SqlDataReader dr;


        //------------------------------------------------------------
        // Retorna una lista de los municipios
        //------------------------------------------------------------
        public static List<Municipio> CargarMunicipios(int provinciaId)
        {
            List<Municipio> lista = new List<Municipio>();
            conn = Conexion.Conectar();

            string query = string.Format(@"SELECT MunicipioId, Nombre FROM Municipios WHERE ProvinciaId = {0}",
                provinciaId);
            com = new SqlCommand(query, conn);
            dr = com.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(CargarMunicipio(dr));
            }

            Municipio item = new Municipio();
            item.Nombre = "-Seleccione-";

            lista.Insert(0, item);

            conn.Close();
            return lista;

        }


        //-------------------------------------------------------
        // Crea un municipio desde la Base de Datos
        //-------------------------------------------------------
        private static Municipio CargarMunicipio(SqlDataReader dr)
        {
            Municipio item = new Municipio();
            item.MunicipioId = Convert.ToInt32(dr["MunicipioID"]);
            item.Nombre = dr["Nombre"].ToString();

            return item;
        }

    }
}