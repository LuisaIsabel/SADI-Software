using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SADI.Model;
using SADI.DataAccess;
using SADIsoft.DataAccess;

namespace SADI.Controller
{
    public class MantenimientoPropietarioControlador
    {
        public static Propietario BuscarPorId(int idPropietario)
        {
            try
            {
                Propietario pro = PropietarioDA.BuscarPorIdDB(idPropietario);

                return pro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string ActualizarPropietario(int id, string p1, string p2, string p3)
        {
            try
            {
                string s = PropietarioDA.ActualizarPropietarioDB(id, p1, p2, p3);
                    

                return s;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}