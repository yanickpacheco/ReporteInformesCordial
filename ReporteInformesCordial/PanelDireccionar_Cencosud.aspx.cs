using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReporteInformesCordial
{
    public partial class PanelDireccionar_Cencosud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnVivirSeguro_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Vivir Seguro Apertura";
            Response.Redirect("Segmentador.aspx");
        }

        protected void btnCrossAccidente_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Cross Accidente Protegido";
            Response.Redirect("Segmentador.aspx");
        }

        protected void btnApAhorroe_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Ap + Ahorro Cross";
            Response.Redirect("Segmentador.aspx");
        }
    }
}