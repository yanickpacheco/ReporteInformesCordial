<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ReporteInformesCordial.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>Ingreso</title>
	<meta charset="UTF-8"/>
	<link rel="stylesheet" type="text/css" href="css/estilo.css"/>

	<meta name="viewport" content="width=device-width, initial-scale=1"/>
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/Linearicons-Free-v1.0.0/icon-font.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css"/>
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css"/>
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css"/>
	<link rel="stylesheet" type="text/css" href="css/main.css"/>
<!--===============================================================================================-->
</head>
<body>

    <div class="container-login100">
		<div class="limiter">
            <asp:Image ID="Image1" runat="server" Height="114px" ImageUrl="~/images/logo cordial.jfif" Width="124px" /></div>
		<div class="container-login100">
			<div class="wrap-login100 p-b-160 p-t-50">
				<form class="login100-form validate-form" runat="server">
					<span class="login100-form-title p-b-43">
						Ingreso
					</span>
					
					<div class="wrap-input100 rs1 validate-input" data-validate="Usuario es requerido">
						<%--<input class="input100" type="text" name="username" id="txtUsuario" runat="server"/>
						<span class="label-input100">Usuario</span>--%>
                        <asp:TextBox ID="txtUsuario" runat="server" CssClass="input100"></asp:TextBox>
						<span class="label-input100">Usuario</span>
					</div>
					
					
					<div class="wrap-input100 rs2 validate-input" data-validate="Contraseña es requerida">
						<%--<input class="input100" type="password" name="pass" id="txtPass" runat="server"/>--%>
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password" CssClass="input100"></asp:TextBox>
						<span class="label-input100">Contraseña</span>
					</div>

					<div class="container-login100-form-btn" >
						<%--<button class="login100-form-btn" runat="server" onclick="Ingresar_Click" id="txtIngresar">
							
						
							Ingresar
							
						</button>--%>
						<%--<button type="button" class="login100-form-btn" data-toggle="modal" data-target="#exampleModalLong">  Launch demo modal</button>--%>
						
                        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="login100-form-btn" OnClick="Ingresar_Click"/>
						<asp:Label ID="lblMensaje" runat="server" Text="Label" Visible="False" ForeColor="Red"></asp:Label>
						</div>
					 

					<!-- Modal -->
<div class="modal fade" id="exampleModalLong" tabindex="-1" role="dialog" aria-labelledby="exampleModalLongTitle" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLongTitle">Seleccione estudio</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
      <ul class="nav">
      <li>
        <a href="Bienvenida2.aspx">
          <i class="zmdi zmdi-view-dashboard" ></i> Bienvenida Cruz Verde
        </a>
      </li>
	</ul>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>
					
				</form>
			</div>
		</div>
	</div>
	
	

	
	
<!--===============================================================================================-->
	<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/bootstrap/js/popper.js"></script>
	<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/daterangepicker/moment.min.js"></script>
	<script src="vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>

	<script>
	$('#exampleModal').on('show.bs.modal', function (event) {
  var button = $(event.relatedTarget) // Button that triggered the modal
  var recipient = button.data('whatever') // Extract info from data-* attributes
  // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
  // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
  var modal = $(this)
  modal.find('.modal-title').text('New message to ' + recipient)
  modal.find('.modal-body input').val(recipient)
	})
		</script>
</body>
</html>
