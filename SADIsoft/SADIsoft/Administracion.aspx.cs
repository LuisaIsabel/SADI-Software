using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SADI
{
    public partial class Administracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["Usuario"]);
            Response.Write(Session["Tipo"]);

            if (Session["Usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else if (Convert.ToInt32(Session["Tipo"]) == 3)
                Response.Redirect("Login.aspx");

            if (Convert.ToInt32(Session["Tipo"]) == 2)
            {
                HyperLink2.Visible = false;
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