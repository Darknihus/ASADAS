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
    public class LecturaDAL
    {
        string messageOutput = "";

        //----------------------------------------------------------------------------------------------
        //Insertar Lectura
        public String AgregarLecturaDAL(UTIL_Lectura utilLe)
        {
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("insert_lectura", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                postCommand.Parameters.Add("_medidor", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilLe.iMedidor);
                postCommand.Parameters.Add("_fecha", NpgsqlTypes.NpgsqlDbType.Date).Value = UTIL.UTIL.ObtenerValor(utilLe.dFecha);
                postCommand.Parameters.Add("_cantidad", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilLe.iLectura);
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
        //Eliminar Lectura
        public String ModificarLecturaDAL(UTIL_Lectura utilLe)
        {

            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("update_lectura", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                postCommand.Parameters.Add("_medidor", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilLe.iMedidor);
                postCommand.Parameters.Add("_cantidad", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilLe.iLectura);
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