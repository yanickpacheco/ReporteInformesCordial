using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Configuration;
using Microsoft.Reporting.WebForms;


namespace Informe201.Views.Home
{
    public partial class Informe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                string myUriString = WebConfigurationManager.AppSettings["rutaReporteCallsouth"];
                string informe = "/Pages/ReportViewer.aspx?%2f365+-+Deceso+Plan+Estandar+Lider%2fPanel+Control+Ejecutivo&rs:Command=Render";

                var myUri = new Uri(myUriString);
                var Parametros = new List<ReportParameter>();
                //ReportViewer1.ServerReport.ReportServerUrl = myUri;
                //ReportViewer1.ServerReport.ReportServerCredentials = new CustomReportCredentials("administrador", "Fehc94890411.,","ALCIA-BACKUP");
                //ReportViewer1.ServerReport.ReportPath = informe;

                //var reportParameterInfos = ReportViewer1.ServerReport.GetParameters().ToList();
                //var RutParameter = reportParameterInfos.Where(z => z.Name == "rut").FirstOrDefault();
                //if (RutParameter != null)
                //{
                //    var rut = "";
                //    if (Session["user"].ToString().Length > 8)
                //    {
                //        rut = Session["user"].ToString().Substring(0, Session["user"].ToString().Length - 2);
                //    }
                //    else
                //    {
                //        rut = Session["user"].ToString();
                //    }
                //    Parametros.Add(new ReportParameter("rut", rut, true));
               //     ReportViewer1.ServerReport.SetParameters(Parametros);

                }

               // ReportViewer1.Height = Int32.Parse(Request.QueryString["height"]);
              // ReportViewer1.Width = Int32.Parse(Request.QueryString["width"]);
               // ReportViewer1.ShowPrintButton = true;
               //ReportViewer1.ServerReport.Refresh();


                //String informe = Request.QueryString["informe"];
                //string myUri = WebConfigurationManager.AppSettings["rutaReporteCallsouth"];
                //ReportViewer1.ServerReport.ReportPath = myUri + informe;
                //var Parametros = new List<ReportParameter>();

                //var reportParameterInfos = ReportViewer1.ServerReport.GetParameters().ToList();
                //var RutParameter = reportParameterInfos.Where(z => z.Name == "rut").FirstOrDefault();
                //if (RutParameter != null)
                //{
                //    Parametros.Add(new ReportParameter("rut", "15450562-8", false));
                //    Parametros.Add(new ReportParameter("com_periodo", "201809", false));

                //}


                //ReportViewer1.Height = Int32.Parse(Request.QueryString["height"]);
                //ReportViewer1.Width = Int32.Parse(Request.QueryString["width"]);

                //if (Parametros.Count > 0)
                //{
                //    ReportViewer1.ServerReport.SetParameters(Parametros);
                //}

                //ReportViewer1.ServerReport.ReportServerCredentials = new CustomReportCredentials("intcallsouth", "Informe8080", "Mok.corp");
                //ReportViewer1.ServerReport.Refresh();
            }
        }
        //protected void Page_PreRender(object sender, System.EventArgs e)
        //{



        //    var reportParameterInfos = ReportViewer1.ServerReport.GetParameters();
        //    var parametrosLista = new List<parametros>();
        //    foreach (var item in reportParameterInfos)
        //    {
        //        var temp = new parametros();

        //        temp.valor = item.Values[0] ; 
        //        temp.nombre = item.Name;
        //        temp.rutaReporte = ReportViewer1.ServerReport.ReportPath.ToString();
        //        parametrosLista.Add(temp);                
        //    }

        //    Session["listaParametros"] = JsonConvert.SerializeObject(parametrosLista);





        //}
    }
    public class parametros
    {
        public string nombre { get; set; }
        public string valor { get; set; }
        public string rutaReporte { get; set; }
    }


    public class CustomReportCredentials : IReportServerCredentials
    {
        private string _UserName;
        private string _PassWord;
        private string _DomainName;

        public CustomReportCredentials(string UserName, string PassWord, string DomainName)
        {
            _UserName = UserName;
            _PassWord = PassWord;
            _DomainName = DomainName;
        }

        public System.Security.Principal.WindowsIdentity ImpersonationUser
        {
            get { return null; }
        }

        public ICredentials NetworkCredentials
        {
            get { return new NetworkCredential(_UserName, _PassWord, _DomainName); }
        }

        //ICredentials IReportServerCredentials.NetworkCredentials => throw new NotImplementedException();



        public bool GetFormsCredentials(out Cookie authCookie, out string userName, out string password, out string authority)
        {
            authCookie = null;
            userName = password = authority = null;
            return false;
        }
    
}

