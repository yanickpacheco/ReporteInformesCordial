using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReporteInformesCordial
{

    
    public partial class PanelControEjecutivo : System.Web.UI.Page
    {
        string CRM;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ContentPlaceHolder cph = new ContentPlaceHolder();

                string perfil_empresa = Session["Empresa"].ToString();
                lblEmpresa.Text = perfil_empresa;
               

            }
        }

        //protected void Buscar1_Click(object sender, EventArgs e)
        //{

        //    string inicio = Convert.ToDateTime(txtFecha_Incio1.Text).ToShortDateString();

        //    string fin = Convert.ToDateTime(txtFecha_Fin1.Text).ToShortDateString();
        //    switch (lblEmpresa.Text)
        //    {
        //        case "Enfermedades Bupa":
        //            CRM = "342";
        //            break;
        //        case "Examenes 80 BUPA ENEL":
        //            CRM = "444";
        //            break;
        //        case "Bupa":
        //            CRM = "342";
        //            break;
        //        case "Corona":
        //            CRM = "824";
        //            break;
        //        case "AP + AHORRO MASIVO":
        //            CRM = "441";
        //            break;
        //        case "AP AHORRO CON APERTURA":
        //            CRM = "679";
        //            break;
        //        case "CROSS AP + AHORRO":
        //            CRM = "680";
        //            break;
        //        case "APERTURA ENCUESTAS":
        //            CRM = "685";
        //            break;
        //    }

        //    Segmen(inicio, fin);
        //    btnExcel.Visible = true;

        //}

        //private void Segmen(string desde, string hasta)
        //{
        //    Clases.Consultas_Generales seg = new Clases.Consultas_Generales();

        //    var retorno_datos = seg.PanelControl (desde, hasta, CRM);

        //    if ((retorno_datos.Count > 0) || (retorno_datos != null))
        //    {
        //        TableResult.DataSource = retorno_datos;
        //        TableResult.DataBind();
        //    }
        //    else
        //    {

        //    }
        //}

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

            Clases.Consultas_Generales seg = new Clases.Consultas_Generales();

            string inicio = Convert.ToDateTime(txtFecha_Incio1.Text).ToShortDateString();

            string fin = Convert.ToDateTime(txtFecha_Fin1.Text).ToShortDateString();

            switch (lblEmpresa.Text)
            {
                case "Enfermedades Bupa":
                    CRM = "342";
                    break;
                case "Examenes 80 BUPA ENEL":
                    CRM = "444";
                    break;
                case "Bupa":
                    CRM = "342";
                    break;
                case "Corona":
                    CRM = "824";
                    break;
                case "AP + AHORRO MASIVO":
                    CRM = "441";
                    break;
                case "AP AHORRO CON APERTURA":
                    CRM = "679";
                    break;
                case "CROSS AP + AHORRO":
                    CRM = "680";
                    break;
                case "APERTURA ENCUESTAS":
                    CRM = "685";
                    break;
            }
        }
        //    var datos = seg.PanelControl (inicio, fin, CRM);

        //    if (datos.Count > 0)
        //    {
        //        string filename = "PanelControlEjecutivo_"  + System.DateTime.Now.ToShortDateString() + ".xls";
        //        System.IO.StringWriter tw = new System.IO.StringWriter();
        //        System.Web.UI.HtmlTextWriter hw = new System.Web.UI.HtmlTextWriter(tw);
        //        DataGrid dgGrid = new DataGrid();
        //        dgGrid.DataSource = datos;
        //        dgGrid.DataBind();

        //        //Get the HTML for the control.

        //        dgGrid.RenderControl(hw);
        //        //Write the HTML back to the browser.

        //        //Response.ContentType = application/vnd.ms-excel;

        //        Response.ContentType = "application/vnd.ms-excel";
        //        Response.AppendHeader("Content-Disposition", "attachment; filename=" + filename + "");
        //        this.EnableViewState = false;
        //        Response.Write(tw.ToString());
        //        Response.End();
        //    }
        //}

        //protected void enviar1_Click(object sender, EventArgs e)
        //{
        //    LinkButton obj = (LinkButton)(sender);

        //    string hola = obj.CommandArgument;

        //    Response.Redirect(hola);
        //    //Response.Write("<script> window.open('" + hola + "','_blank'); </scrip>");
        //    //Response.Write(hola);




        //}
    }
}