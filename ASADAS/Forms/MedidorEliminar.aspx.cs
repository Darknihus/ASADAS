using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class MedidorEliminar : System.Web.UI.Page
    {
        MedidorBLL MedidorBLL = new MedidorBLL();
        LlenarComboBLL LlenarComboBLL = new LlenarComboBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlMedidor.DataSource = LlenarComboBLL.LlenarMedidorBLL();
                ddlMedidor.DataBind();
            }
        }

        protected void btnEstado(int estado) 
        {
            lblError.Text = MedidorBLL.ModificarMedidorBLL(Convert.ToInt32(ddlMedidor.SelectedItem),estado);
        }

        protected void btnHabilitar_Click(object sender, EventArgs e)
        {
            btnEstado(1);  
        }

        protected void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            btnEstado(0);
        }
    }
}