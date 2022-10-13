<%@ Page Title="" Language="C#" MasterPageFile="~/Administracion/Interno.Master" AutoEventWireup="true" CodeBehind="ListaPacientes.aspx.cs" Inherits="Web.Paciente.Lista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
    <div class="container">
        <div class="row">
            <div class="col- col-lg-3 mt-5">
                <h3 class="text-center text-md-start">Filtrar paciente:</h3>
            </div>
        </div>
        <asp:UpdatePanel runat="server" ID="updatepanel">
            <ContentTemplate>
                <div class="row">
                    <div class="col-8 col-lg-4">
                        <asp:TextBox runat="server" ID="txtFiltrar" CssClass="form-control" OnTextChanged="btnfiltrar_Click"></asp:TextBox>
                    </div>
                    <div class="col d-flex flex-column flex-lg-row">
                        <asp:LinkButton runat="server" ID="btnfiltrar" CssClass="btn-skin text-decoration-none" OnClick="btnfiltrar_Click" Text="<i class='bi bi-search'> Filtrar</i>" />
                    </div>
                </div>
                <%if (vacio == true)
                    { %>
                <div class="row mt-5 mb-5">
                    <div class="col">
                        <h2 class="text-center"><i class="bi bi-emoji-frown-fill"></i> No existe ningun paciente.</h2>
                    </div>
                </div>
                <%} %>
                <div class="row">
                    <div class="col">
                        <div class="table-responsive">
                            <asp:GridView ID="dgvClientes" runat="server"
                                DataKeyNames="Id" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvClientes_SelectedIndexChanged" OnPageIndexChanging="dgvClientes_PageIndexChanging" AllowPaging="true" PageSize="10" CssClass=" table table-condensed table-hover mt-5 mb-5 border-0" HeaderStyle-CssClass="text-letra bg-table-header text-uppercase" RowStyle-CssClass="table-light text-letra">
                                <Columns>
                                    <asp:BoundField HeaderText="Nombre completo" DataField="NombreCompleto" />
                                    <asp:BoundField HeaderText="Edad" DataField="Edad" />
                                    <asp:BoundField HeaderText="Celular" DataField="Celular" />
                                    <asp:BoundField HeaderText="Genero" DataField="Sexo" />
                                    <asp:CommandField HeaderText="Detalles" ShowSelectButton="true" SelectText="ver mas" ControlStyle-CssClass="text-decoration-none btn-ver" />
                                </Columns>
                            </asp:GridView>

                        </div>
                        <div class="row d-flex flex-columns">
                            <div class="col mt-5 mt-lg-0">
                                <div class="d-flex flex-column flex-lg-row justify-content-lg-evenly">
                                    <a href="FormularioPaciente.aspx" class="btn-skin text-decoration-none mb-5"><i class="bi bi-person-plus"></i>Nuevo Paciente</a>
                                </div>
                            </div>
                        </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
