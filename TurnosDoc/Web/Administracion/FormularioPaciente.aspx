<%@ Page Title="" Language="C#" MasterPageFile="~/Administracion/Interno.Master" AutoEventWireup="true" CodeBehind="FormularioPaciente.aspx.cs" Inherits="Web.Paciente.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row mt-5">
            <div class="form-outline mb-3 d-flex flex-column flex-lg-row justify-content-lg-start">
                <a href="ListaPacientes.aspx" class="btn-skin text-decoration-none"><i class="bi bi-backspace"></i>Regresar</a>
            </div>
            <div class="col-12">
                <div class="mb-3">
                    <asp:Label runat="server" for="txtId" class="form-label" Visible="false" ID="lblId">Id:</asp:Label>
                    <asp:TextBox runat="server" ID="txtId" CssClass="form-control" Visible="false"></asp:TextBox>

                </div>
            </div>
            <div class="col-12 col-lg-6">
                <div class="mb-3">
                    <label for="txtNombre" class="form-label">Nombre: </label>
                    <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtApellido" class="form-label">Apellido: </label>
                    <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtedad" class="form-label">Edad: </label>
                    <asp:TextBox runat="server" ID="txtEdad" TextMode="Number" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-12 col-lg-6">
                <div class="mb-3">
                    <label for="txtEmail" class="form-label">Email: </label>
                    <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtCelular" class="form-label">Celular: </label>
                    <asp:TextBox runat="server" ID="txtCelular" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="ddlGenero" class="form-label">Genero: </label>
                    <asp:DropDownList ID="ddlGenero" CssClass="form-select" runat="server"></asp:DropDownList>
                </div>
            </div>
            <div class="form-outline mt-4 mt-lg-0 mb-5 d-flex flex-column flex-lg-row justify-content-lg-end">
                <asp:Button runat="server" ID="btnCrear" CssClass="btn-skin" Text="Crear" OnClick="btnCrear_Click" />
            </div>
        </div>
    </div>
</asp:Content>
