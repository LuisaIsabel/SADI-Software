using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SADI.Model
{
    public class Direccion
    {
        public Direccion(string calle, string numero, int sector, int municipio, int provincia)
        {
            Calle = calle;
            Numero = numero;
            Sector = sector;
            Municipio = municipio;
            Provincia = provincia;
        }

        public Direccion(int id, string calle, string numero, int sector, int municipio, int provincia)
        {
            DireccionId = id;
            Calle = calle;
            Numero = numero;
            Sector = sector;
            Municipio = municipio;
            Provincia = provincia;
        }

        public Direccion()
        {
            // TODO: Complete member initialization
        }

        public int DireccionId { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public int Sector { get; set; }
        public int Municipio { get; set; }
        public int Provincia { get; set; }

    }

}