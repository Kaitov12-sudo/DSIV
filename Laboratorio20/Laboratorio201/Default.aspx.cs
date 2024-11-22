using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio201
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(txtNumero.Text, out numero))
            {
                string tabla = "<table border='1'>";
                for (int i = 1; i <= 25; i++)
                {
                    tabla += $"<tr><td>{numero} x {i}</td><td>{numero * i}</td></tr>";
                }
                tabla += "</table>";
                litTabla.Text = tabla;
            }
            else
            {
                litTabla.Text = "<p style='color:red;'>Por favor, ingrese un número válido.</p>";
            }
        }

    }
}