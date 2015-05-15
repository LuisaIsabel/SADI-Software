using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SADI.Controller;

namespace SADIsoft
{
    public partial class RegistrarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string cedula = txtCedula.Text;
                string direccion = txtDireccion.Text;
                string tel1 = txtTelefono1.Text;
                string tel2 = txtTelefono2.Text;
                string email = txtEmail.Text;

                RegistrarClienteControlador.RegistrarCliente(nombre, apellido, cedula, direccion, tel1, tel2, email);

            }
            catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}