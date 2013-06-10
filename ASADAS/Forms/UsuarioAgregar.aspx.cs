using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class UsuarioAgregar : System.Web.UI.Page
    {
        UsuarioBLL UsuarioBLL = new UsuarioBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            lblError.Text = UsuarioBLL.AgregarUsuarioBLL(txtNombre.Text, txtContrasenia.Text);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}