using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class AbonadoAgregar : System.Web.UI.Page
    {
        AbonadoBLL AbonadoBLL = new AbonadoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                //llenar ddlASADA
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
          AbonadoBLL.AgregarAbonadoBLL(txtNombre.Text, Convert.ToInt32(txtCedula.Text), Convert.ToInt32(txtTelefono.Text), txtDireccion.Text, ddlASADA.Text);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}