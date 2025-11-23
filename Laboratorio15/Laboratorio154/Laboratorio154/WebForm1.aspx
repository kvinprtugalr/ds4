<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio154.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:TextBox ID="txtNumUno" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="+"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtNumDos" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnSumar" runat="server" OnClick="btnSumar_Click" Text="Sumar" />
        </p>
    </form>
</body>
</html>
