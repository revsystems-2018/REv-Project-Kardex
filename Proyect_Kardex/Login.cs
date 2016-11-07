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
using System.Data.SqlClient;

namespace Proyect_Kardex
{
    public partial class Login : Form
    {
        Conexion c = new Conexion();

        public int codci = 0;
        public String nameUser = ""; 
        public String nom = "";

        public Login()
        {
            Thread tiempo = new Thread(pantalla);
            tiempo.Start();
            Thread.Sleep(8000);
            InitializeComponent();
            tiempo.Abort();

            toolInicio.SetToolTip(addusermore,"Crear Nueva Cuenta de Usuario");
            toolInicio.SetToolTip(usertext,"Introducir Nombre de Usuario");
            toolInicio.SetToolTip(passtext,"Introducir Contraseña de Usuario");
            toolInicio.SetToolTip(iniboton,"Ingresar");
            toolInicio.SetToolTip(salirboton, "Salir");
        }

        public void pantalla() { Application.Run(new loading()); }

        private void button3_Click(object sender, EventArgs e)
        {
            SolUser s1 = new SolUser();
            s1.Show();
        }

        private void salirboton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iniboton_Click(object sender, EventArgs e)
        {
            c = new Conexion();
            c.Comando("SELECT * FROM Usuario WHERE nuUsuario = '"+usertext.Text+"' AND contraUser = '"+passtext.Text+"' ; ");
            SqlDataReader lee;
            c.OpenCnn();
            lee = c.LeerDatos();
            int cont = 0;
            String id = "";

            while(lee.Read())
            {
                cont = cont + 1;
                id = lee.GetInt32(15).ToString();
                codci = lee.GetInt32(0);
                nom = lee.GetString(1);
                nameUser = lee.GetString(3);
            }
            
            if (cont == 1) {              

                if (id == "1")
                {
                    Principal e1 = new Principal();
                    e1.Cod = codci;
                    e1.Nom = nom;
                    e1.NameUser = nameUser;
                    e1.Show();
                    this.Hide();
                    c.CerrarCnn();
                }
                else
                {
                    Principal_UserCajero e2 = new Principal_UserCajero();
                    e2.Cod = codci;
                    e2.Nom = nom;
                    e2.NameUser = nameUser;
                    e2.Show();
                    this.Hide();
                    c.CerrarCnn();
                } 
            }
            else if (cont > 1)
            {
                MessageBox.Show("ERROR. El Usuario A sido Duplicado, Contacte Con el Administrador.", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passtext.Text = "";
                //c.CerrarCnn();
            }
            else {
                MessageBox.Show("ERROR. El Usuario No Existe, Intente Nuevamente.", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passtext.Text = "";
                //c.CerrarCnn();
            }
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pressenterpass(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                c = new Conexion();
                c.Comando("SELECT * FROM Usuario WHERE nuUsuario = '" + usertext.Text + "' AND contraUser = '" + passtext.Text + "' ; ");
                SqlDataReader lee;
                c.OpenCnn();
                lee = c.LeerDatos();
                int cont = 0;
                String id = "";

                while (lee.Read())
                {
                    cont = cont + 1;
                    id = lee.GetInt32(15).ToString();
                    codci = lee.GetInt32(0);
                    nom = lee.GetString(1);
                    nameUser = lee.GetString(3);
                }

                if (cont == 1)
                {

                    if (id == "1")
                    {
                        Principal e1 = new Principal();
                        e1.Cod = codci;
                        e1.Nom = nom;
                        e1.NameUser = nameUser;
                        e1.Show();
                        this.Hide();
                        c.CerrarCnn();
                    }
                    else
                    {
                        Principal_UserCajero e2 = new Principal_UserCajero();
                        e2.Cod = codci;
                        e2.Nom = nom;
                        e2.NameUser = nameUser;
                        e2.Show();
                        this.Hide();
                        c.CerrarCnn();
                    }
                }
                else if (cont > 1)
                {
                    MessageBox.Show("ERROR. El Usuario A sido Duplicado, Contacte Con el Administrador.", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passtext.Text = "";
                }
                else
                {
                    MessageBox.Show("ERROR. El Usuario No Existe, Intente Nuevamente.", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passtext.Text = "";
                }

            }

        }

        private void nameuserClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (usertext.Text != "" && usertext.Font.Italic == true)
                {
                    usertext.Text = "";
                    usertext.ForeColor = SystemColors.WindowText;
                    usertext.Font = new Font(usertext.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    usertext.ForeColor = SystemColors.WindowText;
                    usertext.Font = new Font(usertext.Font, FontStyle.Regular);
                }
            }
        }

        private void nameuserpress(object sender, KeyPressEventArgs e)
        {
            usertext.ForeColor = SystemColors.WindowText;
            usertext.Font = new Font(usertext.Font, FontStyle.Regular);
        }


    }

}
