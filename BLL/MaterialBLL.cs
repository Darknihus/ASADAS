using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UTIL;
using DAL;

namespace BLL
{
    public class MaterialBLL
    {
        MaterialDAL MaterialDAL = new MaterialDAL();
        UTIL_Material utilMa = new UTIL_Material();

        //----------------------------------------------------------------------------------------------
        //Agrega el registro de un Materia
        public String AgregarMaterialBLL(String asada, String nombre, int stock)
        {
            utilMa.sNombre = asada;
            utilMa.sNombre = nombre;
            utilMa.iStock = stock;

            try
            {
                return MaterialDAL.AgregarMaterialDAL(utilMa);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        //----------------------------------------------------------------------------------------------
        //Modifica el registro de un Materia
        public String AumentarMaterialBLL(String nombre, int stock)
        {
            utilMa.sNombre = nombre;
            utilMa.iStock = stock;

            try
            {
                return MaterialDAL.EliminarMaterialDAL(utilMa);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }
    }
}
