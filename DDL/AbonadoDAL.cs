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
        //Insertar Personas
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
                    db.AddInParameter(dbCommand, "_telefono", DbType.String, UTIL.UTIL.ObtenerValor(utilAb.sApellido1));
                    db.AddInParameter(dbCommand, "_direccion", DbType.String, UTIL.UTIL.ObtenerValor(utilAb.sApellido2));
                    db.AddInParameter(dbCommand, "asada_local", DbType.String, UTIL.UTIL.ObtenerValor(utilAb.sTelefono));
                    db.AddOutParameter(dbCommand, "@strMessage", DbType.String, 250);

                    db.ExecuteNonQuery(dbCommand, tranPersonas);

                    if ((db.GetParameterValue(dbCommand, "@strMessage").ToString().Length) > 0)
                        throw new Exception(db.GetParameterValue(dbCommand, "@strMessage").ToString());

                    if (op == 1)
                    {
                        InsertarFuncioDAL(utilF, utilU, tranPersonas, db);
                        tranPersonas.Commit();
                    }
                    else
                    {
                        InsertarUsuarioDALL(utilU, tranPersonas, db);
                        tranPersonas.Commit();
                    }
                }

                catch (Exception ex)
                {
                    tranPersonas.Rollback();
                    return ex.Message;
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return "true";
        }
}
