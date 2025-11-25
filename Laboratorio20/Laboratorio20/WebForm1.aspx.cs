using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio20
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(TextBox1.Text);

            ListBox1.Items.Clear(); // Limpia antes de agregar

            for (int i = 1; i <= 25; i++)
            {
                int resultado = numero * i;
                ListBox1.Items.Add($"{numero} x {i} = {resultado}");
            }
        }
    }
}