using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System;

namespace Laboratorio154
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Código para ejecutar cuando se cargue la página (si es necesario).
        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            // Variables para almacenar los números ingresados
            double number1, number2;

            // Validar que los valores ingresados sean números
            if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))
            {
                // Realizar la suma
                double result = number1 + number2;

                // Mostrar el resultado en el Label
                lblResult.Text = "El resultado es: " + result.ToString();
            }
            else
            {
                // Mensaje de error si los valores no son válidos
                lblResult.Text = "Por favor, ingrese números válidos.";
            }
        }
    }
}
