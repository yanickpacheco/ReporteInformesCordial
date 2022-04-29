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
            Session["Empresa"] = "Clon Cruz Verde";
            Response.Redirect("Segmentador.aspx");
        }

        protected void btnBienvenidaCruzVerde_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Bienvenida Cruz Verde";
            Response.Redirect("Segmentador.aspx");
        }

        protected void btnPlusCruzVerde_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Plus Cruz Verde";
            Response.Redirect("Segmentador.aspx");
        }
        
        protected void btnMigracionClonCruzVerde_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Migracion Clon Cruz Verde";
            Response.Redirect("Segmentador.aspx");
        }

        protected void btnMigracionBienvenidaCruzVerde_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Migracion Bienvenida Cruz Verde";
            Response.Redirect("Segmentador.aspx");
        }

    }
}