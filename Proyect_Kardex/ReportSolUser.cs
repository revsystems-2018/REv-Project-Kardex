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
    public partial class ReportSolUser : Form
    {
        ValidacionText mn = new ValidacionText();
        OpenFileDialog ima = new OpenFileDialog();
        Conexion cs = new Conexion();
        String id = "3";
        int pos = 0;
        int i = 0;

        public ReportSolUser()
        {
            InitializeComponent();

            toolReportUser.SetToolTip(buscarcic, "Ingresar Carnet de Identidad para Proceder la Busqueda");
            toolReportUser.SetToolTip(regtext, "Registro de Usuarios");
            toolReportUser.SetToolTip(nuevo, "Nuevo Usuario");
            toolReportUser.SetToolTip(editar, "Editar Usuario");
            toolReportUser.SetToolTip(eliminar, "Eliminar Usuario");
            toolReportUser.SetToolTip(actualizar, "Actualizar");
            toolReportUser.SetToolTip(print, "Imprimir");
            toolReportUser.SetToolTip(verimagen, "Ver Fotografia");
            toolReportUser.SetToolTip(save, "Guardar");
            toolReportUser.SetToolTip(salir, "Salir");
            toolReportUser.SetToolTip(searchci, "Buscar");
            toolReportUser.SetToolTip(cire, "Carnet de Identidad del Usuario");
            toolReportUser.SetToolTip(nomre, "Nombres del Usuario");
            toolReportUser.SetToolTip(apere, "Apellidos del Usuario");
            toolReportUser.SetToolTip(namere, "Nombre de Identificacion al Sistema");
            toolReportUser.SetToolTip(passre, "Contraseña para el Usuario");
            toolReportUser.SetToolTip(confpasre, "Repetir misma Contraseña");
            toolReportUser.SetToolTip(dirre, "Dirección del Usuario");
            toolReportUser.SetToolTip(depare, "Departamento donde Vive el Usuario");
            toolReportUser.SetToolTip(provre, "Provincia donde Vive el Usuario");
            toolReportUser.SetToolTip(fotore, "Ubicación de la Fotografia del Usuario");
            toolReportUser.SetToolTip(openre, "Abrir");
            toolReportUser.SetToolTip(nivre, "Nivel de Estudios del Usuario");
            toolReportUser.SetToolTip(cargore, "Cargo de Ocupación de Trabajo con la Empresa");
            toolReportUser.SetToolTip(faxre, "Numero de Fax del Usuario");
            toolReportUser.SetToolTip(celre, "Celular del Cliente");
            toolReportUser.SetToolTip(telre, "Teléfono del Cliente");
            toolReportUser.SetToolTip(corre, "Correo Electrónico");
            toolReportUser.SetToolTip(dia, "Dia");
            toolReportUser.SetToolTip(mes, "Mes");
            toolReportUser.SetToolTip(anno, "Año");


        }

        private void salir_Click(object sender, EventArgs e)
        {
            string message = "Esta Seguro que Desea Salir de las Solicitudes de los Usuarios?";
            string caption = "Salir";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            { // Closes the parent form.
                this.Close();
            }
        }

        private void cifindnum(object sender, KeyPressEventArgs e)
        {
            buscarcic.ForeColor = SystemColors.WindowText;
            buscarcic.Font = new Font(buscarcic.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void cinum(object sender, KeyPressEventArgs e)
        {
            cire.ForeColor = SystemColors.WindowText;
            cire.Font = new Font(cire.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void faxnum(object sender, KeyPressEventArgs e)
        {
            faxre.ForeColor = SystemColors.WindowText;
            faxre.Font = new Font(faxre.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void celnum(object sender, KeyPressEventArgs e)
        {
            celre.ForeColor = SystemColors.WindowText;
            celre.Font = new Font(celre.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void telnum(object sender, KeyPressEventArgs e)
        {
            telre.ForeColor = SystemColors.WindowText;
            telre.Font = new Font(telre.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void nomlet(object sender, KeyPressEventArgs e)
        {
            nomre.ForeColor = SystemColors.WindowText;
            nomre.Font = new Font(nomre.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void apeleteer(object sender, KeyPressEventArgs e)
        {
            apere.ForeColor = SystemColors.WindowText;
            apere.Font = new Font(apere.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void cargoletter(object sender, KeyPressEventArgs e)
        {
            cargore.ForeColor = SystemColors.WindowText;
            cargore.Font = new Font(cargore.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.buscarcic.Enabled = false;
            this.searchci.Enabled = false;
            this.searchci.Visible = false;
            this.cire.Enabled = true;
            this.nomre.Enabled = true;
            this.apere.Enabled = true;
            this.namere.Enabled = true;
            this.passre.Enabled = true;
            this.confpasre.Enabled = true;
            this.dirre.Enabled = true;
            this.depare.Enabled = true;
            this.provre.Enabled = true;
            this.fotore.Enabled = true;
            this.nivre.Enabled = true;
            this.cargore.Enabled = true;
            this.openre.Enabled = true;
            this.faxre.Enabled = true;
            this.celre.Enabled = true;
            this.telre.Enabled = true;
            this.corre.Enabled = true;
            this.dia.Enabled = true;
            this.mes.Enabled = true;
            this.anno.Enabled = true;
            this.sex.Enabled = true;
        }

        private int comprobar()
        {
            int cnt = 0;
            Conexion a = new Conexion();
            string buscar = "SELECT * FROM SolUser WHERE ciSolU= '" + Convert.ToInt32(buscarcic.Text) + "' ; ";
            a.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, a.GetCONN());
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
            a.CerrarCnn();
            return cnt;
        }


        private void editar_Click(object sender, EventArgs e)
        {
            if (buscarcic.Text != "" && buscarcic.Font.Italic == true)
            {
                if (buscarcic.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (buscarcic.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.buscarcic.Enabled = true;
                this.searchci.Enabled = true;
                this.searchci.Visible = true;
                this.cire.Enabled = true;
                this.nomre.Enabled = true;
                this.apere.Enabled = true;
                this.namere.Enabled = true;
                this.passre.Enabled = true;
                this.confpasre.Enabled = true;
                this.dirre.Enabled = true;
                this.depare.Enabled = true;
                this.provre.Enabled = true;
                this.fotore.Enabled = true;
                this.nivre.Enabled = true;
                this.cargore.Enabled = true;
                this.openre.Enabled = true;
                this.faxre.Enabled = true;
                this.celre.Enabled = true;
                this.telre.Enabled = true;
                this.corre.Enabled = true;
                this.dia.Enabled = true;
                this.mes.Enabled = true;
                this.anno.Enabled = true;
                this.sex.Enabled = true;

                //Codigo de Editar Usuario de la Tabla de Solicitudes.
                Conexion s = new Conexion();
                string query = "SELECT * FROM SolUser WHERE ciSolU ='" + Convert.ToInt32(buscarcic.Text) + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, s.GetCONN());
                s.OpenCnn();
                SqlDataReader read;
                if (comprobar() == 1)
                {
                    cire.Text = "";
                    cire.ForeColor = SystemColors.WindowText;
                    cire.Font = new Font(cire.Font, FontStyle.Regular);
                    nomre.Text = "";
                    nomre.ForeColor = SystemColors.WindowText;
                    nomre.Font = new Font(nomre.Font, FontStyle.Regular);
                    apere.Text = "";
                    apere.ForeColor = SystemColors.WindowText;
                    apere.Font = new Font(apere.Font, FontStyle.Regular);
                    namere.Text = "";
                    namere.ForeColor = SystemColors.WindowText;
                    namere.Font = new Font(namere.Font, FontStyle.Regular);
                    dirre.Text = "";
                    dirre.ForeColor = SystemColors.WindowText;
                    dirre.Font = new Font(dirre.Font, FontStyle.Regular);
                    fotore.Text = "";
                    fotore.ForeColor = SystemColors.WindowText;
                    fotore.Font = new Font(fotore.Font, FontStyle.Regular);
                    corre.Text = "";
                    corre.ForeColor = SystemColors.WindowText;
                    corre.Font = new Font(corre.Font, FontStyle.Regular);
                    telre.Text = "";
                    telre.ForeColor = SystemColors.WindowText;
                    telre.Font = new Font(telre.Font, FontStyle.Regular);
                    celre.Text = "";
                    celre.ForeColor = SystemColors.WindowText;
                    celre.Font = new Font(celre.Font, FontStyle.Regular);
                    faxre.Text = "";
                    faxre.ForeColor = SystemColors.WindowText;
                    faxre.Font = new Font(faxre.Font, FontStyle.Regular);
                    cargore.Text = "";
                    cargore.ForeColor = SystemColors.WindowText;
                    cargore.Font = new Font(cargore.Font, FontStyle.Regular);

                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            cire.Text = read.GetInt32(1).ToString();
                            nomre.Text = read.GetString(2);
                            apere.Text = read.GetString(3);
                            namere.Text = read.GetString(4);
                            passre.Text = read.GetString(5);
                            confpasre.Text = read.GetString(5);
                            dirre.Text = read.GetString(6);
                            corre.Text = read.GetString(9);
                            telre.Text = read.GetInt32(10).ToString();
                            celre.Text = read.GetInt32(11).ToString();
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
                    MessageBox.Show("ERROR, El Usuario Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            this.buscarcic.Enabled = true;
            this.searchci.Enabled = true;
            this.searchci.Visible = true;
            this.cire.Enabled = false;
            this.nomre.Enabled = false;
            this.apere.Enabled = false;
            this.namere.Enabled = false;
            this.passre.Enabled = false;
            this.confpasre.Enabled = false;
            this.dirre.Enabled = false;
            this.depare.Enabled = false;
            this.provre.Enabled = false;
            this.fotore.Enabled = false;
            this.nivre.Enabled = false;
            this.cargore.Enabled = false;
            this.openre.Enabled = false;
            this.faxre.Enabled = false;
            this.celre.Enabled = false;
            this.telre.Enabled = false;
            this.corre.Enabled = false;
            this.dia.Enabled = false;
            this.mes.Enabled = false;
            this.anno.Enabled = false;
            this.sex.Enabled = false;

            if (buscarcic.Text != "" && buscarcic.Font.Italic == true)
            {
                if (buscarcic.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (buscarcic.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //Codigo de Eliminar Usuario de la Tabla de Solicitudes.
                if (comprobar() == 1)
                {
                    try
                    {   // Objetos de conexión y comando                        
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "DELETE FROM SolUser WHERE ciSolU = '" + Convert.ToInt32(buscarcic.Text) + "' ;";

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();

                        Messengers mr = new Messengers();
                        mr.textolb.Text = "Usuario Eliminado";
                        mr.ShowDialog();
                        //this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR. Al Eliminar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, No Existen Registros del Usuario.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openre_Click(object sender, EventArgs e)
        {
            ima.InitialDirectory = "C:\\";
            ima.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            ima.Title = "Abrir Fotografia del Usuario";

            if (ima.ShowDialog() == DialogResult.OK)
            {
                fotore.Text = "";
                fotore.ForeColor = SystemColors.WindowText;
                fotore.Font = new Font(fotore.Font, FontStyle.Regular);
                fotore.Text = ima.FileName;
                //fotoCliente.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verimagen_Click(object sender, EventArgs e)
        {
            if (fotore.Text != "" && fotore.Font.Italic == true)
            {
                if (fotore.Text == "")
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (fotore.Text == "")
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta o Escriba la Dirección de la Imagen.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fotoUser.ImageLocation = ima.FileName;
            }
        }

        private void regtext_Click(object sender, EventArgs e)
        {
            Registro_Usuario ru = new Registro_Usuario();
            ru.ShowDialog();
        }

        private void searchci_Click(object sender, EventArgs e)
        {
            if (buscarcic.Text != "" && buscarcic.Font.Italic == true)
            {
                if (buscarcic.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (buscarcic.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //Codigo de Buscar Usuario.

                this.buscarcic.Enabled = true;
                this.searchci.Enabled = true;
                this.searchci.Visible = true;
                this.cire.Enabled = true;
                this.nomre.Enabled = true;
                this.apere.Enabled = true;

                //Codigo de Editar Usuario de la Tabla de Solicitudes.
                Conexion d = new Conexion();
                string query = "SELECT * FROM SolUser WHERE ciSolU ='" + Convert.ToInt32(buscarcic.Text) + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
                d.OpenCnn();
                SqlDataReader read;
                if (comprobar() == 1)
                {
                    cire.Text = "";
                    cire.ForeColor = SystemColors.WindowText;
                    cire.Font = new Font(cire.Font, FontStyle.Regular);
                    nomre.Text = "";
                    nomre.ForeColor = SystemColors.WindowText;
                    nomre.Font = new Font(nomre.Font, FontStyle.Regular);
                    apere.Text = "";
                    apere.ForeColor = SystemColors.WindowText;
                    apere.Font = new Font(apere.Font, FontStyle.Regular);
                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            cire.Text = read.GetInt32(1).ToString();
                            nomre.Text = read.GetString(2);
                            apere.Text = read.GetString(3);
                        }                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    d.CerrarCnn();
                }
                else
                {
                    MessageBox.Show("ERROR, El Usuario Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cirepsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (cire.Text != "" && cire.Font.Italic == true)
                {
                    cire.Text = "";
                    cire.ForeColor = SystemColors.WindowText;
                    cire.Font = new Font(cire.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    cire.ForeColor = SystemColors.WindowText;
                    cire.Font = new Font(cire.Font, FontStyle.Regular);
                }
            }
        }

        private void cibuscarregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (buscarcic.Text != "" && buscarcic.Font.Italic == true)
                {
                    buscarcic.Text = "";
                    buscarcic.ForeColor = SystemColors.WindowText;
                    buscarcic.Font = new Font(buscarcic.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    buscarcic.ForeColor = SystemColors.WindowText;
                    buscarcic.Font = new Font(buscarcic.Font, FontStyle.Regular);
                }
            }
        }

        private void nombregsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nomre.Text != "" && nomre.Font.Italic == true)
                {
                    nomre.Text = "";
                    nomre.ForeColor = SystemColors.WindowText;
                    nomre.Font = new Font(nomre.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nomre.ForeColor = SystemColors.WindowText;
                    nomre.Font = new Font(nomre.Font, FontStyle.Regular);
                }
            }
        }

        private void aperegsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (apere.Text != "" && apere.Font.Italic == true)
                {
                    apere.Text = "";
                    apere.ForeColor = SystemColors.WindowText;
                    apere.Font = new Font(apere.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    apere.ForeColor = SystemColors.WindowText;
                    apere.Font = new Font(apere.Font, FontStyle.Regular);
                }
            }
        }

        private void nameregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (namere.Text != "" && namere.Font.Italic == true)
                {
                    namere.Text = "";
                    namere.ForeColor = SystemColors.WindowText;
                    namere.Font = new Font(namere.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    namere.ForeColor = SystemColors.WindowText;
                    namere.Font = new Font(namere.Font, FontStyle.Regular);
                }
            }
        }

        private void dirregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (dirre.Text != "" && dirre.Font.Italic == true)
                {
                    dirre.Text = "";
                    dirre.ForeColor = SystemColors.WindowText;
                    dirre.Font = new Font(dirre.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    dirre.ForeColor = SystemColors.WindowText;
                    dirre.Font = new Font(dirre.Font, FontStyle.Regular);
                }
            }
        }

        private void fotoregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (fotore.Text != "" && fotore.Font.Italic == true)
                {
                    fotore.Text = "";
                    fotore.ForeColor = SystemColors.WindowText;
                    fotore.Font = new Font(fotore.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    fotore.ForeColor = SystemColors.WindowText;
                    fotore.Font = new Font(fotore.Font, FontStyle.Regular);
                }
            }
        }

        private void correregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (corre.Text != "" && corre.Font.Italic == true)
                {
                    corre.Text = "";
                    corre.ForeColor = SystemColors.WindowText;
                    corre.Font = new Font(corre.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    corre.ForeColor = SystemColors.WindowText;
                    corre.Font = new Font(corre.Font, FontStyle.Regular);
                }
            }
        }

        private void telregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (telre.Text != "" && telre.Font.Italic == true)
                {
                    telre.Text = "";
                    telre.ForeColor = SystemColors.WindowText;
                    telre.Font = new Font(telre.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    telre.ForeColor = SystemColors.WindowText;
                    telre.Font = new Font(telre.Font, FontStyle.Regular);
                }
            }
        }

        private void celregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (celre.Text != "" && celre.Font.Italic == true)
                {
                    celre.Text = "";
                    celre.ForeColor = SystemColors.WindowText;
                    celre.Font = new Font(celre.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    celre.ForeColor = SystemColors.WindowText;
                    celre.Font = new Font(celre.Font, FontStyle.Regular);
                }
            }
        }

        private void faxregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (faxre.Text != "" && faxre.Font.Italic == true)
                {
                    faxre.Text = "";
                    faxre.ForeColor = SystemColors.WindowText;
                    faxre.Font = new Font(faxre.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    faxre.ForeColor = SystemColors.WindowText;
                    faxre.Font = new Font(faxre.Font, FontStyle.Regular);
                }
            }
        }

        private void cargoregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (cargore.Text != "" && cargore.Font.Italic == true)
                {
                    cargore.Text = "";
                    cargore.ForeColor = SystemColors.WindowText;
                    cargore.Font = new Font(cargore.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    cargore.ForeColor = SystemColors.WindowText;
                    cargore.Font = new Font(cargore.Font, FontStyle.Regular);
                }
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (this.printMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.printDocx.DocumentName = "Preparando Documento...";
                this.printDocx.Print();
            }
        }

        private void dirre_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirre.ForeColor = SystemColors.WindowText;
            dirre.Font = new Font(dirre.Font, FontStyle.Regular);
        }

        private void fotore_KeyPress(object sender, KeyPressEventArgs e)
        {
            fotore.ForeColor = SystemColors.WindowText;
            fotore.Font = new Font(fotore.Font, FontStyle.Regular);
        }

        private void corre_KeyPress(object sender, KeyPressEventArgs e)
        {
            corre.ForeColor = SystemColors.WindowText;
            corre.Font = new Font(corre.Font, FontStyle.Regular);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            buscarcic.Text = "";
            buscarcic.ForeColor = SystemColors.WindowText;
            buscarcic.Font = new Font(buscarcic.Font, FontStyle.Regular);
            cire.Text = "";
            cire.ForeColor = SystemColors.WindowText;
            cire.Font = new Font(cire.Font, FontStyle.Regular);
            nomre.Text = "";
            nomre.ForeColor = SystemColors.WindowText;
            nomre.Font = new Font(nomre.Font, FontStyle.Regular);
            apere.Text = "";
            apere.ForeColor = SystemColors.WindowText;
            apere.Font = new Font(apere.Font, FontStyle.Regular);
            namere.Text = "";
            namere.ForeColor = SystemColors.WindowText;
            namere.Font = new Font(namere.Font, FontStyle.Regular);
            dirre.Text = "";
            dirre.ForeColor = SystemColors.WindowText;
            dirre.Font = new Font(dirre.Font, FontStyle.Regular);
            fotore.Text = "";
            fotore.ForeColor = SystemColors.WindowText;
            fotore.Font = new Font(fotore.Font, FontStyle.Regular);
            corre.Text = "";
            corre.ForeColor = SystemColors.WindowText;
            corre.Font = new Font(corre.Font, FontStyle.Regular);
            telre.Text = "";
            telre.ForeColor = SystemColors.WindowText;
            telre.Font = new Font(telre.Font, FontStyle.Regular);
            celre.Text = "";
            celre.ForeColor = SystemColors.WindowText;
            celre.Font = new Font(celre.Font, FontStyle.Regular);
            faxre.Text = "";
            faxre.ForeColor = SystemColors.WindowText;
            faxre.Font = new Font(faxre.Font, FontStyle.Regular);
            cargore.Text = "";
            cargore.ForeColor = SystemColors.WindowText;
            cargore.Font = new Font(cargore.Font, FontStyle.Regular);
        }

        private void ReportSolUser_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.SolUser' Puede moverla o quitarla según sea necesario.
            this.solUserTableAdapter.Fill(this.rEV_DataBaseDataSet.SolUser);

            Conexion f = new Conexion();
            string query = "SELECT * FROM Departamento; ";

            SqlCommand sqlQ = new SqlCommand(query, f.GetCONN());
            f.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(1);
                    depare.Items.Add(Scad);
                }
                f.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void depare_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion d = new Conexion();
            string query = "SELECT nombrePro, CodDep FROM Provincia, Departamento WHERE CodDep=codigoDep AND nombreDep= '" + depare.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
            d.OpenCnn();
            SqlDataReader read;

            try
            {
                read = sqlQ.ExecuteReader();
                provre.Items.Clear();
                while (read.Read())
                {
                    String cade = read.GetString(0);
                    provre.Items.Add(cade);
                    id = read.GetString(1);
                }
                d.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            Conexion d = new Conexion();
            System.Data.SqlClient.SqlDataAdapter asd = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM SolUser ;", d.GetCONN());
            DataTable dt = new DataTable();
            asd.Fill(dt);
            dataGridUser.DataSource = dt;
        }

        private void dataGridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dataGridUser.CurrentRow.Index;
            buscarcic.Text = "";
            buscarcic.ForeColor = SystemColors.WindowText;
            buscarcic.Font = new Font(buscarcic.Font, FontStyle.Regular);
            buscarcic.Text = dataGridUser[1, pos].Value.ToString();
        }


        public void eliminarUsr()
        {
            if (buscarcic.Text == "" || buscarcic.Font.Italic == true || buscarcic.Enabled == false)
            {

            }
            else
            {
                if (comprobar() == 1)
                {
                    try
                    {   // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "DELETE FROM SolUser WHERE ciSolU = '" + Convert.ToInt32(buscarcic.Text) + "' ;";

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR. Al Eliminar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { }
            }
        }


        private void save_Click(object sender, EventArgs e)
        {
            String fn = dia.Text + " " + mes.Text + " " + anno.Text;
            String sex = sexMax.Text;
            int iduser = 2;

            if ((cire.Text != "" && cire.Font.Italic == true) || nomre.Font.Italic == true || apere.Font.Italic == true || namere.Font.Italic == true || dirre.Font.Italic == true || cargore.Font.Italic == true || corre.Font.Italic == true || telre.Font.Italic == true || celre.Font.Italic == true || faxre.Font.Italic == true || fotore.Font.Italic == true)
            {
                if (cire.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Ingresar los Datos del Usuario. Caso Contrario dejar en Blanco", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cire.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Usuario", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (namere.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre de Usuario o Identificacion para el Usuario ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passre.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Contraseña para el Ingreso del Usuario ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Codigo de guardar usuario.
                if (passre.Text == confpasre.Text)
                {
                    if (comprobar() == 0)
                    {
                        if (sexFem.Checked == true)
                        {
                            sex = sexFem.Text;
                            try
                            {   // Objetos de conexión y comando
                                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                                // Estableciento propiedades
                                cmd.Connection = cs.GetCONN();
                                cmd.CommandText = "INSERT INTO Usuario VALUES (@id, @name, @ape, @nuusr, @passw, @dirusr, @nivel, @cargo, @sexo, @fecha, @tel, @cel, @fax, @image, @email, @numid, @codd)";

                                // Creando los parámetros necesarios
                                cmd.Parameters.Add("@id", System.Data.SqlDbType.BigInt);
                                cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@nuusr", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@passw", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@dirusr", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@nivel", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@cargo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@fecha", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@tel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@cel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@fax", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@image", System.Data.SqlDbType.Image);
                                cmd.Parameters.Add("@email", System.Data.SqlDbType.Text);
                                cmd.Parameters.Add("@numid", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);

                                // Asignando el valor de la imagen
                                // Stream usado como buffer
                                System.IO.MemoryStream mss = new System.IO.MemoryStream();
                                // Se guarda la imagen en el buffer
                                fotoUser.Image.Save(mss, System.Drawing.Imaging.ImageFormat.Jpeg);

                                // Asignando los valores a los atributos
                                cmd.Parameters["@id"].Value = int.Parse(cire.Text);
                                cmd.Parameters["@name"].Value = nomre.Text;
                                cmd.Parameters["@ape"].Value = apere.Text;
                                cmd.Parameters["@nuusr"].Value = namere.Text;
                                cmd.Parameters["@passw"].Value = passre.Text;
                                cmd.Parameters["@dirusr"].Value = dirre.Text;
                                cmd.Parameters["@nivel"].Value = nivre.Text;
                                cmd.Parameters["@cargo"].Value = cargore.Text;
                                cmd.Parameters["@sexo"].Value = sex;
                                cmd.Parameters["@fecha"].Value = fn;
                                cmd.Parameters["@tel"].Value = int.Parse(telre.Text);
                                cmd.Parameters["@cel"].Value = int.Parse(celre.Text);
                                cmd.Parameters["@fax"].Value = int.Parse(faxre.Text);
                                cmd.Parameters["@image"].Value = mss.GetBuffer();
                                cmd.Parameters["@email"].Value = corre.Text;
                                cmd.Parameters["@numid"].Value = iduser;
                                cmd.Parameters["@codd"].Value = id;

                                cs.OpenCnn();
                                cmd.ExecuteNonQuery();
                                cs.CerrarCnn();

                                Messengers mr = new Messengers();
                                mr.textolb.Text = "Usuario Guardado";
                                mr.ShowDialog();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR. Al Insertar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            try
                            {  // Objetos de conexión y comando
                                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                                // Estableciento propiedades
                                cmd.Connection = cs.GetCONN();
                                cmd.CommandText = "INSERT INTO Usuario VALUES (@id, @name, @ape, @nuusr, @passw, @dirusr, @nivel, @cargo, @sexo, @fecha, @tel, @cel, @fax, @image, @email, @numid, @codd)";

                                // Creando los parámetros necesarios
                                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@nuusr", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@passw", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@dirusr", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@nivel", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@cargo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@fecha", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@tel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@cel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@fax", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@image", System.Data.SqlDbType.Image);
                                cmd.Parameters.Add("@email", System.Data.SqlDbType.Text);
                                cmd.Parameters.Add("@numid", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);

                                // Asignando el valor de la imagen
                                // Stream usado como buffer
                                System.IO.MemoryStream ms1 = new System.IO.MemoryStream();
                                // Se guarda la imagen en el buffer
                                fotoUser.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);

                                // Asignando los valores a los atributos
                                cmd.Parameters["@id"].Value = int.Parse(cire.Text);
                                cmd.Parameters["@name"].Value = nomre.Text;
                                cmd.Parameters["@ape"].Value = apere.Text;
                                cmd.Parameters["@nuusr"].Value = namere.Text;
                                cmd.Parameters["@passw"].Value = passre.Text;
                                cmd.Parameters["@dirusr"].Value = dirre.Text;
                                cmd.Parameters["@nivel"].Value = nivre.Text;
                                cmd.Parameters["@cargo"].Value = cargore.Text;
                                cmd.Parameters["@sexo"].Value = sex;
                                cmd.Parameters["@fecha"].Value = fn;
                                cmd.Parameters["@tel"].Value = telre.Text;
                                cmd.Parameters["@cel"].Value = celre.Text;
                                cmd.Parameters["@fax"].Value = faxre.Text;
                                cmd.Parameters["@image"].Value = ms1.GetBuffer();
                                cmd.Parameters["@email"].Value = corre.Text;
                                cmd.Parameters["@numid"].Value = iduser;
                                cmd.Parameters["@codd"].Value = id;

                                cs.OpenCnn();
                                cmd.ExecuteNonQuery();
                                cs.CerrarCnn();

                                Messengers mr = new Messengers();
                                mr.textolb.Text = "Usuario Guardado";
                                mr.ShowDialog();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR. Al Insertar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR. El Usuario Ya Existe, Contacte Con el Administrador. ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no son Iguales, Intente Nuevamente.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passre.Text = "";
                    confpasre.Text = "";
                }
            }
        }

        private void ViewPrint_Click(object sender, EventArgs e)
        {
            printView.Document = printDocx;
            printView.ShowDialog();
        }

        private void printDocx_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {   //Inicio del encabezado del Documento.
            Conexion d = new Conexion();
            string query = "SELECT * FROM Empresa ; ";
            SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
            d.OpenCnn();
            SqlDataReader read;
            Image img = null; //Variables Guardar los Datos de la Empresa.
            String name = "";
            String nit = "";
            String tel = "";
            String cel = "";
            String dir = "";
            String web = "";

            int width = 0;
            int height = 0;
            int x = 0;
            int y = 0;
            int rowheight = 0;
            int columnwidth = 0;

            StringFormat str = new StringFormat();
            str.Alignment = StringAlignment.Near;
            str.LineAlignment = StringAlignment.Center;
            str.Trimming = StringTrimming.EllipsisCharacter;
            Pen p = new Pen(Color.Black, 2.5f);

            try
            {
                read = sqlQ.ExecuteReader();

                while (read.Read())
                { // El campo productImage primero se almacena en un buffer
                    byte[] imageBuffer = (byte[])(read[9]);
                    name = read.GetString(1);
                    nit = read.GetString(0);
                    tel = read.GetInt32(3).ToString();
                    cel = read.GetInt32(4).ToString();
                    dir = read.GetString(2);
                    web = read.GetString(8);

                    if (imageBuffer == null || read[9] == null)
                    {
                        img = null;
                    }
                    else
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        img = Image.FromStream(ms); //Logotipo
                    }
                }        //Datos de la Empresa.
                e.Graphics.DrawImage(img, 20, 20, img.Width, img.Height);
                e.Graphics.DrawString(name, new Font("Lucida Sans", 12), new SolidBrush(Color.Black), img.Width + 30, 20);
                e.Graphics.DrawString(nit, new Font("Lucida Sans", 12), new SolidBrush(Color.Black), img.Width + 30, 50);
                e.Graphics.DrawString(tel, new Font("Lucida Sans", 12), new SolidBrush(Color.Black), img.Width + 30, 80);
                e.Graphics.DrawString(cel, new Font("Lucida Sans", 12), new SolidBrush(Color.Black), img.Width + 130, 80);
                e.Graphics.DrawString(dir, new Font("Lucida Sans", 12), new SolidBrush(Color.Black), img.Width + 30, 100);
                e.Graphics.DrawString(web, new Font("Lucida Sans", 12), new SolidBrush(Color.Black), img.Width + 30, 130);
                e.Graphics.DrawString("Solicitudes de Usuarios", new Font("Lucida Sans", 18), new SolidBrush(Color.DarkBlue), img.Width + 400, 60);
                //fin Encabezado Documento.



                //Insert DataGrid Print.
                #region Draw Column 1
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10, 200, dataGridUser.Columns[0].Width-25, dataGridUser.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10, 200, dataGridUser.Columns[0].Width-25, dataGridUser.Rows[0].Height);
                e.Graphics.DrawString(dataGridUser.Columns[1].HeaderText, dataGridUser.Font, Brushes.Black, new RectangleF(10, 200, dataGridUser.Columns[0].Width-25, dataGridUser.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10 + dataGridUser.Columns[0].Width-25, 200, dataGridUser.Columns[0].Width, dataGridUser.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10 + dataGridUser.Columns[0].Width-25, 200, dataGridUser.Columns[0].Width, dataGridUser.Rows[0].Height);
                e.Graphics.DrawString(dataGridUser.Columns[2].HeaderText, dataGridUser.Font, Brushes.Black, new RectangleF(10 + dataGridUser.Columns[0].Width-25, 200, dataGridUser.Columns[0].Width, dataGridUser.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(110 + dataGridUser.Columns[0].Width-25, 200, dataGridUser.Columns[0].Width, dataGridUser.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 110 + dataGridUser.Columns[0].Width-25, 200, dataGridUser.Columns[0].Width, dataGridUser.Rows[0].Height);
                e.Graphics.DrawString(dataGridUser.Columns[3].HeaderText, dataGridUser.Font, Brushes.Black, new RectangleF(110 + dataGridUser.Columns[0].Width-25, 200, dataGridUser.Columns[0].Width, dataGridUser.Rows[0].Height), str);
                #endregion

                #region Draw column 4
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(210 + dataGridUser.Columns[0].Width-25, 200, dataGridUser.Columns[0].Width, dataGridUser.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 210 + dataGridUser.Columns[0].Width-25, 200, dataGridUser.Columns[0].Width, dataGridUser.Rows[0].Height);
                e.Graphics.DrawString(dataGridUser.Columns[4].HeaderText, dataGridUser.Font, Brushes.Black, new RectangleF(210 + dataGridUser.Columns[0].Width-25, 200, dataGridUser.Columns[0].Width, dataGridUser.Rows[0].Height), str);
                #endregion

                #region Draw column 5
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(310 + dataGridUser.Columns[0].Width-25, 200, dataGridUser.Columns[0].Width, dataGridUser.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 310 + dataGridUser.Columns[0].Width-25, 200, dataGridUser.Columns[0].Width, dataGridUser.Rows[0].Height);
                e.Graphics.DrawString(dataGridUser.Columns[6].HeaderText, dataGridUser.Font, Brushes.Black, new RectangleF(310 + dataGridUser.Columns[0].Width-25, 200, dataGridUser.Columns[0].Width, dataGridUser.Rows[0].Height), str);
                #endregion

                #region Draw column 6
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(410 + dataGridUser.Columns[0].Width-20, 200, dataGridUser.Columns[0].Width + 10, dataGridUser.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 410 + dataGridUser.Columns[0].Width-20, 200, dataGridUser.Columns[0].Width + 10, dataGridUser.Rows[0].Height);
                e.Graphics.DrawString(dataGridUser.Columns[9].HeaderText, dataGridUser.Font, Brushes.Black, new RectangleF(410 + dataGridUser.Columns[0].Width-20, 200, dataGridUser.Columns[0].Width + 10, dataGridUser.Rows[0].Height), str);
                #endregion

                #region Draw column 7
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(530 + dataGridUser.Columns[0].Width-20, 200, dataGridUser.Columns[0].Width - 20, dataGridUser.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 530 + dataGridUser.Columns[0].Width-20, 200, dataGridUser.Columns[0].Width - 20, dataGridUser.Rows[0].Height);
                e.Graphics.DrawString(dataGridUser.Columns[10].HeaderText, dataGridUser.Font, Brushes.Black, new RectangleF(530 + dataGridUser.Columns[0].Width-20, 200, dataGridUser.Columns[0].Width - 20, dataGridUser.Rows[0].Height), str);
                #endregion

                #region Draw column 8
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(610 + dataGridUser.Columns[0].Width-20, 200, dataGridUser.Columns[0].Width - 30, dataGridUser.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 610 + dataGridUser.Columns[0].Width-20, 200, dataGridUser.Columns[0].Width - 30, dataGridUser.Rows[0].Height);
                e.Graphics.DrawString(dataGridUser.Columns[11].HeaderText, dataGridUser.Font, Brushes.Black, new RectangleF(610 + dataGridUser.Columns[0].Width-20, 200, dataGridUser.Columns[0].Width - 30, dataGridUser.Rows[0].Height), str);
                #endregion

                #region Draw Rows N
                width = 10 + dataGridUser.Columns[0].Width;
                height = 200;
                //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
                while (i < dataGridUser.Rows.Count)
                {
                    if (height > e.MarginBounds.Height)
                    {
                        height = 200;
                        width = 10;
                        e.HasMorePages = true;
                        return;
                    }

                    height += dataGridUser.Rows[i].Height;
                    //Draw Row 1
                    e.Graphics.DrawRectangle(Pens.Black, 10, height, dataGridUser.Columns[0].Width-25, dataGridUser.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUser.Rows[i].Cells[1].FormattedValue.ToString(), dataGridUser.Font, Brushes.Black, new RectangleF(10, height, dataGridUser.Columns[0].Width-25, dataGridUser.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, 10 + dataGridUser.Columns[0].Width-25, height, dataGridUser.Columns[0].Width - 40, dataGridUser.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUser.Rows[i].Cells[2].Value.ToString(), dataGridUser.Font, Brushes.Black, new RectangleF(10 + dataGridUser.Columns[0].Width-25, height, dataGridUser.Columns[0].Width - 40, dataGridUser.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 110 + dataGridUser.Columns[0].Width-25, height, dataGridUser.Columns[0].Width - 40, dataGridUser.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUser.Rows[i].Cells[3].Value.ToString(), dataGridUser.Font, Brushes.Black, new RectangleF(110 + dataGridUser.Columns[0].Width-25, height, dataGridUser.Columns[0].Width - 40, dataGridUser.Rows[0].Height), str);
                    //Draw Row 4
                    e.Graphics.DrawRectangle(Pens.Black, 210 + dataGridUser.Columns[0].Width-25, height, dataGridUser.Columns[0].Width - 40, dataGridUser.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUser.Rows[i].Cells[4].Value.ToString(), dataGridUser.Font, Brushes.Black, new RectangleF(210 + dataGridUser.Columns[0].Width-25, height, dataGridUser.Columns[0].Width - 40, dataGridUser.Rows[0].Height), str);
                    //Draw Row 5
                    e.Graphics.DrawRectangle(Pens.Black, 310 + dataGridUser.Columns[0].Width-25, height, dataGridUser.Columns[0].Width - 35, dataGridUser.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUser.Rows[i].Cells[6].Value.ToString(), dataGridUser.Font, Brushes.Black, new RectangleF(310 + dataGridUser.Columns[0].Width-25, height, dataGridUser.Columns[0].Width - 35, dataGridUser.Rows[0].Height), str);
                    //Draw Row 6
                    e.Graphics.DrawRectangle(Pens.Black, 410 + dataGridUser.Columns[0].Width-20, height, dataGridUser.Columns[0].Width-20, dataGridUser.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUser.Rows[i].Cells[9].Value.ToString(), dataGridUser.Font, Brushes.Black, new RectangleF(410 + dataGridUser.Columns[0].Width-20, height, dataGridUser.Columns[0].Width-20, dataGridUser.Rows[0].Height), str);
                    //Draw Row 7
                    e.Graphics.DrawRectangle(Pens.Black, 530 + dataGridUser.Columns[0].Width-20, height, dataGridUser.Columns[0].Width - 60, dataGridUser.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUser.Rows[i].Cells[10].Value.ToString(), dataGridUser.Font, Brushes.Black, new RectangleF(530 + dataGridUser.Columns[0].Width-20, height, dataGridUser.Columns[0].Width - 60, dataGridUser.Rows[0].Height), str);
                    //Draw Row 8
                    e.Graphics.DrawRectangle(Pens.Black, 610 + dataGridUser.Columns[0].Width-20, height, dataGridUser.Columns[0].Width - 30, dataGridUser.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUser.Rows[i].Cells[11].Value.ToString(), dataGridUser.Font, Brushes.Black, new RectangleF(610 + dataGridUser.Columns[0].Width-20, height, dataGridUser.Columns[0].Width - 30, dataGridUser.Rows[0].Height), str);

                    width += dataGridUser.Columns[0].Width;
                    i++;
                }

                #endregion

                d.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
