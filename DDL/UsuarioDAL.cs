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
    public class UsuarioDAL
    {
        string messageOutput = "";

            //----------------------------------------------------------------------------------------------
            //Insertar Usuario
            public String AgregarUsuarioDAL(UTIL_Usuario utilUs)
        {
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("insert_users", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
                {
                    postCommand.Parameters.Add("_nick", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilUs.sUser);
                    postCommand.Parameters.Add("_contrasenia", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilUs.sPassword);
                    postCommand.Parameters.Add("_tipo", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilUs.iTipo);
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
            //Eliminar Usuario
            public String EliminarUsuarioDAL(UTIL_Usuario utilUs)
        {

            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("update_users", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                postCommand.Parameters.Add("_nick", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilUs.sUser);
                postCommand.Parameters.Add("_tipo", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilUs.iTipo);
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
            //Modificar Usuario
            public String ModificarUsuarioDAL(UTIL_Usuario utilUs)
            {

                ConnectionBD stringconn = new ConnectionBD();
                NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
                NpgsqlCommand postCommand = new NpgsqlCommand("update_users", conn);
                postCommand.CommandType = CommandType.StoredProcedure;

                try
                {
                    postCommand.Parameters.Add("_nick", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilUs.sUser);
                    postCommand.Parameters.Add("_tipo", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilUs.iTipo);
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
