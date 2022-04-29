using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReporteInformesCordial
{
    public partial class PanelDireccionar_Metilfe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSantaMaria_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Clinica Santa María";
            Response.Redirect("Segmentador.aspx");
        }        

    protected void btnClinicaRedSalud_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Clínica Red Salud";
            Response.Redirect("Segmentador.aspx");
        }

        protected void btnClinicaDavila_Click(object sender, EventArgs e)
        {            
            Session["Empresa"] = "Clínica Davila";
            Response.Redirect("Segmentador.aspx");            
        }

        protected void btnEnfermedadesGraves_Click(object sender, EventArgs e)
        {            
            Session["Empresa"] = "Enfermedades Graves";
            Response.Redirect("Segmentador.aspx");           
        }

        protected void btnCoberturaCovid_Click(object sender, EventArgs e)
        {            
            Session["Empresa"] = "Indisa Catastrofico Cobertura Covid";
            Response.Redirect("Segmentador.aspx");            
        }
    }
}