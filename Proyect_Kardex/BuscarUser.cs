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
    public partial class BuscarUser : Form
    {
        ValidacionText mn = new ValidacionText();
        public BuscarUser()
        {
            InitializeComponent();
            
            toolfind.SetToolTip(regboton,"Registro de Usuarios");
            toolfind.SetToolTip(cancel, "Salir");
            toolfind.SetToolTip(citext, "Ingresar carnet de Identidad del Usuario");
            toolfind.SetToolTip(buscarboton,"Buscar");
        }

        private void civerUser(object sender, KeyPressEventArgs e)
        {
            mn.soloNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (citext.Text != "" && citext.Font.Italic == true)
            {
                if (citext.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (citext.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Width = 517;
                this.Height = 360; //360
                this.foto.Visible = false;
                this.nom.Visible = false;
                this.apellido.Visible = false;
                this.ci.Visible = false;
                this.label5.Visible = false;
                this.nivel.Visible = false;
                this.label6.Visible = false;
                this.user.Visible = false;
                this.label9.Visible = false;
                this.cargo.Visible = false;
                this.depa.Visible = false;
                this.dir.Visible = false;
                this.prov.Visible = false;
                this.label4.Visible = false;
                this.correo.Visible = false;
                this.label15.Visible = false;
                this.tel.Visible = false;
                this.label16.Visible = false;
                this.cel.Visible = false;
                this.label17.Visible = false;
                this.fax.Visible = false;         
                //codigo de busqueda.
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ciUserClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (citext.Text != "" && citext.Font.Italic == true)
                {
                    citext.Text = "";
                    citext.ForeColor = SystemColors.WindowText;
                    citext.Font = new Font(citext.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    citext.ForeColor = SystemColors.WindowText;
                    citext.Font = new Font(citext.Font, FontStyle.Regular);
                }
            }
        }

        private void xsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
