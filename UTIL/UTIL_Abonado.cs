using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTIL
{
    public class UTIL_Abonado
    {
        /// Obtiene o estable el nombre del Abonado
        public string sNombre { get; set; }

        /// Obtiene o estable El numero de cedula del Abonado
        public int iCedula { get; set; }

        /// Obtiene o estable El numero de direccion del Abonado
        public string sDireccion { get; set; }

        /// Obtiene o estable El numero de Telefono del Abonado
        public int iTelefono { get; set; }

        /// Obtiene o estable El numero de asada del Abonado
        public string sAsada { get; set; }

        /// Obtiene o estable El Estado de asada del Abonado
        public int iEstado { get; set; }

            
        //Constructor
        public UTIL_Abonado()
        {
            this.sNombre = string.Empty;
            this.iCedula = -1;
            this.sDireccion = string.Empty;
            this.iTelefono = -1;
            this.sAsada = string.Empty;
            this.iEstado = -1;
        }
    }
}
