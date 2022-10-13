<%@ Page Title="" Language="C#" MasterPageFile="~/Administracion/Interno.Master" AutoEventWireup="true" CodeBehind="Horarios.aspx.cs" Inherits="Web.Horarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
    <div class="container">
        <asp:UpdatePanel runat="server" ID="updatePanel1">
            <ContentTemplate>
                <div class="row">
                    <div class="col-lg-6 col- mt-3">
                        <h3 class="text-center text-lg-start">Filtrar tratamiento:</h3>
                        <asp:DropDownList runat="server" ID="ddlTratamiento" CssClass="form-select" OnSelectedIndexChanged="ddlTratamiento_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <div class="table-responsive">

                            <asp:GridView ID="dgvHorario" runat="server" CssClass="table-responsive table table-condensed table-hover mt-5 mb-5 border-0" HeaderStyle-CssClass="text-letra bg-table-header text-uppercase" RowStyle-CssClass="table-light text-letra" DataKeyNames="Id" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvHorario_SelectedIndexChanged" OnPageIndexChanging="dgvHorario_PageIndexChanging" AllowPaging="true" PageSize="10" FooterStyle-CssClass="text-decoration-none">
                                <Columns>
                                    <asp:BoundField HeaderText="Nombre y apellido" DataField="Paciente" />
                                    <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
                                    <asp:BoundField HeaderText="Horario" DataField="Hora" />
                                    <asp:BoundField HeaderText="Tratamiento" DataField="Tratamiento" />
                                    <asp:CommandField HeaderText="Detalle" ShowSelectButton="true" SelectText="Ver más" ControlStyle-CssClass="text-decoration-none btn-ver" />
                                </Columns>
                            </asp:GridView>

                        </div>
                    </div>
                </div>
                <%if (vacio == true)
                    { %>
                <div class="row mt-5">
                    <div class="col">
                        <h2 class="text-center"><i class="bi bi-emoji-frown-fill"></i> No tienes turnos de esta categoría.</h2>
                    </div>
                </div>
                <%} %>
            </ContentTemplate>
        </asp:UpdatePanel>

        <div class="row d-flex flex-columns">
            <div class="col">
                <div class="d-flex flex-column flex-lg-row justify-content-lg-evenly mt-5 mb-5">
                    <a href="FormularioTurno.aspx" class="btn-skin text-decoration-none"><i class="bi bi-clipboard-plus"></i>
                        Crear Turno</a>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
