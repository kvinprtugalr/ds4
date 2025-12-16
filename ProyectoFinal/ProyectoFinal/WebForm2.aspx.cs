using API.Models;       // Para AnimeItem
using API.Models.WS;
using ProyectoFinal.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{

    public partial class WebForm2 : System.Web.UI.Page
    {
        private int userId = 1; // Cambiar según usuario actual

        
        private int animeId; // Se asigna según el anime que se está viendo
        
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string title = Request.QueryString["title"];
                if (!string.IsNullOrEmpty(title))
                {
                    var apiData = LlamarAPI(title);
                    var anime = apiData?.FirstOrDefault();
                    if (anime != null)
                    {
                        // Guardar AnimeId en ViewState
                        animeId = anime.AnimeId;
                        ViewState["AnimeId"] = anime.AnimeId;

                        ltTitle.Text = anime.title;
                        imgAnime.ImageUrl = anime.imageLarge;
                        imgAnime.AlternateText = anime.title;
                        ltSynopsis.Text = anime.synopsis;
                        ltGenre.Text = $@"
                    <div class='anime-detail'>Género: {anime.genre}</div>
                    <div class='anime-detail'>Episodios: {(anime.episodes.HasValue ? anime.episodes.Value.ToString() : "Desconocido")}</div>
                ";

                        switch (anime.status)
                        {
                            case "Finished Airing":
                                lblEstadoAnime.Text = "Finalizado"; break;
                            case "Currently Airing":
                                lblEstadoAnime.Text = "En emisión"; break;
                            case "Not yet aired":
                                lblEstadoAnime.Text = "Próximo"; break;
                            default:
                                lblEstadoAnime.Text = anime.status; break;
                        }

                        // Obtener favoritos usando el Helper
                        var helper = new FavoritosHelper();
                        var favoritos = await helper.CargarFavoritosAsync(1); // userId = 1
                        var favoritoExistente = favoritos.FirstOrDefault(f => f.AnimeId == anime.AnimeId);
                        if (favoritoExistente != null)
                        {
                            ViewState["FavoritoId"] = favoritoExistente.Id; // Guardar Id de la tabla Favoritos
                        }
                    }
                }
                else
                {
                    // Recuperar animeId en PostBack para usarlo en ddlMiEstado_SelectedIndexChanged
                    if (ViewState["AnimeId"] != null)
                    {
                        animeId = (int)ViewState["AnimeId"];
                    }
                }
            }
        }


        /// <summary>
        /// Llama a la API local y devuelve la lista de animes según el título
        /// </summary>
        private List<AnimeItem> LlamarAPI(string title)
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type", "application/json");

                // URL IGUAL QUE WEBFORM1
                string url = "https://localhost:44369/api/anime/GetAnimes";

                if (!string.IsNullOrEmpty(title))
                {
                    url += "?titles=" + HttpUtility.UrlEncode(title);
                }

                try
                {
                    string json = client.DownloadString(url);
                    var reply = Newtonsoft.Json.JsonConvert.DeserializeObject<AnimeReply>(json);
                    return reply?.data ?? new List<AnimeItem>();
                }
                catch
                {
                    return new List<AnimeItem>();
                }
            }
        }


        /// <summary>
        /// Cambio de estado desde el dropdown
        /// </summary>
        protected void btnCambiarEstado_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text; // ahora funciona
            Response.Redirect($"WebForm2.aspx?title={HttpUtility.UrlEncode(busqueda)}");
        }

        protected async void btnAgregarLista_Click(object sender, EventArgs e)
        {
            if (ViewState["AnimeId"] != null)
                animeId = (int)ViewState["AnimeId"];
            else
            {
                lblMensaje.Text = "Anime no identificado";
                return;
            }

            var favorito = new
            {
                UserId = userId,
                AnimeId = animeId,
                AnimeTitle = ltTitle.Text,
                AnimeImage = imgAnime.ImageUrl,
                Estado = "Pendiente"
            };

            using (HttpClient client = new HttpClient())
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(favorito);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:44369/api/favoritos/agregar", content);
                lblMensaje.Text = response.IsSuccessStatusCode ? "Anime agregado a tu lista" : "Error al agregar anime";
            }
        }








        protected async void btnEliminarLista_Click(object sender, EventArgs e)
        {
            // Recuperar animeId desde ViewState
            if (ViewState["AnimeId"] != null)
            {
                animeId = (int)ViewState["AnimeId"];
            }
            else
            {
                lblMensaje.Text = "No se pudo identificar el anime.";
                return;
            }

            var helper = new FavoritosHelper();
            var favoritos = await helper.CargarFavoritosAsync(userId);

            // Buscar favorito correcto por AnimeId
            var favorito = favoritos.FirstOrDefault(f => f.AnimeId == animeId);

            if (favorito == null)
            {
                lblMensaje.Text = "Anime no se encuentra en tu lista.";
                return;
            }

            bool ok = await helper.EliminarFavoritoAsync(favorito.Id);
            lblMensaje.Text = ok ? "Anime eliminado de tu lista" : "Error al eliminar anime";
        }



        protected async void ddlMiEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Recuperar animeId desde ViewState
            if (ViewState["AnimeId"] != null)
            {
                animeId = (int)ViewState["AnimeId"];
            }
            else
            {
                lblMensaje.Text = "No se pudo identificar el anime.";
                return;
            }

            // Crear payload con IDs correctos
            var payload = new
            {
                Estado = ddlMiEstado.SelectedValue,
                UserId = userId,
                AnimeId = animeId
            };

            using (HttpClient client = new HttpClient())
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await client.PutAsync("https://localhost:44369/api/favoritos/estado", content);

                lblMensaje.Text = response.IsSuccessStatusCode ? "Estado actualizado" : "Error al actualizar estado";
            }
        }













        protected void btnMiLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }



    }
}
