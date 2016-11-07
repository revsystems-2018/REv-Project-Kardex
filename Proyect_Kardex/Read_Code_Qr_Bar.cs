using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using ZXing;

namespace Proyect_Kardex
{
    public partial class Read_Code_Qr_Bar : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        private int num = 0;
        private Bitmap IMAGEN;
        OpenFileDialog img = new OpenFileDialog();
        public String code = "";


        public Read_Code_Qr_Bar()
        {
            InitializeComponent();
            toolRead.SetToolTip(btnSelect1, "Seleccionar/Enviar Codigo");
            toolRead.SetToolTip(btnSelect2, "Seleccionar/Enviar Codigo");
            toolRead.SetToolTip(btnPlay, "Encender Cámara");
            toolRead.SetToolTip(btnStop, "Apagar Cámara");
            toolRead.SetToolTip(btnScan, "Escanear Codigo");
            toolRead.SetToolTip(btnSalir1, "Salir");
            toolRead.SetToolTip(btnSalir2, "Salir");
            toolRead.SetToolTip(cbCamera, "Seleccionar Cámara");
            toolRead.SetToolTip(btnLoad, "Cargar Imagen del Codigo");
            toolRead.SetToolTip(btnLee, "Decodificar Imagen");

        }

        private void tabScan_Click(object sender, EventArgs e)
        {

        }

        private void Read_Code_Qr_Bar_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in CaptureDevice)
            {
                cbCamera.Items.Add(device.Name);              
            }
            FinalFrame = new VideoCaptureDevice();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[cbCamera.SelectedIndex].MonikerString);
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);

                FinalFrame.Start();
                this.btnPlay.Enabled = false;
                btnPlay.BackgroundImage = global::Proyect_Kardex.Properties.Resources.playGame_B;
                btnScan.Enabled = true;
            }
            catch (Exception) { }
        }

        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {              
                fotoCamera.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (Exception) { }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            FinalFrame.Stop();
            fotoCamera.Image = null;
            btnPlay.Enabled = true;
            btnPlay.BackgroundImage = global::Proyect_Kardex.Properties.Resources.playGame;
            btnScan.Enabled = true;
            timeScan.Stop();
        }

        private void Read_Code_Qr_Bar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void btnSelect1_Click(object sender, EventArgs e)
        {
            code = textScan.Text;
            this.Visible = false;
            timeScan.Stop();
            btnScan.Enabled = true;
        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            code = textLee.Text;
            this.Visible = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            img.InitialDirectory = "C:\\";
            img.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            img.Title = "Abrir Imagen del Codigo";

            if (img.ShowDialog() == DialogResult.OK)
            {
                fotoLee.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timeScan_Tick(object sender, EventArgs e)
        {
            try
            {
                IMAGEN = (Bitmap)fotoCamera.Image;
                BarcodeReader reader = new BarcodeReader();               
                textScan.Text = reader.Decode(IMAGEN).ToString();
            }
            catch (Exception) { }

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            btnScan.Enabled = false;
            timeScan.Interval = 20;
            timeScan.Start();
        }

        private void btnLee_Click(object sender, EventArgs e)
        {
            try
            {            
                BarcodeReader reader = new BarcodeReader();
                textLee.Text = "";
                textLee.Text = reader.Decode((Bitmap)fotoLee.Image).ToString();
            }
            catch (Exception) { }
        }

    }
}
