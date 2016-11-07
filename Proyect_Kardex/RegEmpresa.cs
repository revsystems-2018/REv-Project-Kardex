using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;

namespace Proyect_Kardex
{
    public partial class RegEmpresa : Form
    {
        ValidacionText m = new ValidacionText();
        OpenFileDialog im = new OpenFileDialog();
        Conexion cs = new Conexion();
        String id = "3";

        public RegEmpresa()
        {
            InitializeComponent();

            toolreem.SetToolTip(NITtext, "NIT de la Empresa");
            toolreem.SetToolTip(Nomtext,"Nombres del Dueño");
            toolreem.SetToolTip(Apetext, "Apellidos del Dueño");
            toolreem.SetToolTip(tel1text, "Teléfono del Dueño");
            toolreem.SetToolTip(tel2text, "Celular del Dueño");
            toolreem.SetToolTip(NEtext, "Nombre de la Empresa");
            toolreem.SetToolTip(Dirtext, "Dirección de la Empresa (Google Maps)");
            toolreem.SetToolTip(depcombo, "Departamento donde se Ubica la Empresa");
            toolreem.SetToolTip(procombo, "Provincia donde se Ubica el Empresa");
            toolreem.SetToolTip(TEtext, "Teléfono de la Empresa");
            toolreem.SetToolTip(CEtext, "Celular de la Empresa");
            toolreem.SetToolTip(Fax1text, "Número de Fax de la Empresa");
            toolreem.SetToolTip(Fax2text, "Número de Fax de la Empresa");
            toolreem.SetToolTip(logotext, "Ubicación del Logotipo de la Empresa");
            toolreem.SetToolTip(emailtext, "Correo Electronico");
            toolreem.SetToolTip(webtext, "Pagina Web de la Empresa");
            toolreem.SetToolTip(ima1text, "Ubicación de la Imagen de los Anuncios de la Empresa");
            toolreem.SetToolTip(ima2text, "Ubicación de la Imagen de los Anuncios de la Empresa");
            toolreem.SetToolTip(open1, "Abrir");
            toolreem.SetToolTip(open2, "Abrir");
            toolreem.SetToolTip(open3, "Abrir");
            toolreem.SetToolTip(verboton, "Ver Logotipo");
            toolreem.SetToolTip(saveboton, "Guardar");
            toolreem.SetToolTip(salirboton, "Salir");
        }

        public void CargarDatos() 
        {   //Codigo de Seleccionar datos Empresa.
            Conexion r = new Conexion();
            string query = "SELECT * FROM Empresa; ";

            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
            SqlDataReader read;

            NITtext.Text = "";
            NITtext.ForeColor = SystemColors.WindowText;
            NITtext.Font = new Font(NITtext.Font, FontStyle.Regular);
            Nomtext.Text = "";
            Nomtext.ForeColor = SystemColors.WindowText;
            Nomtext.Font = new Font(Nomtext.Font, FontStyle.Regular);
            Apetext.Text = "";
            Apetext.ForeColor = SystemColors.WindowText;
            Apetext.Font = new Font(Apetext.Font, FontStyle.Regular);
            tel1text.Text = "";
            tel1text.ForeColor = SystemColors.WindowText;
            tel1text.Font = new Font(tel1text.Font, FontStyle.Regular);
            tel2text.Text = "";
            tel2text.ForeColor = SystemColors.WindowText;
            tel2text.Font = new Font(tel2text.Font, FontStyle.Regular);
            NEtext.Text = "";
            NEtext.ForeColor = SystemColors.WindowText;
            NEtext.Font = new Font(NEtext.Font, FontStyle.Regular);
            Dirtext.Text = "";
            Dirtext.ForeColor = SystemColors.WindowText;
            Dirtext.Font = new Font(Dirtext.Font, FontStyle.Regular);
            ima1text.Text = "";
            ima1text.ForeColor = SystemColors.WindowText;
            ima1text.Font = new Font(ima1text.Font, FontStyle.Regular);
            ima2text.Text = "";
            ima2text.ForeColor = SystemColors.WindowText;
            ima2text.Font = new Font(ima2text.Font, FontStyle.Regular);
            TEtext.Text = "";
            TEtext.ForeColor = SystemColors.WindowText;
            TEtext.Font = new Font(TEtext.Font, FontStyle.Regular);
            CEtext.Text = "";
            CEtext.ForeColor = SystemColors.WindowText;
            CEtext.Font = new Font(CEtext.Font, FontStyle.Regular);
            Fax1text.Text = "";
            Fax1text.ForeColor = SystemColors.WindowText;
            Fax1text.Font = new Font(Fax1text.Font, FontStyle.Regular);
            Fax2text.Text = "";
            Fax2text.ForeColor = SystemColors.WindowText;
            Fax2text.Font = new Font(Fax2text.Font, FontStyle.Regular);
            logotext.Text = "";
            logotext.ForeColor = SystemColors.WindowText;
            logotext.Font = new Font(logotext.Font, FontStyle.Regular);
            emailtext.Text = "";
            emailtext.ForeColor = SystemColors.WindowText;
            emailtext.Font = new Font(emailtext.Font, FontStyle.Regular);
            webtext.Text = "";
            webtext.ForeColor = SystemColors.WindowText;
            webtext.Font = new Font(webtext.Font, FontStyle.Regular);

                try
                {
                    r.OpenCnn();
                    read = sqlQ.ExecuteReader();
                    while (read.Read())
                    {
                        NITtext.Text = read.GetString(0);
                        NEtext.Text = read.GetString(1);
                        Dirtext.Text = read.GetString(2);
                        TEtext.Text = read.GetInt32(3).ToString();
                        CEtext.Text = read.GetInt32(4).ToString();
                        Fax1text.Text = read.GetInt32(5).ToString();
                        Fax2text.Text = read.GetInt32(6).ToString();
                        emailtext.Text = read.GetString(7);
                        webtext.Text = read.GetString(8);
                        Nomtext.Text = read.GetString(12);
                        Apetext.Text = read.GetString(13);
                        tel1text.Text = read.GetInt32(14).ToString();
                        tel2text.Text = read.GetInt32(15).ToString();                      

                        // El campo productImage primero se almacena en un buffer
                        byte[] imageBuffer = (byte[])(read[9]);
                        byte[] imageBuffer2 = (byte[])(read[10]);
                        byte[] imageBuffer3 = (byte[])(read[11]); 
                        // Se crea un MemoryStream a partir de ese buffer                        

                        if (imageBuffer == null || read[13] == null)
                        {
                            logoview.Image = null;
                        }
                        else
                        {
                            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                            System.IO.MemoryStream ms2 = new System.IO.MemoryStream(imageBuffer2);
                            System.IO.MemoryStream ms3 = new System.IO.MemoryStream(imageBuffer3);
                            logoview.Image = Image.FromStream(ms);
                            img1.Image = Image.FromStream(ms2);
                            img2.Image = Image.FromStream(ms3);
                        }
                    }
                    r.CerrarCnn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Existe Datos Nulos con la Empresa Ingresada. \n" + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con la Empresa a Registrar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r.CerrarCnn();
                }       
        }


        private void RegEmpresa_Load(object sender, EventArgs e)
        {
            CargarDatos();
            Conexion r = new Conexion();
            string query = "SELECT * FROM Departamento; ";

            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
            r.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(1);
                    depcombo.Items.Add(Scad);
                }
                r.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nitnum(object sender, KeyPressEventArgs e)
        {           
            NITtext.ForeColor = SystemColors.WindowText;
            NITtext.Font = new Font(NITtext.Font, FontStyle.Regular); 
            m.soloNumeros(e);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void telDueno(object sender, KeyPressEventArgs e)
        {
            tel1text.ForeColor = SystemColors.WindowText;
            tel1text.Font = new Font(tel1text.Font, FontStyle.Regular);
            m.soloNumeros(e);
        }

        private void celdueno(object sender, KeyPressEventArgs e)
        {
            tel2text.ForeColor = SystemColors.WindowText;
            tel2text.Font = new Font(tel2text.Font, FontStyle.Regular);
            m.soloNumeros(e);
        }

        private void teleemp(object sender, KeyPressEventArgs e)
        {
            TEtext.ForeColor = SystemColors.WindowText;
            TEtext.Font = new Font(TEtext.Font, FontStyle.Regular);
            m.soloNumeros(e);
        }

        private void celemp(object sender, KeyPressEventArgs e)
        {
            CEtext.ForeColor = SystemColors.WindowText;
            CEtext.Font = new Font(CEtext.Font, FontStyle.Regular);
            m.soloNumeros(e);
        }

        private void fax1emp(object sender, KeyPressEventArgs e)
        {
            Fax1text.ForeColor = SystemColors.WindowText;
            Fax1text.Font = new Font(Fax1text.Font, FontStyle.Regular);
            m.soloNumeros(e);
        }

        private void fax2emp(object sender, KeyPressEventArgs e)
        {
            Fax2text.ForeColor = SystemColors.WindowText;
            Fax2text.Font = new Font(Fax2text.Font, FontStyle.Regular);
            m.soloNumeros(e);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void open1_Click(object sender, EventArgs e)
        {
            im.InitialDirectory = "C:\\";
            im.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            im.Title = "Abrir Imagen de Logotipo";

            if (im.ShowDialog() == DialogResult.OK)
            {
                logotext.Text = "";
                logotext.ForeColor = SystemColors.WindowText;
                logotext.Font = new Font(logotext.Font, FontStyle.Regular);
                logotext.Text = im.FileName;
                //fotoCliente.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verboton_Click(object sender, EventArgs e)
        {
            if (logotext.Text != "" && logotext.Font.Italic == true)
            {
                if (logotext.Text == "")
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (logotext.Text == "")
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta o Escriba la Dirección de la Imagen.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                logoview.ImageLocation = im.FileName;
            }
        }

        private void open2_Click(object sender, EventArgs e)
        {
            im.InitialDirectory = "C:\\";
            im.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            im.Title = "Abrir Imagen de Anuncio";

            if (im.ShowDialog() == DialogResult.OK)
            {
                ima1text.Text = "";
                ima1text.ForeColor = SystemColors.WindowText;
                ima1text.Font = new Font(ima1text.Font, FontStyle.Regular);
                ima1text.Text = im.FileName;
                img1.ImageLocation = im.FileName;
                //fotoCliente.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void open3_Click(object sender, EventArgs e)
        {
            im.InitialDirectory = "C:\\";
            im.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            im.Title = "Abrir Imagen de Anuncio";

            if (im.ShowDialog() == DialogResult.OK)
            {
                ima2text.Text = "";
                ima2text.ForeColor = SystemColors.WindowText;
                ima2text.Font = new Font(ima2text.Font, FontStyle.Regular);
                ima2text.Text = im.FileName;
                img2.ImageLocation = im.FileName;
                //fotoCliente.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nitempClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (NITtext.Text != "" && NITtext.Font.Italic == true)
                {
                    NITtext.Text = "";
                    NITtext.ForeColor = SystemColors.WindowText;
                    NITtext.Font = new Font(NITtext.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    NITtext.ForeColor = SystemColors.WindowText;
                    NITtext.Font = new Font(NITtext.Font, FontStyle.Regular);
                }
            }
        }

        private void nombdueClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (Nomtext.Text != "" && Nomtext.Font.Italic == true)
                {
                    Nomtext.Text = "";
                    Nomtext.ForeColor = SystemColors.WindowText;
                    Nomtext.Font = new Font(Nomtext.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    Nomtext.ForeColor = SystemColors.WindowText;
                    Nomtext.Font = new Font(Nomtext.Font, FontStyle.Regular);
                }
            }
        }

        private void apelldueClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (Apetext.Text != "" && Apetext.Font.Italic == true)
                {
                    Apetext.Text = "";
                    Apetext.ForeColor = SystemColors.WindowText;
                    Apetext.Font = new Font(Apetext.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    Apetext.ForeColor = SystemColors.WindowText;
                    Apetext.Font = new Font(Apetext.Font, FontStyle.Regular);
                }
            }
        }

        private void teldueClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (tel1text.Text != "" && tel1text.Font.Italic == true)
                {
                    tel1text.Text = "";
                    tel1text.ForeColor = SystemColors.WindowText;
                    tel1text.Font = new Font(tel1text.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    tel1text.ForeColor = SystemColors.WindowText;
                    tel1text.Font = new Font(tel1text.Font, FontStyle.Regular);
                }
            }
        }

        private void celdueClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (tel2text.Text != "" && tel2text.Font.Italic == true)
                {
                    tel2text.Text = "";
                    tel2text.ForeColor = SystemColors.WindowText;
                    tel2text.Font = new Font(tel2text.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    tel2text.ForeColor = SystemColors.WindowText;
                    tel2text.Font = new Font(tel2text.Font, FontStyle.Regular);
                }
            }
        }

        private void nameEmpClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (NEtext.Text != "" && NEtext.Font.Italic == true)
                {
                    NEtext.Text = "";
                    NEtext.ForeColor = SystemColors.WindowText;
                    NEtext.Font = new Font(NEtext.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    NEtext.ForeColor = SystemColors.WindowText;
                    NEtext.Font = new Font(NEtext.Font, FontStyle.Regular);
                }
            }
        }

        private void dirempClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (Dirtext.Text != "" && Dirtext.Font.Italic == true)
                {
                    Dirtext.Text = "";
                    Dirtext.ForeColor = SystemColors.WindowText;
                    Dirtext.Font = new Font(Dirtext.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    Dirtext.ForeColor = SystemColors.WindowText;
                    Dirtext.Font = new Font(Dirtext.Font, FontStyle.Regular);
                }
            }
        }

        private void anun1empClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (ima1text.Text != "" && ima1text.Font.Italic == true)
                {
                    ima1text.Text = "";
                    ima1text.ForeColor = SystemColors.WindowText;
                    ima1text.Font = new Font(ima1text.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    ima1text.ForeColor = SystemColors.WindowText;
                    ima1text.Font = new Font(ima1text.Font, FontStyle.Regular);
                }
            }
        }

        private void anun2empClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (ima2text.Text != "" && ima2text.Font.Italic == true)
                {
                    ima2text.Text = "";
                    ima2text.ForeColor = SystemColors.WindowText;
                    ima2text.Font = new Font(ima2text.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    ima2text.ForeColor = SystemColors.WindowText;
                    ima2text.Font = new Font(ima2text.Font, FontStyle.Regular);
                }
            }
        }

        private void telempClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (TEtext.Text != "" && TEtext.Font.Italic == true)
                {
                    TEtext.Text = "";
                    TEtext.ForeColor = SystemColors.WindowText;
                    TEtext.Font = new Font(TEtext.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    TEtext.ForeColor = SystemColors.WindowText;
                    TEtext.Font = new Font(TEtext.Font, FontStyle.Regular);
                }
            }
        }

        private void celempClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (CEtext.Text != "" && CEtext.Font.Italic == true)
                {
                    CEtext.Text = "";
                    CEtext.ForeColor = SystemColors.WindowText;
                    CEtext.Font = new Font(CEtext.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    CEtext.ForeColor = SystemColors.WindowText;
                    CEtext.Font = new Font(CEtext.Font, FontStyle.Regular);
                }
            }
        }

        private void fax1empClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (Fax1text.Text != "" && Fax1text.Font.Italic == true)
                {
                    Fax1text.Text = "";
                    Fax1text.ForeColor = SystemColors.WindowText;
                    Fax1text.Font = new Font(Fax1text.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    Fax1text.ForeColor = SystemColors.WindowText;
                    Fax1text.Font = new Font(Fax1text.Font, FontStyle.Regular);
                }
            }
        }

        private void fax2empClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (Fax2text.Text != "" && Fax2text.Font.Italic == true)
                {
                    Fax2text.Text = "";
                    Fax2text.ForeColor = SystemColors.WindowText;
                    Fax2text.Font = new Font(Fax2text.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    Fax2text.ForeColor = SystemColors.WindowText;
                    Fax2text.Font = new Font(Fax2text.Font, FontStyle.Regular);
                }
            }
        }

        private void logoempClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (logotext.Text != "" && logotext.Font.Italic == true)
                {
                    logotext.Text = "";
                    logotext.ForeColor = SystemColors.WindowText;
                    logotext.Font = new Font(logotext.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    logotext.ForeColor = SystemColors.WindowText;
                    logotext.Font = new Font(logotext.Font, FontStyle.Regular);
                }
            }
        }

        private void corrempClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (emailtext.Text != "" && emailtext.Font.Italic == true)
                {
                    emailtext.Text = "";
                    emailtext.ForeColor = SystemColors.WindowText;
                    emailtext.Font = new Font(emailtext.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    emailtext.ForeColor = SystemColors.WindowText;
                    emailtext.Font = new Font(emailtext.Font, FontStyle.Regular);
                }
            }
        }

        private void webempClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (webtext.Text != "" && webtext.Font.Italic == true)
                {
                    webtext.Text = "";
                    webtext.ForeColor = SystemColors.WindowText;
                    webtext.Font = new Font(webtext.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    webtext.ForeColor = SystemColors.WindowText;
                    webtext.Font = new Font(webtext.Font, FontStyle.Regular);
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

        private void emailtext_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(emailtext.Text))
            {

            }
            else
            {
                MessageBox.Show("Dirrección de Correo Electrónico No Valida. El Correo Debe Tener El Formato: nombre@dominio.com  Porfavor Seleccione un Correo Electroónico Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                emailtext.SelectAll();
                emailtext.Focus();
            }
        }

        private void weboton_Click(object sender, EventArgs e)
        {
            if (webtext.Text != "" && webtext.Font.Italic == true)
            {
                if (webtext.Text == "")
                {
                    MessageBox.Show("Ingrese la Dirección de la Pagina Web de la Empresa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese la Dirección de la Pagina Web de la Empresa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (webtext.Text == "")
            {
                MessageBox.Show("Ingrese la Dirección de la Pagina Web de la Empresa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                REV_WebStudio we = new REV_WebStudio();
                we.texturlweb.Text = webtext.Text;
                we.webBrow.Navigate(webtext.Text);
                we.ShowDialog();
            }
        }

        private void tituloemp_Click(object sender, EventArgs e)
        {
            NITtext.Text = "";
            NITtext.ForeColor = SystemColors.WindowText;
            NITtext.Font = new Font(NITtext.Font, FontStyle.Regular);
            Nomtext.Text = "";
            Nomtext.ForeColor = SystemColors.WindowText;
            Nomtext.Font = new Font(Nomtext.Font, FontStyle.Regular);
            Apetext.Text = "";
            Apetext.ForeColor = SystemColors.WindowText;
            Apetext.Font = new Font(Apetext.Font, FontStyle.Regular);
            tel1text.Text = "";
            tel1text.ForeColor = SystemColors.WindowText;
            tel1text.Font = new Font(tel1text.Font, FontStyle.Regular);
            tel2text.Text = "";
            tel2text.ForeColor = SystemColors.WindowText;
            tel2text.Font = new Font(tel2text.Font, FontStyle.Regular);
            NEtext.Text = "";
            NEtext.ForeColor = SystemColors.WindowText;
            NEtext.Font = new Font(NEtext.Font, FontStyle.Regular);
            Dirtext.Text = "";
            Dirtext.ForeColor = SystemColors.WindowText;
            Dirtext.Font = new Font(Dirtext.Font, FontStyle.Regular);
            ima1text.Text = "";
            ima1text.ForeColor = SystemColors.WindowText;
            ima1text.Font = new Font(ima1text.Font, FontStyle.Regular);
            ima2text.Text = "";
            ima2text.ForeColor = SystemColors.WindowText;
            ima2text.Font = new Font(ima2text.Font, FontStyle.Regular);
            TEtext.Text = "";
            TEtext.ForeColor = SystemColors.WindowText;
            TEtext.Font = new Font(TEtext.Font, FontStyle.Regular);
            CEtext.Text = "";
            CEtext.ForeColor = SystemColors.WindowText;
            CEtext.Font = new Font(CEtext.Font, FontStyle.Regular);
            Fax1text.Text = "";
            Fax1text.ForeColor = SystemColors.WindowText;
            Fax1text.Font = new Font(Fax1text.Font, FontStyle.Regular);
            Fax2text.Text = "";
            Fax2text.ForeColor = SystemColors.WindowText;
            Fax2text.Font = new Font(Fax2text.Font, FontStyle.Regular);
            logotext.Text = "";
            logotext.ForeColor = SystemColors.WindowText;
            logotext.Font = new Font(logotext.Font, FontStyle.Regular);
            emailtext.Text = "";
            emailtext.ForeColor = SystemColors.WindowText;
            emailtext.Font = new Font(emailtext.Font, FontStyle.Regular);
            webtext.Text = "";
            webtext.ForeColor = SystemColors.WindowText;
            webtext.Font = new Font(webtext.Font, FontStyle.Regular);
        }

        private void Nomtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            Nomtext.ForeColor = SystemColors.WindowText;
            Nomtext.Font = new Font(Nomtext.Font, FontStyle.Regular);
            m.soloLetras(e);
        }

        private void Apetext_KeyPress(object sender, KeyPressEventArgs e)
        {
            Apetext.ForeColor = SystemColors.WindowText;
            Apetext.Font = new Font(Apetext.Font, FontStyle.Regular);
            m.soloLetras(e);
        }

        private void NEtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            NEtext.ForeColor = SystemColors.WindowText;
            NEtext.Font = new Font(NEtext.Font, FontStyle.Regular);
            m.soloLetras(e);
        }

        private void Dirtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dirtext.ForeColor = SystemColors.WindowText;
            Dirtext.Font = new Font(Dirtext.Font, FontStyle.Regular);
            //m.soloLetras(e);
        }

        private void ima1text_KeyPress(object sender, KeyPressEventArgs e)
        {
            ima1text.ForeColor = SystemColors.WindowText;
            ima1text.Font = new Font(ima1text.Font, FontStyle.Regular);           
        }

        private void ima2text_KeyPress(object sender, KeyPressEventArgs e)
        {
            ima2text.ForeColor = SystemColors.WindowText;
            ima2text.Font = new Font(ima2text.Font, FontStyle.Regular);
        }

        private void logotext_KeyPress(object sender, KeyPressEventArgs e)
        {
            logotext.ForeColor = SystemColors.WindowText;
            logotext.Font = new Font(logotext.Font, FontStyle.Regular);
        }

        private void emailtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            emailtext.ForeColor = SystemColors.WindowText;
            emailtext.Font = new Font(emailtext.Font, FontStyle.Regular);
        }

        private void webtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            webtext.ForeColor = SystemColors.WindowText;
            webtext.Font = new Font(webtext.Font, FontStyle.Regular);
        }

        private void depcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion r = new Conexion();
            string query = "SELECT nombrePro, CodDep FROM Provincia, Departamento WHERE CodDep=codigoDep AND nombreDep= '" + depcombo.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
            SqlDataReader read;
            try
            {
                r.OpenCnn();
                read = sqlQ.ExecuteReader();
                procombo.Items.Clear();
                while (read.Read())
                {
                    String cade = read.GetString(0);
                    procombo.Items.Add(cade);
                    id = read.GetString(1);
                }
                r.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }   
        }

        private void saveboton_Click(object sender, EventArgs e)
        {           
            if ((NITtext.Text != "" && NITtext.Font.Italic == true) || Nomtext.Font.Italic == true || NEtext.Font.Italic == true || Apetext.Font.Italic == true || tel1text.Font.Italic == true || TEtext.Font.Italic == true || CEtext.Font.Italic == true || tel2text.Font.Italic == true || Dirtext.Font.Italic == true || emailtext.Font.Italic == true || webtext.Font.Italic == true)
            {
                if (NITtext.Text == "")
                {
                    MessageBox.Show("Ingrese el Número de NIT de la Empresa de Administración", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Número de NIT de la Empresa de Administración", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (NITtext.Text == "")
            {
                MessageBox.Show("Ingrese el Número de NIT de la Empresa de Administración", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NEtext.Text == "")
            {
                MessageBox.Show("Ingrese el Nombre de la Empresa de Administración ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Nomtext.Text == "")
            {
                MessageBox.Show("Ingrese el Nombre del Dueño de la Empresa de Administración", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //Codigo de guardar usuario.            
                try
                {   // Objetos de conexión y comando
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                    // Estableciento propiedades
                    cmd.Connection = cs.GetCONN();
                    cmd.CommandText = "UPDATE Empresa SET nitEmp=@id, nombreEmp=@name, DirEmp=@dire, telEmp=@tele, celEmp=@cele, fax1Emp=@fax1, fax2Emp=@fax2, emailEmp=@email, webEmp=@web, logoEmp=@logo, anuncio1Emp=@anu1, anuncio2Emp=@anu2, nombreDueño=@nomd, apeDueño=@aped, telDueño=@teld, celDueño=@celd, CodDepaE=@codd, CodeQr=@codeq ;";

                    // Creando los parámetros necesarios
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@dire", System.Data.SqlDbType.Text);
                    cmd.Parameters.Add("@tele", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@cele", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@fax1", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@fax2", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@web", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@logo", System.Data.SqlDbType.Image);
                    cmd.Parameters.Add("@anu1", System.Data.SqlDbType.Image);
                    cmd.Parameters.Add("@anu2", System.Data.SqlDbType.Image);
                    cmd.Parameters.Add("@nomd", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@aped", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@teld", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@celd", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@codeq", System.Data.SqlDbType.Image);

                    // Asignando el valor de la imagen
                    // Stream usado como buffer
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    System.IO.MemoryStream n1 = new System.IO.MemoryStream();
                    System.IO.MemoryStream n2 = new System.IO.MemoryStream();
                    System.IO.MemoryStream n3 = new System.IO.MemoryStream();
                    // Se guarda la imagen en el buffer
                    logoview.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    img2.Image.Save(n1, System.Drawing.Imaging.ImageFormat.Jpeg);
                    img1.Image.Save(n2, System.Drawing.Imaging.ImageFormat.Jpeg);
                    img3.Image.Save(n3, System.Drawing.Imaging.ImageFormat.Png);

                    // Asignando los valores a los atributos
                    cmd.Parameters["@id"].Value = NITtext.Text;
                    cmd.Parameters["@name"].Value = NEtext.Text;
                    cmd.Parameters["@dire"].Value = Dirtext.Text;
                    cmd.Parameters["@tele"].Value = int.Parse(TEtext.Text);
                    cmd.Parameters["@cele"].Value = int.Parse(CEtext.Text);
                    cmd.Parameters["@fax1"].Value = int.Parse(Fax1text.Text);
                    cmd.Parameters["@fax2"].Value = int.Parse(Fax2text.Text);
                    cmd.Parameters["@email"].Value = emailtext.Text;
                    cmd.Parameters["@web"].Value = webtext.Text;
                    cmd.Parameters["@logo"].Value = ms.GetBuffer();
                    cmd.Parameters["@anu1"].Value = n1.GetBuffer();
                    cmd.Parameters["@anu2"].Value = n2.GetBuffer();
                    cmd.Parameters["@nomd"].Value = Nomtext.Text;
                    cmd.Parameters["@aped"].Value = Apetext.Text;
                    cmd.Parameters["@teld"].Value = int.Parse(tel1text.Text);
                    cmd.Parameters["@celd"].Value = int.Parse(tel2text.Text);
                    cmd.Parameters["@codd"].Value = id;
                    cmd.Parameters["@codeq"].Value = n3.GetBuffer();

                    cs.OpenCnn();
                    cmd.ExecuteNonQuery();
                    cs.CerrarCnn();

                    Messengers mr = new Messengers();
                    mr.textolb.Text = "Datos Guardado";
                    mr.ShowDialog();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR. Al Insertar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    }
                }

        private void button2_Click(object sender, EventArgs e)
        {
            GenCodeQrEmpresa re = new GenCodeQrEmpresa();
            re.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            im.InitialDirectory = "C:\\";
            im.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            im.Title = "Abrir Imagen de Anuncio";

            if (im.ShowDialog() == DialogResult.OK)
            {
                txtcodeqr.Text = "";
                txtcodeqr.ForeColor = SystemColors.WindowText;
                txtcodeqr.Font = new Font(txtcodeqr.Font, FontStyle.Regular);
                txtcodeqr.Text = im.FileName;
                img3.ImageLocation = im.FileName;
                //fotoCliente.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcodeqr_MouseClick(object sender, MouseEventArgs e)
        {
            txtcodeqr.ForeColor = SystemColors.WindowText;
            txtcodeqr.Font = new Font(txtcodeqr.Font, FontStyle.Regular);
        }

    }
}
