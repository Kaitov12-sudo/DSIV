using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio203
{
    public partial class _Default : Page
    {
        string connectionString = @"Server=.\sqlexpress;Database=productos;Trusted_Connection=True;";
        bool nuevo = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Laptops", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvProductos.DataSource = dt;
                gvProductos.DataBind();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            nuevo = true;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd;

                if (nuevo)
                {
                    cmd = new SqlCommand("INSERT INTO Laptops (Nombre, Precio, Stock) VALUES (@Nombre, @Precio, @Stock)", conn);
                }
                else
                {
                    cmd = new SqlCommand("UPDATE Laptops SET Nombre=@Nombre, Precio=@Precio, Stock=@Stock WHERE Id=@Id", conn);
                    cmd.Parameters.AddWithValue("@Id", txtId.Text);
                }

                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                cmd.Parameters.AddWithValue("@Stock", txtStock.Text);
                cmd.ExecuteNonQuery();
            }

            CargarProductos();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Laptops WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.ExecuteNonQuery();
            }

            CargarProductos();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Laptops WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNombre.Text = reader["Nombre"].ToString();
                    txtPrecio.Text = reader["Precio"].ToString();
                    txtStock.Text = reader["Stock"].ToString();
                    nuevo = false;
                }
            }
        }
    }
}