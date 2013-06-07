using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AB3.Interfaz
{
    public partial class AgregarTarjeta : System.Web.UI.Page
    {
        string UserName
        {
            get { return ViewState["UserName"] as string; }
            set { ViewState["UserName"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserName = Request.QueryString["UserName"];
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

        try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                SqlCommand cmd = new SqlCommand("insertar_Tarjeta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_credit_card", SqlDbType.Int).Value = txtTarjeta.Text;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = UserName;
                cmd.Parameters.Add("@type_card", SqlDbType.Int).Value = txtTipo.Text;
                cmd.Parameters.Add("@fecha_expiracion", SqlDbType.Date).Value = txtFecha.Text;
                cmd.Parameters.Add("@saldo", SqlDbType.Int).Value = txtSaldo.Text;
                SqlParameter message = cmd.Parameters.Add("@strMessage", SqlDbType.VarChar, 200);
                message.Direction = ParameterDirection.Output;
                con.Open();
                cmd.ExecuteNonQuery();
                msgError.Text = cmd.Parameters["@strMessage"].Value.ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                msgError.Text = ex.Message;

                imgError.Visible = true;
            }
        }
    }
}