﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio161
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnMensaje_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "¡Hola, este es un mensaje desde el servidor!";
        }

    }
}