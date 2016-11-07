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
    public partial class RegCliente : Form
    {
        ValidacionText vt = new ValidacionText();
        OpenFileDialog im = new OpenFileDialog();
        Conexion c = new Conexion();
        String id = "3";

        public RegCliente()
        {
            InitializeComponent();

            toolrec.SetToolTip(cirec, "Carnet de Identidad del Cliente");
            toolrec.SetToolTip(nomrec, "Nombres del Cliente");
            toolrec.SetToolTip(aperec, "Apellidos del Cliente");
            toolrec.SetToolTip(nitrec, "NIT para emisión de Facturas");
            toolrec.SetToolTip(correc, "Correo Electrónico");
            toolrec.SetToolTip(webrec, "Pagina Web del Cliente");
            toolrec.SetToolTip(drirec, "Dirección del Cliente");
            toolrec.SetToolTip(deparec, "Departamento donde vive el Cliente");
            toolrec.SetToolTip(prorec, "Provincia donde vive el Cliente");
            toolrec.SetToolTip(fecharec, "Fecha de Hoy");
            toolrec.SetToolTip(starec, "Estado cual se Identifica el Cliente");
            toolrec.SetToolTip(dia, "Dia");
            toolrec.SetToolTip(mes, "Mes");
            toolrec.SetToolTip(anno, "Año");
            toolrec.SetToolTip(telrec, "Teléfono Local del Cliente");
            toolrec.SetToolTip(celrec, "Celular del Cliente");
            toolrec.SetToolTip(faxrec, "Número de Fax del Cliente");
            toolrec.SetToolTip(fotorec, "Ubicación de la Fotografía del Cliente");
            toolrec.SetToolTip(openrec,"Abrir");
            toolrec.SetToolTip(verboton, "Ver Fotografía");
            toolrec.SetToolTip(salirboton, "Salir");
            toolrec.SetToolTip(saveboton, "Guardar");

        }

        private void RegCliente_Load(object sender, EventArgs e)
        {
            Conexion r = new Conexion();
            string query = "SELECT * FROM Departamento; ";

            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
            r.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(1);
                    deparec.Items.Add(Scad);
                }
                r.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.ToString() + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cicliente(object sender, KeyPressEventArgs e)
        {
            cirec.ForeColor = SystemColors.WindowText;
            cirec.Font = new Font(cirec.Font, FontStyle.Regular);
            vt.soloNumeros(e);
        }

        private void telcliente(object sender, KeyPressEventArgs e)
        {
            telrec.ForeColor = SystemColors.WindowText;
            telrec.Font = new Font(telrec.Font, FontStyle.Regular);
            vt.soloNumeros(e);
        }

        private void celcliente(object sender, KeyPressEventArgs e)
        {
            celrec.ForeColor = SystemColors.WindowText;
            celrec.Font = new Font(celrec.Font, FontStyle.Regular);
            vt.soloNumeros(e);
        }

        private void faxcliente(object sender, KeyPressEventArgs e)
        {
            faxrec.ForeColor = SystemColors.WindowText;
            faxrec.Font = new Font(faxrec.Font, FontStyle.Regular);
            vt.soloNumeros(e);
        }

        private void nitcliente(object sender, KeyPressEventArgs e)
        {
            nitrec.ForeColor = SystemColors.WindowText;
            nitrec.Font = new Font(nitrec.Font, FontStyle.Regular);
            vt.soloNumeros(e);
        }

        private void nomcliente(object sender, KeyPressEventArgs e)
        {
            nomrec.ForeColor = SystemColors.WindowText;
            nomrec.Font = new Font(nomrec.Font, FontStyle.Regular);
            vt.soloLetras(e);
        }

        private void apecliente(object sender, KeyPressEventArgs e)
        {
            aperec.ForeColor = SystemColors.WindowText;
            aperec.Font = new Font(aperec.Font, FontStyle.Regular);
            vt.soloLetras(e);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ciregclientClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (cirec.Text != "" && cirec.Font.Italic == true)
                {
                    cirec.Text = "";
                    cirec.ForeColor = SystemColors.WindowText;
                    cirec.Font = new Font(cirec.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    cirec.ForeColor = SystemColors.WindowText;
                    cirec.Font = new Font(cirec.Font, FontStyle.Regular);
                }
            }
        }

        private void nomregClientClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nomrec.Text != "" && nomrec.Font.Italic == true)
                {
                    nomrec.Text = "";
                    nomrec.ForeColor = SystemColors.WindowText;
                    nomrec.Font = new Font(nomrec.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nomrec.ForeColor = SystemColors.WindowText;
                    nomrec.Font = new Font(nomrec.Font, FontStyle.Regular);
                }
            }
        }

        private void aperecClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (aperec.Text != "" && aperec.Font.Italic == true)
                {
                    aperec.Text = "";
                    aperec.ForeColor = SystemColors.WindowText;
                    aperec.Font = new Font(aperec.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    aperec.ForeColor = SystemColors.WindowText;
                    aperec.Font = new Font(aperec.Font, FontStyle.Regular);
                }
            }
        }

        private void nitrecClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nitrec.Text != "" && nitrec.Font.Italic == true)
                {
                    nitrec.Text = "";
                    nitrec.ForeColor = SystemColors.WindowText;
                    nitrec.Font = new Font(nitrec.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nitrec.ForeColor = SystemColors.WindowText;
                    nitrec.Font = new Font(nitrec.Font, FontStyle.Regular);
                }
            }
        }

        private void correcClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (correc.Text != "" && correc.Font.Italic == true)
                {
                    correc.Text = "";
                    correc.ForeColor = SystemColors.WindowText;
                    correc.Font = new Font(correc.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    correc.ForeColor = SystemColors.WindowText;
                    correc.Font = new Font(correc.Font, FontStyle.Regular);
                }
            }
        }

        private void webrecClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (webrec.Text != "" && webrec.Font.Italic == true)
                {
                    webrec.Text = "";
                    webrec.ForeColor = SystemColors.WindowText;
                    webrec.Font = new Font(webrec.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    webrec.ForeColor = SystemColors.WindowText;
                    webrec.Font = new Font(webrec.Font, FontStyle.Regular);
                }
            }
        }

        private void dirrecClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (drirec.Text != "" && drirec.Font.Italic == true)
                {
                    drirec.Text = "";
                    drirec.ForeColor = SystemColors.WindowText;
                    drirec.Font = new Font(drirec.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    drirec.ForeColor = SystemColors.WindowText;
                    drirec.Font = new Font(drirec.Font, FontStyle.Regular);
                }
            }
        }

        private void telrecClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (telrec.Text != "" && telrec.Font.Italic == true)
                {
                    telrec.Text = "";
                    telrec.ForeColor = SystemColors.WindowText;
                    telrec.Font = new Font(telrec.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    telrec.ForeColor = SystemColors.WindowText;
                    telrec.Font = new Font(telrec.Font, FontStyle.Regular);
                }
            }
        }

        private void celrecClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (celrec.Text != "" && celrec.Font.Italic == true)
                {
                    celrec.Text = "";
                    celrec.ForeColor = SystemColors.WindowText;
                    celrec.Font = new Font(celrec.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    celrec.ForeColor = SystemColors.WindowText;
                    celrec.Font = new Font(celrec.Font, FontStyle.Regular);
                }
            }
        }

        private void faxrecClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (faxrec.Text != "" && faxrec.Font.Italic == true)
                {
                    faxrec.Text = "";
                    faxrec.ForeColor = SystemColors.WindowText;
                    faxrec.Font = new Font(faxrec.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    faxrec.ForeColor = SystemColors.WindowText;
                    faxrec.Font = new Font(faxrec.Font, FontStyle.Regular);
                }
            }
        }

        private void fotorecClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (fotorec.Text != "" && fotorec.Font.Italic == true)
                {
                    fotorec.Text = "";
                    fotorec.ForeColor = SystemColors.WindowText;
                    fotorec.Font = new Font(fotorec.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    fotorec.ForeColor = SystemColors.WindowText;
                    fotorec.Font = new Font(fotorec.Font, FontStyle.Regular);
                }
            }
        }

        private void openrec_Click(object sender, EventArgs e)
        {
            im.InitialDirectory = "C:\\";
            im.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            im.Title = "Abrir Imagen de Perfil";

            if (im.ShowDialog() == DialogResult.OK)
            {
                fotorec.Text = "";
                fotorec.ForeColor = SystemColors.WindowText;
                fotorec.Font = new Font(fotorec.Font, FontStyle.Regular);
                fotorec.Text = im.FileName;
                //fotoCliente.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verboton_Click(object sender, EventArgs e)
        {
            if (fotorec.Text != "" && fotorec.Font.Italic == true)
            {
                if (fotorec.Text == "")
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (fotorec.Text == "")
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta o Escriba la Dirección de la Imagen.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fotograhp.ImageLocation = im.FileName;
            }
        }

        public static bool ValidarEmail(String texto)
        {
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


        private void correc_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(correc.Text))
            {

            }
            else
            {
                MessageBox.Show("Dirrección de Correo Electrónico No Valida. El Correo Debe Tener El Formato: nombre@dominio.com  Porfavor Seleccione un Correo Electroónico Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                correc.SelectAll();
                correc.Focus();
            }
        }

        private void webboton_Click(object sender, EventArgs e)
        {
            if (webrec.Text != "" && webrec.Font.Italic == true)
            {
                if (webrec.Text == "")
                {
                    MessageBox.Show("Ingrese la Dirección de la Pagina Web del Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese la Dirección de la Pagina Web del Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (webrec.Text == "")
            {
                MessageBox.Show("Ingrese la Dirección de la Pagina Web del Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                REV_WebStudio we = new REV_WebStudio();
                we.texturlweb.Text = webrec.Text;
                we.webBrow.Navigate(webrec.Text);
                we.ShowDialog();
            }
        }

        private void deparec_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion r = new Conexion();
            string query = "SELECT nombrePro, CodDep FROM Provincia, Departamento WHERE CodDep=codigoDep AND nombreDep= '" + deparec.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
            r.OpenCnn();
            SqlDataReader read;

            try
            {
                read = sqlQ.ExecuteReader();
                prorec.Items.Clear();
                while (read.Read())
                {
                    String cade = read.GetString(0);
                    prorec.Items.Add(cade);
                    id = read.GetString(1);
                }
                r.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.ToString() + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }   
        }

        private int comprobar()
        {
            int cnt = 0;
            Conexion r = new Conexion();
            string buscar = "SELECT * FROM Clientes WHERE idCliente= '" + Convert.ToInt32(cirec.Text) + "' ; ";
            r.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, r.GetCONN());

            try
            {
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);             
            }
            r.CerrarCnn();
            return cnt;
        }


        private void saveboton_Click(object sender, EventArgs e)
        {
            String fn = "" + dia.Text + " " + mes.Text + " " + anno.Text;
            String sex = sexmax.Text;

            if ((cirec.Text != "" && cirec.Font.Italic == true) || nomrec.Font.Italic == true || aperec.Font.Italic == true || nitrec.Font.Italic == true || drirec.Font.Italic == true || correc.Font.Italic == true || webrec.Font.Italic == true || telrec.Font.Italic == true || celrec.Font.Italic == true || faxrec.Font.Italic == true || fotorec.Font.Italic == true)
            {
                if (cirec.Text == "")
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
            else if (cirec.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nitrec.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre de Usuario o Identificacion para el Cliente ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nomrec.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Contraseña para el Ingreso del Cliente ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //Codigo de guardar usuario.
                    if (comprobar() == 0)
                    {
                        if (sexfem.Checked == true)
                        {
                            sex = sexfem.Text;
                            try
                            {   // Objetos de conexión y comando
                                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                                // Estableciento propiedades
                                cmd.Connection = c.GetCONN();
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
                                fotograhp.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                                // Asignando los valores a los atributos
                                cmd.Parameters["@id"].Value = int.Parse(cirec.Text);
                                cmd.Parameters["@name"].Value = nomrec.Text;
                                cmd.Parameters["@ape"].Value = aperec.Text;
                                cmd.Parameters["@nit"].Value = nitrec.Text;
                                cmd.Parameters["@correo"].Value = correc.Text;
                                cmd.Parameters["@web"].Value = webrec.Text;
                                cmd.Parameters["@dir"].Value = drirec.Text;
                                cmd.Parameters["@sexo"].Value = sex;
                                cmd.Parameters["@tel"].Value = int.Parse(telrec.Text);
                                cmd.Parameters["@cel"].Value = int.Parse(celrec.Text);
                                cmd.Parameters["@fax"].Value = int.Parse(faxrec.Text);
                                cmd.Parameters["@fechan"].Value = fn;
                                cmd.Parameters["@fechac"].Value = fecharec.Text;
                                cmd.Parameters["@image"].Value = ms.GetBuffer();
                                cmd.Parameters["@fidep"].Value = 0;
                                cmd.Parameters["@state"].Value = starec.Text;
                                cmd.Parameters["@codd"].Value = id;

                                c.OpenCnn();
                                cmd.ExecuteNonQuery();
                                c.CerrarCnn();

                                Messengers mr = new Messengers();
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
                                cmd.Connection = c.GetCONN();
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
                                fotograhp.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                                // Asignando los valores a los atributos
                                cmd.Parameters["@id"].Value = int.Parse(cirec.Text);
                                cmd.Parameters["@name"].Value = nomrec.Text;
                                cmd.Parameters["@ape"].Value = aperec.Text;
                                cmd.Parameters["@nit"].Value = nitrec.Text;
                                cmd.Parameters["@correo"].Value = correc.Text;
                                cmd.Parameters["@web"].Value = webrec.Text;
                                cmd.Parameters["@dir"].Value = drirec.Text;
                                cmd.Parameters["@sexo"].Value = sex;
                                cmd.Parameters["@tel"].Value = telrec.Text;
                                cmd.Parameters["@cel"].Value = celrec.Text;
                                cmd.Parameters["@fax"].Value = faxrec.Text;
                                cmd.Parameters["@fechan"].Value = fn;
                                cmd.Parameters["@fechac"].Value = fecharec.Text;
                                cmd.Parameters["@image"].Value = ms.GetBuffer();
                                cmd.Parameters["@fidep"].Value = 0;
                                cmd.Parameters["@state"].Value = starec.Text;
                                cmd.Parameters["@codd"].Value = id;

                                c.OpenCnn();
                                cmd.ExecuteNonQuery();
                                c.CerrarCnn();

                                Messengers mr = new Messengers();
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

        private void emailpress(object sender, KeyPressEventArgs e)
        {
            correc.ForeColor = SystemColors.WindowText;
            correc.Font = new Font(correc.Font, FontStyle.Regular);
        }

        private void webpress(object sender, KeyPressEventArgs e)
        {
            webrec.ForeColor = SystemColors.WindowText;
            webrec.Font = new Font(webrec.Font, FontStyle.Regular);
        }

        private void dirpress(object sender, KeyPressEventArgs e)
        {
            drirec.ForeColor = SystemColors.WindowText;
            drirec.Font = new Font(drirec.Font, FontStyle.Regular);
            //vt.soloLetras(e);
            //vt.soloNumeros(e);
        }

        private void ubifotoPress(object sender, KeyPressEventArgs e)
        {
            fotorec.ForeColor = SystemColors.WindowText;
            fotorec.Font = new Font(fotorec.Font, FontStyle.Regular);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            cirec.Text = "";
            cirec.ForeColor = SystemColors.WindowText;
            cirec.Font = new Font(cirec.Font, FontStyle.Regular);
            nomrec.Text = "";
            nomrec.ForeColor = SystemColors.WindowText;
            nomrec.Font = new Font(nomrec.Font, FontStyle.Regular);
            aperec.Text = "";
            aperec.ForeColor = SystemColors.WindowText;
            aperec.Font = new Font(aperec.Font, FontStyle.Regular);
            nitrec.Text = "";
            nitrec.ForeColor = SystemColors.WindowText;
            nitrec.Font = new Font(nitrec.Font, FontStyle.Regular);
            correc.Text = "";
            correc.ForeColor = SystemColors.WindowText;
            correc.Font = new Font(correc.Font, FontStyle.Regular);
            fotorec.Text = "";
            fotorec.ForeColor = SystemColors.WindowText;
            fotorec.Font = new Font(fotorec.Font, FontStyle.Regular);
            drirec.Text = "";
            drirec.ForeColor = SystemColors.WindowText;
            drirec.Font = new Font(drirec.Font, FontStyle.Regular);
            webrec.Text = "";
            webrec.ForeColor = SystemColors.WindowText;
            webrec.Font = new Font(webrec.Font, FontStyle.Regular);
            telrec.Text = "";
            telrec.ForeColor = SystemColors.WindowText;
            telrec.Font = new Font(telrec.Font, FontStyle.Regular);
            celrec.Text = "";
            celrec.ForeColor = SystemColors.WindowText;
            celrec.Font = new Font(celrec.Font, FontStyle.Regular);
            faxrec.Text = "";
            faxrec.ForeColor = SystemColors.WindowText;
            faxrec.Font = new Font(faxrec.Font, FontStyle.Regular);
        }
    }
}
