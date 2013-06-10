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
    public class AbonadoDAL
    {
        string messageOutput = "";

        //----------------------------------------------------------------------------------------------
        //Insertar Abonado
        public String AgregarAbonadoDAL(UTIL_Abonado utilAb)
        {
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("insert_abonado", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
                {
                    postCommand.Parameters.Add("_cedula", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilAb.iCedula);
                    postCommand.Parameters.Add("_nombre", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilAb.sNombre);
                    postCommand.Parameters.Add("_telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilAb.iTelefono);
                    postCommand.Parameters.Add("_direccion", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilAb.sDireccion);
                    postCommand.Parameters.Add("asada_local", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilAb.sAsada);
                    postCommand.Parameters.Add("_estado", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilAb.iEstado);
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
        //Eliminar Abonado
        public String EliminarAbonadoDAL(UTIL_Abonado utilAb)
        {

            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("Eliminar_Abonado", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                postCommand.Parameters.Add("_cedula", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilAb.iCedula);
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
        //Modificar Abonado
        public String ModificarAbonadoDAL(UTIL_Abonado utilAb)
        {

            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("update_abonados", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                postCommand.Parameters.Add("_cedula", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilAb.iCedula);
                postCommand.Parameters.Add("_nombre", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilAb.sNombre);
                postCommand.Parameters.Add("_telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilAb.iTelefono);
                postCommand.Parameters.Add("_direccion", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilAb.sDireccion);
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
