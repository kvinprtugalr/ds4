using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio154
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblResultado.Text = "";
            }

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNumUno.Text);
            int num2 = int.Parse(txtNumDos.Text);

            int suma = num1 + num2;

            lblResultado.Text = suma.ToString();
        }
    }
}