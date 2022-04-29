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
                    case "Ap + Ahorro Masivo":
                        CRM = "441";
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
                    case "Cross Aniversario":
                        CRM = "437";
                        break;
                    case "Masivo Hogar Catastrofico":
                        CRM = "438";
                        break;
                    case "Masivo Muerte Accidental + Farmacia":
                        CRM = "439";
                        break;
                    case "Apoyo Total Apertura Abierta":
                        CRM = "477";
                        break;
                    case "Saldo Positivo":
                        CRM = "478";
                        break;
                    case "Clinica Santa María":
                        CRM = "368";
                        break;
                    case "Clínica Red Salud":
                        CRM = "420";
                        break;
                    case "Clínica Davila":
                        CRM = "430";
                        break;
                    case "Enfermedades Graves":
                        CRM = "487";
                        break;
                    case "Indisa Catastrofico Cobertura Covid":
                        CRM = "495";
                        break;
                    case "Cross Total Proteccion":
                        CRM = "490";
                        break;
                    case "Seguro Vida Go":
                        CRM = "499";
                        break;
                    case "Seguro Super Cross":
                        CRM = "503";
                        break;
                    case "Cross Accidente Cubierto":
                        CRM = "504";
                        break;
                }

                InfCalidad(inicio, fin, CRM);
                btnExcel.Visible = true;
            }
        }

        //Para exportar a excel
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            cruzVerde_Reportes cruzverde = new cruzVerde_Reportes();

            string inicio = Convert.ToDateTime(txtFecha_Incio.Text).ToShortDateString();

            string fin = Convert.ToDateTime(txtFecha_Fin.Text).ToShortDateString();

            var datos = cruzverde.ListarOrigenRipley(inicio, fin);

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
                case "Ap + Ahorro Masivo":
                    CRM = "441";
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
                case "Cross Aniversario":
                    CRM = "437";
                    break;
                case "Masivo Hogar Catastrofico":
                    CRM = "438";
                    break;
                case "Masivo Muerte Accidental + Farmacia":
                    CRM = "439";
                    break;
                case "Apoyo Total Apertura Abierta":
                    CRM = "477";
                    break;
                case "Saldo Positivo":
                    CRM = "478";
                    break;
                case "Clinica Santa María":
                    CRM = "368";
                    break;
                case "Clínica Red Salud":
                    CRM = "420";
                    break;
                case "Clínica Davila":
                    CRM = "430";
                    break;
                case "Enfermedades Graves":
                    CRM = "487";
                    break;
                case "Indisa Catastrofico Cobertura Covid":
                    CRM = "495";
                    break;
                case "Cross Total Proteccion":
                    CRM = "490";
                    break;
                case "Seguro Vida Go":
                    CRM = "499";
                    break;
                case "Seguro Super Cross":
                    CRM = "503";
                    break;
                case "Cross Accidente Cubierto":
                    CRM = "504";
                    break;
            }

            InfCalidad (inicio, fin, CRM);
            btnExcel.Visible = true;

        }

    }

   
}