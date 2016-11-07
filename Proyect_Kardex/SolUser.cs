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
    public partial class SolUser : Form
    {
        String id = "3";
        Conexion cs = new Conexion();
        public int codUser = 0; 

        public SolUser()
        {
            InitializeComponent();

            toolSolUser.SetToolTip(ciuser, "Carnet de Identidad");
            toolSolUser.SetToolTip(nomus, "Nombres");
            toolSolUser.SetToolTip(apeus, "Apellido Paterno Y Materno");
            toolSolUser.SetToolTip(nameus, "Nombre de Usuario");
            toolSolUser.SetToolTip(passus, "Contraseña");
            toolSolUser.SetToolTip(confpsss, "Repetir la Misma Contraseña");
            toolSolUser.SetToolTip(dirus, "Direccion Donde Vives");
            toolSolUser.SetToolTip(depaus, "Departamento Donde Vives");
            toolSolUser.SetToolTip(provus, "Provincia Donde Vives");
            toolSolUser.SetToolTip(dia, "Dia");
            toolSolUser.SetToolTip(mes, "Mes");
            toolSolUser.SetToolTip(anno, "Año");
            toolSolUser.SetToolTip(corrus, "Correo Electronico");
            toolSolUser.SetToolTip(telus, "Telefono Local");
            toolSolUser.SetToolTip(celus, "Celular");
            toolSolUser.SetToolTip(saveboton, "Guardar");
            toolSolUser.SetToolTip(salirboton, "Salir");
        }


        public int CodigoAdmin()
        {
            int res = 0;
            Conexion d = new Conexion();
            string query = "SELECT ciUser, nuUsuario FROM Usuario WHERE idUser='1'; ";

            SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
            d.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    if (codUser == 0)
                    {
                        res = read2.GetInt32(0);
                    }
                    else
                    {
                        res = codUser;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Con el Codigo del Administrador.\n" + ex.Message + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            d.CerrarCnn();
            return res;
        }

        public void soloNumeros(KeyPressEventArgs n) {
            try
            {
                if(char.IsNumber(n.KeyChar)){
                    n.Handled = false;
                }
                else if(char.IsControl(n.KeyChar)){
                    n.Handled = false;
                }              
                else {
                    n.Handled = true;
                }
            }
            catch(Exception) { 
            
            }
        }

        public void soloLetras(KeyPressEventArgs n)
        {
            try
            {
                if (char.IsLetter(n.KeyChar))
                {
                    n.Handled = false;
                }
                else if (char.IsControl(n.KeyChar))
                {
                    n.Handled = false;
                }
                else if (char.IsSeparator(n.KeyChar))
                {
                    n.Handled = false;
                }
                else
                {
                    n.Handled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ciNumero(object sender, KeyPressEventArgs e)
        {
            ciuser.ForeColor = SystemColors.WindowText;
            ciuser.Font = new Font(ciuser.Font, FontStyle.Regular);
            soloNumeros(e);
        }

        private void nomletra(object sender, KeyPressEventArgs e)
        {
            nomus.ForeColor = SystemColors.WindowText;
            nomus.Font = new Font(nomus.Font, FontStyle.Regular);
            soloLetras(e);
        }

        private void apletra(object sender, KeyPressEventArgs e)
        {
            apeus.ForeColor = SystemColors.WindowText;
            apeus.Font = new Font(apeus.Font, FontStyle.Regular);
            soloLetras(e);
        }

        private void telNum(object sender, KeyPressEventArgs e)
        {
            telus.ForeColor = SystemColors.WindowText;
            telus.Font = new Font(telus.Font, FontStyle.Regular);
            soloNumeros(e);
        }

        private void celNum(object sender, KeyPressEventArgs e)
        {
            celus.ForeColor = SystemColors.WindowText;
            celus.Font = new Font(celus.Font, FontStyle.Regular);
            soloNumeros(e);
        }

        private void cisolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (ciuser.Text != "" && ciuser.Font.Italic == true)
                {
                    ciuser.Text = "";
                    ciuser.ForeColor = SystemColors.WindowText;
                    ciuser.Font = new Font(ciuser.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    ciuser.ForeColor = SystemColors.WindowText;
                    ciuser.Font = new Font(ciuser.Font, FontStyle.Regular);
                }
            }
        }

        private void nombsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nomus.Text != "" && nomus.Font.Italic == true)
                {
                    nomus.Text = "";
                    nomus.ForeColor = SystemColors.WindowText;
                    nomus.Font = new Font(nomus.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nomus.ForeColor = SystemColors.WindowText;
                    nomus.Font = new Font(nomus.Font, FontStyle.Regular);
                }
            }
        }

        private void apelsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (apeus.Text != "" && apeus.Font.Italic == true)
                {
                    apeus.Text = "";
                    apeus.ForeColor = SystemColors.WindowText;
                    apeus.Font = new Font(apeus.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    apeus.ForeColor = SystemColors.WindowText;
                    apeus.Font = new Font(apeus.Font, FontStyle.Regular);
                }
            }
        }

        private void namesolClick(object sender, MouseEventArgs e)
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

        private void dirsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (dirus.Text != "" && dirus.Font.Italic == true)
                {
                    dirus.Text = "";
                    dirus.ForeColor = SystemColors.WindowText;
                    dirus.Font = new Font(dirus.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    dirus.ForeColor = SystemColors.WindowText;
                    dirus.Font = new Font(dirus.Font, FontStyle.Regular);
                }
            }
        }

        private void corrsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (corrus.Text != "" && corrus.Font.Italic == true)
                {
                    corrus.Text = "";
                    corrus.ForeColor = SystemColors.WindowText;
                    corrus.Font = new Font(corrus.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    corrus.ForeColor = SystemColors.WindowText;
                    corrus.Font = new Font(corrus.Font, FontStyle.Regular);
                }
            }
        }

        private void telsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (telus.Text != "" && telus.Font.Italic == true)
                {
                    telus.Text = "";
                    telus.ForeColor = SystemColors.WindowText;
                    telus.Font = new Font(telus.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    telus.ForeColor = SystemColors.WindowText;
                    telus.Font = new Font(telus.Font, FontStyle.Regular);
                }
            }
        }

        private void celsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (celus.Text != "" && celus.Font.Italic == true)
                {
                    celus.Text = "";
                    celus.ForeColor = SystemColors.WindowText;
                    celus.Font = new Font(celus.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    celus.ForeColor = SystemColors.WindowText;
                    celus.Font = new Font(celus.Font, FontStyle.Regular);
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

        private void corrus_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(corrus.Text))
            {

            }
            else
            {
                MessageBox.Show("Dirrección de Correo Electrónico No Valida. El Correo Debe Tener El Formato: nombre@dominio.com  Porfavor Seleccione un Correo Electroónico Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                corrus.SelectAll();
                corrus.Focus();
            }
        }

        private void nameus_KeyPress(object sender, KeyPressEventArgs e)
        {
            nameus.ForeColor = SystemColors.WindowText;
            nameus.Font = new Font(nameus.Font, FontStyle.Regular);
        }

        private void dirus_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirus.ForeColor = SystemColors.WindowText;
            dirus.Font = new Font(dirus.Font, FontStyle.Regular);
        }

        private void corrus_KeyPress(object sender, KeyPressEventArgs e)
        {
            corrus.ForeColor = SystemColors.WindowText;
            corrus.Font = new Font(corrus.Font, FontStyle.Regular);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ciuser.Text = "";
            ciuser.ForeColor = SystemColors.WindowText;
            ciuser.Font = new Font(ciuser.Font, FontStyle.Regular);
            nomus.Text = "";
            nomus.ForeColor = SystemColors.WindowText;
            nomus.Font = new Font(nomus.Font, FontStyle.Regular);
            apeus.Text = "";
            apeus.ForeColor = SystemColors.WindowText;
            apeus.Font = new Font(apeus.Font, FontStyle.Regular);
            nameus.Text = "";
            nameus.ForeColor = SystemColors.WindowText;
            nameus.Font = new Font(nameus.Font, FontStyle.Regular);
            dirus.Text = "";
            dirus.ForeColor = SystemColors.WindowText;
            dirus.Font = new Font(dirus.Font, FontStyle.Regular);
            corrus.Text = "";
            corrus.ForeColor = SystemColors.WindowText;
            corrus.Font = new Font(corrus.Font, FontStyle.Regular);
            telus.Text = "";
            telus.ForeColor = SystemColors.WindowText;
            telus.Font = new Font(telus.Font, FontStyle.Regular);
            celus.Text = "";
            celus.ForeColor = SystemColors.WindowText;
            celus.Font = new Font(celus.Font, FontStyle.Regular);
           
        }

        private void SolUser_Load(object sender, EventArgs e)
        {
            Conexion d = new Conexion();
            string query = "SELECT * FROM Departamento; ";

            SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
            d.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(1);
                    depaus.Items.Add(Scad);
                }
                d.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.ToString() + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void depaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion d = new Conexion();
            string query = "SELECT nombrePro, CodDep FROM Provincia, Departamento WHERE CodDep=codigoDep AND nombreDep= '" + depaus.Text + "' ; ";
            SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
            d.OpenCnn();
            SqlDataReader read;

            try
            {
                read = sqlQ.ExecuteReader();
                provus.Items.Clear();
                while (read.Read())
                {
                    String cade = read.GetString(0);
                    provus.Items.Add(cade);
                    id = read.GetString(1);
                }
                d.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.ToString() + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private int comprobar()
        {
            int cnt = 0;
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM SolUser WHERE ciSolU= '" + Convert.ToInt32(ciuser.Text) + "' ; ";
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

        private void saveboton_Click(object sender, EventArgs e)
        {
            String fn = dia.Text + " " + mes.Text + " " + anno.Text;
            String sex = sexmax.Text;
            int iduser = 2;
            codUser = CodigoAdmin();

            if ((ciuser.Text != "" && ciuser.Font.Italic == true) || nomus.Font.Italic == true || apeus.Font.Italic == true || nameus.Font.Italic == true || dirus.Font.Italic == true || corrus.Font.Italic == true || telus.Font.Italic == true || celus.Font.Italic == true )
            {
                if (ciuser.Text == "")
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
            else if (ciuser.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Usuario", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nameus.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre de Usuario o Identificacion para el Usuario ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passus.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Contraseña para el Ingreso del Usuario ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Codigo de guardar usuario.
                if (passus.Text == confpsss.Text)
                {
                    if (comprobar() == 0)
                    {
                        if (sexfem.Checked == true)
                        {
                            sex = sexfem.Text;
                            try
                            { // Objetos de conexión y comando
                                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                                // Estableciento propiedades
                                cmd.Connection = cs.GetCONN();
                                cmd.CommandText = "INSERT INTO SolUser(ciSolU, nomSolU, apeSolU, nameSolU, PassSolU, dirSolU, sexSolU, fnSolU, corrSolU, telSolU, celSolU, CodDepaSU, codUsr) VALUES (@id, @nom, @ape, @nuusr, @passw, @dirusr, @sexo, @fechan, @correo, @tel, @cel, @codd, @codu)";

                                // Creando los parámetros necesarios
                                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@nuusr", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@passw", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@dirusr", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@fechan", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@correo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@tel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@cel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@codu", System.Data.SqlDbType.Int);

                                // Asignando los valores a los atributos
                                cmd.Parameters["@id"].Value = int.Parse(ciuser.Text);
                                cmd.Parameters["@nom"].Value = nomus.Text;
                                cmd.Parameters["@ape"].Value = apeus.Text;
                                cmd.Parameters["@nuusr"].Value = nameus.Text;
                                cmd.Parameters["@passw"].Value = passus.Text;
                                cmd.Parameters["@dirusr"].Value = dirus.Text;
                                cmd.Parameters["@sexo"].Value = sex;
                                cmd.Parameters["@fechan"].Value = fn;
                                cmd.Parameters["@correo"].Value = corrus.Text;
                                cmd.Parameters["@tel"].Value = int.Parse(telus.Text);
                                cmd.Parameters["@cel"].Value = int.Parse(celus.Text);
                                cmd.Parameters["@codd"].Value = id;
                                cmd.Parameters["@codu"].Value = codUser;

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
                            {   // Objetos de conexión y comando
                                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                                // Estableciento propiedades
                                cmd.Connection = cs.GetCONN();
                                cmd.CommandText = "INSERT INTO SolUser(ciSolU, nomSolU, apeSolU, nameSolU, PassSolU, dirSolU, sexSolU, fnSolU, corrSolU, telSolU, celSolU, CodDepaSU, codUsr) VALUES (@id, @nom, @ape, @nuusr, @passw, @dirusr, @sexo, @fechan, @correo, @tel, @cel, @codd, @codu)";

                                // Creando los parámetros necesarios
                                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@nuusr", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@passw", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@dirusr", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@fechan", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@correo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@tel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@cel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@codu", System.Data.SqlDbType.Int);

                                // Asignando los valores a los atributos
                                cmd.Parameters["@id"].Value = int.Parse(ciuser.Text);
                                cmd.Parameters["@nom"].Value = nomus.Text;
                                cmd.Parameters["@ape"].Value = apeus.Text;
                                cmd.Parameters["@nuusr"].Value = nameus.Text;
                                cmd.Parameters["@passw"].Value = passus.Text;
                                cmd.Parameters["@dirusr"].Value = dirus.Text;
                                cmd.Parameters["@sexo"].Value = sex;
                                cmd.Parameters["@fechan"].Value = fn;
                                cmd.Parameters["@correo"].Value = corrus.Text;
                                cmd.Parameters["@tel"].Value = int.Parse(telus.Text);
                                cmd.Parameters["@cel"].Value = int.Parse(celus.Text);
                                cmd.Parameters["@codd"].Value = id;
                                cmd.Parameters["@codu"].Value = codUser;

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
                        //Editar Usuario.

                        if (sexfem.Checked == true)
                        {
                            sex = sexfem.Text;
                            try
                            {  // Objetos de conexión y comando
                                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                                // Estableciento propiedades
                                cmd.Connection = cs.GetCONN();
                                cmd.CommandText = "UPDATE SolUser SET ciSolU=@id, nomSolU=@nom, apeSolU=@ape, nameSolU=@nuusr, PassSolU=@passw, dirSolU=@dirusr, sexSolU=@sexo, fnSolU=@fechan, corrSolU=@correo, telSolU=@tel, celSolU=@cel, CodDepaSU=@codd, codUsr=@codu WHERE ciSolU = @idd ;";

                                // Creando los parámetros necesarios
                                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@nuusr", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@passw", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@dirusr", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@fechan", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@correo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@tel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@cel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@codu", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@idd", System.Data.SqlDbType.Int);

                                // Asignando los valores a los atributos
                                cmd.Parameters["@id"].Value = int.Parse(ciuser.Text);
                                cmd.Parameters["@nom"].Value = nomus.Text;
                                cmd.Parameters["@ape"].Value = apeus.Text;
                                cmd.Parameters["@nuusr"].Value = nameus.Text;
                                cmd.Parameters["@passw"].Value = passus.Text;
                                cmd.Parameters["@dirusr"].Value = dirus.Text;
                                cmd.Parameters["@sexo"].Value = sex;
                                cmd.Parameters["@fechan"].Value = fn;
                                cmd.Parameters["@correo"].Value = corrus.Text;
                                cmd.Parameters["@tel"].Value = int.Parse(telus.Text);
                                cmd.Parameters["@cel"].Value = int.Parse(celus.Text);
                                cmd.Parameters["@codd"].Value = id;
                                cmd.Parameters["@codu"].Value = codUser;
                                cmd.Parameters["@idd"].Value = int.Parse(ciuser.Text);

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
                                MessageBox.Show("ERROR. Al Modificar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            try
                            {  // Objetos de conexión y comando
                                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                                // Estableciento propiedades
                                cmd.Connection = cs.GetCONN();
                                cmd.CommandText = "UPDATE SolUser SET ciSolU=@id, nomSolU=@nom, apeSolU=@ape, nameSolU=@nuusr, PassSolU=@passw, dirSolU=@dirusr, sexSolU=@sexo, fnSolU=@fechan, corrSolU=@correo, telSolU=@tel, celSolU=@cel, CodDepaSU=@codd, codUsr=@codu WHERE ciSolU = @idd ;";

                                // Creando los parámetros necesarios
                                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@nuusr", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@passw", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@dirusr", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@fechan", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@correo", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@tel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@cel", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);
                                cmd.Parameters.Add("@codu", System.Data.SqlDbType.Int);
                                cmd.Parameters.Add("@idd", System.Data.SqlDbType.Int);

                                // Asignando los valores a los atributos
                                cmd.Parameters["@id"].Value = int.Parse(ciuser.Text);
                                cmd.Parameters["@nom"].Value = nomus.Text;
                                cmd.Parameters["@ape"].Value = apeus.Text;
                                cmd.Parameters["@nuusr"].Value = nameus.Text;
                                cmd.Parameters["@passw"].Value = passus.Text;
                                cmd.Parameters["@dirusr"].Value = dirus.Text;
                                cmd.Parameters["@sexo"].Value = sex;
                                cmd.Parameters["@fechan"].Value = fn;
                                cmd.Parameters["@correo"].Value = corrus.Text;
                                cmd.Parameters["@tel"].Value = int.Parse(telus.Text);
                                cmd.Parameters["@cel"].Value = int.Parse(celus.Text);
                                cmd.Parameters["@codd"].Value = id;
                                cmd.Parameters["@codu"].Value = codUser;
                                cmd.Parameters["@idd"].Value = int.Parse(ciuser.Text);

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
                                MessageBox.Show("ERROR. Al Modificar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no son Iguales, Intente Nuevamente.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passus.Text = "";
                    confpsss.Text = "";
                }
            }
        }

        private void buscaredboton_Click(object sender, EventArgs e)
        {
            Conexion f = new Conexion();
            if (ciuser.Text != "" && ciuser.Font.Italic == true)
            {
                if (ciuser.Text == "")
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
            else if (ciuser.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Usuario que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de buscar Usuario. 
                string query = "SELECT * FROM Usuario WHERE ciUser ='" + Convert.ToInt32(ciuser.Text) + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, f.GetCONN());
                SqlDataReader read;
                if (comprobar() == 1)
                {                   
                    ciuser.ForeColor = SystemColors.WindowText;
                    ciuser.Font = new Font(ciuser.Font, FontStyle.Regular);
                    nameus.Text = "";
                    nameus.ForeColor = SystemColors.WindowText;
                    nameus.Font = new Font(nameus.Font, FontStyle.Regular);
                    apeus.Text = "";
                    apeus.ForeColor = SystemColors.WindowText;
                    apeus.Font = new Font(apeus.Font, FontStyle.Regular);
                    nameus.Text = "";
                    nameus.ForeColor = SystemColors.WindowText;
                    nameus.Font = new Font(nameus.Font, FontStyle.Regular);
                    dirus.Text = "";
                    dirus.ForeColor = SystemColors.WindowText;
                    dirus.Font = new Font(dirus.Font, FontStyle.Regular);
                    corrus.Text = "";
                    corrus.ForeColor = SystemColors.WindowText;
                    corrus.Font = new Font(corrus.Font, FontStyle.Regular);
                    telus.Text = "";
                    telus.ForeColor = SystemColors.WindowText;
                    telus.Font = new Font(telus.Font, FontStyle.Regular);
                    celus.Text = "";
                    celus.ForeColor = SystemColors.WindowText;
                    celus.Font = new Font(celus.Font, FontStyle.Regular);

                    try
                    {
                        f.OpenCnn();
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            nomus.Text = read.GetString(2);
                            apeus.Text = read.GetString(3);
                            nameus.Text = read.GetString(4);
                            passus.Text = read.GetString(5);
                            confpsss.Text = read.GetString(5);
                            dirus.Text = read.GetString(6);
                            corrus.Text = read.GetString(9);
                            telus.Text = read.GetInt32(10).ToString();
                            celus.Text = read.GetInt32(11).ToString();
                        }
                        f.CerrarCnn();
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





    }
}
