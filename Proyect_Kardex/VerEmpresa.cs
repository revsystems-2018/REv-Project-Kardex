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
    public partial class VerEmpresa : Form
    {
        public VerEmpresa()
        {
            InitializeComponent();
        }


         private int comprobar()
        {
            int cnt = 0;
            Conexion s = new Conexion();
            string buscar = "SELECT * FROM Empresa ; ";
            s.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, s.GetCONN());
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
            s.CerrarCnn();
            return cnt;
        }


         private String ReconocerDepa(String cod)
         {
            String res = "";
            Conexion s = new Conexion();
            string query = "SELECT nombreDep FROM Departamento WHERE codigoDep ='" + cod + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, s.GetCONN());
            s.OpenCnn();
            SqlDataReader read;
            try
            {
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    res = read.GetString(0);
                }
            }
            catch(Exception){}
            s.CerrarCnn();
            return res;
        }


        private void VerEmpresa_Load(object sender, EventArgs e)
        {
            String num = "";
            Conexion d = new Conexion();
            string query = "SELECT * FROM Empresa ; ";

            SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
            d.OpenCnn();
            SqlDataReader read;
            if (comprobar() == 1)
            {
                nomEmp.Text = "";           
                NITlabel.Text = "";        
                NDlabel.Text = "";    
                apel.Text = "";                
                TDlabel.Text = "";                
                CDlabel.Text = "";
                Deplabel.Text = "";
                dirlabel.Text = "";
                tellabel.Text = "";
                cellabel.Text = "";
                fax1label.Text = "";
                fax2label.Text = "";
                linkLabel1.Text = ""; 
                linkLabel2.Text = "";

                try
                {
                    read = sqlQ.ExecuteReader();
                    while (read.Read())
                    {
                        nomEmp.Text = read.GetString(1);
                        NITlabel.Text = read.GetString(0);
                        NDlabel.Text = read.GetString(12);
                        apel.Text = read.GetString(13);
                        TDlabel.Text = read.GetInt32(14).ToString();
                        CDlabel.Text = read.GetInt32(15).ToString();
                        dirlabel.Text = read.GetString(2);
                        tellabel.Text = read.GetInt32(3).ToString();
                        cellabel.Text = read.GetInt32(4).ToString();
                        fax1label.Text = read.GetInt32(5).ToString();
                        fax2label.Text = read.GetInt32(6).ToString();
                        linkLabel1.Text = read.GetString(7);
                        linkLabel2.Text = read.GetString(8);
                        num = read.GetString(16);
                        Deplabel.Text = ReconocerDepa(num);

                        // El campo productImage primero se almacena en un buffer
                        byte[] imageBuffer = (byte[])(read[9]);
                        // Se crea un MemoryStream a partir de ese buffer                        

                        if (imageBuffer == null || read[9] == null)
                        {
                            logoEmp.Image = null;
                        }
                        else
                        {
                            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                            logoEmp.Image = Image.FromStream(ms);
                        }

                    }
                    d.CerrarCnn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERROR, Debe Registrar Una Empresa donde Se Desea Administrar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            REV_WebStudio we = new REV_WebStudio();
            we.texturlweb.Text = linkLabel2.Text;
            we.webBrow.Navigate(linkLabel2.Text);
            we.ShowDialog();
        }


    }
  }
