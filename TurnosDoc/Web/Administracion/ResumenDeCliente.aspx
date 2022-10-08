<%@ Page Title="" Language="C#" MasterPageFile="~/Administracion/Interno.Master" AutoEventWireup="true" CodeBehind="ResumenDeCliente.aspx.cs" Inherits="Web.Administracion.ResumenDeCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" ID="scriptManager"></asp:ScriptManager>
    <div class="container">
        <div class="row">
            <div class="col-12">
                <div class="form-outline mt-4 mt-lg-0 mb-5 d-flex flex-column flex-lg-row justify-content-lg-start">
                    <a href="ListaPacientes.aspx" class="btn-skin text-decoration-none"><i class="bi bi-backspace"></i>Regresar</a>
                </div>
            </div>
            <div class="col-12 col-lg-3 mt-5">
                <h2 class="mb-3 label-sesion text-center">Datos personales:</h2>
                <asp:Label runat="server" ID="lblNombreCompleto" CssClass="text-letra mb-3" Text="Nombre Completo : "></asp:Label>
                <br />
                <asp:Label runat="server" ID="lblEdad" CssClass="text-letra mb-3 w-100" Text="Edad : "></asp:Label>
                <br />
                <asp:Label runat="server" ID="lblEmail" CssClass="text-letra mb-3 w-100" Text="Email : "></asp:Label>
                <br />
                <asp:Label runat="server" ID="lblCelular" CssClass="text-letra mb- w-100" Text="Celular : "></asp:Label>
                <br />
                <asp:Label runat="server" ID="lblSexo" CssClass="text-letra mb-3 w-100" Text="Genero : "></asp:Label>
                <br />
                <div class="form-outline mt-4 mb-5 d-flex flex-column flex-lg-row justify-content-lg-start">
                    <asp:Button runat="server" CssClass="btn-skin" ID="btnEditarCliente" OnClick="btnEditarCliente_Click" Text="Modificar" />
                </div>
            </div>
            <div class="col-12 col-lg-9 mt-5">
                <h2 class=" label-sesion text-center mb-3">Historial:</h2>
                <asp:UpdatePanel runat="server" ID="updatePanel1">
                    <ContentTemplate>
                        <div class="table-responsive">
                            <asp:GridView ID="dgvPacienteSeleccionado" runat="server" CssClass="table table-condensed table-hover mt-1 mb-5 border-0" HeaderStyle-CssClass="text-letra bg-table-header text-uppercase" RowStyle-CssClass="table-light text-letra" AutoGenerateColumns="false" DataKeyNames="Id" OnPageIndexChanging="dgvPacienteSeleccionado_PageIndexChanging" AllowPaging="true" PageSize="5">
                                <Columns>
                                    <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
                                    <asp:BoundField HeaderText="Horario" DataField="Hora" />
                                    <asp:BoundField HeaderText="Tratamiento" DataField="Tratamiento" />
                                    <asp:CommandField HeaderText="Detalles" ShowSelectButton="true" SelectText="ver mas" ControlStyle-CssClass="text-decoration-none btn-ver" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>

            </div>
        </div>
    </div>
</asp:Content>
