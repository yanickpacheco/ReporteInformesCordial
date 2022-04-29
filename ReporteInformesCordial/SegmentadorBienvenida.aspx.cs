using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReporteInformesCordial
{
    public partial class SegmentadorBienvenida : System.Web.UI.Page
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

        private void Segmen(string desde, string hasta)
        {
            Clases.Segmentador seg = new Clases.Segmentador();

            var retorno_datos = seg.ListaDatos(desde, hasta);

            if ((retorno_datos.Count > 0) || (retorno_datos != null))
            {
                TableResult.DataSource = retorno_datos;
                TableResult.DataBind();
            }
            else
            {

            }



        }

        //protected void Button1_Click1(object sender, EventArgs e)
        //{
        //    {
        //        Segmen(txtFecha_Incio.Text, txtFecha_Fin.Text);
        //        btnExcel.Visible = true;
        //    }
        //}

        //Para exportar a excel
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
           
            Clases.Segmentador seg = new Clases.Segmentador();

            string inicio = Convert.ToDateTime(txtFecha_Incio.Text).ToShortDateString();

            string fin = Convert.ToDateTime(txtFecha_Fin.Text).ToShortDateString();

            var datos = seg.ListaDatos(inicio, fin);

            if (datos.Count > 0)
            {
                string filename = "SegmentadorBienvenida " + System.DateTime.Now.ToShortDateString() + "_.xls";
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


            Segmen(inicio, fin);
            btnExcel.Visible = true;

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