using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Summa(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Vichitanie(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Umnozenie(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Delenie(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        public static double Summa(double a, double b)
        { return a + b; }
        public static double Vichitanie(double a, double b)
        { return a - b; }
        public static double Umnozenie(double a, double b)
        { return a * b; }
        public static double Delenie(double a, double b)
        { return a / b; }
    }
}
