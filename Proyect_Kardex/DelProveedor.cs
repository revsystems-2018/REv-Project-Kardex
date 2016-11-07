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
    public partial class DelProveedor : Form
    {
        ValidacionText mn = new ValidacionText();
        Conexion cs = new Conexion();
        public DelProveedor()
        {
            InitializeComponent();
            toolProv.SetToolTip(textcod, "Ingresar el Codigo de Registro del Proveedor");
            toolProv.SetToolTip(buscarboton, "Buscar");
            toolProv.SetToolTip(regboton, "Registro de Proveedores");
            toolProv.SetToolTip(deleteboton, "Eliminar Proveedor");
        }

        private void crproveedor(object sender, KeyPressEventArgs e)
        {
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void regboton_Click(object sender, EventArgs e)
        {
            Registro_Proveedores re = new Registro_Proveedores();
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

        private void delProvClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textcod.Text != "" && textcod.Font.Italic == true)
                {
                    textcod.Text = "";
                    textcod.ForeColor = SystemColors.WindowText;
                    textcod.Font = new Font(textcod.Font, FontStyle.Regular);
                }
                else
                {
                    textcod.ForeColor = SystemColors.WindowText;
                    textcod.Font = new Font(textcod.Font, FontStyle.Regular);
                }
            }
        }

        private void buscarboton_Click(object sender, EventArgs e)
        {
            if (textcod.Text != "" && textcod.Font.Italic == true)
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese el Codigo de Registro del Proveedor que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo de Registro del Proveedor que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo de Registro del Proveedor que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //Codigo de buscar Proveedor.
                if (comprobar() == 1)
                {
                    deleteboton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error, No Existen Registros del Proveedor.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }       
            }
        }

        private int comprobar()
        {
            int cnt = 0;
            string buscar = "SELECT * FROM Proveedores WHERE codProve= '" + Convert.ToInt32(textcod.Text) + "' ; ";
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
            textcod.Text = "";
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);
        }

        private void deleteboton_Click(object sender, EventArgs e)
        {
            if (textcod.Text != "" && textcod.Font.Italic == true)
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese el Codigo de Registro del Proveedor Como Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo de Registro del Proveedor Como Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo de Registro del Proveedor Como Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Codigo de Eliminar Proveedor.
                if (comprobar() == 1)
                {
                    try
                    {
                        // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();                       
                        cmd.CommandText = "DELETE FROM Proveedores WHERE codProve = '" + Convert.ToInt32(textcod.Text) + "' ;";

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();

                        Messengers mr = new Messengers();
                        mr.textolb.Text = "Proveedor Eliminado";
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
                    MessageBox.Show("Error, No Existen Registros del Proveedor.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DelProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
