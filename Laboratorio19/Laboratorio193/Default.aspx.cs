using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio193
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)  // Evita doble ejecución
            {
                GetItems();
            }

        }



        private void GetItems()
        {
            var url = $"https://localhost:44314/api/values/2";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // mostrar resultado en pantalla (AGREGA UN LABEL EN EL ASPX)
                            lblResultado.Text = responseBody;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                lblResultado.Text = "Error al consumir API: " + ex.Message;

            }

        }
    }
}