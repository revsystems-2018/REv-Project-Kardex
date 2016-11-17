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

namespace Proyect_Kardex
{
    public partial class Principal_UserCajero : Form
    {
        public int Cod = 7906442;
        public String Nom = "";
        public String NameUser = ""; 

        public int codCate = 0;
        public String codSub = "";
        public String stock = "";
        DateTime dateday = DateTime.Today;
        public String res = "";

        int pos = 0;
        Int64 codUser = 0;
        int i = 0;


        public Principal_UserCajero()
        {
            InitializeComponent();

            UsertoolTip1.SetToolTip(ClientesButton, "Clientes de la Empresa");
            UsertoolTip1.SetToolTip(Ventasbutton, "Ventas");
            UsertoolTip1.SetToolTip(Calcubutton, "Calculadora");
            UsertoolTip1.SetToolTip(Printbutton, "Actualizar Registro de Productos");
            UsertoolTip1.SetToolTip(Reportbutton, "Reporte de Ventas Realizadas");
            UsertoolTip1.SetToolTip(Devolbutton, "Devoluciones");
            UsertoolTip1.SetToolTip(Buscarbutton, "Buscar Producto");
            UsertoolTip1.SetToolTip(Salirbutton, "Salir");
            UsertoolTip1.SetToolTip(Logobutton, "Logotipo de la Empresa");
            UsertoolTip1.SetToolTip(comboCate, "Asignar Categoria");
            UsertoolTip1.SetToolTip(comboSubCate, "Asignar Subcategoria");
            UsertoolTip1.SetToolTip(comboUbica, "Ubicacion Almacen Principal");
            UsertoolTip1.SetToolTip(comboArticulos, "Asignar Articulos");
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
                    //depare.Items.Add(Scad);

                    // El campo productImage primero se almacena en un buffer
                    byte[] imageBuffer = (byte[])(read2[9]);
                    // Se crea un MemoryStream a partir de ese buffer                                                            
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                    Logobutton.BackgroundImage = Image.FromStream(ms);                    
                }
                a.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                a.CerrarCnn();
            }
        }

        public void CargarCategoria() 
        {
            Conexion s = new Conexion();
            string query = "SELECT * FROM Categorias; ";

            SqlCommand sqlQ = new SqlCommand(query, s.GetCONN());
            s.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    String Scad = read2.GetString(1);
                    comboCate.Items.Add(Scad);
                }
                s.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                s.CerrarCnn();
            }
        }


        private void Principal_UserCajero_Load(object sender, EventArgs e)
        {
            TSSname.Text = NameUser;
            CargarEmpresa();
            CargarCategoria();
            TSSdate.Text = dateday.ToString("d");
            comboArticulos.SelectedIndex = 0;
            comboCate.SelectedIndex = 0;
            comboSubCate.SelectedIndex = 0;
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.rEV_DataBaseDataSet.Productos);

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboArticulos.SelectedIndex == 0)
            {
                
            }
            else if (comboArticulos.SelectedIndex == 1)
            {
                stock = "= 0";
            }
            else if (comboArticulos.SelectedIndex == 2) 
            {
                stock = "<= 10";
            }
            else if (comboArticulos.SelectedIndex == 3)
            {
                stock = ">= 10";
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe ac = new AcercaDe();
            ac.ShowDialog();
        }

        private void closetool_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            Login g = new Login();
            g.Show();
            this.Hide();
        }

        private void verEmp_Click(object sender, EventArgs e)
        {
            VerEmpresa ve = new VerEmpresa();
            ve.ShowDialog();
        }

        private void verUser_Click(object sender, EventArgs e)
        {
            VerAdmin va = new VerAdmin();
            va.codUser = Cod;
            va.ShowDialog();
        }

        private void novotool_Click(object sender, EventArgs e)
        {
            SolCliente sc = new SolCliente();       
            sc.ShowDialog();
        }

        private void edittool_Click(object sender, EventArgs e)
        {
            SolCliente sep = new SolCliente();
            sep.label1.Text = "Editar Cliente";
            sep.buscaredboton.Visible = true;
            sep.button1.Visible = false;
            sep.elimLb.Visible = false;
            sep.saveLb.Visible = true;
            sep.saveboton.Visible = true;
          
            sep.ShowDialog();
        }

        private void deltool_Click(object sender, EventArgs e)
        {
            SolCliente sed = new SolCliente();
            sed.label1.Text = "Eliminar Cliente";
            sed.buscaredboton.Visible = true;
            sed.button1.Visible = true;
            sed.elimLb.Visible = true;
            sed.saveLb.Visible = false;
            sed.saveboton.Visible = false;
            sed.nombc.Enabled = false;
            sed.apec.Enabled = false;
            sed.nitc.Enabled = false;
            sed.dirc.Enabled = false;
            sed.depac.Enabled = false;
            sed.provc.Enabled = false;
            sed.corc.Enabled = false;
            sed.telc.Enabled = false;
            sed.celc.Enabled = false;
            sed.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculadora ca = new Calculadora();
            ca.ShowDialog();
        }

        private void SolClientool_Click(object sender, EventArgs e)
        {
            ShowSolClientes sc = new ShowSolClientes();
            sc.codUser = Cod;
            sc.ShowDialog();
        }

        private void reportooldes_Click(object sender, EventArgs e)
        {
            ShowSolClientes rv = new ShowSolClientes();
            rv.codUser = 0;
            rv.nuevo.Enabled = false;
            rv.nuevo.BackgroundImage = global::Proyect_Kardex.Properties.Resources.novob;
            rv.editar.Enabled = false;
            rv.editar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editdocumentob;
            rv.eliminar.Enabled = false;
            rv.eliminar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_deleteb;
            rv.titulosol.Enabled = false;
            rv.buscarcic.Enabled = false;
            rv.searchci.Visible = false;
            rv.ShowDialog();
        }

        private void regCliEmp_Click(object sender, EventArgs e)
        {
            Registro_Clientes rc = new Registro_Clientes();
            rc.CodUsr = 0;
            rc.nuevo.Enabled = false;
            rc.nuevo.BackgroundImage = global::Proyect_Kardex.Properties.Resources.novob;
            rc.editar.Enabled = false;
            rc.editar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editdocumentob;
            rc.eliminar.Enabled = false;
            rc.eliminar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_deleteb;
            rc.botonselect.Enabled = false;
            rc.botonselect.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Selectb;
            rc.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Registro_Clientes rc = new Registro_Clientes();
            rc.CodUsr = 0;
            rc.nuevo.Enabled = false;
            rc.nuevo.BackgroundImage = global::Proyect_Kardex.Properties.Resources.novob;
            rc.editar.Enabled = false;
            rc.editar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editdocumentob;
            rc.eliminar.Enabled = false;
            rc.eliminar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_deleteb;
            rc.botonselect.Enabled = false;
            rc.botonselect.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Selectb;
            rc.ShowDialog();
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

        private void button7_Click(object sender, EventArgs e)
        {
            BuscarProductos bp = new BuscarProductos();
            bp.ShowDialog();
        }

        private void Ventasbutton_Click(object sender, EventArgs e)
        {
            Ventas ve = new Ventas();
            ve.codUsr = Cod;
            ve.ShowDialog();
        }

        private void Devolbutton_Click(object sender, EventArgs e)
        {
            Devoluciones de = new Devoluciones();
            de.codUsr = Cod;
            de.ShowDialog();
        }

        private void cerrarcomplete(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolUser sw = new SolUser();
            sw.ShowDialog();
        }

        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolUser sdf = new SolUser();
            sdf.label1.Text = "Modificar Usuario";
            sdf.buscaredboton.Visible = true;
            MessageBox.Show("Ingresar el Carnet de Identidad del Usuario Solicitado a Modificar.", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            sdf.ShowDialog();
            
        }

        private void abrirListaDeMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroMarcas rm = new RegistroMarcas();
            rm.nuevo.Enabled = false;
            rm.nuevo.BackgroundImage = global::Proyect_Kardex.Properties.Resources.novob;
            rm.editar.Enabled = false;
            rm.editar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editdocumentob;
            rm.eliminar.Enabled = false;
            rm.eliminar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_deleteb;
            rm.btnSelect.Enabled = false;
            rm.btnSelect.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Selectb;
            rm.ShowDialog();
        }

        private void registroDeCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Categoria re = new Registro_Categoria();
            re.nuevo.Enabled = false;
            re.nuevo.BackgroundImage = global::Proyect_Kardex.Properties.Resources.novob;
            re.editar.Enabled = false;
            re.editar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editdocumentob;
            re.eliminar.Enabled = false;
            re.eliminar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_deleteb;
            re.selectboton.Enabled = false;
            re.selectboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Selectb;
            re.btnSubCat.Enabled = false;
            re.btnSubCat.BackgroundImage = global::Proyect_Kardex.Properties.Resources.subcat_settings_B;
            re.ShowDialog();
        }

        private void tipoDeUnidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUnidad re = new RegistroUnidad();
            re.ShowDialog();
        }

        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarProductos bv = new BuscarProductos();
            bv.ShowDialog();
        }

        private void comboCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion d = new Conexion();
            string query = "SELECT nameSubC, codCat FROM SubCategorias, Categorias WHERE catCod=codCat AND DescCat= '" + comboCate.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
            d.OpenCnn();
            SqlDataReader read;

            try
            {                
                read = sqlQ.ExecuteReader();
                comboSubCate.Items.Clear();
                comboSubCate.Items.Add("Todo");
                while (read.Read())
                {
                    String cade = read.GetString(0);
                    comboSubCate.Items.Add(cade);
                    codCate = read.GetInt32(1);
                }
                d.CerrarCnn();
            }
            catch (Exception)
            {
                comboSubCate.Items.Add("Todo");
                d.CerrarCnn();
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (this.printMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.printDocx.DocumentName = "Preparando Documento...";
                this.printDocx.Print();
                i = 0;
            }
        }

        private void listproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pos = listproduct.CurrentRow.Index;
                String valor = "";
                valor = listproduct[0, pos].Value.ToString();
                codUser = Int64.Parse(valor);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (codUser == 0)
            {
                MessageBox.Show("ERROR, No se Ha Seleccionado un Producto a Mostrar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                VerProductos vp = new VerProductos();
                vp.codUser = codUser;
                vp.ShowDialog();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            Export_Excel ex = new Export_Excel();
            ex.ExportarDatosExcel(listproduct);
        }

        private void printview_Click(object sender, EventArgs e)
        {
            printPreview.Document = printDocx;
            printPreview.ShowDialog();
            i = 0;
        }

        private void printDocx_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {   //Inicio del encabezado del Documento.
            Conexion f = new Conexion();
            string query = "SELECT * FROM Empresa ; ";
            SqlCommand sqlQ = new SqlCommand(query, f.GetCONN());
            f.OpenCnn();
            SqlDataReader read;
            Image img = null; //Variables Guardar los Datos de la Empresa.
            String name = "";
            String nit = "";
            String tel = "";
            String cel = "";
            String dir = "";
            String web = "";

            int width = 0;
            int height = 0;
            int x = 0;
            int y = 0;
            int rowheight = 0;
            int columnwidth = 0;

            StringFormat str = new StringFormat();
            str.Alignment = StringAlignment.Near;
            str.LineAlignment = StringAlignment.Center;
            str.Trimming = StringTrimming.EllipsisCharacter;
            Pen p = new Pen(Color.Black, 2.5f);

            try
            {
                read = sqlQ.ExecuteReader();

                while (read.Read())
                { // El campo productImage primero se almacena en un buffer
                    byte[] imageBuffer = (byte[])(read[9]);
                    name = read.GetString(1);
                    nit = read.GetString(0);
                    tel = read.GetInt32(3).ToString();
                    cel = read.GetInt32(4).ToString();
                    dir = read.GetString(2);
                    web = read.GetString(8);

                    if (imageBuffer == null || read[9] == null)
                    {
                        img = null;
                    }
                    else
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        img = Image.FromStream(ms); //Logotipo
                    }
                }        //Datos de la Empresa.
                e.Graphics.DrawImage(img, 20, 20, img.Width, img.Height);
                e.Graphics.DrawString(name, new Font("Lucida Sans", 12), new SolidBrush(Color.Black), img.Width + 30, 20);
                e.Graphics.DrawString(nit, new Font("Lucida Sans", 12), new SolidBrush(Color.Black), img.Width + 30, 50);
                e.Graphics.DrawString(tel, new Font("Lucida Sans", 12), new SolidBrush(Color.Black), img.Width + 30, 80);
                e.Graphics.DrawString(cel, new Font("Lucida Sans", 12), new SolidBrush(Color.Black), img.Width + 130, 80);
                e.Graphics.DrawString(dir, new Font("Lucida Sans", 12), new SolidBrush(Color.Black), img.Width + 30, 100);
                e.Graphics.DrawString(web, new Font("Lucida Sans", 12), new SolidBrush(Color.Black), img.Width + 30, 130);
                e.Graphics.DrawString("Registro de Productos", new Font("Lucida Sans", 18), new SolidBrush(Color.DarkBlue), img.Width + 400, 60);
                //fin Encabezado Documento.

                //Insert DataGrid Print.
                #region Draw Column 1
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10, 200, listproduct.Columns[0].Width - 45, listproduct.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10, 200, listproduct.Columns[0].Width - 45, listproduct.Rows[0].Height);
                e.Graphics.DrawString(listproduct.Columns[0].HeaderText, listproduct.Font, Brushes.Black, new RectangleF(10, 200, listproduct.Columns[0].Width - 45, listproduct.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10 + listproduct.Columns[0].Width - 45, 200, listproduct.Columns[0].Width, listproduct.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10 + listproduct.Columns[0].Width - 45, 200, listproduct.Columns[0].Width, listproduct.Rows[0].Height);
                e.Graphics.DrawString(listproduct.Columns[1].HeaderText, listproduct.Font, Brushes.Black, new RectangleF(10 + listproduct.Columns[0].Width - 45, 200, listproduct.Columns[0].Width, listproduct.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(65 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width, listproduct.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 65 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width, listproduct.Rows[0].Height);
                e.Graphics.DrawString(listproduct.Columns[10].HeaderText, listproduct.Font, Brushes.Black, new RectangleF(65 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width, listproduct.Rows[0].Height), str);
                #endregion

                #region Draw column 4
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(165 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width, listproduct.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 165 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width, listproduct.Rows[0].Height);
                e.Graphics.DrawString(listproduct.Columns[11].HeaderText, listproduct.Font, Brushes.Black, new RectangleF(165 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width, listproduct.Rows[0].Height), str);
                #endregion

                #region Draw column 5
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(265 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width, listproduct.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 265 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width, listproduct.Rows[0].Height);
                e.Graphics.DrawString(listproduct.Columns[13].HeaderText, listproduct.Font, Brushes.Black, new RectangleF(265 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width, listproduct.Rows[0].Height), str);
                #endregion

                #region Draw column 6
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(365 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width - 50, listproduct.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 365 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width-50, listproduct.Rows[0].Height);
                e.Graphics.DrawString(listproduct.Columns[14].HeaderText, listproduct.Font, Brushes.Black, new RectangleF(365 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width-50, listproduct.Rows[0].Height), str);
                #endregion

                #region Draw column 7
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(445 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width - 20, listproduct.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 445 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width - 20, listproduct.Rows[0].Height);
                e.Graphics.DrawString(listproduct.Columns[15].HeaderText, listproduct.Font, Brushes.Black, new RectangleF(445 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width - 20, listproduct.Rows[0].Height), str);
                #endregion

                #region Draw column 8
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(545 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width - 60, listproduct.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 545 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width - 60, listproduct.Rows[0].Height);
                e.Graphics.DrawString(listproduct.Columns[6].HeaderText, listproduct.Font, Brushes.Black, new RectangleF(545 + listproduct.Columns[0].Width, 200, listproduct.Columns[0].Width - 60, listproduct.Rows[0].Height), str);
                #endregion

                #region Draw Rows N
                width = 10 + listproduct.Columns[0].Width;
                height = 200;
                //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
                while (i < listproduct.Rows.Count)
                {
                    if (height > e.MarginBounds.Height)
                    {
                        height = 200;
                        width = 10;
                        e.HasMorePages = true;
                        return;
                    }

                    height += listproduct.Rows[i].Height;
                    //Draw Row 1
                    e.Graphics.DrawRectangle(Pens.Black, 10, height, listproduct.Columns[0].Width - 45, listproduct.Rows[0].Height);
                    e.Graphics.DrawString(listproduct.Rows[i].Cells[0].FormattedValue.ToString(), listproduct.Font, Brushes.Black, new RectangleF(10, height, listproduct.Columns[0].Width - 45, listproduct.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, 10 + listproduct.Columns[0].Width - 45, height, listproduct.Columns[0].Width - 80, listproduct.Rows[0].Height);
                    e.Graphics.DrawString(listproduct.Rows[i].Cells[1].Value.ToString(), listproduct.Font, Brushes.Black, new RectangleF(10 + listproduct.Columns[0].Width - 45, height, listproduct.Columns[0].Width - 80, listproduct.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 65 + listproduct.Columns[0].Width, height, listproduct.Columns[0].Width-80, listproduct.Rows[0].Height);
                    e.Graphics.DrawString(listproduct.Rows[i].Cells[10].Value.ToString(), listproduct.Font, Brushes.Black, new RectangleF(65 + listproduct.Columns[0].Width, height, listproduct.Columns[0].Width-80, listproduct.Rows[0].Height), str);
                    //Draw Row 4
                    e.Graphics.DrawRectangle(Pens.Black, 165 + listproduct.Columns[0].Width, height, listproduct.Columns[0].Width -80, listproduct.Rows[0].Height);
                    e.Graphics.DrawString(listproduct.Rows[i].Cells[11].Value.ToString(), listproduct.Font, Brushes.Black, new RectangleF(165 + listproduct.Columns[0].Width, height, listproduct.Columns[0].Width-80, listproduct.Rows[0].Height), str);
                    //Draw Row 5
                    e.Graphics.DrawRectangle(Pens.Black, 265 + listproduct.Columns[0].Width, height, listproduct.Columns[0].Width - 80, listproduct.Rows[0].Height);
                    e.Graphics.DrawString(listproduct.Rows[i].Cells[13].Value.ToString(), listproduct.Font, Brushes.Black, new RectangleF(265 + listproduct.Columns[0].Width, height, listproduct.Columns[0].Width - 80, listproduct.Rows[0].Height), str);
                    //Draw Row 6
                    e.Graphics.DrawRectangle(Pens.Black, 365 + listproduct.Columns[0].Width, height, listproduct.Columns[0].Width - 100, listproduct.Rows[0].Height);
                    e.Graphics.DrawString(listproduct.Rows[i].Cells[14].Value.ToString(), listproduct.Font, Brushes.Black, new RectangleF(365 + listproduct.Columns[0].Width, height, listproduct.Columns[0].Width - 100, listproduct.Rows[0].Height), str);
                    //Draw Row 7
                    e.Graphics.DrawRectangle(Pens.Black, 445 + listproduct.Columns[0].Width, height, listproduct.Columns[0].Width - 80, listproduct.Rows[0].Height);
                    e.Graphics.DrawString(listproduct.Rows[i].Cells[15].Value.ToString(), listproduct.Font, Brushes.Black, new RectangleF(445 + listproduct.Columns[0].Width, height, listproduct.Columns[0].Width - 80, listproduct.Rows[0].Height), str);
                    //Draw Row 8
                    e.Graphics.DrawRectangle(Pens.Black, 545 + listproduct.Columns[0].Width, height, listproduct.Columns[0].Width - 60, listproduct.Rows[0].Height);
                    e.Graphics.DrawString(listproduct.Rows[i].Cells[6].Value.ToString(), listproduct.Font, Brushes.Black, new RectangleF(545 + listproduct.Columns[0].Width, height, listproduct.Columns[0].Width - 60, listproduct.Rows[0].Height), str);

                    width += listproduct.Columns[0].Width;
                    i++;
                }

                #endregion

                f.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f.CerrarCnn();
            }
        }

        private void Updatebutton_Click_1(object sender, EventArgs e)
        {
            Conexion g = new Conexion();         
            DataTable dt = new DataTable();
            SqlDataAdapter sda;
            String sql;

            if(comboCate.SelectedIndex == 0 && comboSubCate.SelectedIndex == 0 && comboArticulos.SelectedIndex == 0)
            {
                sql = "SELECT * FROM Productos ;";
                sda = new SqlDataAdapter(sql, g.GetCONN());
                sda.Fill(dt);
                listproduct.DataSource = dt;
            }
            else if (comboCate.SelectedIndex == 0 && comboSubCate.SelectedIndex == 0 && comboArticulos.SelectedIndex != 0)
            {
                sql = "SELECT * FROM Productos WHERE CantProd " + stock + " ;";
                sda = new SqlDataAdapter(sql, g.GetCONN());
                sda.Fill(dt);
                listproduct.DataSource = dt;
            }
            else if (comboCate.SelectedIndex != 0 && comboSubCate.SelectedIndex == 0 && comboArticulos.SelectedIndex != 0) 
            {
                sql = "SELECT * FROM Productos WHERE cateCod = "+codCate+" AND CantProd "+stock+" ;";
                sda = new SqlDataAdapter(sql, g.GetCONN());
                sda.Fill(dt);
                listproduct.DataSource = dt;
            }
            else if (comboCate.SelectedIndex != 0 && comboSubCate.SelectedIndex != 0 && comboArticulos.SelectedIndex == 0)
            {
                sql = "SELECT * FROM Productos WHERE cateCod = " + codCate + " AND subCod = '" + codSub + "' ;";
                sda = new SqlDataAdapter(sql, g.GetCONN());
                sda.Fill(dt);
                listproduct.DataSource = dt;
            }
            else 
            {
                sql = "SELECT * FROM Productos WHERE cateCod = " + codCate + " AND subCod = '" + codSub + "' AND CantProd " + stock + " ;";
                sda = new SqlDataAdapter(sql, g.GetCONN());
                sda.Fill(dt);
                listproduct.DataSource = dt;
            }
        }

        private void comboSubCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion h = new Conexion();
            string query = "SELECT CodSubC FROM SubCategorias WHERE nameSubC = '" + comboSubCate.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, h.GetCONN());
            h.OpenCnn();
            SqlDataReader read;

            try
            {
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {                  
                    codSub = read.GetString(0);
                }
                h.CerrarCnn();
            }
            catch (Exception) { h.CerrarCnn(); }
        }

        private void configuser_Click(object sender, EventArgs e)
        {
            Conexion f = new Conexion();
            if (Cod == 0)
            {
                MessageBox.Show("Atención.\nUsted No Tiene Codigo de Ingreso.\nFavor de Reiniciar el Software.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EditUser ed = new EditUser();
                ed.tituloEdit.Text = "Configuración De Cuenta";
                ed.regboton.Visible = false;
                ed.Reglabel.Visible = false;
                ed.ciedu.Text = Cod.ToString();

                MessageBox.Show("Puede Proceder con la Configuración; Cargando los Datos, Precionando el Boton Buscar.", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                string query = "SELECT * FROM Usuario WHERE ciUser ='" + Cod + "' ; ";
                SqlCommand sqlQ = new SqlCommand(query, f.GetCONN());
                f.OpenCnn();
                SqlDataReader read;

                    ed.cius.Text = "";
                    ed.cius.ForeColor = SystemColors.WindowText;
                    ed.cius.Font = new Font(ed.cius.Font, FontStyle.Regular);
                    ed.nameus.Text = "";
                    ed.nameus.ForeColor = SystemColors.WindowText;
                    ed.nameus.Font = new Font(ed.nameus.Font, FontStyle.Regular);
                    ed.apelus.Text = "";
                    ed.apelus.ForeColor = SystemColors.WindowText;
                    ed.apelus.Font = new Font(ed.apelus.Font, FontStyle.Regular);
                    ed.nomedus.Text = "";
                    ed.nomedus.ForeColor = SystemColors.WindowText;
                    ed.nomedus.Font = new Font(ed.nomedus.Font, FontStyle.Regular);
                    ed.fotous.Text = "";
                    ed.fotous.ForeColor = SystemColors.WindowText;
                    ed.fotous.Font = new Font(ed.fotous.Font, FontStyle.Regular);
                    ed.corredu.Text = "";
                    ed.corredu.ForeColor = SystemColors.WindowText;
                    ed.corredu.Font = new Font(ed.corredu.Font, FontStyle.Regular);
                    ed.cargoedus.Text = "";
                    ed.cargoedus.ForeColor = SystemColors.WindowText;
                    ed.cargoedus.Font = new Font(ed.cargoedus.Font, FontStyle.Regular);
                    ed.teledu.Text = "";
                    ed.teledu.ForeColor = SystemColors.WindowText;
                    ed.teledu.Font = new Font(ed.teledu.Font, FontStyle.Regular);
                    ed.celedu.Text = "";
                    ed.celedu.ForeColor = SystemColors.WindowText;
                    ed.celedu.Font = new Font(ed.celedu.Font, FontStyle.Regular);
                    ed.faxedu.Text = "";
                    ed.faxedu.ForeColor = SystemColors.WindowText;
                    ed.faxedu.Font = new Font(ed.faxedu.Font, FontStyle.Regular);
                    ed.diredu.Text = "";
                    ed.diredu.ForeColor = SystemColors.WindowText;
                    ed.diredu.Font = new Font(ed.diredu.Font, FontStyle.Regular);

                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            ed.cius.Text = read.GetInt32(0).ToString();
                            ed.nameus.Text = read.GetString(1);
                            ed.apelus.Text = read.GetString(2);
                            ed.nomedus.Text = read.GetString(3);
                            ed.passedus.Text = read.GetString(4);
                            ed.confpass.Text = read.GetString(4);
                            ed.diredu.Text = read.GetString(5);
                            ed.cargoedus.Text = read.GetString(7);
                            ed.corredu.Text = read.GetString(14);
                            ed.teledu.Text = read.GetInt32(10).ToString();
                            ed.celedu.Text = read.GetInt32(11).ToString();
                            ed.faxedu.Text = read.GetInt32(12).ToString();
                            ed.dia.SelectedItem = read.GetString(9).Substring(0, 2);
                            ed.mes.SelectedItem = read.GetString(9).Substring(3, 2);
                            ed.anno.SelectedItem = read.GetString(9).Substring(6, 4);
                            ed.nivelesus.SelectedItem = read.GetString(6);
                            ed.depaedu.SelectedItem = ed.GetDepa(read.GetString(16));

                            // El campo productImage primero se almacena en un buffer
                            byte[] imageBuffer = (byte[])(read[13]);
                            // Se crea un MemoryStream a partir de ese buffer                        

                            if (imageBuffer == null || read[13] == null)
                            {
                                ed.fotoUser.Image = null;
                            }
                            else
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                                ed.fotoUser.Image = Image.FromStream(ms);
                            }

                            if (read.GetString(8) == "Masculino")
                            {
                                ed.sexMax.Checked = true;
                                ed.sexFem.Checked = false;
                            }
                            else
                            {
                                ed.sexFem.Checked = true;
                                ed.sexMax.Checked = false;
                            }
                        }
                        f.CerrarCnn();
                    }
                    catch (Exception)
                    { f.CerrarCnn(); }
                    ed.ShowDialog();
            }
         }

        private void registroDeSolicitudDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSolUser sc = new ShowSolUser();
            sc.codUser = Cod;
            Conexion g = new Conexion();
            System.Data.SqlClient.SqlDataAdapter asd = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM SolUser WHERE codUsr = '" + codUser + "' ;", g.GetCONN());
            DataTable dt = new DataTable();
            asd.Fill(dt);
            sc.dataGridUsr.DataSource = dt;
            sc.ShowDialog();
        }

        private void registroDeMedidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUnidad re = new RegistroUnidad();
            re.nuevo.Enabled = false;
            re.nuevo.BackgroundImage = global::Proyect_Kardex.Properties.Resources.novob;
            re.editar.Enabled = false;
            re.editar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editdocumentob;
            re.eliminar.Enabled = false;
            re.eliminar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_deleteb;
            re.selectboton.Enabled = false;
            re.selectboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Selectb;
            re.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (codUser == 0)
            {
                MessageBox.Show("ERROR, No se Ha Seleccionado un Producto a Mostrar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                VerProductos vp = new VerProductos();
                vp.codUser = codUser;
                vp.ShowDialog();
            }
        }

        private void actualizarRegistroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexion h = new Conexion();
            DataTable dt = new DataTable();
            SqlDataAdapter sda;
            String sql;

            if (comboCate.SelectedIndex == 0 && comboSubCate.SelectedIndex == 0 && comboArticulos.SelectedIndex == 0)
            {
                sql = "SELECT * FROM Productos ;";
                sda = new SqlDataAdapter(sql, h.GetCONN());
                sda.Fill(dt);
                listproduct.DataSource = dt;
            }
            else if (comboCate.SelectedIndex == 0 && comboSubCate.SelectedIndex == 0 && comboArticulos.SelectedIndex != 0)
            {
                sql = "SELECT * FROM Productos WHERE CantProd " + stock + " ;";
                sda = new SqlDataAdapter(sql, h.GetCONN());
                sda.Fill(dt);
                listproduct.DataSource = dt;
            }
            else if (comboCate.SelectedIndex != 0 && comboSubCate.SelectedIndex == 0 && comboArticulos.SelectedIndex != 0)
            {
                sql = "SELECT * FROM Productos WHERE cateCod = " + codCate + " AND CantProd " + stock + " ;";
                sda = new SqlDataAdapter(sql, h.GetCONN());
                sda.Fill(dt);
                listproduct.DataSource = dt;
            }
            else if (comboCate.SelectedIndex != 0 && comboSubCate.SelectedIndex != 0 && comboArticulos.SelectedIndex == 0)
            {
                sql = "SELECT * FROM Productos WHERE cateCod = " + codCate + " AND subCod = '" + codSub + "' ;";
                sda = new SqlDataAdapter(sql, h.GetCONN());
                sda.Fill(dt);
                listproduct.DataSource = dt;
            }
            else
            {
                sql = "SELECT * FROM Productos WHERE cateCod = " + codCate + " AND subCod = '" + codSub + "' AND CantProd " + stock + " ;";
                sda = new SqlDataAdapter(sql, h.GetCONN());
                sda.Fill(dt);
                listproduct.DataSource = dt;
            }
        }

        private void exportarRegistroDeProductosAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export_Excel ex = new Export_Excel();
            ex.ExportarDatosExcel(listproduct);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Graphic_Products gf = new Graphic_Products();
            gf.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SearchMensseger sm = new SearchMensseger();
            Conexion q = new Conexion();
            res = sm.value;
            sm.ShowDialog();
            try
            {              
                SqlDataAdapter sda = new SqlDataAdapter(sm.value, q.GetCONN());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listproduct.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void vistaPreviaDeImpresionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreview.Document = printDocx;
            printPreview.ShowDialog();
            i = 0;
        }

        private void imprimirReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.printMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.printDocx.DocumentName = "Preparando Documento...";
                this.printDocx.Print();
                i = 0;
            }
        }

        private void stockMinimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Conexion w = new Conexion();
            SqlDataAdapter sda;
            String sql;
            sql = "SELECT * FROM Productos WHERE CantProd <= SMinProd ;";
            sda = new SqlDataAdapter(sql, w.GetCONN());
            sda.Fill(dt);
            listproduct.DataSource = dt;
        }

        private void stockMaximoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Conexion r = new Conexion();
            SqlDataAdapter sda;
            String sql;
            sql = "SELECT * FROM Productos WHERE CantProd >= SMaxProd ;";
            sda = new SqlDataAdapter(sql, r.GetCONN());
            sda.Fill(dt);
            listproduct.DataSource = dt;
        }

        private void stockInexistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Conexion t = new Conexion();
            SqlDataAdapter sda;
            String sql;
            sql = "SELECT * FROM Productos WHERE CantProd <= SMinProd OR CantProd <= SMinProd+10 ;";
            sda = new SqlDataAdapter(sql, t.GetCONN());
            sda.Fill(dt);
            listproduct.DataSource = dt;
        }

        private void economicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Conexion r = new Conexion();
            SqlDataAdapter sda;
            String sql;
            sql = "SELECT * FROM Productos WHERE PVUProd <= 100.0 ;";
            sda = new SqlDataAdapter(sql, r.GetCONN());
            sda.Fill(dt);
            listproduct.DataSource = dt;
        }

        private void altosPreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Conexion r = new Conexion();
            SqlDataAdapter sda;
            String sql;
            sql = "SELECT * FROM Productos WHERE PVUProd >= 100.0 ;";
            sda = new SqlDataAdapter(sql, r.GetCONN());
            sda.Fill(dt);
            listproduct.DataSource = dt;
        }

        private void sinVencimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Conexion r = new Conexion();
            SqlDataAdapter sda;
            String sql;
            sql = "SELECT * FROM Productos WHERE fnProd = NULL ;";
            sda = new SqlDataAdapter(sql, r.GetCONN());
            sda.Fill(dt);
            listproduct.DataSource = dt;
        }

        private void productosNuevosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Conexion r = new Conexion();
            SqlDataAdapter sda;
            String sql;
            sql = "SELECT * FROM Productos WHERE EstadoProd = 'Nuevo' ;";
            sda = new SqlDataAdapter(sql, r.GetCONN());
            sda.Fill(dt);
            listproduct.DataSource = dt;
        }

        private void productosDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Conexion r = new Conexion();
            SqlDataAdapter sda;
            String sql;
            sql = "SELECT * FROM Productos WHERE EstadoProd = 'Activo' ;";
            sda = new SqlDataAdapter(sql, r.GetCONN());
            sda.Fill(dt);
            listproduct.DataSource = dt;
        }

        private void productosInactivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Conexion r = new Conexion();
            SqlDataAdapter sda;
            String sql;
            sql = "SELECT * FROM Productos WHERE EstadoProd = 'Inactivo' ;";
            sda = new SqlDataAdapter(sql, r.GetCONN());
            sda.Fill(dt);
            listproduct.DataSource = dt;
        }

        private void productosSuspendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Conexion r = new Conexion();
            SqlDataAdapter sda;
            String sql;
            sql = "SELECT * FROM Productos WHERE EstadoProd = 'Suspendido' ;";
            sda = new SqlDataAdapter(sql, r.GetCONN());
            sda.Fill(dt);
            listproduct.DataSource = dt;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {            
            DataTable dt = new DataTable();
            Conexion r = new Conexion();
            SqlDataAdapter sda;
            String sql;
            sql = "SELECT * FROM Productos WHERE fnProd <= GETDATE() ;";
            sda = new SqlDataAdapter(sql, r.GetCONN());
            sda.Fill(dt);
            listproduct.DataSource = dt;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Conexion r = new Conexion();
            SqlDataAdapter sda;
            String sql;
            sql = "SELECT * FROM Productos WHERE EstadoProd = 'Promoción' ;";
            sda = new SqlDataAdapter(sql, r.GetCONN());
            sda.Fill(dt);
            listproduct.DataSource = dt;
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

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            REV_Camera re = new REV_Camera();
            re.ShowDialog();
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

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            REV_SendEmail re = new REV_SendEmail();
            re.ShowDialog();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            EditVentasDetFact de = new EditVentasDetFact();
            de.codUsr = Cod;
            de.ShowDialog();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            Registro_Ventas re = new Registro_Ventas();
            re.codUser = Cod;
            re.ShowDialog();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            List_Ventas zz = new List_Ventas();
            zz.codUser = Cod;
            zz.ShowDialog();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            Report_DetalleVenta dv = new Report_DetalleVenta();
            dv.ShowDialog();
        }

        private void realizarDevoluciónDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devoluciones de = new Devoluciones();
            de.codUsr = Cod;
            de.ShowDialog();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            Report_Devolucion de = new Report_Devolucion();
            de.ShowDialog();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Factura de = new Report_Factura();
            de.ShowDialog();
        }

        private void reportesDeVentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Graphic_Ventas vd = new Graphic_Ventas();
            vd.CodUser = Cod;
            vd.ShowDialog();
        }

        private void Reportbutton_Click(object sender, EventArgs e)
        {
            Graphic_Ventas vd = new Graphic_Ventas();
            vd.CodUser = Cod;
            vd.ShowDialog();
        }


    }
}
