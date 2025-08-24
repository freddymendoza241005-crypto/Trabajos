using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_1_login
{
    public partial class Form1 : Form
    {
        int intentosFallidos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btingresar_Click(object sender, EventArgs e)
        {
            int intentosRestantes = 0;
            const int maxIntentos = 3;

            string usuarioCorrecto = "admin";
            string claveCorrecta = "admin123";

            string usuarioIngresado = Nombre.Text;
            string claveIngresada = Contraseña.Text;

            if (usuarioIngresado == usuarioCorrecto && claveIngresada == claveCorrecta)
            {
                MessageBox.Show(" Bienvenido " + usuarioIngresado, "Login exitoso");
                intentosFallidos = 0; 
            }
            else
            {
                intentosFallidos++;
                intentosRestantes = maxIntentos - intentosFallidos;

                if (intentosFallidos >= maxIntentos)
                {
                    MessageBox.Show(" Has superado el número máximo de intentos.\nAcceso bloqueado.", "Acceso denegado");
                    Btingresar.Enabled = false;
                    Nombre.Enabled = false;
                    Contraseña.Enabled = false;
                }
                else
                {
                    MessageBox.Show(" Usuario o clave incorrectos.\nIntentos restantes:" +intentosRestantes, "Error de login");
                }

            }
        }

    }

}
