using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class UsuarioModificar : System.Web.UI.Page
    {
        UsuarioBLL UsuarioBLL = new UsuarioBLL();
        BuscarBLL BuscarBLL = new BuscarBLL();
        LlenarComboBLL LlenarComboBLL = new LlenarComboBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               //ddlNombre.DataSource = LlenarComboBLL.LlenarUsuariosBLL();
                //ddlNombre.DataBind();

            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            lblError.Text = UsuarioBLL.ModificarUsuarioBLL(ddlNombre.SelectedItem.ToString(), Convert.ToInt32(ddlPermisos.SelectedValue.ToString()));
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}