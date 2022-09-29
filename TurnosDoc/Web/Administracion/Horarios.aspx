<%@ Page Title="" Language="C#" MasterPageFile="~/Administracion/Interno.Master" AutoEventWireup="true" CodeBehind="Horarios.aspx.cs" Inherits="Web.Horarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col">
                <asp:GridView ID="dgvHorario" runat="server" CssClass="table table-hover table-active mt-5" DataKeyNames="Id" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvHorario_SelectedIndexChanged" OnPageIndexChanging="dgvHorario_PageIndexChanging" AllowPaging="true" PageSize="10" HeaderStyle-CssClass="table-dark" RowStyle-CssClass="table-light">
                    <Columns>
                        <asp:BoundField HeaderText="Nombre y apellido" DataField="Paciente" />
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                        <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
                        <asp:BoundField HeaderText="Horario" DataField="Hora" />
                        <asp:CommandField HeaderText="Detalle" ShowSelectButton="true" SelectText="Ver más" ControlStyle-CssClass="text-decoration-none btn-ver" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <div class="row d-flex flex-columns">
            <div class="col">
                <div class="d-flex flex-column flex-lg-row justify-content-lg-evenly">
                    <a href="Paciente.aspx" class="btn-skin text-decoration-none"><i class="bi bi-clipboard-plus"></i>
 Crear Turno</a>
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>
