using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReporteInformesCordial
{
    public partial class PanelDireccionar_Bupa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnBupa_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnExamenes_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Examenes 80 BUPA ENEL";
            Response.Redirect("PanelControEjecutivo.aspx");
        }

        protected void btnBupa1_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Enfermedades Bupa";
            Response.Redirect("PanelControEjecutivo.aspx");
        }
    }
}