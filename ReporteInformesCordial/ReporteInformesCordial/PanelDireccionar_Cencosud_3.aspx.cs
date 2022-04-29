using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReporteInformesCordial
{
    public partial class PanelDireccionar_Cencosud_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnApAhorroe_Click(object sender, EventArgs e)
        {
            {
                Session["Empresa"] = "Ap + Ahorro Cross";
                Response.Redirect("Segmentador.aspx");
            }
        }

        protected void btnApMasivo_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Ap + Ahorro Masivo";
            Response.Redirect("Segmentador.aspx");
        }
    }
}