<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PanelDireccionar_Metilfe.aspx.cs" Inherits="ReporteInformesCordial.PanelDireccionar_Metilfe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Informes Cencosud</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.7/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/material-design-iconic-font/2.2.0/css/material-design-iconic-font.min.css" />
    <link rel="stylesheet" href="/css/estilo.css" />
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            height: 253px;
            margin-left: auto;
            margin-right: auto;
            padding-left: 15px;
            padding-right: 15px;
            background-color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div id="viewport">
  <!-- Sidebar -->
  <div id="sidebar">
    <header>
      <a href="#"></a>
    </header>
    <%--<ul class="nav">
      <li>
        <a href="http://190.96.5.67/ReportServer/Pages/ReportViewer.aspx?%2F66%20-%20Clon%20Cruz%20Verde%2FInforme%20Calidad&rc:showbackbutton=true">
          <i class="zmdi zmdi-view-dashboard"></i> Informe Calidad
        </a>
      </li>
      <li>
        <a href="http://190.96.5.67/ReportServer/Pages/ReportViewer.aspx?%2F66%20-%20Clon%20Cruz%20Verde%2FPanel%20Control%20Ejecutivo&rc:showbackbutton=true">
          <i class="zmdi zmdi-link"></i> Panel de ejecutivos
        </a>
      </li>
      <li>
        <a href="http://190.96.5.67/ReportServer/Pages/ReportViewer.aspx?%2F66%20-%20Clon%20Cruz%20Verde%2FResultante&rc:showbackbutton=true">
          <i class="zmdi zmdi-widgets"></i> Resultante
        </a>
      </li>--%>
      <%--<li>
        <a href="#">
          <i class="zmdi zmdi-calendar"></i> Events
        </a>
      </li>
      <li>
        <a href="#">
          <i class="zmdi zmdi-info-outline"></i> About
        </a>
      </li>--%>
      <%--<li>
        <a href="#">
          <i class="zmdi zmdi-settings"></i> Services
        </a>
      </li>
      <li>
        <a href="#">
          <i class="zmdi zmdi-comment-more"></i> Contact
        </a>
      </li>--%>
    </ul>
  </div>
  <!-- Content -->
  <div id="content">
    <nav class="navbar navbar-default">
      <div class="container-fluid">
        <ul class="nav navbar-nav navbar-right">
          <li>
            <%--<a href="#"><i class="zmdi zmdi-notifications text-danger"></i>--%>
                <asp:Label ID="lblNombrePd" runat="server" Text="Label" csClass="zmdi zmdi-notifications text-danger" Visible="false"></asp:Label>
            <%--</a>--%>
          </li>
        </ul>
      </div>
    </nav>
    <div class="container-fluid">
      <h1 class="container">&nbsp;</h1>
      <p>
           <div class="auto-style1">
               <h1 class="container">        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;        Seleccione estudio</h1>
               <br />
           <asp:Panel ID="panelRedirec" HorizontalAlign="Center" runat="server" Width="501px" BackImageUrl="~/ExtraPreunic.aspx" Height="285px">
                <br />
                <asp:Button ID="btnSantaMaria" runat="server" Text="Clinica Santa María" Width="258px" OnClick="btnSantaMaria_Click" />
                <br />
                <br />
                <asp:Button ID="btnClinicaRedSalud" runat="server" Text="Clínica Red Salud"  Width="258px" OnClick="btnClinicaRedSalud_Click" style="height: 28px" />
                <br />
                <br />
                <asp:Button ID="btnClinicaDavila" runat="server" Text="Clínica Davila"  Width="258px" OnClick="btnClinicaDavila_Click" />
                <br />
                <br />
               <asp:Button ID="btnEnfermedadesGraves" runat="server" Text="Enfermedades Graves"  Width="258px" OnClick="btnEnfermedadesGraves_Click" />
                <br />
                <br />
               <asp:Button ID="btnCoberturaCovid" runat="server" Text="Indisa Catastrofico Cobertura Covid"  Width="288px" OnClick="btnCoberturaCovid_Click" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </asp:Panel>
               </div>
</p>
    </div>
  </div>
</div>
    </form>
</body>
</html>
