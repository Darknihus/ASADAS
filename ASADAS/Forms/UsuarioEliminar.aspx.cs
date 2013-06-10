using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class UsuarioEliminar : System.Web.UI.Page
    {
        UsuarioBLL UsuarioBLL = new UsuarioBLL();
        BuscarBLL BuscarBLL = new BuscarBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //llenar combos
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            lblError.Text = UsuarioBLL.EliminarUsuarioBLL(ddlNombre.SelectedItem.ToString());
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}