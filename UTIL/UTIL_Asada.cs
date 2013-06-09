using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTIL
{
    public class UTIL_Asada
    {
        /// Obtiene o estable el Nombre de la Asada
        public string sNombre { get; set; }

        /// Obtiene o estable la UbicacionX de la Asada
        public string sUbicacionX { get; set; }

        /// Obtiene o estable la UbicacionY de la Asada
        public string sUbicacionY { get; set; }

        /// Obtiene o estable El Estado de la Asada
        public int iEstado { get; set; }

            
        //Constructor
        public UTIL_Asada()
        {
            this.sNombre = string.Empty;
            this.sUbicacionX = string.Empty;
            this.sUbicacionY = string.Empty;
            this.iEstado = -1;
        }
    }
}
