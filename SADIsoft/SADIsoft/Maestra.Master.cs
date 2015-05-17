using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginBootrah
{
    public partial class Maestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnIniciarSeccion_Click(object sender, EventArgs e)
        {
            //Page.ClientScript.RegisterStartupScript(GetType(),"Mi Prueba","alert('Prueba Carlos')",true);
            Response.Redirect("/Login.aspx");
        }
    }
}