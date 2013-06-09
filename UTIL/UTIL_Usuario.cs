using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTIL
{
    public class UTIL_Usuario
    {
        /// Obtiene o estable el User del Usuario
        public string sUser { get; set; }

        /// Obtiene o estable el Password del Usuario
        public string sPassword { get; set; }

        /// Obtiene o estable el Tipo del Usuario
        public int iTipo { get; set; }

            
        //Constructor
        public UTIL_Usuario()
        {
            this.sUser = string.Empty;
            this.sPassword = string.Empty;
            this.iTipo = -1;
        }
    }
}
