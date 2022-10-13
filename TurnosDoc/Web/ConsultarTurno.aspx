<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="ConsultarTurno.aspx.cs" Inherits="Web.ConsultarTurno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <asp:ScriptManager runat="server" ID="scriptManager1"></asp:ScriptManager>
        <div class="container" style="min-height: 60vh;">
            <div class="row mt-5">
                <div class="col-12">
                    <h2 class="text-center">Consultar turno</h2>
                    <h3 class="mt-5">Ingrese su email y brevemente le esta llegando su turno a su correo electronico</h3>
                </div>
                <asp:UpdatePanel runat="server" ID="UpdatePanel1">
                    <contenttemplate>
                        <div class="col-md-6 col-12 offset-md-3">
                            <asp:TextBox runat="server" ID="txtEmail" CssClass="mt-5 form-control"></asp:TextBox>
                        </div>
                        <%if (MailExitoso)
                            { %>
                        <div class="alert alert-warning mt-5 col-md-6 offset-md-3" role="alert">
                            <asp:Label runat="server" ID="lblMensaje"></asp:Label>
                        </div>
                        <%} %>
                        <div class="col-12 d-flex flex-column flex-lg-row justify-content-center">
                            <asp:LinkButton runat="server" ID="btnEmail" CssClass="btn-skin mt-5 mb-5 text-decoration-none" Text="Enviar Email" OnClick="btnEmail_Click"></asp:LinkButton>
                        </div>
                    </contenttemplate>
                </asp:UpdatePanel>
                <div class="col-12 mb-xxl-5">
                    <h5 class=" text-center label-sesion"><i class="bi bi-exclamation-octagon"></i>Sí usted no posee un turno o si tiene turno y no tiene registrado el mail, contactarse por <a href="https://wa.me/5491130720970" class="text-decoration-none bi-whatsapp label-sesion">Whatsapp</a>.</h5>
                </div>
            </div>
        </div>
</asp:Content>
