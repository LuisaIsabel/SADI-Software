using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace SADIsoft.prueba
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string nombre;

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SadiConnectionString"].ConnectionString);
            string sql = string.Format("SELECT Foto1 FROM Inmuebles WHERE InmuebleId = 5");
            con.Open();
            SqlCommand com = new SqlCommand(sql,con);

            nombre = com.ExecuteScalar().ToString();


            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(nombre);
            Response.Write(string.Format("/Images/1088-5/{0}",nombre));
            ImageButton1.ImageUrl = string.Format("/Images/1088-5/{0}", nombre);
           
        }
    }
}