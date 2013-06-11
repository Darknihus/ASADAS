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
    public class FacturaDAL
    {
        string messageOutput = "";
        DataSet ds = new DataSet();
        //----------------------------------------------------------------------------------------------
        //Insertar Factura
        public String CobrarFacturaDAL(UTIL_Factura utilFa)
        {
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("erase_factura", conn);
            postCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                postCommand.Parameters.Add("_cedula", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilFa.iCedula);
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
        public String TipoMedidorDALL(int medidor)
        {
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("Buscar_Tipo", conn);
            postCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                postCommand.Parameters.Add("_medidor", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(medidor);
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
        //Buscar Abonado por cedula
        public DataTable GetTarifaDALL()
        {
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("Buscar_Tarifa", conn);
            postCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                conn.Open();
                postCommand.ExecuteNonQuery();
                NpgsqlDataAdapter dta = new NpgsqlDataAdapter(postCommand);
                dta.Fill(ds);
                messageOutput = postCommand.Parameters["message"].Value.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            else return null;
        }
        //----------------------------------------------------------------------------------------------
        //Actualizar cobro factura
        public String GenerarFacturaCobroDAL(UTIL_Factura utilFa)
        {
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("Update_Cobro", conn);
            postCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                postCommand.Parameters.Add("_cobro", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilFa.iCedula);
                postCommand.Parameters.Add("_medidor", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilFa.iMedidor);
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