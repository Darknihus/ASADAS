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

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
          AbonadoBLL.AgregarAbonadoBLL( "",  0, 0, "", "");
        }
    }
}