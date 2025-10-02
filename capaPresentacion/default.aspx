<%@ Page Title="Taller Atracciones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="capaPresentacion._default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnGuardarA" runat="server" Text="Guardar o Buscar Atraccion" OnClick="btnGuardarA_Click" CssClass="btn" />
    <asp:Label ID="lblcheck" runat="server" Text=" "></asp:Label>
    <asp:Button ID="btnGestionJuegos" runat="server" Text="Gestion De Juegos" OnClick="btnGestionJuegos_Click" CssClass="btn" />
    <asp:Button ID="btnSesiones" runat="server" Text="Registro De Sesiones De Juego" OnClick="btnSesiones_Click" CssClass="btn" />
</asp:Content>
