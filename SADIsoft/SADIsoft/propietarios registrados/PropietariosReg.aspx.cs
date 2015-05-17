using SADI.Controller;
using SADI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SADIsoft.propietarios_registrados
{
    public partial class PropietariosReg : System.Web.UI.Page
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

                txtTelefonops1.Text = prop.Telefono1;
                txtTelefonos2.Text = prop.Telefono2;
                TextEmail.Text = prop.Email;

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }

        }

        protected void btnActualizarP_Click(object sender, EventArgs e)
        {
            try
            {
                int idPropietario = Convert.ToInt32(GridView1.SelectedDataKey.Value);
                string s = MantenimientoPropietarioControlador.ActualizarPropietario(idPropietario, txtTelefonops1.Text, txtTelefonos2.Text, TextEmail.Text);
                Response.Write(s.ToString());
                GridView1.UpdateRow(Convert.ToInt32(GridView1.SelectedDataKey.Value), false);

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }

        }
    }
}