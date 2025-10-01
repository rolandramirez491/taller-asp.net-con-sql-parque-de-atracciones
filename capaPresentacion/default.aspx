<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="capaPresentacion._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>taller de chucho</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:Label ID="lblCodA" runat="server" Text="Codigo de atraccion"></asp:Label>
            <asp:TextBox ID="txtCodA" runat="server"></asp:TextBox>
            <asp:Label ID="lblNomb" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombA" runat="server"></asp:TextBox>
            <asp:Label ID="lblPrecio" runat="server" Text="Precio"></asp:Label>
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            <asp:Label ID="lblCapacidad" runat="server" Text="Capacidad"></asp:Label>
            <asp:TextBox ID="txtCapacidad" runat="server"></asp:TextBox>
            <asp:Button ID="btnGuardarA" runat="server" Text="Guardar Atraccion" OnClick="btnGuardarA_Click" />
            <asp:Label ID="lblcheck" runat="server" Text=" "></asp:Label>
            
            <asp:Button ID="btnGestionJuegos" runat="server" Text="Gestion De Juegos" OnClick="btnGestionJuegos_Click"  />
            <asp:Button ID="btnSesiones" runat="server" Text="Registro De Sesiones De Juego" OnClick="btnSesiones_Click"  />
        </div>
    </form>
</body>
</html>
