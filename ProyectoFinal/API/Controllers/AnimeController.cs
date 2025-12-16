using API.Models;       // Para AnimeItem
using API.Models.WS;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Caching;
using System.Web.Http;

namespace API.Controllers
{
    public class AnimeController : ApiController
    {
        

        [HttpGet]
        
        public AnimeReply GetAnimes([FromUri] string[] titles) // ahora recibe un arreglo de nombres
        {
            if (titles == null || titles.Length == 0)
            {
                // opcional: si no envían títulos, puedes devolver algunos por defecto
                titles = new string[] { "Demon Slayer", "One Piece" };
            }

            var animeList = new List<AnimeItem>();

            foreach (var title in titles)
            {
                var anime = GetAnimeFromJikanCached(title);

                if (anime != null)
                    animeList.Add(anime);

                Thread.Sleep(1000);
            }


            return new AnimeReply
            {
                result = 200,
                message = "OK",
                data = animeList
            };
        }

        private AnimeItem GetAnimeFromJikan(string title)
        {
            try
            {
                string url = $"https://api.jikan.moe/v4/anime?q={title}&limit=1";

                using (var client = new WebClient())
                {
                    client.Headers.Add("Content-Type", "application/json");
                    string json = client.DownloadString(url);

                    var result = Newtonsoft.Json.Linq.JObject.Parse(json);

                    var data = result["data"]?.FirstOrDefault();
                    if (data == null) return null;

                    var images = data["images"]?["jpg"];

                    return new AnimeItem
                    {
                        AnimeId = (int)data["mal_id"],
                        title = (string)data["title"] ?? title,

                        imageSmall = (string)images?["small_image_url"],
                        imageMedium = (string)images?["image_url"],
                        imageLarge = (string)images?["large_image_url"],

                        synopsis = (string)data["synopsis"] ?? "Sin sinopsis disponible",

                        genre = string.Join(", ",
                            data["genres"]?.Select(g => (string)g["name"]) ?? new List<string>()),

                        episodes = data["episodes"]?.Type == Newtonsoft.Json.Linq.JTokenType.Integer
                           ? (int?)data["episodes"].Value<int>()
                           : null,

                        status = (string)data["status"] ?? "",
                        statusValue = ((string)data["status"])?.ToLower().Replace(" ", "_") ?? ""
                    };
                }
            }
            catch
            {
                return null;
            }
        }


        private AnimeItem GetAnimeFromJikanCached(string title)
        {
            string key = "anime_" + title.ToLower();

            // Intentar obtener desde caché
            var cached = HttpRuntime.Cache[key] as AnimeItem;
            if (cached != null)
                return cached;

            // Llamar a Jikan
            var item = GetAnimeFromJikan(title);

            // Guardar si vino bien
            if (item != null)
            {
                HttpRuntime.Cache.Insert(
                    key,
                    item,
                    null,
                    DateTime.Now.AddHours(6),
                    Cache.NoSlidingExpiration
                );
            }

            return item;
        }


       


    }
}
