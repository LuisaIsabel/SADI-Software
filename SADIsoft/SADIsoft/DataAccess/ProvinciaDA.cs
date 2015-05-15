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
    public class ProvinciaDA
    {
        private static SqlConnection conn;
        private static SqlCommand com;
        private static SqlDataReader dr;

        //---------------------------------------------
        // Retorna una lista de todas las Provincias
        //---------------------------------------------
        public static List<Provincia> CargarProvincias()
        {
            try
            {
                List<Provincia> lista = new List<Provincia>();

                conn = Conexion.Conectar();

                string query = string.Format(@"SELECT ProvinciaId,Nombre FROM Provincias");
                com = new SqlCommand(query, conn);
                dr = com.ExecuteReader();


                while (dr.Read())
                {
                    lista.Add(CargarProvincia(dr));
                }

                Provincia item = new Provincia();
                item.Nombre = "-Seleccione-";
                lista.Insert(0, item);

                conn.Close();

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //-------------------------------------------------------
        // Crea una Provincia desde la Base de Datos
        //-------------------------------------------------------
        private static Provincia CargarProvincia(SqlDataReader dr)
        {
            Provincia prov = new Provincia();
            prov.ProvinciaId = Convert.ToInt32(dr["ProvinciaId"]);
            prov.Nombre = dr["Nombre"].ToString();

            return prov;
        }


    }
}