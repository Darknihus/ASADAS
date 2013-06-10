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
    public class LlenarComboDAL
    {
        DataSet ds = new DataSet();

        //----------------------------------------------------------------------------------------------
        //Llenar Combobox con 
        public DataTable LlenarAsadasDAL()
        {            
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("LlenarCombo_Asadas", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                postCommand.ExecuteNonQuery();
                NpgsqlDataAdapter dta = new NpgsqlDataAdapter(postCommand);
                dta.Fill(ds);
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
        //Llenar Combobox con 
        public DataTable LlenarCedulasDAL()
        {            
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("LlenarCombo_Cedulas", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                postCommand.ExecuteNonQuery();
                NpgsqlDataAdapter dta = new NpgsqlDataAdapter(postCommand);
                dta.Fill(ds);
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
        //Llenar Combobox con 
        public DataTable LlenarMedidorDAL()
        {
            ConnectionBD stringconn = new ConnectionBD();
            NpgsqlConnection conn = new NpgsqlConnection(stringconn.Postgreconnection());
            NpgsqlCommand postCommand = new NpgsqlCommand("LlenarCombo_Medidor", conn);
            postCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                postCommand.ExecuteNonQuery();
                NpgsqlDataAdapter dta = new NpgsqlDataAdapter(postCommand);
                dta.Fill(ds);
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
    }
}
