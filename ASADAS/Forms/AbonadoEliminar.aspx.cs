using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class AbonadoEliminar : System.Web.UI.Page
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
            //no sabemos que devuelve
            lblNombre.Text = BuscarBLL.BuscarAbonadoBLL(Convert.ToInt32(ddlCedula.Text)).Rows[0]["nombre"].ToString();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            lblError.Text = AbonadoBLL.EliminarAbonadoBLL(Convert.ToInt32(ddlCedula.Text));
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        

    }
}