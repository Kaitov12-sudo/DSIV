using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio122
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
                // Obtener valores
                double nota1 = double.Parse(textBox1.Text);
                double nota2 = double.Parse(textBox2.Text);
                double nota3 = double.Parse(textBox3.Text);

                // Calcular promedio
                double promedio = CalcularPromedio(nota1, nota2, nota3);

                // Mostrar resultado 
                textBox4.Text = promedio.ToString("F2");
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos en todas las notas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private double CalcularPromedio(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
}
