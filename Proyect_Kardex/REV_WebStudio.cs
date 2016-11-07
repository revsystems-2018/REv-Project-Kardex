using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect_Kardex
{
    public partial class REV_WebStudio : Form
    {
        public REV_WebStudio()
        {
            InitializeComponent();

            toolwebstudio.SetToolTip(atraspage, "Pagina Anterior");
            toolwebstudio.SetToolTip(nextpage, "Pagina Siguiente");
            toolwebstudio.SetToolTip(homepage, "Pagina de Inicio");
            toolwebstudio.SetToolTip(stoppage, "Detener");
            toolwebstudio.SetToolTip(updatepage, "Actualizar");
            toolwebstudio.SetToolTip(texturlweb, "Ingresar Dirrección de la Pagina Web");
            toolwebstudio.SetToolTip(gopage, "Ir a la Pagina");
            toolwebstudio.SetToolTip(botonmax, "Maximizar");
            toolwebstudio.SetToolTip(botonmin, "Minimizar");
            toolwebstudio.SetToolTip(xsalir, "Salir");
        }

        private void atraspage_Click(object sender, EventArgs e)
        {
            try
            {
                webBrow.GoBack();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void nextpage_Click(object sender, EventArgs e)
        {
            try
            {
                webBrow.GoForward();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void updatepage_Click(object sender, EventArgs e)
        {
            try
            {
                webBrow.Refresh();
                texturlweb.Text = webBrow.Url.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void stoppage_Click(object sender, EventArgs e)
        {
            try
            {
                webBrow.Stop();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void homepage_Click(object sender, EventArgs e)
        {
            webBrow.GoHome();
            webBrow.Navigate("www.google.com");
            texturlweb.Text = webBrow.Url.ToString();
        }

        private void gopage_Click(object sender, EventArgs e)
        {
            try
            {
                webBrow.Navigate(texturlweb.Text);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void webBrow_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                cargapage.Value = Convert.ToInt32(e.CurrentProgress);
                cargapage.Maximum = Convert.ToInt32(e.CurrentProgress);
            }
            catch (Exception)
            { 
            
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

        private void botonmax_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal){
                
                this.WindowState = FormWindowState.Maximized;
            }
            else{
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void texturlweb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    webBrow.Navigate(texturlweb.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void texturlweb_Click(object sender, EventArgs e)
        {
            texturlweb.SelectAll();
        }
    }
}
