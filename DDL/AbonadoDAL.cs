using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class AbonadoDAL
    {
        //----------------------------------------------------------------------------------------------
        //Modificar Personas
        public String ModificarPerfilDAL(UtilPersona utilP, UtilUsuario utilU)
        {
            Database db = DatabaseFactory.CreateDatabase("TallerAutomotriz");
            string sqlCommand = "dbo.proc_Persona_Modificar";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            using (DbConnection conn = db.CreateConnection())
            {
                conn.Open();
                DbTransaction tranPersonas = conn.BeginTransaction();

                try
                {
                    odComm = new OdbcCommand("editCountry", odbcConn);
                    odComm.CommandType = CommandType.StoredProcedure;
                    odComm.Parameters.Add(new OdbcParameter("$1", OdbcType.VarChar)).Value = newbucketId;
                    odComm.Parameters.Add(new OdbcParameter("$2", OdbcType.VarChar)).Value = ctryCode;
                    odbcConn.Open();
                    odComm.ExecuteNonQuery();
                    odbcConn.Close();

                    db.ExecuteNonQuery(dbCommand, tranPersonas);

                    if ((db.GetParameterValue(dbCommand, "@strMessage").ToString().Length) > 0)
                        throw new Exception(db.GetParameterValue(dbCommand, "@strMessage").ToString());


                    ModificarUsuarioDALL(utilU, tranPersonas, db);

                    tranPersonas.Commit();
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
}
