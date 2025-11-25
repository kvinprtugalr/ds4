using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio202
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtN.Text);


            // Aquí vamos a construir la tabla HTML
            string html = "<table border='1' cellspacing='0' cellpadding='5'>";

            for (int fila = 0; fila < N; fila++)
            {
                html += "<tr>";

                for (int col = 0; col < N; col++)
                {
                    // Condición para la diagonal inversa:
                    int valor = (fila + col == N - 1) ? 1 : 0;

                    html += $"<td>{valor}</td>";
                }

                html += "</tr>";
            }

            html += "</table>";

            // Mostramos la tabla en pantalla
            litMatriz.Text = html;
        }
    }
}