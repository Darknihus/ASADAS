using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UTIL;
using DAL;

namespace BLL
{
    public class LlenarComboBLL
    {
        LlenarComboDAL LlenarComboDAL = new LlenarComboDAL();

        public String LlenarAsadasBLL()
        {
            try
            {
                return LlenarComboDAL.LlenarAsadasDAL();
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public String LlenarCedulasBLL()
        {
            try
            {
                return LlenarComboDAL.LlenarCedulasDAL();
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public String LlenarMedidorBLL()
        {
            try
            {
                return LlenarComboDAL.LlenarMedidorDAL();
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }
    }
}
