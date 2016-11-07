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
    public partial class VerProveedor : Form
    {
        public int codUser = 0;

        public VerProveedor()
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            REV_WebStudio we = new REV_WebStudio();
            we.texturlweb.Text = linkLabel2.Text;
            we.webBrow.Navigate(linkLabel2.Text);
            we.ShowDialog();
        }


        private int comprobar()
        {
            int cnt = 0;
            Conexion f = new Conexion();
            string buscar = "SELECT * FROM Proveedores WHERE codProve = '" + codUser + "' ; ";
            f.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, f.GetCONN());
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
            f.CerrarCnn();
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


        private void VerProveedor_Load(object sender, EventArgs e)
        {
            String num = "";
            Conexion f = new Conexion();
            string query = "SELECT * FROM Proveedores WHERE codProve ='" + codUser + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, f.GetCONN());
            f.OpenCnn();
            SqlDataReader read;
            if (comprobar() == 1)
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
                    f.CerrarCnn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERROR, Debe Seleccionar un Proveedor de la Tabla de Registro; Para Proceder la Presentación del Perfil del Proveedor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
