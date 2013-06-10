using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class ASADAAgregar : System.Web.UI.Page
    {
        AsadaBLL ArregloBLL = new AsadaBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
          // ArregloBLL.AgregarAsadaBLL( txtNombre.Text,  lblX,  ubicacionY);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}