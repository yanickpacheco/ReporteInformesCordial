<%@ Page Title="" Language="C#" MasterPageFile="~/Odonto.Master" AutoEventWireup="true" CodeBehind="InformeCalidadOdonto.aspx.cs" Inherits="ReporteInformesCordial.InformeCalidadOdonto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head5" runat="server">
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2_Empresa5" runat="server">
     <h4  style="color:white"> <span>BCI</span>
       <br />
    <asp:Label ID="lblEmpresa" runat="server" Text=""></asp:Label></h4>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1_Cuerpo5" runat="server">
    <div class="container-fluid">
        <div class="panel-title">
            <div class="label-primary form-control" style="text-align:center;height:50px"><span style="color:white;font-size:26px">Informe Calidad</span></div>
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

                            <th>ID</th>
                            <th>Usuario</th>
                            <th>Fono Contacto</th>
                            <th>F.Venta</th>
                            <th>Rut</th>
                            <th>Nombre Venta</th>
                            <th>Fecha Nacimiento</th>                            
                            <th>Sexo</th>
                            <th>Email</th>
                            <th>Direccion Venta</th>
                            <th>Comuna Venta</th>
                            <th>Ciudad Venta</th>
                            <th>Tipo Contrato</th>
                            <th>Plan Contratado</th>
                            <th>Prima UF</th>
                            <th>Prima Pesos</th>
                            <th>Grabacion</th>
                            <th>Estado Calidad</th>
                            <th>Observacion</th>
                            <th>Analista Calidad</th>
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
                                    <td><%#Eval("Nombre_V") %></td>
                                    <td><%#Eval("Fecha_nacimiento_V") %></td>
                                    <td><%# Eval("Sexo_V") %></td>
                                    <td><%# Eval("Mail_V") %></td>
                                    <td><%#Eval("Direccion_V") %></td>
                                    <td><%#Eval("Comuna_V") %></td>
                                    <td><%#Eval("Ciudad_V") %></td>
                                    <td><%#Eval("Tipo_Contrato") %></td>
                                    <td><%#Eval("Plan_contratado") %></td>
                                    <td><%#Eval("Prima_UF") %></td>
                                    <td><%#Eval("Prima_Pesos") %></td>
                                    <td><%#Eval("Grabacion") %></td>
                                    <td><%#Eval("Estado_calidad") %></td>
                                    <td><%#Eval("Observacion") %></td>
                                    <td><%#Eval("Analista_calidad") %></td>
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
