using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Proyect_Kardex
{
    public partial class SolCliente : Form
    {
        ValidacionText mn = new ValidacionText();
        Conexion cs = new Conexion();
        String id = "3";
        public int codUser = 0;

        public SolCliente()
        {
            InitializeComponent();

            toolSolCliente.SetToolTip(cic, "Carnet de Identidad del Cliente");
            toolSolCliente.SetToolTip(nombc, "Nombres del Cliente");
            toolSolCliente.SetToolTip(apec, "Apellidos del Cliente");
            toolSolCliente.SetToolTip(nitc, "Numero del NIT del Cliente");
            toolSolCliente.SetToolTip(dirc, "Direccion donde vive el Cliente");
            toolSolCliente.SetToolTip(depac, "Departamento donde vive el Cliente");
            toolSolCliente.SetToolTip(provc, "Provincia donde vive el Cliente");
            toolSolCliente.SetToolTip(corc, "Correo Electronico del Cliente");
            toolSolCliente.SetToolTip(telc, "Telefono Local del Cliente");
            toolSolCliente.SetToolTip(celc, "Celular del Cliente");
            toolSolCliente.SetToolTip(saveboton, "Guardar");
            toolSolCliente.SetToolTip(salirboton, "Salir");

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
                    if(codUser == 0){
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


        private void ciCliente(object sender, KeyPressEventArgs e)
        {
            cic.ForeColor = SystemColors.WindowText;
            cic.Font = new Font(cic.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void nitCliente(object sender, KeyPressEventArgs e)
        {
            nitc.ForeColor = SystemColors.WindowText;
            nitc.Font = new Font(nitc.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void telCliente(object sender, KeyPressEventArgs e)
        {
            telc.ForeColor = SystemColors.WindowText;
            telc.Font = new Font(telc.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void CelCliente(object sender, KeyPressEventArgs e)
        {
            celc.ForeColor = SystemColors.WindowText;
            celc.Font = new Font(celc.Font, FontStyle.Regular);
            mn.soloNumeros(e);
        }

        private void nombCli(object sender, KeyPressEventArgs e)
        {
            nombc.ForeColor = SystemColors.WindowText;
            nombc.Font = new Font(nombc.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void apeCliente(object sender, KeyPressEventArgs e)
        {
            apec.ForeColor = SystemColors.WindowText;
            apec.Font = new Font(apec.Font, FontStyle.Regular);
            mn.soloLetras(e);
        }

        private void salirboton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscaredboton_Click(object sender, EventArgs e)
        {
            Conexion d = new Conexion();
            if (cic.Text != "" && cic.Font.Italic == true)
            {
                if (cic.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente Nuevo a Buscar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente Nuevo a Buscar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cic.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente Nuevo a Buscar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   //Codigo de Buscar Cliente.
                string query = "SELECT * FROM SolClientes WHERE ciSolC ='" + Convert.ToInt32(cic.Text) + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
                d.OpenCnn();
                SqlDataReader read;
                if (comprobar() == 1)
                {
                    nombc.Text = "";
                    nombc.ForeColor = SystemColors.WindowText;
                    nombc.Font = new Font(nombc.Font, FontStyle.Regular);
                    apec.Text = "";
                    apec.ForeColor = SystemColors.WindowText;
                    apec.Font = new Font(apec.Font, FontStyle.Regular);
                    nitc.Text = "";
                    nitc.ForeColor = SystemColors.WindowText;
                    nitc.Font = new Font(nitc.Font, FontStyle.Regular);
                    dirc.Text = "";
                    dirc.ForeColor = SystemColors.WindowText;
                    dirc.Font = new Font(dirc.Font, FontStyle.Regular);
                    corc.Text = "";
                    corc.ForeColor = SystemColors.WindowText;
                    corc.Font = new Font(corc.Font, FontStyle.Regular);
                    telc.Text = "";
                    telc.ForeColor = SystemColors.WindowText;
                    telc.Font = new Font(telc.Font, FontStyle.Regular);
                    celc.Text = "";
                    celc.ForeColor = SystemColors.WindowText;
                    celc.Font = new Font(celc.Font, FontStyle.Regular);

                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            nombc.Text = read.GetString(2);
                            apec.Text = read.GetString(3);
                            nitc.Text = read.GetInt32(4).ToString();
                            dirc.Text = read.GetString(5);
                            corc.Text = read.GetString(6);
                            telc.Text = read.GetInt32(7).ToString();
                            celc.Text = read.GetInt32(8).ToString();                        
                        }
                        d.CerrarCnn();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        d.CerrarCnn();
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, El Cliente Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cic.Text != "" && cic.Font.Italic == true)
            {
                if (cic.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente a Eliminar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente a Eliminar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cic.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente a Eliminar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de eliminar Cliente.
                if(comprobar()==1)
                {
                    try
                    {    // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "DELETE FROM SolClientes WHERE ciSolC = '"+Convert.ToInt32(cic.Text)+"' ;";

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();
                       
                        Messengers mr = new Messengers();
                        mr.textolb.Text = "Cliente Eliminado";
                        mr.ShowDialog();
                        this.Close();
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

        private void cisolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (cic.Text != "" && cic.Font.Italic == true)
                {
                    cic.Text = "";
                    cic.ForeColor = SystemColors.WindowText;
                    cic.Font = new Font(cic.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    cic.ForeColor = SystemColors.WindowText;
                    cic.Font = new Font(cic.Font, FontStyle.Regular);
                }
            }
        }

        private void nomsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nombc.Text != "" && nombc.Font.Italic == true)
                {
                    nombc.Text = "";
                    nombc.ForeColor = SystemColors.WindowText;
                    nombc.Font = new Font(nombc.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nombc.ForeColor = SystemColors.WindowText;
                    nombc.Font = new Font(nombc.Font, FontStyle.Regular);
                }
            }
        }

        private void apesolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (apec.Text != "" && apec.Font.Italic == true)
                {
                    apec.Text = "";
                    apec.ForeColor = SystemColors.WindowText;
                    apec.Font = new Font(apec.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    apec.ForeColor = SystemColors.WindowText;
                    apec.Font = new Font(apec.Font, FontStyle.Regular);
                }
            }
        }

        private void nitsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nitc.Text != "" && nitc.Font.Italic == true)
                {
                    nitc.Text = "";
                    nitc.ForeColor = SystemColors.WindowText;
                    nitc.Font = new Font(nitc.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nitc.ForeColor = SystemColors.WindowText;
                    nitc.Font = new Font(nitc.Font, FontStyle.Regular);
                }
            }
        }

        private void dirsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (dirc.Text != "" && dirc.Font.Italic == true)
                {
                    dirc.Text = "";
                    dirc.ForeColor = SystemColors.WindowText;
                    dirc.Font = new Font(dirc.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    dirc.ForeColor = SystemColors.WindowText;
                    dirc.Font = new Font(dirc.Font, FontStyle.Regular);
                }
            }
        }

        private void corrsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (corc.Text != "" && corc.Font.Italic == true)
                {
                    corc.Text = "";
                    corc.ForeColor = SystemColors.WindowText;
                    corc.Font = new Font(corc.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    corc.ForeColor = SystemColors.WindowText;
                    corc.Font = new Font(corc.Font, FontStyle.Regular);
                }
            }
        }

        private void telsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (telc.Text != "" && telc.Font.Italic == true)
                {
                    telc.Text = "";
                    telc.ForeColor = SystemColors.WindowText;
                    telc.Font = new Font(telc.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    telc.ForeColor = SystemColors.WindowText;
                    telc.Font = new Font(telc.Font, FontStyle.Regular);
                }
            }
        }

        private void celsolClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (celc.Text != "" && celc.Font.Italic == true)
                {
                    celc.Text = "";
                    celc.ForeColor = SystemColors.WindowText;
                    celc.Font = new Font(celc.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    celc.ForeColor = SystemColors.WindowText;
                    celc.Font = new Font(celc.Font, FontStyle.Regular);
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

        private void corc_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(corc.Text))
            {

            }
            else
            {
                MessageBox.Show("Dirrección de Correo Electrónico No Valida. El Correo Debe Tener El Formato: nombre@dominio.com  Porfavor Seleccione un Correo Electroónico Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                corc.SelectAll();
                corc.Focus();
            }
        }

        private void dirc_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirc.ForeColor = SystemColors.WindowText;
            dirc.Font = new Font(dirc.Font, FontStyle.Regular);
        }

        private void corc_KeyPress(object sender, KeyPressEventArgs e)
        {
            corc.ForeColor = SystemColors.WindowText;
            corc.Font = new Font(corc.Font, FontStyle.Regular);
        }

        private void SolCliente_Load(object sender, EventArgs e)
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
                    depac.Items.Add(Scad);
                }
                d.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);         
            }
        }

        private void depac_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion d = new Conexion();
            string query = "SELECT nombrePro, CodDep FROM Provincia, Departamento WHERE CodDep=codigoDep AND nombreDep= '" + depac.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
            d.OpenCnn();
            SqlDataReader read;

            try
            {
                read = sqlQ.ExecuteReader();
                provc.Items.Clear();
                while (read.Read())
                {
                    String cade = read.GetString(0);
                    provc.Items.Add(cade);
                    id = read.GetString(1);
                }
                d.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }


        private int comprobar()
        {
            int cnt = 0;
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM SolClientes WHERE ciSolC= '" + Convert.ToInt32(cic.Text) + "' ; ";
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
            codUser = CodigoAdmin();
            if ((cic.Text != "" && cic.Font.Italic == true) || nombc.Font.Italic == true || apec.Font.Italic == true || nitc.Font.Italic == true || dirc.Font.Italic == true || corc.Font.Italic == true || telc.Font.Italic == true || celc.Font.Italic == true )
            {
                if (cic.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Ingresar los Datos del Usuario. Caso Contrario dejar en Blanco", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cic.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nombc.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre de Cliente o Identificacion para el Cliente ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nitc.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Contraseña para el Ingreso del Cliente ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //Codigo de guardar usuario.
                if (comprobar() == 0)
                {
                    try
                    { // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "INSERT INTO SolClientes(cisolC, nomSolC, apeSolC, nitSolC, dirSolC, corrSolC, telSolC, celSolC, CodDepaSC, codUsr) VALUES (@ci, @nom, @ape, @nit, @dir, @correo, @tel, @cel, @codd, @codU)";

                        // Creando los parámetros necesarios
                        cmd.Parameters.Add("@ci", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@ape", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@nit", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@dir", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@correo", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@tel", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@cel", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@codU", System.Data.SqlDbType.Int);               

                        // Asignando los valores a los atributos
                        cmd.Parameters["@ci"].Value = int.Parse(cic.Text);
                        cmd.Parameters["@nom"].Value = nombc.Text;
                        cmd.Parameters["@ape"].Value = apec.Text;
                        cmd.Parameters["@nit"].Value = int.Parse(nitc.Text);
                        cmd.Parameters["@dir"].Value = dirc.Text;
                        cmd.Parameters["@correo"].Value = corc.Text;
                        cmd.Parameters["@tel"].Value = int.Parse(telc.Text);
                        cmd.Parameters["@cel"].Value = int.Parse(celc.Text);
                        cmd.Parameters["@codd"].Value = id;
                        cmd.Parameters["@codU"].Value = codUser;

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();
                       
                        Messengers mr = new Messengers();
                        mr.textolb.Text = "Cliente Guardado";
                        mr.ShowDialog();
                        //Thread.Sleep(5000);
                        mr.Close();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR. Al Insertar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            nombc.Text = "";
            nombc.ForeColor = SystemColors.WindowText;
            nombc.Font = new Font(nombc.Font, FontStyle.Regular);
            apec.Text = "";
            apec.ForeColor = SystemColors.WindowText;
            apec.Font = new Font(apec.Font, FontStyle.Regular);
            nitc.Text = "";
            nitc.ForeColor = SystemColors.WindowText;
            nitc.Font = new Font(nitc.Font, FontStyle.Regular);
            dirc.Text = "";
            dirc.ForeColor = SystemColors.WindowText;
            dirc.Font = new Font(dirc.Font, FontStyle.Regular);
            corc.Text = "";
            corc.ForeColor = SystemColors.WindowText;
            corc.Font = new Font(corc.Font, FontStyle.Regular);
            telc.Text = "";
            telc.ForeColor = SystemColors.WindowText;
            telc.Font = new Font(telc.Font, FontStyle.Regular);
            celc.Text = "";
            celc.ForeColor = SystemColors.WindowText;
            celc.Font = new Font(celc.Font, FontStyle.Regular);
            cic.Text = "";
            cic.ForeColor = SystemColors.WindowText;
            cic.Font = new Font(cic.Font, FontStyle.Regular);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            codUser = CodigoAdmin();

            if (cic.Text != "" && cic.Font.Italic == true)
            {
                if (cic.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente a Modificar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente a Modificar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cic.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente a Modificar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de editar Cliente.
                if (comprobar() == 1)
                {
                    try
                    {      // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "UPDATE SolClientes SET ciSolC=@cic, nomSolC=@nomc, apeSolC=@apec, nitSolC=@nitc, dirSolC=@dir, corrSolC=@email, telSolC=@tel, celSolC=@cel, CodDepaSC=@codd, codUsr=@codu  WHERE ciSolC = @cisol ;";

                        cmd.Parameters.Add("@cic", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@nomc", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@apec", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@nitc", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@dir", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@tel", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@cel", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@codd", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@codu", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@cisol", System.Data.SqlDbType.Int);

                        // Asignando los valores a los atributos
                        cmd.Parameters["@cic"].Value = int.Parse(cic.Text);
                        cmd.Parameters["@nomc"].Value = nombc.Text;
                        cmd.Parameters["@apec"].Value = apec.Text;
                        cmd.Parameters["@nitc"].Value = int.Parse(nitc.Text);
                        cmd.Parameters["@dir"].Value = dirc.Text;
                        cmd.Parameters["@email"].Value = corc.Text;
                        cmd.Parameters["@tel"].Value = int.Parse(telc.Text);
                        cmd.Parameters["@cel"].Value = int.Parse(celc.Text);
                        cmd.Parameters["@codd"].Value = id;
                        cmd.Parameters["@codu"].Value = codUser;
                        cmd.Parameters["@cisol"].Value = int.Parse(cic.Text);

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
                    MessageBox.Show("Error, No Existen Registros del Cliente.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


    }
}
