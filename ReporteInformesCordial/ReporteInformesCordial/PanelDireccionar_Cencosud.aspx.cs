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

        protected void btnCrossVivirSeguro_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Cross Vivir Seguro Apertura";
            Response.Redirect("Segmentador.aspx");
        }

        protected void btnCrossAniversario_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Cross Aniversario";
            Response.Redirect("Segmentador.aspx");
        }

        protected void btnMasivoHogar_Click(object sender, EventArgs e)
        {

            Session["Empresa"] = "Masivo Hogar Catastrofico";
            Response.Redirect("Segmentador.aspx");
        }

        protected void btnMasivoMuerte_Click(object sender, EventArgs e)
        {

            Session["Empresa"] = "Masivo Muerte Accidental + Farmacia";
            Response.Redirect("Segmentador.aspx");
        }

        protected void btnApoyoTotal_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Apoyo Total Apertura Abierta";
            Response.Redirect("Segmentador.aspx");
        }

        protected void btnSaldoPositivo_Click(object sender, EventArgs e)
        {
            Session["Empresa"] = "Saldo Positivo";
            Response.Redirect("Segmentador.aspx");
        }

        protected void btnCrossTotalProteccion_Click(object sender, EventArgs e)
        {
                Session["Empresa"] = "Cross Total Proteccion";
                Response.Redirect("Segmentador.aspx");
        }

        protected void btnSeguroVidaGo_Click(object sender, EventArgs e)
        {
                Session["Empresa"] = "Seguro Vida Go";
                Response.Redirect("Segmentador.aspx");
        }

        protected void btnSeguroSuperCross_Click(object sender, EventArgs e)
        {
                Session["Empresa"] = "Seguro Super Cross";
                Response.Redirect("Segmentador.aspx");
        }

        protected void btnCrossAccidenteCubierto_Click(object sender, EventArgs e)
        {
                Session["Empresa"] = "Cross Accidente Cubierto";
                Response.Redirect("Segmentador.aspx");
        }
    }
}