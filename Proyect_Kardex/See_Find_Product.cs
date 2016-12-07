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
    public partial class See_Find_Product : Form
    {
        public See_Find_Product()
        {
            InitializeComponent();

            toolTipfind.SetToolTip(citext, "Ingresar el Nombre, Detalle, Codigo de Registro o Codigo de Barras del Producto Registrado ");
            toolTipfind.SetToolTip(findbtn, "Buscar Detalle del Producto");
            toolTipfind.SetToolTip(regboton, "Registro de Productos");
            toolTipfind.SetToolTip(botonmax, "Maximizar");
            toolTipfind.SetToolTip(botonmin, "Minimizar");
            toolTipfind.SetToolTip(xsalir, "Salir");
        }

        private void regboton_Click(object sender, EventArgs e)
        {
            List_Productos rp = new List_Productos();          
            rp.ShowDialog();
            citext.Text = "";
            citext.ForeColor = SystemColors.WindowText;
            citext.Font = new Font(citext.Font, FontStyle.Regular);
            citext.Text = rp.codUser.ToString();        
        }

        private void citext_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (citext.Text != "" && citext.Font.Italic == true)
                {
                    citext.Text = "";
                    citext.ForeColor = SystemColors.WindowText;
                    citext.Font = new Font(citext.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    citext.ForeColor = SystemColors.WindowText;
                    citext.Font = new Font(citext.Font, FontStyle.Regular);
                }
            }
        }

        private void citext_KeyPress(object sender, KeyPressEventArgs e)
        {
            citext.ForeColor = SystemColors.WindowText;
            citext.Font = new Font(citext.Font, FontStyle.Regular);
        }

        private void botonmax_Click(object sender, EventArgs e)
        {
            //NADA
        }

        private void botonmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void xsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private int comprobarCodBar() 
        {
            int cnt = 0;
            long num = 0;
            Conexion d = new Conexion();
            Boolean conv = long.TryParse(citext.Text, out num);

            if (conv == true)
            {
                string buscar = "SELECT * FROM Productos WHERE CodBarP = '" + Convert.ToInt64(citext.Text) + "' ; ";
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
                catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador 1. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else 
            {
                cnt = 0;
            }
            d.CerrarCnn();
            return cnt;
        }


        private int comprobarName() 
        {
            int cnt = 0;
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Productos WHERE nomProd = '" + citext.Text + "' ; ";
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
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador 2. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            d.CerrarCnn();
            return cnt;
        }


        private int comprobarDetalle() 
        {
            int cnt = 0;
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Productos WHERE DescProd LIKE '" + citext.Text + "%'";
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
            catch (Exception) { }
            d.CerrarCnn();
            return cnt;
        }


        private void findbtn_Click(object sender, EventArgs e)
        {
            Conexion s = new Conexion();
            String query = "";
            SqlCommand sqlQ;
            SqlDataReader read;
        
            if (citext.Text != "" && citext.Font.Italic == true)
            {
                if (citext.Text == "")
                {
                    MessageBox.Show("Ingrese el Nombre o Descripción del Producto a Buscar.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    MessageBox.Show("Ingrese el Nombre o Descripción del Producto a Buscar.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (citext.Text == "")
            {
                MessageBox.Show("Ingrese el Nombre o Descripción del Producto a Buscar.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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

                if (comprobarCodBar() == 1)
                {
                    query = "SELECT * FROM Productos WHERE CodBarP ='" + Convert.ToInt64(citext.Text) + "' ; ";
                    sqlQ = new SqlCommand(query, s.GetCONN());
                    s.OpenCnn();

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
                    catch (Exception) { }

                }
                else if (comprobarName() == 1)
                {
                    query = "SELECT * FROM Productos WHERE nomProd ='" + citext.Text + "' ; ";
                    sqlQ = new SqlCommand(query, s.GetCONN());
                    s.OpenCnn();

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
                    catch (Exception) { }

                }
                else if (comprobarDetalle() == 1)
                {
                    query = "SELECT * FROM Productos WHERE DescProd LIKE '" + citext.Text + "%'";
                    sqlQ = new SqlCommand(query, s.GetCONN());
                    s.OpenCnn();

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
                    catch (Exception) { }

                }
                else
                {
                    MessageBox.Show("ERROR. El Producto No Esta Registrado. \nReintente Nuevamente... ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    s.CerrarCnn();
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Read_Code_Qr_Bar rc = new Read_Code_Qr_Bar();
            rc.ShowDialog();
            citext.Text = "";          
            citext.ForeColor = SystemColors.WindowText;
            citext.Font = new Font(citext.Font, FontStyle.Regular);
            citext.Text = rc.code;
        }


    }
}
