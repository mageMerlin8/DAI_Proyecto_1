<%@ Page Title="" Language="C#" MasterPageFile="~/navbar_botones.master" AutoEventWireup="true" CodeFile="pagBuscar.aspx.cs" Inherits="pagInicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Buscar:"></asp:Label>
    <asp:TextBox ID="txtBusqueda" runat="server"></asp:TextBox>
    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Button" />
</asp:Content>

