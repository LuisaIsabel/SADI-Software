using SADIsoft.Controller;
using SADIsoft.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SADIsoft.registrar_inmueble
{
    public partial class RegistrarInmuebles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPropietarios();
                CargarProvincias();
               
   
            }

            if (rbAlquiler1.Checked == true)
            {
                txtPrecioAlquiler1.Enabled = true;
                txtPrecioVenta1.Enabled = false;
                ddlDepositos1.Enabled = true;

            }
            else
            {
                txtPrecioAlquiler1.Enabled = false;
                txtPrecioVenta1.Enabled = true;
                ddlDepositos1.Enabled = false;
            }

            if (cbMarquesina1.Checked == true)
            {
                ddlCapacidadMarquesina1.Enabled = true;
            }

        }
        private void CargarPropietarios()
        {
            ddlPropietario1.DataSource = PropietarioDA.CargarPropietariosDB();
            ddlPropietario1.DataTextField = "Nombre";
            ddlPropietario1.DataValueField = "PropietarioId";
            ddlPropietario1.DataBind();
        }
        private void CargarProvincias()
        {
            ddlProvincia1.DataSource = ProvinciaDA.CargarProvincias();
            ddlProvincia1.DataTextField = "Nombre";
            ddlProvincia1.DataValueField = "ProvinciaId";
            ddlProvincia1.DataBind();

            if (ddlProvincia1.Items.Count != 0)
            {
                int ProvinciaId = Convert.ToInt32(ddlProvincia1.SelectedValue);

                CargarMunicipios(ProvinciaId);
            }
            else
            {
                ddlMunicipio1.Items.Clear();
                ddlSector1.Items.Clear();
                //dvCustomer.DataSource = null;
                //dvCustomer.DataBind();
            }

        }
        private void CargarMunicipios(int ProvinciaId)
        {
            ddlMunicipio1.DataSource = MunicipioDA.CargarMunicipios(ProvinciaId);
            ddlMunicipio1.DataTextField = "Nombre";
            ddlMunicipio1.DataValueField = "MunicipioId";
            ddlMunicipio1.DataBind();


            if (ddlMunicipio1.Items.Count != 0)
            {
                int MunicipioId = Convert.ToInt32(ddlMunicipio1.SelectedValue);

                CargarSectores(MunicipioId);
            }
            else
            {
                ddlSector1.Items.Clear();
                //dvCustomer.DataSource = null;
                //dvCustomer.DataBind();
            }

        }
        private void CargarSectores(int MunicipioId)
        {
            ddlSector1.DataSource = SectorDA.CargarSectores(MunicipioId);
            ddlSector1.DataTextField = "Nombre";
            ddlSector1.DataValueField = "SectorId";
            ddlSector1.DataBind();

        }

        protected void btnRegistrar1_Click(object sender, EventArgs e)
        {
            int propietarioId = Convert.ToInt32(ddlPropietario1.SelectedValue);
            int provinciaId = Convert.ToInt32(ddlProvincia1.SelectedValue);
            int municipioId = Convert.ToInt32(ddlMunicipio1.SelectedValue);
            int sectorId = Convert.ToInt32(ddlSector1.SelectedValue);
            string calle = txtCalle1.Text;
            string numero = txtNumero1.Text;
            bool tipo;
            if (rbAlquiler1.Checked)
            {
                tipo = true;
            }
            else
            {
                tipo = false;
            }

            decimal precioAlquiler = 0.0m;
            if (txtPrecioAlquiler1.Text != "")
            {
                precioAlquiler = Convert.ToDecimal(txtPrecioAlquiler1.Text);
            }
            int depositos = 0;
            if (ddlDepositos1.SelectedValue != "")
            {
                depositos = Convert.ToInt32(ddlDepositos1.SelectedValue);
            }

            decimal precioVenta = 0.0m;
            if (txtPrecioVenta1.Text != "")
            {
                precioVenta = Convert.ToDecimal(txtPrecioVenta1.Text);
            }

            int niveles = Convert.ToInt32(ddlNiveles1.SelectedValue);

            bool sotano = cbSotano1.Checked;
            bool piscina = cbPiscina1.Checked;
            bool marquesina = cbMarquesina1.Checked;
            int capacidad = 0;
            if (ddlCapacidadMarquesina1.SelectedIndex != -1)
            {
                capacidad = ddlCapacidadMarquesina1.SelectedIndex;
            }
            int habitaciones = Convert.ToInt32(ddlHabitaciones1.Text);
            int banos = Convert.ToInt32(ddlBanos1.Text);

            string nombreFoto1 = propietarioId.ToString() + "-1.jpg";
            string nombreFoto2 = propietarioId.ToString() + "-2.jpg";
            string nombreFoto3 = propietarioId.ToString() + "-3.jpg";
            string nombreFoto4 = propietarioId.ToString() + "-4.jpg";

            string comentarios = txtComentarios1.Text;

            bool tipoInmueble = false;
            if (rbAlquiler1.Checked) tipoInmueble = true;

            try
            {
                int inmuebleId = RegistrarInmuebleControlador.RegistrarInmueble(propietarioId, provinciaId, municipioId, sectorId, calle, numero,
                    tipo, precioAlquiler, depositos, precioVenta, niveles, tipoInmueble, sotano, piscina, marquesina, capacidad, comentarios,
                    nombreFoto1, nombreFoto2, nombreFoto3, nombreFoto4, habitaciones, banos);

                string foto1 = Server.MapPath(string.Format(@"~\" + @"\Images\{0}-{1}\", propietarioId.ToString(), inmuebleId.ToString()));
                Directory.CreateDirectory(foto1);
                FileUpload1.SaveAs(foto1 += nombreFoto1);

                string foto2 = Server.MapPath(string.Format(@"~\" + @"\Images\{0}-{1}\", propietarioId.ToString(), inmuebleId.ToString()));
                Directory.CreateDirectory(foto2);
                FileUpload2.SaveAs(foto2 += nombreFoto2);

                string foto3 = Server.MapPath(string.Format(@"~\" + @"\Images\{0}-{1}\", propietarioId.ToString(), inmuebleId.ToString()));
                Directory.CreateDirectory(foto3);
                FileUpload3.SaveAs(foto3 += nombreFoto3);

                string foto4 = Server.MapPath(string.Format(@"~\" + @"\Images\{0}-{1}\", propietarioId.ToString(), inmuebleId.ToString()));
                Directory.CreateDirectory(foto4);
                FileUpload4.SaveAs(foto4 += nombreFoto4);

                Response.Redirect("Administracion.aspx");
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }

            
        }

        protected void ddlMunicipio1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MunicipioId = Convert.ToInt32(ddlMunicipio1.SelectedValue);
            CargarSectores(MunicipioId);

        }

        protected void ddlPropietario1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlProvincia1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ProvinciaId = Convert.ToInt32(ddlProvincia1.SelectedValue);
            CargarMunicipios(ProvinciaId);
        }
     
    }
}