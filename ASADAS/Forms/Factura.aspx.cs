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
        protected void Page_Load(object sender, EventArgs e)
        {
            //llenar ddlCedula
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            lblNombre.Text = BuscarBLL.BuscarAbonadoBLL(Convert.ToInt32(ddlCedula.SelectedItem));
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