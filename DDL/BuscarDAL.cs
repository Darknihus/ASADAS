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
    public class BuscarDAL
    {
        string messageOutput = "";
        DataSet ds = new DataSet();

        //----------------------------------------------------------------------------------------------
        //Buscar Abonado por cedula
        public DataTable BuscarAbonadoDAL(UTIL_Abonado utilAb)
        {            
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("buscar_abonado", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                postCommand.Parameters.Add("_cedula", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilAb.iCedula);
                NpgsqlParameter message = postCommand.Parameters.Add("message", NpgsqlTypes.NpgsqlDbType.Text, 250);
                message.Direction = ParameterDirection.Output;


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
        //Buscar Arreglo por cedula
        public DataTable BuscarArregloDAL(UTIL_Arreglo utilAr)
        {
            DataSet ds = new DataSet();

            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("buscar_arreglo", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                postCommand.Parameters.Add("_cedula", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilAr.iCedula);
                NpgsqlParameter message = postCommand.Parameters.Add("message", NpgsqlTypes.NpgsqlDbType.Text, 250);
                message.Direction = ParameterDirection.Output;


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
        //Buscar Lectura por medidor
        public DataTable BuscarLecturaDAL(UTIL_Lectura utilLe)
        {
            DataSet ds = new DataSet();

            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("buscar_medidor", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                postCommand.Parameters.Add("_id_medidor", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilLe.iMedidor);
                NpgsqlParameter message = postCommand.Parameters.Add("message", NpgsqlTypes.NpgsqlDbType.Text, 250);
                message.Direction = ParameterDirection.Output;


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
        //Buscar Factura por cedula
        public DataTable BuscarFacturaDAL(UTIL_Factura utilFa)
        {
            DataSet ds = new DataSet();

            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("buscar_factura", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                postCommand.Parameters.Add("_cedula", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilFa.iCedula);
                NpgsqlParameter message = postCommand.Parameters.Add("message", NpgsqlTypes.NpgsqlDbType.Text, 250);
                message.Direction = ParameterDirection.Output;


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
        //Buscar Materiales por Asada
        public DataTable BuscarMaterialesAsadaDAL(UTIL_Material utilMa)
        {
            DataSet ds = new DataSet();

            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("buscar_materiales", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                postCommand.Parameters.Add("_asada", NpgsqlTypes.NpgsqlDbType.Integer).Value = UTIL.UTIL.ObtenerValor(utilMa.sAsada);
                NpgsqlParameter message = postCommand.Parameters.Add("message", NpgsqlTypes.NpgsqlDbType.Text, 250);
                message.Direction = ParameterDirection.Output;


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
        //Buscar Cantidad de materiales por Material
        public String BuscarStockMateriaDAL(UTIL_Material utilMa)
        {
            DataSet ds = new DataSet();

            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("buscar_stock", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                postCommand.Parameters.Add("_material", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilMa.sNombre);
                postCommand.Parameters.Add("_asada", NpgsqlTypes.NpgsqlDbType.Text).Value = UTIL.UTIL.ObtenerValor(utilMa.sAsada);
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
