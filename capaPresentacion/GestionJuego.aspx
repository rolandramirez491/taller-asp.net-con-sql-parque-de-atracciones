<%@ Page Title="Gestion de Juegos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionJuego.aspx.cs" Inherits="capaPresentacion.GestionJuego" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblCodJ" runat="server" Text="Codigo De Juego"></asp:Label>
    <asp:TextBox ID="txtCodJ" runat="server"></asp:TextBox>
    <asp:Label ID="lblNombreJ" runat="server" Text="Nombre Del Juego"></asp:Label>
    <asp:TextBox ID="txtNombreJ" runat="server"></asp:TextBox>
    <asp:Label ID="lblDuracion" runat="server" Text="Duracion Del Juego"></asp:Label>
    <asp:TextBox ID="txtDuracion" runat="server"></asp:TextBox>
    <asp:Label ID="lblCategoria" runat="server" Text="Categoria"></asp:Label>
    <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
    <asp:Button ID="btnGuardarJuego" runat="server" Text="Guardar Nuevo Juego" OnClick="btnGuardarJuego_Click" CssClass="btn" />
    <asp:Label ID="lblCheck" runat="server" Text=" "></asp:Label>
    <asp:Button ID="btnAtras" runat="server" Text="Atras" OnClick="btnAtras_Click" CssClass="btn" />
    <asp:Label ID="lblExito" runat="server" Text=" "></asp:Label>
</asp:Content>
