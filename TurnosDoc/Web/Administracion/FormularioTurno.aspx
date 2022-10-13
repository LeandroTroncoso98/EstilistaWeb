<%@ Page Title="" Language="C#" MasterPageFile="~/Administracion/Interno.Master" AutoEventWireup="true" CodeBehind="FormularioTurno.aspx.cs" Inherits="Web.Administracion.FormularioTurno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container">
        <div class="row">
            <div class="form-outline mb-3 d-flex flex-column flex-lg-row justify-content-lg-between mt-5">
                <asp:LinkButton ID="btnRegresar" runat="server" CssClass="btn-skin text-decoration-none " Text="<i class='bi bi-backspace'> Regresar</i>" CausesValidation="false" OnClick="btnRegresar_Click"
                    ></asp:LinkButton>
                <asp:LinkButton ID="btnEliminar" runat="server" Text="<i class='bi bi-person-x-fill'> Eliminar</i>" CssClass="btn-eliminar text-decoration-none mt-5 mt-lg-0" Visible="false" />
            </div>
            <div class="row mt-5">
                <div class="mb-1">
                    <asp:Label runat="server" for="txtId" class="form-label" Visible="false" ID="lblId">Id:</asp:Label>
                    <asp:TextBox runat="server" ID="txtId" CssClass="form-control" Visible="false"></asp:TextBox>
                </div>
                <div class="col-12 col-lg-6">
                    <div class="mb-1">
                        <asp:Label for="ddlNombre" ID="lblNombre" CssClass="form-label" runat="server">Paciente: </asp:Label>
                        <div class="d-flex justify-content-between">
                            <asp:DropDownList runat="server" ID="ddlNombre" CssClass="form-select w-75"></asp:DropDownList>
                            <asp:LinkButton runat="server" ID="btnAgregarCliente" CssClass="btn-skin text-decoration-none" Text="<i class='bi bi-person-plus-fill'> Nuevo</i>" CausesValidation="false" OnClick="btnAgregarCliente_Click"></asp:LinkButton>
                        </div>
                    </div>
                    <div class="mb-1">
                        <asp:Label for="ddlHora" CssClass="form-label" ID="lblHora" runat="server" Text="Hora:"></asp:Label>
                        <asp:DropDownList runat="server" ID="ddlHora" CssClass="form-select"></asp:DropDownList>
                    </div>
                    <div class="mb-1">
                        <asp:Label for="ddlTratamiento" CssClass="form-label" ID="lblTratamiento" runat="server" Text="Tratamiento:"></asp:Label>
                        <asp:DropDownList runat="server" ID="ddlTratamiento" CssClass="form-select"></asp:DropDownList>
                    </div>
                    <div class="mb-1">
                        <asp:Label for="CFecha" CssClass="form-label" ID="lblCalendar" runat="server" Text="Fecha:"></asp:Label>                      
                        <asp:TextBox runat="server" ID="txtFecha" TextMode="Date" CssClass="form-select" ></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="reqFecha" ControlToValidate="txtFecha" CssClass="text-danger" Text="* Debe ingresar una fecha"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="col-12 col-lg-6">
                    <asp:Label for="txtDescripcion" CssClass="form-label" runat="server" Text="Descripcion: "></asp:Label>
                    <asp:TextBox runat="server" ID="txtDescripcion" TextMode="MultiLine" Rows="7" CssClass="form-control"></asp:TextBox>
                </div>              
                <div class="form-outline mt-4 mt-lg-0 mb-5 d-flex flex-column flex-lg-row justify-content-lg-end">
                    <asp:Button runat="server" ID="btnCrear" CssClass="btn-skin mb-5" Text="Crear" OnClick="btnCrear_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
