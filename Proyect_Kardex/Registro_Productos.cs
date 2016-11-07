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
    public partial class Registro_Productos : Form
    {
        public Int64 codUser = 0;
        int pos = 0;
        int i = 0;
        public int ContProd = 0;
        public Double total = 0;

        public String res = "";

        public Registro_Productos()
        {
            InitializeComponent();

            toolRegProd.SetToolTip(nuevo, "Agregar Nuevo Producto");
            toolRegProd.SetToolTip(editar, "Editar Producto");
            toolRegProd.SetToolTip(eliminar, "Eliminar Producto");
            toolRegProd.SetToolTip(seeProd, "Ver Producto");
            toolRegProd.SetToolTip(actualizar, "Actualizar Registro de Productos");
            toolRegProd.SetToolTip(print, "Imprimir Registro de Productos");
            toolRegProd.SetToolTip(printview, "PRE-Vista");
            toolRegProd.SetToolTip(save ,"Guardar en Excel");
            toolRegProd.SetToolTip(graficStadis, "Reporte de Productos");
            toolRegProd.SetToolTip(buscarQuick, "Busqueda Rapida de Productos");
            toolRegProd.SetToolTip(buscardet, "Busqueda Detallada de Productos");
            toolRegProd.SetToolTip(gencodbar, "Generar Codigo de Barras");
            toolRegProd.SetToolTip(CodeQR, "Generar Codigo QR");
            toolRegProd.SetToolTip(salir, "Salir");
            toolRegProd.SetToolTip(cantlabel, "Cantidad de Productos");
            toolRegProd.SetToolTip(totallabel, "Valor Total de los Productos");
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            AddProductos ad = new AddProductos();
            ad.ShowDialog();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            EditProductos ed = new EditProductos();
            ed.codbuscprod.Text = "";
            ed.codbuscprod.Text = codUser.ToString();
            ed.codbuscprod.ForeColor = SystemColors.WindowText;
            ed.codbuscprod.Font = new Font(ed.codbuscprod.Font, FontStyle.Regular);
            ed.ShowDialog();
        }

        private void eliminar_Click(object sender, EventArgs e)
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
            df.codbuscprod.Text = codUser.ToString();
            df.codbuscprod.ForeColor = SystemColors.WindowText;
            df.codbuscprod.Font = new Font(df.codbuscprod.Font, FontStyle.Regular);
            df.Width = 672;
            df.Height = 95;
            df.ShowDialog();
        }

        private void buscardet_Click(object sender, EventArgs e)
        {
            BuscarProductos we = new BuscarProductos();
            we.ShowDialog();
        }

        private void buscarQuick_Click(object sender, EventArgs e)
        {
            SearchMensseger sm = new SearchMensseger();
            Conexion r = new Conexion();
            res = sm.value;
            sm.ShowDialog();      
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(sm.value, r.GetCONN());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                regprodtable.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            
        }

        private void gencodbar_Click(object sender, EventArgs e)
        {
            REV_BarCode re = new REV_BarCode();
            re.ShowDialog();
        }


        private void SumarProductos() 
        {
            Conexion r = new Conexion();
            string query = "SELECT SUM(CantProd) FROM Productos ; ";

            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
            SqlDataReader read;
            try
            {
                r.OpenCnn();
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    ContProd = read.GetInt32(0);
                    cantlabel.Text = "" + ContProd + " Und.";
                }
                r.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }
        }

        private void SumarTotal() 
        {
            Conexion r = new Conexion();
            string query = "SELECT SUM(CantProd * PVUProd) FROM Productos ; ";

            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
            SqlDataReader read;
            try
            {
                r.OpenCnn();
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    total = read.GetDouble(0);
                    totallabel.Text = "" + total + " Bs.";
                }
                r.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }
        }


        private void Registro_Productos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
                this.productosTableAdapter.Fill(this.rEV_DataBaseDataSet.Productos);

                SumarProductos();
                SumarTotal();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }

        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.rEV_DataBaseDataSet.Productos);

            SumarProductos();
            SumarTotal();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Export_Excel ex = new Export_Excel();
            ex.ExportarDatosExcel(regprodtable);
        }

        private void regprodtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pos = regprodtable.CurrentRow.Index;
                String valor = "";
                valor = regprodtable[0, pos].Value.ToString();
                codUser = Int64.Parse(valor);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (this.printMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.printDocx.DocumentName = "Preparando Documento...";
                this.printDocx.Print();
                i = 0;
            }
        }

        private void printview_Click(object sender, EventArgs e)
        {
            printPreview.Document = printDocx;
            printPreview.ShowDialog();
            i = 0;
        }

        private void printDocx_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {   //Inicio del encabezado del Documento.
            Conexion r = new Conexion();
            string query = "SELECT * FROM Empresa ; ";
            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
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
                r.OpenCnn();
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

                //Datos de los totales.
                e.Graphics.DrawString("Cantidad de Productos: ", new Font("Lucida Sans", 12), new SolidBrush(Color.Black), 40, 170);
                e.Graphics.DrawString(cantlabel.Text, new Font("Lucida Sans", 14), new SolidBrush(Color.Black), 235, 170);
                e.Graphics.DrawString("Valor Total: ", new Font("Lucida Sans", 12), new SolidBrush(Color.Black), 550, 170);
                e.Graphics.DrawString(totallabel.Text, new Font("Lucida Sans", 14), new SolidBrush(Color.Black), 650, 170);
                //fin totales.

                //Insert DataGrid Print.
                #region Draw Column 1
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10, 200, regprodtable.Columns[0].Width - 45, regprodtable.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10, 200, regprodtable.Columns[0].Width - 45, regprodtable.Rows[0].Height);
                e.Graphics.DrawString(regprodtable.Columns[0].HeaderText, regprodtable.Font, Brushes.Black, new RectangleF(10, 200, regprodtable.Columns[0].Width - 45, regprodtable.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10 + regprodtable.Columns[0].Width - 45, 200, regprodtable.Columns[0].Width, regprodtable.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10 + regprodtable.Columns[0].Width - 45, 200, regprodtable.Columns[0].Width, regprodtable.Rows[0].Height);
                e.Graphics.DrawString(regprodtable.Columns[1].HeaderText, regprodtable.Font, Brushes.Black, new RectangleF(10 + regprodtable.Columns[0].Width - 45, 200, regprodtable.Columns[0].Width, regprodtable.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(65 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width, regprodtable.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 65 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width, regprodtable.Rows[0].Height);
                e.Graphics.DrawString(regprodtable.Columns[10].HeaderText, regprodtable.Font, Brushes.Black, new RectangleF(65 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width, regprodtable.Rows[0].Height), str);
                #endregion

                #region Draw column 4
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(165 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width, regprodtable.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 165 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width, regprodtable.Rows[0].Height);
                e.Graphics.DrawString(regprodtable.Columns[11].HeaderText, regprodtable.Font, Brushes.Black, new RectangleF(165 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width, regprodtable.Rows[0].Height), str);
                #endregion

                #region Draw column 5
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(265 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width, regprodtable.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 265 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width, regprodtable.Rows[0].Height);
                e.Graphics.DrawString(regprodtable.Columns[13].HeaderText, regprodtable.Font, Brushes.Black, new RectangleF(265 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width, regprodtable.Rows[0].Height), str);
                #endregion

                #region Draw column 6
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(365 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width + 10, regprodtable.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 365 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width + 10, regprodtable.Rows[0].Height);
                e.Graphics.DrawString(regprodtable.Columns[14].HeaderText, regprodtable.Font, Brushes.Black, new RectangleF(365 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width + 10, regprodtable.Rows[0].Height), str);
                #endregion

                #region Draw column 7
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(495 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width - 20, regprodtable.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 495 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width - 20, regprodtable.Rows[0].Height);
                e.Graphics.DrawString(regprodtable.Columns[15].HeaderText, regprodtable.Font, Brushes.Black, new RectangleF(495 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width - 20, regprodtable.Rows[0].Height), str);
                #endregion

                #region Draw column 8
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(595 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width - 60, regprodtable.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 595 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width - 60, regprodtable.Rows[0].Height);
                e.Graphics.DrawString(regprodtable.Columns[6].HeaderText, regprodtable.Font, Brushes.Black, new RectangleF(595 + regprodtable.Columns[0].Width, 200, regprodtable.Columns[0].Width - 60, regprodtable.Rows[0].Height), str);
                #endregion

                #region Draw Rows N
                width = 10 + regprodtable.Columns[0].Width;
                height = 200;
                //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
                while (i < regprodtable.Rows.Count)
                {
                    if (height > e.MarginBounds.Height)
                    {
                        height = 200;
                        width = 10;
                        e.HasMorePages = true;
                        return;
                    }

                    height += regprodtable.Rows[i].Height;
                    //Draw Row 1
                    e.Graphics.DrawRectangle(Pens.Black, 10, height, regprodtable.Columns[0].Width - 45, regprodtable.Rows[0].Height);
                    e.Graphics.DrawString(regprodtable.Rows[i].Cells[0].FormattedValue.ToString(), regprodtable.Font, Brushes.Black, new RectangleF(10, height, regprodtable.Columns[0].Width - 45, regprodtable.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, 10 + regprodtable.Columns[0].Width - 45, height, regprodtable.Columns[0].Width - 50, regprodtable.Rows[0].Height);
                    e.Graphics.DrawString(regprodtable.Rows[i].Cells[1].Value.ToString(), regprodtable.Font, Brushes.Black, new RectangleF(10 + regprodtable.Columns[0].Width - 45, height, regprodtable.Columns[0].Width - 50, regprodtable.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 65 + regprodtable.Columns[0].Width, height, regprodtable.Columns[0].Width - 50, regprodtable.Rows[0].Height);
                    e.Graphics.DrawString(regprodtable.Rows[i].Cells[10].Value.ToString(), regprodtable.Font, Brushes.Black, new RectangleF(65 + regprodtable.Columns[0].Width, height, regprodtable.Columns[0].Width - 50, regprodtable.Rows[0].Height), str);
                    //Draw Row 4
                    e.Graphics.DrawRectangle(Pens.Black, 165 + regprodtable.Columns[0].Width, height, regprodtable.Columns[0].Width - 50, regprodtable.Rows[0].Height);
                    e.Graphics.DrawString(regprodtable.Rows[i].Cells[11].Value.ToString(), regprodtable.Font, Brushes.Black, new RectangleF(165 + regprodtable.Columns[0].Width, height, regprodtable.Columns[0].Width - 50, regprodtable.Rows[0].Height), str);
                    //Draw Row 5
                    e.Graphics.DrawRectangle(Pens.Black, 265 + regprodtable.Columns[0].Width, height, regprodtable.Columns[0].Width - 50, regprodtable.Rows[0].Height);
                    e.Graphics.DrawString(regprodtable.Rows[i].Cells[13].Value.ToString(), regprodtable.Font, Brushes.Black, new RectangleF(265 + regprodtable.Columns[0].Width, height, regprodtable.Columns[0].Width - 50, regprodtable.Rows[0].Height), str);
                    //Draw Row 6
                    e.Graphics.DrawRectangle(Pens.Black, 365 + regprodtable.Columns[0].Width, height, regprodtable.Columns[0].Width - 20, regprodtable.Rows[0].Height);
                    e.Graphics.DrawString(regprodtable.Rows[i].Cells[14].Value.ToString(), regprodtable.Font, Brushes.Black, new RectangleF(365 + regprodtable.Columns[0].Width, height, regprodtable.Columns[0].Width - 20, regprodtable.Rows[0].Height), str);
                    //Draw Row 7
                    e.Graphics.DrawRectangle(Pens.Black, 495 + regprodtable.Columns[0].Width, height, regprodtable.Columns[0].Width - 50, regprodtable.Rows[0].Height);
                    e.Graphics.DrawString(regprodtable.Rows[i].Cells[15].Value.ToString(), regprodtable.Font, Brushes.Black, new RectangleF(495 + regprodtable.Columns[0].Width, height, regprodtable.Columns[0].Width - 50, regprodtable.Rows[0].Height), str);
                    //Draw Row 8
                    e.Graphics.DrawRectangle(Pens.Black, 595 + regprodtable.Columns[0].Width, height, regprodtable.Columns[0].Width - 60, regprodtable.Rows[0].Height);
                    e.Graphics.DrawString(regprodtable.Rows[i].Cells[6].Value.ToString(), regprodtable.Font, Brushes.Black, new RectangleF(595 + regprodtable.Columns[0].Width, height, regprodtable.Columns[0].Width - 60, regprodtable.Rows[0].Height), str);

                    width += regprodtable.Columns[0].Width;
                    i++;
                }

                #endregion

                r.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerProductos vp = new VerProductos();
            vp.codUser = codUser;
            vp.ShowDialog();
        }

        private void CodeQR_Click(object sender, EventArgs e)
        {
            REV_CodeQr re = new REV_CodeQr();
            re.ShowDialog();
        }

        private void graficStadis_Click(object sender, EventArgs e)
        {
            Graphic_Products gp = new Graphic_Products();
            gp.ShowDialog();
        }

    }
}
