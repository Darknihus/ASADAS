using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class LecturaAgregar : System.Web.UI.Page
    {
        LecturaBLL LecturaBLL = new LecturaBLL();
        LlenarComboBLL LlenarComboBLL = new LlenarComboBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                ddlMedidor.DataSource = LlenarComboBLL.LlenarMedidorBLL();
                ddlMedidor.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            lblError.Text = LecturaBLL.AgregarLecturaBLL(Convert.ToDateTime(lblFecha.Text), Convert.ToInt32(ddlMedidor.SelectedItem), Convert.ToInt32(txtLectura.Text));
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}