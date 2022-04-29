using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.Data;

namespace ReporteInformesCordial
{
 
    public partial class Bienvenida1 : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Button1.Visible = false;
                ImageButton1.Visible = false;
                ImageButton2.Visible = false;
                Calendar3.Visible = false;
                Calendar4.Visible = false;
                btnExcel.Visible = false;
            }
            HtmlAnchor enl = enlace as HtmlAnchor;
            enl.ServerClick += new EventHandler(enl_ServerClick);
        }
        void enl_ServerClick(object sender, EventArgs e)
        {
            //TextBox3.Visible = true;
            //TextBox4.Visible = true;
            //Label3.Visible = true;
            //Label4.Visible = true;
            //Button1.Visible = true;
            //ImageButton1.Visible = true;
            //ImageButton2.Visible = true;

        }
            
            








    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar3.Visible == false)
            {
                Calendar3.Visible = true;
               
            }
            else
            {
                Calendar3.Visible = false;
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar4.Visible == false)
            {
                Calendar4.Visible = true;
            }
            else
            {
                Calendar4.Visible = false;
            }
        }

        protected void Calendar3_SelectionChanged(object sender, EventArgs e)
        {
            TextBox3.Text = Calendar3.SelectedDate.ToShortDateString();

        }

        protected void Calendar4_SelectionChanged(object sender, EventArgs e)
        {
            TextBox4.Text = Calendar4.SelectedDate.ToShortDateString();
        }



        private void InformeCalidad(string desde, string hasta)
        {
            //CruzVerde_Reportes cruzverde = new CruzVerde_ReportesResultante();
            cruzVerde_Reportes cruzverde = new cruzVerde_Reportes();
          
            var retorno_datos = cruzverde.ListarOrigen(desde, hasta);

            if ((retorno_datos.Count > 0) || (retorno_datos != null))
            {
                TableResult.DataSource = retorno_datos;
                TableResult.DataBind();
            }
            else 
            {
            
            }

            /*
            string cx = System.Configuration.ConfigurationManager.ConnectionStrings["cnc"].ConnectionString;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = cx;
            cn.Open();
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = System.Data.CommandType.StoredProcedure;
            cm.CommandText = "Reporteria.InformeCalidad";
            cm.Parameters.AddWithValue("@desde", desde);
            cm.Parameters.AddWithValue("@hasta", hasta);
            cm.ExecuteNonQuery();
            //System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.DataTable tbl = new System.Data.DataTable();
            SqlDataAdapter dA = new SqlDataAdapter(cm);
            dA.Fill(tbl);
            GridView1.DataSource=tbl;
            GridView1.DataBind();
            */



        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            {
                InformeCalidad(TextBox3.Text, TextBox4.Text);
                btnExcel.Visible = true;
            }
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            cruzVerde_Reportes cruzverde = new cruzVerde_Reportes();

            string inicio = Convert.ToDateTime(txtFecha_Incio.Text).ToShortDateString();

            string fin = Convert.ToDateTime(txtFecha_Fin.Text).ToShortDateString();

            var datos = cruzverde.ListarOrigen(inicio, fin);

            if (datos.Count > 0)
            {
                string filename = "InformeCalidad_ "+System.DateTime.Now.ToShortDateString() +"_.xls";
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

            
                InformeCalidad(inicio, fin);
                btnExcel.Visible = true;
            
        }

    }
}