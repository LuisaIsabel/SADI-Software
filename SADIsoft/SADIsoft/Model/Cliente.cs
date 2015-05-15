using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SADI.Model
{
    public class Cliente
    {
        public string Nombre;
        public string Apellido;
        public string Cedula;
        public string Direccion;
        public string Tel1;
        public string Tel2;
        public string Email;

        public Cliente(string nombre, string apellido, string cedula, string direccion, string tel1, string tel2, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Direccion = direccion;
            Tel1 = tel1;
            Tel2 = tel2;
            Email = email;
        }
    }
}
