using SADI.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SADI
{
    public partial class RegistrarUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;

                if (RegistrarUsuariosControlador.RegistrarUsuario(email))
                {
                    Response.Write("Enviado");
                }
                else
                {
                    Response.Write("Error");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.Redirect("Default.aspx");
        }
    }
}