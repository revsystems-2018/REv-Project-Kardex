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
    public partial class ReportSolClientes : Form
    {
        ValidacionText mn = new ValidacionText();
        OpenFileDialog ima = new OpenFileDialog();
        String id = "3";
        int pos = 0;
        int i = 0;

        public ReportSolClientes()
        {
            InitializeComponent();

            toolsolcliente.SetToolTip(nuevo,"Nuevo Cliente");
            toolsolcliente.SetToolTip(editar, "Editar Cliente");
            toolsolcliente.SetToolTip(eliminar, "Eliminar Cliente");
            toolsolcliente.SetToolTip(actualizar, "Actualizar");
            toolsolcliente.SetToolTip(print, "Imprimir");
            toolsolcliente.SetToolTip(verimagen, "Ver Fotografia");
            toolsolcliente.SetToolTip(save, "Guardar");
            toolsolcliente.SetToolTip(salir, "Salir");
            toolsolcliente.SetToolTip(regtext, "Registro de Clientes");

            toolsolcliente.SetToolTip(buscarcic, "Buscar Cliente con Carnet de Identidad");
            toolsolcliente.SetToolTip(ci, "Carnet de Identidad ");
            toolsolcliente.SetToolTip(nom, "Nombres del Cliente");
            toolsolcliente.SetToolTip(apell, "Apellidos del Cliente");
            toolsolcliente.SetToolTip(nit, "Documento de NIT para Facturas");
            toolsolcliente.SetToolTip(correo, "Correo Electronico del Cliente");
            toolsolcliente.SetToolTip(web, "Pagina Web del Cliente");
            toolsolcliente.SetToolTip(direc, "Dirección del Cliente");
            toolsolcliente.SetToolTip(depa, "Seleccionar Departamento Donde Vive el Cliente");
            toolsolcliente.SetToolTip(prov, "Seleccionar Provincia Donde Vive el Cliente");
            toolsolcliente.SetToolTip(fecha, "Seleccionar la Fecha de Hoy");
            toolsolcliente.SetToolTip(dia, "Dia");
            toolsolcliente.SetToolTip(mes, "Mes");
            toolsolcliente.SetToolTip(anno, "Año");
            toolsolcliente.SetToolTip(tel, "Telefono Local del Cliente");
            toolsolcliente.SetToolTip(cel, "Celular del Cliente");
            toolsolcliente.SetToolTip(fax, "Fax del Cliente");
            toolsolcliente.SetToolTip(foto, "Seleccionar Fotografia para el Cliente");
            toolsolcliente.SetToolTip(state, "Seleccionar el Estado/situación que se Encuentra el Cliente");
            toolsolcliente.SetToolTip(selectfoto, "Abrir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Esta Seguro que Desea Salir de las Solicitudes del Cliente?";
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

        private void buscarci(object sender, KeyPressEventArgs e)
        {
            buscarcic.ForeColor = SystemColors.WindowText;
            buscarcic.Font = new Font(buscarcic.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void cinum(object sender, KeyPressEventArgs e)
        {
            ci.ForeColor = SystemColors.WindowText;
            ci.Font = new Font(ci.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void nitnum(object sender, KeyPressEventArgs e)
        {
            nit.ForeColor = SystemColors.WindowText;
            nit.Font = new Font(nit.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void telnum(object sender, KeyPressEventArgs e)
        {
            tel.ForeColor = SystemColors.WindowText;
            tel.Font = new Font(tel.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void celnum(object sender, KeyPressEventArgs e)
        {
            cel.ForeColor = SystemColors.WindowText;
            cel.Font = new Font(cel.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void faxnum(object sender, KeyPressEventArgs e)
        {
            fax.ForeColor = SystemColors.WindowText;
            fax.Font = new Font(fax.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void nomtext(object sender, KeyPressEventArgs e)
        {
            nom.ForeColor = SystemColors.WindowText;
            nom.Font = new Font(nom.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void apeltext(object sender, KeyPressEventArgs e)
        {
            apell.ForeColor = SystemColors.WindowText;
            apell.Font = new Font(apell.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.buscarcic.Enabled = false;
            this.searchci.Visible = false;
            this.ci.Enabled = true;
            this.nom.Enabled = true;
            this.apell.Enabled = true;
            this.nit.Enabled = true;
            this.correo.Enabled = true;
            this.web.Enabled = true;
            this.direc.Enabled = true;
            this.depa.Enabled = true;
            this.prov.Enabled = true;
            this.fecha.Enabled = true;
            this.sexo.Enabled = true;
            this.dia.Enabled = true;
            this.mes.Enabled = true;
            this.anno.Enabled = true;
            this.tel.Enabled = true;
            this.cel.Enabled = true;
            this.fax.Enabled = true;
            this.foto.Enabled = true;
            this.state.Enabled = true;
            this.selectfoto.Enabled = true;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (buscarcic.Text != "" && buscarcic.Font.Italic == true)
            {
                if (buscarcic.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (buscarcic.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.buscarcic.Enabled = true;
                this.searchci.Visible = true;
                this.searchci.Enabled = true;
                this.ci.Enabled = true;
                this.nom.Enabled = true;
                this.apell.Enabled = true;
                this.nit.Enabled = true;
                this.correo.Enabled = true;
                this.web.Enabled = true;
                this.direc.Enabled = true;
                this.depa.Enabled = true;
                this.prov.Enabled = true;
                this.fecha.Enabled = true;
                this.sexo.Enabled = true;
                this.dia.Enabled = true;
                this.mes.Enabled = true;
                this.anno.Enabled = true;
                this.tel.Enabled = true;
                this.cel.Enabled = true;
                this.fax.Enabled = true;
                this.foto.Enabled = true;
                this.state.Enabled = true;
                this.selectfoto.Enabled = true;

                //Codigo de Editar Cliente.
                Conexion w = new Conexion();
                string query = "SELECT * FROM SolClientes WHERE ciSolC ='" + Convert.ToInt32(buscarcic.Text) + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, w.GetCONN());
                SqlDataReader read;
                if (comprobar() == 1)
                {
                    ci.Text = "";
                    ci.ForeColor = SystemColors.WindowText;
                    ci.Font = new Font(ci.Font, FontStyle.Regular);
                    nom.Text = "";
                    nom.ForeColor = SystemColors.WindowText;
                    nom.Font = new Font(nom.Font, FontStyle.Regular);
                    apell.Text = "";
                    apell.ForeColor = SystemColors.WindowText;
                    apell.Font = new Font(apell.Font, FontStyle.Regular);
                    nit.Text = "";
                    nit.ForeColor = SystemColors.WindowText;
                    nit.Font = new Font(nit.Font, FontStyle.Regular);
                    correo.Text = "";
                    correo.ForeColor = SystemColors.WindowText;
                    correo.Font = new Font(correo.Font, FontStyle.Regular);
                    web.Text = "";
                    web.ForeColor = SystemColors.WindowText;
                    web.Font = new Font(web.Font, FontStyle.Regular);
                    direc.Text = "";
                    direc.ForeColor = SystemColors.WindowText;
                    direc.Font = new Font(direc.Font, FontStyle.Regular);
                    tel.Text = "";
                    tel.ForeColor = SystemColors.WindowText;
                    tel.Font = new Font(tel.Font, FontStyle.Regular);
                    cel.Text = "";
                    cel.ForeColor = SystemColors.WindowText;
                    cel.Font = new Font(cel.Font, FontStyle.Regular);
                    fax.Text = "";
                    fax.ForeColor = SystemColors.WindowText;
                    fax.Font = new Font(fax.Font, FontStyle.Regular);
                    foto.Text = "";
                    foto.ForeColor = SystemColors.WindowText;
                    foto.Font = new Font(foto.Font, FontStyle.Regular);

                    try
                    {
                        w.OpenCnn();
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            ci.Text = read.GetInt32(1).ToString();
                            nom.Text = read.GetString(2);
                            apell.Text = read.GetString(3);
                            nit.Text = read.GetInt32(4).ToString();
                            direc.Text = read.GetString(5);
                            correo.Text = read.GetString(6);
                            tel.Text = read.GetInt32(7).ToString();
                            cel.Text = read.GetInt32(8).ToString();
                        }
                        w.CerrarCnn();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        w.CerrarCnn();
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, El Cliente Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private int comprobar()
        {
            int cnt = 0;
            Conexion w = new Conexion();
            string buscar = "SELECT * FROM SolClientes WHERE ciSolC= '" + Convert.ToInt32(buscarcic.Text) + "' ; ";
            try
            {
                w.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, w.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
            }
            catch (Exception ex) { 
                MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                w.CerrarCnn();
            }
            w.CerrarCnn();
            return cnt;
        }


        private void eliminar_Click(object sender, EventArgs e)
        {
            this.buscarcic.Enabled = true;
            this.searchci.Enabled = true;
            this.ci.Enabled = false;
            this.nom.Enabled = false;
            this.apell.Enabled = false;
            this.nit.Enabled = false;
            this.correo.Enabled = false;
            this.web.Enabled = false;
            this.direc.Enabled = false;
            this.depa.Enabled = false;
            this.prov.Enabled = false;
            this.fecha.Enabled = false;
            this.sexo.Enabled = false;
            this.dia.Enabled = false;
            this.mes.Enabled = false;
            this.anno.Enabled = false;
            this.tel.Enabled = false;
            this.cel.Enabled = false;
            this.fax.Enabled = false;
            this.foto.Enabled = false;
            this.state.Enabled = false;
            this.selectfoto.Enabled = false;

            if (buscarcic.Text != "" && buscarcic.Font.Italic == true)
            {
                if (buscarcic.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (buscarcic.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //Codigo de Eliminar Cliente de la Tabla de Solicitudes.
                if (comprobar() == 1)
                {
                    try
                    {   // Objetos de conexión y comando
                        Conexion w = new Conexion();
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = w.GetCONN();
                        cmd.CommandText = "DELETE FROM SolClientes WHERE ciSolC = '" + Convert.ToInt32(buscarcic.Text) + "' ;";

                        w.OpenCnn();
                        cmd.ExecuteNonQuery();
                        w.CerrarCnn();

                        Messengers mr = new Messengers();
                        mr.textolb.Text = "Cliente Eliminado";
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
                    MessageBox.Show("Error, No Existen Registros del Cliente.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }

        private void regtext_Click(object sender, EventArgs e)
        {
            Registro_Clientes rc = new Registro_Clientes();
            rc.ShowDialog();
        }

        private void searchci_Click(object sender, EventArgs e)
        {
            if (buscarcic.Text != "" && buscarcic.Font.Italic == true)
            {
                if (buscarcic.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (buscarcic.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   //Codigo de Buscar Cliente.
                ci.Enabled = true;
                nom.Enabled = true;
                apell.Enabled = true;

                Conexion w = new Conexion();
                string query = "SELECT * FROM SolClientes WHERE ciSolC ='" + Convert.ToInt32(buscarcic.Text) + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, w.GetCONN());
                SqlDataReader read;
                if (comprobar() == 1)
                {
                    ci.Text = "";
                    ci.ForeColor = SystemColors.WindowText;
                    ci.Font = new Font(ci.Font, FontStyle.Regular);
                    nom.Text = "";
                    nom.ForeColor = SystemColors.WindowText;
                    nom.Font = new Font(nom.Font, FontStyle.Regular);
                    apell.Text = "";
                    apell.ForeColor = SystemColors.WindowText;
                    apell.Font = new Font(apell.Font, FontStyle.Regular);
                    nit.Text = "";
                    nit.ForeColor = SystemColors.WindowText;
                    nit.Font = new Font(nit.Font, FontStyle.Regular);
                    correo.Text = "";
                    correo.ForeColor = SystemColors.WindowText;
                    correo.Font = new Font(correo.Font, FontStyle.Regular);
                    web.Text = "";
                    web.ForeColor = SystemColors.WindowText;
                    web.Font = new Font(web.Font, FontStyle.Regular);
                    direc.Text = "";
                    direc.ForeColor = SystemColors.WindowText;
                    direc.Font = new Font(direc.Font, FontStyle.Regular);
                    tel.Text = "";
                    tel.ForeColor = SystemColors.WindowText;
                    tel.Font = new Font(tel.Font, FontStyle.Regular);
                    cel.Text = "";
                    cel.ForeColor = SystemColors.WindowText;
                    cel.Font = new Font(cel.Font, FontStyle.Regular);
                    fax.Text = "";
                    fax.ForeColor = SystemColors.WindowText;
                    fax.Font = new Font(fax.Font, FontStyle.Regular);
                    foto.Text = "";
                    foto.ForeColor = SystemColors.WindowText;
                    foto.Font = new Font(foto.Font, FontStyle.Regular);

                    try
                    {
                        w.OpenCnn();
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            ci.Text = read.GetInt32(1).ToString();
                            nom.Text = read.GetString(2);
                            apell.Text = read.GetString(3);                        
                        }
                        w.CerrarCnn();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        w.CerrarCnn();
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, El Cliente Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void selectfoto_Click(object sender, EventArgs e)
        {
            ima.InitialDirectory = "C:\\";
            ima.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            ima.Title = "Abrir Fotografia del Cliente";

            if (ima.ShowDialog() == DialogResult.OK)
            {
                foto.Text = "";
                foto.ForeColor = SystemColors.WindowText;
                foto.Font = new Font(foto.Font, FontStyle.Regular);
                foto.Text = ima.FileName;
                //fotoCliente.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verimagen_Click(object sender, EventArgs e)
        {
            if (foto.Text != "" && foto.Font.Italic == true)
            {
                if (foto.Text == "")
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (foto.Text == "")
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta o Escriba la Dirección de la Imagen.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fotoCliente.ImageLocation = ima.FileName;
            }
        }

        private void ciregsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (ci.Text != "" && ci.Font.Italic == true)
                {
                    ci.Text = "";
                    ci.ForeColor = SystemColors.WindowText;
                    ci.Font = new Font(ci.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    ci.ForeColor = SystemColors.WindowText;
                    ci.Font = new Font(ci.Font, FontStyle.Regular);
                }
            }
        }

        private void buscarregClick(object sender, MouseEventArgs e)
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

        private void nomregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nom.Text != "" && nom.Font.Italic == true)
                {
                    nom.Text = "";
                    nom.ForeColor = SystemColors.WindowText;
                    nom.Font = new Font(nom.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nom.ForeColor = SystemColors.WindowText;
                    nom.Font = new Font(nom.Font, FontStyle.Regular);
                }
            }
        }

        private void aperegsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (apell.Text != "" && apell.Font.Italic == true)
                {
                    apell.Text = "";
                    apell.ForeColor = SystemColors.WindowText;
                    apell.Font = new Font(apell.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    apell.ForeColor = SystemColors.WindowText;
                    apell.Font = new Font(apell.Font, FontStyle.Regular);
                }
            }
        }

        private void nitregsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nit.Text != "" && nit.Font.Italic == true)
                {
                    nit.Text = "";
                    nit.ForeColor = SystemColors.WindowText;
                    nit.Font = new Font(nit.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nit.ForeColor = SystemColors.WindowText;
                    nit.Font = new Font(nit.Font, FontStyle.Regular);
                }
            }
        }

        private void correregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (correo.Text != "" && correo.Font.Italic == true)
                {
                    correo.Text = "";
                    correo.ForeColor = SystemColors.WindowText;
                    correo.Font = new Font(correo.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    correo.ForeColor = SystemColors.WindowText;
                    correo.Font = new Font(correo.Font, FontStyle.Regular);
                }
            }
        }

        private void webregsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (web.Text != "" && web.Font.Italic == true)
                {
                    web.Text = "";
                    web.ForeColor = SystemColors.WindowText;
                    web.Font = new Font(web.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    web.ForeColor = SystemColors.WindowText;
                    web.Font = new Font(web.Font, FontStyle.Regular);
                }
            }
        }

        private void dirregsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (direc.Text != "" && direc.Font.Italic == true)
                {
                    direc.Text = "";
                    direc.ForeColor = SystemColors.WindowText;
                    direc.Font = new Font(direc.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    direc.ForeColor = SystemColors.WindowText;
                    direc.Font = new Font(direc.Font, FontStyle.Regular);
                }
            }
        }

        private void telregsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (tel.Text != "" && tel.Font.Italic == true)
                {
                    tel.Text = "";
                    tel.ForeColor = SystemColors.WindowText;
                    tel.Font = new Font(tel.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    tel.ForeColor = SystemColors.WindowText;
                    tel.Font = new Font(tel.Font, FontStyle.Regular);
                }
            }
        }

        private void celregsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (cel.Text != "" && cel.Font.Italic == true)
                {
                    cel.Text = "";
                    cel.ForeColor = SystemColors.WindowText;
                    cel.Font = new Font(cel.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    cel.ForeColor = SystemColors.WindowText;
                    cel.Font = new Font(cel.Font, FontStyle.Regular);
                }
            }
        }

        private void faxregsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (fax.Text != "" && fax.Font.Italic == true)
                {
                    fax.Text = "";
                    fax.ForeColor = SystemColors.WindowText;
                    fax.Font = new Font(fax.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    fax.ForeColor = SystemColors.WindowText;
                    fax.Font = new Font(fax.Font, FontStyle.Regular);
                }
            }
        }

        private void fotoregsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (foto.Text != "" && foto.Font.Italic == true)
                {
                    foto.Text = "";
                    foto.ForeColor = SystemColors.WindowText;
                    foto.Font = new Font(foto.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    foto.ForeColor = SystemColors.WindowText;
                    foto.Font = new Font(foto.Font, FontStyle.Regular);
                }
            }
        }

        private void weboton_Click(object sender, EventArgs e)
        {
            if (web.Text != "" && web.Font.Italic == true)
            {
                if (web.Text == "")
                {
                    MessageBox.Show("Ingrese la Dirección de la Pagina Web del Proveedor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese la Dirección de la Pagina Web del Proveedor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (web.Text == "")
            {
                MessageBox.Show("Ingrese la Dirección de la Pagina Web del Proveedor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                REV_WebStudio we = new REV_WebStudio();
                we.texturlweb.Text = web.Text;
                we.webBrow.Navigate(web.Text);
                we.ShowDialog();
            }
        }

        private void ReportSolClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.SolClientes' Puede moverla o quitarla según sea necesario.
            this.solClientesTableAdapter.Fill(this.rEV_DataBaseDataSet.SolClientes);
            Conexion s = new Conexion();
            string query = "SELECT * FROM Departamento; ";

            SqlCommand sqlQ = new SqlCommand(query, s.GetCONN());
            s.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(1);
                    depa.Items.Add(Scad);
                }
                s.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            correo.ForeColor = SystemColors.WindowText;
            correo.Font = new Font(correo.Font, FontStyle.Regular);
        }

        private void web_KeyPress(object sender, KeyPressEventArgs e)
        {
            web.ForeColor = SystemColors.WindowText;
            web.Font = new Font(web.Font, FontStyle.Regular);
        }

        private void direc_KeyPress(object sender, KeyPressEventArgs e)
        {
            direc.ForeColor = SystemColors.WindowText;
            direc.Font = new Font(direc.Font, FontStyle.Regular);
        }

        private void foto_KeyPress(object sender, KeyPressEventArgs e)
        {
            foto.ForeColor = SystemColors.WindowText;
            foto.Font = new Font(foto.Font, FontStyle.Regular);
        }

        private void prov_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion s = new Conexion();
            string query = "SELECT nombrePro, CodDep FROM Provincia, Departamento WHERE CodDep=codigoDep AND nombreDep= '" + depa.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, s.GetCONN());
            SqlDataReader read;

            try
            {
                s.OpenCnn();
                read = sqlQ.ExecuteReader();
                prov.Items.Clear();
                while (read.Read())
                {
                    String cade = read.GetString(0);
                    prov.Items.Add(cade);
                    id = read.GetString(1);
                }
                s.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                s.CerrarCnn();
            }  
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.SolClientes' Puede moverla o quitarla según sea necesario.
            this.solClientesTableAdapter.Fill(this.rEV_DataBaseDataSet.SolClientes);
            Conexion s = new Conexion();
            System.Data.SqlClient.SqlDataAdapter asd = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM SolClientes ;", s.GetCONN());
            DataTable dt = new DataTable();
            asd.Fill(dt);
            dataGridSol.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            buscarcic.Text = "";
            buscarcic.ForeColor = SystemColors.WindowText;
            buscarcic.Font = new Font(buscarcic.Font, FontStyle.Regular);
            ci.Text = "";
            ci.ForeColor = SystemColors.WindowText;
            ci.Font = new Font(ci.Font, FontStyle.Regular);
            nom.Text = "";
            nom.ForeColor = SystemColors.WindowText;
            nom.Font = new Font(nom.Font, FontStyle.Regular);
            apell.Text = "";
            apell.ForeColor = SystemColors.WindowText;
            apell.Font = new Font(apell.Font, FontStyle.Regular);
            nit.Text = "";
            nit.ForeColor = SystemColors.WindowText;
            nit.Font = new Font(nit.Font, FontStyle.Regular);
            correo.Text = "";
            correo.ForeColor = SystemColors.WindowText;
            correo.Font = new Font(correo.Font, FontStyle.Regular);
            web.Text = "";
            web.ForeColor = SystemColors.WindowText;
            web.Font = new Font(web.Font, FontStyle.Regular);
            direc.Text = "";
            direc.ForeColor = SystemColors.WindowText;
            direc.Font = new Font(direc.Font, FontStyle.Regular);
            tel.Text = "";
            tel.ForeColor = SystemColors.WindowText;
            tel.Font = new Font(tel.Font, FontStyle.Regular);
            cel.Text = "";
            cel.ForeColor = SystemColors.WindowText;
            cel.Font = new Font(cel.Font, FontStyle.Regular);
            fax.Text = "";
            fax.ForeColor = SystemColors.WindowText;
            fax.Font = new Font(fax.Font, FontStyle.Regular);
            foto.Text = "";
            foto.ForeColor = SystemColors.WindowText;
            foto.Font = new Font(foto.Font, FontStyle.Regular);
        }


        public void eliminarUsr() 
        {
            Conexion d = new Conexion();
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
                        cmd.Connection = d.GetCONN();
                        cmd.CommandText = "DELETE FROM SolClientes WHERE ciSolC = '" + Convert.ToInt32(buscarcic.Text) + "' ;";

                        d.OpenCnn();
                        cmd.ExecuteNonQuery();
                        d.CerrarCnn();
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
            Conexion d = new Conexion();
            String fn = dia.Text + " " + mes.Text + " " + anno.Text;
            String sex = sexMax.Text;

            if ((ci.Text != "" && ci.Font.Italic == true) || nom.Font.Italic == true || apell.Font.Italic == true || nit.Font.Italic == true || direc.Font.Italic == true || correo.Font.Italic == true || web.Font.Italic == true || tel.Font.Italic == true || cel.Font.Italic == true || fax.Font.Italic == true || foto.Font.Italic == true)
            {
                if (ci.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Ingresar los Datos del Cliente. Caso Contrario dejar en Blanco", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ci.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nit.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre de Usuario o Identificacion para el Cliente ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nom.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Contraseña para el Ingreso del Cliente ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //Codigo de guardar usuario.
                if (comprobar() == 0)
                {
                    if (sexFem.Checked == true)
                    {
                        sex = sexFem.Text;
                        try
                        {   // Objetos de conexión y comando
                            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                            // Estableciento propiedades
                            cmd.Connection = d.GetCONN();
                            cmd.CommandText = "INSERT INTO Clientes VALUES (@id, @name, @ape, @nit, @correo, @web, @dir, @sexo, @tel, @cel, @fax, @fechan, @fechac, @image, @fidep, @state, @codd)";

                            // Creando los parámetros necesarios
                            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@nit", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@correo", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@web", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@dir", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@tel", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@cel", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@fax", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@fechan", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@fechac", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@image", System.Data.SqlDbType.Image);
                            cmd.Parameters.Add("@fidep", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);

                            // Asignando el valor de la imagen
                            // Stream usado como buffer
                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            // Se guarda la imagen en el buffer
                            fotoCliente.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                            // Asignando los valores a los atributos
                            cmd.Parameters["@id"].Value = int.Parse(ci.Text);
                            cmd.Parameters["@name"].Value = nom.Text;
                            cmd.Parameters["@ape"].Value = apell.Text;
                            cmd.Parameters["@nit"].Value = nit.Text;
                            cmd.Parameters["@correo"].Value = correo.Text;
                            cmd.Parameters["@web"].Value = web.Text;
                            cmd.Parameters["@dir"].Value = direc.Text;
                            cmd.Parameters["@sexo"].Value = sex;
                            cmd.Parameters["@tel"].Value = int.Parse(tel.Text);
                            cmd.Parameters["@cel"].Value = int.Parse(cel.Text);
                            cmd.Parameters["@fax"].Value = int.Parse(fax.Text);
                            cmd.Parameters["@fechan"].Value = fn;
                            cmd.Parameters["@fechac"].Value = fecha.Text;
                            cmd.Parameters["@image"].Value = ms.GetBuffer();
                            cmd.Parameters["@fidep"].Value = 0;
                            cmd.Parameters["@state"].Value = state.Text;
                            cmd.Parameters["@codd"].Value = id;

                            d.OpenCnn();
                            cmd.ExecuteNonQuery();
                            d.CerrarCnn();

                            Messengers mr = new Messengers();
                            mr.textolb.Text = "Cliente Guardado";
                            eliminarUsr();
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
                        {   // Objetos de conexión y comando
                            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                            // Estableciento propiedades
                            cmd.Connection = d.GetCONN();
                            cmd.CommandText = "INSERT INTO Clientes VALUES (@id, @name, @ape, @nit, @correo, @web, @dir, @sexo, @tel, @cel, @fax, @fechan, @fechac, @image, @fidep, @state, @codd)";

                            // Creando los parámetros necesarios
                            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@nit", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@correo", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@web", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@dir", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@tel", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@cel", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@fax", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@fechan", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@fechac", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@image", System.Data.SqlDbType.Image);
                            cmd.Parameters.Add("@fidep", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);

                            // Asignando el valor de la imagen
                            // Stream usado como buffer
                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            // Se guarda la imagen en el buffer
                            fotoCliente.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                            // Asignando los valores a los atributos
                            cmd.Parameters["@id"].Value = int.Parse(ci.Text);
                            cmd.Parameters["@name"].Value = nom.Text;
                            cmd.Parameters["@ape"].Value = apell.Text;
                            cmd.Parameters["@nit"].Value = nit.Text;
                            cmd.Parameters["@correo"].Value = correo.Text;
                            cmd.Parameters["@web"].Value = web.Text;
                            cmd.Parameters["@dir"].Value = direc.Text;
                            cmd.Parameters["@sexo"].Value = sex;
                            cmd.Parameters["@tel"].Value = tel.Text;
                            cmd.Parameters["@cel"].Value = cel.Text;
                            cmd.Parameters["@fax"].Value = fax.Text;
                            cmd.Parameters["@fechan"].Value = fn;
                            cmd.Parameters["@fechac"].Value = fecha.Text;
                            cmd.Parameters["@image"].Value = ms.GetBuffer();
                            cmd.Parameters["@fidep"].Value = 0;
                            cmd.Parameters["@state"].Value = state.Text;
                            cmd.Parameters["@codd"].Value = id;

                            d.OpenCnn();
                            cmd.ExecuteNonQuery();
                            d.CerrarCnn();

                            Messengers mr = new Messengers();
                            mr.textolb.Text = "Cliente Guardado";
                            eliminarUsr();
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
        }

        private void printview_Click(object sender, EventArgs e)
        {
            ViewPrint.Document = printDocx;
            ViewPrint.ShowDialog();
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (this.printMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.printDocx.DocumentName = "Preparando Documento...";
                this.printDocx.Print();
            }
        }

        private void printDocx_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Inicio del encabezado del Documento.
            Conexion r = new Conexion();
            string query = "SELECT * FROM Empresa ; ";
            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
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
                r.OpenCnn();
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
                e.Graphics.DrawString("Solicitudes de Clientes", new Font("Lucida Sans", 18), new SolidBrush(Color.DarkBlue), img.Width + 400, 60);
                //fin Encabezado Documento.



                //Insert DataGrid Print.
                #region Draw Column 1
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height);
                e.Graphics.DrawString(dataGridSol.Columns[1].HeaderText, dataGridSol.Font, Brushes.Black, new RectangleF(10, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height);
                e.Graphics.DrawString(dataGridSol.Columns[2].HeaderText, dataGridSol.Font, Brushes.Black, new RectangleF(10 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(110 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 110 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height);
                e.Graphics.DrawString(dataGridSol.Columns[3].HeaderText, dataGridSol.Font, Brushes.Black, new RectangleF(110 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height), str);
                #endregion

                #region Draw column 4
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(210 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 210 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height);
                e.Graphics.DrawString(dataGridSol.Columns[4].HeaderText, dataGridSol.Font, Brushes.Black, new RectangleF(210 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height), str);
                #endregion

                #region Draw column 5
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(310 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 310 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height);
                e.Graphics.DrawString(dataGridSol.Columns[5].HeaderText, dataGridSol.Font, Brushes.Black, new RectangleF(310 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height), str);
                #endregion

                #region Draw column 6
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(410 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width + 10, dataGridSol.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 410 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width + 10, dataGridSol.Rows[0].Height);
                e.Graphics.DrawString(dataGridSol.Columns[6].HeaderText, dataGridSol.Font, Brushes.Black, new RectangleF(410 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width + 10, dataGridSol.Rows[0].Height), str);
                #endregion

                #region Draw column 7
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(530 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 530 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height);
                e.Graphics.DrawString(dataGridSol.Columns[7].HeaderText, dataGridSol.Font, Brushes.Black, new RectangleF(530 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height), str);
                #endregion

                #region Draw column 8
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(610 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 610 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height);
                e.Graphics.DrawString(dataGridSol.Columns[8].HeaderText, dataGridSol.Font, Brushes.Black, new RectangleF(610 + dataGridSol.Columns[0].Width, 200, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height), str);
                #endregion

                #region Draw Rows N
                width = 10 + dataGridSol.Columns[0].Width;
                height = 200;
                //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
                while (i < dataGridSol.Rows.Count)
                {
                    if (height > e.MarginBounds.Height)
                    {
                        height = 200;
                        width = 10;
                        e.HasMorePages = true;
                        return;
                    }

                    height += dataGridSol.Rows[i].Height;
                    //Draw Row 1
                    e.Graphics.DrawRectangle(Pens.Black, 10, height, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height);
                    e.Graphics.DrawString(dataGridSol.Rows[i].Cells[1].FormattedValue.ToString(), dataGridSol.Font, Brushes.Black, new RectangleF(10, height, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, 10 + dataGridSol.Columns[0].Width, height, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height);
                    e.Graphics.DrawString(dataGridSol.Rows[i].Cells[2].Value.ToString(), dataGridSol.Font, Brushes.Black, new RectangleF(10 + dataGridSol.Columns[0].Width, height, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 110 + dataGridSol.Columns[0].Width, height, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height);
                    e.Graphics.DrawString(dataGridSol.Rows[i].Cells[3].Value.ToString(), dataGridSol.Font, Brushes.Black, new RectangleF(110 + dataGridSol.Columns[0].Width, height, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height), str);
                    //Draw Row 4
                    e.Graphics.DrawRectangle(Pens.Black, 210 + dataGridSol.Columns[0].Width, height, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height);
                    e.Graphics.DrawString(dataGridSol.Rows[i].Cells[4].Value.ToString(), dataGridSol.Font, Brushes.Black, new RectangleF(210 + dataGridSol.Columns[0].Width, height, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height), str);
                    //Draw Row 5
                    e.Graphics.DrawRectangle(Pens.Black, 310 + dataGridSol.Columns[0].Width, height, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height);
                    e.Graphics.DrawString(dataGridSol.Rows[i].Cells[5].Value.ToString(), dataGridSol.Font, Brushes.Black, new RectangleF(310 + dataGridSol.Columns[0].Width, height, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height), str);
                    //Draw Row 6
                    e.Graphics.DrawRectangle(Pens.Black, 410 + dataGridSol.Columns[0].Width, height, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height);
                    e.Graphics.DrawString(dataGridSol.Rows[i].Cells[6].Value.ToString(), dataGridSol.Font, Brushes.Black, new RectangleF(410 + dataGridSol.Columns[0].Width, height, dataGridSol.Columns[0].Width, dataGridSol.Rows[0].Height), str);
                    //Draw Row 7
                    e.Graphics.DrawRectangle(Pens.Black, 530 + dataGridSol.Columns[0].Width, height, dataGridSol.Columns[0].Width - 40, dataGridSol.Rows[0].Height);
                    e.Graphics.DrawString(dataGridSol.Rows[i].Cells[7].Value.ToString(), dataGridSol.Font, Brushes.Black, new RectangleF(530 + dataGridSol.Columns[0].Width, height, dataGridSol.Columns[0].Width - 40, dataGridSol.Rows[0].Height), str);
                    //Draw Row 8
                    e.Graphics.DrawRectangle(Pens.Black, 610 + dataGridSol.Columns[0].Width, height, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height);
                    e.Graphics.DrawString(dataGridSol.Rows[i].Cells[8].Value.ToString(), dataGridSol.Font, Brushes.Black, new RectangleF(610 + dataGridSol.Columns[0].Width, height, dataGridSol.Columns[0].Width - 20, dataGridSol.Rows[0].Height), str);

                    width += dataGridSol.Columns[0].Width;
                    i++;
                }

                #endregion

                r.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridSol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dataGridSol.CurrentRow.Index;
            buscarcic.Text = "";
            buscarcic.ForeColor = SystemColors.WindowText;
            buscarcic.Font = new Font(buscarcic.Font, FontStyle.Regular);
            buscarcic.Text = dataGridSol[1, pos].Value.ToString();
        }
    }
}
