<%@ Page Title="Atracciones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Atracciones.aspx.cs" Inherits="capaPresentacion.Atracciones" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblCodA" runat="server" Text="Codigo de atraccion"></asp:Label>
    <asp:TextBox ID="txtCodA" runat="server"></asp:TextBox>
    <asp:Label ID="lblNomb" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtNombA" runat="server"></asp:TextBox>
    <asp:Label ID="lblPrecio" runat="server" Text="Precio"></asp:Label>
    <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
    <asp:Label ID="lblCapacidad" runat="server" Text="Capacidad"></asp:Label>
    <asp:TextBox ID="txtCapacidad" runat="server"></asp:TextBox>
    <asp:Button ID="btnGuardarA" runat="server" Text="Guardar Atraccion" OnClick="btnGuardarA_Click" CssClass="btn" />
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar Atraccion" OnClick="btnBuscar_Click" CssClass="btn" />
    <asp:Label ID="lblcheck" runat="server" Text=" "></asp:Label>
    <asp:DropDownList ID="ddlAtracciones" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlAtracciones_SelectedIndexChanged"></asp:DropDownList>
    <asp:Button ID="btnActualizar" runat="server" Text="Actulizar Atraccion" Visible="False" OnClick="btnActualizar_Click" CssClass="btn" />
    <asp:Button ID="btnAtras" runat="server" Text="Atras" OnClick="btnAtras_Click" CssClass="btn" />
    <asp:GridView ID="dgvAtracciones" runat="server"></asp:GridView>
</asp:Content>
