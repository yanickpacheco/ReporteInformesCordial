using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ReporteInformesCordial.Clases
{
    public class Consultas_Generales
    {


		public List<Segmentador> Segmentador(string desde, string hasta, string CRM)
		{
			List<Segmentador> datos = new List<Segmentador>();
			string connString = ConfigurationManager.ConnectionStrings["global"].ConnectionString;
			SqlConnection conn = null;
			SqlDataReader rdr = null;
			try
			{
				conn = new SqlConnection(connString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("Reporteria.Segmentador_Web", conn);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(new SqlParameter("@desde", desde));
				cmd.Parameters.Add(new SqlParameter("@hasta", hasta));
                cmd.Parameters.Add(new SqlParameter("@crm", CRM));
                rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{
					Segmentador i = new Segmentador();
					i.Grabacion = rdr["GRABACION"].ToString();
					i.Fecha_venta = Convert.ToDateTime(rdr["FECHA_VENTA"].ToString());
					i.Ejecutivo = rdr["EJECUTIVO"].ToString();
					i.Rut_venta = rdr["RUT_VENTA"].ToString();
					i.Nombre = rdr["NOMBRE"].ToString();
					i.Paterno = rdr["PATERNO"].ToString();
					i.Materno = rdr["MATERNO"].ToString();
					i.Direcc_venta = rdr["DIRECCION_VENTA"].ToString();
					i.Comuna = rdr["COMUNA"].ToString();
					i.Estado_cal_grab = rdr["ESTADO_CALIDAD_GRABACION"].ToString();
					i.Estado_cal_regrab = rdr["ESTADO_CALIDAD_REGRABACION"].ToString();
					i.Observacion = rdr["OBSERVACION"].ToString();
					i.Venta_informada = rdr["VENTA_INFORMADA"].ToString();
					i.Motivonn = rdr["MOTIVO_NN"].ToString();
					i.Primapesos = rdr["PRIMAPESOS"].ToString();
					i.Primauf = rdr["PRIMAUF"].ToString();
					i.Plan_contratado = rdr["PLAN_CONTRATADO"].ToString();
					i.Tipo_contrato = rdr["TIPO_CONTRATO"].ToString();
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


        public List<InformeCalidad> InformeCalidad(string desde, string hasta, string CRM)
        {
            List<InformeCalidad> datos = new List<InformeCalidad>();

            string connString = ConfigurationManager.ConnectionStrings["global"].ConnectionString;
            SqlConnection conn = null;
            SqlDataReader rdr = null;
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Reporteria.InformeCalidad_Web", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@desde", desde));
                cmd.Parameters.Add(new SqlParameter("@hasta", hasta));
                cmd.Parameters.Add(new SqlParameter("@crm", CRM));
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    InformeCalidad i = new InformeCalidad();
                    i.Id = Convert.ToInt32(rdr["ID"].ToString());
                    i.Usuario = rdr["USUARIO"].ToString();
                    i.Fono_contacto = rdr["FONO_CONTACTO"].ToString();
                    i.Fecha_V = Convert.ToDateTime(rdr["FECHA_VENTA"].ToString());
                    i.Rut_V = rdr["RUT_VENTA"].ToString() + "-" + rdr["DV_VENTA"].ToString();
                    i.Nombre_V = rdr["NOMBRE_VENTA"].ToString();
                    i.Fecha_nacimiento_V = Convert.ToDateTime(rdr["FECHA_NACIMIENTO_VENTA"].ToString());
                    i.Sexo_V = rdr["SEXO_VENTA"].ToString();
                    i.Mail_V = rdr["EMAIL_VENTA"].ToString();
                    i.Direccion_V = rdr["DIRECCION_VENTA"].ToString();
                    i.Comuna_V = rdr["COMUNA_VENTA"].ToString();
                    i.Ciudad_V = rdr["CIUDAD_VENTA"].ToString();
                    i.Tipo_Contrato = rdr["TIPO_CONTRATO"].ToString();
                    i.Plan_contratado = rdr["PLAN_CONTRATADO"].ToString();
                    i.Prima_UF = rdr["PRIMA_UF"].ToString();
                    i.Prima_Pesos = rdr["PRIMA_PESOS"].ToString();
                    i.Grabacion = rdr["GRABACION"].ToString();
                    i.Estado_calidad = rdr["ESTADO_CALIDAD"].ToString();
                    i.Observacion = rdr["OBSERVACION_CALIDAD"].ToString();
                    i.Analista_calidad = rdr["ANALISTA_CALIDAD"].ToString();
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


        public List<PanelControlEjecutivo> PanelControlEjecutivo(string desde, string hasta, string CRM)
        {
            List<PanelControlEjecutivo> datos = new List<PanelControlEjecutivo>();

            string connString = ConfigurationManager.ConnectionStrings["global"].ConnectionString;
            SqlConnection conn = null;
            SqlDataReader rdr = null;
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Reporteria.PanelControlEjecutivo_Web", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@desde", desde));
                cmd.Parameters.Add(new SqlParameter("@hasta", hasta));
                cmd.Parameters.Add(new SqlParameter("@crm", CRM));
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    PanelControlEjecutivo i = new PanelControlEjecutivo();
                    i.Ejecutivo = rdr["Ejecutivo"].ToString();
                    i.Venta = Convert.ToInt32(rdr["Venta"].ToString());
                    i.Adicionales = Convert.ToInt32(rdr["Adicionales"].ToString());
                    i.RecorridoIntento1 = Convert.ToInt32(rdr["Recorrido_Intento_1"].ToString());
                    i.Recorridos = Convert.ToInt32(rdr["Recorridos"].ToString());
                    i.Terminados = Convert.ToInt32(rdr["Terminados"].ToString());
                    i.Agendados = Convert.ToInt32(rdr["Agendados"].ToString());
                    i.Contactados = Convert.ToInt32(rdr["Contactados"].ToString());
                    i.NoContactados = Convert.ToInt32(rdr["No_Contactados"].ToString());
                    i.AloRut = Convert.ToInt32(rdr["Alo_Rut"].ToString());
                    i.Cargados = Convert.ToInt32(rdr["Cargados"].ToString());
                    i.Contactabilidad = rdr["Contactabilidad"].ToString();
                    i.Efectividad = rdr["Efectividad"].ToString();
                    i.AloRutSobreRecorridos = rdr["AloRut_Sobre_Recorridos"].ToString();
                    i.VentaSobreBase = rdr["Venta_Sobre_Base"].ToString();
                    i.VentaSobreRecorridos = rdr["Venta_Sobre_Recorridos"].ToString();
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