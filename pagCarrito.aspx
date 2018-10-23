<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.master" AutoEventWireup="true" CodeFile="pagCarrito.aspx.cs" Inherits="pagInicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="gridCanciones" runat="server" HorizontalAlign="Center" Width="80%">
        <Columns>
            <asp:TemplateField HeaderText="Borrar">
                <EditItemTemplate>
                    <asp:CheckBox ID="chkBorrar" runat="server" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="chkBorrar" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnBorrar" runat="server" OnClick="btnBorrar_Click" Text="Eliminar canciones seleccionadas" />
    <br />
    <asp:Button ID="btnPagar" runat="server" OnClick="btnPagar_Click" Text="Proceder Al Pago" />
</asp:Content>

