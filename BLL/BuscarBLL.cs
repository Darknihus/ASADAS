using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UTIL;
using DAL;


namespace BLL
{
    public class BuscarBLL
    {
        BuscarDAL BuscarDAL = new BuscarDAL();
        UTIL_Abonado utilAb = new UTIL_Abonado();
        UTIL_Arreglo utilAr = new UTIL_Arreglo();
        UTIL_Lectura utilLe = new UTIL_Lectura();
        UTIL_Factura utilFa = new UTIL_Factura();
        UTIL_Material utilMa = new UTIL_Material();

        public String BuscarAbonadoBLL(int Cedula)
        {
            utilAb.iCedula = Cedula;

            try
            {
                return BuscarDAL.BuscarAbonadoDAL(utilAb);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public String BuscarArregloBLL(int Cedula)
        {
            utilAr.iCedula = Cedula;

            try
            {
                return BuscarDAL.BuscarArregloDAL(utilAr);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public String BuscarLecturaBLL(int medidor)
        {
            utilLe.iMedidor = medidor;

            try
            {
                return BuscarDAL.BuscarLecturaDAL(utilLe);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public String BuscarFacturaBLL(int cedula)
        {
            utilFa.iCedula = cedula;

            try
            {
                return BuscarDAL.BuscarFacturaDAL(utilFa);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public String BuscarMaterialesAsadaBLL(String asada)
        {
            utilMa.sAsada = asada;

            try
            {
                return BuscarDAL.BuscarMaterialesAsadaDAL(utilMa);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public String BuscarStockMateriaBLL(String material)
        {
            utilMa.sNombre = material;

            try
            {
                return BuscarDAL.BuscarStockMateriaDAL(utilMa);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

    }
}
