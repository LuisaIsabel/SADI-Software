using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SADIsoft.DataAccess;
using System.Data.SqlClient;
using System.Data;
using SADI.Model;

namespace SADIsoft.DataAccess
{
    public class InmuebleDA
    {
        private static SqlConnection conn;
        private static SqlCommand com;

        
        //---------------------------------------------------
        // Inserta un Inmueble en la Base de Datos
        //---------------------------------------------------
        internal static void RegistrarInmuebleDB(Inmueble inm)
        {

            try
            {
                conn = Conexion.Conectar();
                com = new SqlCommand();
                com.Connection = conn;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "USP_Registrar_Inmueble";

                com.Parameters.Add("@PropietarioId", SqlDbType.Int).Value = inm.PropietarioId;
                com.Parameters.Add("@ProvinciaId", SqlDbType.Int).Value = inm.Direccion.Provincia;
                com.Parameters.Add("@MunicipioId", SqlDbType.Int).Value = inm.Direccion.Municipio;
                com.Parameters.Add("@SectorId", SqlDbType.Int).Value = inm.Direccion.Sector;
                com.Parameters.Add("@Calle", SqlDbType.VarChar).Value = inm.Direccion.Calle;
                com.Parameters.Add("@Numero", SqlDbType.VarChar).Value = inm.Direccion.Numero;
                com.Parameters.Add("@Tipo", SqlDbType.Bit).Value = inm.Tipo;
                com.Parameters.Add("@PrecioVenta", SqlDbType.Money).Value = inm.PrecioVenta;
                com.Parameters.Add("@PrecioAlquiler", SqlDbType.Money).Value = inm.PrecioAlquiler;
                com.Parameters.Add("@Depositos", SqlDbType.Int).Value = inm.Depositos;
                com.Parameters.Add("@Sotano", SqlDbType.Bit).Value = inm.Sotano;
                com.Parameters.Add("@Piscina", SqlDbType.Bit).Value = inm.Piscina;
                com.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = inm.Comentarios;
                com.Parameters.Add("@Marquesina", SqlDbType.Bit).Value = inm.Marquesina;
                com.Parameters.Add("@CapacidadMarquesina", SqlDbType.Int).Value = inm.Capacidad;
                com.Parameters.Add("@NumeroPlantas", SqlDbType.Int).Value = inm.Niveles;
                com.Parameters.Add("@TipoInmueble", SqlDbType.Bit).Value = inm.TipoInmueble;
                com.Parameters.Add("@Foto1", SqlDbType.VarChar).Value = inm.Foto1;
                com.Parameters.Add("@Foto2", SqlDbType.VarChar).Value = inm.Foto2;
                com.Parameters.Add("@Foto3", SqlDbType.VarChar).Value = inm.Foto3;
                com.Parameters.Add("@Foto4", SqlDbType.VarChar).Value = inm.Foto4;
                com.Parameters.Add("@Habitaciones", SqlDbType.Int).Value = inm.Habitaciones;
                com.Parameters.Add("@Banos", SqlDbType.Int).Value = inm.Banos;

                com.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}