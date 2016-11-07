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
    public partial class EditUser : Form
    {
        Conexion cs = new Conexion();
        ValidacionText mn = new ValidacionText();
        OpenFileDialog im = new OpenFileDialog();
        String id = "3";

        public EditUser()
        {
            InitializeComponent();
            tooleduser.SetToolTip(ciedu, "Ingresar Carnet de Identidad del Usuario");
            tooleduser.SetToolTip(cius, "Carnet de Identidad del Usuario");
            tooleduser.SetToolTip(nomedus, "Identificador de Usuario");
            tooleduser.SetToolTip(apelus, "Apellidos del Usuario");
            tooleduser.SetToolTip(nameus, "Nombres del Usuario");
            tooleduser.SetToolTip(passedus, "Contraseña de Usuario");
            tooleduser.SetToolTip(confpass, "Repetir su misma Contraseña");
            tooleduser.SetToolTip(diredu, "Dirección del Usuario");
            tooleduser.SetToolTip(provedu, "Provincia donde vive el Usuario");
            tooleduser.SetToolTip(depaedu, "Departamento donde vive el Usuario");
            tooleduser.SetToolTip(fotous, "Ubicación de la Fotografía del Usuario");
            tooleduser.SetToolTip(nivelesus, "Nivel de Estudios que Presenta el Usuario");
            tooleduser.SetToolTip(cargoedus, "Cargo de Ocupación de Trabajo con la Empresa");
            tooleduser.SetToolTip(dia, "Dia");
            tooleduser.SetToolTip(mes, "Mes");
            tooleduser.SetToolTip(anno, "Año");
            tooleduser.SetToolTip(corredu, "Correo Electronico del Usuario");
            tooleduser.SetToolTip(teledu, "Teléfono del Usuario");
            tooleduser.SetToolTip(celedu, "Celular del Usuario");
            tooleduser.SetToolTip(faxedu,"Fax del Usuario");
            tooleduser.SetToolTip(openboton, "Abrir");
            tooleduser.SetToolTip(verboton, "Ver Fotografía del Usuario");
            tooleduser.SetToolTip(saveboton, "Guardar");
            tooleduser.SetToolTip(salirboton, "Salir");
            tooleduser.SetToolTip(buscarboton, "Buscar");
            tooleduser.SetToolTip(regboton, "Registro de Usuarios");
            
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
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
                    depaedu.Items.Add(Scad);
                }
                s.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                s.CerrarCnn();
            }
        }

        private void busqueda(object sender, KeyPressEventArgs e)
        {
            ciedu.ForeColor = SystemColors.WindowText;
            ciedu.Font = new Font(ciedu.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void ciUser(object sender, KeyPressEventArgs e)
        {
            cius.ForeColor = SystemColors.WindowText;
            cius.Font = new Font(cius.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void telUser(object sender, KeyPressEventArgs e)
        {
            teledu.ForeColor = SystemColors.WindowText;
            teledu.Font = new Font(teledu.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void celUser(object sender, KeyPressEventArgs e)
        {
            celedu.ForeColor = SystemColors.WindowText;
            celedu.Font = new Font(celedu.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void faxUser(object sender, KeyPressEventArgs e)
        {
            faxedu.ForeColor = SystemColors.WindowText;
            faxedu.Font = new Font(faxedu.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void nomUser(object sender, KeyPressEventArgs e)
        {
            nameus.ForeColor = SystemColors.WindowText;
            nameus.Font = new Font(nameus.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void apeUser(object sender, KeyPressEventArgs e)
        {
            apelus.ForeColor = SystemColors.WindowText;
            apelus.Font = new Font(apelus.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void cargoUser(object sender, KeyPressEventArgs e)
        {
            cargoedus.ForeColor = SystemColors.WindowText;
            cargoedus.Font = new Font(cargoedus.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Esta Seguro que Desea Cancelar la Modificación del Usuario?";
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

        private void ciedubusClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (ciedu.Text != "" && ciedu.Font.Italic == true)
                {
                    ciedu.Text = "";
                    ciedu.ForeColor = SystemColors.WindowText;
                    ciedu.Font = new Font(ciedu.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;
                }
                else
                {
                    ciedu.ForeColor = SystemColors.WindowText;
                    ciedu.Font = new Font(ciedu.Font, FontStyle.Regular);
                }
            }
        }

        private void cieduClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (cius.Text != "" && cius.Font.Italic == true)
                {
                    cius.Text = "";
                    cius.ForeColor = SystemColors.WindowText;
                    cius.Font = new Font(cius.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;
                }
                else
                {
                    cius.ForeColor = SystemColors.WindowText;
                    cius.Font = new Font(cius.Font, FontStyle.Regular);
                }
            }
        }

        private void nomedusClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nameus.Text != "" && nameus.Font.Italic == true)
                {
                    nameus.Text = "";
                    nameus.ForeColor = SystemColors.WindowText;
                    nameus.Font = new Font(nameus.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;
                }
                else
                {
                    nameus.ForeColor = SystemColors.WindowText;
                    nameus.Font = new Font(nameus.Font, FontStyle.Regular);
                }
            }
        }

        private void apeledusClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (apelus.Text != "" && apelus.Font.Italic == true)
                {
                    apelus.Text = "";
                    apelus.ForeColor = SystemColors.WindowText;
                    apelus.Font = new Font(apelus.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;
                }
                else
                {
                    apelus.ForeColor = SystemColors.WindowText;
                    apelus.Font = new Font(apelus.Font, FontStyle.Regular);
                }
            }
        }

        private void nameedusClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nomedus.Text != "" && nomedus.Font.Italic == true)
                {
                    nomedus.Text = "";
                    nomedus.ForeColor = SystemColors.WindowText;
                    nomedus.Font = new Font(nomedus.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;
                }
                else
                {
                    nomedus.ForeColor = SystemColors.WindowText;
                    nomedus.Font = new Font(nomedus.Font, FontStyle.Regular);
                }
            }
        }

        private void diredusClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (diredu.Text != "" && diredu.Font.Italic == true)
                {
                    diredu.Text = "";
                    diredu.ForeColor = SystemColors.WindowText;
                    diredu.Font = new Font(diredu.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;
                }
                else
                {
                    diredu.ForeColor = SystemColors.WindowText;
                    diredu.Font = new Font(diredu.Font, FontStyle.Regular);
                }
            }
        }

        private void fotoedusClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (fotous.Text != "" && fotous.Font.Italic == true)
                {
                    fotous.Text = "";
                    fotous.ForeColor = SystemColors.WindowText;
                    fotous.Font = new Font(fotous.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;
                }
                else
                {
                    fotous.ForeColor = SystemColors.WindowText;
                    fotous.Font = new Font(fotous.Font, FontStyle.Regular);
                }
            }
        }

        private void cargoedusClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (cargoedus.Text != "" && cargoedus.Font.Italic == true)
                {
                    cargoedus.Text = "";
                    cargoedus.ForeColor = SystemColors.WindowText;
                    cargoedus.Font = new Font(cargoedus.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;
                }
                else
                {
                    cargoedus.ForeColor = SystemColors.WindowText;
                    cargoedus.Font = new Font(cargoedus.Font, FontStyle.Regular);
                }
            }
        }

        private void correoedusClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (corredu.Text != "" && corredu.Font.Italic == true)
                {
                    corredu.Text = "";
                    corredu.ForeColor = SystemColors.WindowText;
                    corredu.Font = new Font(corredu.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;
                }
                else
                {
                    corredu.ForeColor = SystemColors.WindowText;
                    corredu.Font = new Font(corredu.Font, FontStyle.Regular);
                }
            }
        }

        private void teledusClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (teledu.Text != "" && teledu.Font.Italic == true)
                {
                    teledu.Text = "";
                    teledu.ForeColor = SystemColors.WindowText;
                    teledu.Font = new Font(teledu.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;
                }
                else
                {
                    teledu.ForeColor = SystemColors.WindowText;
                    teledu.Font = new Font(teledu.Font, FontStyle.Regular);
                }
            }
        }

        private void celedusClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (celedu.Text != "" && celedu.Font.Italic == true)
                {
                    celedu.Text = "";
                    celedu.ForeColor = SystemColors.WindowText;
                    celedu.Font = new Font(celedu.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;
                }
                else
                {
                    celedu.ForeColor = SystemColors.WindowText;
                    celedu.Font = new Font(celedu.Font, FontStyle.Regular);
                }
            }
        }

        private void faxedusClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (faxedu.Text != "" && faxedu.Font.Italic == true)
                {
                    faxedu.Text = "";
                    faxedu.ForeColor = SystemColors.WindowText;
                    faxedu.Font = new Font(faxedu.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;
                }
                else
                {
                    faxedu.ForeColor = SystemColors.WindowText;
                    faxedu.Font = new Font(faxedu.Font, FontStyle.Regular);
                }
            }
        }

        public String GetDepa(String value)
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

        private void buscarboton_Click(object sender, EventArgs e)
        {
            Conexion f = new Conexion();
            if (ciedu.Text != "" && ciedu.Font.Italic == true)
            {
                if (ciedu.Text == "")
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
            else if (ciedu.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de buscar Usuario.  
                string query = "SELECT * FROM Usuario WHERE ciUser ='" + Convert.ToInt32(ciedu.Text) + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, f.GetCONN());
                SqlDataReader read;
                if (comprobar() == 1)
                {
                    cius.Text = "";
                    cius.ForeColor = SystemColors.WindowText;
                    cius.Font = new Font(cius.Font, FontStyle.Regular);
                    nameus.Text = "";
                    nameus.ForeColor = SystemColors.WindowText;
                    nameus.Font = new Font(nameus.Font, FontStyle.Regular);
                    apelus.Text = "";
                    apelus.ForeColor = SystemColors.WindowText;
                    apelus.Font = new Font(apelus.Font, FontStyle.Regular);
                    nomedus.Text = "";
                    nomedus.ForeColor = SystemColors.WindowText;
                    nomedus.Font = new Font(nomedus.Font, FontStyle.Regular);
                    fotous.Text = "";
                    fotous.ForeColor = SystemColors.WindowText;
                    fotous.Font = new Font(fotous.Font, FontStyle.Regular);
                    corredu.Text = "";
                    corredu.ForeColor = SystemColors.WindowText;
                    corredu.Font = new Font(corredu.Font, FontStyle.Regular);
                    cargoedus.Text = "";
                    cargoedus.ForeColor = SystemColors.WindowText;
                    cargoedus.Font = new Font(cargoedus.Font, FontStyle.Regular);
                    teledu.Text = "";
                    teledu.ForeColor = SystemColors.WindowText;
                    teledu.Font = new Font(teledu.Font, FontStyle.Regular);
                    celedu.Text = "";
                    celedu.ForeColor = SystemColors.WindowText;
                    celedu.Font = new Font(celedu.Font, FontStyle.Regular);
                    faxedu.Text = "";
                    faxedu.ForeColor = SystemColors.WindowText;
                    faxedu.Font = new Font(faxedu.Font, FontStyle.Regular);
                    diredu.Text = "";
                    diredu.ForeColor = SystemColors.WindowText;
                    diredu.Font = new Font(diredu.Font, FontStyle.Regular);

                    try
                    {
                        f.OpenCnn();
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            cius.Text = read.GetInt32(0).ToString();
                            nameus.Text = read.GetString(1);
                            apelus.Text = read.GetString(2);
                            nomedus.Text = read.GetString(3);
                            passedus.Text = read.GetString(4);
                            confpass.Text = read.GetString(4);
                            diredu.Text = read.GetString(5);
                            cargoedus.Text = read.GetString(7);
                            corredu.Text = read.GetString(14);
                            teledu.Text = read.GetInt32(10).ToString();
                            celedu.Text = read.GetInt32(11).ToString();
                            faxedu.Text = read.GetInt32(12).ToString();
                            dia.SelectedItem = read.GetString(9).Substring(0, 2);
                            mes.SelectedItem = read.GetString(9).Substring(3, 2);
                            anno.SelectedItem = read.GetString(9).Substring(6, 4);
                            nivelesus.SelectedItem = read.GetString(6);
                            depaedu.SelectedItem = GetDepa(read.GetString(16));

                            // El campo productImage primero se almacena en un buffer
                            byte[] imageBuffer = (byte[])(read[13]);
                            // Se crea un MemoryStream a partir de ese buffer                        

                            if (imageBuffer == null || read[13] == null)
                            {
                                fotoUser.Image = null;
                            }
                            else
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                                fotoUser.Image = Image.FromStream(ms);
                            }

                            if (read.GetString(8) == "Masculino")
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
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, El Usuario Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);                  
                }

            }
        }

        private void openboton_Click(object sender, EventArgs e)
        {
            im.InitialDirectory = "C:\\";
            im.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            im.Title = "Abrir Imagen de Perfil";

            if (im.ShowDialog() == DialogResult.OK)
            {
                fotous.Text = "";
                fotous.ForeColor = SystemColors.WindowText;
                fotous.Font = new Font(fotous.Font, FontStyle.Regular);
                fotous.Text = im.FileName;
                //fotoCliente.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verboton_Click(object sender, EventArgs e)
        {
            if (fotous.Text != "" && fotous.Font.Italic == true)
            {
                if (fotous.Text == "")
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (fotous.Text == "")
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta o Escriba la Dirección de la Imagen.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fotoUser.ImageLocation = im.FileName;
            }
        }

        private void regboton_Click(object sender, EventArgs e)
        {
            Registro_Usuario rc = new Registro_Usuario();
            rc.nuevo.Enabled = false;
            rc.nuevo.BackgroundImage = global::Proyect_Kardex.Properties.Resources.novob;
            rc.editar.Enabled = false;
            rc.editar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editdocumentob;
            rc.eliminar.Enabled = false;
            rc.eliminar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_deleteb;
            rc.ShowDialog();
            ciedu.Text = "";
            ciedu.ForeColor = SystemColors.WindowText;
            ciedu.Font = new Font(ciedu.Font, FontStyle.Regular);
            ciedu.Text = rc.codUser.ToString(); 
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

        private void corredu_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(corredu.Text))
            {

            }
            else
            {
                MessageBox.Show("Dirrección de Correo Electrónico No Valida. El Correo Debe Tener El Formato: nombre@dominio.com  Porfavor Seleccione un Correo Electroónico Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                corredu.SelectAll();
                corredu.Focus();
            }
        }

        private void nomedus_KeyPress(object sender, KeyPressEventArgs e)
        {
            nomedus.ForeColor = SystemColors.WindowText;
            nomedus.Font = new Font(nomedus.Font, FontStyle.Regular);
        }

        private void diredu_KeyPress(object sender, KeyPressEventArgs e)
        {
            diredu.ForeColor = SystemColors.WindowText;
            diredu.Font = new Font(diredu.Font, FontStyle.Regular);
        }

        private void fotous_KeyPress(object sender, KeyPressEventArgs e)
        {
            fotous.ForeColor = SystemColors.WindowText;
            fotous.Font = new Font(fotous.Font, FontStyle.Regular);
        }

        private void corredu_KeyPress(object sender, KeyPressEventArgs e)
        {
            corredu.ForeColor = SystemColors.WindowText;
            corredu.Font = new Font(corredu.Font, FontStyle.Regular);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ciedu.Text = "";
            ciedu.ForeColor = SystemColors.WindowText;
            ciedu.Font = new Font(ciedu.Font, FontStyle.Regular);
            cius.Text = "";
            cius.ForeColor = SystemColors.WindowText;
            cius.Font = new Font(cius.Font, FontStyle.Regular);
            nameus.Text = "";
            nameus.ForeColor = SystemColors.WindowText;
            nameus.Font = new Font(nameus.Font, FontStyle.Regular);
            apelus.Text = "";
            apelus.ForeColor = SystemColors.WindowText;
            apelus.Font = new Font(apelus.Font, FontStyle.Regular);
            nomedus.Text = "";
            nomedus.ForeColor = SystemColors.WindowText;
            nomedus.Font = new Font(nomedus.Font, FontStyle.Regular);
            fotous.Text = "";
            fotous.ForeColor = SystemColors.WindowText;
            fotous.Font = new Font(fotous.Font, FontStyle.Regular);
            corredu.Text = "";
            corredu.ForeColor = SystemColors.WindowText;
            corredu.Font = new Font(corredu.Font, FontStyle.Regular);
            cargoedus.Text = "";
            cargoedus.ForeColor = SystemColors.WindowText;
            cargoedus.Font = new Font(cargoedus.Font, FontStyle.Regular);
            teledu.Text = "";
            teledu.ForeColor = SystemColors.WindowText;
            teledu.Font = new Font(teledu.Font, FontStyle.Regular);
            celedu.Text = "";
            celedu.ForeColor = SystemColors.WindowText;
            celedu.Font = new Font(celedu.Font, FontStyle.Regular);
            faxedu.Text = "";
            faxedu.ForeColor = SystemColors.WindowText;
            faxedu.Font = new Font(faxedu.Font, FontStyle.Regular);
            diredu.Text = "";
            diredu.ForeColor = SystemColors.WindowText;
            diredu.Font = new Font(diredu.Font, FontStyle.Regular);
            passedus.Text = "";
            passedus.ForeColor = SystemColors.WindowText;
            passedus.Font = new Font(passedus.Font, FontStyle.Regular);
            confpass.Text = "";
            confpass.ForeColor = SystemColors.WindowText;
            confpass.Font = new Font(confpass.Font, FontStyle.Regular);

        }

        private void depaedu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion f = new Conexion();
            string query = "SELECT nombrePro, CodDep FROM Provincia, Departamento WHERE CodDep=codigoDep AND nombreDep= '" + depaedu.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, f.GetCONN());
            SqlDataReader read;

            try
            {
                f.OpenCnn();
                read = sqlQ.ExecuteReader();
                provedu.Items.Clear();
                while (read.Read())
                {
                    String cade = read.GetString(0);
                    provedu.Items.Add(cade);
                    id = read.GetString(1);
                }
                f.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.ToString() + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f.CerrarCnn();
            }  
        }

        private int comprobar()
        {
            int cnt = 0;
            Conexion g = new Conexion();
            string buscar = "SELECT * FROM Usuario WHERE ciUser= '" + Convert.ToInt32(ciedu.Text) + "' ; ";

            try
            {
                g.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, g.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            g.CerrarCnn();
            return cnt;
        }

        private void saveboton_Click(object sender, EventArgs e)
        {
            String fn = dia.Text + "" + mes.Text + "" + anno.Text;
            String sex = sexMax.Text;
            int idusr = 2;

            if (ciedu.Text != "" && ciedu.Font.Italic == true)
            {
                if (ciedu.Text == "")
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
            else if (ciedu.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Usuario a Modificar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nameus.Text == "" || nameus.Font.Italic == true)
            {
                MessageBox.Show("Ingrese el nombre de Identidad del Usuario a Modificar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passedus.Text == "" || passedus.Font.Italic == true)
            {
                MessageBox.Show("Ingrese la Contraseña del Usuario a Modificar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de editar Cliente.
                if (comprobar() == 1)
                {
                    if (passedus.Text == confpass.Text)
                    {
                        if (sexFem.Checked == true)
                        {
                            sex = sexFem.Text;
                            try
                            {   // Objetos de conexión y comando
                                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                                // Asignando el valor de la imagen
                                // Stream usado como buffer
                                System.IO.MemoryStream mss = new System.IO.MemoryStream();
                                // Se guarda la imagen en el buffer
                                fotoUser.Image.Save(mss, System.Drawing.Imaging.ImageFormat.Jpeg);

                                // Estableciento propiedades
                                cmd.Connection = cs.GetCONN();
                                cmd.CommandText = "UPDATE Usuario SET ciUser=@ci, nombreUser=@nom, apeUser=@ape, nuUsuario=@name, contraUser=@pass, dirUser=@dir, nivelUser=@nivel, cargoUser=@cargo, sexoUser=@sexo, fechaNaci=@fecha, telUser=@tel, celUser=@cel, faxUser=@fax, fotoUser= @imagen, emailUser=@email, idUser=@iduser, CodDepaU=@codd  WHERE ciUser = @ciid ;";

                                cmd.Parameters.Add("@ci", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@pass", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@dir", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@nivel", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@cargo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@fecha", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@tel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@cel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@fax", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@imagen", System.Data.SqlDbType.Image);
                                cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@iduser", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@ciid", System.Data.SqlDbType.Int);

                                // Asignando los valores a los atributos
                                cmd.Parameters["@ci"].Value = int.Parse(cius.Text);
                                cmd.Parameters["@nom"].Value = nameus.Text;
                                cmd.Parameters["@ape"].Value = apelus.Text;
                                cmd.Parameters["@name"].Value = nomedus.Text;
                                cmd.Parameters["@pass"].Value = passedus.Text;
                                cmd.Parameters["@dir"].Value = diredu.Text;
                                cmd.Parameters["@nivel"].Value = nivelesus.Text;
                                cmd.Parameters["@cargo"].Value = cargoedus.Text;
                                cmd.Parameters["@sexo"].Value = sex;
                                cmd.Parameters["@fecha"].Value = fn;
                                cmd.Parameters["@tel"].Value = int.Parse(teledu.Text);
                                cmd.Parameters["@cel"].Value = int.Parse(celedu.Text);
                                cmd.Parameters["@fax"].Value = int.Parse(faxedu.Text);
                                cmd.Parameters["@imagen"].Value = mss.GetBuffer();
                                cmd.Parameters["@email"].Value = corredu.Text;
                                cmd.Parameters["@iduser"].Value = idusr;
                                cmd.Parameters["@codd"].Value = id;
                                cmd.Parameters["@ciid"].Value = int.Parse(ciedu.Text);

                                cs.OpenCnn();
                                cmd.ExecuteNonQuery();
                                cs.CerrarCnn();

                                Messengers mr = new Messengers();
                                mr.textolb.Text = "Usuario Modificado";
                                mr.ShowDialog();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR. Al Modificar Los Datos. \n" + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con el Usuario a Modificar.", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            try
                            {   // Objetos de conexión y comando
                                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                                System.IO.MemoryStream mss = new System.IO.MemoryStream();
                                fotoUser.Image.Save(mss, System.Drawing.Imaging.ImageFormat.Jpeg);

                                // Estableciento propiedades
                                cmd.Connection = cs.GetCONN();
                                cmd.CommandText = "UPDATE Usuario SET ciUser=@ci, nombreUser=@nom, apeUser=@ape, nuUsuario=@name, contraUser=@pass, dirUser=@dir, nivelUser=@nivel, cargoUser=@cargo, sexoUser=@sexo, fechaNaci=@fecha, telUser=@tel, celUser=@cel, faxUser=@fax, fotoUser= @imagen, emailUser=@email, idUser=@iduser, CodDepaU=@codd  WHERE ciUser = @ciid ;";

                                cmd.Parameters.Add("@ci", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@pass", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@dir", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@nivel", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@cargo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@fecha", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@tel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@cel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@fax", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@imagen", System.Data.SqlDbType.Image);
                                cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@iduser", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@ciid", System.Data.SqlDbType.Int);

                                // Asignando los valores a los atributos
                                cmd.Parameters["@ci"].Value = int.Parse(cius.Text);
                                cmd.Parameters["@nom"].Value = nameus.Text;
                                cmd.Parameters["@ape"].Value = apelus.Text;
                                cmd.Parameters["@name"].Value = nomedus.Text;
                                cmd.Parameters["@pass"].Value = passedus.Text;
                                cmd.Parameters["@dir"].Value = diredu.Text;
                                cmd.Parameters["@nivel"].Value = nivelesus.Text;
                                cmd.Parameters["@cargo"].Value = cargoedus.Text;
                                cmd.Parameters["@sexo"].Value = sex;
                                cmd.Parameters["@fecha"].Value = fn;
                                cmd.Parameters["@tel"].Value = int.Parse(teledu.Text);
                                cmd.Parameters["@cel"].Value = int.Parse(celedu.Text);
                                cmd.Parameters["@fax"].Value = int.Parse(faxedu.Text);
                                cmd.Parameters["@imagen"].Value = mss.GetBuffer();
                                cmd.Parameters["@email"].Value = corredu.Text;
                                cmd.Parameters["@iduser"].Value = idusr;
                                cmd.Parameters["@codd"].Value = id;
                                cmd.Parameters["@ciid"].Value = int.Parse(ciedu.Text);

                                cs.OpenCnn();
                                cmd.ExecuteNonQuery();
                                cs.CerrarCnn();

                                Messengers mr = new Messengers();
                                mr.textolb.Text = "Usuario Modificado";
                                mr.ShowDialog();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR. Al Modificar Los Datos. " + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con el Usuario a Modificar.", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, Debe Confirmar que las Contraseñas sean Iguales.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, No Existen Registros del Usuario.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //string text = passedus.Text;
          //  passedus.UseSystemPasswordChar = true;
            //passedus.Text = text;
        }


    }
}
