<%@ Page Title="" Language="C#" MasterPageFile="~/GestionDiaria2.Master" AutoEventWireup="true" CodeBehind="GestionesDiarias.aspx.cs" Inherits="ReporteInformesCordial.GestionesDiarias" %>
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
    <h4  style="color:white"> <span>INFORMES</span>
       <br />
         <asp:Label ID="lblEmpresa" runat="server" Text=""></asp:Label></h4>
    <p  style="color:white; height: 47px; width: 249px;"> 
        <asp:Image ID="Image1" runat="server" Height="42px" ImageUrl="~/images/scotia.PNG" Width="126px" />
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1_Cuerpo6" runat="server">
    <div class="container-fluid">
        <div class="panel-title">
            <div class="label-primary form-control" style="text-align:center;height:50px"><span style="color:white;font-size:26px">Gestiones Diarias</span></div>
        </div>
        <br />
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
            <div class="scrolling-wrapper">
                <table id="datatable" class="table table-striped table-bordered" ">
                    <thead class="label-info" style="color: #fff">
                        <tr>

                            <th>Fecha</th>
                            <th>TO Conectados</th>
                            <th>Venta</th>
                            <th>Adicionales</th>
                            <th>Recorrido intento 1</th>
                            <th>Recorridos</th>
                            <th>Horas habladas</th>                            
                            <th>Terminados</th>
                            <th>Agendados</th>
                            <th>Contactados</th>
                            <th>No contactados</th>
                            <th>Alo rut</th>
                            <th>Cargados</th>
                            <th>Contactabilidad</th>
                            <th>Efectividad</th>
                            <th>Alorut sobre recorridos</th>
                            <th>Venta sobre recorridos</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:ListView runat="server" ID="TableResult">
                            <ItemTemplate>
                                <tr>
                            <td><%# Eval("Fecha") %></td>
                            <td><%# Eval("Nejecutivo") %></td>
                            <td><%#Eval("Venta") %></td>
                            <td><%#Eval("Adicionales") %></td>
                            <td><%#Eval("Recorrido_intento_1") %></td>
                            <td><%#Eval("Recorridos") %></td>
                            <td><%#Eval("HORAS_HABLADAS") %></td>
                            <td><%# Eval("TERMINADOS") %></td>
                            <td><%# Eval("AGENDADOS") %></td>
                            <td><%#Eval("CONTACTADOS") %></td>
                            <td><%#Eval("NO_CONTACTADOS") %></td>
                            <td><%#Eval("Alo_Rut") %></td>
                            <td><%#Eval("CARGADOS") %></td>
                            <td><%#Eval("Contactabilidad") %></td>
                            <td><%#Eval("Efectividad") %></td>
                            <td><%#Eval("AloRut_Sobre_Recorridos") %></td>
                            <td><%#Eval("Venta_Sobre_Recorridos") %></td>
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
