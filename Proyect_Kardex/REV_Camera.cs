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

namespace Proyect_Kardex
{
    public partial class REV_Camera : Form
    {
        private FilterInfoCollection CaptureDevice; 
        private VideoCaptureDevice FinalFrame;
        private int num = 0;

        public REV_Camera()
        {
            InitializeComponent();
            toolCamera.SetToolTip(onoff, "Activar/Desactivar");
            toolCamera.SetToolTip(onoff2, "Activar/Desactivar");
            toolCamera.SetToolTip(cbCamara1, "Seleccionar Cámara");
            toolCamera.SetToolTip(cbcamara2, "Seleccionar Cámara");
            toolCamera.SetToolTip(btnChange, "Cambiar Cámara");
            toolCamera.SetToolTip(btnChanges, "Cambiar Cámara");
            toolCamera.SetToolTip(btnPhoto, "Foto");
            toolCamera.SetToolTip(btnPhoto2, "Foto");
            toolCamera.SetToolTip(fotomini, "Ver Fotografia");
            toolCamera.SetToolTip(btnSave, "Guardar");
            toolCamera.SetToolTip(btnSave2, "Guardar");
            toolCamera.SetToolTip(btnLeft, "Ocultar");
        }

        private void REV_Camera_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in CaptureDevice)
            {
                cbCamara1.Items.Add(device.Name);
                cbcamara2.Items.Add(device.Name);
            }
            //cbCamara1.SelectedIndex = 0;
            //cbcamara2.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (cbCamara1.Visible == false)
            {
                cbCamara1.Visible = true;
            }
            else {
                cbCamara1.Visible = false;
            }
        }

        private void btnChanges_Click(object sender, EventArgs e)
        {
            if (cbcamara2.Visible == false)
            {
                cbcamara2.Visible = true;
            }
            else
            {
                cbcamara2.Visible = false;
            }
        }

        private void fotomini_Click(object sender, EventArgs e)
        {
            onoff.Visible = false;
            cbCamara1.Visible = false;
            btnChange.Visible = false;
            fotomini.Visible = false;
            btnPhoto.Visible = false;
            btnSave.Visible = false;
            this.Height = 540;
            this.Width = 605;
            titulo.Visible = true;
            onoff2.Visible = true;
            cbcamara2.Visible = false;
            fotomax.Visible = true;
            btnChanges.Visible = true;
            btnPhoto2.Visible = true;
            btnSave2.Visible = true;
            btnLeft.Visible = true;
            lbphoto.Visible = false;
            lbpunto.Visible = false;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            onoff.Visible = true;
            cbCamara1.Visible = false;
            btnChange.Visible = true;
            fotomini.Visible = true;
            btnPhoto.Visible = true;
            btnSave.Visible = true;
            this.Height = 595;
            this.Width = 413;
            titulo.Visible = false;
            onoff2.Visible = false;
            cbcamara2.Visible = false;
            fotomax.Visible = false;
            btnChanges.Visible = false;
            btnPhoto2.Visible = false;
            btnSave2.Visible = false;
            btnLeft.Visible = false;
            lbphoto.Visible = true;
            lbpunto.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image imgfinal = (Image)fotomax.Image.Clone();

            SaveFileDialog saveimg = new SaveFileDialog();
            saveimg.AddExtension = true;
            saveimg.Filter = "Imagen PNG (*.png)|*.png";
            saveimg.Title = "Guardar Fotografia";
            saveimg.ShowDialog();

            if (!String.IsNullOrEmpty(saveimg.FileName))
            {
                imgfinal.Save(saveimg.FileName, ImageFormat.Png);
            }
            imgfinal.Dispose();
        }

        private void onoff_Click(object sender, EventArgs e)
        {
            try
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[cbCamara1.SelectedIndex].MonikerString);
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);

                if (num == 0 && pictureBox1.Image == null)
                {
                    onoff.BackgroundImage = global::Proyect_Kardex.Properties.Resources.on;
                    onoff2.BackgroundImage = global::Proyect_Kardex.Properties.Resources.on;
                    FinalFrame.Start();
                    num = 1;
                }
                else if (num == 1 && pictureBox1.Image != null)
                {
                    onoff.BackgroundImage = global::Proyect_Kardex.Properties.Resources.offA;
                    onoff2.BackgroundImage = global::Proyect_Kardex.Properties.Resources.offA;
                    FinalFrame.Stop();
                    pictureBox1.Image = null;
                    num = 0;
                }
            }
            catch(Exception){ }
        }

        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch(Exception){}
        }

        private void onoff2_Click(object sender, EventArgs e)
        {
            try
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[cbCamara1.SelectedIndex].MonikerString);
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);

                if (num == 0 && pictureBox1.Image==null)
                {
                    onoff.BackgroundImage = global::Proyect_Kardex.Properties.Resources.on;
                    onoff2.BackgroundImage = global::Proyect_Kardex.Properties.Resources.on;
                    FinalFrame.Start();
                    num = 1;
                }
                else if(num == 1 && pictureBox1.Image != null)
                {
                    onoff.BackgroundImage = global::Proyect_Kardex.Properties.Resources.offA;
                    onoff2.BackgroundImage = global::Proyect_Kardex.Properties.Resources.offA;
                    FinalFrame.Stop();
                    pictureBox1.Image = null;
                    num = 0;
                }
            }
            catch (Exception) { }
        }

        private void REV_Camera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FinalFrame.IsRunning==true)
            {
                FinalFrame.Stop();
            }
            FinalFrame.Stop();
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            fotomini.Image = (Bitmap)pictureBox1.Image.Clone();
            fotomax.Image = (Bitmap)pictureBox1.Image.Clone();
        }

        private void btnPhoto2_Click(object sender, EventArgs e)
        {
            fotomini.Image = (Bitmap)pictureBox1.Image.Clone();
            fotomax.Image = (Bitmap)pictureBox1.Image.Clone();
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            Image imgfinal = (Image)fotomax.Image.Clone();

            SaveFileDialog saveimg = new SaveFileDialog();
            saveimg.AddExtension = true;
            saveimg.Filter = "Imagen PNG (*.png)|*.png";
            saveimg.Title = "Guardar Fotografia";
            saveimg.ShowDialog();

            if (!String.IsNullOrEmpty(saveimg.FileName))
            {
                imgfinal.Save(saveimg.FileName, ImageFormat.Png);
            }
            imgfinal.Dispose();
        }
    }
}
