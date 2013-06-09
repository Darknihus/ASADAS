using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTIL
{
    public class UTIL_Material
    {
        /// Obtiene o estable la ASADA de la Material
        public string sAsada { get; set; }

        /// Obtiene o estable el nombre de la Material
        public string sNombre { get; set; }

        /// Obtiene o estable el Stock de la Material
        public int iStock { get; set; }

            
        //Constructor
        public UTIL_Material()
        {
            this.sAsada = string.Empty;
            this.sNombre = string.Empty;
            this.iStock = -1;
        }
    }
}
