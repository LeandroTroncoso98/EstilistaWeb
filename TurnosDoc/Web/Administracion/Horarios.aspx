<%@ Page Title="" Language="C#" MasterPageFile="~/Administracion/Interno.Master" AutoEventWireup="true" CodeBehind="Horarios.aspx.cs" Inherits="Web.Horarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
    <div class="container">
        <div class="row">
            <div class="col">
                <div class="table-responsive">
                    <asp:UpdatePanel runat="server" ID="updatePanel1">
                        <ContentTemplate>
                            <asp:GridView ID="dgvHorario" runat="server" CssClass="table-responsive table table-condensed table-hover mt-5 mb-5 border-0" HeaderStyle-CssClass="text-letra bg-table-header text-uppercase" RowStyle-CssClass="table-light text-letra" DataKeyNames="Id" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvHorario_SelectedIndexChanged" OnPageIndexChanging="dgvHorario_PageIndexChanging" AllowPaging="true" PageSize="10" FooterStyle-CssClass="text-decoration-none">
                                <Columns>
                                    <asp:BoundField HeaderText="Nombre y apellido" DataField="Paciente" />
                                    <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
                                    <asp:BoundField HeaderText="Horario" DataField="Hora" />
                                    <asp:BoundField HeaderText="Tratamiento" DataField="Tratamiento" />
                                    <asp:CommandField HeaderText="Detalle" ShowSelectButton="true" SelectText="Ver más" ControlStyle-CssClass="text-decoration-none btn-ver" />
                                </Columns>
                            </asp:GridView>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
        <div class="row d-flex flex-columns">
            <div class="col">
                <div class="d-flex flex-column flex-lg-row justify-content-lg-evenly">
                    <a href="FormularioTurno.aspx" class="btn-skin text-decoration-none"><i class="bi bi-clipboard-plus"></i>
                        Crear Turno</a>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
