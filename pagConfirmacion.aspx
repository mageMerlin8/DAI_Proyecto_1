<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.master" AutoEventWireup="true" CodeFile="pagConfirmacion.aspx.cs" Inherits="pagConfirmacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label2" runat="server" Text="Confirme su compra"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Carrito de compras:"></asp:Label>
    <asp:GridView ID="gridCompras" runat="server">
    </asp:GridView>
    <br />
    <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar Compra" OnClick="btnConfirmar_Click" />
    </asp:Content>