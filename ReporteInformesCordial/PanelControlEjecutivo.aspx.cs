using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReporteInformesCordial
{

    
    public partial class PanelControlEjecutivo : System.Web.UI.Page
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

        protected void Buscar1_Click(object sender, EventArgs e)
        {

            string inicio = Convert.ToDateTime(txtFecha_Incio1.Text).ToShortDateString();

            string fin = Convert.ToDateTime(txtFecha_Fin1.Text).ToShortDateString();
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
                case "Cross Vivir Seguro Apertura":
                    CRM = "419";
                    break;
                case "Bienvenida Cruz Verde":
                    CRM = "170";
                    break;
                case "Clon Cruz Verde":
                    CRM = "066";
                    break;
                case "Plus Cruz Verde":
                    CRM = "278";
                    break;
                case "Migracion Clon Cruz Verde":
                    CRM = "426";
                    break;
                case "Migracion Bienvenida Cruz Verde":
                    CRM = "427";
                    break;
                case "Clinica Cruz Verde":
                    CRM = "422";
                    break;
            }

            PanelControl(inicio, fin,CRM);
            btnExcel.Visible = true;

        }

        private void PanelControl(string desde, string hasta, string CRM)
        {
            Clases.Consultas_Generales pnc = new Clases.Consultas_Generales();

            var retorno_datos = pnc.PanelControlEjecutivo (desde, hasta, CRM);

            if ((retorno_datos.Count > 0) || (retorno_datos != null))
            {
                TableResult.DataSource = retorno_datos;
                TableResult.DataBind();
            }
            else
            {

            }
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

            Clases.Consultas_Generales pnc = new Clases.Consultas_Generales();

            string inicio = Convert.ToDateTime(txtFecha_Incio1.Text).ToShortDateString();

            string fin = Convert.ToDateTime(txtFecha_Fin1.Text).ToShortDateString();

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
                case "Cross Vivir Seguro Apertura":
                    CRM = "419";
                    break;
                case "Bienvenida Cruz Verde":
                    CRM = "170";
                    break;
                case "Clon Cruz Verde":
                    CRM = "066";
                    break;
                case "Plus Cruz Verde":
                    CRM = "278";
                    break;
                case "Migracion Clon Cruz Verde":
                    CRM = "426";
                    break;
                case "Migracion Bienvenida Cruz Verde":
                    CRM = "427";
                    break;
                case "Clinica Cruz Verde":
                    CRM = "422";
                    break;
            }

            var datos = pnc.PanelControlEjecutivo(inicio, fin, CRM);

            if (datos.Count > 0)
            {
                string filename = "PanelControlEjecutivo_" + CRM + " " + System.DateTime.Now.ToShortDateString() + "_.xls";
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

        protected void enviar_Click(object sender, EventArgs e)
        {
            LinkButton obj = (LinkButton)(sender);

            string hola = obj.CommandArgument;

            Response.Redirect(hola);
            //Response.Write("<script> window.open('" + hola + "','_blank'); </scrip>");
            //Response.Write(hola);




        }
    }
}