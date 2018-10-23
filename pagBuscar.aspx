<%@ Page Title="" Language="C#" MasterPageFile="~/navbar_heredada.master" AutoEventWireup="true" CodeFile="pagBuscar.aspx.cs" Inherits="pagInicio" %>

   
<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:Label ID="Label1" runat="server" Text="Buscar:"></asp:Label>
    <asp:TextBox ID="txtBusqueda" runat="server"></asp:TextBox>
    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Button" />
</asp:Content>

