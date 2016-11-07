using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Proyect_Kardex
{
    public partial class EditCliente : Form
    {
        Conexion cs = new Conexion();
        ValidacionText mn = new ValidacionText();
        OpenFileDialog img = new OpenFileDialog();
        String id = "3";

        public EditCliente()
        {
            InitializeComponent();

            tooleditcliente.SetToolTip(ciedcli, "Ingresar Carnet de Identidad del Cliente");
            tooleditcliente.SetToolTip(ci, "Carnet de Identidad del Cliente");
            tooleditcliente.SetToolTip(buscaredboton, "Buscar Cliente");
            tooleditcliente.SetToolTip(regboton, "Registro de Clientes");
            tooleditcliente.SetToolTip(nomed, "Nombres del Cliente");
            tooleditcliente.SetToolTip(apeled, "Apellidos del Cliente");
            tooleditcliente.SetToolTip(nited, "NIT para las Facturas");
            tooleditcliente.SetToolTip(corred, "Correo Electronico del Cliente");
            tooleditcliente.SetToolTip(webed, "Pagina Web del Cliente");
            tooleditcliente.SetToolTip(dired, "Dirrección del Cliente");
            tooleditcliente.SetToolTip(depaed, "Departamento donde vive el Cliente");
            tooleditcliente.SetToolTip(proved, "Provincia donde vive el Cliente");
            tooleditcliente.SetToolTip(fechaed, "Fecha del Hoy ");
            tooleditcliente.SetToolTip(staed, "Estado cual se Identifica el Cliente");
            tooleditcliente.SetToolTip(dia, "Dia");
            tooleditcliente.SetToolTip(mes, "Mes");
            tooleditcliente.SetToolTip(anno, "Año");
            tooleditcliente.SetToolTip(teled, "Teléfono del Cliente");
            tooleditcliente.SetToolTip(celed, "Celular del Cliente");
            tooleditcliente.SetToolTip(faxed, "Fax del Cliente");
            tooleditcliente.SetToolTip(fotoed, "Ubicación de la Foto del Cliente");
            tooleditcliente.SetToolTip(openboton, "Abrir");
            tooleditcliente.SetToolTip(verboton, "Mostrar la Fotografia del Cliente");
            tooleditcliente.SetToolTip(saveboton, "Guardar");
            tooleditcliente.SetToolTip(salirboton, "Salir");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Esta Seguro que Desea Cancelar la Modificación del Cliente?";
            string caption = "Cancelar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            { // Closes the parent form.
                this.Close();
            }
        }

        private void ciCliente(object sender, KeyPressEventArgs e)
        {
            ci.ForeColor = SystemColors.WindowText;
            ci.Font = new Font(ci.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void busquedaci(object sender, KeyPressEventArgs e)
        {
            ciedcli.ForeColor = SystemColors.WindowText;
            ciedcli.Font = new Font(ciedcli.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void nitCliente(object sender, KeyPressEventArgs e)
        {
            nited.ForeColor = SystemColors.WindowText;
            nited.Font = new Font(nited.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void telCliente(object sender, KeyPressEventArgs e)
        {
            teled.ForeColor = SystemColors.WindowText;
            teled.Font = new Font(teled.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void celCliente(object sender, KeyPressEventArgs e)
        {
            celed.ForeColor = SystemColors.WindowText;
            celed.Font = new Font(celed.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void faxCliente(object sender, KeyPressEventArgs e)
        {
            faxed.ForeColor = SystemColors.WindowText;
            faxed.Font = new Font(faxed.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void nomCliente(object sender, KeyPressEventArgs e)
        {
            nomed.ForeColor = SystemColors.WindowText;
            nomed.Font = new Font(nomed.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void apeCliente(object sender, KeyPressEventArgs e)
        {
            apeled.ForeColor = SystemColors.WindowText;
            apeled.Font = new Font(apeled.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void ciedclientClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (ciedcli.Text != "" && ciedcli.Font.Italic == true)
                {
                    ciedcli.Text = "";
                    ciedcli.ForeColor = SystemColors.WindowText;
                    ciedcli.Font = new Font(ciedcli.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    ciedcli.ForeColor = SystemColors.WindowText;
                    ciedcli.Font = new Font(ciedcli.Font, FontStyle.Regular);
                }
            }
        }

        private void ciClientClick(object sender, MouseEventArgs e)
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

        private void nomedClientClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nomed.Text != "" && nomed.Font.Italic == true)
                {
                    nomed.Text = "";
                    nomed.ForeColor = SystemColors.WindowText;
                    nomed.Font = new Font(nomed.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nomed.ForeColor = SystemColors.WindowText;
                    nomed.Font = new Font(nomed.Font, FontStyle.Regular);
                }
            }
        }

        private void apedClientClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (apeled.Text != "" && apeled.Font.Italic == true)
                {
                    apeled.Text = "";
                    apeled.ForeColor = SystemColors.WindowText;
                    apeled.Font = new Font(apeled.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    apeled.ForeColor = SystemColors.WindowText;
                    apeled.Font = new Font(apeled.Font, FontStyle.Regular);
                }
            }
        }

        private void nitedClienteClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nited.Text != "" && nited.Font.Italic == true)
                {
                    nited.Text = "";
                    nited.ForeColor = SystemColors.WindowText;
                    nited.Font = new Font(nited.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nited.ForeColor = SystemColors.WindowText;
                    nited.Font = new Font(nited.Font, FontStyle.Regular);
                }
            }
        }

        private void coredClientClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (corred.Text != "" && corred.Font.Italic == true)
                {
                    corred.Text = "";
                    corred.ForeColor = SystemColors.WindowText;
                    corred.Font = new Font(corred.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    corred.ForeColor = SystemColors.WindowText;
                    corred.Font = new Font(corred.Font, FontStyle.Regular);
                }
            }
        }

        private void webedClienteClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (webed.Text != "" && webed.Font.Italic == true)
                {
                    webed.Text = "";
                    webed.ForeColor = SystemColors.WindowText;
                    webed.Font = new Font(webed.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    webed.ForeColor = SystemColors.WindowText;
                    webed.Font = new Font(webed.Font, FontStyle.Regular);
                }
            }
        }

        private void diredClientClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (dired.Text != "" && dired.Font.Italic == true)
                {
                    dired.Text = "";
                    dired.ForeColor = SystemColors.WindowText;
                    dired.Font = new Font(dired.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    dired.ForeColor = SystemColors.WindowText;
                    dired.Font = new Font(dired.Font, FontStyle.Regular);
                }
            }
        }

        private void teledClientClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (teled.Text != "" && teled.Font.Italic == true)
                {
                    teled.Text = "";
                    teled.ForeColor = SystemColors.WindowText;
                    teled.Font = new Font(teled.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    teled.ForeColor = SystemColors.WindowText;
                    teled.Font = new Font(teled.Font, FontStyle.Regular);
                }
            }
        }

        private void celedClientClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (celed.Text != "" && celed.Font.Italic == true)
                {
                    celed.Text = "";
                    celed.ForeColor = SystemColors.WindowText;
                    celed.Font = new Font(celed.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    celed.ForeColor = SystemColors.WindowText;
                    celed.Font = new Font(celed.Font, FontStyle.Regular);
                }
            }
        }

        private void faxedClientClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (faxed.Text != "" && faxed.Font.Italic == true)
                {
                    faxed.Text = "";
                    faxed.ForeColor = SystemColors.WindowText;
                    faxed.Font = new Font(faxed.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    faxed.ForeColor = SystemColors.WindowText;
                    faxed.Font = new Font(faxed.Font, FontStyle.Regular);
                }
            }
        }

        private void fotoedClientClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (fotoed.Text != "" && fotoed.Font.Italic == true)
                {
                    fotoed.Text = "";
                    fotoed.ForeColor = SystemColors.WindowText;
                    fotoed.Font = new Font(fotoed.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    fotoed.ForeColor = SystemColors.WindowText;
                    fotoed.Font = new Font(fotoed.Font, FontStyle.Regular);
                }
            }
        }

        private int comprobar()
        {
            int cnt = 0;
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Clientes WHERE idCliente= '" + Convert.ToInt32(ciedcli.Text) + "' ; ";

            try
            {
                d.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, d.GetCONN());
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

        private String GetDepa(String value)
        {
            String res = "";
            Conexion h = new Conexion();
            string query = "SELECT * FROM Departamento WHERE codigoDep = '" + value + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, h.GetCONN());
            h.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    res = read2.GetString(1);
                }
            }
            catch (Exception) { }
            h.CerrarCnn();
            return res;
        }

        private void buscaredboton_Click(object sender, EventArgs e)
        {
            Conexion f = new Conexion();
            if (ciedcli.Text != "" && ciedcli.Font.Italic == true)
            {
                if (ciedcli.Text == "")
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
            else if (ciedcli.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de Buscar Cliente.
                string query = "SELECT * FROM Clientes WHERE idCliente ='" + Convert.ToInt32(ciedcli.Text) + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, f.GetCONN());
                SqlDataReader read;
                if (comprobar() == 1)
                {
                    ci.Text = "";
                    ci.ForeColor = SystemColors.WindowText;
                    ci.Font = new Font(ci.Font, FontStyle.Regular);
                    nomed.Text = "";
                    nomed.ForeColor = SystemColors.WindowText;
                    nomed.Font = new Font(nomed.Font, FontStyle.Regular);
                    apeled.Text = "";
                    apeled.ForeColor = SystemColors.WindowText;
                    apeled.Font = new Font(apeled.Font, FontStyle.Regular);
                    nited.Text = "";
                    nited.ForeColor = SystemColors.WindowText;
                    nited.Font = new Font(nited.Font, FontStyle.Regular);
                    corred.Text = "";
                    corred.ForeColor = SystemColors.WindowText;
                    corred.Font = new Font(corred.Font, FontStyle.Regular);
                    webed.Text = "";
                    webed.ForeColor = SystemColors.WindowText;
                    webed.Font = new Font(webed.Font, FontStyle.Regular);
                    teled.Text = "";
                    teled.ForeColor = SystemColors.WindowText;
                    teled.Font = new Font(teled.Font, FontStyle.Regular);
                    celed.Text = "";
                    celed.ForeColor = SystemColors.WindowText;
                    celed.Font = new Font(celed.Font, FontStyle.Regular);
                    faxed.Text = "";
                    faxed.ForeColor = SystemColors.WindowText;
                    faxed.Font = new Font(faxed.Font, FontStyle.Regular);
                    fotoed.Text = "";
                    fotoed.ForeColor = SystemColors.WindowText;
                    fotoed.Font = new Font(fotoed.Font, FontStyle.Regular);
                    dired.Text = "";
                    dired.ForeColor = SystemColors.WindowText;
                    dired.Font = new Font(dired.Font, FontStyle.Regular);

                    try
                    {
                        f.OpenCnn();
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            ci.Text = read.GetInt32(0).ToString();
                            nomed.Text = read.GetString(1);
                            apeled.Text = read.GetString(2);
                            nited.Text = read.GetString(3);
                            corred.Text = read.GetString(4);
                            webed.Text = read.GetString(5);
                            dired.Text = read.GetString(6);
                            teled.Text = read.GetInt32(8).ToString();
                            celed.Text = read.GetInt32(9).ToString();
                            faxed.Text = read.GetInt32(10).ToString();
                            staed.SelectedItem = read.GetString(15);
                            dia.SelectedItem = read.GetString(11).Substring(0, 2);
                            mes.SelectedItem = read.GetString(11).Substring(3, 2);
                            anno.SelectedItem = read.GetString(11).Substring(6, 4);
                            depaed.SelectedItem = GetDepa(read.GetString(16));

                            // El campo productImage primero se almacena en un buffer
                            byte[] imageBuffer = (byte[])(read[13]);
                            // Se crea un MemoryStream a partir de ese buffer                        

                            if (imageBuffer == null || read[13] == null)
                            {
                                fotoCliente.Image = null;
                            }
                            else
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                                fotoCliente.Image = Image.FromStream(ms);
                            }

                            if (read.GetString(7) == "Masculino")
                            {
                                sexMax.Checked = true;
                                sexFem.Checked = false;
                            }
                            else
                            {
                                sexFem.Checked = true;
                                sexMax.Checked = false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Existe Datos Nulos con el Cliente Ingresado. \n" + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con el Cliente a Modificar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        f.CerrarCnn();
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, El Cliente Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    f.CerrarCnn();
                }
            }
        }

        private void regboton_Click(object sender, EventArgs e)
        {
            Registro_Clientes re = new Registro_Clientes();
            re.nuevo.Enabled = false;
            re.nuevo.BackgroundImage = global::Proyect_Kardex.Properties.Resources.novob;
            re.editar.Enabled = false;
            re.editar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editdocumentob;
            re.eliminar.Enabled = false;
            re.eliminar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_deleteb;
            re.ShowDialog();
            ciedcli.Text = "";
            ciedcli.ForeColor = SystemColors.WindowText;
            ciedcli.Font = new Font(ciedcli.Font, FontStyle.Regular);
            ciedcli.Text = re.codUser.ToString(); 
        }

        private void openboton_Click(object sender, EventArgs e)
        {
            img.InitialDirectory = "C:\\";
            img.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            img.Title = "Abrir Imagen de Perfil";

            if (img.ShowDialog() == DialogResult.OK)
            {
                fotoed.Text = "";
                fotoed.ForeColor = SystemColors.WindowText;
                fotoed.Font = new Font(fotoed.Font, FontStyle.Regular);
                fotoed.Text = img.FileName;
                //fotoCliente.ImageLocation = img.FileName;
            }
            else {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verboton_Click(object sender, EventArgs e)
        {
            if(fotoed.Text != "" && fotoed.Font.Italic == true){
                if (fotoed.Text == "")
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (fotoed.Text == "")
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta o Escriba la Dirección de la Imagen.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                fotoCliente.ImageLocation = img.FileName;
            }

        }

        public static bool ValidarEmail(String texto) {
            String exper = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(texto, exper))
            {
                if (Regex.Replace(texto, exper, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        } 

        private void emailClientreg(object sender, EventArgs e)
        {
            if (ValidarEmail(corred.Text))
            {

            }
            else {
                MessageBox.Show("Dirrección de Correo Electrónico No Valida. El Correo Debe Tener El Formato: nombre@dominio.com  Porfavor Seleccione un Correo Electroónico Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                corred.SelectAll();
                corred.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webed.Text != "" && webed.Font.Italic == true)
            {
                if (webed.Text == "")
                {
                    MessageBox.Show("Ingrese la Dirección de la Pagina Web del Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese la Dirección de la Pagina Web del Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (webed.Text == "")
            {
                MessageBox.Show("Ingrese la Dirección de la Pagina Web del Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                REV_WebStudio we = new REV_WebStudio();
                we.texturlweb.Text = webed.Text;
                we.webBrow.Navigate(webed.Text);
                we.ShowDialog();
            }
        }

        private void corred_KeyPress(object sender, KeyPressEventArgs e)
        {
            corred.ForeColor = SystemColors.WindowText;
            corred.Font = new Font(corred.Font, FontStyle.Regular);
        }

        private void webed_KeyPress(object sender, KeyPressEventArgs e)
        {
            webed.ForeColor = SystemColors.WindowText;
            webed.Font = new Font(webed.Font, FontStyle.Regular);
        }

        private void dired_KeyPress(object sender, KeyPressEventArgs e)
        {
            dired.ForeColor = SystemColors.WindowText;
            dired.Font = new Font(dired.Font, FontStyle.Regular);
        }

        private void fotoed_KeyPress(object sender, KeyPressEventArgs e)
        {
            fotoed.ForeColor = SystemColors.WindowText;
            fotoed.Font = new Font(fotoed.Font, FontStyle.Regular);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ciedcli.Text = "";
            ciedcli.ForeColor = SystemColors.WindowText;
            ciedcli.Font = new Font(ciedcli.Font, FontStyle.Regular);
            ci.Text = "";
            ci.ForeColor = SystemColors.WindowText;
            ci.Font = new Font(ci.Font, FontStyle.Regular);
            nomed.Text = "";
            nomed.ForeColor = SystemColors.WindowText;
            nomed.Font = new Font(nomed.Font, FontStyle.Regular);
            apeled.Text = "";
            apeled.ForeColor = SystemColors.WindowText;
            apeled.Font = new Font(apeled.Font, FontStyle.Regular);
            nited.Text = "";
            nited.ForeColor = SystemColors.WindowText;
            nited.Font = new Font(nited.Font, FontStyle.Regular);
            corred.Text = "";
            corred.ForeColor = SystemColors.WindowText;
            corred.Font = new Font(corred.Font, FontStyle.Regular);
            webed.Text = "";
            webed.ForeColor = SystemColors.WindowText;
            webed.Font = new Font(webed.Font, FontStyle.Regular);
            teled.Text = "";
            teled.ForeColor = SystemColors.WindowText;
            teled.Font = new Font(teled.Font, FontStyle.Regular);
            celed.Text = "";
            celed.ForeColor = SystemColors.WindowText;
            celed.Font = new Font(celed.Font, FontStyle.Regular);
            faxed.Text = "";
            faxed.ForeColor = SystemColors.WindowText;
            faxed.Font = new Font(faxed.Font, FontStyle.Regular);
            fotoed.Text = "";
            fotoed.ForeColor = SystemColors.WindowText;
            fotoed.Font = new Font(fotoed.Font, FontStyle.Regular);

        }

        private void EditCliente_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Departamento; ";

            SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
            cs.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(1);
                    depaed.Items.Add(Scad);
                }
                cs.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cs.CerrarCnn();
            }
        }

        private void depaed_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT nombrePro, CodDep FROM Provincia, Departamento WHERE CodDep=codigoDep AND nombreDep= '" + depaed.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
            cs.OpenCnn();
            SqlDataReader read;
            try
            {
                read = sqlQ.ExecuteReader();
                proved.Items.Clear();
                while (read.Read())
                {
                    String cade = read.GetString(0);
                    proved.Items.Add(cade);
                    id = read.GetString(1);
                }
                cs.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cs.CerrarCnn();
            }  
        }

        private void saveboton_Click(object sender, EventArgs e)
        {
            String fn = dia.Text + " " + mes.Text + " " + anno.Text;
            String sex = sexMax.Text;

            if (ciedcli.Text != "" && ciedcli.Font.Italic == true)
            {
                if (ciedcli.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Usuario a Modificar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Usuario a Modificar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ciedcli.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Usuario a Modificar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nomed.Text == "" || nomed.Font.Italic == true)
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Usuario a Modificar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nited.Text == "" || nited.Font.Italic == true)
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Usuario a Modificar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de editar Cliente.
                if (comprobar() == 1)
                {                   
                        if (sexFem.Checked == true)
                        {
                            sex = sexFem.Text;
                            try
                            {   // Objetos de conexión y comando
                                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                                // Asignando el valor de la imagen
                                // Stream usado como buffer
                                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                                // Se guarda la imagen en el buffer
                                fotoCliente.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                                // Estableciento propiedades
                                cmd.Connection = cs.GetCONN();
                                cmd.CommandText = "UPDATE Clientes SET idCliente=@id, nombreCliente=@nom, apellidoCliente=@ape, nitCliente=@nit, correoCliente=@email, webCliente=@web, DirCliente=@dir, sexoCliente=@sexo, telCliente=@tel, celCliente=@cel, faxCliente=@fax, fnCliente=@fechan, fcCliente=@fechac, fotoCliente=@imagen, estado=@state, CodDepaC=@codd  WHERE idCliente = @ciid ;";

                                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@nit", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@web", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@dir", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@tel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@cel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@fax", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@fechan", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@fechac", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@imagen", System.Data.SqlDbType.Image);
                                cmd.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@ciid", System.Data.SqlDbType.Int);

                                // Asignando los valores a los atributos
                                cmd.Parameters["@id"].Value = int.Parse(ci.Text);
                                cmd.Parameters["@nom"].Value = nomed.Text;
                                cmd.Parameters["@ape"].Value = apeled.Text;
                                cmd.Parameters["@nit"].Value = nited.Text;
                                cmd.Parameters["@email"].Value = corred.Text;
                                cmd.Parameters["@web"].Value = webed.Text;
                                cmd.Parameters["@dir"].Value = dired.Text;
                                cmd.Parameters["@sexo"].Value = sex;
                                cmd.Parameters["@tel"].Value = int.Parse(teled.Text);
                                cmd.Parameters["@cel"].Value = int.Parse(celed.Text);
                                cmd.Parameters["@fax"].Value = int.Parse(faxed.Text);
                                cmd.Parameters["@fechan"].Value = fn;
                                cmd.Parameters["@fechac"].Value = fechaed.Text;
                                cmd.Parameters["@imagen"].Value = ms.GetBuffer();
                                cmd.Parameters["@state"].Value = staed.Text;
                                cmd.Parameters["@codd"].Value = id;
                                cmd.Parameters["@ciid"].Value = int.Parse(ciedcli.Text);

                                cs.OpenCnn();
                                cmd.ExecuteNonQuery();
                                cs.CerrarCnn();

                                Messengers mr = new Messengers();
                                mr.textolb.Text = "Cliente Modificado";
                                mr.ShowDialog();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR. Al Modificar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            try
                            {   // Objetos de conexión y comando
                                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                                // Asignando el valor de la imagen
                                // Stream usado como buffer
                                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                                // Se guarda la imagen en el buffer
                                fotoCliente.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                                // Estableciento propiedades
                                cmd.Connection = cs.GetCONN();
                                cmd.CommandText = "UPDATE Clientes SET idCliente=@id, nombreCliente=@nom, apellidoCliente=@ape, nitCliente=@nit, correoCliente=@email, webCliente=@web, DirCliente=@dir, sexoCliente=@sexo, telCliente=@tel, celCliente=@cel, faxCliente=@fax, fnCliente=@fechan, fcCliente=@fechac, fotoCliente=@imagen, estado=@state, CodDepaC=@codd  WHERE idCliente = @ciid ;";

                                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@nit", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@web", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@dir", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@tel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@cel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@fax", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@fechan", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@fechac", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@imagen", System.Data.SqlDbType.Image);
                                cmd.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@ciid", System.Data.SqlDbType.Int);

                                // Asignando los valores a los atributos
                                cmd.Parameters["@id"].Value = int.Parse(ci.Text);
                                cmd.Parameters["@nom"].Value = nomed.Text;
                                cmd.Parameters["@ape"].Value = apeled.Text;
                                cmd.Parameters["@nit"].Value = nited.Text;
                                cmd.Parameters["@email"].Value = corred.Text;
                                cmd.Parameters["@web"].Value = webed.Text;
                                cmd.Parameters["@dir"].Value = dired.Text;
                                cmd.Parameters["@sexo"].Value = sex;
                                cmd.Parameters["@tel"].Value = int.Parse(teled.Text);
                                cmd.Parameters["@cel"].Value = int.Parse(celed.Text);
                                cmd.Parameters["@fax"].Value = int.Parse(faxed.Text);
                                cmd.Parameters["@fechan"].Value = fn;
                                cmd.Parameters["@fechac"].Value = fechaed.Text;
                                cmd.Parameters["@imagen"].Value = ms.GetBuffer();
                                cmd.Parameters["@state"].Value = staed.Text;
                                cmd.Parameters["@codd"].Value = id;
                                cmd.Parameters["@ciid"].Value = int.Parse(ciedcli.Text);

                                cs.OpenCnn();
                                cmd.ExecuteNonQuery();
                                cs.CerrarCnn();

                                Messengers mr = new Messengers();
                                mr.textolb.Text = "Cliente Modificado";
                                mr.ShowDialog();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR. Al Modificar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }                                       
                }
                else
                {
                    MessageBox.Show("Error, No Existen Registros del Usuario.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




    }
}
