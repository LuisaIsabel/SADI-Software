using SADI.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SADIsoft.registrar_usuario
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail1.Text;

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
    }
}