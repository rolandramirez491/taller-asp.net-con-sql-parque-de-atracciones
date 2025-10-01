<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Atracciones.aspx.cs" Inherits="capaPresentacion.Atracciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar Atraccion" OnClick="btnBuscar_Click" />

            <asp:Label ID="lblcheck" runat="server" Text=" "></asp:Label>
            <asp:DropDownList ID="ddlAtracciones" runat="server"  AutoPostBack="true" OnSelectedIndexChanged="ddlAtracciones_SelectedIndexChanged" ></asp:DropDownList>
            <asp:Button ID="btnActualizar" runat="server" Text="Actulizar Atraccion" Visible="False" OnClick="btnActualizar_Click" />
            <asp:Button ID="btnAtras" runat="server" Text="Atras" OnClick="btnAtras_Click" />

            <asp:GridView ID="dgvAtracciones" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
