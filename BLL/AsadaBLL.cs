using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UTIL;
using DAL;

namespace BLL
{
    public class AsadaBLL
    {
        AsadaDAL AsadaDAL = new AsadaDAL();
        UTIL_Asada utilAs = new UTIL_Asada();

        //----------------------------------------------------------------------------------------------
        //Agrega el registro de un Asada
        public String AgregarAsadaBLL(String nombre, String ubicacionX, String ubicacionY)
        {
            utilAs.sNombre = nombre;
            utilAs.sUbicacionX = ubicacionX;
            utilAs.sUbicacionY = ubicacionY;
            utilAs.iEstado = 1;

            try
            {
                return AsadaDAL.AgregarAsadaDAL(utilAs);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        //----------------------------------------------------------------------------------------------
        //Elimina el registro de un Asada
        public String EliminarAsadaBLL(String nombre)
        {
            utilAs.iEstado = 0;
            utilAs.sNombre = nombre;
            try
            {
                return AsadaDAL.EliminarAsadaDAL(utilAs);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }
    }
}
