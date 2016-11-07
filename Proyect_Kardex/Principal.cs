using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect_Kardex
{
    public partial class Principal : Form
    {
        ValidacionText mn = new ValidacionText();

        public int Cod = 0;
        public String Nom = "";
        public String NameUser = ""; 

        public Principal()
        {
            InitializeComponent();
            smshelp.SetToolTip(this.Userboton,"Usuarios");
            smshelp.SetToolTip(this.provBoton,"Proveedores");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login es = new Login();
            es.Show();
            this.Hide(); 
        }

        private void agregarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegEmpresa n = new RegEmpresa();
            n.Show();
        }

        private void verEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerEmpresa a = new VerEmpresa();
            a.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            VerAdmin n = new VerAdmin();
            n.Show();
        }

        private void usuarioCajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegAdmin mn = new RegAdmin();
            mn.Text = "Datos del Usuario";
            mn.label1.Text = "Registro De Usuarios";
            mn.Show();
        }

        private void usuarioClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegCliente v = new RegCliente();
            v.Show();
        }

        private void editarUsuarioCajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUser eu = new EditUser();
            eu.Show();
        }

        private void editarUsuarioClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCliente ec = new EditCliente();
            ec.Show();
        }

        private void editarUsuarioProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProveedor ep = new EditProveedor();
            ep.Show();
        }

        private void buscarci(object sender, KeyPressEventArgs e)
        {
            mn.soloNumeros(e);
        }

        private void insertarCUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarUser bu = new BuscarUser();

            if (buscarciUser.Text == "")
            {
                bu.Width = 560;
                bu.Height = 77; //360
                bu.foto.Visible = false;
                bu.nom.Visible = false;
                bu.apellido.Visible = false;
                bu.ci.Visible = false;
                bu.label5.Visible = false;
                bu.nivel.Visible = false;
                bu.label6.Visible = false;
                bu.user.Visible = false;
                bu.label9.Visible = false;
                bu.cargo.Visible = false;
                bu.depa.Visible = false;
                bu.dir.Visible = false;
                bu.prov.Visible = false;
                bu.label4.Visible = false;
                bu.correo.Visible = false;
                bu.label15.Visible = false;
                bu.tel.Visible = false;
                bu.label16.Visible = false;
                bu.cel.Visible = false;
                bu.label17.Visible = false;
                bu.fax.Visible = false;            
                bu.Show();
            }
            else{
                bu.Width = 517;
                bu.Height = 360;
                bu.citext.Text =""+ buscarciUser.Text;
                bu.salir.Visible = false;
                bu.cancel.Visible = false;
                bu.Show();          
            }
        }

        private void eliminarUsuarioCajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelUser du = new DelUser();
            du.Show();
        }

        private void eliminarUsuarioClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelCliente dc = new DelCliente();
            dc.Show();
        }

        private void eliminarUsuarioProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelProveedor dp = new DelProveedor();
            dp.Show();
        }

        private void Userboton_Click(object sender, EventArgs e)
        {
            Registro_Usuario ru = new Registro_Usuario();
            ru.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ReportSolClientes nms = new ReportSolClientes();
            nms.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegEmpresa rem = new RegEmpresa();
            rem.tituloemp.Text = "Configuración De La Empresa";
            rem.Show();
        }

        private void solicitudesDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSolUser ru = new ReportSolUser();
            ru.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Registro_Clientes rc = new Registro_Clientes();
            rc.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            PedidosCompras pc = new PedidosCompras();
            pc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProductos ad = new AddProductos();
            ad.ShowDialog();
        }

        private void provBoton_Click(object sender, EventArgs e)
        {
            Registro_Proveedores re = new Registro_Proveedores();
            re.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            TSSname.Text = Name;
        }
    }
}
