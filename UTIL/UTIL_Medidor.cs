using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTIL
{
    public class UTIL_Medidor
    {
        /// Obtiene o estable la ID Medidor del Medidor
        public int iIdMedidor { get; set; }

        /// Obtiene o estable la ASADA del Medidor
        public string sAsada { get; set; }

        /// Obtiene o estable la Garantia del Medidor
        public string sGarantia { get; set; }

        /// Obtiene o estable la Marca del Medidor
        public string sMarca { get; set; }

        /// Obtiene o estable la UbicacionX del Medidor
        public string sUbicacionX { get; set; }

        /// Obtiene o estable la UbicacionX del Medidor
        public string sUbicacionY { get; set; }

        /// Obtiene o estable El Tipo del Medidor
        public int iTipo { get; set; }

        /// Obtiene o estable El Cedula del Medidor
        public int iCedula { get; set; }

        /// Obtiene o estable El Estado del Medidor
        public int iEstado { get; set; }

            
        //Constructor
        public UTIL_Medidor()
        {
            this.iIdMedidor = -1;
            this.sAsada = string.Empty;
            this.sGarantia = string.Empty;
            this.sMarca = string.Empty;
            this.sUbicacionX = string.Empty;
            this.sUbicacionY = string.Empty;
            this.iTipo = -1;
            this.iCedula = -1;
            this.iEstado = -1;
        }
    }
}
