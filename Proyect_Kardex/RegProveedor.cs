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
    public partial class RegProveedor : Form
    {
        ValidacionText mn = new ValidacionText();
        OpenFileDialog ima = new OpenFileDialog();
        Conexion cs = new Conexion();
        String id = "3";

        public RegProveedor()
        {
            InitializeComponent();

            toolregpro.SetToolTip(codrep, "Código de Registro, Número de Diez Dígitos");
            toolregpro.SetToolTip(genboton, "Generar Código de Registro");
            toolregpro.SetToolTip(ciduep, "Carnet de Identidad del Supervisor de la Empresa");
            toolregpro.SetToolTip(nombduep, "Nombres del Supervisor de la Empresa");
            toolregpro.SetToolTip(apeduep, "Apellidos del Supervisor de la Empresa");
            toolregpro.SetToolTip(dia, "Dia");
            toolregpro.SetToolTip(mes,"Mes");
            toolregpro.SetToolTip(anno, "Año");
            toolregpro.SetToolTip(telduep, "Teléfono del Supervisor de la Empresa");
            toolregpro.SetToolTip(celduep, "Celular del Supervisor de la Empresa");
            toolregpro.SetToolTip(correp, "Correo Electrónico de la Empresa");
            toolregpro.SetToolTip(webrep, "Página Web de la Empresa");
            toolregpro.SetToolTip(direp, "Dirección de la Empresa");
            toolregpro.SetToolTip(deparep, "Departamento donde se Ubica la Empresa");
            toolregpro.SetToolTip(provrep, "Provincia donde se Ubica la Empresa");
            toolregpro.SetToolTip(pagorep, "Forma de Pago al Proveedor");
            toolregpro.SetToolTip(starep, "Estado de Identificación al Proveedor");
            toolregpro.SetToolTip(nitempp, "Número de NIT de la Empresa");
            toolregpro.SetToolTip(namerep, "Nombre de la Empresa");
            toolregpro.SetToolTip(telrep, "Teléfono Local de la Empresa");
            toolregpro.SetToolTip(celrep, "Celular de la Empresa");
            toolregpro.SetToolTip(faxrep, "Fax de la Empresa");
            toolregpro.SetToolTip(logorep, "Ubicación del Logotipo de la Empresa");
            toolregpro.SetToolTip(openboton, "Abrir");
            toolregpro.SetToolTip(fecharep, "Fecha de Hoy");
            toolregpro.SetToolTip(verboton, "Ver Logotipo");
            toolregpro.SetToolTip(saveboton, "Guardar");
            toolregpro.SetToolTip(salirboton, "Salir");
            
        }

        private void codreg(object sender, KeyPressEventArgs e)
        {
            codrep.ForeColor = SystemColors.WindowText;
            codrep.Font = new Font(codrep.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ciduep.ForeColor = SystemColors.WindowText;
            ciduep.Font = new Font(ciduep.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void nitemp(object sender, KeyPressEventArgs e)
        {
            nitempp.ForeColor = SystemColors.WindowText;
            nitempp.Font = new Font(nitempp.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void telemp(object sender, KeyPressEventArgs e)
        {
            telrep.ForeColor = SystemColors.WindowText;
            telrep.Font = new Font(telrep.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void celemp(object sender, KeyPressEventArgs e)
        {
            celrep.ForeColor = SystemColors.WindowText;
            celrep.Font = new Font(celrep.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void faxemp(object sender, KeyPressEventArgs e)
        {
            faxrep.ForeColor = SystemColors.WindowText;
            faxrep.Font = new Font(faxrep.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void teldue(object sender, KeyPressEventArgs e)
        {
            telduep.ForeColor = SystemColors.WindowText;
            telduep.Font = new Font(telduep.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void celdue(object sender, KeyPressEventArgs e)
        {
            celduep.ForeColor = SystemColors.WindowText;
            celduep.Font = new Font(celduep.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void nomdue(object sender, KeyPressEventArgs e)
        {
            nombduep.ForeColor = SystemColors.WindowText;
            nombduep.Font = new Font(nombduep.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void apedue(object sender, KeyPressEventArgs e)
        {
            apeduep.ForeColor = SystemColors.WindowText;
            apeduep.Font = new Font(apeduep.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openboton_Click(object sender, EventArgs e)
        {
            ima.InitialDirectory = "C:\\";
            ima.Filter = "PNG Imagen (*.png)|*.png";
            ima.Title = "Abrir Logotipo de Empresa";

            if (ima.ShowDialog() == DialogResult.OK)
            {
                logorep.Text = "";
                logorep.ForeColor = SystemColors.WindowText;
                logorep.Font = new Font(logorep.Font, FontStyle.Regular);
                logorep.Text = ima.FileName;
                //fotoCliente.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verboton_Click(object sender, EventArgs e)
        {
            if (logorep.Text != "" && logorep.Font.Italic == true)
            {
                if (logorep.Text == "")
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (logorep.Text == "")
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta o Escriba la Dirección de la Imagen.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                logoview.ImageLocation = ima.FileName;
            }
        }

        private void genboton_Click(object sender, EventArgs e)
        {
            Random ra = new Random();
            int puro = new int();

            if (codrep.Font.Italic == true)
            {
                MessageBox.Show("Debe pulsar con un Click en el campo del Codigo de Registro para Proveedores.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                puro = ra.Next(1, 999999999);
            }
            codrep.Text = "" + puro;
        }

        private void codrepClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (codrep.Text != "" && codrep.Font.Italic == true)
                {
                    codrep.Text = "";
                    codrep.ForeColor = SystemColors.WindowText;
                    codrep.Font = new Font(codrep.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    codrep.ForeColor = SystemColors.WindowText;
                    codrep.Font = new Font(codrep.Font, FontStyle.Regular);
                }
            }
        }

        private void cisuregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (ciduep.Text != "" && ciduep.Font.Italic == true)
                {
                    ciduep.Text = "";
                    ciduep.ForeColor = SystemColors.WindowText;
                    ciduep.Font = new Font(ciduep.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    ciduep.ForeColor = SystemColors.WindowText;
                    ciduep.Font = new Font(ciduep.Font, FontStyle.Regular);
                }
            }
        }

        private void namesuregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nombduep.Text != "" && nombduep.Font.Italic == true)
                {
                    nombduep.Text = "";
                    nombduep.ForeColor = SystemColors.WindowText;
                    nombduep.Font = new Font(nombduep.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nombduep.ForeColor = SystemColors.WindowText;
                    nombduep.Font = new Font(nombduep.Font, FontStyle.Regular);
                }
            }
        }

        private void apesuregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (apeduep.Text != "" && apeduep.Font.Italic == true)
                {
                    apeduep.Text = "";
                    apeduep.ForeColor = SystemColors.WindowText;
                    apeduep.Font = new Font(apeduep.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    apeduep.ForeColor = SystemColors.WindowText;
                    apeduep.Font = new Font(apeduep.Font, FontStyle.Regular);
                }
            }
        }

        private void telsuregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (telduep.Text != "" && telduep.Font.Italic == true)
                {
                    telduep.Text = "";
                    telduep.ForeColor = SystemColors.WindowText;
                    telduep.Font = new Font(telduep.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    telduep.ForeColor = SystemColors.WindowText;
                    telduep.Font = new Font(telduep.Font, FontStyle.Regular);
                }
            }
        }

        private void celsuregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (celduep.Text != "" && celduep.Font.Italic == true)
                {
                    celduep.Text = "";
                    celduep.ForeColor = SystemColors.WindowText;
                    celduep.Font = new Font(celduep.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    celduep.ForeColor = SystemColors.WindowText;
                    celduep.Font = new Font(celduep.Font, FontStyle.Regular);
                }
            }
        }

        private void corempregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (correp.Text != "" && correp.Font.Italic == true)
                {
                    correp.Text = "";
                    correp.ForeColor = SystemColors.WindowText;
                    correp.Font = new Font(correp.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    correp.ForeColor = SystemColors.WindowText;
                    correp.Font = new Font(correp.Font, FontStyle.Regular);
                }
            }
        }

        private void webempregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (webrep.Text != "" && webrep.Font.Italic == true)
                {
                    webrep.Text = "";
                    webrep.ForeColor = SystemColors.WindowText;
                    webrep.Font = new Font(webrep.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    webrep.ForeColor = SystemColors.WindowText;
                    webrep.Font = new Font(webrep.Font, FontStyle.Regular);
                }
            }
        }

        private void dirempregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (direp.Text != "" && direp.Font.Italic == true)
                {
                    direp.Text = "";
                    direp.ForeColor = SystemColors.WindowText;
                    direp.Font = new Font(direp.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    direp.ForeColor = SystemColors.WindowText;
                    direp.Font = new Font(direp.Font, FontStyle.Regular);
                }
            }
        }

        private void nitempregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nitempp.Text != "" && nitempp.Font.Italic == true)
                {
                    nitempp.Text = "";
                    nitempp.ForeColor = SystemColors.WindowText;
                    nitempp.Font = new Font(nitempp.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nitempp.ForeColor = SystemColors.WindowText;
                    nitempp.Font = new Font(nitempp.Font, FontStyle.Regular);
                }
            }
        }

        private void nameempregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (namerep.Text != "" && namerep.Font.Italic == true)
                {
                    namerep.Text = "";
                    namerep.ForeColor = SystemColors.WindowText;
                    namerep.Font = new Font(namerep.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    namerep.ForeColor = SystemColors.WindowText;
                    namerep.Font = new Font(namerep.Font, FontStyle.Regular);
                }
            }
        }

        private void telempregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (telrep.Text != "" && telrep.Font.Italic == true)
                {
                    telrep.Text = "";
                    telrep.ForeColor = SystemColors.WindowText;
                    telrep.Font = new Font(telrep.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    telrep.ForeColor = SystemColors.WindowText;
                    telrep.Font = new Font(telrep.Font, FontStyle.Regular);
                }
            }
        }

        private void celempregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (celrep.Text != "" && celrep.Font.Italic == true)
                {
                    celrep.Text = "";
                    celrep.ForeColor = SystemColors.WindowText;
                    celrep.Font = new Font(celrep.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    celrep.ForeColor = SystemColors.WindowText;
                    celrep.Font = new Font(celrep.Font, FontStyle.Regular);
                }
            }
        }

        private void faxempregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (faxrep.Text != "" && faxrep.Font.Italic == true)
                {
                    faxrep.Text = "";
                    faxrep.ForeColor = SystemColors.WindowText;
                    faxrep.Font = new Font(faxrep.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    faxrep.ForeColor = SystemColors.WindowText;
                    faxrep.Font = new Font(faxrep.Font, FontStyle.Regular);
                }
            }
        }

        private void logoempregClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (logorep.Text != "" && logorep.Font.Italic == true)
                {
                    logorep.Text = "";
                    logorep.ForeColor = SystemColors.WindowText;
                    logorep.Font = new Font(logorep.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    logorep.ForeColor = SystemColors.WindowText;
                    logorep.Font = new Font(logorep.Font, FontStyle.Regular);
                }
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

        private void correp_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(correp.Text))
            {

            }
            else
            {
                MessageBox.Show("Dirrección de Correo Electrónico No Valida. El Correo Debe Tener El Formato: nombre@dominio.com  Porfavor Seleccione un Correo Electroónico Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                correp.SelectAll();
                correp.Focus();
            }
        }

        private void weboton_Click(object sender, EventArgs e)
        {
            if (webrep.Text != "" && webrep.Font.Italic == true)
            {
                if (webrep.Text == "")
                {
                    MessageBox.Show("Ingrese la Dirección de la Pagina Web del Proveedor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese la Dirección de la Pagina Web del Proveedor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (webrep.Text == "")
            {
                MessageBox.Show("Ingrese la Dirección de la Pagina Web del Proveedor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                REV_WebStudio we = new REV_WebStudio();
                we.texturlweb.Text = webrep.Text;
                we.webBrow.Navigate(webrep.Text);
                we.ShowDialog();
            }
        }

        private void apeduep_TextChanged(object sender, EventArgs e)
        {
            apeduep.ForeColor = SystemColors.WindowText;
            apeduep.Font = new Font(apeduep.Font, FontStyle.Regular);           
        }

        private void correp_KeyPress(object sender, KeyPressEventArgs e)
        {
            correp.ForeColor = SystemColors.WindowText;
            correp.Font = new Font(correp.Font, FontStyle.Regular);
        }

        private void webrep_KeyPress(object sender, KeyPressEventArgs e)
        {
            webrep.ForeColor = SystemColors.WindowText;
            webrep.Font = new Font(webrep.Font, FontStyle.Regular);
        }

        private void direp_KeyPress(object sender, KeyPressEventArgs e)
        {
            direp.ForeColor = SystemColors.WindowText;
            direp.Font = new Font(direp.Font, FontStyle.Regular);
        }

        private void namerep_KeyPress(object sender, KeyPressEventArgs e)
        {
            namerep.ForeColor = SystemColors.WindowText;
            namerep.Font = new Font(namerep.Font, FontStyle.Regular);
        }

        private void logorep_KeyPress(object sender, KeyPressEventArgs e)
        {
            logorep.ForeColor = SystemColors.WindowText;
            logorep.Font = new Font(logorep.Font, FontStyle.Regular);
        }

        private void RegProveedor_Load(object sender, EventArgs e)
        {
            Conexion w = new Conexion();
            string query = "SELECT * FROM Departamento; ";

            SqlCommand sqlQ = new SqlCommand(query, w.GetCONN());
            w.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(1);
                    deparep.Items.Add(Scad);
                }
                w.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                w.CerrarCnn();
            }
        }

        private void deparep_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion w = new Conexion();
            string query = "SELECT nombrePro, CodDep FROM Provincia, Departamento WHERE CodDep=codigoDep AND nombreDep= '" + deparep.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, w.GetCONN());
            SqlDataReader read;

            try
            {
                w.OpenCnn();
                read = sqlQ.ExecuteReader();
                provrep.Items.Clear();
                while (read.Read())
                {
                    String cade = read.GetString(0);
                    provrep.Items.Add(cade);
                    id = read.GetString(1);
                }
                w.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                w.CerrarCnn();
            }   
        }

        private int comprobar()
        {
            int cnt = 0;
            Conexion w = new Conexion();
            string buscar = "SELECT * FROM Clientes WHERE idCliente= '" + Convert.ToInt32(codrep.Text) + "' ; ";

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
            catch (Exception ex) 
            { 
                MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                w.CerrarCnn();
            }
            w.CerrarCnn();
            return cnt;
        }


        private void saveboton_Click(object sender, EventArgs e)
        {
             String fn = dia.Text + " " + mes.Text + " " + anno.Text;
            String sex = sexmax.Text;

            if ((codrep.Text != "" && codrep.Font.Italic == true) || ciduep.Font.Italic == true || nombduep.Font.Italic == true || correp.Font.Italic == true || webrep.Font.Italic == true || direp.Font.Italic == true || nitempp.Font.Italic == true || namerep.Font.Italic == true || apeduep.Font.Italic == true || telrep.Font.Italic == true || celrep.Font.Italic == true)
            {
                if (codrep.Text == "")
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
            else if (codrep.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Usuario", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nitempp.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre de Usuario o Identificacion para el Usuario ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (namerep.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Contraseña para el Ingreso del Usuario ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ciduep.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Contraseña para el Ingreso del Usuario ", "ERROR",
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
                            cmd.Connection = cs.GetCONN();
                            cmd.CommandText = "INSERT INTO Proveedores VALUES (@id, @ci, @nom, @ape, @sexo, @fechan, @telp, @celp, @correo, @web, @dir, @formpay, @state, @nit, @name, @tele, @cele, @fax, @logo, @fechac, @codd)";

                            // Creando los parámetros necesarios
                            cmd.Parameters.Add("@id", System.Data.SqlDbType.BigInt);
                            cmd.Parameters.Add("@ci", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@fechan", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@telp", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@celp", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@correo", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@web", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@dir", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@formpay", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@nit", System.Data.SqlDbType.BigInt);
                            cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@tele", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@cele", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@fax", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@logo", System.Data.SqlDbType.Image);
                            cmd.Parameters.Add("@fechac", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);

                            // Asignando el valor de la imagen
                            // Stream usado como buffer
                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            // Se guarda la imagen en el buffer
                            logoview.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                            // Asignando los valores a los atributos
                            cmd.Parameters["@id"].Value = int.Parse(codrep.Text);
                            cmd.Parameters["@ci"].Value = int.Parse(ciduep.Text);
                            cmd.Parameters["@nom"].Value = nombduep.Text;
                            cmd.Parameters["@ape"].Value = apeduep.Text;
                            cmd.Parameters["@sexo"].Value = sex;
                            cmd.Parameters["@fechan"].Value = fn;
                            cmd.Parameters["@telp"].Value = int.Parse(telduep.Text);
                            cmd.Parameters["@celp"].Value = int.Parse(celduep.Text);
                            cmd.Parameters["@correo"].Value = correp.Text;
                            cmd.Parameters["@web"].Value = webrep.Text;
                            cmd.Parameters["@dir"].Value = direp.Text;
                            cmd.Parameters["@formpay"].Value = pagorep.Text;
                            cmd.Parameters["@state"].Value = starep.Text;
                            cmd.Parameters["@nit"].Value = int.Parse(nitempp.Text); ;
                            cmd.Parameters["@name"].Value = namerep.Text;
                            cmd.Parameters["@tele"].Value = telrep.Text;
                            cmd.Parameters["@cele"].Value = celrep.Text;
                            cmd.Parameters["@fax"].Value = faxrep.Text;
                            cmd.Parameters["@logo"].Value = ms.GetBuffer();
                            cmd.Parameters["@fechac"].Value = fecharep.Text;
                            cmd.Parameters["@codd"].Value = id;

                            cs.OpenCnn();
                            cmd.ExecuteNonQuery();
                            cs.CerrarCnn();

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
                        {  // Objetos de conexión y comando
                           System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                            // Estableciento propiedades
                            cmd.Connection = cs.GetCONN();
                            cmd.CommandText = "INSERT INTO Proveedores VALUES (@id, @ci, @nom, @ape, @sexo, @fechan, @telp, @celp, @correo, @web, @dir, @formpay, @state, @nit, @name, @tele, @cele, @fax, @logo, @fechac, @codd)";

                            // Creando los parámetros necesarios
                            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@ci", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@fechan", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@telp", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@celp", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@correo", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@web", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@dir", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@formpay", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@nit", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@tele", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@cele", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@fax", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@logo", System.Data.SqlDbType.Image);
                            cmd.Parameters.Add("@fechac", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);

                            // Asignando el valor de la imagen
                            // Stream usado como buffer
                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            // Se guarda la imagen en el buffer
                            logoview.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                            // Asignando los valores a los atributos
                            cmd.Parameters["@id"].Value = int.Parse(codrep.Text);
                            cmd.Parameters["@ci"].Value = int.Parse(ciduep.Text);
                            cmd.Parameters["@nom"].Value = nombduep.Text;
                            cmd.Parameters["@ape"].Value = apeduep.Text;
                            cmd.Parameters["@sexo"].Value = sex;
                            cmd.Parameters["@fechan"].Value = fn;
                            cmd.Parameters["@telp"].Value = int.Parse(telduep.Text);
                            cmd.Parameters["@celp"].Value = int.Parse(celduep.Text);
                            cmd.Parameters["@correo"].Value = correp.Text;
                            cmd.Parameters["@web"].Value = webrep.Text;
                            cmd.Parameters["@dir"].Value = direp.Text;
                            cmd.Parameters["@formpay"].Value = pagorep.Text;
                            cmd.Parameters["@state"].Value = starep.Text;
                            cmd.Parameters["@nit"].Value = int.Parse(nitempp.Text); ;
                            cmd.Parameters["@name"].Value = namerep.Text;
                            cmd.Parameters["@tele"].Value = telrep.Text;
                            cmd.Parameters["@cele"].Value = celrep.Text;
                            cmd.Parameters["@fax"].Value = faxrep.Text;
                            cmd.Parameters["@logo"].Value = ms.GetBuffer();
                            cmd.Parameters["@fechac"].Value = fecharep.Text;
                            cmd.Parameters["@codd"].Value = id;

                            cs.OpenCnn();
                            cmd.ExecuteNonQuery();
                            cs.CerrarCnn();

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



    }
}
