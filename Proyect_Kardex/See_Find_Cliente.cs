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
    public partial class See_Find_Cliente : Form
    {
        public int Code = 0;

        public See_Find_Cliente()
        {
            InitializeComponent();
        }

        private void botonmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void xsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void regboton_Click(object sender, EventArgs e)
        {
            Registro_Clientes rc = new Registro_Clientes();
            rc.CodUsr = Code;
            rc.ShowDialog();
            citext.Text = "";
            citext.ForeColor = SystemColors.WindowText;
            citext.Font = new Font(citext.Font, FontStyle.Regular);
            citext.Text = rc.codUser.ToString();
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


        private int comprobarCodBar()
        {
            int cnt = 0;
            int num = 0;
            Conexion d = new Conexion();
            Boolean conv = int.TryParse(citext.Text, out num);

            if (conv == true)
            {
                string buscar = "SELECT * FROM Clientes WHERE idCliente = '" + Convert.ToInt32(citext.Text) + "' ; ";
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
            string buscar = "SELECT * FROM Clientes WHERE nombreCliente = '" + citext.Text + "' ; ";
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
            string buscar = "SELECT * FROM Clientes WHERE apellidoCliente = '" + citext.Text + "' ; ";
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
            string buscar = "SELECT * FROM Clientes WHERE nitCliente = '" + citext.Text + "' ; ";
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


        private void findbtn_Click(object sender, EventArgs e)
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
                nit.Text = "";
                state.Text = "";
                fecha.Text = "";
                sexo.Text = "";
                depa.Text = "";
                dir.Text = "";
                tel.Text = "";
                cel.Text = "";
                fax.Text = "";
                correo.Text = "";
                web.Text = "";

                if (comprobarCodBar() == 1)
                {
                    query = "SELECT * FROM Clientes WHERE idCliente ='" + Convert.ToInt32(citext.Text) + "' ; ";
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
                            nit.Text = read.GetString(3);
                            state.Text = read.GetString(15);
                            fecha.Text = read.GetString(11);
                            sexo.Text = read.GetString(7);
                            dir.Text = read.GetString(6);
                            tel.Text = read.GetInt32(8).ToString();
                            cel.Text = read.GetInt32(9).ToString();
                            fax.Text = read.GetInt32(10).ToString();
                            correo.Text = read.GetString(4);
                            web.Text = read.GetString(5);
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
                    query = "SELECT * FROM Clientes WHERE nombreCliente ='" + citext.Text + "' ; ";
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
                            nit.Text = read.GetString(3);
                            state.Text = read.GetString(15);
                            fecha.Text = read.GetString(11);
                            sexo.Text = read.GetString(7);
                            dir.Text = read.GetString(6);
                            tel.Text = read.GetInt32(8).ToString();
                            cel.Text = read.GetInt32(9).ToString();
                            fax.Text = read.GetInt32(10).ToString();
                            correo.Text = read.GetString(4);
                            web.Text = read.GetString(5);
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
                    query = "SELECT * FROM Clientes WHERE apellidoCliente = '" + citext.Text + "' ";
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
                            nit.Text = read.GetString(3);
                            state.Text = read.GetString(15);
                            fecha.Text = read.GetString(11);
                            sexo.Text = read.GetString(7);
                            dir.Text = read.GetString(6);
                            tel.Text = read.GetInt32(8).ToString();
                            cel.Text = read.GetInt32(9).ToString();
                            fax.Text = read.GetInt32(10).ToString();
                            correo.Text = read.GetString(4);
                            web.Text = read.GetString(5);
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
                    query = "SELECT * FROM Clientes WHERE nitCliente = '" + citext.Text + "' ";
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
                            nit.Text = read.GetString(3);
                            state.Text = read.GetString(15);
                            fecha.Text = read.GetString(11);
                            sexo.Text = read.GetString(7);
                            dir.Text = read.GetString(6);
                            tel.Text = read.GetInt32(8).ToString();
                            cel.Text = read.GetInt32(9).ToString();
                            fax.Text = read.GetInt32(10).ToString();
                            correo.Text = read.GetString(4);
                            web.Text = read.GetString(5);
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
                    MessageBox.Show("ERROR. El Cliente No Esta Registrado. \nReintente Nuevamente... ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    s.CerrarCnn();
                }
            }
        }
    }
}
