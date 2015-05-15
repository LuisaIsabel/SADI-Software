using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace SADIsoft.DataAccess
{
    public class Conexion
    {
        private static SqlConnection c;

        public static SqlConnection Conectar()
        {
            c = new SqlConnection(ConfigurationManager.ConnectionStrings["SadiConnectionString"].ConnectionString);
            c.Open();

            return c;
        }
    }
}