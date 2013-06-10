using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ASADAS.Forms
{
    public partial class PRUEBAS_BUSCAR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BuscarBLL BuscarBLL = new BuscarBLL();
            GridView1.DataSource = BuscarBLL.BuscarAbonadoBLL(123);
            GridView1.DataBind();

        }
    }
}