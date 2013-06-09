using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UTIL;
using DAL;

namespace BLL
{
    public class ArregloBLL
    {
        ArregloDAL ArregloDAL = new ArregloDAL();
        UTIL_Arreglo utilAr = new UTIL_Arreglo();

        //----------------------------------------------------------------------------------------------
        //Agrega el registro de un Arreglo
        public String AgregarArregloBLL(int cedula, int monto, int abono)
        {
            utilAr.iCedula = cedula;
            utilAr.iMonto = monto;
            utilAr.iAbono = abono;

            try
            {
                return ArregloDAL.AgregarArregloDAL(utilAr);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        //----------------------------------------------------------------------------------------------
        //Elimina el registro de un Arreglo
        public String EliminarArregloBLL(int cedula)
        {
            utilAr.iCedula = cedula;

            try
            {
                return ArregloDAL.EliminarArregloDAL(utilAr);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        //----------------------------------------------------------------------------------------------
        //Modifica el registro de un Arreglo
        public String ModificarArregloBLL(int cedula, int monto, int abono)
        {
            utilAr.iCedula = cedula;
            utilAr.iMonto = monto;
            utilAr.iAbono = abono;

            try
            {
                return ArregloDAL.ModificarArregloDAL(utilAr);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }
    }
}
