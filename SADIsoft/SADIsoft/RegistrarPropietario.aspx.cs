using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SADI.Controller;
using SADI.DataAccess;
using SADI.Code;
using SADIsoft.DataAccess;

namespace SADI
{
    public partial class ResgistrarPropietario : System.Web.UI.Page
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
           


            if (!IsPostBack)
            {
                CargarProvincias();
            }

        }

        private void CargarProvincias()
        {
            ddlProvincia.DataSource = ProvinciaDA.CargarProvincias();
            ddlProvincia.DataTextField = "Nombre";
            ddlProvincia.DataValueField = "ProvinciaId";
            ddlProvincia.DataBind();
            
            if (ddlProvincia.Items.Count != 0)
            {
                int ProvinciaId = Convert.ToInt32(ddlProvincia.SelectedValue);

                CargarMunicipios(ProvinciaId);
            }
            else
            {
                ddlMunicipio.Items.Clear();
                ddlSector.Items.Clear();
                //dvCustomer.DataSource = null;
                //dvCustomer.DataBind();
            }
             
        }

        private void CargarMunicipios(int ProvinciaId)
        {
            ddlMunicipio.DataSource = MunicipioDA.CargarMunicipios(ProvinciaId);
            ddlMunicipio.DataTextField = "Nombre";
            ddlMunicipio.DataValueField = "MunicipioId";
            ddlMunicipio.DataBind();
            

            if (ddlMunicipio.Items.Count != 0)
            {
                int MunicipioId = Convert.ToInt32(ddlMunicipio.SelectedValue);

                CargarSectores(MunicipioId);
            }
            else
            {
                ddlSector.Items.Clear();
                //dvCustomer.DataSource = null;
                //dvCustomer.DataBind();
            }
             
        }

        private void CargarSectores(int MunicipioId)
        {
            ddlSector.DataSource = SectorDA.CargarSectores(MunicipioId);
            ddlSector.DataTextField = "Nombre";
            ddlSector.DataValueField = "SectorId";
            ddlSector.DataBind();
            
        }
        string cedula;
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            
            
            cedula = txtCedula.Text;
            
            
            int provinciaId = Convert.ToInt32(ddlProvincia.SelectedValue);
            int municipioId = Convert.ToInt32(ddlMunicipio.SelectedValue);
            int sectorId = Convert.ToInt32(ddlSector.SelectedValue);
            string calle = txtCalle.Text;
            string numero = txtNumero.Text;
            string telefono1 = txtTelefono1.Text;
            string telefono2 = txtTelefono2.Text;
            string email = txtEmail.Text;

            try
            {
                if (Validacion.ValidarCedula(cedula,false))
                {

                    RegistrarPropietarioControlador.RegistrarPropietario(nombre, apellido, cedula, provinciaId, municipioId,
                        sectorId, calle, numero, telefono1, telefono2, email);


                    Response.Write("Propietario registrado con exito");
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Label1.Visible = true;
                }
                
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ProvinciaId = Convert.ToInt32(ddlProvincia.SelectedValue);
            CargarMunicipios(ProvinciaId);
            
        }

        protected void ddlMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MunicipioId = Convert.ToInt32(ddlMunicipio.SelectedValue);
            CargarSectores(MunicipioId);
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.Redirect("Default.aspx");
        }

     
      

        
    }
}