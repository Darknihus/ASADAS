using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UTIL;
using DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL UsuarioDAL = new UsuarioDAL();
        UTIL_Usuario utilUs = new UTIL_Usuario();

        //----------------------------------------------------------------------------------------------
        //Agrega el registro de un Usuario
        public String AgregarUsuarioBLL(String user, String password)
        {
            utilUs.sUser = user;
            utilUs.sPassword = password;
            utilUs.iTipo = 1;

            try
            {
                return UsuarioDAL.AgregarUsuarioDAL(utilUs);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        //----------------------------------------------------------------------------------------------
        //Elimina el registro de un Usuario
        public String EliminarUsuarioBLL(String user)
        {
            utilUs.sUser = user;
            utilUs.iTipo = 0;

            try
            {
                return UsuarioDAL.EliminarUsuarioDAL(utilUs);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }

        //----------------------------------------------------------------------------------------------
        //Modifica el registro de un Usuario
        public String ModificarUsuarioBLL(String user, int tipo)
        {
            utilUs.sUser = user;
            utilUs.iTipo = tipo;

            try
            {
                return UsuarioDAL.ModificarUsuarioDAL(utilUs);
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw new Exception(ex.Message);
            }
        }
    }
}
