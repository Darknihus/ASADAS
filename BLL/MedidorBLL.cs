using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UTIL;
using DAL;

namespace BLL
{
    public class MedidorBLL
    {
        MedidorDAL MedidorDAL = new MedidorDAL();
        UTIL_Medidor utilMe = new UTIL_Medidor();

        //----------------------------------------------------------------------------------------------
        //Agrega el registro de un Medidor
        public String AgregarMedidorBLL(String asada, int cedula, int codigo, String garantia, String marca, int tipo, String ubicacionX,  String ubicacionY)
        {
            utilMe.sAsada = asada;
            utilMe.iCedula = cedula;
            utilMe.iIdMedidor = codigo;
            utilMe.sGarantia = garantia;
            utilMe.sMarca = marca;
            utilMe.iTipo = tipo;
            utilMe.sUbicacionX = ubicacionX;
            utilMe.sUbicacionY = ubicacionY;

            try
            {
                return MedidorDAL.AgregarMedidorDAL(utilMe);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        //----------------------------------------------------------------------------------------------
        //Modifica el registro de un Medidor
        public String ModificarMedidorBLL(int codigo, int estado)
        {
            utilMe.iIdMedidor = codigo;
            utilMe.iEstado = estado;

            try
            {
                return MedidorDAL.ModificarMedidorDAL(utilMe);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }
    }
}
