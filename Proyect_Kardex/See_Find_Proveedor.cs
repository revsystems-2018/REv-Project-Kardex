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
    public partial class See_Find_Proveedor : Form
    {
        public See_Find_Proveedor()
        {
            InitializeComponent();

            toolTipP.SetToolTip(regboton, "Registro de Proveedores");
            toolTipP.SetToolTip(citext, "Ingresar Codigo de Registro, Nombre, NIT de la Empresa del Proveedor");
            toolTipP.SetToolTip(findbtn, "Buscar Proveedor");
            toolTipP.SetToolTip(botonmax, "Maximizar");
            toolTipP.SetToolTip(botonmin, "Minimizar");
            toolTipP.SetToolTip(xsalir, "Salir");
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

        private void regboton_Click(object sender, EventArgs e)
        {
            Registro_Proveedores sd = new Registro_Proveedores();
            sd.ShowDialog();
            citext.Text = "";
            citext.Text = sd.codUser.ToString();
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
                string buscar = "SELECT * FROM Proveedores WHERE codProve = '" + Convert.ToInt32(citext.Text) + "' ; ";
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
            string buscar = "SELECT * FROM Proveedores WHERE nameEmpProve = '" + citext.Text + "' ; ";
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


        private int comprobarNitEmp() 
        {
            int cnt = 0;
            int num = 0;
            Conexion d = new Conexion();
            Boolean conv = int.TryParse(citext.Text, out num);

            if (conv == true)
            {
                string buscar = "SELECT * FROM Proveedores WHERE nitProve = '" + Convert.ToInt32(citext.Text) + "' ; ";
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
                cisuper.Text = "";
                NDlabel.Text = "";
                apel.Text = "";
                sexo.Text = "";
                fecha.Text = "";
                TDlabel.Text = "";
                CDlabel.Text = "";
                linkLabel1.Text = "";
                linkLabel2.Text = "";
                dirlabel.Text = "";
                state.Text = "";
                NITlabel.Text = "";
                nomEmpresa.Text = "";
                tellabel.Text = "";
                cellabel.Text = "";
                fax1label.Text = "";
                Deplabel.Text = "";

                if (comprobarCodBar() == 1)
                {
                    query = "SELECT * FROM Proveedores WHERE codProve ='" + Convert.ToInt32(citext.Text) + "' ; ";
                    sqlQ = new SqlCommand(query, s.GetCONN());
                    s.OpenCnn();

                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            cisuper.Text = read.GetInt32(1).ToString();
                            NDlabel.Text = read.GetString(2);
                            apel.Text = read.GetString(3);
                            sexo.Text = read.GetString(4);
                            fecha.Text = read.GetString(5);
                            TDlabel.Text = read.GetInt32(6).ToString();
                            CDlabel.Text = read.GetInt32(7).ToString();
                            linkLabel1.Text = read.GetString(8);
                            linkLabel2.Text = read.GetString(9);
                            dirlabel.Text = read.GetString(10);
                            state.Text = read.GetString(12);
                            NITlabel.Text = read.GetInt32(13).ToString();
                            nomEmpresa.Text = read.GetString(14);
                            tellabel.Text = read.GetInt32(15).ToString();
                            cellabel.Text = read.GetInt32(16).ToString();
                            fax1label.Text = read.GetInt32(17).ToString();
                            num = read.GetString(20);
                            Deplabel.Text = ReconocerDepa(num);

                            // El campo productImage primero se almacena en un buffer
                            byte[] imageBuffer = (byte[])(read[18]);
                            // Se crea un MemoryStream a partir de ese buffer                        

                            if (imageBuffer == null || read[18] == null)
                            {
                                logoEmpresa.Image = null;
                            }
                            else
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                                logoEmpresa.Image = Image.FromStream(ms);
                            }
                        }
                        s.CerrarCnn();
                    }
                    catch (Exception) { }

                }
                else if (comprobarName() == 1)
                {
                    query = "SELECT * FROM Proveedores WHERE nameEmpProve ='" + citext.Text + "' ; ";
                    sqlQ = new SqlCommand(query, s.GetCONN());
                    s.OpenCnn();

                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            cisuper.Text = read.GetInt32(1).ToString();
                            NDlabel.Text = read.GetString(2);
                            apel.Text = read.GetString(3);
                            sexo.Text = read.GetString(4);
                            fecha.Text = read.GetString(5);
                            TDlabel.Text = read.GetInt32(6).ToString();
                            CDlabel.Text = read.GetInt32(7).ToString();
                            linkLabel1.Text = read.GetString(8);
                            linkLabel2.Text = read.GetString(9);
                            dirlabel.Text = read.GetString(10);
                            state.Text = read.GetString(12);
                            NITlabel.Text = read.GetInt32(13).ToString();
                            nomEmpresa.Text = read.GetString(14);
                            tellabel.Text = read.GetInt32(15).ToString();
                            cellabel.Text = read.GetInt32(16).ToString();
                            fax1label.Text = read.GetInt32(17).ToString();
                            num = read.GetString(20);
                            Deplabel.Text = ReconocerDepa(num);

                            // El campo productImage primero se almacena en un buffer
                            byte[] imageBuffer = (byte[])(read[18]);
                            // Se crea un MemoryStream a partir de ese buffer                        

                            if (imageBuffer == null || read[18] == null)
                            {
                                logoEmpresa.Image = null;
                            }
                            else
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                                logoEmpresa.Image = Image.FromStream(ms);
                            }
                        }
                        s.CerrarCnn();
                    }
                    catch (Exception) { }

                }
                else if (comprobarNitEmp() == 1)
                {
                    query = "SELECT * FROM Proveedores WHERE nitProve = '" + Convert.ToInt32(citext.Text) + "' ";
                    sqlQ = new SqlCommand(query, s.GetCONN());
                    s.OpenCnn();

                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            cisuper.Text = read.GetInt32(1).ToString();
                            NDlabel.Text = read.GetString(2);
                            apel.Text = read.GetString(3);
                            sexo.Text = read.GetString(4);
                            fecha.Text = read.GetString(5);
                            TDlabel.Text = read.GetInt32(6).ToString();
                            CDlabel.Text = read.GetInt32(7).ToString();
                            linkLabel1.Text = read.GetString(8);
                            linkLabel2.Text = read.GetString(9);
                            dirlabel.Text = read.GetString(10);
                            state.Text = read.GetString(12);
                            NITlabel.Text = read.GetInt32(13).ToString();
                            nomEmpresa.Text = read.GetString(14);
                            tellabel.Text = read.GetInt32(15).ToString();
                            cellabel.Text = read.GetInt32(16).ToString();
                            fax1label.Text = read.GetInt32(17).ToString();
                            num = read.GetString(20);
                            Deplabel.Text = ReconocerDepa(num);

                            // El campo productImage primero se almacena en un buffer
                            byte[] imageBuffer = (byte[])(read[18]);
                            // Se crea un MemoryStream a partir de ese buffer                        

                            if (imageBuffer == null || read[18] == null)
                            {
                                logoEmpresa.Image = null;
                            }
                            else
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                                logoEmpresa.Image = Image.FromStream(ms);
                            }
                        }
                        s.CerrarCnn();
                    }
                    catch (Exception) { }

                }                
                else
                {
                    MessageBox.Show("ERROR. El Proveedor No Esta Registrado. \nReintente Nuevamente... ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    s.CerrarCnn();
                }
            }
        }
    }
}
