using ReporteInformesCordial.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReporteInformesCordial
{
    public partial class GestionesDiarias : System.Web.UI.Page
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

        private void GestionDiaria(string desde, string hasta, String CRM)
        {
            Clases.Consultas_Generales gesDiaria = new Clases.Consultas_Generales();

            var retorno_datos = gesDiaria.GestionDiaria(desde, hasta, CRM);

            if ((retorno_datos.Count > 0) || (retorno_datos != null))
            {
                TableResult.DataSource = retorno_datos;
                TableResult.DataBind();
            }
            else
            {

            }



        }


        //Para exportar a excel
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            //cruzVerde_Reportes cruzverde = new cruzVerde_Reportes();
            //GestionDiaria gd new = GestionDiaria();
            Clases.GestionDiaria gd = new Clases.GestionDiaria();

            //GestionDiaria gd = new GestionDiaria();


            string inicio = Convert.ToDateTime(txtFecha_Incio.Text).ToShortDateString();

            string fin = Convert.ToDateTime(txtFecha_Fin.Text).ToShortDateString();

            switch (lblEmpresa.Text)
            {
                case "Vivir Seguro Apertura":
                    CRM = "398";
                    break;
                case "Cross Accidente Protegido":
                    CRM = "399";
                    break;
                case "Ap + Ahorro Cross":
                    CRM = "400";
                    break;
                case "Bupa":
                    CRM = "342";
                    break;
                case "Examenes 80 BUPA ENEL":
                    CRM = "444";
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
                case "Scotia":
                    CRM = "828";
                    break;
            }

            var datos = gd.GestionDiaria2(inicio, fin, CRM);

           // var datos = gd.GestionDiaria1(inicio, fin);

            if (datos.Count > 0)
            {
                string filename = "GestionDiaria " + System.DateTime.Now.ToShortDateString() + "_.xls";
                System.IO.StringWriter tw = new System.IO.StringWriter();
                System.Web.UI.HtmlTextWriter hw = new System.Web.UI.HtmlTextWriter(tw);
                
                DataGrid dgGrid = new DataGrid();
                dgGrid.DataSource = datos;
                dgGrid.DataBind();

                //Get the HTML for the control.

                dgGrid.RenderControl(hw);
                //Write the HTML back to the browser.

                //Response.ContentType = application/vnd.ms-excel;

                Response.ContentType = "application/vnd.ms-excel";
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + filename + "");
                this.EnableViewState = false;
                
                Response.Write(tw.ToString());
                Response.End();
            }
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {

            string inicio = Convert.ToDateTime(txtFecha_Incio.Text).ToShortDateString();

            string fin = Convert.ToDateTime(txtFecha_Fin.Text).ToShortDateString();

            switch (lblEmpresa.Text)
            {
                case "Vivir Seguro Apertura":
                    CRM = "398";
                    break;
                case "Cross Accidente Protegido":
                    CRM = "399";
                    break;
                case "Ap + Ahorro Cross":
                    CRM = "400";
                    break;
                case "Bupa":
                    CRM = "342";
                    break;
                case "Examenes 80 BUPA ENEL":
                    CRM = "444";
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
                case "Scotia":
                    CRM = "828";
                    break;
            }

            GestionDiaria(inicio, fin, CRM);
            btnExcel.Visible = true;

        }
    }
}