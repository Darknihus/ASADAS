using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTIL
{
    public class UTIL
    {

        public static object ObtenerValor(object objDato)
        {
            if (objDato.GetType() == typeof(Int32))
            {
                if ((int)objDato == -1)
                    return null;
            }

            if (objDato.GetType() == typeof(String))
            {
                if ((string)objDato == "")
                    return null;
            }

            if (objDato.GetType() == typeof(decimal))
            {
                if ((decimal)objDato == -1)
                    return null;

            }

            if (objDato.GetType() == typeof(Int64))
            {
                if ((System.Int64)objDato == -1)
                    return null;
            }

            return objDato;

        }
    }
}
