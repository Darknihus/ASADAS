using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class ConnectionBD
    {
        public string Postgreconnection()
        {
            return String.Format(
              "Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=ASADA;Pooling=false");
        }
    }
}