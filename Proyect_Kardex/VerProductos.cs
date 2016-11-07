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
    public partial class VerProductos : Form
    {
        public Int64 codUser = 0;
        public VerProductos()
        {
            InitializeComponent();
        }

        private void xsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private int comprobar()
        {
            int cnt = 0;
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Productos WHERE CodBarP = '" + codUser + "' ; ";
            d.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, d.GetCONN());
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
            d.CerrarCnn();
            return cnt;
        }


        private void VerProductos_Load(object sender, EventArgs e)
        {
            Conexion s = new Conexion();
            string query = "SELECT * FROM Productos WHERE CodBarP ='" + codUser + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, s.GetCONN());
            s.OpenCnn();
            SqlDataReader read;
            if (comprobar() == 1)
            {
                NomP.Text = "";
                codP.Text = "";
                state.Text = "";
                fechav.Text = "";
                fechaC.Text = "";
                pesoP.Text = "";
                volP.Text = "";
                descP.Text = "";
                MinP.Text = "";
                MaxP.Text = "";
                cantP.Text = "";
                CCUP.Text = "";
                PVUP.Text = "";           

                try
                {
                    read = sqlQ.ExecuteReader();
                    while (read.Read())
                    {
                        NomP.Text = read.GetString(1);
                        codP.Text = read.GetInt64(0).ToString();
                        state.Text = read.GetString(5);                      
                        fechaC.Text = read.GetDateTime(7).ToString();
                        descP.Text = read.GetString(2);
                        pesoP.Text = read.GetDouble(3).ToString();
                        volP.Text = read.GetDouble(4).ToString();
                        MaxP.Text = read.GetInt32(15).ToString();
                        MinP.Text = read.GetInt32(14).ToString();
                        cantP.Text = read.GetInt32(13).ToString();
                        CCUP.Text = read.GetDouble(10).ToString();
                        PVUP.Text = read.GetDouble(11).ToString();                      

                        // El campo productImage primero se almacena en un buffer
                        byte[] imageBuffer = (byte[])(read[8]);
                        byte[] imgcod = (byte[])(read[9]);
                        // Se crea un MemoryStream a partir de ese buffer 
                                               
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        System.IO.MemoryStream mscod = new System.IO.MemoryStream(imgcod);

                        fotoP.Image = Image.FromStream(ms);
                        codFotoP.Image = Image.FromStream(mscod);

                        fechav.Text = read.GetDateTime(6).ToString();
                    }
                    s.CerrarCnn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERROR, Debe Seleccionar un Producto de la Tabla de Registro; Para Proceder la Presentación de los Datos del Producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
