using SADI.Controller;
using SADI.DataAccess;
using SADI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SADI
{
    public partial class Propietarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idPropietario = Convert.ToInt32(GridView1.SelectedDataKey.Value);
                Label1.Text = idPropietario.ToString();

                Propietario prop = MantenimientoPropietarioControlador.BuscarPorId(idPropietario);

                txtTelefono1.Text = prop.Telefono1;
                txtTelefono2.Text = prop.Telefono2;
                txtEmail.Text = prop.Email;
                
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPropietario = Convert.ToInt32(GridView1.SelectedDataKey.Value);
                string s = MantenimientoPropietarioControlador.ActualizarPropietario(idPropietario, txtTelefono1.Text, txtTelefono2.Text, txtEmail.Text);
                Response.Write(s.ToString());
                GridView1.UpdateRow(Convert.ToInt32(GridView1.SelectedDataKey.Value), false);
                
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
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