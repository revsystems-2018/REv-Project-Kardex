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
using System.IO;

namespace Proyect_Kardex
{
    public partial class AEEMarca : Form
    {
        ValidacionText mn = new ValidacionText();
        OpenFileDialog img = new OpenFileDialog();
        Conexion cs = new Conexion();

        public AEEMarca()
        {
            InitializeComponent();

            toolMarca.SetToolTip(textcod, "Ingrese un Codigo de Registro");
            toolMarca.SetToolTip(buscarboton, "Buscar");
            toolMarca.SetToolTip(textnom, "Ingrese el Nombre de la Marca");
            toolMarca.SetToolTip(textlogo, "Seleccionar el Logotipo de la Marca");
            toolMarca.SetToolTip(openlogo, "Abrir");
            toolMarca.SetToolTip(textini, "Ingrese Iniciales de la Marca");
            toolMarca.SetToolTip(deleteboton, "Eliminar Marca");
            toolMarca.SetToolTip(verboton, "Mostrar Logotipo");
            toolMarca.SetToolTip(saveboton, "Guardar");
            toolMarca.SetToolTip(salirboton, "Salir");
            toolMarca.SetToolTip(gencode, "Generar Codigo de Registro");
        }

        private void codregmClick(object sender, MouseEventArgs e)
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

        private void solonumcodm(object sender, KeyPressEventArgs e)
        {
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void nombregmClick(object sender, MouseEventArgs e)
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

        private void logoregmClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textlogo.Text != "" && textlogo.Font.Italic == true)
                {
                    textlogo.Text = "";
                    textlogo.ForeColor = SystemColors.WindowText;
                    textlogo.Font = new Font(textlogo.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textlogo.ForeColor = SystemColors.WindowText;
                    textlogo.Font = new Font(textlogo.Font, FontStyle.Regular);
                }
            }
        }

        private void iniregmClick(object sender, MouseEventArgs e)
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

        private void letrasynumerosini(object sender, KeyPressEventArgs e)
        {
            textini.ForeColor = SystemColors.WindowText;
            textini.Font = new Font(textini.Font, FontStyle.Regular);
            mn.soloLetrasYNumeros(e);
        }

        private void salirboton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void leternumCod(object sender, KeyPressEventArgs e)
        {
            textnom.ForeColor = SystemColors.WindowText;
            textnom.Font = new Font(textnom.Font, FontStyle.Regular);
            mn.soloLetrasYNumeros(e);
        }

        private void buscarboton_Click(object sender, EventArgs e)
        {
            if (textcod.Text != "" && textcod.Font.Italic == true)
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese el Codigo de Registro de la Marca que Muestra en la Tabla de Registro", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo de Registro de la Marca que Muestra en la Tabla de Registro", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo de Registro de la Marca que Muestra en la Tabla de Registro", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   //Codigo de Buscar Marca.
                string query = "SELECT * FROM Marcas WHERE codMarca ='" + Convert.ToInt32(textcod.Text) + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
                SqlDataReader read;
                if (comprobar() == 1)
                {
                    textcod.Text = "";
                    textcod.ForeColor = SystemColors.WindowText;
                    textcod.Font = new Font(textcod.Font, FontStyle.Regular);
                    textini.Text = "";
                    textini.ForeColor = SystemColors.WindowText;
                    textini.Font = new Font(textini.Font, FontStyle.Regular);
                    textlogo.Text = "";
                    textlogo.ForeColor = SystemColors.WindowText;
                    textlogo.Font = new Font(textlogo.Font, FontStyle.Regular);
                    textnom.Text = "";
                    textnom.ForeColor = SystemColors.WindowText;
                    textnom.Font = new Font(textnom.Font, FontStyle.Regular);

                    try
                    {
                        cs.OpenCnn();
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            textcod.Text = read.GetInt32(0).ToString();
                            textini.Text = read.GetString(1);
                            textnom.Text = read.GetString(2);

                            // El campo productImage primero se almacena en un buffer
                            byte[] imageBuffer = new byte[0];
                            imageBuffer = (byte[])(read[3]);

                            // Se crea un MemoryStream a partir de ese buffer                        
                            if (imageBuffer == null || read[3] == null)
                            {
                                picturelogo.Image = null;
                            }
                            else
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                                picturelogo.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Existe Datos Nulos con el Codigo de Marca Ingresada. \n" + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con la Marca a Modificar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cs.CerrarCnn();
                    }
                }
            }
            cs.CerrarCnn();
        }

        private void openlogo_Click(object sender, EventArgs e)
        {
            img.InitialDirectory = "C:\\";
            img.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            img.Title = "Abrir Imagen de Logotipo";

            if (img.ShowDialog() == DialogResult.OK)
            {
                textlogo.Text = "";
                textlogo.ForeColor = SystemColors.WindowText;
                textlogo.Font = new Font(textlogo.Font, FontStyle.Regular);
                textlogo.Text = img.FileName;
                //fotoCliente.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verboton_Click(object sender, EventArgs e)
        {
            if (textlogo.Text != "" && textlogo.Font.Italic == true)
            {
                if (textlogo.Text == "")
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textlogo.Text == "")
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta o Escriba la Dirección de la Imagen.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                picturelogo.ImageLocation = img.FileName;
            }
        }

        private void deleteboton_Click(object sender, EventArgs e)
        {
            if (textcod.Text != "" && textcod.Font.Italic == true)
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese el Codigo de Registro de la Marca que Muestra en la Tabla de Registro", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo de Registro de la Marca que Muestra en la Tabla de Registro", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo de Registro de la Marca que Muestra en la Tabla de Registro", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de Eliminar Marca.
                if (comprobar() == 1)
                {
                    try
                    {
                        // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "DELETE FROM Marcas WHERE codMarca = '" + Convert.ToInt32(textcod.Text) + "' ;";

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();

                        Messengers mr = new Messengers();
                        mr.textolb.Text = "Marca Eliminada";
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
                    MessageBox.Show("Error, No Existen Registros de la Marca.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Inicializamos la clase Random
            Random r = new Random();

            int[] numeros = new int[6];

            textcod.Text = "";
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);

            //Recorremos el array y vamos asignando a cada
            //posición un número aleatorio
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = r.Next(0, 10);
                textcod.Text = textcod.Text + numeros[i].ToString();
            }
        }

        private void textlogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            textlogo.ForeColor = SystemColors.WindowText;
            textlogo.Font = new Font(textlogo.Font, FontStyle.Regular);
        }


        private int comprobar()
        {
            int cnt = 0;
            string buscar = "SELECT * FROM Marcas WHERE codMarca = '" + Convert.ToInt32(textcod.Text) + "' ; ";

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


        private void saveboton_Click(object sender, EventArgs e)
        {
            if ((textcod.Text != "" && textcod.Font.Italic == true) || textini.Font.Italic == true || textlogo.Font.Italic == true || textnom.Font.Italic == true )
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese o Genere un Código de Registro para la Marca de los Productos.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Ingresar los Datos de la Marca. Caso Contrario dejar en Blanco", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "")
            {
                MessageBox.Show("Ingrese o Genere un Código de Registro para la Marca de los Productos.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textnom.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre o Identificación para la Marca del Producto. ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comprobar() == 0)
                {
                    try
                    {   // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN(); ;
                        cmd.CommandText = "INSERT INTO Marcas VALUES (@id, @ini, @nom, @img)";

                        FileStream stream = new FileStream(textlogo.Text, FileMode.Open, FileAccess.Read);
                        //Se inicializa un flujo de archivo con la imagen seleccionada desde el disco.
                        BinaryReader br = new BinaryReader(stream);
                        FileInfo fi = new FileInfo(textlogo.Text);

                        //Se inicializa un arreglo de Bytes del tamaño de la imagen
                        byte[] binData = new byte[stream.Length];
                        //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
                        //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
                        stream.Read(binData, 0, Convert.ToInt32(stream.Length));

                        ////Se muetra la imagen obtenida desde el flujo de datos
                        picturelogo.Image = Image.FromStream(stream);

                        // Creando los parámetros necesarios
                        cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@ini", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@img", System.Data.SqlDbType.Image);                  

                        // Asignando los valores a los atributos
                        cmd.Parameters["@id"].Value = int.Parse(textcod.Text);
                        cmd.Parameters["@ini"].Value = textini.Text;
                        cmd.Parameters["@nom"].Value = textnom.Text;                        
                        cmd.Parameters["@img"].Value = binData;

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();

                        Messengers mr = new Messengers();
                        mr.textolb.Text = "Marca Guardado";
                        mr.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR. Al Insertar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR. La Marca Ya Existe, Contacte Con el Administrador. ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((textcod.Text != "" && textcod.Font.Italic == true) || textini.Font.Italic == true || textlogo.Font.Italic == true || textnom.Font.Italic == true )
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese o Genere un Código de Registro para la Marca de los Productos.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Ingresar los Datos de la Marca. Caso Contrario dejar en Blanco", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "")
            {
                MessageBox.Show("Ingrese o Genere un Código de Registro para la Marca de los Productos.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textnom.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre o Identificación para la Marca del Producto. ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comprobar() == 1)
                {
                    try
                    {   // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        FileStream stream = new FileStream(textlogo.Text, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(stream);
                        FileInfo fi = new FileInfo(textlogo.Text);

                        byte[] binData = new byte[stream.Length];
                        stream.Read(binData, 0, Convert.ToInt32(stream.Length));

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "UPDATE Marcas SET codMarca=@id, iniMarca=@ini, DescMarca=@nom, logoMarca=@logo WHERE codMarca = @ciid ;";

                        cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@ini", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@logo", System.Data.SqlDbType.Image);
                        cmd.Parameters.Add("@ciid", System.Data.SqlDbType.Int);    

                        // Asignando los valores a los atributos
                        cmd.Parameters["@id"].Value = int.Parse(textcod.Text);
                        cmd.Parameters["@ini"].Value = textini.Text;
                        cmd.Parameters["@nom"].Value = textnom.Text;
                        cmd.Parameters["@logo"].Value = binData;
                        cmd.Parameters["@ciid"].Value = int.Parse(textcod.Text);

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();

                        Messengers mr = new Messengers();
                        mr.textolb.Text = "Marca Modificada";
                        mr.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR. Al Modificar Los Datos. \n" + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con la Marca a Modificar.", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR. La Marca No Existe, Contacte Con el Administrador. ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void titulolabel_Click(object sender, EventArgs e)
        {
            textcod.Text = "";
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);
            textini.Text = "";
            textini.ForeColor = SystemColors.WindowText;
            textini.Font = new Font(textini.Font, FontStyle.Regular);
            textlogo.Text = "";
            textlogo.ForeColor = SystemColors.WindowText;
            textlogo.Font = new Font(textlogo.Font, FontStyle.Regular);
            textnom.Text = "";
            textnom.ForeColor = SystemColors.WindowText;
            textnom.Font = new Font(textnom.Font, FontStyle.Regular);
        }

        private void AEEMarca_Load(object sender, EventArgs e)
        {

        }


    }
}
