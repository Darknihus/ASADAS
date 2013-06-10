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
        public string Datos = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e,String datos)
        {
           //string strData = Request.Form["Data"].ToString();
           String [] strData2 = datos.Split(',');
           for (int i = 0; i < strData2.Length; i++) 
           {
               if (strData2[i] == "")
               {
                   i++;
               }
               else {
                   ArregloBLL.AgregarAsadaBLL(strData2[i], strData2[i + 1], strData2[i + 2]);
               }
           }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}