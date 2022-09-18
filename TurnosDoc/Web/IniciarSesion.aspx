<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="Web.IniciarSesion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="container h-custom">
            <div class="row d-flex justify-content-center mt-5 align-items-center h-100">
                <div class="col-md-9 col-lg-6 col-xl-5 mt-3">
                    <img src="img/Iniciar sesion alicia.png" alt="Iniciar sesion" class="img-fluid card-img-bottom" />
                </div>
                <div class="col-md-9 col-lg-6 col-xl-4 offset-xl-1">
                    <div class="divider d-flex align-items-center my-4">
                        <h2 class="text-center fw-bold mx-3 mb-0">Ingresa tu usuario para continuar</h2>
                    </div>
                    <div class="form-outline mb-4">


                        <label for="txtEmail" class="form-label">Correo electronico</label>
                        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control form-control-lg"></asp:TextBox>
                    </div>
                    <div class="form-outline mb-3">
                        <label for="txtPass" class="form-label">Contraseña</label>
                        <asp:TextBox runat="server" ID="txtPass" CssClass="form-control form-control-lg" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="form-outline mb-3">
                        <asp:Label runat="server" ID="lblUserDanger" CssClass="text-danger alert"></asp:Label>
                    </div>
                    <div class="form-outline mb-3 d-flex flex-column flex-lg-row justify-content-lg-end">
                        <asp:Button ID="btnIniciarSesion" runat="server" CssClass="btn-skin" Text="ingresar" OnClick="btnIniciarSesion_Click"/>
                    </div>                 
                </div>
            </div>
        </div>
    </section>
</asp:Content>
