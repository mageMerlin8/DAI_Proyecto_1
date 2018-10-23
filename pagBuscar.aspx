<%@ Page Title="" Language="C#" MasterPageFile="~/navbar_heredada.master" AutoEventWireup="true" CodeFile="pagBuscar.aspx.cs" Inherits="pagInicio" %>

   
<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" Width="81px" />
    <br />
    <asp:RadioButton ID="rbCancion" runat="server" GroupName="radioGroup" Text="Cancion" />
    <br />
    <asp:RadioButton ID="rbArtista" runat="server" GroupName="radioGroup" Text="Artista" />
    <br />
</asp:Content>

