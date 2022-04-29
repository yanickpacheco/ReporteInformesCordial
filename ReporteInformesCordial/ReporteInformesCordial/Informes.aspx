<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Informes.aspx.cs" Inherits="ReporteInformesCordial.Informes" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <title>Inicio informes Clientes</title>
    <link rel="stylesheet" type="text/css" href="css/inicio.css"/>
   <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<!-- Include the above in your HEAD tag -->

<link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"/>
</head>
<body style="margin: 0px !important; background-color: white">

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" AsyncPostBackTimeout="100000"></asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" ProcessingMode="Remote">
            <ServerReport ReportServerUrl="http://190.96.5.67/Reportserver" Timeout="100000" />
        </rsweb:ReportViewer>
    </form>
</body>
<%--<script>
    // Guardando la URL de la imagen del botón imprimir. Esta imagen es una copia de la imagen mostrada en el ReportViewer, guardada en la carpeta de imágenes de la aplicación web.
    var urlImg = '<%=Page.ResolveUrl("../imagenes/Print.png") %>';

    // Función que se ejecuta una vez se ha terminado de cargar el DOM de la página web en el navegador
    $(document).ready(function () {
        colocarBtnImprimir();    // Colocar el botón de imprimir en la barra de herramientas del ReportViewer
        $("#BtnImprimir").click(function () {
             
            location.href = "/Home/CrearPdf";               
            
        });  // Asignando la función "imprimirDiv" al evento click del botón de impresión
    });

    // Esta función coloca el botón de imprimir en la barra de herramientas del ReportViewer
    //function colocarBtnImprimir() {
    //    var jqoBarraRpt = $('div#ReportViewer1_ctl05>div:first-child');    // Buscando el div que contiene la barra de herramientas del RportViewer

    //    if (jqoBarraRpt && jqoBarraRpt.length > 0    // Verificando que el DIV barra de herramientas fue encontrado,
    //        && jqoBarraRpt.find('#BtnImprimir').length <= 0) {    // y verificando que el botón de imprimir no existe ya

    //        // Colocando el botón de impresión, con una estructura similar a la que tiene el botón original en el ReportViewer
    //        jqoBarraRpt.append('<table cellpadding="0" cellspacing="0" ToolbarSpacer="true" style="display:inline;width:10px;"><tr><td></td></tr></table><div style="display:inline;font-family:Verdana;font-size:8pt;vertical-align:top;"><table cellpadding="0" cellspacing="0" style="display:inline;"><tr><td height="28px"><div"><div id="BtnImprimir"><table title="Print"><tr><td><img title="Print" src="' + urlImg + '" alt="Print" style="border-style:None;height:16px;width:16px;" /></td></tr></table></div><div disabled="disabled" style="display:none;border:1px transparent Solid;"><table title="Print"><tr><td><input type="image" disabled="disabled" title="Print" src="' + urlImg + '" alt="Print" style="border-style:None;height:16px;width:16px;cursor:default;" /></td></tr></table></div></div></td></tr></table></div>');

    //    }

    //}

    // Función que se encarga de imprimir el reporte
    function imprimirDiv() {


        //location.href = '/Home/CrearPdf';
        //var divImprimir = $("div[id$='ReportDiv']").parent();    // Obteniendo el DIV que contiene el reporte a imprimir
        //var newWin = window.open();    // Abriendo una nueva ventana del navegador
        //newWin.document.open();    // Abriendo el documento de la nueva ventana, para escribir su contenido
        //newWin.document.write('<html><head><style type="text/css">' + getAllStyleSheetsAsText() + '</style></head><body>' + divImprimir.html() + '</body>');
        //newWin.document.close();
        //newWin.print();
        //newWin.close();
    }

    function getAllStyleSheetsAsText() {
        var cssText = '';
        var sheets = document.styleSheets;
        for (var c = 0; c < sheets.length; c++) {
            var sheet = sheets[c];
            if ((sheet.ownerNode || sheet.owningElement).id.endsWith('_ReportControl_styles')) {
                var rules = sheet.rules || sheet.cssRules;
                for (var r = 0; r < rules.length; r++) {
                    var cssRule = rules[r];
                    if (navigator.appName == 'Microsoft Internet Explorer') {
                        var cssText = cssText + cssRule.selectorText + '{' + cssRule.style.cssText.toLowerCase() + '}';
                    } else {
                        var cssText = cssText + cssRule.cssText;
                    }
                }
            }
        }
        return cssText;
    }
</script>--%>
</html>

