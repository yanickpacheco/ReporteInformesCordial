using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace ReporteInformesCordial.Clases
{
    public class CurzVerdeResultanteClon
    {
        int id;
        string rut;
        string dv;
        string nombre_cli;
        DateTime fec_nac;
        string sexo_base;
        int edad_base;
        string direcc_base;
        string comuna_base;
        string ciudad_base;
        string region_base;
        string mail_base;
        string fono1;
        string fono2;
        string fono3;
        string fono4;
        string fono5;
        string fono6;
        string aniomes;
        string estado;
        string fecha_ges;
        string hora_ges;
        string fecha_venta;
        string hora_venta;
        int intentos;
        int llamada;
        string ejecutivo;
        string contacto;
        string no_contacto;
        string contacto_con;
        string flujo_contacto;
        string rut_venta;
        string dv_venta;
        string nombre_venta;
        string fec_nac_venta;
        string sexo_venta;
        string email_venta;
        string direc_venta;
        string comuna_venta;
        string ciudad_venta;
        string tipo_contrato;
        string plan_contratado;
        string prima_uf;
        string prima_pesos;
        string venta;
        string grabacion;

        public int Id { get => id; set => id = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Dv { get => dv; set => dv = value; }
        public string Nombre_cli { get => nombre_cli; set => nombre_cli = value; }
        public DateTime Fec_nac { get => fec_nac; set => fec_nac = value; }
        public string Sexo_base { get => sexo_base; set => sexo_base = value; }
        public int Edad_base { get => edad_base; set => edad_base = value; }
        public string Direcc_base { get => direcc_base; set => direcc_base = value; }
        public string Comuna_base { get => comuna_base; set => comuna_base = value; }
        public string Ciudad_base { get => ciudad_base; set => ciudad_base = value; }
        public string Region_base { get => region_base; set => region_base = value; }
        public string Mail_base { get => mail_base; set => mail_base = value; }
        public string Fono1 { get => fono1; set => fono1 = value; }
        public string Fono2 { get => fono2; set => fono2 = value; }
        public string Fono3 { get => fono3; set => fono3 = value; }
        public string Fono4 { get => fono4; set => fono4 = value; }
        public string Fono5 { get => fono5; set => fono5 = value; }
        public string Fono6 { get => fono6; set => fono6 = value; }
        public string Aniomes { get => aniomes; set => aniomes = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Fecha_ges { get => fecha_ges; set => fecha_ges = value; }
        public string Hora_ges { get => hora_ges; set => hora_ges = value; }
        public string Fecha_venta { get => fecha_venta; set => fecha_venta = value; }
        public string Hora_venta { get => hora_venta; set => hora_venta = value; }
        public int Intentos { get => intentos; set => intentos = value; }
        public int Llamada { get => llamada; set => llamada = value; }
        public string Ejecutivo { get => ejecutivo; set => ejecutivo = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string No_contacto { get => no_contacto; set => no_contacto = value; }
        public string Contacto_con { get => contacto_con; set => contacto_con = value; }
        public string Flujo_contacto { get => flujo_contacto; set => flujo_contacto = value; }
        public string Rut_venta { get => rut_venta; set => rut_venta = value; }
        public string Dv_venta { get => dv_venta; set => dv_venta = value; }
        public string Nombre_venta { get => nombre_venta; set => nombre_venta = value; }
        public string Fec_nac_venta { get => fec_nac_venta; set => fec_nac_venta = value; }
        public string Sexo_venta { get => sexo_venta; set => sexo_venta = value; }
        public string Email_venta { get => email_venta; set => email_venta = value; }
        public string Direc_venta { get => direc_venta; set => direc_venta = value; }
        public string Comuna_venta { get => comuna_venta; set => comuna_venta = value; }
        public string Ciudad_venta { get => ciudad_venta; set => ciudad_venta = value; }
        public string Tipo_contrato { get => tipo_contrato; set => tipo_contrato = value; }
        public string Plan_contratado { get => plan_contratado; set => plan_contratado = value; }
        public string Prima_uf { get => prima_uf; set => prima_uf = value; }
        public string Prima_pesos { get => prima_pesos; set => prima_pesos = value; }
        public string Venta { get => venta; set => venta = value; }
        public string Grabacion { get => grabacion; set => grabacion = value; }

        //Metodo listar
        public List<CurzVerdeResultanteClon> listaOrigenDatos(string desde1, string hasta1)
        {
            List<CurzVerdeResultanteClon> datos = new List<CurzVerdeResultanteClon>();
            string connString = ConfigurationManager.ConnectionStrings["clo"].ConnectionString;
            SqlConnection conn = null;
            SqlDataReader rdr = null;
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Reporteria.BaseResultante", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@desde", desde1));
                cmd.Parameters.Add(new SqlParameter("@hasta", hasta1));
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CurzVerdeResultanteClon i = new CurzVerdeResultanteClon();
                    i.Id = Convert.ToInt32(rdr["ID"].ToString());
                    i.Rut = rdr["RUT_BASE"].ToString();
                    i.Dv = rdr["DV_BASE"].ToString();
                    i.Nombre_cli = rdr["NOMBRE_CLIENTE"].ToString();
                    i.Fec_nac = Convert.ToDateTime(rdr["FECHA_NACIMIENTO"].ToString());
                    i.Sexo_base = rdr["SEXO_BASE"].ToString();
                    i.Edad_base = Convert.ToInt32(rdr["EDAD_BASE"].ToString());
                    i.Direcc_base = rdr["DIRECCION_BASE"].ToString();
                    i.Comuna_base = rdr["COMUNA_BASE"].ToString();
                    i.Ciudad_base = rdr["CIUDAD_BASE"].ToString();
                    i.Region_base = rdr["REGION_BASE"].ToString();
                    i.Mail_base = rdr["EMAIL_BASE"].ToString();
                    i.Fono1 = rdr["FONO1"].ToString();
                    i.Fono2 = rdr["FONO2"].ToString();
                    i.Fono3 = rdr["FONO3"].ToString();
                    i.Fono4 = rdr["FONO4"].ToString();
                    i.Fono5 = rdr["FONO5"].ToString();
                    i.Fono6 = rdr["FONO6"].ToString();
                    i.Aniomes = rdr["ANIOMES"].ToString();
                    i.Estado = rdr["ESTADO"].ToString();
                    i.Fecha_ges = rdr["FECHA_GESTION"].ToString();
                    i.Hora_ges = rdr["HORA_GESTION"].ToString();
                    i.Fecha_venta = rdr["FECHA_VENTA"].ToString();
                    i.Hora_venta = rdr["HORA_VENTA"].ToString();
                    i.Intentos = Convert.ToInt32(rdr["INTENTOS"].ToString());
                    i.Llamada = Convert.ToInt32(rdr["LLAMADA"].ToString());
                    i.Ejecutivo = rdr["EJECUTIVO"].ToString();
                    i.Contacto = rdr["CONTACTO"].ToString();
                    i.No_contacto = rdr["NO_CONTACTO"].ToString();
                    i.Contacto_con = rdr["CONTACTO_CON"].ToString();
                    i.Flujo_contacto = rdr["FLUJO_CONTACTO"].ToString();
                    i.Rut_venta = rdr["RUT_VENTA"].ToString();
                    i.Dv_venta = rdr["DV_VENTA"].ToString();
                    i.Nombre_venta = rdr["NOMBRE_VENTA"].ToString();
                    i.Fec_nac_venta = rdr["FECHA_NACIMIENTO_VENTA"].ToString();
                    i.Sexo_venta = rdr["SEXO_VENTA"].ToString();
                    i.Email_venta = rdr["EMAIL_VENTA"].ToString();
                    i.Direc_venta = rdr["DIRECCION_VENTA"].ToString();
                    i.Comuna_venta = rdr["COMUNA_VENTA"].ToString();
                    i.Ciudad_venta = rdr["CIUDAD_VENTA"].ToString();
                    i.Tipo_contrato = rdr["TIPO_CONTRATO"].ToString();
                    i.Plan_contratado = rdr["PLAN_CONTRATADO"].ToString();
                    i.Prima_uf = rdr["PRIMA_UF"].ToString();
                    i.Prima_pesos = rdr["PRIMA_PESOS"].ToString();
                    i.Venta = rdr["VENTA"].ToString();
                    i.Grabacion = rdr["GRABACION"].ToString();
                    datos.Add(i);

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }

            return datos;
        }

        //ocupamos la clase de resultante de clon para preunic
        public List<CurzVerdeResultanteClon> listaOrigenDatosPU(string desde1, string hasta1)
        {
            List<CurzVerdeResultanteClon> datos = new List<CurzVerdeResultanteClon>();
            string connString = ConfigurationManager.ConnectionStrings["pre"].ConnectionString;
            SqlConnection conn = null;
            SqlDataReader rdr = null;
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Reporteria.BaseResultante", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@desde", desde1));
                cmd.Parameters.Add(new SqlParameter("@hasta", hasta1));
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CurzVerdeResultanteClon i = new CurzVerdeResultanteClon();
                    i.Id = Convert.ToInt32(rdr["ID"].ToString());
                    i.Rut = rdr["RUT_BASE"].ToString();
                    i.Dv = rdr["DV_BASE"].ToString();
                    i.Nombre_cli = rdr["NOMBRE_CLIENTE"].ToString();
                    i.Fec_nac = Convert.ToDateTime(rdr["FECHA_NACIMIENTO"].ToString());
                    i.Sexo_base = rdr["SEXO_BASE"].ToString();
                    i.Edad_base = Convert.ToInt32(rdr["EDAD_BASE"].ToString());
                    i.Direcc_base = rdr["DIRECCION_BASE"].ToString();
                    i.Comuna_base = rdr["COMUNA_BASE"].ToString();
                    i.Ciudad_base = rdr["CIUDAD_BASE"].ToString();
                    i.Region_base = rdr["REGION_BASE"].ToString();
                    i.Mail_base = rdr["EMAIL_BASE"].ToString();
                    i.Fono1 = rdr["FONO1"].ToString();
                    i.Fono2 = rdr["FONO2"].ToString();
                    i.Fono3 = rdr["FONO3"].ToString();
                    i.Fono4 = rdr["FONO4"].ToString();
                    i.Fono5 = rdr["FONO5"].ToString();
                    i.Fono6 = rdr["FONO6"].ToString();
                    i.Aniomes = rdr["ANIOMES"].ToString();
                    i.Estado = rdr["ESTADO"].ToString();
                    i.Fecha_ges = rdr["FECHA_GESTION"].ToString();
                    i.Hora_ges = rdr["HORA_GESTION"].ToString();
                    i.Fecha_venta = rdr["FECHA_VENTA"].ToString();
                    i.Hora_venta = rdr["HORA_VENTA"].ToString();
                    i.Intentos = Convert.ToInt32(rdr["INTENTOS"].ToString());
                    i.Llamada = Convert.ToInt32(rdr["LLAMADA"].ToString());
                    i.Ejecutivo = rdr["EJECUTIVO"].ToString();
                    i.Contacto = rdr["CONTACTO"].ToString();
                    i.No_contacto = rdr["NO_CONTACTO"].ToString();
                    i.Contacto_con = rdr["CONTACTO_CON"].ToString();
                    i.Flujo_contacto = rdr["FLUJO_CONTACTO"].ToString();
                    i.Rut_venta = rdr["RUT_VENTA"].ToString();
                    i.Dv_venta = rdr["DV_VENTA"].ToString();
                    i.Nombre_venta = rdr["NOMBRE_VENTA"].ToString();
                    i.Fec_nac_venta = rdr["FECHA_NACIMIENTO_VENTA"].ToString();
                    i.Sexo_venta = rdr["SEXO_VENTA"].ToString();
                    i.Email_venta = rdr["EMAIL_VENTA"].ToString();
                    i.Direc_venta = rdr["DIRECCION_VENTA"].ToString();
                    i.Comuna_venta = rdr["COMUNA_VENTA"].ToString();
                    i.Ciudad_venta = rdr["CIUDAD_VENTA"].ToString();
                    i.Tipo_contrato = rdr["TIPO_CONTRATO"].ToString();
                    i.Plan_contratado = rdr["PLAN_CONTRATADO"].ToString();
                    i.Prima_uf = rdr["PRIMA_UF"].ToString();
                    i.Prima_pesos = rdr["PRIMA_PESOS"].ToString();
                    i.Venta = rdr["VENTA"].ToString();
                    i.Grabacion = rdr["GRABACION"].ToString();
                    datos.Add(i);

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }

            return datos;
        }


        public List<CurzVerdeResultanteClon> listaOrigenDatosPlus(string desde1, string hasta1)
        {
            List<CurzVerdeResultanteClon> datos = new List<CurzVerdeResultanteClon>();
            string connString = ConfigurationManager.ConnectionStrings["plu"].ConnectionString;
            SqlConnection conn = null;
            SqlDataReader rdr = null;
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Reporteria.BaseResultante", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@desde", desde1));
                cmd.Parameters.Add(new SqlParameter("@hasta", hasta1));
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CurzVerdeResultanteClon i = new CurzVerdeResultanteClon();
                    i.Id = Convert.ToInt32(rdr["ID"].ToString());
                    i.Rut = rdr["RUT_BASE"].ToString();
                    i.Dv = rdr["DV_BASE"].ToString();
                    i.Nombre_cli = rdr["NOMBRE_CLIENTE"].ToString();
                    i.Fec_nac = Convert.ToDateTime(rdr["FECHA_NACIMIENTO"].ToString());
                    i.Sexo_base = rdr["SEXO_BASE"].ToString();
                    i.Edad_base = Convert.ToInt32(rdr["EDAD_BASE"].ToString());
                    i.Direcc_base = rdr["DIRECCION_BASE"].ToString();
                    i.Comuna_base = rdr["COMUNA_BASE"].ToString();
                    i.Ciudad_base = rdr["CIUDAD_BASE"].ToString();
                    i.Region_base = rdr["REGION_BASE"].ToString();
                    i.Mail_base = rdr["EMAIL_BASE"].ToString();
                    i.Fono1 = rdr["FONO1"].ToString();
                    i.Fono2 = rdr["FONO2"].ToString();
                    i.Fono3 = rdr["FONO3"].ToString();
                    i.Fono4 = rdr["FONO4"].ToString();
                    i.Fono5 = rdr["FONO5"].ToString();
                    i.Fono6 = rdr["FONO6"].ToString();
                    i.Aniomes = rdr["ANIOMES"].ToString();
                    i.Estado = rdr["ESTADO"].ToString();
                    i.Fecha_ges = rdr["FECHA_GESTION"].ToString();
                    i.Hora_ges = rdr["HORA_GESTION"].ToString();
                    i.Fecha_venta = rdr["FECHA_VENTA"].ToString();
                    i.Hora_venta = rdr["HORA_VENTA"].ToString();
                    i.Intentos = Convert.ToInt32(rdr["INTENTOS"].ToString());
                    i.Llamada = Convert.ToInt32(rdr["LLAMADA"].ToString());
                    i.Ejecutivo = rdr["EJECUTIVO"].ToString();
                    i.Contacto = rdr["CONTACTO"].ToString();
                    i.No_contacto = rdr["NO_CONTACTO"].ToString();
                    i.Contacto_con = rdr["CONTACTO_CON"].ToString();
                    i.Flujo_contacto = rdr["FLUJO_CONTACTO"].ToString();
                    i.Rut_venta = rdr["RUT_VENTA"].ToString();
                    i.Dv_venta = rdr["DV_VENTA"].ToString();
                    i.Nombre_venta = rdr["NOMBRE_VENTA"].ToString();
                    i.Fec_nac_venta = rdr["FECHA_NACIMIENTO_VENTA"].ToString();
                    i.Sexo_venta = rdr["SEXO_VENTA"].ToString();
                    i.Email_venta = rdr["EMAIL_VENTA"].ToString();
                    i.Direc_venta = rdr["DIRECCION_VENTA"].ToString();
                    i.Comuna_venta = rdr["COMUNA_VENTA"].ToString();
                    i.Ciudad_venta = rdr["CIUDAD_VENTA"].ToString();
                    i.Tipo_contrato = rdr["TIPO_CONTRATO"].ToString();
                    i.Plan_contratado = rdr["PLAN_CONTRATADO"].ToString();
                    i.Prima_uf = rdr["PRIMA_UF"].ToString();
                    i.Prima_pesos = rdr["PRIMA_PESOS"].ToString();
                    i.Venta = rdr["VENTA"].ToString();
                    i.Grabacion = rdr["GRABACION"].ToString();
                    datos.Add(i);

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }

            return datos;
        }


        public List<CurzVerdeResultanteClon> listaOrigenDatosOdonto(string desde1, string hasta1)
        {
            List<CurzVerdeResultanteClon> datos = new List<CurzVerdeResultanteClon>();
            string connString = ConfigurationManager.ConnectionStrings["odo"].ConnectionString;
            SqlConnection conn = null;
            SqlDataReader rdr = null;
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Reporteria.BaseResultante", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@desde", desde1));
                cmd.Parameters.Add(new SqlParameter("@hasta", hasta1));
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CurzVerdeResultanteClon i = new CurzVerdeResultanteClon();
                    i.Id = Convert.ToInt32(rdr["ID"].ToString());
                    i.Rut = rdr["RUT_BASE"].ToString();
                    i.Dv = rdr["DV_BASE"].ToString();
                    i.Nombre_cli = rdr["NOMBRE_CLIENTE"].ToString();
                    i.Fec_nac = Convert.ToDateTime(rdr["FECHA_NACIMIENTO"].ToString());
                    i.Sexo_base = rdr["SEXO_BASE"].ToString();
                    i.Edad_base = Convert.ToInt32(rdr["EDAD_BASE"].ToString());
                    i.Direcc_base = rdr["DIRECCION_BASE"].ToString();
                    i.Comuna_base = rdr["COMUNA_BASE"].ToString();
                    i.Ciudad_base = rdr["CIUDAD_BASE"].ToString();
                    i.Region_base = rdr["REGION_BASE"].ToString();
                    i.Mail_base = rdr["EMAIL_BASE"].ToString();
                    i.Fono1 = rdr["FONO1"].ToString();
                    i.Fono2 = rdr["FONO2"].ToString();
                    i.Fono3 = rdr["FONO3"].ToString();
                    i.Fono4 = rdr["FONO4"].ToString();
                    i.Fono5 = rdr["FONO5"].ToString();
                    i.Fono6 = rdr["FONO6"].ToString();
                    i.Aniomes = rdr["ANIOMES"].ToString();
                    i.Estado = rdr["ESTADO"].ToString();
                    i.Fecha_ges = rdr["FECHA_GESTION"].ToString();
                    i.Hora_ges = rdr["HORA_GESTION"].ToString();
                    i.Fecha_venta = rdr["FECHA_VENTA"].ToString();
                    i.Hora_venta = rdr["HORA_VENTA"].ToString();
                    i.Intentos = Convert.ToInt32(rdr["INTENTOS"].ToString());
                    i.Llamada = Convert.ToInt32(rdr["LLAMADA"].ToString());
                    i.Ejecutivo = rdr["EJECUTIVO"].ToString();
                    i.Contacto = rdr["CONTACTO"].ToString();
                    i.No_contacto = rdr["NO_CONTACTO"].ToString();
                    i.Contacto_con = rdr["CONTACTO_CON"].ToString();
                    i.Flujo_contacto = rdr["FLUJO_CONTACTO"].ToString();
                    i.Rut_venta = rdr["RUT_VENTA"].ToString();
                    i.Dv_venta = rdr["DV_VENTA"].ToString();
                    i.Nombre_venta = rdr["NOMBRE_VENTA"].ToString();
                    i.Fec_nac_venta = rdr["FECHA_NACIMIENTO_VENTA"].ToString();
                    i.Sexo_venta = rdr["SEXO_VENTA"].ToString();
                    i.Email_venta = rdr["EMAIL_VENTA"].ToString();
                    i.Direc_venta = rdr["DIRECCION_VENTA"].ToString();
                    i.Comuna_venta = rdr["COMUNA_VENTA"].ToString();
                    i.Ciudad_venta = rdr["CIUDAD_VENTA"].ToString();
                    i.Tipo_contrato = rdr["TIPO_CONTRATO"].ToString();
                    i.Plan_contratado = rdr["PLAN_CONTRATADO"].ToString();
                    i.Prima_uf = rdr["PRIMA_UF"].ToString();
                    i.Prima_pesos = rdr["PRIMA_PESOS"].ToString();
                    i.Venta = rdr["VENTA"].ToString();
                    i.Grabacion = rdr["GRABACION"].ToString();
                    datos.Add(i);

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }

            return datos;
        }

        public List<CurzVerdeResultanteClon> listaOrigenDatosRipley(string desde1, string hasta1)
        {
            List<CurzVerdeResultanteClon> datos = new List<CurzVerdeResultanteClon>();
            string connString = ConfigurationManager.ConnectionStrings["rip"].ConnectionString;
            SqlConnection conn = null;
            SqlDataReader rdr = null;
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Reporteria.BaseResultante", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@desde", desde1));
                cmd.Parameters.Add(new SqlParameter("@hasta", hasta1));
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CurzVerdeResultanteClon i = new CurzVerdeResultanteClon();
                    i.Id = Convert.ToInt32(rdr["ID"].ToString());
                    i.Rut = rdr["RUT_BASE"].ToString();
                    i.Dv = rdr["DV_BASE"].ToString();
                    i.Nombre_cli = rdr["NOMBRE_CLIENTE"].ToString();
                    i.Fec_nac = Convert.ToDateTime(rdr["FECHA_NACIMIENTO"].ToString());
                    i.Sexo_base = rdr["SEXO_BASE"].ToString();
                    i.Edad_base = Convert.ToInt32(rdr["EDAD_BASE"].ToString());
                    i.Direcc_base = rdr["DIRECCION_BASE"].ToString();
                    i.Comuna_base = rdr["COMUNA_BASE"].ToString();
                    i.Ciudad_base = rdr["CIUDAD_BASE"].ToString();
                    i.Region_base = rdr["REGION_BASE"].ToString();
                    i.Mail_base = rdr["EMAIL_BASE"].ToString();
                    i.Fono1 = rdr["FONO1"].ToString();
                    i.Fono2 = rdr["FONO2"].ToString();
                    i.Fono3 = rdr["FONO3"].ToString();
                    i.Fono4 = rdr["FONO4"].ToString();
                    i.Fono5 = rdr["FONO5"].ToString();
                    i.Fono6 = rdr["FONO6"].ToString();
                    i.Aniomes = rdr["ANIOMES"].ToString();
                    i.Estado = rdr["ESTADO"].ToString();
                    i.Fecha_ges = rdr["FECHA_GESTION"].ToString();
                    i.Hora_ges = rdr["HORA_GESTION"].ToString();
                    i.Fecha_venta = rdr["FECHA_VENTA"].ToString();
                    i.Hora_venta = rdr["HORA_VENTA"].ToString();
                    i.Intentos = Convert.ToInt32(rdr["INTENTOS"].ToString());
                    i.Llamada = Convert.ToInt32(rdr["LLAMADA"].ToString());
                    i.Ejecutivo = rdr["EJECUTIVO"].ToString();
                    i.Contacto = rdr["CONTACTO"].ToString();
                    i.No_contacto = rdr["NO_CONTACTO"].ToString();
                    i.Contacto_con = rdr["CONTACTO_CON"].ToString();
                    i.Flujo_contacto = rdr["FLUJO_CONTACTO"].ToString();
                    i.Rut_venta = rdr["RUT_VENTA"].ToString();
                    i.Dv_venta = rdr["DV_VENTA"].ToString();
                    i.Nombre_venta = rdr["NOMBRE_VENTA"].ToString();
                    i.Fec_nac_venta = rdr["FECHA_NACIMIENTO_VENTA"].ToString();
                    i.Sexo_venta = rdr["SEXO_VENTA"].ToString();
                    i.Email_venta = rdr["EMAIL_VENTA"].ToString();
                    i.Direc_venta = rdr["DIRECCION_VENTA"].ToString();
                    i.Comuna_venta = rdr["COMUNA_VENTA"].ToString();
                    i.Ciudad_venta = rdr["CIUDAD_VENTA"].ToString();
                    i.Tipo_contrato = rdr["TIPO_CONTRATO"].ToString();
                    i.Plan_contratado = rdr["PLAN_CONTRATADO"].ToString();
                    i.Prima_uf = rdr["PRIMA_UF"].ToString();
                    i.Prima_pesos = rdr["PRIMA_PESOS"].ToString();
                    i.Venta = rdr["VENTA"].ToString();
                    i.Grabacion = rdr["GRABACION"].ToString();
                    datos.Add(i);

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error", ex);
            }

            return datos;
        }
    }
}