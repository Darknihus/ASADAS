using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using BLL;

namespace ASADAS.Forms
{
    public partial class ASADAAgregar : System.Web.UI.Page
    {
        AsadaBLL AsadaBLL = new AsadaBLL();     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
            else {
            }
        }
        
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
           string datos = bd.Value;
           datos = datos.Replace(",", "");
           String [] strData = datos.Split('/');
           for (int i = 0; i < strData.Length; i++) 
           {
               if (strData[i].Equals("")) { i++; }
               else
               {
                   //Nombre, latitud, longitud
                   String[] strData2 = strData[i].Split('*');
                   AsadaBLL.AgregarAsadaBLL(strData2[0], strData2[1], strData2[2]);
               }
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}