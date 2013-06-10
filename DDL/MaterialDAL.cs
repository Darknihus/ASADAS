using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.Common;
using UTIL;
using Npgsql;

namespace DAL
{
    public class MaterialDAL
    {
        string messageOutput = "";

            //----------------------------------------------------------------------------------------------
            //Insertar Material
            public String AgregarMaterialDAL(UTIL_Material utilMa)
        {
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("insert_materiales", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
                {
                    postCommand.Parameters.Add("_asadafk", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilMa.sAsada);
                    postCommand.Parameters.Add("_material", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilMa.sNombre);
                    postCommand.Parameters.Add("_stock", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilMa.iStock);
                    NpgsqlParameter message = postCommand.Parameters.Add("message", NpgsqlTypes.NpgsqlDbType.Text, 250);
                    message.Direction = ParameterDirection.Output;


                    conn.Open();
                    postCommand.ExecuteNonQuery();
                    messageOutput = postCommand.Parameters["message"].Value.ToString();
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

            return messageOutput;
        }

            //----------------------------------------------------------------------------------------------
            //Eliminar Material
            public String AumentarMaterialDAL(UTIL_Material utilMa)
            {

                ConnectionBD stringconn = new ConnectionBD();
                NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
                NpgsqlCommand postCommand = new NpgsqlCommand("update_materiales", conn);
                postCommand.CommandType = CommandType.StoredProcedure;

                try
                {
                    postCommand.Parameters.Add("_material", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilMa.sNombre);
                    postCommand.Parameters.Add("_stock", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilMa.iStock);
                    NpgsqlParameter message = postCommand.Parameters.Add("message", NpgsqlTypes.NpgsqlDbType.Text, 250);
                    message.Direction = ParameterDirection.Output;


                    conn.Open();
                    postCommand.ExecuteNonQuery();
                    messageOutput = postCommand.Parameters["message"].Value.ToString();
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

                return messageOutput;
            }
    }
}
