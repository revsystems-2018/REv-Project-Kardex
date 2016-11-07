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
    public partial class AEESubCat : Form
    {
        ValidacionText vt = new ValidacionText();
        Conexion cs = new Conexion();
        public String codUser = "0";
        int pos = 0;
        int i = 0;

        public int CodCat = 0;

        public AEESubCat()
        {
            InitializeComponent();

            toolSUB.SetToolTip(textcod, "Nombre o Descripción de la Sub-Categoría");
            toolSUB.SetToolTip(codetxt, "Ingrese o Genere un Codigo para el Registro");
            toolSUB.SetToolTip(cbCat, "Seleccionar Categoría");
            toolSUB.SetToolTip(editBtn, "Editar");
            toolSUB.SetToolTip(savebtn, "Guardar");
            toolSUB.SetToolTip(deleteBtn, "Eliminar");
            toolSUB.SetToolTip(novoBtn, "Nuevo");
        }

        private void xsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void namesub(object sender, KeyPressEventArgs e)
        {
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);
            vt.soloLetrasYNumeros(e);           
        }

        private void namesubClick(object sender, MouseEventArgs e)
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


        private int comprobar()
        {
            int cnt = 0;
            string buscar = "SELECT * FROM SubCategorias WHERE CodSubC = '" + codetxt.Text + "' ; ";

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



        private int GenerarCode() 
        {
            int res = 0;
            string query = "SELECT codCat FROM Categorias WHERE DescCat= '" + cbCat.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
            SqlDataReader read;

            try
            {
                cs.OpenCnn();
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                     res = read.GetInt32(0);                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cs.CerrarCnn();
            }
            cs.CerrarCnn();
            return res;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (codetxt.Text != "" && codetxt.Font.Italic == true)
            {
                if (codetxt.Text == "")
                {
                    MessageBox.Show("Ingrese el Nombre o Describción de la SubCategoría a Registrar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Nombre o Describción de la SubCategoría a Registrar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (codetxt.Text == "" || textcod.Text == "")
            {
                MessageBox.Show("Ingrese los Datos de la SubCategoría a Registrar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //Codigo de registro de subcategoria.
                if (comprobar() == 0)
                {
                    try
                    {
                        CodCat = GenerarCode();
                        // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "INSERT INTO SubCategorias VALUES (@id, @ini, @nom)";

                        // Creando los parámetros necesarios
                        cmd.Parameters.Add("@id", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@ini", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@nom", System.Data.SqlDbType.Int);

                        // Asignando los valores a los atributos
                        cmd.Parameters["@id"].Value = codetxt.Text;
                        cmd.Parameters["@ini"].Value = textcod.Text;
                        cmd.Parameters["@nom"].Value = CodCat;

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();

                        ActualizarTabla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR. Al Insertar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR. La Sub-Categoria Ya Existe, Contacte Con el Administrador. ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
        }

        private void titulolabel_Click(object sender, EventArgs e)
        {
            textcod.Text = "";
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);
            codetxt.Text = "";
            codetxt.ForeColor = SystemColors.WindowText;
            codetxt.Font = new Font(codetxt.Font, FontStyle.Regular);
        }

        private void AEESubCat_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.SubCategorias' Puede moverla o quitarla según sea necesario.
            this.subCategoriasTableAdapter.Fill(this.rEV_DataBaseDataSet.SubCategorias);

            string query = "SELECT * FROM Categorias; ";

            SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
            cs.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(1);
                    cbCat.Items.Add(Scad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cs.CerrarCnn();
        }


        private void ActualizarTabla() 
        {
            string query = "SELECT CodSubC, nameSubC, catCod FROM SubCategorias, Categorias WHERE CodCat=catCod AND DescCat= '" + cbCat.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
            cs.OpenCnn();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = sqlQ;
                DataTable dt = new DataTable();
                sda.Fill(dt);

                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridSub.DataSource = bs;
                sda.Update(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cs.CerrarCnn();
        }


        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT CodSubC, nameSubC, catCod FROM SubCategorias, Categorias WHERE CodCat=catCod AND DescCat= '" + cbCat.Text + "' ; ";
            
            SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
            cs.OpenCnn();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = sqlQ;
                DataTable dt = new DataTable();
                sda.Fill(dt);

                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridSub.DataSource = bs;
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cs.CerrarCnn();
            }
            cs.CerrarCnn();
        }

        private void genboton_Click(object sender, EventArgs e)
        {
            //Inicializamos la clase Random
            Random r = new Random();

            codetxt.Text = "";
            codetxt.ForeColor = SystemColors.WindowText;
            codetxt.Font = new Font(codetxt.Font, FontStyle.Regular);

            codetxt.Text = r.Next(0, 99999).ToString();
        }

        private void novoBtn_Click(object sender, EventArgs e)
        {
            codetxt.Text = "";
            codetxt.ForeColor = SystemColors.WindowText;
            codetxt.Font = new Font(codetxt.Font, FontStyle.Regular);
            textcod.Text = "";
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);
            savebtn.Enabled = true;
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
        }

        private void dataGridSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pos = dataGridSub.CurrentRow.Index;
                String valor = "";
                valor = dataGridSub[2, pos].Value.ToString();
                codetxt.Text = "";
                codetxt.ForeColor = SystemColors.WindowText;
                codetxt.Font = new Font(codetxt.Font, FontStyle.Regular);
                textcod.Text = "";
                textcod.ForeColor = SystemColors.WindowText;
                textcod.Font = new Font(textcod.Font, FontStyle.Regular);
                codetxt.Text = dataGridSub[0, pos].Value.ToString();
                textcod.Text = dataGridSub[1, pos].Value.ToString();
                codUser = valor;

                savebtn.Enabled = false;
                editBtn.Enabled = true;
                deleteBtn.Enabled = true;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (codetxt.Text != "" && codetxt.Font.Italic == true)
            {
                if (codetxt.Text == "")
                {
                    MessageBox.Show("Ingrese el Nombre o Describción de la SubCategoría a Modificar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Nombre o Describción de la SubCategoría a Modificar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (codetxt.Text == "" || textcod.Text == "")
            {
                MessageBox.Show("Ingrese los Datos de la SubCategoría a Modificar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //Codigo de registro de subcategoria.
                if (comprobar() == 1)
                {
                    try
                    {
                        CodCat = GenerarCode();
                        // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "UPDATE SubCategorias SET CodSubC=@id, nameSubC=@nom, catCod=@cod WHERE CodSubC = @ciid ;";

                        // Creando los parámetros necesarios
                        cmd.Parameters.Add("@id", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@cod", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@ciid", System.Data.SqlDbType.VarChar);

                        // Asignando los valores a los atributos
                        cmd.Parameters["@id"].Value = codetxt.Text;
                        cmd.Parameters["@nom"].Value = textcod.Text;
                        cmd.Parameters["@cod"].Value = CodCat;
                        cmd.Parameters["@ciid"].Value = codetxt.Text;

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();

                        ActualizarTabla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR. Al Insertar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR. La Sub-Categoria No Existe, Contacte Con el Administrador. ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
             if (codetxt.Text != "" && codetxt.Font.Italic == true)
            {
                if (codetxt.Text == "")
                {
                    MessageBox.Show("Ingrese el Nombre o Describción de la SubCategoría a Eliminar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Nombre o Describción de la SubCategoría a Eliminar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
             else if (codetxt.Text == "")
             {
                 MessageBox.Show("Ingrese los Datos de la SubCategoría a Eliminar", "ERROR",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else
             {
                 if (comprobar() == 1)
                 {
                     try
                     {   // Objetos de conexión y comando
                         System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                         // Estableciento propiedades
                         cmd.Connection = cs.GetCONN();
                         cmd.CommandText = "DELETE FROM SubCategorias WHERE CodSubC = '" + Convert.ToInt32(codetxt.Text) + "' ;";

                         cs.OpenCnn();
                         cmd.ExecuteNonQuery();
                         cs.CerrarCnn();

                         ActualizarTabla();
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("ERROR. Al Eliminar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }
                 else
                 {
                     MessageBox.Show("Error, No Existen Registros de la Sub-Categoría.", "ERROR",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
        }

        private void codetxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (codetxt.Text != "" && codetxt.Font.Italic == true)
                {
                    codetxt.Text = "";
                    codetxt.ForeColor = SystemColors.WindowText;
                    codetxt.Font = new Font(codetxt.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    codetxt.ForeColor = SystemColors.WindowText;
                    codetxt.Font = new Font(codetxt.Font, FontStyle.Regular);
                }
            }
        }

        private void codetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            codetxt.ForeColor = SystemColors.WindowText;
            codetxt.Font = new Font(codetxt.Font, FontStyle.Regular);
            vt.soloLetrasYNumeros(e);
        }

        private void AEESubCat_FormClosing(object sender, FormClosingEventArgs e)
        {
            cs.CerrarCnn();
        }

    }
}
