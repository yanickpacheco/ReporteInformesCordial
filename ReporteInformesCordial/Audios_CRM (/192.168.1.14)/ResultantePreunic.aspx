<%@ Page Title="" Language="C#" MasterPageFile="~/PreUnic.Master" AutoEventWireup="true" CodeBehind="ResultantePreunic.aspx.cs" Inherits="ReporteInformesCordial.ResultantePreunic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head2" runat="server">
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2_Empresa3" runat="server">
    <h4  style="color:white"> <span>ExtraProtección</span>
       <br />
    <asp:Label ID="lblEmpresa" runat="server" Text=""></asp:Label></h4>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1_Cuerpo3" runat="server">
    <div class="container-fluid">
        <div class="panel-title">
            <div class="label-primary form-control" style="text-align:center;height:50px"><span style="color:white;font-size:26px">Resultante</span></div>
            <br />
        </div>
        <div class="row">
            <div class="col-md-4">
                <h3>Inicio</h3>
                <asp:TextBox ID="txtFecha_Inicio1" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Debe ingresar Fecha" ControlToValidate="txtFecha_Inicio1" ValidationGroup="A"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-4">
                <h3>Fin</h3>
                <asp:TextBox ID="txtFecha_Fin1" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Debe ingresar Fecha" ControlToValidate="txtFecha_Fin1" ValidationGroup="A"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-4">
                <h3>&nbsp;</h3>
                <asp:Button ID="btnBuscar1" runat="server" Text="Buscar" CssClass="btn btn-info" ValidationGroup="A" OnClick="btnBuscar1_Click" />
            </div>

        </div>
        <%--fin de las busquedas--%>
        <br />
        <div>
            <div style="text-align: right">
                <asp:ImageButton ID="btnImgExcel1" runat="server" Height="33px" ImageUrl="~/images/icons/excel.png" OnClick="btnImgExcel1_Click" Width="50px" />
            </div>
            <div class="scrolling-wrapper">
                <table id="datatable" class="table table-striped table-bordered">
                    <thead class="label-info" style="color: #fff">
                        <tr>
                            <th>ID</th>
                            <th>RUT BASE</th>
                            <th>DV BASE</th>
                            <th>NOMBRE CLIENTE</th>
                            <th>FECHA NACIMIENTO</th>
                            <th>SEXO BASE</th>
                            <th>EDAD BASE</th>
                            <th>DIRECCION BASE</th>
                            <th>COMUNA BASE</th>
                            <th>CIUDAD BASE</th>
                            <th>REGION BASE</th>
                            <th>EMAIL BASE</th>
                            <th>FONO1</th>
                            <th>FONO2</th>
                            <th>FONO3</th>
                            <th>FONO4</th>
                            <th>FONO5</th>
                            <th>FONO6</th>
                            <th>ANIOMES</th>
                            <th>ESTADO</th>
                            <th>FECHA GESTION</th>
                            <th>HORA GESTION</th>
                            <th>FECHA VENTA</th>
                            <th>HORA VENTA</th>
                            <th>INTENTOS</th>
                            <th>LLAMADA</th>
                            <th>EJECUTIVO</th>
                            <th>CONTACTO</th>
                            <th>NO CONTACTO</th>
                            <th>CONTACTO CON</th>
                            <th>FLUJO CONTACTO</th>
                            <th>RUT VENTA</th>
                            <th>DV VENTA</th>
                            <th>NOMBRE VENTA</th>
                            <th>FECHA NACIMIENTO VENTA</th>
                            <th>SEXO VENTA</th>
                            <th>EMAIL VENTA</th>
                            <th>DIRECCION VENTA</th>
                            <th>COMUNA VENTA</th>
                            <th>CIUDAD VENTA</th>
                            <th>TIPO CONTRATO</th>
                            <th>PLAN CONTRATADO</th>
                            <th>PRIMA UF</th>
                            <th>PRIMA PESOS</th>
                            <th>VENTA</th>
                            <th>Grabacion</th>                           
                        </tr>
                    </thead>
                    <tbody>
                        <asp:ListView runat="server" ID="TableResult1">
                            <ItemTemplate>
                                <tr>
                                    <td><%# Eval("Id") %></td>
                                    <td><%# Eval("Rut") %></td>
                                    <td><%#Eval("Dv") %></td>
                                    <td><%#Eval("Nombre_cli") %></td>
                                    <td><%#Eval("Fec_nac") %></td>
                                    <td><%#Eval("Sexo_base") %></td>
                                    <td><%# Eval("Edad_base") %></td>
                                    <td><%# Eval("Direcc_base") %></td>
                                    <td><%#Eval("Comuna_base") %></td>
                                    <td><%#Eval("Ciudad_base") %></td>
                                    <td><%#Eval("Region_base") %></td>
                                    <td><%#Eval("Mail_base") %></td>
                                    <td><%#Eval("Fono1") %></td>
                                    <td><%#Eval("Fono2") %></td>
                                    <td><%#Eval("Fono3") %></td>
                                    <td><%#Eval("Fono4") %></td>
                                    <td><%#Eval("Fono5") %></td>
                                    <td><%#Eval("Fono6") %></td>
                                    <td><%#Eval("Aniomes") %></td>
                                    <td><%#Eval("Estado") %></td>
                                    <td><%#Eval("Fecha_ges") %></td>
                                    <td><%#Eval("Hora_ges") %></td>
                                    <td><%#Eval("Fecha_venta") %></td>
                                    <td><%#Eval("Hora_venta") %></td>
                                    <td><%#Eval("Intentos") %></td>
                                    <td><%#Eval("Ejecutivo") %></td>
                                    <td><%#Eval("Contacto") %></td>
                                    <td><%#Eval("No_contacto") %></td>
                                    <td><%#Eval("Contacto_con") %></td>
                                    <td><%#Eval("Flujo_contacto") %></td>
                                    <td><%#Eval("Rut_venta") %></td>
                                    <td><%#Eval("Dv_venta") %></td>
                                    <td><%#Eval("Nombre_venta") %></td>
                                    <td><%#Eval("Fec_nac_venta") %></td>
                                    <td><%#Eval("Sexo_venta") %></td>
                                    <td><%#Eval("Email_venta") %></td>
                                    <td><%#Eval("Direc_venta") %></td>
                                    <td><%#Eval("Comuna_venta") %></td>
                                    <td><%#Eval("Ciudad_venta") %></td>
                                    <td><%#Eval("Direc_venta") %></td>
                                    <td><%#Eval("Tipo_contrato") %></td>
                                    <td><%#Eval("Plan_contratado") %></td>
                                    <td><%#Eval("Prima_uf") %></td>
                                    <td><%#Eval("Prima_pesos") %></td>
                                    <td><%#Eval("Venta") %></td>
                                    <td><%#Eval("Grabacion") %></td>
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
