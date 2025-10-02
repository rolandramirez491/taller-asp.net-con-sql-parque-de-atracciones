<%@ Page Title="Gestion de Sesiones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionSesion.aspx.cs" Inherits="capaPresentacion.GestionSesion" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblIdSesion" runat="server" Text="Codigo De La Sesion"></asp:Label>
    <asp:TextBox ID="txtIdSesion" runat="server"></asp:TextBox>
    <asp:Label ID="lblCodA" runat="server" Text="Codigo De La Atraccion"></asp:Label>
    <asp:DropDownList ID="ddlCodA" runat="server"></asp:DropDownList>
    <asp:Label ID="lblCodJ" runat="server" Text="Codigo Del Juego"></asp:Label>
    <asp:DropDownList ID="ddlCodJ" runat="server"></asp:DropDownList>
    <asp:Label ID="lblNumZona" runat="server" Text="Numero De Zona"></asp:Label>
    <asp:TextBox ID="txtNumZona" runat="server"></asp:TextBox>
    <asp:Label ID="lblHora" runat="server" Text="Hora De Inicio"></asp:Label>
    <asp:TextBox ID="txtHora" runat="server"></asp:TextBox>
    <asp:Label ID="lblBoletos" runat="server" Text="Cantidad De Boletos Vendidos"></asp:Label>
    <asp:TextBox ID="txtBoletos" runat="server" OnTextChanged="txtBoletos_TextChanged"></asp:TextBox>
    <asp:Button ID="btnGuardarSesion" runat="server" Text="Guardar Sesion" OnClick="btnGuardarSesion_Click" CssClass="btn" />
    <asp:Button ID="btnAtras" runat="server" Text="Atras" OnClick="btnAtras_Click" CssClass="btn" />
    <asp:Label ID="lblCheck" runat="server" Text=" "></asp:Label>
    <asp:GridView ID="dgvAtracciones" runat="server"></asp:GridView>
    <asp:GridView ID="dgvJuegos" runat="server"></asp:GridView>
</asp:Content>
