<%@ Page Title="" Language="C#" MasterPageFile="~/Administracion/Interno.Master" AutoEventWireup="true" CodeBehind="FormularioPaciente.aspx.cs" Inherits="Web.Paciente.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="form-outline mb-3 d-flex flex-column flex-lg-row justify-content-lg-between">                
                <asp:LinkButton ID="btnRegresar" runat="server" CssClass="btn-skin text-decoration-none " Text="<i class='bi bi-backspace'> Regresar</i>" OnClick="btnRegresar_Click" CausesValidation="false"></asp:LinkButton>
                <asp:LinkButton ID="btnEliminar" runat="server" Text="<i class='bi bi-person-x-fill'> Eliminar</i>" CssClass="btn-eliminar text-decoration-none mt-5 mt-lg-0" Visible="false" OnClick="btnEliminar_Click" />
            </div>
        </div>
        <div class="row mt-5">
            <div class="col-12">
                <div class="mb-1">
                    <asp:Label runat="server" for="txtId" class="form-label" Visible="false" ID="lblId">Id:</asp:Label>
                    <asp:TextBox runat="server" ID="txtId" CssClass="form-control" Visible="false"></asp:TextBox>
                </div>
            </div>
            <div class="col-12 col-lg-6">
                <div class="mb-3">
                    <label for="txtNombreCompleto" class="form-label">Nombre completo: </label>
                    <asp:TextBox runat="server" ID="txtNombreCompleto" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtNombreCompleto" runat="server" ID="reqName" CssClass="text-danger" Text="* Campo obligatorio"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegExpNombre" runat="server" ErrorMessage="* maximo 50 caracteres - minimo 3 caracteres." ControlToValidate="txtNombreCompleto" CssClass="text-danger" ValidationExpression="[a-zA-Z ]{3,50}$"></asp:RegularExpressionValidator>

                </div>
                <div class="mb-1">
                    <label for="txtedad" class="form-label">Edad: </label>
                    <asp:TextBox runat="server" ID="txtEdad" TextMode="Number" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtEdad" runat="server" ID="reqEdad" Text="* Campo obligatorio" CssClass="text-danger"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RangeValidator runat="server" ID="rangEdad" ControlToValidate="txtEdad" Type="Integer" MinimumValue="3" MaximumValue="110" CssClass="text-danger" Text="* Valor permitido entre 3 y 100 años"></asp:RangeValidator>
                </div>
                <div class="mb-5 mb-lg-3">
                    <label for="ddlGenero" class="form-label">Genero: </label>
                    <asp:DropDownList ID="ddlGenero" CssClass="form-select" runat="server"></asp:DropDownList>
                </div>
            </div>
            <div class="col-12 col-lg-6">
                <div class="mb-3 ">
                    <label for="txtEmail" class="form-label">Email: </label>
                    <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator runat="server" ID="rexEmail" ControlToValidate="txtEmail" ValidationExpression="[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?" CssClass="text-danger" ErrorMessage="* Formato de mail no valido."></asp:RegularExpressionValidator>
                </div>
                <div class="mb-3">
                    <label for="txtCelular" class="form-label">Celular: </label>
                    <asp:TextBox runat="server" ID="txtCelular" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtCelular" runat="server" ID="reqCelular" Text="* Campo obligatorio" CssClass="text-danger"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ControlToValidate="txtCelular" runat="server" ID="rexCelular" CssClass="text-danger" ErrorMessage="* Numero invalido" ValidationExpression="^[0-9]{8,12}$"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-outline mt-4 mt-lg-0 mb-5 d-flex flex-column flex-lg-row justify-content-lg-end">
                <asp:Button runat="server" ID="btnCrear" CssClass="btn-skin mb-5" Text="Crear" OnClick="btnCrear_Click" />
            </div>
        </div>
    </div>
</asp:Content>
