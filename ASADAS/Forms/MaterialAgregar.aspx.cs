using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class MaterialAgregar : System.Web.UI.Page
    {
        MaterialBLL MaterialBLL = new MaterialBLL();
        BuscarBLL BuscarBLL = new BuscarBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //cargar asadaddll
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            lblError.Text = MaterialBLL.AgregarMaterialBLL(ddlASADA.SelectedItem.ToString(), txtNombre.Text, Convert.ToInt32(txtStock.Text));
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}