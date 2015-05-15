using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SADI.Controller;

namespace SADI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                string usuario = txtUsuario.Text;
                string contrasena = txtContrasena.Text;

                try
                {
                    if (!LoginControlador.IsCuentaValidada(usuario))
                    {

                        if (LoginControlador.ValidarUsuario(usuario, contrasena))
                        {
                            Session["Usuario"] = usuario;
                            Response.Write("Logeado");
                            Response.Redirect("CambiarContrasena.aspx");
                        }
                        else
                        {
                            Response.Write("No logeado");
                        }
                    }
                    else
                    {
                        int tipo = LoginControlador.VerificarUsuario(usuario, contrasena);
                        if (tipo != 0)
                        {
                            Session["Usuario"] = usuario;
                            Session["Tipo"] = tipo;

                            if (tipo == 1)
                                Response.Redirect("Administracion.aspx");
                            if (tipo == 2)
                                Response.Redirect("Administracion.aspx");
                            if (tipo == 3)
                                Response.Redirect("PropietarioCuenta.aspx");
                        }
                        else
                        {
                            Response.Write("No logeado");
                        }
                    }
                    
                }
                catch(Exception ex){
                    Response.Write(ex.ToString());
                }

            
        }
    }
}