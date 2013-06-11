using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class MedidorAgregar : System.Web.UI.Page
    {
        MedidorBLL MedidorBLL = new MedidorBLL();
        LlenarComboBLL LlenarComboBLL = new LlenarComboBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlASADA.DataSource = LlenarComboBLL.LlenarAsadasBLL();
                ddlASADA.DataBind();
                ddlCedula.DataSource = LlenarComboBLL.LlenarCedulasBLL();
                ddlCedula.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string datos = bd.Value;
            String[] strData = datos.Split(',');
            MedidorBLL.AgregarMedidorBLL(ddlASADA.SelectedItem.ToString(), Convert.ToInt32(ddlCedula.SelectedItem.ToString()), Convert.ToInt32(txtCodigo.Text), txtGarantia.Text, txtMarca.Text, Convert.ToInt32(txtTipo.Text), strData[0], strData[1]);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}