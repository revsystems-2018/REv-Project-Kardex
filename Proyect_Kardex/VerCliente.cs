﻿using System;
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
    public partial class VerCliente : Form
    {
        public int codUser = 0;

        public VerCliente()
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            REV_WebStudio we = new REV_WebStudio();
            we.texturlweb.Text = web.Text;
            we.webBrow.Navigate(web.Text);
            we.ShowDialog();
        }


        private int comprobar()
        {
            int cnt = 0;
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Clientes WHERE idCliente= '" + codUser + "' ; ";
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


        private void VerCliente_Load(object sender, EventArgs e)
        {           
            String num = "";
            Conexion d = new Conexion();
            string query = "SELECT * FROM Clientes WHERE idCliente ='" + codUser + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
            d.OpenCnn();
            SqlDataReader read;
            if (comprobar() == 1)
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
                    d.CerrarCnn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERROR, Debe Seleccionar un Cliente de la Tabla de Registro; Para Proceder la Presentación del Perfil del Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
