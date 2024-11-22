using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio202
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtN.Text, out n) && n > 0)
            {
                string matriz = "<table border='1' style='border-collapse: collapse;'>";
                for (int i = 0; i < n; i++)
                {
                    matriz += "<tr>";
                    for (int j = 0; j < n; j++)
                    {
                        // Si está en la diagonal inversa, escribe 1; de lo contrario, 0
                        matriz += $"<td style='padding: 5px; text-align: center;'>{(j == n - i - 1 ? 1 : 0)}</td>";
                    }
                    matriz += "</tr>";
                }
                matriz += "</table>";
                litMatriz.Text = matriz;
            }
            else
            {
                litMatriz.Text = "<p style='color:red;'>Por favor, ingrese un número válido mayor a 0.</p>";
            }
        }

    }

}