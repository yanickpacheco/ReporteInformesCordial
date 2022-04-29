using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReporteInformesCordial
{
    public partial class PanelDireccionar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnClonCruzVerde_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "CruzVerde";
            Response.Redirect("InformeCalidadClon.aspx");
        }

        protected void btnBienvenidaCruzVerde_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "CruzVerde";
            Response.Redirect("Reportes.aspx");
        }

        protected void btnPlusCruzVerde_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "CruzVerde";
            Response.Redirect("InformeCalidadPlus.aspx");
        }
    }
}