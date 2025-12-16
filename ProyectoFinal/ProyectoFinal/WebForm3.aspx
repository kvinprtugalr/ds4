<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="ProyectoFinal.WebForm3" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Mis Favoritos</title>
    <link rel="stylesheet" href="Styles.css" />
    
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <a href="WebForm1.aspx" class="logo-link">
                <div class="logo">AnimeWorld</div>
            </a>

            <div class="search-container">
                <asp:TextBox ID="txtBuscar" runat="server" placeholder="Buscar anime..." CssClass="search-input" />

                <asp:Button ID="btnBuscar" runat="server" Text="🔍" CssClass="search-btn" OnClick="btnBuscar_Click" />
            </div>

            <a href="WebForm3.aspx" class="list-btn">Mi Lista</a>

        </div>

        <h2 class="section-title">Mis Animes Favoritos</h2>

        <asp:Repeater ID="repFavoritos" runat="server">
            <ItemTemplate>
                <div class="favorito-item">
                    <!-- Envolver imagen y nombre en un enlace -->
                    <a href='WebForm2.aspx?title=<%# Eval("AnimeTitle") %>' style="display:flex; align-items:center; text-decoration:none;">
                        <img src='<%# Eval("AnimeImage") %>' alt='<%# Eval("AnimeTitle") %>' />
                        <div class="favorito-nombre"><%# Eval("AnimeTitle") %></div>
                    </a>

                    <!-- Botón Eliminar -->
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn-eliminar"
                                CommandArgument='<%# Eval("Id") %>' OnCommand="btnEliminar_Command" />
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </form>
</body>
</html>

