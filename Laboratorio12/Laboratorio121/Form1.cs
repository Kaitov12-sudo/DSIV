using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de velocidad y tiempo
                double velocidad = double.Parse(textBox1.Text);
                double tiempo = double.Parse(textBox2.Text);

                // Calcular distancia
                double distancia = CalcularDistancia(velocidad, tiempo);

                // Mostrar resultado
                textBox3.Text = distancia.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private double CalcularDistancia(double velocidad, double tiempo)
        {
            return velocidad * tiempo;
        }
    }
    }

