using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReporteInformesCordial
{
    public partial class PanelDireccionar_Metlife : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnAhorroMasivo_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "AP + AHORRO MASIVO";
            Response.Redirect("InformeCalidad.aspx");
        }

        protected void btnAhorroConApertura_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "AP AHORRO CON APERTURA";
            Response.Redirect("InformeCalidad.aspx");
        }

        protected void btnCrossApAhorro_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "CROSS AP + AHORRO";
            Response.Redirect("InformeCalidad.aspx");
        }

        protected void btnAperturaEncuestas_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "APERTURA ENCUESTAS";
            Response.Redirect("InformeCalidad.aspx");
        }
    }
}