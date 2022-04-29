using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReporteInformesCordial.Clases
{
    public class PanelControl
    {
        string ejecutivo;
        string horas_logueo;
        string primeraconexion;
        string ultimoregistro;
        string diferencia;
        string atrasado;
        string recorridos;
        string horas_habladas;
        string recorrido_intento_1;
        string terminados;
        string agendados;
        string contactados;
        string no_contactados;
        string alo_rut;
        string venta;
        string adicionales;
        string cargados;
        string tiempopostview;
        string descanso;

        public string Ejecutivo { get => ejecutivo; set => ejecutivo = value; }
        public string Horas_logueo { get => horas_logueo; set => horas_logueo = value; }
        public string Primeraconexion { get => primeraconexion; set => primeraconexion = value; }
        public string Ultimoregistro { get => ultimoregistro; set => ultimoregistro = value; }
        public string Diferencia { get => diferencia; set => diferencia = value; }
        public string Atrasado { get => atrasado; set => atrasado = value; }
        public string Recorridos { get => recorridos; set => recorridos = value; }
        public string Horas_habladas { get => horas_habladas; set => horas_habladas = value; }
        public string Recorrido_intento_1 { get => recorrido_intento_1; set => recorrido_intento_1 = value; }
        public string Terminados { get => terminados; set => terminados = value; }
        public string Agendados { get => agendados; set => agendados = value; }
        public string Contactados { get => contactados; set => contactados = value; }
        public string No_contactados { get => no_contactados; set => no_contactados = value; }
        public string Alo_rut { get => alo_rut; set => alo_rut = value; }
        public string Venta { get => venta; set => venta = value; }
        public string Adicionales { get => adicionales; set => adicionales = value; }

        public string Tiempopostview { get => tiempopostview; set => tiempopostview = value; }
        public string Descanso { get => descanso; set => descanso = value; }
        public string Cargados { get => cargados; set => cargados = value; }
    }
}