<%@ Page Title="" Language="C#" MasterPageFile="~/Administracion/Interno.Master" AutoEventWireup="true" CodeBehind="ListaPacientes.aspx.cs" Inherits="Web.Paciente.Lista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
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
                
            </div>
        </div>
        <div class="row d-flex flex-columns">
            <div class="col">
                <div class="d-flex flex-column flex-lg-row justify-content-lg-evenly">
                    <a href="FormularioPaciente.aspx" class="btn-skin text-decoration-none mb-5"><i class="bi bi-person-plus"></i>Nuevo Paciente</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
