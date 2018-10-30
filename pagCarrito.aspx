<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.master" AutoEventWireup="true" CodeFile="pagCarrito.aspx.cs" Inherits="pagCarrito" %>
<%@ MasterType VirtualPath="~/navbar.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Carrito Vacio"></asp:Label>
    <asp:GridView ID="gridCanciones" runat="server" HorizontalAlign="Center" Width="80%" OnRowCommand="gridCanciones_RowCommand">
        <Columns>
            <asp:ButtonField ButtonType="Button" ItemStyle-HorizontalAlign="Center" CommandName="Select" Text="Borrar del carrito" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="btnPagar" runat="server" Text="Pagar" OnClick="btnPagar_Clicked" />
</asp:Content>
