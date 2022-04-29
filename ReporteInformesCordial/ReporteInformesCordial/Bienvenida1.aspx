<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bienvenida1.aspx.cs" Inherits="ReporteInformesCordial.Bienvenida1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.7/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/material-design-iconic-font/2.2.0/css/material-design-iconic-font.min.css" />
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.20/css/jquery.dataTables.css" />
  
<script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.20/js/jquery.dataTables.js"></script>



    


    <link rel="stylesheet" href="/css/estilo.css" />
    <script src="js/jquery-1.12.4.js"></script>
    <script "js/jquery.dataTables.min.css"></script>
    <script src="js/jquery.dataTables.min.js"></script>

    <script type="text/javascript"> 
        $(document).ready(function () {
            $('#datatable').DataTable();
        });
    </script>

</head>
<body>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div id="viewport">
            <!-- Sidebar -->
            <div id="sidebar">
                <header>
                    <a href="#">Bienvenida cruz verde</a>
                </header>
                <ul class="nav">
                    <li>
                        <%--<a href="http://190.96.5.67/ReportServer/Pages/ReportViewer.aspx?%2F170%20-%20BIenvenida%20Cruz%20Verde%2FInforme%20Calidad&rc:showbackbutton=true">--%>
                        <a href="Bienvenida1.aspx" runat="server" id="enlace" onclick="" style="height: 53px">
                            <i class="zmdi zmdi-view-dashboard" runat="server"></i>Informe calidad
                        </a>
                    </li>
                    <li>
                        <a href="#">
                            <i class="zmdi zmdi-link"></i>Resultante
                        </a>
                    </li>
                    <%-- <li>
        <a href="#">
          <i class="zmdi zmdi-widgets"></i> Overview
        </a>
      </li>
      <li>
        <a href="#">
          <i class="zmdi zmdi-calendar"></i> Events
        </a>
      </li>
      <li>
        <a href="#">
          <i class="zmdi zmdi-info-outline"></i> About
        </a>
      </li>
      <li>
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
                                <a href="#"><i class="zmdi zmdi-notifications text-danger"></i>
                                </a>
                            </li>

                        </ul>
                    </div>




                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-md-4">
                                <h3>Inicio</h3>
                                <asp:TextBox ID="txtFecha_Incio" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe ingresar Fecha" ControlToValidate="txtFecha_Incio" ValidationGroup="A"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-4">
                                <h3>Fin</h3>
                                <asp:TextBox ID="txtFecha_Fin" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe ingresar Fecha" ControlToValidate="txtFecha_Fin" ValidationGroup="A"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-4">
                                <h3>&nbsp;</h3>
                                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info" ValidationGroup="A" OnClick="Buscar_Click" />
                            </div>

                        </div>
                        <%--fin de las busquedas--%>
                        <br />
                        <div>
                            <div style="text-align: right">
                                <asp:ImageButton ID="btnExcel" runat="server" Height="33px" ImageUrl="~/images/icons/excel.png" OnClick="ImageButton3_Click" Width="50px" />
                            </div>
                            <div class="table">
                               
                               <%-- <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"  scro   CellPadding="3" ForeColor="Black" GridLines="Vertical"  Font-Size="X-Small" CssClass="table-responsive">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <FooterStyle BackColor="#CCCCCC" />
                                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="Gray" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>--%>
                                

                                <table id="datatable" class="table table-striped table-bordered">
                                        <thead class="label-info" style="color: #fff">
                                            <tr>
                                                
                                                <th>ID</th>
                                                <th>Usuario</th>
                                                <th>Fono Contacto</th>
                                                <th>F.Venta</th>
                                                <th>Rut</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:ListView runat="server" ID="TableResult">
                                                <ItemTemplate>
                                                    <tr>
                                                        <td><%# Eval("Id") %></td>
                                                        <td><%# Eval("Usuario") %></td>
                                                        <td><%#Eval("Fono_contacto") %></td>
                                                        <td><%#Eval("Fecha_V") %></td>
                                                        <td><%#Eval("Rut_V") %></td>
                                                    </tr>

                                                </ItemTemplate>
                                            </asp:ListView>
                                        </tbody>
                                    </table>



                            </div>
                        </div>
                        <%--fin de los datos--%>
                        <code></code>
                        <table>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Desde" Font-Size="X-Small"></asp:Label>
                                <asp:TextBox ID="TextBox3" runat="server" Width="92px" ReadOnly="True" Font-Size="Small"></asp:TextBox><asp:ImageButton ID="ImageButton1" runat="server" Height="28px" ImageUrl="~/images/calendario.jfif" Width="37px" OnClick="ImageButton1_Click" />
                                <asp:Calendar ID="Calendar3" runat="server" SelectionMode="Day" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="70px" Width="172px" OnSelectionChanged="Calendar3_SelectionChanged">
                                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                    <NextPrevStyle VerticalAlign="Bottom" />
                                    <OtherMonthDayStyle ForeColor="#808080" />
                                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                    <SelectorStyle BackColor="#CCCCCC" />
                                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <WeekendDayStyle BackColor="#FFFFCC" />
                                </asp:Calendar>

                                <td style width="150px"></td>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="Hasta" Font-Size="X-Small"></asp:Label>
                                    <asp:TextBox ID="TextBox4" runat="server" Width="111px" ReadOnly="True" Font-Size="Small"></asp:TextBox><asp:ImageButton ID="ImageButton2" runat="server" Height="28px" ImageUrl="~/images/calendario.jfif" OnClick="ImageButton2_Click" Width="36px" />
                                    <asp:Calendar ID="Calendar4" runat="server" SelectionMode="Day" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="17px" Width="162px" OnSelectionChanged="Calendar4_SelectionChanged">
                                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                        <NextPrevStyle VerticalAlign="Bottom" />
                                        <OtherMonthDayStyle ForeColor="#808080" />
                                        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                        <SelectorStyle BackColor="#CCCCCC" />
                                        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                        <WeekendDayStyle BackColor="#FFFFCC" />
                                    </asp:Calendar>
                                </td>
                                <td></td>
                                <td>
                                    <asp:Button ID="Button1" runat="server" Text="Ver informe" Height="30px" OnClick="Button1_Click1" Width="108px" />
                                    <br />
                                    <br />
                                    <br />

                                </td>


                            </td>


                        </table>


                    </div>
                    <br />
                    <table>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;
       
                        </td>
                    </table>
            </div>
        </div>
    </form>
</body>
</html>
