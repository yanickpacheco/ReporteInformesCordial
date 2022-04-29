<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="A.aspx.cs" Inherits="ReporteInformesCordial.A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script
        src="https://code.jquery.com/jquery-1.11.2.js"
        integrity="sha256-WMJwNbei5YnfOX5dfgVCS5C4waqvc+/0fV7W2uy3DyU="
        crossorigin="anonymous"></script>
    <title></title>
    
        <script type="text/javascript">
            $(document).load(function () {
                $("#content").attr("src", "http://190.96.5.67/ReportServer/Pages/ReportViewer.aspx?%2F170%20-%20BIenvenida%20Cruz%20Verde%2FInforme%20Calidad&rc:showbackbutton=true");
            })
</script>


          

       

       
        


</head>
<body>
    <form id="form1" runat="server">
      <div id="content"></div>
    </form>
</body>
</html>
