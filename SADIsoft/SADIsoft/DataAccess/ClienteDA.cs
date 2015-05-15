using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using SADI.Model;
using SADIsoft.DataAccess;

namespace SADI.DataAccess
{
    public class ClienteDA
    {
        private static SqlConnection conn;
        private static SqlCommand com;

        public static void RegistrarClienteDA(Cliente cliente)
        {
            try
            {
                conn = Conexion.Conectar();
                string query = string.Format(@"INSERT INTO Clientes(nombre,apellido,cedula,direccion,telefono1,telefono2,Email) 
                VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", cliente.Nombre, cliente.Apellido, cliente.Cedula, cliente.Direccion, cliente.Tel1, cliente.Tel2,cliente.Email);
                com = new SqlCommand(query, conn);

                int i = com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}