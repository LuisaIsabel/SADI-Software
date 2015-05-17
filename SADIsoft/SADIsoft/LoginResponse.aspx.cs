using SADI.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SADIsoft
{
    public partial class LoginResponse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = textUsuarios.Text;
            string contrasenia = textContrase.Text;

            try
            {
                if (!LoginControlador.IsCuentaValidada(usuario))
                {

                    if (LoginControlador.ValidarUsuario(usuario, contrasenia))
                    {
                        Session["Usuario"] = usuario;
                        Response.Write("Logeado");
                        Response.Redirect("LoginCambioResp.aspx");
                    }
                    else
                    {
                        Response.Write("No logeado");
                    }
                }
                else
                {
                    int tipo = LoginControlador.VerificarUsuario(usuario, contrasenia);
                    if (tipo != 0)
                    {
                        Session["Usuario"] = usuario;
                        Session["Tipo"] = tipo;

                        if (tipo == 1)
                            Response.Redirect("AdministracionResp.aspx");
                        if (tipo == 2)
                            Response.Redirect("AdministracionResp.aspx");
                        if (tipo == 3)
                            Response.Redirect("PropietarioCuenta.aspx");
                    }
                    else
                    {
                        Response.Write("No logeado");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());

            }
        }
    }
}