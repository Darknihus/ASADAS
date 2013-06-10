using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class AbonadoModificar : System.Web.UI.Page
    {
        AbonadoBLL AbonadoBLL = new AbonadoBLL();
        BuscarBLL BuscarBLL = new BuscarBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //llenar ddlCedula
            }
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            //no se sabe como vienen estos datos
<<<<<<< HEAD
            txtNombre.Text = BuscarBLL.BuscarAbonadoBLL(Convert.ToInt32(ddlCedula.Text)); 
=======
            txtNombre.Text = BuscarBLL.BuscarAbonadoBLL(Convert.ToInt32(ddlCedula.SelectedItem)); 
>>>>>>> conexion
        }

        protected void btnModificar_Click1(object sender, EventArgs e)
        {
            lblError.Text = AbonadoBLL.ModificarAbonadoBLL(txtNombre.Text, Convert.ToInt32(ddlCedula.SelectedItem), txtDireccion.Text);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }


        
    }
}