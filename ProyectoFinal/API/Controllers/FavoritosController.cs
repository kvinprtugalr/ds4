using API.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class FavoritosController : ApiController
    {
        private string connectionString = "Server=.;Database=AnimeDB;Trusted_Connection=True;";

        // GET api/favoritos/{userId}
        [HttpGet]
        [Route("api/favoritos/{userId}")]
        public Reply GetFavoritos(int userId)
        {
            Reply oR = new Reply
            {
                result = 200,
                data = new List<FavoritoItem>()
            };

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand(
                    @"SELECT Id, AnimeId, AnimeTitle, AnimeImage, Estado
              FROM Favoritos
              WHERE UserId = @UserId", cn);

                cmd.Parameters.AddWithValue("@UserId", userId);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oR.data.Add(new FavoritoItem
                    {
                        Id = dr.GetInt32(0),
                        AnimeId = dr.GetInt32(1),
                        AnimeTitle = dr.GetString(2),
                        AnimeImage = dr.GetString(3),
                        Estado = dr.GetString(4)

                    });
                }
            }

            oR.message = "OK";
            return oR;
        }

        [HttpPost]
        [Route("api/favoritos/agregar")]
        public Reply AgregarFavorito([FromBody] FavoritoRequest model)
        {
            Reply oR = new Reply { result = 200 };

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Favoritos 
                      (UserId, AnimeId, AnimeTitle, AnimeImage, Estado)
                      VALUES 
                      (@UserId, @AnimeId, @AnimeTitle, @AnimeImage, @Estado)", cn);

                cmd.Parameters.AddWithValue("@UserId", model.UserId);
                cmd.Parameters.AddWithValue("@AnimeId", model.AnimeId);
                cmd.Parameters.AddWithValue("@AnimeTitle", model.AnimeTitle);
                cmd.Parameters.AddWithValue("@AnimeImage", model.AnimeImage);
                cmd.Parameters.AddWithValue("@Estado",
                    string.IsNullOrEmpty(model.Estado) ? "Pendiente" : model.Estado);

                cmd.ExecuteNonQuery();
            }

            oR.message = "Agregado correctamente";
            return oR;
        }



        // DELETE api/favoritos/eliminar/{userId}/{animeId}
        [HttpDelete]
        [Route("api/favoritos/eliminar/{favoritoId}")]
        public Reply EliminarFavorito(int favoritoId)
        {
            Reply oR = new Reply { result = 200 };

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Favoritos WHERE Id=@Id", cn);
                cmd.Parameters.AddWithValue("@Id", favoritoId);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            oR.message = "Eliminado";
            return oR;
        }

        // PUT api/favoritos/estado/{favoritoId}
        // PUT api/favoritos/estado
        [HttpPut]
        [Route("api/favoritos/estado")]
        public Reply ActualizarEstado([FromBody] FavoritoRequest model)
        {
            Reply oR = new Reply { result = 200 };

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Favoritos SET Estado=@Estado WHERE UserId=@UserId AND AnimeId=@AnimeId", cn);

                cmd.Parameters.AddWithValue("@Estado", model.Estado);
                cmd.Parameters.AddWithValue("@UserId", model.UserId);
                cmd.Parameters.AddWithValue("@AnimeId", model.AnimeId);

                cmd.ExecuteNonQuery();
            }

            oR.message = "Estado actualizado";
            return oR;
        }




        // Clases para serializar
        public class Reply
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

        public class FavoritoRequest
        {
            public int UserId { get; set; }
            public int AnimeId { get; set; }
            public string AnimeTitle { get; set; }
            public string AnimeImage { get; set; }
            public string Estado { get; set; }
        }

    }
}
