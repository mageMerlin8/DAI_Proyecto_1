<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.master" AutoEventWireup="true" CodeFile="pagHistorial.aspx.cs" Inherits="pagInicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Historial de Compras"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Seleccione una fecha de inicio: "></asp:Label>
    <asp:Calendar ID="calIni" runat="server" SelectedDate="2017-12-01"></asp:Calendar>
    <asp:Label ID="Label3" runat="server" Text="Seleccione un fecha final:"></asp:Label>
    <br />
    <asp:Calendar ID="calFin" runat="server"></asp:Calendar>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Compras:"></asp:Label>
    <br />
    <asp:GridView ID="gridCompras" runat="server">
        <Columns>

            <asp:TemplateField HeaderText="Seleccione una compra">
            <ItemTemplate>
            <asp:Button ID="Button1" runat="server" Text="Seleccionar" 
            OnClick="compraSeleccionada" />
            </ItemTemplate>
            </asp:TemplateField>
            
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Canciones compradas:"></asp:Label>
    <br />
    <asp:GridView ID="gridCanciones" runat="server">
    </asp:GridView>
</asp:Content>

