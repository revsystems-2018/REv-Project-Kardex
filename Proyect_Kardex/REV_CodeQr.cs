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
using System.Drawing.Imaging;

using ThoughtWorks.QRCode;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;
//using ThoughtWorks.QRCode.Codec.Util;


namespace Proyect_Kardex
{
    public partial class REV_CodeQr : Form
    {
        private int qrBackColor = Color.FromArgb(255, 255, 255, 255).ToArgb();
        private int qrForeColor = Color.FromArgb(255, 0, 0, 0).ToArgb();

        public REV_CodeQr()
        {
            InitializeComponent();

            toolTip1.SetToolTip(magicode, "Generar Número de Codigo");
            toolTip1.SetToolTip(eliminarreg, "Borrar Codigo");
            toolTip1.SetToolTip(Buscaritem, "Buscar en Registro");
            toolTip1.SetToolTip(print, "Imprimir");
            toolTip1.SetToolTip(printview, "PRE-Vista");
            toolTip1.SetToolTip(gencode, "Generar Codigo Qr");
            toolTip1.SetToolTip(save, "Guardar");
            toolTip1.SetToolTip(salir, "Salir");
            toolTip1.SetToolTip(textcod, "Ingresar/Generar un Codigo");
            toolTip1.SetToolTip(combotipo, "Seleccionar Calidad");
            toolTip1.SetToolTip(cbMode, "Seleccionar Tipo de Codificación");
            toolTip1.SetToolTip(panelcode, "Doble Click, Escojer Color");
            toolTip1.SetToolTip(panelfondo, "Doble Click, Escojer Color");
            toolTip1.SetToolTip(textPixel, "Ingresar Valor de Pixel");
            toolTip1.SetToolTip(pictucodeQr, "Codigo Qr");
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void magicode_Click(object sender, EventArgs e)
        {
            //Inicializamos la clase Random
            Random r = new Random();

            int[] numeros = new int[13];

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

        private void eliminarreg_Click(object sender, EventArgs e)
        {
            this.pictucodeQr.Image = null;
            this.textcod.Text = "";
            this.textcod.ForeColor = SystemColors.WindowText;
            this.textcod.Font = new Font(textcod.Font, FontStyle.Regular);
            this.gencode.Enabled = true;
            this.save.Enabled = false;
            this.save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.saveblok;
        }

        private int comprobar()
        {
            int cnt = 0;
            Conexion c = new Conexion();
            string buscar = "SELECT * FROM Productos WHERE CodBarP= '" + Convert.ToInt64(textcod.Text) + "' ; ";
            c.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, c.GetCONN());
            try
            {

                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            c.CerrarCnn();
            return cnt;
        }

        private void Buscaritem_Click(object sender, EventArgs e)
        {
            if (textcod.Text != "" && textcod.Font.Italic == true)
            {
                if (textcod.Text == "")
                {
                    MessageBox.Show("Ingrese o Genere un Codigo de Registro para el Producto (13 Digitos).", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese o Genere un Codigo de Registro para el Producto (13 Digitos).", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcod.Text == "")
            {
                MessageBox.Show("Ingrese o Genere un Codigo de Registro para el Producto (13 Digitos).", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (int.Parse(textcod.Text) > 0)
                    {
                        if (comprobar() == 1)
                        {
                            MessageBox.Show("Error, El Codigo Ingresado Ya Existe.\nIngrese o Genere un Codigo Nuevo.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("El Codigo Esta Disponible Para el Registro.\n     Continue el Procedimiento...", "HECHO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, El Texto Ingresado es Incorrecto Para el Registro del Producto.", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, El Texto Ingresado es Incorrecto Para el Registro del Producto. \n" +ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (this.printMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.printDocx.Print();
            }
        }

        private void printview_Click(object sender, EventArgs e)
        {
            printPreview.Document = printDocx;
            printPreview.ShowDialog();
        }

        private void printDocx_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictucodeQr.BackgroundImage, 30, 30, pictucodeQr.BackgroundImage.Width, pictucodeQr.BackgroundImage.Height);
        }

        private void save_Click(object sender, EventArgs e)
        {
            Image imgfinal = (Image)pictucodeQr.BackgroundImage.Clone();

            SaveFileDialog saveimg = new SaveFileDialog();
            saveimg.AddExtension = true;
            saveimg.Filter = "Imagen PNG (*.png)|*.png";
            saveimg.Title = "Guardar Imagen Codigo Qr";
            saveimg.ShowDialog();

            if (!String.IsNullOrEmpty(saveimg.FileName))
            {
                imgfinal.Save(saveimg.FileName, ImageFormat.Png);
            }
            imgfinal.Dispose();
        }

        private void REV_CodeQr_Load(object sender, EventArgs e)
        {
            combotipo.SelectedIndex = 0;
            cbMode.SelectedIndex = 0;
            panelcode.BackColor = Color.FromArgb(qrBackColor);
            panelfondo.BackColor = Color.FromArgb(qrForeColor);
        }

        private void panelcode_DoubleClick(object sender, EventArgs e)
        {
            ColorDialog nColorDGL = new ColorDialog();
            nColorDGL.AllowFullOpen = false;
            nColorDGL.ShowHelp = true;
            nColorDGL.Color = Color.FromArgb(panelcode.BackColor.ToArgb());

            if (nColorDGL.ShowDialog() == DialogResult.OK) 
            {
                panelcode.BackColor = nColorDGL.Color;
                qrBackColor = panelcode.BackColor.ToArgb();
            }
            nColorDGL.Dispose();
        }

        private void panelfondo_DoubleClick(object sender, EventArgs e)
        {
            ColorDialog nColorDGL = new ColorDialog();
            nColorDGL.AllowFullOpen = false;
            nColorDGL.ShowHelp = true;
            nColorDGL.Color = Color.FromArgb(panelfondo.BackColor.ToArgb());

            if (nColorDGL.ShowDialog() == DialogResult.OK)
            {
                panelfondo.BackColor = nColorDGL.Color;
                qrForeColor = panelfondo.BackColor.ToArgb();
            }
            nColorDGL.Dispose();
        }

        private void gencode_Click(object sender, EventArgs e)
        {
            if (textcod.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Ingrese o Genere un Codigo.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textPixel.Text == "") { textPixel.Text = "4"; }

            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            //modo de codificacion.
            String encoding = cbMode.Text;
            if (encoding == "Byte")
            {
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            }
            else if (encoding == "Alpha Numerico")
            {
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
            }
            else if (encoding == "Numerico")
            {
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
            }

            //Tamaño del pixel.
            try
            {
                int scale = Convert.ToInt16(textPixel.Text);
                qrCodeEncoder.QRCodeScale = scale;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tamaño Invalido. \n"+ ex.Message, "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Error de Correccion level.           
            string errorCorrect = combotipo.Text;
            if (errorCorrect == "Bajo (7%)")
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            else if (errorCorrect == "Medio (15%)")
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            else if (errorCorrect == "Calidad (25%)")
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
            else if (errorCorrect == "Alto (30%)")
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;

            //Color del codigo.
            qrCodeEncoder.QRCodeBackgroundColor = System.Drawing.Color.FromArgb(qrBackColor);
            qrCodeEncoder.QRCodeForegroundColor = System.Drawing.Color.FromArgb(qrForeColor);

            try{
                if (checkForza.Checked)
                {          
                    pictucodeQr.Image = qrCodeEncoder.Encode(textcod.Text, System.Text.Encoding.UTF8);
                }
                else
                {
                    pictucodeQr.Image = qrCodeEncoder.Encode(textcod.Text);
                }       
            }
            catch(Exception ex)
            {
                MessageBox.Show("Comprobar Texto Ingresado. \n"+ ex.Message, "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            save.Enabled = true;
            this.save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
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

        private void textcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            textcod.ForeColor = SystemColors.WindowText;
            textcod.Font = new Font(textcod.Font, FontStyle.Regular);
        }


    }
}
