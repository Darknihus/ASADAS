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

        public DataTable LlenarAsadasBLL()
        {
            try
            {
                return LlenarComboDAL.LlenarAsadasDAL();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable LlenarCedulasBLL()
        {
            try
            {
                return LlenarComboDAL.LlenarCedulasDAL();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable LlenarMedidorBLL()
        {
            try
            {
                return LlenarComboDAL.LlenarMedidorDAL();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
