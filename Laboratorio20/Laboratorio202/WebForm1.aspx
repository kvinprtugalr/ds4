<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio202.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtN" runat="server"></asp:TextBox>
            <asp:Button ID="btnGenerar" runat="server" Text="Generar" OnClick="btnGenerar_Click" />

            <br /><br />

            <asp:Literal ID="litMatriz" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
