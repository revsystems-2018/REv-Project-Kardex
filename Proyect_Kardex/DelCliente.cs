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
    public partial class DelCliente : Form
    {
        ValidacionText mn = new ValidacionText();
        Conexion cs = new Conexion();
        public DelCliente()
        {
            InitializeComponent();
            tooldelcliente.SetToolTip(textci,"Ingresar Carnet de Identidad del Cliente");
            tooldelcliente.SetToolTip(buscarboton,"Buscar");
            tooldelcliente.SetToolTip(regboton,"Registro de Clientes");
            tooldelcliente.SetToolTip(deleteboton, "Eliminar Cliente");
        }

        private void cicliente(object sender, KeyPressEventArgs e)
        {
            textci.ForeColor = SystemColors.WindowText;
            textci.Font = new Font(textci.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textci.Text != "" && textci.Font.Italic == true)
            {
                if (textci.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textci.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
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
                        cmd.CommandText = "DELETE FROM Clientes WHERE idCliente = '" + Convert.ToInt32(textci.Text) + "' ;";

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();

                        Messengers mr = new Messengers();
                        mr.textolb.Text = "Cliente Eliminado";
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
                    MessageBox.Show("Error, No Existen Registros del Cliente.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ciClientClick(object sender, MouseEventArgs e)
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
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textci.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   //Codigo de Eliminar Cliente.
                if(comprobar() == 1)
                {
                    deleteboton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error, No Existen Registros del Cliente.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }            
            }
        }

        private int comprobar()
        {
            int cnt = 0;
            string buscar = "SELECT * FROM Clientes WHERE idCliente= '" + Convert.ToInt32(textci.Text) + "' ; ";
            Conexion r = new Conexion();
            try
            {
                r.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, r.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            r.CerrarCnn();
            return cnt;
        }


        private void regboton_Click(object sender, EventArgs e)
        {
            Registro_Clientes re = new Registro_Clientes();
            re.nuevo.Enabled = false;
            re.nuevo.BackgroundImage = global::Proyect_Kardex.Properties.Resources.novob;
            re.editar.Enabled = false;
            re.editar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editdocumentob;
            re.eliminar.Enabled = false;
            re.eliminar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_deleteb;
            re.save.Enabled = false;
            re.save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.saveblok;
            re.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textci.Text = "";
            textci.ForeColor = SystemColors.WindowText;
            textci.Font = new Font(textci.Font, FontStyle.Regular);
        }
    }
}
