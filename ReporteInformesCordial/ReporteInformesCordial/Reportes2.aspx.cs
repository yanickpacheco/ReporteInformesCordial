using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReporteInformesCordial
{
    public partial class Reportes2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ContentPlaceHolder cph = new ContentPlaceHolder();

                string perfil_empresa = Session["Empresa"].ToString();
                switch (perfil_empresa)
                {
                    case "CruzVerde":
                        lblEmpresa.Text = "CruzVerde";
                        break;
                    default:
                        lblEmpresa.Text = "Por definir";
                        break;
                }
            }
        }

        protected void btnBuscar1_Click(object sender, EventArgs e)
        {

            string inicio1 = Convert.ToDateTime(txtFecha_Inicio1.Text).ToShortDateString();

            string fin1 = Convert.ToDateTime(txtFecha_Fin1.Text).ToShortDateString();


            Resultante(inicio1, fin1);
            btnImgExcel1.Visible = true;

        }

        private void Resultante(string desde1, string hasta1)
        {
            CruzVerde_ReportesResultante cv = new CruzVerde_ReportesResultante();

            var retorno_datos1 = cv.listaOrigenDatos(desde1, hasta1);

            if ((retorno_datos1.Count > 0) || (retorno_datos1 != null))
            {
                TableResult1.DataSource = retorno_datos1;
                TableResult1.DataBind();
            }
            else
            {

            }
        }

        protected void btnImgExcel1_Click(object sender, ImageClickEventArgs e)
        {
            CruzVerde_ReportesResultante cruzverde = new CruzVerde_ReportesResultante();

            string inicio1 = Convert.ToDateTime(txtFecha_Inicio1.Text).ToShortDateString();

            string fin1 = Convert.ToDateTime(txtFecha_Fin1.Text).ToShortDateString();

            var datos = cruzverde.listaOrigenDatos(inicio1, fin1);

            if (datos.Count > 0)
            {
                string filename = "Resultante " + System.DateTime.Now.ToShortDateString() + "_.xls";
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
    }
}