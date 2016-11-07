using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyect_Kardex
{
    public partial class DelUser : Form
    {
        ValidacionText mn = new ValidacionText();
        Conexion cs = new Conexion();
        public DelUser()
        {
            InitializeComponent();
            toolUser.SetToolTip(textci, "Ingresar Carnet de Identidad del Usuario");
            toolUser.SetToolTip(buscarboton, "Buscar");
            toolUser.SetToolTip(regboton, "Registro de Usuarios");
            toolUser.SetToolTip(deleteboton, "Eliminar Usuario");
        }

        private void ciUser(object sender, KeyPressEventArgs e)
        {
            textci.ForeColor = SystemColors.WindowText;
            textci.Font = new Font(textci.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void deleteboton_Click(object sender, EventArgs e)
        {
            if (textci.Text != "" && textci.Font.Italic == true)
            {
                if (textci.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textci.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Codigo de Eliminar Cliente.
                if (comprobar() == 1)
                {
                    try
                    {
                        // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "DELETE FROM Usuario WHERE ciUser = '" + Convert.ToInt32(textci.Text) + "' ;";

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();

                        Messengers mr = new Messengers();
                        mr.textolb.Text = "Usuario Eliminado";
                        mr.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR. Al Eliminar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, No Existen Registros del Usuario.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void DelUserClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textci.Text != "" && textci.Font.Italic == true)
                {
                    textci.Text = "";
                    textci.ForeColor = SystemColors.WindowText;
                    textci.Font = new Font(textci.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textci.ForeColor = SystemColors.WindowText;
                    textci.Font = new Font(textci.Font, FontStyle.Regular);
                }
            }
        }

        private void buscarboton_Click(object sender, EventArgs e)
        {
            if (textci.Text != "" && textci.Font.Italic == true)
            {
                if (textci.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textci.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {//Codigo de buscar Usuario.
                if (comprobar() == 1)
                {
                    deleteboton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error, No Existen Registros del Usuario.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                             
            }
        }



        private int comprobar()
        {
            int cnt = 0;
            string buscar = "SELECT * FROM Usuario WHERE ciUser= '" + Convert.ToInt32(textci.Text) + "' ; ";
            Conexion f = new Conexion();
            try
            {
                f.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, f.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            f.CerrarCnn();
            return cnt;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textci.Text = "";
            textci.ForeColor = SystemColors.WindowText;
            textci.Font = new Font(textci.Font, FontStyle.Regular);
        }
    }
}
