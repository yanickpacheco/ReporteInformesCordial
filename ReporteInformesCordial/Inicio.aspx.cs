using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ReporteInformesCordial
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Ingresar_Click(object sender, EventArgs e)
        {
            //string hola = txtPass.Value;
            //string yanick = txtUsuario.Value;
            string cx = System.Configuration.ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = cx;
            cn.Open();
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = System.Data.CommandType.StoredProcedure;
            cm.CommandText = "ValidaUsuario";
            cm.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cm.Parameters.AddWithValue("@contraseña", txtPass.Text);

            bool correcto = Convert.ToInt32(cm.ExecuteScalar()) > 0;
            {
                if (correcto)
                {

                    string Perfil = listarPerfil(txtUsuario.Text);

                    if (Perfil.Equals("Cencosud"))
                         {
                            Session["Empresa"] = "Cenco";
                            Response.Redirect("PanelDireccionar_Cencosud.aspx");
                        }
                    if (Perfil.Equals("Bupa"))
                        {
                        Session["Empresa"] = "Bupa";
                        Response.Redirect("PanelDireccionar_Bupa.aspx");
                        }
                    if (Perfil.Equals("Metlife"))
                        {
                        Session["Empresa"] = "Metlife";
                        Response.Redirect("PanelDireccionar_Metlife.aspx");
                        }
                    //else
                    if (Perfil.Equals("Corona"))
                        {
                        Session["Empresa"] = "Corona";
                        Response.Redirect("GestionesDiarias.aspx");
                        }
                    if (Perfil.Equals("Scotia"))
                    {
                        Session["Empresa"] = "Scotia";
                        Response.Redirect("GestionesDiarias.aspx");
                    }
                    else
                    //lblMensaje.Visible = true;
                    //lblMensaje.Text = "Usuario correcto";
                    //txtUsuario.Text = "";
                    if (txtUsuario.Text.Equals("cruzverde"))
                    {
                        Session["Empresa"] = "CruzVerde";
                        Response.Redirect("PanelDireccionar.aspx");
                    }
                    if (txtUsuario.Text.Equals("preunic"))
                    {
                        Session["Empresa"] = "Preunic";
                        Response.Redirect("InformeCalidadPreunic.aspx");
                    }
                    if (txtUsuario.Text.Equals("odonto"))
                    {
                        Session["Empresa"] = "Odonto";
                        Response.Redirect("InformeCalidadOdonto.aspx");
                    }
                    if (txtUsuario.Text.Equals("ripley"))
                    {
                        Session["Empresa"] = "Ripley";
                        Response.Redirect("InformeCalidadRipley.aspx");
                    }
                    if (txtUsuario.Text.Equals("corona"))
                    {
                        Session["Empresa"] = "Corona";
                        Response.Redirect("GestionesDiarias.aspx");
                    }

                }
                else
                {
                    //lblMensaje.Visible = true;
                    //lblMensaje.Text = "Usuario incorrecto";
                    //txtPass.Text = "";
                }

            }

        }

         string listarPerfil(string Usuario)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader rdr = null;
            string nombrePerfil = "";
            
                string cx = System.Configuration.ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
               
                cn.ConnectionString = cx;
                cn.Open();
                cm.Connection = cn;
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.CommandText = "obtienePerfilporUsuario";
                cm.Parameters.Add(new SqlParameter("@usuario", Usuario));
                rdr = cm.ExecuteReader();
           
            while (rdr.Read())
            {
                nombrePerfil = rdr["nombrePerfil"].ToString();
               
                
            }
            cn.Close();
            return nombrePerfil;

        }
    }
}