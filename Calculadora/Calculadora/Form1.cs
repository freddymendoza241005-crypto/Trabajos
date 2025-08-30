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
using System.Text.RegularExpressions;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double memoria = 0;
        public Form1()
        {
            InitializeComponent();
        }
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        private void Btborrarpantalla_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void Btborrarcaracter_Click(object sender, EventArgs e)
        {
            if (txtPantalla.TextLength == 1) txtPantalla.Text = "0";
            else txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length -1);

        }

        private void Btuno_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "1";

        }

        private void Btdos_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void Bttres_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void Btcuatro_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void Btcinco_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void Btseis_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void Btciete_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void Btocho_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void Btnueve_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void Btcero_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void Btpunto_Click(object sender, EventArgs e)
        {
            if (!txtPantalla.Text.Contains("."))
                txtPantalla.Text += ".";
        }


        private void Btsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = double.Parse(txtPantalla.Text, CultureInfo.CurrentCulture);
            txtPantalla.Text = "0";
        }

        private void Btresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = double.Parse(txtPantalla.Text, CultureInfo.CurrentCulture);
            txtPantalla.Text = "0";
        }

        private void Btmultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = double.Parse(txtPantalla.Text, CultureInfo.CurrentCulture);
            txtPantalla.Text = "0";
        }

        private void Btdividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = double.Parse(txtPantalla.Text, CultureInfo.CurrentCulture);
            txtPantalla.Text = "0";
        }

        private void Btexponente_Click(object sender, EventArgs e)
        {
            operador = "^";
            num1 = double.Parse(txtPantalla.Text, CultureInfo.CurrentCulture);
            txtPantalla.Text = "0";
        }
        private void Btraiz_Click(object sender, EventArgs e)
        {
            operador = "√";
            num1 = double.Parse(txtPantalla.Text, CultureInfo.CurrentCulture);
            
        }
        private void Btpi_Click(object sender, EventArgs e)
        {
            operador = "π";
            num1 = double.Parse(txtPantalla.Text, CultureInfo.CurrentCulture);
            
        }
        private void Btlog_Click(object sender, EventArgs e)
        {
            operador = "Log";
            num1 = double.Parse(txtPantalla.Text, CultureInfo.CurrentCulture);

        }

        private void Btguardarenmemoria_Click(object sender, EventArgs e)
        {
            //Ms
            memoria = Convert.ToDouble(txtPantalla.Text);
           
        }
        private void Btrecuperarnumero_Click(object sender, EventArgs e)
        {
            // operador = "Mr";
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = memoria.ToString();
        }
        private void Btlimpiar_Click(object sender, EventArgs e)
        {
            //operador = "Mc";
            memoria = 0;
        }
        private void Btrestarguardado_Click(object sender, EventArgs e)
        {
            //operador = "M-";
            memoria -= Convert.ToDouble(txtPantalla.Text);
        }
        private void Btporciento_Click(object sender, EventArgs e)
        {
            //operador = "%";
            num1 = double.Parse(txtPantalla.Text, CultureInfo.CurrentCulture);
            txtPantalla.Text = $"{num1 / 100}";
        }

        private void BtSen_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtPantalla.Text, CultureInfo.CurrentCulture);
            txtPantalla.Text = $"{Math.Sin(num1)}";
        }
        private void BtCoseno_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtPantalla.Text, CultureInfo.CurrentCulture);
            txtPantalla.Text = $"{Math.Cos(num1)}";
        }

        private void Btigual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtPantalla.Text);

            switch (operador)
            {
                case "+":
                    txtPantalla.Text = $"{num1 + num2}";
                    break;
                case "-":
                    txtPantalla.Text = $"{num1 - num2}";
                    break;
                case "*":
                    txtPantalla.Text = $"{num1 * num2}";
                    break;
                case "/":
                    txtPantalla.Text = $"{num1 / num2}";
                    break;
                case "^":
                    txtPantalla.Text = $"{Math.Pow(num1,num2)}";
                    break;
                case "√":
                    txtPantalla.Text = $"{Math.Sqrt(num1)}";
                    break;
                case "π":
                    txtPantalla.Text = Math.PI.ToString();
                    break;
                case "Log":
                    num1 = double.Parse(txtPantalla.Text);
                    if (num1 > 0)
                    {
                        txtPantalla.Text = Math.Log10(num1).ToString();
                    }
                    else
                    {
                        txtPantalla.Text = "Error";
                    }
                    break;

            }
        }

        private void Btsumarguardado_Click_1(object sender, EventArgs e)
        {
            //operador = "M+";
            memoria += Convert.ToDouble(txtPantalla.Text);

        }

    }
}
