using SADI.DataAccess;
using SADIsoft.Controller;
using SADIsoft.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SADI
{
    public partial class RegistrarInmuebles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Response.Write(Session["Usuario"]);
            Response.Write(Session["Tipo"]);

            if (Session["Usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else if (Convert.ToInt32(Session["Tipo"]) == 3)
                Response.Redirect("Login.aspx");

         */
            if (!IsPostBack)
            {
                CargarPropietarios();
                CargarProvincias();
            }

            if (rbAlquiler.Checked == true)
            {
                txtPrecioAlquiler.Enabled = true;
                txtPrecioVenta.Enabled = false;
                ddlDepositos.Enabled = true;

            }
            else
            {
                txtPrecioAlquiler.Enabled = false;
                txtPrecioVenta.Enabled = true;
                ddlDepositos.Enabled = false;
            }

            if (cbMarquesina.Checked == true)
            {
                ddlCapacidadMarquesina.Enabled = true;
            }
        }

        private void CargarPropietarios()
        {
            ddlPropietario.DataSource = PropietarioDA.CargarPropietariosDB();
            ddlPropietario.DataTextField = "Nombre";
            ddlPropietario.DataValueField = "PropietarioId";
            ddlPropietario.DataBind();
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
           /* Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.Redirect("Default.aspx");*/
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            int propietarioId = Convert.ToInt32(ddlPropietario.SelectedValue);
            int provinciaId = Convert.ToInt32(ddlProvincia.SelectedValue);
            int municipioId = Convert.ToInt32(ddlMunicipio.SelectedValue);
            int sectorId = Convert.ToInt32(ddlSector.SelectedValue);
            string calle = txtCalle.Text;
            string numero = txtNumero.Text;
            bool tipo;
            if (rbAlquiler.Checked)
            {
                tipo = true;
            }
            else
            {
                tipo = false;
            }

            decimal precioAlquiler = 0.0m;
            if (txtPrecioAlquiler.Text != "")
            {
                precioAlquiler = Convert.ToDecimal(txtPrecioAlquiler.Text);
            }
            int depositos = 0;
            if (ddlDepositos.SelectedValue != "")
            {
                depositos = Convert.ToInt32(ddlDepositos.SelectedValue);
            }

            decimal precioVenta = 0.0m;
            if (txtPrecioVenta.Text != "")
            {
                precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            }
            
            int niveles = Convert.ToInt32(ddlNiveles.SelectedValue);

            bool sotano = cbSotano.Checked;
            bool piscina = cbPiscina.Checked;
            bool marquesina = cbMarquesina.Checked;
            int capacidad = Convert.ToInt32(ddlCapacidadMarquesina.Text);
            int habitaciones = Convert.ToInt32(ddlHabitaciones.Text);
            int banos = Convert.ToInt32(ddlBanos.Text);

            string foto1 = Server.MapPath(string.Format(@"~\" + @"{0}\",propietarioId.ToString()));
            Directory.CreateDirectory(foto1);
            FileUpload1.SaveAs(foto1 += propietarioId.ToString() + "1.jpg");

            string foto2 = Server.MapPath(string.Format(@"~\" + @"{0}\",propietarioId.ToString()));
            Directory.CreateDirectory(foto2);
            FileUpload1.SaveAs(foto2 += propietarioId.ToString() + "2.jpg");

            string foto3 = Server.MapPath(string.Format(@"~\" + @"{0}\", propietarioId.ToString()));
            Directory.CreateDirectory(foto3);
            FileUpload1.SaveAs(foto3 += propietarioId.ToString() + "3.jpg");

            string foto4 = Server.MapPath(string.Format(@"~\" + @"{0}\",propietarioId.ToString()));
            Directory.CreateDirectory(foto4);
            FileUpload1.SaveAs(foto4 += propietarioId.ToString() + "4.jpg");
            
            string comentarios = txtComentarios.Text;

            bool tipoInmueble = false;
            if (rbAlquiler.Checked) tipoInmueble = true;

            try
            {
                RegistrarInmuebleControlador.RegistrarInmueble(propietarioId, provinciaId, municipioId, sectorId, calle, numero,
                    tipo, precioAlquiler, depositos, precioVenta, niveles, tipoInmueble, sotano, piscina, marquesina, capacidad, comentarios,
                    foto1, foto2, foto3, foto4,habitaciones,banos);
            }
            catch(Exception ex)
            {
                Response.Write(ex);
            }
            
            Response.Write(propietarioId + " " + provinciaId + " " + municipioId + " " + sectorId + " " + 
                calle + " " + numero + " " + tipo + " " + precioAlquiler + " " + depositos + " " + precioVenta + " " + niveles
                + " " + sotano + " " + piscina + " " + marquesina + " " +  foto1 + " " +  foto2 + " " +  foto3 + " " + foto4 + " " + tipoInmueble );



        }

        protected void ddlPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
    }
}