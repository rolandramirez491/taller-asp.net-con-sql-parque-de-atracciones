<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionJuego.aspx.cs" Inherits="capaPresentacion.GestionJuego" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCodJ" runat="server" Text="Codigo De Juego"></asp:Label>
            <asp:TextBox ID="txtCodJ" runat="server"></asp:TextBox>
            <asp:Label ID="lblNombreJ" runat="server" Text="Nombre Del Juego"></asp:Label>
            <asp:TextBox ID="txtNombreJ" runat="server"></asp:TextBox>
            <asp:Label ID="lblDuracion" runat="server" Text="Duracion Del Juego"></asp:Label>
            <asp:TextBox ID="txtDuracion" runat="server"></asp:TextBox>
            <asp:Label ID="lblCategoria" runat="server" Text="Categoria"></asp:Label>
            <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
            <asp:Button ID="btnGuardarJuego" runat="server" Text="Guardar Nuevo Juego" OnClick="btnGuardarJuego_Click" />
            <asp:Label ID="lblCheck" runat="server" Text=" "></asp:Label>

            <%--<asp:GridView ID="dgvBuscar" runat="server"></asp:GridView>--%>

            <asp:Button ID="btnAtras" runat="server" Text="Atras" OnClick="btnAtras_Click" enable="false"/>
            <asp:Label ID="lblExito" runat="server" Text=" "></asp:Label>
        </div>
    </form>
</body>
</html>
