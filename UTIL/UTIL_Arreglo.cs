using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTIL
{
    public class UTIL_Arreglo
    {
        /// Obtiene o estable el cedula para el Arreglo
        public int iCedula { get; set; }

        /// Obtiene o estable El monto del Arreglo
        public int iMonto { get; set; }

        /// Obtiene o estable El abono del Arreglo
        public int iAbono { get; set; }

            
        //Constructor
        public UTIL_Arreglo()
        {
            this.iCedula = -1;
            this.iMonto = -1;
            this.iAbono = -1;
        }
    }
}
