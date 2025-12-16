using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace ProyectoFinal.Helpers
{
    public class FavoritosHelper
    {
        private readonly string apiBase = "https://localhost:44369/api/favoritos";

        public async Task<List<FavoritoItem>> CargarFavoritosAsync(int userId)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"{apiBase}/{userId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var reply = JsonConvert.DeserializeObject<FavoritosReply>(json);
                    return reply?.data ?? new List<FavoritoItem>();
                }
                return new List<FavoritoItem>();
            }
        }

        public async Task<bool> EliminarFavoritoAsync(int favoritoId)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.DeleteAsync($"{apiBase}/eliminar/{favoritoId}");
                return response.IsSuccessStatusCode;
            }
        }
    }

    public class FavoritosReply
    {
        public int result { get; set; }
        public string message { get; set; }
        public List<FavoritoItem> data { get; set; }
    }

    public class FavoritoItem
    {
        public int Id { get; set; }
        public int AnimeId { get; set; }
        public string AnimeTitle { get; set; }
        public string AnimeImage { get; set; }
        public string Estado { get; set; }
    }
}