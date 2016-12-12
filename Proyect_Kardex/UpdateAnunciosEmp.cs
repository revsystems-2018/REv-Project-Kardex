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
    public partial class UpdateAnunciosEmp : Form
    {
        OpenFileDialog im = new OpenFileDialog();
        OpenFileDialog im2 = new OpenFileDialog();
        Conexion cs = new Conexion();

        public UpdateAnunciosEmp()
        {
            InitializeComponent();

            toolTipUA.SetToolTip(anun1, "Imagen del Primer Anuncio");
            toolTipUA.SetToolTip(anun2, "Imagen del Segundo Anuncio");
            toolTipUA.SetToolTip(PAtxt, "Seleccionar Imagen del Primer Anuncio Comercial");
            toolTipUA.SetToolTip(SPtxt, "Seleccionar Imagen del Segundo Anuncio Comercial");
            toolTipUA.SetToolTip(saveboton, "Guardar");
            toolTipUA.SetToolTip(salirboton, "Salir");
            toolTipUA.SetToolTip(btn1, "Abrir");
            toolTipUA.SetToolTip(btn2, "Abrir");
        }

        private void salirboton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            im.InitialDirectory = "C:\\";
            im.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            im.Title = "Abrir Imagen de Anuncio";

            if (im.ShowDialog() == DialogResult.OK)
            {
                PAtxt.Text = "";
                PAtxt.ForeColor = SystemColors.WindowText;
                PAtxt.Font = new Font(PAtxt.Font, FontStyle.Regular);
                PAtxt.Text = im.FileName;
                anun1.ImageLocation = im.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            im2.InitialDirectory = "C:\\";
            im2.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            im2.Title = "Abrir Imagen de Anuncio";

            if (im2.ShowDialog() == DialogResult.OK)
            {
                SPtxt.Text = "";
                SPtxt.ForeColor = SystemColors.WindowText;
                SPtxt.Font = new Font(SPtxt.Font, FontStyle.Regular);
                SPtxt.Text = im2.FileName;
                anun2.ImageLocation = im2.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveboton_Click(object sender, EventArgs e)
        {
            try
            {   // Objetos de conexión y comando
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = cs.GetCONN();
                cmd.CommandText = "UPDATE Empresa SET anuncio1Emp=@codeq, anuncio2Emp=@numa ;";

                // Creando los parámetros necesarios
                cmd.Parameters.Add("@codeq", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@numa", System.Data.SqlDbType.Image);

                // Asignando el valor de la imagen
                // Stream usado como buffer
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                System.IO.MemoryStream ms2 = new System.IO.MemoryStream();

                // Se guarda la imagen en el buffer
                anun1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                anun2.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Png);

                // Asignando los valores a los atributos
                cmd.Parameters["@codeq"].Value = ms.GetBuffer();
                cmd.Parameters["@numa"].Value = ms2.GetBuffer();

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

        private void SPtxt_MouseClick(object sender, MouseEventArgs e)
        {
            SPtxt.ForeColor = SystemColors.WindowText;
            SPtxt.Font = new Font(SPtxt.Font, FontStyle.Regular);
        }

        private void UpdateAnunciosEmp_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Empresa; ";

            SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
            SqlDataReader read;

            SPtxt.Text = "";
            SPtxt.ForeColor = SystemColors.WindowText;
            SPtxt.Font = new Font(SPtxt.Font, FontStyle.Regular);

            PAtxt.Text = "";
            PAtxt.ForeColor = SystemColors.WindowText;
            PAtxt.Font = new Font(PAtxt.Font, FontStyle.Regular);

            try
            {
                cs.OpenCnn();
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    // El campo productImage primero se almacena en un buffer
                    byte[] imageBuffer = (byte[])(read[10]);
                    byte[] imageBuffer2 = (byte[])(read[11]);

                    // Se crea un MemoryStream a partir de ese buffer                        
                    if (imageBuffer == null || read[10] == null)
                    {
                        anun1.Image = null;
                    }
                    else if (imageBuffer2 == null || read[11] == null) 
                    {
                        anun2.Image = null;
                    }
                    else
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        System.IO.MemoryStream ms2 = new System.IO.MemoryStream(imageBuffer2); 
                        anun1.Image = Image.FromStream(ms);
                        anun2.Image = Image.FromStream(ms2);
                    }
                }
                cs.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe Datos Nulos con la Empresa Ingresada. \n" + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con la Empresa a Registrar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cs.CerrarCnn();
            }
        }
    }
}
