using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UTIL;
using DAL;


namespace BLL
{
    public class AbonadoBLL
    {
        AbonadoDAL AbonadoDAL = new AbonadoDAL();
        UTIL_Abonado utilAb = new UTIL_Abonado();

        //----------------------------------------------------------------------------------------------
        //Agrega el registro de un Abonado
        public String AgregarAbonadoBLL(String nombre, int cedula, int telefono, String direccion, String asada)
        {
            utilAb.sNombre = nombre;
            utilAb.iCedula = cedula;
            utilAb.iTelefono = telefono;
            utilAb.sDireccion = direccion;
            utilAb.sAsada = asada;

            try
            {
                return AbonadoDAL.AgregarAbonadoDAL(utilAb);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        //----------------------------------------------------------------------------------------------
        //Elimina el registro de un Abonado
        public String EliminarAbonadoBLL(int cedula)
        {
            utilAb.iCedula = cedula;


            try
            {
                return AbonadoDAL.EliminarAbonadoDAL(utilAb);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        //----------------------------------------------------------------------------------------------
        //Modifica el registro de un Abonado
        public String ModificarAbonadoBLL(String nombre, int telefono, String direccion)
        {
            utilAb.sNombre = nombre;
            utilAb.iTelefono = telefono;
            utilAb.sDireccion = direccion;

            try
            {
                return AbonadoDAL.ModificarAbonadoDAL(utilAb);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }
    }
}
