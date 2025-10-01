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
            <asp:Button ID="btnGuardarA" runat="server" Text="Guardar o Buscar Atraccion" OnClick="btnGuardarA_Click" />
            <asp:Label ID="lblcheck" runat="server" Text=" "></asp:Label>
            
            <asp:Button ID="btnGestionJuegos" runat="server" Text="Gestion De Juegos" OnClick="btnGestionJuegos_Click"  />
            <asp:Button ID="btnSesiones" runat="server" Text="Registro De Sesiones De Juego" OnClick="btnSesiones_Click"  />
        </div>
    </form>
</body>
</html>
