using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MostrarPreguntas();
            }
        }

        private void MostrarPreguntas()
        {
            string conexion = ConfigurationManager.ConnectionStrings["ConexionKEVINPORTUGAL"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conexion))
            {
                string consulta = @"SELECT p.TextoPregunta, r.TextoRespuesta 
                            FROM KP_Preguntas p 
                            LEFT JOIN KP_Respuestas r ON p.PreguntaID = r.PreguntaID";

                SqlCommand cmd = new SqlCommand(consulta, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                string html = "<ul>";

                while (reader.Read())
                {
                    html += $"<li><b>Pregunta:</b> {reader["TextoPregunta"]} <br/><b>Respuesta:</b> {reader["TextoRespuesta"]}</li><br/>";
                }

                html += "</ul>";
                ltPreguntas.Text = html;
            }
        }


    }
}