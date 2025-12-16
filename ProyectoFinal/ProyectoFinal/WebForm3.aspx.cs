using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Models.WS;
using ProyectoFinal.Helpers;


namespace ProyectoFinal
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        

        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var helper = new FavoritosHelper();
                var favoritos = await helper.CargarFavoritosAsync(1); // userId = 1
                repFavoritos.DataSource = favoritos;
                repFavoritos.DataBind();
            }
        }




        protected async void btnEliminar_Command(object sender, CommandEventArgs e)
        {
            if (int.TryParse(e.CommandArgument?.ToString(), out int favoritoId))
            {
                var helper = new FavoritosHelper();
                bool ok = await helper.EliminarFavoritoAsync(favoritoId);
                if (ok)
                {
                    var favoritos = await helper.CargarFavoritosAsync(1);
                    repFavoritos.DataSource = favoritos;
                    repFavoritos.DataBind();
                }
            }
        }


        // Clase simplificada para el Repeater
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


        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            Response.Redirect($"WebForm2.aspx?title={HttpUtility.UrlEncode(busqueda)}");
        }

        protected void btnMiLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }


    }
}