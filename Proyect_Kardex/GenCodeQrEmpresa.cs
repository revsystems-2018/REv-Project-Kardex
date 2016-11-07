using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;

namespace Proyect_Kardex
{
    public partial class GenCodeQrEmpresa : Form
    {
        private int qrBackColor = Color.FromArgb(255, 255, 255, 255).ToArgb();
        private int qrForeColor = Color.FromArgb(255, 0, 0, 0).ToArgb();
        String textcod = "";

        public GenCodeQrEmpresa()
        {
            InitializeComponent();

            toolTip1.SetToolTip(t1, "NIT Emisor");
            toolTip1.SetToolTip(t2, "Número de Factura");
            toolTip1.SetToolTip(t3, "Número de Autorización");
            toolTip1.SetToolTip(t4, "Fecha de Emisión");
            toolTip1.SetToolTip(t5, "Importe de la Compra");
            toolTip1.SetToolTip(t6, "Importe Credito Fiscal");
            toolTip1.SetToolTip(t7, "Codigo de Control");
            toolTip1.SetToolTip(t8, "NIT del Comprador");
            toolTip1.SetToolTip(t9, "Importe ICE");
            toolTip1.SetToolTip(t10, "Importe No Gravadas");
            toolTip1.SetToolTip(t11, "Importe No Sujeto a Credito Fiscal");
            toolTip1.SetToolTip(t12, "Descuentos");
            toolTip1.SetToolTip(verboton, "Generar Codigo");
            toolTip1.SetToolTip(saveboton, "Guardar");
            toolTip1.SetToolTip(salirboton, "Salir");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void verboton_Click(object sender, EventArgs e)
        {
            textcod = t1 + " | " + t2 + " | " + t3 + " | " + t4 + " | " + t5 + " | " + t6 + " | " + t7 + " | " + t8 + " | " + t9 + " | " + t10 + " | " + t11 + " | " + t12;
            if (textcod == String.Empty)
            {
                MessageBox.Show("Ingrese o Genere un Codigo.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            //modo de codificacion.
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
            //Tamaño del pixel.
            qrCodeEncoder.QRCodeScale = 4;
            //Error de Correccion level.           
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;

            //Color del codigo.
            qrCodeEncoder.QRCodeBackgroundColor = System.Drawing.Color.FromArgb(qrBackColor);
            qrCodeEncoder.QRCodeForegroundColor = System.Drawing.Color.FromArgb(qrForeColor);

            logoview.Image = qrCodeEncoder.Encode(textcod, System.Text.Encoding.UTF8);

            saveboton.Enabled = true;

        }

        private void saveboton_Click(object sender, EventArgs e)
        {
            Image imgfinal = (Image)logoview.BackgroundImage.Clone();

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

        private void salirboton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
