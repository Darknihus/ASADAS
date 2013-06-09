using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTIL
{
    public class UTIL_Factura
    {
        /// Obtiene o estable la fecha de la Factura
        public DateTime dFecha { get; set; }

        /// Obtiene o estable la cedula de la Factura
        public int iCedula { get; set; }

        /// Obtiene o estable El medidor de la Factura
        public int iMedidor { get; set; }

        /// Obtiene o estable El cobro de la Factura
        public int iTelefono { get; set; }

        /// Obtiene o estable El IDFactura de la Factura
        public int iIdFactura { get; set; }

        /// Obtiene o estable El consumo de la Factura
        public int iConsumo { get; set; }

        /// Obtiene o estable El Estado de la Factura
        public int iEstado { get; set; }

            
        //Constructor
        public UTIL_Factura()
        {
            this.dFecha = DateTime.Now;
            this.iCedula = -1;
            this.iMedidor = -1;
            this.iTelefono = -1;
            this.iIdFactura = -1;
            this.iConsumo = -1;
            this.iEstado = -1;
        }
    }
}
