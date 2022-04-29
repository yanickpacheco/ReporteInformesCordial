using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ReporteInformesCordial.Clases
{
    public class Segmentador
    {
		string grabacion;
		DateTime fecha_venta;
		string ejecutivo;
		string contacto;
		string no_contacto;
		string contacto_con;
		string flujo_contacto;
		string rut_venta;
		string nombre;
		string paterno;
		string materno;
		string direcc_venta;
		string comuna;
		string estado_cal_grab;
		string estado_cal_regrab;
		string observacion;
		string venta_informada;
		string motivonn;
		string primapesos;
		string primauf;
		string plan_contratado;
		string tipo_contrato;

		public string Grabacion { get => grabacion; set => grabacion = value; }
		public DateTime Fecha_venta { get => fecha_venta; set => fecha_venta = value; }
		public string Ejecutivo { get => ejecutivo; set => ejecutivo = value; }
		public string Contacto { get => contacto; set => contacto = value; }
		public string No_contacto { get => no_contacto; set => no_contacto = value; }
		public string Contacto_con { get => contacto_con; set => contacto_con = value; }
		public string Flujo_contacto { get => flujo_contacto; set => flujo_contacto = value; }
		public string Rut_venta { get => rut_venta; set => rut_venta = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Paterno { get => paterno; set => paterno = value; }
		public string Materno { get => materno; set => materno = value; }
		public string Direcc_venta { get => direcc_venta; set => direcc_venta = value; }
		public string Comuna { get => comuna; set => comuna = value; }
		public string Estado_cal_grab { get => estado_cal_grab; set => estado_cal_grab = value; }
		public string Estado_cal_regrab { get => estado_cal_regrab; set => estado_cal_regrab = value; }
		public string Observacion { get => observacion; set => observacion = value; }
		public string Venta_informada { get => venta_informada; set => venta_informada = value; }
		public string Motivonn { get => motivonn; set => motivonn = value; }
		public string Primapesos { get => primapesos; set => primapesos = value; }
		public string Primauf { get => primauf; set => primauf = value; }
		public string Plan_contratado { get => plan_contratado; set => plan_contratado = value; }
		public string Tipo_contrato { get => tipo_contrato; set => tipo_contrato = value; }


		public List<Segmentador> ListaDatos(string desde, string hasta)
		{
			List<Segmentador> datos = new List<Segmentador>();
			string connString = ConfigurationManager.ConnectionStrings["cnc"].ConnectionString;
			SqlConnection conn = null;
			SqlDataReader rdr = null;
			try
			{
				conn = new SqlConnection(connString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("Reporteria.Segmentador", conn);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(new SqlParameter("@desde", desde));
				cmd.Parameters.Add(new SqlParameter("@hasta", hasta));
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
					i.Venta_informada = rdr["VENTA_INFORMADA_BICE"].ToString();
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


		public List<Segmentador> ListaDatosClon(string desde, string hasta)
		{
			List<Segmentador> datos = new List<Segmentador>();
			string connString = ConfigurationManager.ConnectionStrings["clo"].ConnectionString;
			SqlConnection conn = null;
			SqlDataReader rdr = null;
			try
			{
				conn = new SqlConnection(connString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("Reporteria.Segmentador", conn);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(new SqlParameter("@desde", desde));
				cmd.Parameters.Add(new SqlParameter("@hasta", hasta));
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
					i.Venta_informada = rdr["VENTA_INFORMADA_BICE"].ToString();
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

		//para mostrar datos de Preunic
		public List<Segmentador> ListaDatosPU(string desde, string hasta)
		{
			List<Segmentador> datos = new List<Segmentador>();
			string connString = ConfigurationManager.ConnectionStrings["pre"].ConnectionString;
			SqlConnection conn = null;
			SqlDataReader rdr = null;
			try
			{
				conn = new SqlConnection(connString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("Reporteria.Segmentador", conn);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(new SqlParameter("@desde", desde));
				cmd.Parameters.Add(new SqlParameter("@hasta", hasta));
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
					i.Venta_informada = rdr["VENTA_INFORMADA_BICE"].ToString();
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


		public List<Segmentador> ListaDatosRipley(string desde, string hasta)
		{
			List<Segmentador> datos = new List<Segmentador>();
			string connString = ConfigurationManager.ConnectionStrings["rip"].ConnectionString;
			SqlConnection conn = null;
			SqlDataReader rdr = null;
			try
			{
				conn = new SqlConnection(connString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("Reporteria.Segmentador", conn);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(new SqlParameter("@desde", desde));
				cmd.Parameters.Add(new SqlParameter("@hasta", hasta));
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
					i.Venta_informada = rdr["VENTA_INFORMADA_BICE"].ToString();
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
	}	
}