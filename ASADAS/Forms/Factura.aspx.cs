using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class Factura : System.Web.UI.Page
    {
        FacturaBLL FacturaBLL = new FacturaBLL();
        BuscarBLL BuscarBLL = new BuscarBLL();
        LlenarComboBLL LlenarComboBLL = new LlenarComboBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlCedula.DataSource = LlenarComboBLL.LlenarCedulasBLL();
                ddlCedula.DataBind();
            }
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            lblFecha.Text = BuscarBLL.BuscarFacturaBLL(Convert.ToInt32(ddlCedula.SelectedItem)).Rows[0]["fecha"].ToString();
            lblCobro.Text = BuscarBLL.BuscarFacturaBLL(Convert.ToInt32(ddlCedula.SelectedItem)).Rows[0]["cobro"].ToString();
            lblConsumo.Text = BuscarBLL.BuscarFacturaBLL(Convert.ToInt32(ddlCedula.SelectedItem)).Rows[0]["Consumo"].ToString();
            lblMedidor.Text = BuscarBLL.BuscarFacturaBLL(Convert.ToInt32(ddlCedula.SelectedItem)).Rows[0]["medidor"].ToString();
            lblFactura.Text = BuscarBLL.BuscarFacturaBLL(Convert.ToInt32(ddlCedula.SelectedItem)).Rows[0]["id_factura"].ToString(); ;
            lblNombre.Text = BuscarBLL.BuscarAbonadoBLL(Convert.ToInt32(ddlCedula.SelectedItem)).Rows[0]["nombre"].ToString();
        }

        protected void btnCobrar_Click(object sender, EventArgs e)
        {
            lblError.Text = FacturaBLL.CobrarFacturaBLL(Convert.ToInt32(ddlCedula.SelectedItem));
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

    }
}