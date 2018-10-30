<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.master" AutoEventWireup="true" CodeFile="pagCompraExitosa.aspx.cs" Inherits="pagCompraExitosa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Felicidades, su compra fue exitosa"></asp:Label>

    <br />
    <br />
    <asp:GridView ID="gridCompra" runat="server">
    </asp:GridView>
    <asp:Label ID="lblTotal" runat="server" Text="Total: "></asp:Label>
    <br />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

