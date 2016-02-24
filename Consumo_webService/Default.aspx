<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Consumo_webService._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="btnHolaMundo" runat="server" Text="Llamar ws hola mundo" OnClick="HolaMundo" />
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="lblHolaMundo" runat="server" Text=""></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="btnFecha" runat="server" Text="Llamar ws fecha" OnClick="ObtenerFecha" />
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="lblFecha" runat="server" Text=""></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox ID="txtSaludar" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="btnSaludarNombre" runat="server" Text="Llamar ws saludar" OnClick="Saludar" />
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="lblSaludar" runat="server" Text=""></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
