<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ProyectoFinal.WebForm2" Async="true"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>AnimeWorld</title>

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

        <main>
            <div class="main-content">
                <div class="container">
                    <!-- Título -->
                    <h1 class="anime-title">
                        <asp:Literal ID="ltTitle" runat="server" />
                    </h1>

                    <!-- Imagen -->
                    <asp:Image ID="imgAnime" runat="server" CssClass="anime-image" ImageUrl="ruta_imagen.jpg" AlternateText="Anime" />

                    <!-- Descripción -->
                    <div class="anime-description">
                        <asp:Literal ID="ltSynopsis" runat="server"></asp:Literal>
                    </div>



                    <!-- Detalles: Género, Episodios, Estado -->
                    <div class="anime-details">
                        <asp:Literal ID="ltGenre" runat="server"></asp:Literal>
                    </div>



                        <!-- Dropdown y botones -->
                        <div class="controls">
                            <!-- Label que muestra el estado actual del anime -->
                            <asp:Label ID="lblEstadoAnime" runat="server" CssClass="anime-status"></asp:Label>

                            <!-- Dropdown para el estado personal -->
                            <asp:DropDownList ID="ddlMiEstado" runat="server" CssClass="dropdown-estado" AutoPostBack="true" OnSelectedIndexChanged="ddlMiEstado_SelectedIndexChanged">
                                <asp:ListItem Text="Pendiente" Value="Pendiente"></asp:ListItem>
                                <asp:ListItem Text="Visto" Value="Visto"></asp:ListItem>                                
                                <asp:ListItem Text="Viendo" Value="Viendo"></asp:ListItem>
                            </asp:DropDownList>


                            <!-- Mensaje de confirmación -->
                            <asp:Label ID="lblMensaje" runat="server" CssClass="mensaje"></asp:Label>


                            

                            <!-- Botones de lista -->
                            <asp:Button ID="btnAgregarLista" runat="server" Text="Agregar a mi lista" OnClick="btnAgregarLista_Click" CssClass="btn-lista" />


                            <asp:Button ID="btnEliminarLista" runat="server" Text="Eliminar de mi lista" OnClick="btnEliminarLista_Click" CssClass="btn-lista" />

                        </div>

                </div>



            <asp:HyperLink ID="hlVolver" runat="server" NavigateUrl="~/WebForm1.aspx">← Volver</asp:HyperLink>
            </div>
        </main>
    </form>
</body>
</html>
