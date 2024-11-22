using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio171
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }


        private void BindGrid()
        {
            string connString = WebConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Usar el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("GetCategories", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                // Llenar el DataTable con los datos obtenidos
                da.Fill(dt);

                // Asignar el DataTable al GridView
                gvCategories.DataSource = dt;
                gvCategories.DataBind();
            }
        }


    }

}