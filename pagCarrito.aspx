<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.master" AutoEventWireup="true" CodeFile="pagCarrito.aspx.cs" Inherits="pagCarrito" %>
<%@ MasterType VirtualPath="~/navbar.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="gridCanciones" runat="server" HorizontalAlign="Center" Width="80%">
    </asp:GridView>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Borrar" />
    <br />
    <asp:Button ID="Button2" runat="server" Text="Button" />
</asp:Content>
