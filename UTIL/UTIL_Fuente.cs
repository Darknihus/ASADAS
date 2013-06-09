using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTIL
{
    public class UTIL_Fuente
    {
        /// Obtiene o estable la ASADA de la Fuente
        public string sAsada { get; set; }

        /// Obtiene o estable la Ubicacion de la Fuente
        public string sUbicacionX { get; set; }

        /// Obtiene o estable la Ubicacion de la Fuente
        public string sUbicacionY { get; set; }

        /// Obtiene o estable El nombre de la Fuente
        public string sNombre { get; set; }

        /// Obtiene o estable El estado de la Fuente
        public int iEstado { get; set; }

            
        //Constructor
        public UTIL_Fuente()
        {
            this.sAsada = string.Empty;
            this.sUbicacionX = string.Empty;
            this.sUbicacionY = string.Empty;
            this.sNombre = string.Empty;
            this.iEstado = -1;
        }
    }
}
