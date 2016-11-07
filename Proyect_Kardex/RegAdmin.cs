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
using System.IO;

namespace Proyect_Kardex
{
    public partial class RegAdmin : Form
    {
        ValidacionText vt = new ValidacionText();
        OpenFileDialog im = new OpenFileDialog();
        Conexion c = new Conexion();
        String id = "3";

        public RegAdmin()
        {
            InitializeComponent();

            toolrea.SetToolTip(cire, "Carnet de Identidad");
            toolrea.SetToolTip(nomre, "Ingresar sus Nombres");
            toolrea.SetToolTip(apere, "Ingresar sus Apellidos");
            toolrea.SetToolTip(namere, "Identificador del Nombre como Usuario");
            toolrea.SetToolTip(passre, "Contraseña de Usuario");
            toolrea.SetToolTip(confpasre,"Repetir la misma Contraseña");
            toolrea.SetToolTip(dirre, "Ingresar la Dirección donde Vive");
            toolrea.SetToolTip(depare, "Departamento donde vive");
            toolrea.SetToolTip(provre, "Provincia donde vive");
            toolrea.SetToolTip(fotore, "Ubicación de su Fotografía");
            toolrea.SetToolTip(nivre, "Nivel de Estudios la cual Presenta");
            toolrea.SetToolTip(cargore, "Cargo de Ocupación de Trabajo con la Empresa");
            toolrea.SetToolTip(dia,"Dia");
            toolrea.SetToolTip(mes, "Mes");
            toolrea.SetToolTip(anno, "Año");
            toolrea.SetToolTip(corre,"Correo Electronico");
            toolrea.SetToolTip(telre, "Teléfono Local");
            toolrea.SetToolTip(celre, "Celular");
            toolrea.SetToolTip(faxre, "Número de Fax");
            toolrea.SetToolTip(openre,"Abrir");
            toolrea.SetToolTip(verboton, "Ver Fotografía");
            toolrea.SetToolTip(saveboton, "Guardar");
            toolrea.SetToolTip(salirboton, "Salir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.CerrarCnn();
            this.Close();
        }

        private void ciadmin(object sender, KeyPressEventArgs e)
        {
            cire.ForeColor = SystemColors.WindowText;
            cire.Font = new Font(cire.Font, FontStyle.Regular);
            vt.soloNumeros(e);
        }

        private void nomuser(object sender, KeyPressEventArgs e)
        {
            nomre.ForeColor = SystemColors.WindowText;
            nomre.Font = new Font(nomre.Font, FontStyle.Regular);
            vt.soloLetras(e);
        }

        private void apeuser(object sender, KeyPressEventArgs e)
        {
            apere.ForeColor = SystemColors.WindowText;
            apere.Font = new Font(apere.Font, FontStyle.Regular);
            vt.soloLetras(e);
        }

        private void teluser(object sender, KeyPressEventArgs e)
        {
            telre.ForeColor = SystemColors.WindowText;
            telre.Font = new Font(telre.Font, FontStyle.Regular);
            vt.soloNumeros(e);
        }

        private void celuser(object sender, KeyPressEventArgs e)
        {
            celre.ForeColor = SystemColors.WindowText;
            celre.Font = new Font(faxre.Font, FontStyle.Regular);
            vt.soloNumeros(e);
        }

        private void faxuser(object sender, KeyPressEventArgs e)
        {
            faxre.ForeColor = SystemColors.WindowText;
            faxre.Font = new Font(faxre.Font, FontStyle.Regular);
            vt.soloNumeros(e);
        }

        private void ciadminclick(object sender, MouseEventArgs e)
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

        private void nameadminclick(object sender, MouseEventArgs e)
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

        private void apeadminclick(object sender, MouseEventArgs e)
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

        private void nomadClick(object sender, MouseEventArgs e)
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

        private void diradClick(object sender, MouseEventArgs e)
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

        private void fotoadminClick(object sender, MouseEventArgs e)
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

        private void CargoadminClick(object sender, MouseEventArgs e)
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

        private void coradminClick(object sender, MouseEventArgs e)
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

        private void TelAdminClick(object sender, MouseEventArgs e)
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

        private void celadminClick(object sender, MouseEventArgs e)
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

        private void faxadminClick(object sender, MouseEventArgs e)
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

        private void openre_Click(object sender, EventArgs e)
        {
            im.InitialDirectory = "C:\\";
            im.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            im.Title = "Abrir Imagen de Perfil";

            if (im.ShowDialog() == DialogResult.OK)
            {
                fotore.Text = "";
                fotore.ForeColor = SystemColors.WindowText;
                fotore.Font = new Font(fotore.Font, FontStyle.Regular);
                fotore.Text = im.FileName;
                //fotoCliente.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verboton_Click(object sender, EventArgs e)
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
                fotoadm.ImageLocation = im.FileName;
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

        private void corre_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(corre.Text))
            {

            }
            else
            {
                MessageBox.Show("Dirrección de Correo Electrónico No Valida. El Correo Debe Tener El Formato: nombre@dominio.com  Porfavor Seleccione un Correo Electroónico Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                corre.SelectAll();
                corre.Focus();
            }
        }

        private int comprobar() 
        {
            int cnt = 0;
            Conexion r = new Conexion();
            string buscar = "SELECT * FROM Usuario WHERE ciUser= '" + Convert.ToInt32(cire.Text) + "' ; ";
            try
            {
                r.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, r.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("ERROR. En el Comparador. "+ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }
            r.CerrarCnn();
            return cnt;
        }


        private void saveboton_Click(object sender, EventArgs e)
        {
            String fn = "" + dia.Text + " " + mes.Text + " " + anno.Text;
            String sex = sexmas.Text;
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
                            if (sexfem.Checked == true)
                            {
                                sex = sexfem.Text;                                                               
                                try
                                {   // Objetos de conexión y comando
                                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                                    // Estableciento propiedades
                                    cmd.Connection = c.GetCONN();
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
                                    fotoadm.Image.Save(mss, System.Drawing.Imaging.ImageFormat.Jpeg);

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

                                    c.OpenCnn();
                                    cmd.ExecuteNonQuery();
                                    c.CerrarCnn();

                                    Messengers mr = new Messengers();
                                    mr.textolb.Text = "Usuario Guardado";
                                    mr.ShowDialog();
                                    this.Close();
                                }
                                catch (Exception ex) { 
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
                                    fotoadm.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);

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

                                    c.OpenCnn();
                                    cmd.ExecuteNonQuery();
                                    c.CerrarCnn();

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
                else {
                    MessageBox.Show("Las contraseñas no son Iguales, Intente Nuevamente.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passre.Text = "";
                    confpasre.Text = "";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
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
            cargore.Text = "";
            cargore.ForeColor = SystemColors.WindowText;
            cargore.Font = new Font(cargore.Font, FontStyle.Regular);
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
        }

        private void RegAdmin_Load(object sender, EventArgs e)
        {
            sexmas.Checked = true;
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
                    depare.Items.Add(Scad);
                }
                r.CerrarCnn();
            }
            catch (Exception ex) { 
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }
        }

        private void depare_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion r = new Conexion();
            string query = "SELECT nombrePro, CodDep FROM Provincia, Departamento WHERE CodDep=codigoDep AND nombreDep= '" + depare.Text + "' ; ";
            
            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
            r.OpenCnn();
            SqlDataReader read;

            try {
                read = sqlQ.ExecuteReader();
                provre.Items.Clear();
                while(read.Read()){
                    String cade = read.GetString(0);
                    provre.Items.Add(cade);
                    id = read.GetString(1);
                }
                r.CerrarCnn();
            }              
            catch(Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }     
        }

        private void nameusrPress(object sender, KeyPressEventArgs e)
        {
            namere.ForeColor = SystemColors.WindowText;
            namere.Font = new Font(namere.Font, FontStyle.Regular);
        }

        private void pass1(object sender, KeyPressEventArgs e)
        {
            passre.ForeColor = SystemColors.WindowText;
            passre.Font = new Font(passre.Font, FontStyle.Regular);
        }

        private void pass2(object sender, KeyPressEventArgs e)
        {
            confpasre.ForeColor = SystemColors.WindowText;
            confpasre.Font = new Font(confpasre.Font, FontStyle.Regular);
        }

        private void dirpress(object sender, KeyPressEventArgs e)
        {
            dirre.ForeColor = SystemColors.WindowText;
            dirre.Font = new Font(dirre.Font, FontStyle.Regular);
        }

        private void fotoPress(object sender, KeyPressEventArgs e)
        {
            fotore.ForeColor = SystemColors.WindowText;
            fotore.Font = new Font(fotore.Font, FontStyle.Regular);
        }

        private void cargoPress(object sender, KeyPressEventArgs e)
        {
            cargore.ForeColor = SystemColors.WindowText;
            cargore.Font = new Font(cargore.Font, FontStyle.Regular);
        }

        private void correPress(object sender, KeyPressEventArgs e)
        {
            corre.ForeColor = SystemColors.WindowText;
            corre.Font = new Font(corre.Font, FontStyle.Regular);
        }



    }
}
