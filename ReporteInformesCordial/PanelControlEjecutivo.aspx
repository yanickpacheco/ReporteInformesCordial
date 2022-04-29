<%@ Page Title="" Language="C#" MasterPageFile="~/Cencosud.Master" AutoEventWireup="true" CodeBehind="PanelControlEjecutivo.aspx.cs" Inherits="ReporteInformesCordial.PanelControlEjecutivo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head6" runat="server">
     <link rel="stylesheet" href="/css/estilo.css" />
    <script src="js/jquery-1.12.4.js"></script>
    <script "js/jquery.dataTables.min.css"></script>
    <script src="js/jquery.dataTables.min.js"></script>

    <script type="text/javascript"> 
        $(document).ready(function () {
            $('#datatable').DataTable(
                { "scrollX": true });
        });
    </script> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2_Empresa6" runat="server">
    <h4  style="color:white"> <span>CAMPAÑAS</span>
       <br />
    <asp:Label ID="lblEmpresa" runat="server" Text=""></asp:Label></h4>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1_Cuerpo6" runat="server">
     <div class="container-fluid">
        <div class="panel-title">
            <div class="label-primary form-control" style="text-align:center;height:50px"><span style="color:white;font-size:26px">Panel Control Ejecutivo</span></div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-4">
                <h3>Inicio</h3>
                <asp:TextBox ID="txtFecha_Incio1" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe ingresar Fecha" ControlToValidate="txtFecha_Incio1" ValidationGroup="A"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-4">
                <h3>Fin</h3>
                <asp:TextBox ID="txtFecha_Fin1" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe ingresar Fecha" ControlToValidate="txtFecha_Fin1" ValidationGroup="A"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-4">
                <h3>&nbsp;</h3>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info" ValidationGroup="A" OnClick="Buscar1_Click" />
            </div>

        </div>
        <%--fin de las busquedas--%>
        <br />
        <div>
            <div style="text-align: right">
                <asp:ImageButton ID="btnExcel" runat="server" Height="33px" ImageUrl="~/images/icons/excel.png" OnClick="ImageButton3_Click" Width="50px" />
            </div>
            <div class="scrolling-wrapper">
                <table id="datatable" class="table table-striped table-bordered" ">
                    <thead class="label-info" style="color: #fff">
                        <tr>

                            <th>Ejecutivo</th>
                            <th>Venta</th>
                            <th>Adicionales</th>
                            <th>Recorrido_Intento_1</th>
                            <th>Recorridos</th>
                            <th>Terminados</th>
                            <th>Agendados</th>
                            <th>Contactados</th>
                            <th>No_Contactados</th>
                            <th>Alo_Rut</th>
                            <th>% Contactabilidad</th>
                            <th>% Efectividad</th>
                            <th>% Alo Rut Sobre Recorridos</th>
                            <th>% Ventas Sobre Base</th>
                            <th>% Ventas Sobre Recorridos</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:ListView runat="server" ID="TableResult" >
                            <ItemTemplate>
                                <tr>
                                    
                                    <td><%#Eval("Ejecutivo") %></td>
                                    <td><%#Eval("Venta") %></td>
                                    <td><%#Eval("Adicionales") %></td>
                                    <td><%#Eval("RecorridoIntento1") %></td>
                                    <td><%#Eval("Recorridos") %></td>
                                    <td><%#Eval("Terminados") %></td>
                                    <td><%#Eval("Agendados") %></td>
                                    <td><%#Eval("Contactados") %></td>
                                    <td><%#Eval("NoContactados") %></td>
                                    <td><%#Eval("AloRut") %></td>
                                    <td><%#Eval("Contactabilidad") %></td>
                                    <td><%#Eval("Efectividad") %></td>
                                    <td><%#Eval("AloRutSobreRecorridos") %></td>
                                    <td><%#Eval("VentaSobreBase") %></td>
                                    <td><%#Eval("VentaSobreRecorridos") %></td>
                                </tr>

                            </ItemTemplate>
                        </asp:ListView>
                    </tbody>
                </table>



            </div>
        </div>
        <%--fin de los datos--%>
    </div>
</asp:Content>
