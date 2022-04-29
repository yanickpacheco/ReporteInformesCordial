using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ReporteInformesCordial.Clases
{
    public class GestionDiaria
    {
        string fecha;
		string nejecutivo;
        string venta;
        string adicionales;
        string recorrido_intento_1;
        string recorridos;
        string horas_habladas;
        string terminados;
        string agendados;
        string contactados;
        string no_contactados;
        string alo_rut;
        string cargados;
        string contactabilidad;
        string efectividad;
        string alorut_sobre_recorridos;
        string venta_sobre_recorridos;

        public string Fecha { get => fecha; set => fecha = value; }
		public string Nejecutivo { get => nejecutivo; set => nejecutivo = value; }
		public string Venta { get => venta; set => venta = value; }
        public string Adicionales { get => adicionales; set => adicionales = value; }
        public string Recorrido_intento_1 { get => recorrido_intento_1; set => recorrido_intento_1 = value; }
        public string Recorridos { get => recorridos; set => recorridos = value; }
        public string Horas_habladas { get => horas_habladas; set => horas_habladas = value; }
        public string Terminados { get => terminados; set => terminados = value; }
        public string Agendados { get => agendados; set => agendados = value; }
        public string Contactados { get => contactados; set => contactados = value; }
        public string No_contactados { get => no_contactados; set => no_contactados = value; }
        public string Alo_rut { get => alo_rut; set => alo_rut = value; }
        public string Cargados { get => cargados; set => cargados = value; }
        public string Contactabilidad { get => contactabilidad; set => contactabilidad = value; }
        public string Efectividad { get => efectividad; set => efectividad = value; }
        public string Alorut_sobre_recorridos { get => alorut_sobre_recorridos; set => alorut_sobre_recorridos = value; }       
        public string Venta_sobre_recorridos { get => venta_sobre_recorridos; set => venta_sobre_recorridos = value; }
        

        public List<GestionDiaria> GestionDiaria2(string desde, string hasta, string CRM)
		{
			List<GestionDiaria> datos = new List<GestionDiaria>();

			string connString = ConfigurationManager.ConnectionStrings["global"].ConnectionString;
			SqlConnection conn = null;
			SqlDataReader rdr = null;
			try
			{
				conn = new SqlConnection(connString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("Reporteria.GestionDiaria_Web", conn);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(new SqlParameter("@desde", desde));
				cmd.Parameters.Add(new SqlParameter("@hasta", hasta));
				cmd.Parameters.Add(new SqlParameter("@crm", CRM));
				rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{
					GestionDiaria i = new Clases.GestionDiaria();
					i.Fecha = rdr["FECHA"].ToString();
					i.Nejecutivo = rdr["N_EJECUTIVOS"].ToString();
					i.Venta = rdr["Venta"].ToString();
					i.Adicionales = rdr["Adicionales"].ToString();
					i.Recorrido_intento_1 = rdr["RECORRIDO_INTENTO_1"].ToString();
					i.Recorridos = rdr["RECORRIDOS"].ToString();
					i.Horas_habladas = rdr["HORAS_HABLADAS"].ToString();
					i.Terminados = rdr["TERMINADOS"].ToString();
					i.Agendados = rdr["AGENDADOS"].ToString();
					i.Contactados = rdr["CONTACTADOS"].ToString();
					i.No_contactados = rdr["NO_CONTACTADOS"].ToString();
					i.Alo_rut = rdr["Alo_Rut"].ToString();
					i.Cargados = rdr["CARGADOS"].ToString();
					i.Contactabilidad = rdr["Contactabilidad"].ToString();
					i.Efectividad = rdr["Efectividad"].ToString();
					i.Alorut_sobre_recorridos = rdr["AloRut_Sobre_Recorridos"].ToString();
					i.Venta_sobre_recorridos = rdr["Venta_Sobre_Recorridos"].ToString();
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