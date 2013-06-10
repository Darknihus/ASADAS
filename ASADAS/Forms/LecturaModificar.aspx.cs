using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class LecturaModificar : System.Web.UI.Page
    {
        LecturaBLL LecturaBLL = new LecturaBLL();
        BuscarBLL BuscarBLL = new BuscarBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //llenar ddlMedidor
            }
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            
            txtLectura.Text = BuscarBLL.BuscarLecturaBLL(Convert.ToInt32(ddlMedidor.SelectedItem.ToString())).Rows[0]["Lectura"].ToString();
            lblFecha.Text = BuscarBLL.BuscarLecturaBLL(Convert.ToInt32(ddlMedidor.SelectedItem.ToString())).Rows[0]["Fecha"].ToString();
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            lblError.Text = LecturaBLL.ModificarLecturaBLL(Convert.ToInt32(ddlMedidor.SelectedItem), Convert.ToInt32(txtLectura.Text));
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

    }
}