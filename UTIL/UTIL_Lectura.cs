using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTIL
{
    public class UTIL_Lectura
    {
        /// Obtiene o estable la fecha de la Lectura
        public DateTime dFecha { get; set; }

        /// Obtiene o estable la lectura de la Lectura
        public int iLectura { get; set; }

        /// Obtiene o estable El medidor de la Lectura
        public int iMedidor { get; set; }

            
        //Constructor
        public UTIL_Lectura()
        {
            this.dFecha = DateTime.Now;
            this.iLectura = -1;
            this.iMedidor = -1;
        }
    }
}
