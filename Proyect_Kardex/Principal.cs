using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Proyect_Kardex
{
    public partial class Principal : Form
    {
        ValidacionText mn = new ValidacionText();
        GMarkerGoogle marker;
        GMapOverlay markeroverlay;

        public int Cod = 0;
        public String Nom = "";
        public String NameUser = "";
        public String DirEmp = "";

        DateTime dateday = DateTime.Today;

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
            n.ShowDialog();
        }

        private void verEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerEmpresa a = new VerEmpresa();
            a.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            VerAdmin n = new VerAdmin();
            n.codUser = Cod;
            n.ShowDialog();
        }

        private void usuarioCajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegAdmin mn = new RegAdmin();
            mn.Text = "Datos del Usuario";
            mn.label1.Text = "Registro De Usuarios";
            mn.ShowDialog();
        }

        private void usuarioClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegCliente v = new RegCliente();
            v.ShowDialog();
        }

        private void editarUsuarioCajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUser eu = new EditUser();
            eu.ShowDialog();
        }

        private void editarUsuarioClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCliente ec = new EditCliente();
            ec.ShowDialog();
        }

        private void editarUsuarioProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProveedor ep = new EditProveedor();
            ep.ShowDialog();
        }

        private void buscarci(object sender, KeyPressEventArgs e)
        {
            buscarciUser.ForeColor = SystemColors.WindowText;
            buscarciUser.Font = new Font(buscarciUser.Font, FontStyle.Regular);
        }

        private void insertarCUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarUser bu = new BuscarUser();
            if (buscarciUser.Text != "" && buscarciUser.Font.Italic == true)
            {
                bu.citext.Text = "";
                bu.ShowDialog();
            }
            else if (buscarciUser.Text == "")
            {
                bu.citext.Text = "";
                bu.ShowDialog();
            }
            else
            {
                bu.citext.Text = buscarciUser.Text;
                bu.ShowDialog();
            }
           
        }

        private void eliminarUsuarioCajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelUser du = new DelUser();
            du.ShowDialog();
        }

        private void eliminarUsuarioClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelCliente dc = new DelCliente();
            dc.ShowDialog();
        }

        private void eliminarUsuarioProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelProveedor dp = new DelProveedor();
            dp.ShowDialog();
        }

        private void Userboton_Click(object sender, EventArgs e)
        {
            Registro_Usuario ru = new Registro_Usuario();
            ru.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegEmpresa rem = new RegEmpresa();
            rem.tituloemp.Text = "Configuración De La Empresa";
            rem.ShowDialog();
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

        public void CargarEmpresa()
        {
            Conexion a = new Conexion();
            string query = "SELECT * FROM Empresa; ";

            SqlCommand sqlQ = new SqlCommand(query, a.GetCONN());
            a.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    TSSemp.Text = read2.GetString(1);
                    lbName.Text = read2.GetString(1);
                    DirEmp = read2.GetString(2);
                    lbtel.Text = read2.GetInt32(3).ToString();
                    lbcel.Text = read2.GetInt32(4).ToString();
                    lbfaxs.Text = read2.GetInt32(5).ToString() +" "+ read2.GetInt32(6).ToString();
                    lbcorreo.Text = read2.GetString(7);
                    lbweb.Text = read2.GetString(8);

                    // El campo productImage primero se almacena en un buffer
                    byte[] imageBuffer = (byte[])(read2[9]);
                    byte[] img2 = (byte[])(read2[10]);
                    byte[] img3 = (byte[])(read2[11]);
 
                    // Se crea un MemoryStream a partir de ese buffer                                                            
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                    System.IO.MemoryStream ms2 = new System.IO.MemoryStream(img2);
                    System.IO.MemoryStream ms3 = new System.IO.MemoryStream(img3);

                    logoEmp.BackgroundImage = Image.FromStream(ms);
                    PBanun1.BackgroundImage = Image.FromStream(ms2);
                    PBanun2.BackgroundImage = Image.FromStream(ms3);
                }
                a.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public String GetNameUser(int osc) 
        {
            String res = "";
            Conexion a = new Conexion();
            string query = "SELECT * FROM Usuario; ";

            SqlCommand sqlQ = new SqlCommand(query, a.GetCONN());
            a.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    res = read2.GetString(1) + " " + read2.GetString(2);
                    res = res.ToUpper();
                }
            }
            catch (Exception) { }
            a.CerrarCnn();
            return res;
        }


        public String SacarCadena(String cid) 
        {
            String res = "";
            int posi = cid.IndexOf(";");
            res = cid.Substring(0, posi);
            return res;
        }


        private void Principal_Load(object sender, EventArgs e)
        {
            CargarEmpresa();
            String lt = "";
            String lg = "";

            //Datos para cargar el mapa
            String one = SacarCadena(DirEmp);
            lbdir.Text = one;
            DirEmp = DirEmp.Replace(DirEmp.Substring(0, (DirEmp.IndexOf(";")+1)), "");
            lt = SacarCadena(DirEmp);
            DirEmp = DirEmp.Replace(DirEmp.Substring(0, (DirEmp.IndexOf(";") + 1)), "");
            lg = DirEmp;
            //gMaps
            gMapControl1.DragButton = System.Windows.Forms.MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(Convert.ToDouble(lt), Convert.ToDouble(lg));
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;
            //add marcador
            markeroverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(lt), Convert.ToDouble(lg)), GMarkerGoogleType.red);
            markeroverlay.Markers.Add(marker); 
            //add overlay en el mapa
            gMapControl1.Overlays.Add(markeroverlay);

            //Datos del statusBar
            TSSNameUsr.Text = GetNameUser(Cod);
            TSSdate.Text = dateday.ToString("d");
        }

        private void lbweb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            REV_WebStudio we = new REV_WebStudio();
            we.texturlweb.Text = lbweb.Text;
            we.webBrow.Navigate(lbweb.Text);
            we.ShowDialog();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(e);
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pantallaNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void generadorDeCodigosDeBarrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REV_BarCode re = new REV_BarCode();
            re.ShowDialog();
        }

        private void generadorDeCodigosQRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REV_CodeQr re = new REV_CodeQr();
            re.ShowDialog();
        }

        private void scannerLectorDeCodigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Read_Code_Qr_Bar re = new Read_Code_Qr_Bar();
            re.ShowDialog();
        }

        private void camaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REV_Camera re = new REV_Camera();
            re.ShowDialog();
        }

        private void enviarSMSACorreoElectrónicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REV_SendEmail re = new REV_SendEmail();
            re.ShowDialog();
        }

        private void googleMapsLocalizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GMapsLocal goo = new GMapsLocal();
            goo.ShowDialog();
        }

        private void calculadoraSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora c = new Calculadora();
            c.ShowDialog();
        }

        private void navegadorWebStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REV_WebStudio we = new REV_WebStudio();
            we.ShowDialog();
        }

        private void buscarciUser_Click(object sender, EventArgs e)
        {
            if (buscarciUser.Text != "" && buscarciUser.Font.Italic == true)
            {
                buscarciUser.Text = "";
                buscarciUser.ForeColor = SystemColors.WindowText;
                buscarciUser.Font = new Font(buscarciUser.Font, FontStyle.Regular);
                //textBox1.Font.Italic = false;

            }
            else
            {
                buscarciUser.ForeColor = SystemColors.WindowText;
                buscarciUser.Font = new Font(buscarciUser.Font, FontStyle.Regular);
            }
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeSolicitudesDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Clientes re = new Registro_Clientes();
            re.ShowDialog();
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSolClientes sc = new ShowSolClientes();
            sc.ShowDialog();
        }

        private void registroDeSolicitudesDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSolClientes re = new ReportSolClientes();
            re.ShowDialog();
        }

        private void reporteEstadisticoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportClientes rs = new ReportClientes();
            rs.ShowDialog();
        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Usuario ru = new Registro_Usuario();
            ru.ShowDialog();
        }

        private void reporteDeSolicitudesDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSolUser ss = new ShowSolUser();
            ss.ShowDialog();
        }

        private void reporteDeSolicitudesDeUsuariosDestacadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSolUser sl = new ReportSolUser();
            sl.ShowDialog();
        }

        private void reporteEstadisticoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteUsuarios re = new ReporteUsuarios();
            re.ShowDialog();
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Proveedores rp = new Registro_Proveedores();
            rp.ShowDialog();
        }

        private void editarCuentaDeAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUser ra = new EditUser();
            ra.tituloEdit.Text = "Configuración De Cuenta";
            ra.ciedu.Text = "";
            ra.ciedu.ForeColor = SystemColors.WindowText;
            ra.ciedu.Font = new Font(ra.ciedu.Font, FontStyle.Regular);
            ra.ciedu.Text = Cod.ToString();
            ra.ShowDialog();
        }

        private void usuarioProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegProveedor rp = new RegProveedor();
            rp.ShowDialog();
        }

        private void productoNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductos ap = new AddProductos();
            ap.ShowDialog();
        }

        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProductos ep = new EditProductos();
            ep.ShowDialog();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProductos df = new EditProductos();
            df.label26.Visible = false;
            df.label1.Visible = false;
            df.codprod.Visible = false;
            df.nameprod.Visible = false;
            df.groupBox4.Visible = false;
            df.deleteboton.Visible = true;
            df.tituloprod.Text = "Eliminar Producto";
            df.codbuscprod.Text = "";         
            df.codbuscprod.ForeColor = SystemColors.WindowText;
            df.codbuscprod.Font = new Font(df.codbuscprod.Font, FontStyle.Regular);
            df.Width = 672;
            df.Height = 95;
            df.ShowDialog();
        }

        private void registroDeProductosEnLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Productos reg = new Registro_Productos();
            reg.ShowDialog();
        }

        private void nuevaMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AEEMarca am = new AEEMarca();
            am.ShowDialog();
        }

        private void registroDeMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroMarcas rm = new RegistroMarcas();
            rm.ShowDialog();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AEECategoria ac = new AEECategoria();
            ac.ShowDialog();
        }

        private void nuevaSubCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AEESubCat ass = new AEESubCat();
            ass.ShowDialog();
        }

        private void registroDeCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Categoria rc = new Registro_Categoria();
            rc.ShowDialog();
        }

        private void nuevaMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AEEMedida aem = new AEEMedida();
            aem.ShowDialog();
        }

        private void registroDeMedidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUnidad ru = new RegistroUnidad();
            ru.ShowDialog();
        }

        private void buscarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarProductos bp = new BuscarProductos();
            bp.ShowDialog();
        }

        private void reporteGraficoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphic_Products gp = new Graphic_Products();
            gp.ShowDialog();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            See_Find_Cliente bu = new See_Find_Cliente();
            if (findCtxt.Text != "" && findCtxt.Font.Italic == true)
            {
                bu.citext.Text = "";
                bu.ShowDialog();
            }
            else if (findCtxt.Text == "")
            {
                bu.citext.Text = "";
                bu.ShowDialog();
            }
            else
            {
                bu.citext.Text = findCtxt.Text;
                bu.ShowDialog();
            }
        }

        private void buscarCuentaDeProveedorIngresadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            See_Find_Proveedor bu = new See_Find_Proveedor();

            if (findPtxt.Text != "" && findPtxt.Font.Italic == true)
            {
                bu.citext.Text = "";
                bu.ShowDialog();
            }
            else if (findPtxt.Text == "")
            {
                bu.citext.Text = "";
                bu.ShowDialog();
            }
            else
            {
                bu.citext.Text = findPtxt.Text;
                bu.ShowDialog();
            }
        }

        private void findCtxt_Click(object sender, EventArgs e)
        {
            if (findCtxt.Text != "" && findCtxt.Font.Italic == true)
            {
                findCtxt.Text = "";
                findCtxt.ForeColor = SystemColors.WindowText;
                findCtxt.Font = new Font(findCtxt.Font, FontStyle.Regular);
                //textBox1.Font.Italic = false;

            }
            else
            {
                findCtxt.ForeColor = SystemColors.WindowText;
                findCtxt.Font = new Font(findCtxt.Font, FontStyle.Regular);
            }
            
        }

        private void findCtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            findCtxt.ForeColor = SystemColors.WindowText;
            findCtxt.Font = new Font(findCtxt.Font, FontStyle.Regular);
        }

        private void findPtxt_Click(object sender, EventArgs e)
        {
            if (findPtxt.Text != "" && findPtxt.Font.Italic == true)
            {
                findPtxt.Text = "";
                findPtxt.ForeColor = SystemColors.WindowText;
                findPtxt.Font = new Font(findPtxt.Font, FontStyle.Regular);
                //textBox1.Font.Italic = false;

            }
            else
            {
                findPtxt.ForeColor = SystemColors.WindowText;
                findPtxt.Font = new Font(findPtxt.Font, FontStyle.Regular);
            }
        }

        private void findPtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            findPtxt.ForeColor = SystemColors.WindowText;
            findPtxt.Font = new Font(findPtxt.Font, FontStyle.Regular);
        }


    }
}
