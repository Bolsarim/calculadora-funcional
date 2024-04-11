using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace calculadora_funcional
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1() 
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, 
                    CultureInfo.InvariantCulture);
                txtBoxResultado.Text = "";
                operacao = "SOMA";
                labeloperacao.Text = "+";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
