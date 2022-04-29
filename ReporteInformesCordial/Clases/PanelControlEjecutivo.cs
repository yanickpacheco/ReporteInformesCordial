using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReporteInformesCordial.Clases
{
    public class PanelControlEjecutivo
    {
        string _Ejecutivo;
        int _Venta;
        int _Adicionales;
        int _RecorridoIntento1;
        int _Recorridos;
        int _Terminados;
        int _Agendados;
        int _Contactados;
        int _NoContactados;
        int _AloRut;
        int _Cargados;
        string _Contactabilidad;
        string _Efectividad;
        string _AloRutSobreRecorridos;
        string _VentaSobreBase;
        string _VentaSobreRecorridos;

        public string Ejecutivo { get => _Ejecutivo; set => _Ejecutivo = value; }
        public int Venta { get => _Venta; set => _Venta = value; }
        public int Adicionales { get => _Adicionales; set => _Adicionales = value; }
        public int RecorridoIntento1 { get => _RecorridoIntento1; set => _RecorridoIntento1 = value; }
        public int Recorridos { get => _Recorridos; set => _Recorridos = value; }
        public int Terminados { get => _Terminados; set => _Terminados = value; }
        public int Agendados { get => _Agendados; set => _Agendados = value; }
        public int Contactados { get => _Contactados; set => _Contactados = value; }
        public int NoContactados { get => _NoContactados; set => _NoContactados = value; }
        public int AloRut { get => _AloRut; set => _AloRut = value; }
        public int Cargados { get => _Cargados; set => _Cargados = value; }
        public string Contactabilidad { get => _Contactabilidad; set => _Contactabilidad = value; }
        public string Efectividad { get => _Efectividad; set => _Efectividad = value; }
        public string AloRutSobreRecorridos { get => _AloRutSobreRecorridos; set => _AloRutSobreRecorridos = value; }
        public string VentaSobreBase { get => _VentaSobreBase; set => _VentaSobreBase = value; }
        public string VentaSobreRecorridos { get => _VentaSobreRecorridos; set => _VentaSobreRecorridos = value; }
    }
}