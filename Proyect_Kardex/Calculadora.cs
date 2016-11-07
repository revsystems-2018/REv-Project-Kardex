using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect_Kardex
{
    public partial class Calculadora : Form
    {
        bool secuencia = true, punto = true;
        string operacion, borrado;
        double num1, num2, resultado;
        double me = 0.0;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void xsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textcalcu.Text = "";
                textcalcu.Text = "9";
                secuencia = false;
            }
            else
            {
                textcalcu.Text = textcalcu.Text + "9";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textcalcu.Text = "";
                textcalcu.Text = "8";
                secuencia = false;
            }
            else
            {
                textcalcu.Text = textcalcu.Text + "8";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textcalcu.Text = "";
                textcalcu.Text = "7";
                secuencia = false;
            }
            else
            {
                textcalcu.Text = textcalcu.Text + "7";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textcalcu.Text = "";
                textcalcu.Text = "6";
                secuencia = false;
            }
            else
            {
                textcalcu.Text = textcalcu.Text + "6";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textcalcu.Text = "";
                textcalcu.Text = "5";
                secuencia = false;
            }
            else
            {
                textcalcu.Text = textcalcu.Text + "5";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textcalcu.Text = "";
                textcalcu.Text = "4";
                secuencia = false;
            }
            else
            {
                textcalcu.Text = textcalcu.Text + "4";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textcalcu.Text = "";
                textcalcu.Text = "3";
                secuencia = false;
            }
            else
            {
                textcalcu.Text = textcalcu.Text + "3";
            }
        }

        private void nume2_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textcalcu.Text = "";
                textcalcu.Text = "2";
                secuencia = false;
            }
            else
            {
                textcalcu.Text = textcalcu.Text + "2";
            }
        }

        private void nume1_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textcalcu.Text = "";
                textcalcu.Text = "1";
                secuencia = false;
            }
            else
            {
                textcalcu.Text = textcalcu.Text + "1";
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textcalcu.Text = "";
                textcalcu.Text = "0";
                secuencia = false;
            }
            else
            {
                textcalcu.Text = textcalcu.Text + "0";
            }
        }

        private void mas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            num1 = double.Parse(textcalcu.Text);
            secuencia = true;
        }

        private void menos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            num1 = double.Parse(textcalcu.Text);
            secuencia = true;
        }

        private void por_Click(object sender, EventArgs e)
        {
            operacion = "*";
            num1 = double.Parse(textcalcu.Text);
            secuencia = true;
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            num1 = double.Parse(textcalcu.Text);
            secuencia = true;
        }

        private void igual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textcalcu.Text);
            if (operacion == "+")
            {
                resultado = num1 + num2;
                textcalcu.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "-")
            {
                resultado = num1 - num2;
                textcalcu.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "*")
            {
                resultado = num1 * num2;
                textcalcu.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "/")
            {
                resultado = num1 / num2;
                textcalcu.Text = resultado.ToString();
                secuencia = true;
            }
        }

        private void coma_Click(object sender, EventArgs e)
        {
            if (punto == true)
            {
                textcalcu.Text = textcalcu.Text + ",";
                punto = false;
            }
            else
            {
                return;
            }
        }

        private void sobre1_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textcalcu.Text);
            resultado = 1 / num1;
            if (num1 < 0)
            {
                MessageBox.Show("MATH ERROR");
            }
            else
            {
                textcalcu.Text = resultado.ToString();
            }
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            if (num1 < 0)
            {
                MessageBox.Show("MATH ERROR");
            }
            else
                num1 = double.Parse(textcalcu.Text);
                resultado = Math.Sqrt(num1);
                textcalcu.Text = resultado.ToString();
        }

        private void masmenos_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textcalcu.Text);
            num1 *= -1;
            textcalcu.Text = num1.ToString();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = textcalcu.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            textcalcu.Text = borrado;

            if (textcalcu.Text == "")
            {
                textcalcu.Text = "0";
                secuencia = true;
            }
            if (textcalcu.Text == "-")
            {
                textcalcu.Text = "0";
                secuencia = true;
            }
        }

        private void botonC_Click(object sender, EventArgs e)
        {
            textcalcu.Text = "0";
            num1 = 0;
            num2 = 0;
            secuencia = true;
        }

        private void botonCE_Click(object sender, EventArgs e)
        {
            textcalcu.Text = "0";
            num2 = 0;
            secuencia = true;
        }

        private void botonMmenos_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textcalcu.Text);
            me = me - num1;
        }

        private void botonMmas_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textcalcu.Text);
            me = me + num1;
        }

        private void botonMS_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textcalcu.Text);
            me = num1;
        }

        private void botonMR_Click(object sender, EventArgs e)
        {
            textcalcu.Text = me.ToString();
        }

        private void botonMC_Click(object sender, EventArgs e)
        {
            me = 0;
            num1 = 0;
            textcalcu.Text = "0";
        }

        private void modulo_Click(object sender, EventArgs e)
        {
            //double num1 = double.Parse(textcalcu.Text);
            if (num2 == 0)
            {
                textcalcu.Text = "0";
            }
            else {
                resultado = (num1 * ((double.Parse(textcalcu.Text)) / 100.0));
                textcalcu.Text = resultado.ToString();
            }
        }
    }
}
