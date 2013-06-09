using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.Common;
using UTIL;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace DAL
{
    public class BuscarDAL
    {
        //----------------------------------------------------------------------------------------------
        //Buscar Abonado por cedula
        public String BuscarAbonadoDAL(UTIL_Abonado utilAb) { return ""; }

        //----------------------------------------------------------------------------------------------
        //Buscar Arreglo por cedula
        public String BuscarArregloDAL(UTIL_Arreglo utilAr) { return ""; }

        //----------------------------------------------------------------------------------------------
        //Buscar Lectura por medidor
        public String BuscarLecturaDAL(UTIL_Lectura utilLe) { return ""; }

        //----------------------------------------------------------------------------------------------
        //Buscar Factura por cedula
        public String BuscarFacturaDAL(UTIL_Factura utilFa) { return ""; }

        //----------------------------------------------------------------------------------------------
        //Buscar Materiales por Asada
        public String BuscarMaterialesAsadaDAL(UTIL_Material utilMa) { return ""; }

        //----------------------------------------------------------------------------------------------
        //Buscar Cantidad de materiales por Material
        public String BuscarStockMateriaDAL(UTIL_Material utilMa) { return ""; }
    }
}
