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
    public partial class Update_FacturaEmp : Form
    {
        OpenFileDialog im = new OpenFileDialog();
        Conexion cs = new Conexion();
        String id = "3";

        public Update_FacturaEmp()
        {
            InitializeComponent();

            toolTip1.SetToolTip(ndatxt, "Ingresar/Modificar Numero de Autorización");
            toolTip1.SetToolTip(cdctxt, "Ingresar/Modificar Codigo de Control");
            toolTip1.SetToolTip(qrtxt, "Seleccionar la Imagen del codigo Qr para las Facturas");
            toolTip1.SetToolTip(btnOpenQr, "Abrir");
            toolTip1.SetToolTip(logoview, "Codigo Qr Empresarial");
            toolTip1.SetToolTip(button1, "Generar Codigo Qr");
            toolTip1.SetToolTip(saveboton, "Guardar");
            toolTip1.SetToolTip(salirboton, "Salir");
        }

        private void salirboton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenCodeQrEmpresa ge = new GenCodeQrEmpresa();
            ge.ShowDialog();
        }


        private void btnOpenQr_Click(object sender, EventArgs e)
        {
            im.InitialDirectory = "C:\\";
            im.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            im.Title = "Abrir Imagen de Anuncio";

            if (im.ShowDialog() == DialogResult.OK)
            {
                qrtxt.Text = "";
                qrtxt.ForeColor = SystemColors.WindowText;
                qrtxt.Font = new Font(qrtxt.Font, FontStyle.Regular);
                qrtxt.Text = im.FileName;
                logoview.ImageLocation = im.FileName;           
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
                cmd.CommandText = "UPDATE Empresa SET CodeQr=@codeq, numAutoEmp=@numa, codControlEmp = @codc ;";

                // Creando los parámetros necesarios
                cmd.Parameters.Add("@codeq", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@numa", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@codc", System.Data.SqlDbType.VarChar);

                // Asignando el valor de la imagen
                // Stream usado como buffer
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                
                // Se guarda la imagen en el buffer
                logoview.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                // Asignando los valores a los atributos
                cmd.Parameters["@codeq"].Value = ms.GetBuffer();
                cmd.Parameters["@numa"].Value = ndatxt.Text;
                cmd.Parameters["@codc"].Value = cdctxt.Text;

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

        private void Update_FacturaEmp_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Empresa; ";

            SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
            SqlDataReader read;

            try
            {
                c.OpenCnn();
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    ndatxt.Text = read.GetString(18);
                    cdctxt.Text = read.GetString(19);

                    // El campo productImage primero se almacena en un buffer
                    byte[] imageBuffer = (byte[])(read[17]);

                    // Se crea un MemoryStream a partir de ese buffer                        
                    if (imageBuffer == null || read[17] == null)
                    {
                        logoview.Image = null;
                    }
                    else
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        logoview.Image = Image.FromStream(ms);
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
