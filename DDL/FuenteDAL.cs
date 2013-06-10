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
    public class FuenteDAL
    {
        string messageOutput = "";

            //----------------------------------------------------------------------------------------------
            //Insertar Fuente
        public String AgregarFuenteDAL(UTIL_Fuente utilFu)
        {
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("insert_fuentes", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                postCommand.Parameters.Add("_asada", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilFu.sAsada);
                postCommand.Parameters.Add("_nombre", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilFu.sNombre);
                postCommand.Parameters.Add("_ubicacion_x", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilFu.sUbicacionX);
                postCommand.Parameters.Add("_ubicacion_x", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilFu.sUbicacionY);
                postCommand.Parameters.Add("_estado", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilFu.iEstado);
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
            //Eliminar Fuente
        public String EliminarFuenteDAL(UTIL_Fuente utilFu)
        {

            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("update_fuentes", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                postCommand.Parameters.Add("_nombre", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilFu.sNombre);
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
