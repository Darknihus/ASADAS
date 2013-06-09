using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UTIL;
using DAL;

namespace BLL
{
    public class FuenteBLL
    {
        FuenteDAL FuenteDAL = new FuenteDAL();
        UTIL_Fuente utilFu = new UTIL_Fuente();

        //----------------------------------------------------------------------------------------------
        //Agrega el registro de un Fuente
        public String AgregarFuenteBLL(String asada, String nombre, String ubicacionX, String ubicacionY)
        {
            utilFu.sAsada = asada;
            utilFu.sNombre = nombre;
            utilFu.sUbicacionX = ubicacionX;
            utilFu.sUbicacionY = ubicacionY;

            try
            {
                return FuenteDAL.AgregarFuenteDAL(utilFu);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        //----------------------------------------------------------------------------------------------
        //Elimina el registro de un Fuente
        public String EliminarFuenteBLL(string nombre)
        {
            utilFu.sNombre = nombre;

            try
            {
                return FuenteDAL.EliminarFuenteDAL(utilFu);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }
    }
}
