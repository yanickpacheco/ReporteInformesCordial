<%@ Page Title="" Language="C#" MasterPageFile="~/Cencosud.Master" AutoEventWireup="true" CodeBehind="Segmentador.aspx.cs" Inherits="ReporteInformesCordial.Segmentador" %>
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1_Cuerpo6" runat="server">
     <div class="container-fluid">
        <div class="panel-title">
            <div class="label-primary form-control" style="text-align:center;height:50px"><span style="color:white;font-size:26px">Segmentador</span></div>
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

                            <th>Grabacion</th>
                            <th>Fecha venta</th>
                            <th>Ejecutivo</th>
                            <th>Rut venta</th>
                            <th>Nombre</th>
                            <th>Paterno</th>
                            <th>Materno</th>   
                            <th>Direccion Venta</th>
                            <th>Comuna</th>
                            <th>Estado calidad grabación</th>
                            <th>Estado calidad regrabación</th>
                            <th>Observacion</th>
                            <th>Venta informada</th>
                            <th>Motivo NN</th>
                            <th>Prima pesos</th>
                            <th>Prima UF</th>
                            <th>Plan contratado</th>
                            <th>Tipo contrato</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:ListView runat="server" ID="TableResult" >
                            <ItemTemplate>
                                <tr>
                                    
                                    <td><asp:LinkButton ID="enviar" runat="server" text="Reproducir audios" CommandArgument='<%# Bind("Grabacion") %>' CommandName="Select"  OnClick="enviar_Click"/></td>
                                    <td><%#Eval("Fecha_venta") %></td>
                                    <td><%#Eval("Ejecutivo") %></td>
                                    <td><%#Eval("Rut_venta") %></td>
                                    <td><%#Eval("Nombre") %></td>
                                    <td><%#Eval("Paterno") %></td>
                                    <td><%#Eval("Materno") %></td>
                                    <td><%#Eval("Direcc_venta") %></td>
                                    <td><%#Eval("Comuna") %></td>
                                    <td><%#Eval("Estado_cal_grab") %></td>
                                    <td><%#Eval("Estado_cal_regrab") %></td>
                                    <td><%#Eval("Observacion") %></td>
                                    <td><%#Eval("Venta_informada") %></td>
                                    <td><%#Eval("Motivonn") %></td>
                                    <td><%#Eval("Primapesos") %></td>
                                    <td><%#Eval("Primauf") %></td>
                                    <td><%#Eval("Plan_contratado") %></td>
                                    <td><%#Eval("Tipo_contrato") %></td>
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
