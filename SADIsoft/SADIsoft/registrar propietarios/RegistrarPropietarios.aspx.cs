using SADI.Code;
using SADI.Controller;
using SADIsoft.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SADIsoft.registrar_propietarios
{
    public partial class RegistrarPropietarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["Usuario"]);
            Response.Write(Session["Tipo"]);

            if (Session["Usuario"] == null)
            {
                Response.Redirect("/LoginResponse.aspx");
            }
            else if (Convert.ToInt32(Session["Tipo"]) == 3)
                Response.Redirect("/LoginResponse.aspx");



            if (!IsPostBack)
            {
                CargarProvincias();
            }


        }
        private void CargarProvincias()
        {
            ddlProvinciaP.DataSource = ProvinciaDA.CargarProvincias();
            ddlProvinciaP.DataTextField = "Nombre";
            ddlProvinciaP.DataValueField = "ProvinciaId";
            ddlProvinciaP.DataBind();

            if (ddlProvinciaP.Items.Count != 0)
            {
                int ProvinciaId = Convert.ToInt32(ddlProvinciaP.SelectedValue);

                CargarMunicipios(ProvinciaId);
            }
            else
            {
                ddlMunicipioP.Items.Clear();
                ddlSectorP.Items.Clear();
                //dvCustomer.DataSource = null;
                //dvCustomer.DataBind();
            }

        }
        private void CargarMunicipios(int ProvinciaId)
        {
            ddlMunicipioP.DataSource = MunicipioDA.CargarMunicipios(ProvinciaId);
            ddlMunicipioP.DataTextField = "Nombre";
            ddlMunicipioP.DataValueField = "MunicipioId";
            ddlMunicipioP.DataBind();


            if (ddlMunicipioP.Items.Count != 0)
            {
                int MunicipioId = Convert.ToInt32(ddlMunicipioP.SelectedValue);

                CargarSectores(MunicipioId);
            }
            else
            {
                ddlSectorP.Items.Clear();
                //dvCustomer.DataSource = null;
                //dvCustomer.DataBind();
            }

        }
        private void CargarSectores(int MunicipioId)
        {
            ddlSectorP.DataSource = SectorDA.CargarSectores(MunicipioId);
            ddlSectorP.DataTextField = "Nombre";
            ddlSectorP.DataValueField = "SectorId";
            ddlSectorP.DataBind();

        }
        string cedula;


        protected void btnRegistrarPropietario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreP.Text;
            string apellido = txtApellidoP.Text;


            cedula = txtCedulaP.Text;


            int provinciaId = Convert.ToInt32(ddlProvinciaP.SelectedValue);
            int municipioId = Convert.ToInt32(ddlMunicipioP.SelectedValue);
            int sectorId = Convert.ToInt32(ddlSectorP.SelectedValue);
            string calle = txtCalleP.Text;
            string numero = txtNumeroP.Text;
            string telefono1 = txtTelefonos1P.Text;
            string telefono2 = txtTelefonos2P.Text;
            string email = txtEmail1P.Text;

            try
            {
                //if (Validacion.ValidarCedula(cedula, false))
                //{

                    RegistrarPropietarioControlador.RegistrarPropietario(nombre, apellido, cedula, provinciaId, municipioId,
                        sectorId, calle, numero, telefono1, telefono2, email);
                    
                    Response.Write("Propietario registrado con exito");
                    Response.Redirect("/propietarios registrados/PropietariosReg.aspx");
               // }
               // else
               // {
               //     Label1.Visible = true;
              //  }

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }

        }

        protected void ddlProvinciaP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ProvinciaId = Convert.ToInt32(ddlProvinciaP.SelectedValue);
            CargarMunicipios(ProvinciaId);
        }

        protected void ddlMunicipioP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MunicipioId = Convert.ToInt32(ddlMunicipioP.SelectedValue);
            CargarSectores(MunicipioId);
        }
    }
}