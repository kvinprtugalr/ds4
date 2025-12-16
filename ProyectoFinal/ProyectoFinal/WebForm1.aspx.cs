using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;
using API.Models;       // Para AnimeItem
using API.Models.WS;

namespace ProyectoFinal
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCarousel();
                LoadRecommended();
            }

        }

        

        private AnimeReply GetAnimesFromJikan(string[] titles)
        {
            string url = "https://localhost:44369/api/anime/GetAnimes";

            if (titles != null && titles.Length > 0)
            {
                string[] encoded = titles
                    .Select(t => "titles=" + HttpUtility.UrlEncode(t))
                    .ToArray();

                url += "?" + string.Join("&", encoded);
            }

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    string json = reader.ReadToEnd();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<AnimeReply>(json);
                }
            }
            catch
            {
                return null;
            }
        }

        



        private void LoadCarousel()
        {
            string[] carouselTitles =
            {
                "Naruto",
                "Bleach",
                "One Piece",
                "Demon Slayer",
                "Jujutsu Kaisen"
            };

            var reply = GetAnimesFromJikan(carouselTitles);

            if (reply != null && reply.data != null)
            {
                hfCarouselData.Value =
                    Newtonsoft.Json.JsonConvert.SerializeObject(reply.data);
            }
        }

        private void LoadRecommended()
        {
            string[] recommendedTitles =
            {
                "Fairy Tail", "Chainsaw Man", "Death Note", "Blue Exorcist",
                "Hunter x Hunter", "Sword Art Online", "Tokyo Ghoul",
                "Mob Psycho 100", "Bleach", "Black Clover", "Attack on Titan",
                "Fate Zero", "Vinland Saga", "Re:Zero", "Overlord", "Fire Force"
            };

            var reply = GetAnimesFromJikan(recommendedTitles);

            if (reply != null && reply.data != null)
            {
                // ENLAZAR AL REPEATER
                repRecommended.DataSource = reply.data;
                repRecommended.DataBind();
            }

            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text; // ahora funciona
            Response.Redirect($"WebForm2.aspx?title={HttpUtility.UrlEncode(busqueda)}");
        }

        protected void btnMiLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }











    }
}