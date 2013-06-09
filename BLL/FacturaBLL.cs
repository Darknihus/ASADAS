using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UTIL;
using DAL;

namespace BLL
{
    public class FacturaBLL
    {
        FacturaDAL FacturaDAL = new FacturaDAL();
        UTIL_Factura utilFa = new UTIL_Factura();

        //----------------------------------------------------------------------------------------------
        //Elimina el registro de un Factura
        public String CobrarFacturaBLL(int cedula)
        {
            utilFa.iCedula = cedula;

            try
            {
                return FacturaDAL.CobrarFacturaDAL(utilFa);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }
    }
}
