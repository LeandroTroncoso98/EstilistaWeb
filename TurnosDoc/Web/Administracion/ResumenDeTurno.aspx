<%@ Page Title="" Language="C#" MasterPageFile="~/Administracion/Interno.Master" AutoEventWireup="true" CodeBehind="ResumenDeTurno.aspx.cs" Inherits="Web.Administracion.ResumenDeTurno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" ID="SriptManager1"></asp:ScriptManager>
    <div class="container">
        <div class="row">
            <div class="col-12">
                <div class="form-outline mt-4 mt-lg-4 mb-5 d-flex flex-column flex-lg-row justify-content-lg-start">
                    <a href="Horarios.aspx" class="btn-skin text-decoration-none"><i class="bi bi-backspace"></i>Regresar</a>
                </div>
            </div>
            <div class="col-12 col-lg-3 mt-5">
                <h2 class="mb-3 label-sesion text-center text-lg-start">Datos del turno: </h2>
                <asp:Label runat="server" ID="lblNombreCompleto" CssClass="text-letra mb-3" Text="Paciente: "></asp:Label>
                <br />
                <asp:Label runat="server" ID="lblEdad" CssClass="text-letra mb-3 w-100" Text="Edad : "></asp:Label>
                <br />
                <asp:Label runat="server" ID="lblCelular" CssClass="text-letra mb- w-100" Text="Celular: "></asp:Label>
                <br />
                <asp:Label runat="server" ID="lblSexo" CssClass="text-letra mb-3 w-100" Text="Genero: "></asp:Label>
                <br />
                <asp:Label runat="server" ID="lblFecha" CssClass="text-letra mb-3 w-100" Text="Fecha: "></asp:Label>
                <br />
                <asp:Label runat="server" ID="lblHorario" CssClass="text-letra mb-3 w-100" Text="Horario: "></asp:Label>
                <br />
                <asp:Label runat="server" ID="lblTratamiento" CssClass="text-letra mb-3 w-100" Text="Tratamiento: "></asp:Label>
                <div class="form-outline mt-4 mb-3 d-flex flex-column flex-lg-row justify-content-lg-start">
                    <asp:LinkButton runat="server" ID="btnWAppp" CssClass="btn-WhatsApp text-decoration-none" Text="<i class='bi bi-whatsapp'></i> WhatsApp" OnClick="btnWAppp_Click"></asp:LinkButton>
                </div>
                <div class="form-outline mt-4 mb-3 d-flex flex-column flex-lg-row justify-content-lg-start">
                    <asp:LinkButton runat="server" ID="btnModificarTurno" CssClass="btn-skin text-decoration-none" Text="<i class='bi bi-pencil-square'> Editar Turno</i>" OnClick="btnModificarTurno_Click"></asp:LinkButton>
                </div>
                <asp:UpdatePanel runat="server" ID="UpdatePanel1">
                    <ContentTemplate>
                        <div class="form-outline mt-5 d-flex flex-column flex-lg-row justify-content-lg-start">
                            <asp:CheckBox runat="server" ID="checkEliminar" Text=" ¿Deseas eliminar el turno?" CssClass=" mb-4 text-center" AutoPostBack="true" />
                        </div>
                        <%if (checkeo)
                            { %>
                        <div class="form-outline mt-2 mb-5 d-flex flex-column flex-lg-row justify-content-lg-start">
                            <asp:LinkButton runat="server" CssClass="btn-eliminar text-decoration-none" ID="btnEliminar" Text="<i class='bi bi-trash3-fill'> Eliminar</i>" OnClick="btnEliminar_Click" />
                        </div>
                        <%} %>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div class="col-12 col-lg-9 mt-lg-5 mt-0">
                <h2 class="mb-3 label-sesion text-center">Descripción del turno:</h2>
                <asp:TextBox runat="server" ID="txtDescripcion" TextMode="MultiLine" Rows="9" CssClass="form-control"></asp:TextBox>
                <div class="form-outline mt-4 mb-5 d-flex flex-column flex-lg-row justify-content-lg-end">
                    <asp:LinkButton runat="server" ID="btnAgregarDesc" CssClass="btn-skin text-decoration-none" OnClick="btnAgregarDesc_Click" Text="<i class='bi bi-plus-square'> Agregar Descripcion</i>"></asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
