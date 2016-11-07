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
    public partial class AEECategoria : Form
    {
        Conexion cs = new Conexion();
        ValidacionText vc = new ValidacionText();
        public AEECategoria()
        {
            InitializeComponent();

            toolCate.SetToolTip(textcod, "Ingrese un Codigo para Registro");
            toolCate.SetToolTip(buscarboton, "Buscar");
            toolCate.SetToolTip(btngen, "Generar Código");
            toolCate.SetToolTip(textnom, "Ingrese el Nombre de la Categoría");
            toolCate.SetToolTip(textDet, "Ingrese el Detalle de la Categoría");
            toolCate.SetToolTip(btnEdit, "Editar Categoría");
            toolCate.SetToolTip(saveboton, "Guardar Categoría");
            toolCate.SetToolTip(deleteboton, "Eliminar Categoría");
            toolCate.SetToolTip(salirboton,"Salir");
        }

        private void salirboton_Click(object sender, EventArgs e)
        {
            this.Close();
            cs.CerrarCnn();
        }

        private void numcodcat(object sender, KeyPressEventArgs e)
        {
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);
            vc.soloLetrasYNumeros(e);
        }

        private void numletname(object sender, KeyPressEventArgs e)
        {
            textnom.ForeColor = SystemColors.WindowText;
            textnom.Font = new Font(textnom.Font, FontStyle.Regular);
            vc.soloLetrasYNumeros(e);
        }

        private void codcatClick(object sender, MouseEventArgs e)
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

        private void namecatClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textnom.Text != "" && textnom.Font.Italic == true)
                {
                    textnom.Text = "";
                    textnom.ForeColor = SystemColors.WindowText;
                    textnom.Font = new Font(textnom.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textnom.ForeColor = SystemColors.WindowText;
                    textnom.Font = new Font(textnom.Font, FontStyle.Regular);
                }
            }
        }

        private void buscarboton_Click(object sender, EventArgs e)
        {
            if (textcod.Text != "" && textcod.Font.Italic == true)
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese el Codigo de Registro de la Categoría a Buscar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo de Registro de la Categoría a Buscar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo de Registro de la Categoría a Buscar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   //Codigo de buscar Categoria.
                string query = "SELECT * FROM Categorias WHERE codCat ='" + int.Parse(textcod.Text) + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
                SqlDataReader read;
                if (comprobar() == 1)
                {
                    textnom.Text = "";
                    textnom.ForeColor = SystemColors.WindowText;
                    textnom.Font = new Font(textnom.Font, FontStyle.Regular);
                    textDet.Text = "";
                    textDet.ForeColor = SystemColors.WindowText;
                    textDet.Font = new Font(textDet.Font, FontStyle.Regular);
                    textcod.Enabled = false;

                    try
                    {
                        cs.OpenCnn();
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            textnom.Text = read.GetString(1);
                            textDet.Text = read.GetString(2);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Existe Datos Nulos con el Codigo de la Categoría Ingresada. \n" + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con la Categoría a Modificar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cs.CerrarCnn();
                    }
                }
            }
        }

        private int comprobar()
        {
            int cnt = 0;
            string buscar = "SELECT * FROM Categorias WHERE codCat = '" + int.Parse(textcod.Text) + "' ; ";
            Conexion fg = new Conexion();

            try
            {
                fg.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, fg.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            fg.CerrarCnn();
            return cnt;
        }


        private void saveboton_Click(object sender, EventArgs e)
        {
            if ((textcod.Text != "" && textcod.Font.Italic == true) || textnom.Font.Italic == true || textDet.Font.Italic == true)
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese el Codigo de Registro de la Categoría a Registrar.\nDebe Quedar en Blanco.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo de Registro de la Categoría a Registrar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "" || textnom.Text == "")
            {
                MessageBox.Show("Ingrese los Datos de la Categoría a Registrar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de Guardar Categoria.
                if (comprobar() == 0)
                {
                    try
                    {
                        // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "INSERT INTO Categorias VALUES (@id, @ini, @nom)";

                        // Creando los parámetros necesarios
                        cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@ini", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);

                        // Asignando los valores a los atributos
                        cmd.Parameters["@id"].Value = int.Parse(textcod.Text);
                        cmd.Parameters["@ini"].Value = textnom.Text;
                        cmd.Parameters["@nom"].Value = textDet.Text;

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
                    MessageBox.Show("ERROR. La Categoría Ya Existe, Contacte Con el Administrador. ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textcod.Text != "" && textcod.Font.Italic == true)
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese el Nombre o Descripción de la Categoría a Modificar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Nombre o Descripción de la Categoría a Modificar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "" || textnom.Text == "")
            {
                MessageBox.Show("Ingrese los Datos de la Categoría a Modificar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {//Codigo de Guardar BD Categoria.
                if (comprobar() == 1)
                {
                    try
                    {
                        // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN(); ;
                        cmd.CommandText = "UPDATE Categorias SET codCat=@id, DescCat=@ini, DescSubCat=@nom WHERE codCat = @ciid ;";

                        cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@ini", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@ciid", System.Data.SqlDbType.Int);

                        // Asignando los valores a los atributos
                        cmd.Parameters["@id"].Value = int.Parse(textcod.Text);
                        cmd.Parameters["@ini"].Value = textnom.Text;
                        cmd.Parameters["@nom"].Value = textDet.Text;
                        cmd.Parameters["@ciid"].Value = int.Parse(textcod.Text);

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR. Al Modificar Los Datos. \n" + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con la Categoría a Modificar.", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR. La Categoría No Existe, Contacte Con el Administrador. ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteboton_Click(object sender, EventArgs e)
        {
            if (textcod.Text != "" && textcod.Font.Italic == true)
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese el Nombre o Descripción de la Categoría a Eliminar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Nombre o Descripción de la Categoría a Eliminar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "")
            {
                MessageBox.Show("Ingrese el Nombre o Descripción de la Categoría a Eliminar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //Codigo de eliminar BD Categoria.
                if (comprobar() == 1)
                {
                    try
                    {
                        // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN(); ;
                        cmd.CommandText = "DELETE FROM Categorias WHERE codCat = '" + Convert.ToInt32(textcod.Text) + "' ;";

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();

                        Messengers mr = new Messengers();
                        mr.textolb.Text = "Categoría Eliminada";
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
                    MessageBox.Show("Error, No Existen Registros de la Categoría.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void titulolabel_Click(object sender, EventArgs e)
        {
            textcod.Text = "";
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);
            textnom.Text = "";
            textnom.ForeColor = SystemColors.WindowText;
            textnom.Font = new Font(textnom.Font, FontStyle.Regular);
            textDet.Text = "";
            textDet.ForeColor = SystemColors.WindowText;
            textDet.Font = new Font(textDet.Font, FontStyle.Regular);
        }

        private void textDet_KeyPress(object sender, KeyPressEventArgs e)
        {
            textDet.ForeColor = SystemColors.WindowText;
            textDet.Font = new Font(textDet.Font, FontStyle.Regular);
            vc.soloLetrasYNumeros(e);
        }

        private void textDet_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textDet.Text != "" && textDet.Font.Italic == true)
                {
                    textDet.Text = "";
                    textDet.ForeColor = SystemColors.WindowText;
                    textDet.Font = new Font(textDet.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textDet.ForeColor = SystemColors.WindowText;
                    textDet.Font = new Font(textDet.Font, FontStyle.Regular);
                }
            }
        }

        private void btngen_Click(object sender, EventArgs e)
        {
            //Inicializamos la clase Random
            Random r = new Random();

            textcod.Text = "";
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);

            textcod.Text = r.Next(0, 999).ToString();
        }

        private void AEECategoria_Load(object sender, EventArgs e)
        {

        }

        private void AEECategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            cs.CerrarCnn();
        }


    }
}
