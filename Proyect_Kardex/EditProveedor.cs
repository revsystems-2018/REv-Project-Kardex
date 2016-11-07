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
    public partial class EditProveedor : Form
    {
        Conexion cs = new Conexion();
        ValidacionText mn = new ValidacionText();
        OpenFileDialog ima = new OpenFileDialog();
        String id = "3";

        public EditProveedor()
        {
            InitializeComponent();

            tooledProv.SetToolTip(codedprov, "Introducir el Codigo de Registro del Proveedor");
            tooledProv.SetToolTip(buscarboton, "Buscar");
            tooledProv.SetToolTip(regprov, "Registro de Proveedores");
            tooledProv.SetToolTip(codreg, "Codigo de Registro");
            tooledProv.SetToolTip(genboton, "Generar Codigo de Registro");
            tooledProv.SetToolTip(cidue, "Carnet de Identidad del Dueño de la Empresa");
            tooledProv.SetToolTip(nomdue, "Nombres del Dueño");
            tooledProv.SetToolTip(apedue, "Apellidos del Dueño");
            tooledProv.SetToolTip(dia, "Dia");
            tooledProv.SetToolTip(mes, "Mes");
            tooledProv.SetToolTip(anno, "Año");
            tooledProv.SetToolTip(teldue, "Teléfono del Dueño");
            tooledProv.SetToolTip(celdue, "Celular del Dueño");
            tooledProv.SetToolTip(corredp,"Correo Electronico de la Empresa");
            tooledProv.SetToolTip(webedp, "Pagina Web de la Empresa");
            tooledProv.SetToolTip(dired, "Dirección de la Empresa");
            tooledProv.SetToolTip(depaed, "Departamento de Ubicación de la Empresa");
            tooledProv.SetToolTip(proved, "Provincia de Ubicación de la Empresa");
            tooledProv.SetToolTip(pagoed, "Forma de Pago a Realizar al Proveedor");
            tooledProv.SetToolTip(stated, "Estado cual se Identifica el Proveedor");
            tooledProv.SetToolTip(nited, "Nit de la Empresa");
            tooledProv.SetToolTip(nombemed, "Nombre de la Empresa del Proveedor");
            tooledProv.SetToolTip(teledp, "Teléfono de la Empresa del Proveedor");
            tooledProv.SetToolTip(celedp, "Celular de la Empresa del Proveedor");
            tooledProv.SetToolTip(faxedp, "Fax de la Empresa del Proveedor");
            tooledProv.SetToolTip(logoem, "Ubicación del Logo de la Empresa");
            tooledProv.SetToolTip(opened, "Abrir");
            tooledProv.SetToolTip(fechaedp, "Fecha de Hoy");
            tooledProv.SetToolTip(veboton, "Ver Logotipo de la Empresa");
            tooledProv.SetToolTip(saveboton, "Guardar");
            tooledProv.SetToolTip(salirboton, "Salir");

        }

        private void codbusqueda(object sender, KeyPressEventArgs e)
        {
            codedprov.ForeColor = SystemColors.WindowText;
            codedprov.Font = new Font(codedprov.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void codpro(object sender, KeyPressEventArgs e)
        {
            codreg.ForeColor = SystemColors.WindowText;
            codreg.Font = new Font(codreg.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void cisuper(object sender, KeyPressEventArgs e)
        {
            cidue.ForeColor = SystemColors.WindowText;
            cidue.Font = new Font(cidue.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void telSuper(object sender, KeyPressEventArgs e)
        {
            teldue.ForeColor = SystemColors.WindowText;
            teldue.Font = new Font(teldue.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void celSuper(object sender, KeyPressEventArgs e)
        {
            celdue.ForeColor = SystemColors.WindowText;
            celdue.Font = new Font(celdue.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void nitpro(object sender, KeyPressEventArgs e)
        {
            nited.ForeColor = SystemColors.WindowText;
            nited.Font = new Font(nited.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void telpro(object sender, KeyPressEventArgs e)
        {
            teledp.ForeColor = SystemColors.WindowText;
            teledp.Font = new Font(teledp.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void celpro(object sender, KeyPressEventArgs e)
        {
            celedp.ForeColor = SystemColors.WindowText;
            celedp.Font = new Font(celedp.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void faxpro(object sender, KeyPressEventArgs e)
        {
            faxedp.ForeColor = SystemColors.WindowText;
            faxedp.Font = new Font(faxedp.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void nomsuper(object sender, KeyPressEventArgs e)
        {
            nomdue.ForeColor = SystemColors.WindowText;
            nomdue.Font = new Font(nomdue.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void apesuper(object sender, KeyPressEventArgs e)
        {
            apedue.ForeColor = SystemColors.WindowText;
            apedue.Font = new Font(apedue.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {          
            string message = "Esta Seguro que Desea Cancelar la Modificación del Proveedor?";
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

        private void button1_Click(object sender, EventArgs e)
        {
            String fn = dia.Text + " " + mes.Text + " " + anno.Text;
            String sex = sexMax.Text;

            if (codedprov.Text != "" && codedprov.Font.Italic == true || codreg.Font.Italic == true || nomdue.Font.Italic == true || nombemed.Font.Italic == true || nited.Font.Italic == true || cidue.Font.Italic == true)
            {
                if (codedprov.Text == "")
                {
                    MessageBox.Show("Ingrese el Codigo de Registro del Proveedor a Modificar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo de Registro del Proveedor a Modificar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (codedprov.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo de Registro del Proveedor a Modificar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nombemed.Text == "" || nombemed.Font.Italic == true)
            {
                MessageBox.Show("Ingrese el Nombre de la Empresa del Proveedor a Modificar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nited.Text == "" || nited.Font.Italic == true)
            {
                MessageBox.Show("Ingrese el NIT del Proveedor a Modificar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cidue.Text == "" || cidue.Font.Italic == true)
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Proveedor a Modificar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de editar Proveedor.
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
                                fotoPro.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                                // Estableciento propiedades
                                cmd.Connection = cs.GetCONN();
                                cmd.CommandText = "UPDATE Proveedores SET codProve=@codp, ciProve=@cip, nomProve=@nomd, apeProve=@aped, sexProve=@sexo, fnProve=@fechan, telProve=@teld, celProve=@celd, corrProve=@email, webProve=@web, DirProve=@dir, formPay=@pay, estadoProve=@state, nitProve=@nit, nameEmpProve=@name, telEmp=@tele, celEmp=@cele, faxEmp=@faxe, logoProve=@logo, fcProve=@fechac, CodDepaP=@codd  WHERE codProve = @codbp ;";

                                cmd.Parameters.Add("@codp", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@cip", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@nomd", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@aped", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@fechan", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@teld", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@celd", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@web", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@dir", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@pay", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@nit", System.Data.SqlDbType.BigInt);
                                cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@tele", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@cele", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@faxe", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@logo", System.Data.SqlDbType.Image);
                                cmd.Parameters.Add("@fechac", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@codbp", System.Data.SqlDbType.Int);                              

                                // Asignando los valores a los atributos
                                cmd.Parameters["@codp"].Value = int.Parse(codreg.Text);
                                cmd.Parameters["@cip"].Value = int.Parse(codreg.Text);
                                cmd.Parameters["@nomd"].Value = nomdue.Text;
                                cmd.Parameters["@aped"].Value = apedue.Text;
                                cmd.Parameters["@sexo"].Value = sex;
                                cmd.Parameters["@fechan"].Value = fn;
                                cmd.Parameters["@teld"].Value = int.Parse(teldue.Text);
                                cmd.Parameters["@celd"].Value = int.Parse(celdue.Text);
                                cmd.Parameters["@email"].Value = corredp.Text;
                                cmd.Parameters["@web"].Value = webedp.Text;
                                cmd.Parameters["@dir"].Value = dired.Text;
                                cmd.Parameters["@pay"].Value = pagoed.Text;
                                cmd.Parameters["@state"].Value = stated.Text;
                                cmd.Parameters["@nit"].Value = Int64.Parse(nited.Text);
                                cmd.Parameters["@name"].Value = nombemed.Text;
                                cmd.Parameters["@tele"].Value = int.Parse(teledp.Text);
                                cmd.Parameters["@cele"].Value = int.Parse(celedp.Text);
                                cmd.Parameters["@faxe"].Value = int.Parse(faxedp.Text);
                                cmd.Parameters["@logo"].Value = ms.GetBuffer();
                                cmd.Parameters["@fechac"].Value = fechaedp.Text;
                                cmd.Parameters["@codd"].Value = id;
                                cmd.Parameters["@codbp"].Value = int.Parse(codedprov.Text);


                                cs.OpenCnn();
                                cmd.ExecuteNonQuery();
                                cs.CerrarCnn();

                                Messengers mr = new Messengers();
                                mr.textolb.Text = "Proveedor Modificado";
                                mr.ShowDialog();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR. Al Modificar Los Datos. " + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con el Proveedor a Modificar.", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                fotoPro.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                                // Estableciento propiedades
                                cmd.Connection = cs.GetCONN();
                                cmd.CommandText = "UPDATE Proveedores SET codProve=@codp, ciProve=@cip, nomProve=@nomd, apeProve=@aped, sexProve=@sexo, fnProve=@fechan, telProve=@teld, celProve=@celd, corrProve=@email, webProve=@web, DirProve=@dir, formPay=@pay, estadoProve=@state, nitProve=@nit, nameEmpProve=@name, telEmp=@tele, celEmp=@cele, faxEmp=@faxe, logoProve=@logo, fcProve=@fechac, CodDepaP=@codd  WHERE codProve = @codbp ;";

                                cmd.Parameters.Add("@codp", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@cip", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@nomd", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@aped", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@fechan", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@teld", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@celd", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@web", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@dir", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@pay", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@nit", System.Data.SqlDbType.BigInt);
                                cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@tele", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@cele", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@faxe", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@logo", System.Data.SqlDbType.Image);
                                cmd.Parameters.Add("@fechac", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@codbp", System.Data.SqlDbType.Int);

                                // Asignando los valores a los atributos
                                cmd.Parameters["@codp"].Value = int.Parse(codreg.Text);
                                cmd.Parameters["@cip"].Value = int.Parse(codreg.Text);
                                cmd.Parameters["@nomd"].Value = nomdue.Text;
                                cmd.Parameters["@aped"].Value = apedue.Text;
                                cmd.Parameters["@sexo"].Value = sex;
                                cmd.Parameters["@fechan"].Value = fn;
                                cmd.Parameters["@teld"].Value = int.Parse(teldue.Text);
                                cmd.Parameters["@celd"].Value = int.Parse(celdue.Text);
                                cmd.Parameters["@email"].Value = corredp.Text;
                                cmd.Parameters["@web"].Value = webedp.Text;
                                cmd.Parameters["@dir"].Value = dired.Text;
                                cmd.Parameters["@pay"].Value = pagoed.Text;
                                cmd.Parameters["@state"].Value = stated.Text;
                                cmd.Parameters["@nit"].Value = Int64.Parse(nited.Text);
                                cmd.Parameters["@name"].Value = nombemed.Text;
                                cmd.Parameters["@tele"].Value = int.Parse(teledp.Text);
                                cmd.Parameters["@cele"].Value = int.Parse(celedp.Text);
                                cmd.Parameters["@faxe"].Value = int.Parse(faxedp.Text);
                                cmd.Parameters["@logo"].Value = ms.GetBuffer();
                                cmd.Parameters["@fechac"].Value = fechaedp.Text;
                                cmd.Parameters["@codd"].Value = id;
                                cmd.Parameters["@codbp"].Value = int.Parse(codedprov.Text);


                                cs.OpenCnn();
                                cmd.ExecuteNonQuery();
                                cs.CerrarCnn();

                                Messengers mr = new Messengers();
                                mr.textolb.Text = "Proveedor Modificado";
                                mr.ShowDialog();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR. Al Modificar Los Datos. " + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con el Proveedor a Modificar.", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CodedProvClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (codedprov.Text != "" && codedprov.Font.Italic == true)
                {
                    codedprov.Text = "";
                    codedprov.ForeColor = SystemColors.WindowText;
                    codedprov.Font = new Font(codedprov.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    codedprov.ForeColor = SystemColors.WindowText;
                    codedprov.Font = new Font(codedprov.Font, FontStyle.Regular);
                }
            }
        }

        private void codregProvClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (codreg.Text != "" && codreg.Font.Italic == true)
                {
                    codreg.Text = "";
                    codreg.ForeColor = SystemColors.WindowText;
                    codreg.Font = new Font(codreg.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    codreg.ForeColor = SystemColors.WindowText;
                    codreg.Font = new Font(codreg.Font, FontStyle.Regular);
                }
            }
        }

        private void cidueClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (cidue.Text != "" && cidue.Font.Italic == true)
                {
                    cidue.Text = "";
                    cidue.ForeColor = SystemColors.WindowText;
                    cidue.Font = new Font(cidue.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    cidue.ForeColor = SystemColors.WindowText;
                    cidue.Font = new Font(cidue.Font, FontStyle.Regular);
                }
            }
        }

        private void namedueClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nomdue.Text != "" && nomdue.Font.Italic == true)
                {
                    nomdue.Text = "";
                    nomdue.ForeColor = SystemColors.WindowText;
                    nomdue.Font = new Font(nomdue.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nomdue.ForeColor = SystemColors.WindowText;
                    nomdue.Font = new Font(nomdue.Font, FontStyle.Regular);
                }
            }
        }

        private void apedueClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (apedue.Text != "" && apedue.Font.Italic == true)
                {
                    apedue.Text = "";
                    apedue.ForeColor = SystemColors.WindowText;
                    apedue.Font = new Font(apedue.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    apedue.ForeColor = SystemColors.WindowText;
                    apedue.Font = new Font(apedue.Font, FontStyle.Regular);
                }
            }
        }

        private void teldueClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (teldue.Text != "" && teldue.Font.Italic == true)
                {
                    teldue.Text = "";
                    teldue.ForeColor = SystemColors.WindowText;
                    teldue.Font = new Font(teldue.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    teldue.ForeColor = SystemColors.WindowText;
                    teldue.Font = new Font(teldue.Font, FontStyle.Regular);
                }
            }
        }

        private void celdueClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (celdue.Text != "" && celdue.Font.Italic == true)
                {
                    celdue.Text = "";
                    celdue.ForeColor = SystemColors.WindowText;
                    celdue.Font = new Font(celdue.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    celdue.ForeColor = SystemColors.WindowText;
                    celdue.Font = new Font(celdue.Font, FontStyle.Regular);
                }
            }
        }

        private void CorrdueClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (corredp.Text != "" && corredp.Font.Italic == true)
                {
                    corredp.Text = "";
                    corredp.ForeColor = SystemColors.WindowText;
                    corredp.Font = new Font(corredp.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    corredp.ForeColor = SystemColors.WindowText;
                    corredp.Font = new Font(corredp.Font, FontStyle.Regular);
                }
            }
        }

        private void webedClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (webedp.Text != "" && webedp.Font.Italic == true)
                {
                    webedp.Text = "";
                    webedp.ForeColor = SystemColors.WindowText;
                    webedp.Font = new Font(webedp.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    webedp.ForeColor = SystemColors.WindowText;
                    webedp.Font = new Font(webedp.Font, FontStyle.Regular);
                }
            }
        }

        private void dirempClick(object sender, MouseEventArgs e)
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

        private void nitedempClick(object sender, MouseEventArgs e)
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

        private void nameempClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nombemed.Text != "" && nombemed.Font.Italic == true)
                {
                    nombemed.Text = "";
                    nombemed.ForeColor = SystemColors.WindowText;
                    nombemed.Font = new Font(nombemed.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nombemed.ForeColor = SystemColors.WindowText;
                    nombemed.Font = new Font(nombemed.Font, FontStyle.Regular);
                }
            }
        }

        private void teledempClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (teledp.Text != "" && teledp.Font.Italic == true)
                {
                    teledp.Text = "";
                    teledp.ForeColor = SystemColors.WindowText;
                    teledp.Font = new Font(teledp.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    teledp.ForeColor = SystemColors.WindowText;
                    teledp.Font = new Font(teledp.Font, FontStyle.Regular);
                }
            }
        }

        private void celedempClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (celedp.Text != "" && celedp.Font.Italic == true)
                {
                    celedp.Text = "";
                    celedp.ForeColor = SystemColors.WindowText;
                    celedp.Font = new Font(celedp.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    celedp.ForeColor = SystemColors.WindowText;
                    celedp.Font = new Font(celedp.Font, FontStyle.Regular);
                }
            }
        }

        private void faxedempClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (faxedp.Text != "" && faxedp.Font.Italic == true)
                {
                    faxedp.Text = "";
                    faxedp.ForeColor = SystemColors.WindowText;
                    faxedp.Font = new Font(faxedp.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    faxedp.ForeColor = SystemColors.WindowText;
                    faxedp.Font = new Font(faxedp.Font, FontStyle.Regular);
                }
            }
        }

        private void logoedempClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (logoem.Text != "" && logoem.Font.Italic == true)
                {
                    logoem.Text = "";
                    logoem.ForeColor = SystemColors.WindowText;
                    logoem.Font = new Font(logoem.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    logoem.ForeColor = SystemColors.WindowText;
                    logoem.Font = new Font(logoem.Font, FontStyle.Regular);
                }
            }
        }


        private int comprobar()
        {
            int cnt = 0;
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Proveedores WHERE codProve= '" + Convert.ToInt32(codedprov.Text) + "' ; ";

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
                d.CerrarCnn();
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
                h.CerrarCnn();
            }
            catch (Exception) { }
            h.CerrarCnn();
            return res;
        }

        private void buscarboton_Click(object sender, EventArgs e)
        {
            if (codedprov.Text != "" && codedprov.Font.Italic == true)
            {
                if (codedprov.Text == "")
                {
                    MessageBox.Show("Ingrese el Codigo de Registro del Proveedor que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo de Registro del Proveedor que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (codedprov.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo de Registro del Proveedor que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {//Codigo de buscar el Proveedor.
                string query = "SELECT * FROM Proveedores WHERE codProve ='" + Convert.ToInt32(codedprov.Text) + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
                cs.OpenCnn();
                SqlDataReader read;
                if (comprobar() == 1)
                {
                    codreg.Text = "";
                    codreg.ForeColor = SystemColors.WindowText;
                    codreg.Font = new Font(codreg.Font, FontStyle.Regular);
                    cidue.Text = "";
                    cidue.ForeColor = SystemColors.WindowText;
                    cidue.Font = new Font(cidue.Font, FontStyle.Regular);
                    nomdue.Text = "";
                    nomdue.ForeColor = SystemColors.WindowText;
                    nomdue.Font = new Font(nomdue.Font, FontStyle.Regular);
                    apedue.Text = "";
                    apedue.ForeColor = SystemColors.WindowText;
                    apedue.Font = new Font(apedue.Font, FontStyle.Regular);
                    teldue.Text = "";
                    teldue.ForeColor = SystemColors.WindowText;
                    teldue.Font = new Font(teldue.Font, FontStyle.Regular);
                    celdue.Text = "";
                    celdue.ForeColor = SystemColors.WindowText;
                    celdue.Font = new Font(celdue.Font, FontStyle.Regular);
                    corredp.Text = "";
                    corredp.ForeColor = SystemColors.WindowText;
                    corredp.Font = new Font(corredp.Font, FontStyle.Regular);
                    webedp.Text = "";
                    webedp.ForeColor = SystemColors.WindowText;
                    webedp.Font = new Font(webedp.Font, FontStyle.Regular);
                    dired.Text = "";
                    dired.ForeColor = SystemColors.WindowText;
                    dired.Font = new Font(dired.Font, FontStyle.Regular);
                    nited.Text = "";
                    nited.ForeColor = SystemColors.WindowText;
                    nited.Font = new Font(nited.Font, FontStyle.Regular);
                    nombemed.Text = "";
                    nombemed.ForeColor = SystemColors.WindowText;
                    nombemed.Font = new Font(nombemed.Font, FontStyle.Regular);
                    teledp.Text = "";
                    teledp.ForeColor = SystemColors.WindowText;
                    teledp.Font = new Font(teledp.Font, FontStyle.Regular);
                    celedp.Text = "";
                    celedp.ForeColor = SystemColors.WindowText;
                    celedp.Font = new Font(celedp.Font, FontStyle.Regular);
                    faxedp.Text = "";
                    faxedp.ForeColor = SystemColors.WindowText;
                    faxedp.Font = new Font(faxedp.Font, FontStyle.Regular);
                    logoem.Text = "";
                    logoem.ForeColor = SystemColors.WindowText;
                    logoem.Font = new Font(logoem.Font, FontStyle.Regular);

                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            codreg.Text = read.GetInt32(0).ToString();
                            cidue.Text = read.GetInt32(1).ToString();
                            nomdue.Text = read.GetString(2);
                            apedue.Text = read.GetString(3);
                            teldue.Text = read.GetInt32(6).ToString();
                            celdue.Text = read.GetInt32(7).ToString();
                            corredp.Text = read.GetString(8);
                            webedp.Text = read.GetString(9);
                            dired.Text = read.GetString(10);
                            nited.Text = read.GetInt32(13).ToString();
                            nombemed.Text = read.GetString(14);
                            teledp.Text = read.GetInt32(15).ToString();
                            celedp.Text = read.GetInt32(16).ToString();
                            faxedp.Text = read.GetInt32(17).ToString();
                            dia.SelectedItem = read.GetString(5).Substring(0, 2);
                            mes.SelectedItem = read.GetString(5).Substring(3, 2);
                            anno.SelectedItem = read.GetString(5).Substring(6, 4);
                            pagoed.SelectedItem = read.GetString(11);
                            stated.SelectedItem = read.GetString(12);
                            depaed.SelectedItem = GetDepa(read.GetString(20));

                            // El campo productImage primero se almacena en un buffer
                            byte[] imageBuffer = (byte[])(read[18]);
                            // Se crea un MemoryStream a partir de ese buffer                        

                            if (imageBuffer == null || read[18] == null)
                            {
                                fotoPro.Image = null;
                            }
                            else
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                                fotoPro.Image = Image.FromStream(ms);
                            }

                            if (read.GetString(4) == "Masculino")
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
                        cs.CerrarCnn();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Existe Datos Nulos con el Proveedor Ingresado. \n" + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con el Proveedor a Modificar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cs.CerrarCnn();
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, El Proveedor Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cs.CerrarCnn();
                }

            }
        }

        private void opened_Click(object sender, EventArgs e)
        {
            ima.InitialDirectory = "C:\\";
            ima.Filter = "PNG Imagen (*.png)|*.png";
            ima.Title = "Abrir Logotipo de Empresa";

            if (ima.ShowDialog() == DialogResult.OK)
            {
                logoem.Text = "";
                logoem.ForeColor = SystemColors.WindowText;
                logoem.Font = new Font(logoem.Font, FontStyle.Regular);
                logoem.Text = ima.FileName;
                //fotoCliente.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void veboton_Click(object sender, EventArgs e)
        {
            if (logoem.Text != "" && logoem.Font.Italic == true)
            {
                if (logoem.Text == "")
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (logoem.Text == "")
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta o Escriba la Dirección de la Imagen.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fotoPro.ImageLocation = ima.FileName;
            }
        }

        private void genboton_Click(object sender, EventArgs e)
        {
            codreg.ForeColor = SystemColors.WindowText;
            codreg.Font = new Font(codreg.Font, FontStyle.Regular);

            Random ra = new Random();
            int puro = new int();
         
            if(codreg.Font.Italic == true){
                MessageBox.Show("Debe pulsar con un Click en el campo del Codigo de Registro para Proveedores.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                puro = ra.Next(1, 999999999);
            }
            codreg.Text = "" + puro;
        }

        private void regprov_Click(object sender, EventArgs e)
        {
            Registro_Proveedores rp = new Registro_Proveedores();
            rp.nuevo.Enabled = false;
            rp.nuevo.BackgroundImage = global::Proyect_Kardex.Properties.Resources.novob;
            rp.editar.Enabled = false;
            rp.editar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editdocumentob;
            rp.eliminar.Enabled = false;
            rp.eliminar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_deleteb;
            rp.ShowDialog();
            codedprov.Text = "";
            codedprov.ForeColor = SystemColors.WindowText;
            codedprov.Font = new Font(codedprov.Font, FontStyle.Regular);
            codedprov.Text = rp.codUser.ToString(); 
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


        private void corredp_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(corredp.Text))
            {

            }
            else
            {
                MessageBox.Show("Dirrección de Correo Electrónico No Valida. El Correo Debe Tener El Formato: nombre@dominio.com  Porfavor Seleccione un Correo Electroónico Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                corredp.SelectAll();
                corredp.Focus();
            }
        }

        private void weboton_Click(object sender, EventArgs e)
        {
            if (webedp.Text != "" && webedp.Font.Italic == true)
            {
                if (webedp.Text == "")
                {
                    MessageBox.Show("Ingrese la Dirección de la Pagina Web del Proveedor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese la Dirección de la Pagina Web del Proveedor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (webedp.Text == "")
            {
                MessageBox.Show("Ingrese la Dirección de la Pagina Web del Proveedor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                REV_WebStudio we = new REV_WebStudio();
                we.texturlweb.Text = webedp.Text;
                we.webBrow.Navigate(webedp.Text);
                we.ShowDialog();
            }
        }

        private void corredp_KeyPress(object sender, KeyPressEventArgs e)
        {
            corredp.ForeColor = SystemColors.WindowText;
            corredp.Font = new Font(corredp.Font, FontStyle.Regular);
        }

        private void webedp_KeyPress(object sender, KeyPressEventArgs e)
        {
            webedp.ForeColor = SystemColors.WindowText;
            webedp.Font = new Font(webedp.Font, FontStyle.Regular);
        }

        private void dired_KeyPress(object sender, KeyPressEventArgs e)
        {
            dired.ForeColor = SystemColors.WindowText;
            dired.Font = new Font(dired.Font, FontStyle.Regular);
        }

        private void nombemed_KeyPress(object sender, KeyPressEventArgs e)
        {
            nombemed.ForeColor = SystemColors.WindowText;
            nombemed.Font = new Font(nombemed.Font, FontStyle.Regular);
        }

        private void logoem_KeyPress(object sender, KeyPressEventArgs e)
        {
            logoem.ForeColor = SystemColors.WindowText;
            logoem.Font = new Font(logoem.Font, FontStyle.Regular);
        }

        private void label25_Click(object sender, EventArgs e)
        {
            codedprov.Text = "";
            codedprov.ForeColor = SystemColors.WindowText;
            codedprov.Font = new Font(codedprov.Font, FontStyle.Regular);
            codreg.Text = "";
            codreg.ForeColor = SystemColors.WindowText;
            codreg.Font = new Font(codreg.Font, FontStyle.Regular);
            cidue.Text = "";
            cidue.ForeColor = SystemColors.WindowText;
            cidue.Font = new Font(cidue.Font, FontStyle.Regular);
            nomdue.Text = "";
            nomdue.ForeColor = SystemColors.WindowText;
            nomdue.Font = new Font(nomdue.Font, FontStyle.Regular);
            apedue.Text = "";
            apedue.ForeColor = SystemColors.WindowText;
            apedue.Font = new Font(apedue.Font, FontStyle.Regular);
            teldue.Text = "";
            teldue.ForeColor = SystemColors.WindowText;
            teldue.Font = new Font(teldue.Font, FontStyle.Regular);
            celdue.Text = "";
            celdue.ForeColor = SystemColors.WindowText;
            celdue.Font = new Font(celdue.Font, FontStyle.Regular);
            corredp.Text = "";
            corredp.ForeColor = SystemColors.WindowText;
            corredp.Font = new Font(corredp.Font, FontStyle.Regular);
            webedp.Text = "";
            webedp.ForeColor = SystemColors.WindowText;
            webedp.Font = new Font(webedp.Font, FontStyle.Regular);
            dired.Text = "";
            dired.ForeColor = SystemColors.WindowText;
            dired.Font = new Font(dired.Font, FontStyle.Regular);
            nited.Text = "";
            nited.ForeColor = SystemColors.WindowText;
            nited.Font = new Font(nited.Font, FontStyle.Regular);
            nombemed.Text = "";
            nombemed.ForeColor = SystemColors.WindowText;
            nombemed.Font = new Font(nombemed.Font, FontStyle.Regular);
            teledp.Text = "";
            teledp.ForeColor = SystemColors.WindowText;
            teledp.Font = new Font(teledp.Font, FontStyle.Regular);
            celedp.Text = "";
            celedp.ForeColor = SystemColors.WindowText;
            celedp.Font = new Font(celedp.Font, FontStyle.Regular);
            faxedp.Text = "";
            faxedp.ForeColor = SystemColors.WindowText;
            faxedp.Font = new Font(faxedp.Font, FontStyle.Regular);
            logoem.Text = "";
            logoem.ForeColor = SystemColors.WindowText;
            logoem.Font = new Font(logoem.Font, FontStyle.Regular);
        }

        private void EditProveedor_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Departamento; ";
            Conexion j = new Conexion();
            SqlCommand sqlQ = new SqlCommand(query, j.GetCONN());
            j.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(1);
                    depaed.Items.Add(Scad);
                }
                j.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                j.CerrarCnn();
            }
        }

        private void depaed_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion h = new Conexion();
            string query = "SELECT nombrePro, CodDep FROM Provincia, Departamento WHERE CodDep=codigoDep AND nombreDep= '" + depaed.Text + "' ; ";
            SqlCommand sqlQ = new SqlCommand(query, h.GetCONN());
            h.OpenCnn();
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
                h.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                h.CerrarCnn();
            } 
        }



    }
}
