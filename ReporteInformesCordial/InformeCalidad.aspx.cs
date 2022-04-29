using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReporteInformesCordial
{
    public partial class InformeCalidad : System.Web.UI.Page
    {
        string CRM;
        PanelDireccionar_Metlife pm = new PanelDireccionar_Metlife();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ContentPlaceHolder cph = new ContentPlaceHolder();

                string perfil_empresa = Session["Empresa"].ToString();
                lblEmpresa.Text = perfil_empresa;
                


            }
        }

        private void InfCalidad(string desde, string hasta, String CRM)
        {
            Clases.Consultas_Generales infCalidad = new Clases.Consultas_Generales();

            var retorno_datos = infCalidad.InformeCalidad(desde, hasta, CRM);

            if ((retorno_datos.Count > 0) || (retorno_datos != null))
            {
                TableResult.DataSource = retorno_datos;
                TableResult.DataBind();
            }
            else
            {

            }



        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
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
                    case "AP + AHORRO MASIVO(CENCOSUD)":
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

                InfCalidad(inicio, fin, CRM);
                btnExcel.Visible = true;
            }
        }

        //Para exportar a excel
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            //cruzVerde_Reportes cruzverde = new cruzVerde_Reportes();
            Clases.Consultas_Generales cg = new Clases.Consultas_Generales();
            


            string inicio = Convert.ToDateTime(txtFecha_Incio.Text).ToShortDateString();

            string fin = Convert.ToDateTime(txtFecha_Fin.Text).ToShortDateString();

            //string crm1 = CRM;
            //crm1 = "824";
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
            }

            var datos = cg.InformeCalidad(inicio, fin, CRM);
            //InfCalidad(inicio, fin, CRM);
            //var datos = InfCalidad(inicio, fin, CRM);

            if (datos.Count > 0)
            {
                string filename = "InformeCalidad " + System.DateTime.Now.ToShortDateString() + "_.xls";
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
            }

            //switch(bt)

            InfCalidad (inicio, fin, CRM);
            btnExcel.Visible = true;

        }

    }

   
}