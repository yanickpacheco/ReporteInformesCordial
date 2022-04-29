<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="ReporteInformesCordial.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio informes Clientes</title>
    <link rel="stylesheet" type="text/css" href="css/inicio.css"/>
    <%--<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css"/>--%>
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

<%--<link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css"/>--%>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<!-- Include the above in your HEAD tag -->

<link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"/>
</head>
<body>
   <%-- <form id="form1" runat="server">--%>
      
       <div class="main">
  
    
    <div class="container">
<center>
<div class="middle">
    
      <div id="login">

        <form id="form1"  runat="server" style="height: 270px">

         <%-- <fieldset class="clearfix">

            <p ><span class="fa fa-user"><asp:TextBox id="txtUsuario" runat="server"></asp:TextBox></span></p><!-- JS because of IE support; better: placeholder="Username" -->
            <p><span class="fa fa-lock"><asp:TextBox id="txtPass" runat="server" Text="Contraseña" TextMode="Password"></asp:TextBox></span></p>--%>
               <%-- <input type="password" placeholder="Contraseña" required="required" runat="server" id="txtContraseña"/>--%> <!-- JS because of IE support; better: placeholder="Password" -->
            
             <%--<div>
                    <span style="width:50%; text-align:right;  display: inline-block; height: 30px;">
                    <asp:Button ID="txtIngresar" runat="server" Text="Ingresar" OnClick="Ingresar_Click"></asp:Button></span>
             </div>

          </fieldset>--%>

             <fieldset class="clearfix">
                 <br />
                 <br />
                 <br />
                 <br />

            <p ><span class="fa fa-user"></span><asp:TextBox id="txtUsuario" runat="server"></asp:TextBox></p> <!-- JS because of IE support; better: placeholder="Username" -->
            <p><span class="fa fa-lock"></span><asp:TextBox id="txtPass" runat="server" TextMode="Password"></asp:TextBox></p> <!-- JS because of IE support; better: placeholder="Password" -->
            
             <div>
                                <span style="width:50%; text-align:right;  display: inline-block;"><asp:Button ID="txtIngresar" runat="server" Text="Ingresar" OnClick="Ingresar_Click"/></span>

                            </div>

          </fieldset>
<div class="clearfix"></div>
        </form>

        <div class="clearfix"></div>

      </div> <!-- end login -->
      <div class="logo"><asp:Image ID="Image1" runat="server" ImageUrl="~/images/Cordial Phone 2020 LOGO PNG 2.png"></asp:Image>
          
          <div class="clearfix"></div>
      </div>
      
      </div>
</center>
    </div>

</div>
    <%--</form>--%>
</body>
</html>
