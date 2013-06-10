using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class MaterialModificar : System.Web.UI.Page
    {
        MaterialBLL MaterialBLL = new MaterialBLL();
        BuscarBLL BuscarBLL = new BuscarBLL();
        LlenarComboBLL LlenarComboBLL = new LlenarComboBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlASADA.DataSource = LlenarComboBLL.LlenarMedidorBLL();
                ddlASADA.DataBind();
            }
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            ddlNombre.DataSource = BuscarBLL.BuscarMaterialesAsadaBLL(ddlASADA.SelectedItem.ToString());
            ddlNombre.DataBind(); 
        }

        protected void Buscar2_Click(object sender, EventArgs e)
        {
            txtStock.Text = BuscarBLL.BuscarStockMateriaBLL(ddlASADA.SelectedItem.ToString(), ddlNombre.SelectedItem.ToString());
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            lblError.Text = MaterialBLL.AgregarMaterialBLL(ddlASADA.SelectedItem.ToString(), ddlNombre.SelectedItem.ToString(), Convert.ToInt32(txtStock.Text));
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        
        
    }
}