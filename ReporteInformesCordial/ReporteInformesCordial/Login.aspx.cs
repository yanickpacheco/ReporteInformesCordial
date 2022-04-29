using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ReporteInformesCordial
{
    public partial class Login : System.Web.UI.Page
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
                    //lblMensaje.Visible = true;
                    //lblMensaje.Text = "Usuario correcto";
                    //txtUsuario.Text = "";
                    if (txtUsuario.Text.Equals("cruzverde"))
                    {
                        Session["Empresa"] = "CruzVerde";
                        Response.Redirect("PanelDireccionar.aspx");
                        
                    
                    }

                }
                else
                {
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "Usuario incorrecto";
                    txtPass.Text = "";
                }

            }

        }

        }


    }