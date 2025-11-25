<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio203.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>Productos</title>
</head>

<body>
<form id="form1" runat="server">

    <!-- Barra de botones -->
    <div style="padding:5px; display:flex; align-items:center; gap:10px;">
        <asp:ImageButton ID="tsbNuevo" runat="server" ImageUrl="~/iconos/nuevo.png" Width="24px" Height="24px" OnClick="tsbNuevo_Click" />
        <asp:ImageButton ID="tsbGuardar" runat="server" ImageUrl="~/iconos/guardar.png" Width="24px" Height="24px" OnClick="tsbGuardar_Click"/>
        <asp:ImageButton ID="tsbCancelar" runat="server" ImageUrl="~/iconos/cancelar.png" Width="24px" Height="24px" OnClick="tsbCancelar_Click" />
        <asp:ImageButton ID="tsbEliminar" runat="server" ImageUrl="~/iconos/eliminar.png" Width="24px" Height="24px" OnClick="tsbEliminar_Click" />

        <asp:Label ID="lblBuscarId" runat="server" Text="Buscar por id:" style="margin-left:20px;"></asp:Label>
        <asp:TextBox ID="tstId" runat="server" Width="150"></asp:TextBox>
        <asp:ImageButton ID="tsbBuscar" runat="server" ImageUrl="~/iconos/buscar.png" Width="24px" Height="24px" OnClick="tsbBuscar_Click" />
    </div>

    <br />

    
    <!-- Fila Id y Nombre -->
    <div style="display:flex; gap:80px; margin-bottom:5px; width:600px;">
        <div>
            <asp:Label ID="lblId" runat="server" Text="Id"></asp:Label><br />
            <asp:TextBox ID="txtId" runat="server" Width="60"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label><br />
            <asp:TextBox ID="txtNombre" runat="server" Width="300"></asp:TextBox>
        </div>
    </div>


    <!-- Fila Precio y Stock -->
    <div style="display:flex; gap:20px; margin-bottom:5px; width:600px;"">
        <div>
            <asp:Label ID="lblPrecio" runat="server" Text="Precio"></asp:Label><br />
            <asp:TextBox ID="txtPrecio" runat="server" Width="120"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblStock" runat="server" Text="Stock"></asp:Label><br />
            <asp:TextBox ID="txtStock" runat="server" Width="120"></asp:TextBox>
        </div>
    </div>      


    <!-- Botón salir -->
    <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click"
                Style="width:100px; height:40px; font-size:18px;" />

    <p>
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </p>

</form>
</body>
</html>

