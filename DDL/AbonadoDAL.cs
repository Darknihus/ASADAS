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
    public class AbonadoDAL
    {
        //----------------------------------------------------------------------------------------------
        //Insertar Abonado
        public String AgregarAbonadoDAL(UTIL_Abonado utilAb)
        {
            Database db = DatabaseFactory.CreateDatabase("ASADA");
            string sqlCommand = "dbo.insert_abonado";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            using (DbConnection conn = db.CreateConnection())
            {
                conn.Open();
                DbTransaction tranPersonas = conn.BeginTransaction();

                try
                {
                    db.AddInParameter(dbCommand, "_cedula", DbType.Int16, UTIL.UTIL.ObtenerValor(utilAb.iCedula));
                    db.AddInParameter(dbCommand, "_nombre", DbType.String, UTIL.UTIL.ObtenerValor(utilAb.sNombre));
                    db.AddInParameter(dbCommand, "_telefono", DbType.String, UTIL.UTIL.ObtenerValor(utilAb.iTelefono));
                    db.AddInParameter(dbCommand, "_direccion", DbType.String, UTIL.UTIL.ObtenerValor(utilAb.sDireccion));
                    db.AddInParameter(dbCommand, "asada_local", DbType.String, UTIL.UTIL.ObtenerValor(utilAb.sAsada));
                    db.AddOutParameter(dbCommand, "message", DbType.String, 250);

                    db.ExecuteNonQuery(dbCommand, tranPersonas);
                }

                catch (Exception ex)
                {
                    return ex.Message;
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return db.GetParameterValue(dbCommand, "message").ToString();
        }

        //----------------------------------------------------------------------------------------------
        //Eliminar Abonado
        public String EliminarAbonadoDAL(UTIL_Abonado utilAb){ return ""; }
            
        //----------------------------------------------------------------------------------------------
        //Modificar Abonado
        public String ModificarAbonadoDAL(UTIL_Abonado utilAb) { return ""; }
    }
}
