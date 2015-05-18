using SADI.DataAccess;
using SADI.Model;
using SADIsoft.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SADIsoft.Controller
{
    public static class RegistrarInmuebleControlador
    {

        public static int RegistrarInmueble(int propietarioId, int provinciaId, int municipioId, int sectorId, string calle, 
            string numero, bool tipo, decimal precioAlquiler, int depositos, decimal precioVenta, int niveles, 
            bool tipoInmueble, bool sotano, bool piscina, bool marquesina, int capacidad, string comentarios, string foto1, 
            string foto2, string foto3, string foto4, int habitaciones, int banos)
        {
            try
            {
                Direccion direccion = new Direccion(calle, numero, sectorId, municipioId, provinciaId);

                Inmueble inmueble = new Inmueble(propietarioId, direccion, tipo, precioAlquiler, depositos,
                    precioVenta, niveles, tipoInmueble, sotano, piscina, marquesina, capacidad, comentarios, foto1, foto2, foto3, foto4, habitaciones, banos);

                int id = InmuebleDA.RegistrarInmuebleDB(inmueble);
                return id;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}