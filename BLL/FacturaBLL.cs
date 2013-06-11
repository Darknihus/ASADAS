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
        //----------------------------------------------------------------------------------------------
        //Genera el cobro de una Factura
        public String GenerarFacturaCobroBLL(int Lectura, int medidor)
        {
            string tipo = DeterminarTipoMedidorBLL(Convert.ToInt32(FacturaDAL.TipoMedidorDALL(medidor)));
            int cobro = 0;
            int comsu = 1;
            DataTable consumo = FacturaDAL.GetTarifaDALL();
            while (Lectura != 0)
            {
                if (Convert.ToInt32(consumo.Rows[comsu]["consumo"].ToString()) > Lectura)
                {
                    cobro = cobro + (Convert.ToInt32(consumo.Rows[comsu]["consumo"].ToString()) * Convert.ToInt32(consumo.Rows[0][tipo].ToString()));
                    Lectura = Lectura - Convert.ToInt32(consumo.Rows[comsu]["consumo"].ToString());
                    comsu++;
                }
                else
                {
                    cobro = cobro + Lectura * Convert.ToInt32(consumo.Rows[comsu][tipo].ToString());
                    Lectura = 0;
                }
            }
            utilFa.iCobro = cobro;
            utilFa.iMedidor = medidor;
            try
            {
                return FacturaDAL.GenerarFacturaCobroDAL(utilFa);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }
        //----------------------------------------------------------------------------------------------
        //Datermina el tipo del medidor
        public String DeterminarTipoMedidorBLL(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return "domiciliar";
                case 2:
                    return "empresarial";
                case 3:
                    return "preferencial";
                case 4:
                    return "gobierno";
                default:
                    return "error";
            }
        }
    }
}