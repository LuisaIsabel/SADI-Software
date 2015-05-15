using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SADI.Model
{
    public class Propietario
    {
        public Propietario()
        {

        }

        public Propietario(string nombre, string apellido, string cedula, int direccion, string tel1,
            string tel2, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            DireccionId = direccion;
            Telefono1 = tel1;
            Telefono2 = tel2;
            Email = email;
        }

        public Propietario(string nombre, string apellido, string cedula, Direccion direccion, string tel1,
            string tel2, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Direccion = direccion;
            Telefono1 = tel1;
            Telefono2 = tel2;
            Email = email;
        }

        public Propietario(int id, string nombre, string apellido, string cedula, Direccion direccion, string tel1,
            string tel2, string email, string contrasea)
        {
            PropietarioId = id;
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Direccion = direccion;
            Telefono1 = tel1;
            Telefono2 = tel2;
            Email = email;
        }

        public int PropietarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public Direccion Direccion { get; set; }
        public int DireccionId { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }

    }

}