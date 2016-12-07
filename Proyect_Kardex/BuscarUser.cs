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
    public partial class BuscarUser : Form
    {
        public int CodUser = 7906442;

        public BuscarUser()
        {
            InitializeComponent();
            
            toolfind.SetToolTip(regboton,"Registro de Usuarios");
            toolfind.SetToolTip(citext, "Ingresar carnet de Identidad, Nombre de Usuario, Nombre o Apellido del Usuario");
            toolfind.SetToolTip(findbtn, "Buscar Usuario");
            toolfind.SetToolTip(botonmax, "Maximizar");
            toolfind.SetToolTip(botonmin, "Minimizar");
            toolfind.SetToolTip(xsalir, "Salir");

        }

        private void civerUser(object sender, KeyPressEventArgs e)
        {
            citext.ForeColor = SystemColors.WindowText;
            citext.Font = new Font(citext.Font, FontStyle.Regular);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (citext.Text != "" && citext.Font.Italic == true)
            {
                if (citext.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (citext.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Width = 517;
                this.Height = 360; //360
                this.foto.Visible = false;
                this.nom.Visible = false;
                this.apellido.Visible = false;
                this.ci.Visible = false;
                this.label5.Visible = false;
                this.nivel.Visible = false;
                this.label6.Visible = false;
                this.user.Visible = false;
                this.label9.Visible = false;
                this.cargo.Visible = false;
                this.depa.Visible = false;
                this.dir.Visible = false;
                this.label4.Visible = false;
                this.correo.Visible = false;
                this.label15.Visible = false;
                this.tel.Visible = false;
                this.label16.Visible = false;
                this.cel.Visible = false;
                this.label17.Visible = false;
                this.fax.Visible = false;         
                //codigo de busqueda.
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ciUserClick(object sender, MouseEventArgs e)
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

        private void xsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void regboton_Click(object sender, EventArgs e)
        {
            Registro_Usuario sd = new Registro_Usuario();
            sd.CodUsr = CodUser;
            sd.ShowDialog();
            citext.Text = "";
            citext.Text = sd.codUser.ToString();
            citext.ForeColor = SystemColors.WindowText;
            citext.Font = new Font(citext.Font, FontStyle.Regular);
        }

        private void botonmax_Click(object sender, EventArgs e)
        {
            //NADA
        }


        private int comprobarCodBar()
        {
            int cnt = 0;
            int num = 0;
            Conexion d = new Conexion();
            Boolean conv = int.TryParse(citext.Text, out num);

            if (conv == true)
            {
                string buscar = "SELECT * FROM Usuario WHERE ciUser = '" + Convert.ToInt32(citext.Text) + "' ; ";
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
            string buscar = "SELECT * FROM Usuario WHERE nombreUser = '" + citext.Text + "' ; ";
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

        private int comprobarApe() 
        {
            int cnt = 0;
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Usuario WHERE apeUser = '" + citext.Text + "' ; ";
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

        private int comprobarNameUsr() 
        {
            int cnt = 0;
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Usuario WHERE nuUsuario = '" + citext.Text + "' ; ";
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


        private String ReconocerDepa(String cod)
        {
            String res = "";
            Conexion d = new Conexion();
            string query = "SELECT nombreDep FROM Departamento WHERE codigoDep ='" + cod + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
            d.OpenCnn();
            SqlDataReader read;
            try
            {
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    res = read.GetString(0);
                }
            }
            catch (Exception) { }
            d.CerrarCnn();
            return res;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Conexion s = new Conexion();
            String num = "";
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
                else
                {
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
                nom.Text = "";
                apellido.Text = "";
                ci.Text = "";
                nivel.Text = "";
                user.Text = "";
                cargo.Text = "";
                sexo.Text = "";
                depa.Text = "";
                dir.Text = "";
                tel.Text = "";
                cel.Text = "";
                fax.Text = "";
                correo.Text = "";   

                if (comprobarCodBar() == 1)
                {
                    query = "SELECT * FROM Usuario WHERE ciUser ='" + Convert.ToInt32(citext.Text) + "' ; ";
                    sqlQ = new SqlCommand(query, s.GetCONN());
                    s.OpenCnn();

                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            nom.Text = read.GetString(1);
                            apellido.Text = read.GetString(2);
                            ci.Text = read.GetInt32(0).ToString();
                            nivel.Text = read.GetString(6);
                            user.Text = read.GetString(3);
                            cargo.Text = read.GetString(7);
                            sexo.Text = read.GetString(8);
                            dir.Text = read.GetString(5);
                            tel.Text = read.GetInt32(10).ToString();
                            cel.Text = read.GetInt32(11).ToString();
                            fax.Text = read.GetInt32(12).ToString();
                            correo.Text = read.GetString(14);
                            num = read.GetString(16);
                            depa.Text = ReconocerDepa(num);

                            // El campo productImage primero se almacena en un buffer
                            byte[] imageBuffer = (byte[])(read[13]);
                            // Se crea un MemoryStream a partir de ese buffer                        

                            if (imageBuffer == null || read[13] == null)
                            {
                                foto.Image = null;
                            }
                            else
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                                foto.Image = Image.FromStream(ms);
                            }
                        }
                        s.CerrarCnn();
                    }
                    catch (Exception) { }

                }
                else if (comprobarName() == 1)
                {
                    query = "SELECT * FROM Usuario WHERE nombreUser ='" + citext.Text + "' ; ";
                    sqlQ = new SqlCommand(query, s.GetCONN());
                    s.OpenCnn();

                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            nom.Text = read.GetString(1);
                            apellido.Text = read.GetString(2);
                            ci.Text = read.GetInt32(0).ToString();
                            nivel.Text = read.GetString(6);
                            user.Text = read.GetString(3);
                            cargo.Text = read.GetString(7);
                            sexo.Text = read.GetString(8);
                            dir.Text = read.GetString(5);
                            tel.Text = read.GetInt32(10).ToString();
                            cel.Text = read.GetInt32(11).ToString();
                            fax.Text = read.GetInt32(12).ToString();
                            correo.Text = read.GetString(14);
                            num = read.GetString(16);
                            depa.Text = ReconocerDepa(num);

                            // El campo productImage primero se almacena en un buffer
                            byte[] imageBuffer = (byte[])(read[13]);
                            // Se crea un MemoryStream a partir de ese buffer                        

                            if (imageBuffer == null || read[13] == null)
                            {
                                foto.Image = null;
                            }
                            else
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                                foto.Image = Image.FromStream(ms);
                            }
                        }
                        s.CerrarCnn();
                    }
                    catch (Exception) { }

                }
                else if (comprobarApe() == 1)
                {
                    query = "SELECT * FROM Usuario WHERE apeUser = '" + citext.Text + "' ";
                    sqlQ = new SqlCommand(query, s.GetCONN());
                    s.OpenCnn();

                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            nom.Text = read.GetString(1);
                            apellido.Text = read.GetString(2);
                            ci.Text = read.GetInt32(0).ToString();
                            nivel.Text = read.GetString(6);
                            user.Text = read.GetString(3);
                            cargo.Text = read.GetString(7);
                            sexo.Text = read.GetString(8);
                            dir.Text = read.GetString(5);
                            tel.Text = read.GetInt32(10).ToString();
                            cel.Text = read.GetInt32(11).ToString();
                            fax.Text = read.GetInt32(12).ToString();
                            correo.Text = read.GetString(14);
                            num = read.GetString(16);
                            depa.Text = ReconocerDepa(num);

                            // El campo productImage primero se almacena en un buffer
                            byte[] imageBuffer = (byte[])(read[13]);
                            // Se crea un MemoryStream a partir de ese buffer                        

                            if (imageBuffer == null || read[13] == null)
                            {
                                foto.Image = null;
                            }
                            else
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                                foto.Image = Image.FromStream(ms);
                            }
                        }
                        s.CerrarCnn();
                    }
                    catch (Exception) { }

                }
                else if (comprobarNameUsr() == 1)
                {
                    query = "SELECT * FROM Usuario WHERE nuUsuario = '" + citext.Text + "' ";
                    sqlQ = new SqlCommand(query, s.GetCONN());
                    s.OpenCnn();

                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            nom.Text = read.GetString(1);
                            apellido.Text = read.GetString(2);
                            ci.Text = read.GetInt32(0).ToString();
                            nivel.Text = read.GetString(6);
                            user.Text = read.GetString(3);
                            cargo.Text = read.GetString(7);
                            sexo.Text = read.GetString(8);
                            dir.Text = read.GetString(5);
                            tel.Text = read.GetInt32(10).ToString();
                            cel.Text = read.GetInt32(11).ToString();
                            fax.Text = read.GetInt32(12).ToString();
                            correo.Text = read.GetString(14);
                            num = read.GetString(16);
                            depa.Text = ReconocerDepa(num);

                            // El campo productImage primero se almacena en un buffer
                            byte[] imageBuffer = (byte[])(read[13]);
                            // Se crea un MemoryStream a partir de ese buffer                        

                            if (imageBuffer == null || read[13] == null)
                            {
                                foto.Image = null;
                            }
                            else
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                                foto.Image = Image.FromStream(ms);
                            }
                        }
                        s.CerrarCnn();
                    }
                    catch (Exception) { }

                }
                else
                {
                    MessageBox.Show("ERROR. El Usuario No Esta Registrado. \nReintente Nuevamente... ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    s.CerrarCnn();
                }
            }
        }

    }
}
