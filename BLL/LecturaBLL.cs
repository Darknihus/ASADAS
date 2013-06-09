using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UTIL;
using DAL;

namespace BLL
{
    public class LecturaBLL
    {
        LecturaDAL LecturaDAL = new LecturaDAL();
        UTIL_Lectura utilLe = new UTIL_Lectura();

        //----------------------------------------------------------------------------------------------
        //Agrega el registro de un Lectura
        public String AgregarLecturaBLL(DateTime fecha, int medidor, int lectura)
        {
            utilLe.dFecha = fecha;
            utilLe.iMedidor = medidor;
            utilLe.iLectura = lectura;

            try
            {
                return LecturaDAL.AgregarLecturaDAL(utilLe);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        //----------------------------------------------------------------------------------------------
        //Elimina el registro de un Lectura
        public String ModificarLecturaBLL(int medidor, int lectura)
        {
            utilLe.iMedidor = medidor;
            utilLe.iLectura = lectura;

            try
            {
                return LecturaDAL.ModificarLecturaDAL(utilLe);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }
    }
}
