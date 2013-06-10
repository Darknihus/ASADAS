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
    public class MedidorDAL
    {
        string messageOutput = "";

            //----------------------------------------------------------------------------------------------
            //Insertar Medidor
            public String AgregarMedidorDAL(UTIL_Medidor utilMe)
        {
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("insert_abonado", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
                {
                    postCommand.Parameters.Add("asada_own", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilMe.sAsada);
                    postCommand.Parameters.Add("_cedula", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilMe.iCedula);
                    postCommand.Parameters.Add("_id_medidor", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilMe.iIdMedidor);
                    postCommand.Parameters.Add("_proveedor", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilMe.sProveedor);
                    postCommand.Parameters.Add("_garantia", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilMe.sGarantia);
                    postCommand.Parameters.Add("_marca", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilMe.sMarca);
                    postCommand.Parameters.Add("_ubicacion_x", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilMe.sUbicacionX);
                    postCommand.Parameters.Add("_ubicacion_y", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilMe.sUbicacionY);
                    postCommand.Parameters.Add("_tipo", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilMe.iTipo);
                    postCommand.Parameters.Add("_estado", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilMe.iEstado);
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
            //Modificar Medidor
            public String ModificarMedidorDAL(UTIL_Medidor utilMe)
            {

                ConnectionBD stringconn = new ConnectionBD();
                NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
                NpgsqlCommand postCommand = new NpgsqlCommand("update_medidor", conn);
                postCommand.CommandType = CommandType.StoredProcedure;

                try
                {
                    postCommand.Parameters.Add("_id_medidor", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilMe.iIdMedidor);
                    postCommand.Parameters.Add("_estado", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilMe.iEstado);
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
