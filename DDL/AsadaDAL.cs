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
    public class AsadaDAL
    {
        string messageOutput = "";

            //----------------------------------------------------------------------------------------------
            //Insertar Asada
            public String AgregarAsadaDAL(UTIL_Asada utilAs)
        {
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("insert_asada", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
                {
                    postCommand.Parameters.Add("_nombre", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilAs.sNombre);
                    postCommand.Parameters.Add("_ubicacion_x", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilAs.sUbicacionX);
                    postCommand.Parameters.Add("_ubicacion_y", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilAs.sUbicacionY);
                    postCommand.Parameters.Add("_estado", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilAs.iEstado);
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
            //Eliminar Asada
            public String EliminarAsadaDAL(UTIL_Asada utilAs)
            {

                ConnectionBD stringconn = new ConnectionBD();
                NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
                NpgsqlCommand postCommand = new NpgsqlCommand("update_asada", conn);
                postCommand.CommandType = CommandType.StoredProcedure;

                try
                {
                    postCommand.Parameters.Add("_nombre", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilAs.sNombre);
                    postCommand.Parameters.Add("_estado", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilAs.iEstado);
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
