using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class FuenteAgregar : System.Web.UI.Page
    {
        FuenteBLL FuenteBLL = new FuenteBLL();     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
        }
        
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
           string datos = bd.Value;
           String [] strData = datos.Split(',');
           FuenteBLL.AgregarFuenteBLL(ddlASADA.SelectedItem.ToString(), txtNombre.Text, strData[0], strData[1]);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}