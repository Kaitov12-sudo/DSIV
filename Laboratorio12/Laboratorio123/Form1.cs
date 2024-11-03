using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los lados
                double ladoA = double.Parse(textBox1.Text);
                double ladoB = double.Parse(textBox2.Text);
                double ladoC = double.Parse(textBox3.Text);

                // Calcular el semiperímetro
                double semiperimetro = CalcularSemiperimetro(ladoA, ladoB, ladoC);

                // Mostrar el resultado en el TextBox4
                textBox4.Text = semiperimetro.ToString("F2");
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los lados
                double ladoA = double.Parse(textBox1.Text);
                double ladoB = double.Parse(textBox2.Text);
                double ladoC = double.Parse(textBox3.Text);

                // Calcular el semiperímetro
                double semiperimetro = CalcularSemiperimetro(ladoA, ladoB, ladoC);

                // Calcular el área usando la fórmula de Herón
                double area = CalcularArea(ladoA, ladoB, ladoC, semiperimetro);

                // Mostrar el resultado en el TextBox5
                textBox5.Text = area.ToString("F2");
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Método para calcular el semiperímetro
        private double CalcularSemiperimetro(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }
        // Método para calcular el área
        private double CalcularArea(double a, double b, double c, double s)
        {
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
