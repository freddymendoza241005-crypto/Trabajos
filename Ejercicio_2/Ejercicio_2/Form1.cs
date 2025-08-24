using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        double aumentar = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtConvertir_Click(object sender, EventArgs e)
        {
            double gradoC, gradoF;


            if (GradosC.Text !="")
            {
                gradoC = double.Parse(GradosC.Text);
                double resultadof = (((gradoC * 9) / 5) + 32);
                GradosF.Text = resultadof.ToString("F2");
            }
            else if(GradosF.Text !="")
            {
                gradoF = double.Parse(GradosF.Text);
                double resultadoC = (((gradoF - 32) * 5) / 9);
                GradosC.Text = resultadoC.ToString("F2");
            }
            else
            {
                MessageBox.Show("formato incorrecto");
            }

        }
        private void Btborrar_Click(object sender, EventArgs e)
        {
            GradosC.Clear();
            GradosF.Clear();
        }

        private void btMedir_Click_1(object sender, EventArgs e)
        {
            double peso, altura;
            if (double.TryParse(cantpeso.Text, out peso) && double.TryParse(cantaltura.Text, out altura))
            {
                double resultado = peso / (altura * altura);

                if (resultado <= 16)
                {
                    MessageBox.Show("Delgadez severa");
                }
                else if (resultado >= 16 && resultado < 18)
                {
                    MessageBox.Show("Delgadez moderada");

                }
                else if (resultado >= 18 && resultado < 25)
                {
                    MessageBox.Show("peso normal");
                }
                else if (resultado >= 25 && resultado < 30)
                {
                    MessageBox.Show("sobre peso");
                }
                else if (resultado >= 30 && resultado < 35)
                {
                    MessageBox.Show("obesidad grado 1");
                }
                else if (resultado >= 35 && resultado < 40)
                {
                    MessageBox.Show("obesidad grado 2");
                }
                else
                {
                    MessageBox.Show("sobre peso");
                }
            }
            else
            {
                MessageBox.Show("Error, ingresa valores numericos");
            }
        }

        private void Btcontarclick_Click(object sender, EventArgs e)
        {
            aumentar = aumentar + 1;
            Contador.Text = aumentar.ToString();
        }

    }
}