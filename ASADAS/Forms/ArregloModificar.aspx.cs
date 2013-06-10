using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;


namespace ASADAS.Forms
{
    public partial class ArregloModificar : System.Web.UI.Page
    {
        ArregloBLL ArregloBLL = new ArregloBLL();
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
            lblNombre.Text = BuscarBLL.BuscarAbonadoBLL(Convert.ToInt32(ddlCedula.SelectedItem)).Rows[0]["Nombre"].ToString();
            txtAbono.Text = BuscarBLL.BuscarArregloBLL(Convert.ToInt32(ddlCedula.SelectedItem)).Rows[0]["Abono"].ToString();
            txtDeuda.Text = BuscarBLL.BuscarArregloBLL(Convert.ToInt32(ddlCedula.SelectedItem)).Rows[0]["Monto"].ToString();
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            lblError.Text = ArregloBLL.ModificarArregloBLL(Convert.ToInt32(ddlCedula.SelectedItem), Convert.ToInt32(txtDeuda.Text), Convert.ToInt32(txtAbono.Text));
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

    }
}