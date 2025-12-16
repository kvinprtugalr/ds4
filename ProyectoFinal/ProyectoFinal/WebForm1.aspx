<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ProyectoFinal.WebForm1" %>

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
            <div class="logo">AnimeWorld</div>

            <div class="search-container">
                <asp:TextBox ID="txtBuscar" runat="server" placeholder="Buscar anime..." CssClass="search-input" />

                <asp:Button ID="btnBuscar" runat="server" Text="🔍" CssClass="search-btn" OnClick="btnBuscar_Click" />
            </div>

            <a href="WebForm3.aspx" class="list-btn">Mi Lista</a>

        </div>

        <!-- CARRUSEL PRINCIPAL DINÁMICO -->
        

        <asp:HiddenField ID="hfCarouselData" runat="server" />

        <div class="hero-slider">
            <div id="heroItem" class="hero-item">
                <div class="hero-content">
                    <h1 id="heroTitle" class="hero-title"></h1>
                    <a id="heroLink" class="hero-btn" href="#">Ver ahora</a>
                </div>
                <button type="button" class="arrow-btn" onclick="nextSlide()">›</button>
            </div>
        </div>


        <!-- RECOMENDADOS -->
        
       <h2 class="section-title">Recomendados</h2>

        <div class="grid-recomendados">
            <asp:Repeater ID="repRecommended" runat="server">
                <ItemTemplate>
                    <a class="anime-link" href='WebForm2.aspx?title=<%# Eval("title") %>'>
                        <div class="anime-card">
                            <img src='<%# Eval("imageMedium") %>' alt='<%# Eval("title") %>' />
                            <p class="anime-name"><%# Eval("title") %></p>
                        </div>
                    </a>
                </ItemTemplate>
            </asp:Repeater>

        </div>





         

        <script>

            let heroData = [];

            window.onload = function () {
                // Obtener JSON del HiddenField
                const raw = document.getElementById("<%=hfCarouselData.ClientID %>").value;

                if (raw) {
                    heroData = JSON.parse(raw);
                    renderSlide();
                }
            };

            let index = 0;

            function renderSlide() {
                const item = heroData[index];

                if (!item) return;

                document.getElementById("heroItem").style.backgroundImage =
                    `url('${item.imageLarge}')`;

                document.getElementById("heroTitle").textContent = item.title;

                const link = document.getElementById("heroLink");
                link.href = `WebForm2.aspx?title=${encodeURIComponent(item.title)}`;
            }

            function nextSlide() {
                index = (index + 1) % heroData.length;
                renderSlide();
            }

        </script>



    </form>
</body>
</html>
