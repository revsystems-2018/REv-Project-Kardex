using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect_Kardex
{
    public partial class REV_SendEmail : Form
    {
        Correo c = new Correo();
        OpenFileDialog img = new OpenFileDialog();

        public REV_SendEmail()
        {
            InitializeComponent();

            toolTipSMS.SetToolTip(textcod, "Ingresar Correo Electrónico de Microsoft");
            toolTipSMS.SetToolTip(textPass, "Ingresar la Contraseña de su Correo Electrónico");
            toolTipSMS.SetToolTip(textini, "Ingresar Correo Electrónico a Enviar el SMS");
            toolTipSMS.SetToolTip(textAsunt, "Redactar Asunto o Título del Mensaje");
            toolTipSMS.SetToolTip(textAdjunt, "Seleccionar Archivo");
            toolTipSMS.SetToolTip(textSMS, "Redactar el Mensaje");
            toolTipSMS.SetToolTip(btnOpen, "Abrir");
            toolTipSMS.SetToolTip(SeePass, "Ver");
            toolTipSMS.SetToolTip(btnSend, "Enviar");
            toolTipSMS.SetToolTip(salirboton, "Salir");
        }

        private void salirboton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textcod_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textcod.Text != "" && textcod.Font.Italic == true)
                {
                    textcod.Text = "";
                    textcod.ForeColor = SystemColors.WindowText;
                    textcod.Font = new Font(textcod.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textcod.ForeColor = SystemColors.WindowText;
                    textcod.Font = new Font(textcod.Font, FontStyle.Regular);
                }
            }
        }

        private void textini_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textini.Text != "" && textini.Font.Italic == true)
                {
                    textini.Text = "";
                    textini.ForeColor = SystemColors.WindowText;
                    textini.Font = new Font(textini.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textini.ForeColor = SystemColors.WindowText;
                    textini.Font = new Font(textini.Font, FontStyle.Regular);
                }
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textAsunt.Text != "" && textAsunt.Font.Italic == true)
                {
                    textAsunt.Text = "";
                    textAsunt.ForeColor = SystemColors.WindowText;
                    textAsunt.Font = new Font(textAsunt.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textAsunt.ForeColor = SystemColors.WindowText;
                    textAsunt.Font = new Font(textAsunt.Font, FontStyle.Regular);
                }
            }
        }

        private void textAdjunt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textAdjunt.Text != "" && textAdjunt.Font.Italic == true)
                {
                    textAdjunt.Text = "";
                    textAdjunt.ForeColor = SystemColors.WindowText;
                    textAdjunt.Font = new Font(textAdjunt.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textAdjunt.ForeColor = SystemColors.WindowText;
                    textAdjunt.Font = new Font(textAdjunt.Font, FontStyle.Regular);
                }
            }
        }

        private void textSMS_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textSMS.Text != "" && textSMS.Font.Italic == true)
                {
                    textSMS.Text = "";
                    textSMS.ForeColor = SystemColors.WindowText;
                    textSMS.Font = new Font(textSMS.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textSMS.ForeColor = SystemColors.WindowText;
                    textSMS.Font = new Font(textSMS.Font, FontStyle.Regular);
                }
            }
        }

        public static bool ValidarEmail(String texto)
        {
            String exper = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(texto, exper))
            {
                if (Regex.Replace(texto, exper, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        } 

        private void textcod_KeyPress(object sender, KeyPressEventArgs e)
        {      
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);
             
        }

        private void textini_KeyPress(object sender, KeyPressEventArgs e)
        {
            textini.ForeColor = SystemColors.WindowText;
            textini.Font = new Font(textini.Font, FontStyle.Regular);
        }

        private void textAsunt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textAsunt.ForeColor = SystemColors.WindowText;
            textAsunt.Font = new Font(textAsunt.Font, FontStyle.Regular);
        }

        private void textAdjunt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textAdjunt.ForeColor = SystemColors.WindowText;
            textAdjunt.Font = new Font(textAdjunt.Font, FontStyle.Regular);
        }

        private void textSMS_KeyPress(object sender, KeyPressEventArgs e)
        {
            textSMS.ForeColor = SystemColors.WindowText;
            textSMS.Font = new Font(textSMS.Font, FontStyle.Regular);
        }

        private void titulolabel_Click(object sender, EventArgs e)
        {
            textcod.Text = "";
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);
            textPass.Text = "";
            textPass.ForeColor = SystemColors.WindowText;
            textPass.Font = new Font(textPass.Font, FontStyle.Regular);
            textini.Text = "";
            textini.ForeColor = SystemColors.WindowText;
            textini.Font = new Font(textini.Font, FontStyle.Regular);
            textAsunt.Text = "";
            textAsunt.ForeColor = SystemColors.WindowText;
            textAsunt.Font = new Font(textAsunt.Font, FontStyle.Regular);
            textAdjunt.Text = "";
            textAdjunt.ForeColor = SystemColors.WindowText;
            textAdjunt.Font = new Font(textAdjunt.Font, FontStyle.Regular);
            textSMS.Text = "";
            textSMS.ForeColor = SystemColors.WindowText;
            textSMS.Font = new Font(textSMS.Font, FontStyle.Regular);
        }

        private void textcod_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(textcod.Text))
            {

            }
            else
            {
                MessageBox.Show("Dirrección de Correo Electrónico No Valida. El Correo Debe Tener El Formato: nombre@dominio.com  Porfavor Seleccione un Correo Electroónico Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textcod.SelectAll();
                textcod.Focus();
            }
        }

        private void textini_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(textini.Text))
            {

            }
            else
            {
                MessageBox.Show("Dirrección de Correo Electrónico No Valida. El Correo Debe Tener El Formato: nombre@dominio.com  Porfavor Seleccione un Correo Electroónico Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textini.SelectAll();
                textini.Focus();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lbsendsms.Visible = true;
            if (textcod.Text != "" && textcod.Font.Italic == true)
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese su Correo Electrónico Correctamente.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese su Correo Electrónico Correctamente.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textini.Text == "" && textini.Font.Italic == true)
            {
                MessageBox.Show("Ingrese el Correo Electrónico para Realizar el Envio.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbsendsms.Visible = true;
                c.enviarCorreo(textcod.Text, textPass.Text, textSMS.Text, textAsunt.Text, textini.Text, textAdjunt.Text);
                //this.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            img.InitialDirectory = "C:\\";
            img.Filter = "Archivos de Compresion (*.rar)(*.zip)|*.rar;*.zip| Archivos de ISO (*.iso)|*.iso| PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            img.Title = "Abrir Archivo";

            if (img.ShowDialog() == DialogResult.OK)
            {
                textAdjunt.Text = "";
                textAdjunt.ForeColor = SystemColors.WindowText;
                textAdjunt.Font = new Font(textAdjunt.Font, FontStyle.Regular);
                textAdjunt.Text = img.FileName;
                //fotoCliente.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar el Archivo Correcto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeePass_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            const char PASSWORD_VISIBLE = '\0';
            textPass.PasswordChar = PASSWORD_VISIBLE;
        }

        private void SeePass_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            const char PASSWORD_VISIBLE = '*';
            textPass.PasswordChar = PASSWORD_VISIBLE;
        }

    }
}
