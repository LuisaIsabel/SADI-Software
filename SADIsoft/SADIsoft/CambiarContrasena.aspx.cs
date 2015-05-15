using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SADI.Controller;

namespace SADI
{
    public partial class CambiarContrasena : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
                Response.Redirect("Login.aspx");
            Response.Write(Session["Usuario"]);

        }

        
        protected void btnListo_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginControlador.CambiarContrasena(Session["Usuario"].ToString(), txtContrasena.Text)) Response.Write("Bien");
                Response.Redirect("Propietarios.aspx");
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            
        }
    }
}