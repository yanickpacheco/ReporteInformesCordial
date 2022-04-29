using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReporteInformesCordial.Clases
{
    public class InformeCalidad
    {
        int id;
        string usuario;
        string fono_contacto;
        DateTime fecha_V;
        string rut_V;
        string dv_V;
        string nombre_V;
        DateTime fecha_nacimiento_V;
        string sexo_V;
        string mail_V;
        string direccion_V;
        string comuna_V;
        string ciudad_V;
        string tipo_Contrato;
        string plan_contratado;
        string prima_UF;
        string prima_Pesos;
        string grabacion;
        string estado_calidad;
        string observacion;
        string analista_calidad;

        public int Id { get => id; set => id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Fono_contacto { get => fono_contacto; set => fono_contacto = value; }
        public DateTime Fecha_V { get => fecha_V; set => fecha_V = value; }
        public string Rut_V { get => rut_V; set => rut_V = value; }
        public string Dv_V { get => dv_V; set => dv_V = value; }
        public string Nombre_V { get => nombre_V; set => nombre_V = value; }
        public DateTime Fecha_nacimiento_V { get => fecha_nacimiento_V; set => fecha_nacimiento_V = value; }
        public string Sexo_V { get => sexo_V; set => sexo_V = value; }
        public string Mail_V { get => mail_V; set => mail_V = value; }
        public string Direccion_V { get => direccion_V; set => direccion_V = value; }
        public string Comuna_V { get => comuna_V; set => comuna_V = value; }
        public string Ciudad_V { get => ciudad_V; set => ciudad_V = value; }
        public string Tipo_Contrato { get => tipo_Contrato; set => tipo_Contrato = value; }
        public string Plan_contratado { get => plan_contratado; set => plan_contratado = value; }
        public string Prima_UF { get => prima_UF; set => prima_UF = value; }
        public string Prima_Pesos { get => prima_Pesos; set => prima_Pesos = value; }
        public string Grabacion { get => grabacion; set => grabacion = value; }
        public string Estado_calidad { get => estado_calidad; set => estado_calidad = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string Analista_calidad { get => analista_calidad; set => analista_calidad = value; }

    }
}