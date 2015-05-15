using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SADI.Model;
using SADI.DataAccess;
using SADIsoft.DataAccess;

namespace SADI.Controller
{
    public class RegistrarPropietarioControlador
    {
        public static void RegistrarPropietario(string nombre, string apellido, string cedula, int provincia,
            int municipio, int sector, string calle, string numero, string tel1, string tel2, string email)
        {
            try
            {

                Direccion dir = new Direccion(calle, numero, sector, municipio, provincia);

                Propietario prop = new Propietario(nombre, apellido, cedula, dir, tel1, tel2, email);
                PropietarioDA.RegistrarPropietarioDB(prop);

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}