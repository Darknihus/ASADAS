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
            lblNombre.Text = BuscarBLL.BuscarAbonadoBLL(Convert.ToInt32(ddlCedula.SelectedItem));
            txtAbono.Text = BuscarBLL.BuscarArregloBLL(Convert.ToInt32(ddlCedula.SelectedItem));
            txtDeuda.Text = BuscarBLL.BuscarArregloBLL(Convert.ToInt32(ddlCedula.SelectedItem));
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