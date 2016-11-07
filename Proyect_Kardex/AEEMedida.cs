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
    public partial class AEEMedida : Form
    {
        ValidacionText vb = new ValidacionText();
        Conexion cs = new Conexion();

        public AEEMedida()
        {
            InitializeComponent();

            toolRegMed.SetToolTip(textcod, "Ingresar Codigo de Registro");
            toolRegMed.SetToolTip(textname, "Ingrese el Nombre o la Descripción de la Medida");
            toolRegMed.SetToolTip(textsimb, "Ingrese los Iniciales de la Simbologia de la Medida");
            toolRegMed.SetToolTip(savebtn, "Guardar");
            toolRegMed.SetToolTip(editbtn, "Editar");
            toolRegMed.SetToolTip(xsalir, "Salir");
            toolRegMed.SetToolTip(botonmin, "Mínimizar");
            toolRegMed.SetToolTip(botonmax, "Máximizar");
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void codClick(object sender, MouseEventArgs e)
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

        private void nombClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textname.Text != "" && textname.Font.Italic == true)
                {
                    textname.Text = "";
                    textname.ForeColor = SystemColors.WindowText;
                    textname.Font = new Font(textname.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textname.ForeColor = SystemColors.WindowText;
                    textname.Font = new Font(textname.Font, FontStyle.Regular);
                }
            }
        }

        private void simbClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textsimb.Text != "" && textsimb.Font.Italic == true)
                {
                    textsimb.Text = "";
                    textsimb.ForeColor = SystemColors.WindowText;
                    textsimb.Font = new Font(textsimb.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textsimb.ForeColor = SystemColors.WindowText;
                    textsimb.Font = new Font(textsimb.Font, FontStyle.Regular);
                }
            }
        }

        private void numCod(object sender, KeyPressEventArgs e)
        {
            textsimb.ForeColor = SystemColors.WindowText;
            textsimb.Font = new Font(textsimb.Font, FontStyle.Regular);
            vb.soloNumeros(e);
        }

        private void namepr(object sender, KeyPressEventArgs e)
        {
            textname.ForeColor = SystemColors.WindowText;
            textname.Font = new Font(textname.Font, FontStyle.Regular);
            vb.soloLetrasYNumeros(e);
        }

        private void simbpress(object sender, KeyPressEventArgs e)
        {
            textsimb.ForeColor = SystemColors.WindowText;
            textsimb.Font = new Font(textsimb.Font, FontStyle.Regular);
            vb.soloLetrasYNumeros(e);
        }


        private int comprobar()
        {
            int cnt = 0;
            string buscar = "SELECT * FROM Medidas WHERE codMed = '" + textcod.Text + "' ; ";

            try
            {
                cs.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, cs.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            cs.CerrarCnn();
            return cnt;
        }


        private void savebtn_Click(object sender, EventArgs e)
        {
            if (textcod.Text != "" && textcod.Font.Italic == true || textname.Font.Italic == true || textsimb.Font.Italic == true)
            {
                if (textcod.Text == "" || textname.Text == "" || textsimb.Text == "")
                {
                    MessageBox.Show("Ingrese los Datos de la Unidad de Medida", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese los Datos de la Unidad de Medida", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "" || textname.Text == "" || textsimb.Text == "")
            {
                MessageBox.Show("Ingrese los Datos de la Unidad de Medida", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de Guardar medida.
                if (comprobar() == 0)
                {
                    try
                    {   // Objetos de conexión y comando                      
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "INSERT INTO Medidas VALUES (@id, @ini, @nom)";

                        // Creando los parámetros necesarios
                        cmd.Parameters.Add("@id", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@ini", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);

                        // Asignando los valores a los atributos
                        cmd.Parameters["@id"].Value = textcod.Text;
                        cmd.Parameters["@ini"].Value = textname.Text;
                        cmd.Parameters["@nom"].Value = textsimb.Text;

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();
                     
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR. Al Insertar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR. La Medida Ya Existe, Contacte Con el Administrador. ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void titulolabel_Click(object sender, EventArgs e)
        {
            textcod.Text = "";
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);
            textname.Text = "";
            textname.ForeColor = SystemColors.WindowText;
            textname.Font = new Font(textname.Font, FontStyle.Regular);
            textsimb.Text = "";
            textsimb.ForeColor = SystemColors.WindowText;
            textsimb.Font = new Font(textsimb.Font, FontStyle.Regular);
        }

        private void gencode_Click(object sender, EventArgs e)
        {
            //Inicializamos la clase Random
            Random r = new Random();

            textcod.Text = "";
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);

            textcod.Text = r.Next(0, 99).ToString();
        }

        private void botonmax_Click(object sender, EventArgs e)
        {

        }

        private void buscarboton_Click(object sender, EventArgs e)
        {
            if (textcod.Text != "" && textcod.Font.Italic == true )
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese el Código de la Unidad de Medida", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Código de la Unidad de Medida", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "")
            {
                MessageBox.Show("Ingrese el Código de la Unidad de Medida", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de buscar medida.
                string query = "SELECT * FROM Medidas WHERE codMed ='" + textcod.Text + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
                SqlDataReader read;
                if (comprobar() == 1)
                {                   
                    textname.Text = "";
                    textname.ForeColor = SystemColors.WindowText;
                    textname.Font = new Font(textname.Font, FontStyle.Regular);
                    textsimb.Text = "";
                    textsimb.ForeColor = SystemColors.WindowText;
                    textsimb.Font = new Font(textsimb.Font, FontStyle.Regular);

                    try
                    {
                        cs.OpenCnn();
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {                          
                            textname.Text = read.GetString(1);
                            textsimb.Text = read.GetString(2);                           
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Existe Datos Nulos con el Codigo de la Medida Ingresada. \n" + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con la Medida a Modificar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cs.CerrarCnn();
                    }
                }

            }
            cs.CerrarCnn();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (textcod.Text != "" && textcod.Font.Italic == true || textname.Font.Italic == true || textsimb.Font.Italic == true)
            {
                if (textcod.Text == "" || textname.Text == "" || textsimb.Text == "")
                {
                    MessageBox.Show("Ingrese los Datos de la Unidad de Medida", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese los Datos de la Unidad de Medida", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "" || textname.Text == "" || textsimb.Text == "")
            {
                MessageBox.Show("Ingrese los Datos de la Unidad de Medida", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de Editar medida.
                if (comprobar() == 1)
                {
                    try
                    {   // Objetos de conexión y comando                        
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "UPDATE Medidas SET codMed=@id, nameMed=@ini, simbMed=@nom WHERE codMed = @ciid ;";

                        cmd.Parameters.Add("@id", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@ini", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@ciid", System.Data.SqlDbType.VarChar);

                        // Asignando los valores a los atributos
                        cmd.Parameters["@id"].Value = textcod.Text;
                        cmd.Parameters["@ini"].Value = textname.Text;
                        cmd.Parameters["@nom"].Value = textsimb.Text;
                        cmd.Parameters["@ciid"].Value = textcod.Text;

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR. Al Modificar Los Datos. \n" + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con la Medida a Modificar.", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR. La Medida No Existe, Contacte Con el Administrador. ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
