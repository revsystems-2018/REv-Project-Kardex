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
    public partial class Report_Factura : Form
    {
        Conexion fu = new Conexion();
        public String coddet = "790644210/12/2016 21:15:26";
        public int codUser = 7906442;
        public String cant = "";
        public String totalp = "";

        int pos = 0;
        String codprod = "0";
        int i = 0;

        public Report_Factura()
        {
            InitializeComponent();

            toolTipF.SetToolTip(seeProd, "Mostrar Cliente");
            toolTipF.SetToolTip(btnFechas, "Mostrar Facturas de Fecha Caducadas");
            toolTipF.SetToolTip(actualizar, "Actualizar");
            toolTipF.SetToolTip(print, "Imprimir Detalle de Venta");
            toolTipF.SetToolTip(printview, "PRE-Vista");
            toolTipF.SetToolTip(save, "Exportar a Excel");
            toolTipF.SetToolTip(salir, "Salir");
            toolTipF.SetToolTip(cantlabel, "Cantidad de Productos");
            toolTipF.SetToolTip(txtTotalV, "Total Vendido");
        }

        public int GetIDUsuario(int idu)
        {
            int res = 0;
            Conexion r = new Conexion();
            string buscar = "SELECT * FROM Usuario WHERE ciUser= '" + idu + "' ; ";
            try
            {
                r.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, r.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    res = fb.GetInt32(15);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }
            r.CerrarCnn();
            return res;
        }


        private void Report_Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Facturas' Puede moverla o quitarla según sea necesario.
            this.facturasTableAdapter.Fill(this.rEV_DataBaseDataSet.Facturas);

            try
            {
                if (GetIDUsuario(codUser) == 2)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Facturas WHERE codVenF = '" + coddet + "'; ", fu.GetCONN());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataFactuVenta.DataSource = dt;
                    UpdateTC();
                }
                else 
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Facturas ; ", fu.GetCONN());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataFactuVenta.DataSource = dt;
                    UpdateTCA();
                }
            }
            catch (Exception) { }
        }

        public void UpdateTCA()
        {
            Conexion r = new Conexion();
            string query = "SELECT SUM(num_Prod), SUM(pago_Cliente) FROM REV_Ventas ; ";

            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
            r.OpenCnn();
            SqlDataReader read;
            try
            {
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    totalp = read.GetDouble(1).ToString();
                    cant = read.GetInt32(0).ToString();
                    txtTotalV.Text = "" + totalp + " Bs.";
                    cantlabel.Text = "" + cant + " Und.";
                }
                r.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateTC()
        {
            Conexion r = new Conexion();
            string query = "SELECT num_Prod, pago_Cliente FROM REV_Ventas WHERE id_Venta = '" + coddet + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
            r.OpenCnn();
            SqlDataReader read;
            try
            {
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    totalp = read.GetDouble(1).ToString();
                    cant = read.GetInt32(0).ToString();
                    txtTotalV.Text = "" + totalp + " Bs.";
                    cantlabel.Text = "" + cant + " Und.";
                }
                r.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Export_Excel er = new Export_Excel();
            er.ExportarDatosExcel(dataFactuVenta);
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetIDUsuario(codUser) == 2)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Facturas WHERE codVenF = '" + coddet + "'; ", fu.GetCONN());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataFactuVenta.DataSource = dt;
                    UpdateTC();
                }
                else
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Facturas ; ", fu.GetCONN());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataFactuVenta.DataSource = dt;
                    UpdateTCA();
                }
            }
            catch (Exception) { }
        }

        private void dataFactuVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pos = dataFactuVenta.CurrentRow.Index;
                String valor = "";
                valor = dataFactuVenta[4, pos].Value.ToString();
                if (valor == null || valor == "")
                {
                    codprod = "0";
                }
                else 
                {
                    codprod = valor; 
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public int GetIDCliente(String gus) 
        {
            int res = 0;
            Conexion r = new Conexion();
            string buscar = "SELECT * FROM Clientes WHERE nitCliente = '" + gus + "' ; ";
            try
            {
                r.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, r.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    res = fb.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. En el Obtenedor. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }
            r.CerrarCnn();
            return res;
        }


        private void seeProd_Click(object sender, EventArgs e)
        {
            if (codprod == "0")
            {
                MessageBox.Show("El Codigo del Cliente No Se Encuentra Registrado en la Base de Datos.\nSeleccione la factura del cliente a mostrar.\nPor lo contrario no es posible mostrar los datos de dicho cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                VerCliente vc = new VerCliente();
                vc.codUser = GetIDCliente(codprod);
                vc.ShowDialog();
            }
        }

        private void printview_Click(object sender, EventArgs e)
        {
            printPreview.Document = printDocx;
            printPreview.ShowDialog();
            i = 0;
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

        private void printDocx_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Inicio del encabezado del Documento.
            Conexion r = new Conexion();
            string query = "SELECT * FROM Empresa ; ";
            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
            r.OpenCnn();
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
                e.Graphics.DrawString("Reporte de Facturas", new Font("Lucida Sans", 18), new SolidBrush(Color.DarkBlue), img.Width + 300, 60);
                //fin Encabezado Documento.

                //Datos de los totales.
                e.Graphics.DrawString("Cantidad de Productos: ", new Font("Lucida Sans", 12), new SolidBrush(Color.Black), 40, 170);
                e.Graphics.DrawString(cantlabel.Text, new Font("Lucida Sans", 14), new SolidBrush(Color.Black), 235, 170);
                e.Graphics.DrawString("Valor Total: ", new Font("Lucida Sans", 12), new SolidBrush(Color.Black), 550, 170);
                e.Graphics.DrawString(txtTotalV.Text, new Font("Lucida Sans", 14), new SolidBrush(Color.Black), 650, 170);
                //fin totales.

                //Insert DataGrid Print.
                #region Draw Column 1
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height);
                e.Graphics.DrawString(dataFactuVenta.Columns[0].HeaderText, dataFactuVenta.Font, Brushes.Black, new RectangleF(10, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10 + dataFactuVenta.Columns[0].Width-30, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10 + dataFactuVenta.Columns[0].Width-30, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height);
                e.Graphics.DrawString(dataFactuVenta.Columns[1].HeaderText, dataFactuVenta.Font, Brushes.Black, new RectangleF(10 + dataFactuVenta.Columns[0].Width-30, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(100 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 100 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height);
                e.Graphics.DrawString(dataFactuVenta.Columns[3].HeaderText, dataFactuVenta.Font, Brushes.Black, new RectangleF(100 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height), str);
                #endregion

                #region Draw column 4
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(185 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 185 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height);
                e.Graphics.DrawString(dataFactuVenta.Columns[4].HeaderText, dataFactuVenta.Font, Brushes.Black, new RectangleF(185 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height), str);
                #endregion

                #region Draw column 5
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(265 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 265 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height);
                e.Graphics.DrawString(dataFactuVenta.Columns[6].HeaderText, dataFactuVenta.Font, Brushes.Black, new RectangleF(265 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width, dataFactuVenta.Rows[0].Height), str);
                #endregion

                #region Draw column 6
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(345 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width + 10, dataFactuVenta.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 345 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width + 10, dataFactuVenta.Rows[0].Height);
                e.Graphics.DrawString(dataFactuVenta.Columns[8].HeaderText, dataFactuVenta.Font, Brushes.Black, new RectangleF(345 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width + 10, dataFactuVenta.Rows[0].Height), str);
                #endregion

                #region Draw column 7
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(465 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width + 10, dataFactuVenta.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 465 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width + 10, dataFactuVenta.Rows[0].Height);
                e.Graphics.DrawString(dataFactuVenta.Columns[9].HeaderText, dataFactuVenta.Font, Brushes.Black, new RectangleF(465 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width + 10, dataFactuVenta.Rows[0].Height), str);
                #endregion

                #region Draw column 8
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(585 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width - 45, dataFactuVenta.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 585 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width - 45, dataFactuVenta.Rows[0].Height);
                e.Graphics.DrawString(dataFactuVenta.Columns[10].HeaderText, dataFactuVenta.Font, Brushes.Black, new RectangleF(585 + dataFactuVenta.Columns[0].Width, 200, dataFactuVenta.Columns[0].Width - 45, dataFactuVenta.Rows[0].Height), str);
                #endregion

                #region Draw Rows N
                width = 10 + dataFactuVenta.Columns[0].Width;
                height = 200;
                //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
                while (i < dataFactuVenta.Rows.Count)
                {
                    if (height > e.MarginBounds.Height)
                    {
                        height = 200;
                        width = 10;
                        e.HasMorePages = true;
                        return;
                    }

                    height += dataFactuVenta.Rows[i].Height;
                    //Draw Row 1
                    e.Graphics.DrawRectangle(Pens.Black, 10, height, dataFactuVenta.Columns[0].Width - 30, dataFactuVenta.Rows[0].Height);
                    e.Graphics.DrawString(dataFactuVenta.Rows[i].Cells[0].FormattedValue.ToString(), dataFactuVenta.Font, Brushes.Black, new RectangleF(10, height, dataFactuVenta.Columns[0].Width - 30, dataFactuVenta.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, 10 + dataFactuVenta.Columns[0].Width-30, height, dataFactuVenta.Columns[0].Width - 30, dataFactuVenta.Rows[0].Height);
                    e.Graphics.DrawString(dataFactuVenta.Rows[i].Cells[1].Value.ToString(), dataFactuVenta.Font, Brushes.Black, new RectangleF(10 + dataFactuVenta.Columns[0].Width-30, height, dataFactuVenta.Columns[0].Width - 30, dataFactuVenta.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 100 + dataFactuVenta.Columns[0].Width, height, dataFactuVenta.Columns[0].Width - 65, dataFactuVenta.Rows[0].Height);
                    e.Graphics.DrawString(dataFactuVenta.Rows[i].Cells[3].Value.ToString(), dataFactuVenta.Font, Brushes.Black, new RectangleF(100 + dataFactuVenta.Columns[0].Width, height, dataFactuVenta.Columns[0].Width - 65, dataFactuVenta.Rows[0].Height), str);
                    //Draw Row 4
                    e.Graphics.DrawRectangle(Pens.Black, 185 + dataFactuVenta.Columns[0].Width, height, dataFactuVenta.Columns[0].Width - 70, dataFactuVenta.Rows[0].Height);
                    e.Graphics.DrawString(dataFactuVenta.Rows[i].Cells[4].Value.ToString(), dataFactuVenta.Font, Brushes.Black, new RectangleF(185 + dataFactuVenta.Columns[0].Width, height, dataFactuVenta.Columns[0].Width - 70, dataFactuVenta.Rows[0].Height), str);
                    //Draw Row 5
                    e.Graphics.DrawRectangle(Pens.Black, 265 + dataFactuVenta.Columns[0].Width, height, dataFactuVenta.Columns[0].Width - 70, dataFactuVenta.Rows[0].Height);
                    e.Graphics.DrawString(dataFactuVenta.Rows[i].Cells[6].Value.ToString(), dataFactuVenta.Font, Brushes.Black, new RectangleF(265 + dataFactuVenta.Columns[0].Width, height, dataFactuVenta.Columns[0].Width - 70, dataFactuVenta.Rows[0].Height), str);
                    //Draw Row 6
                    e.Graphics.DrawRectangle(Pens.Black, 345 + dataFactuVenta.Columns[0].Width, height, dataFactuVenta.Columns[0].Width - 30, dataFactuVenta.Rows[0].Height);
                    e.Graphics.DrawString(dataFactuVenta.Rows[i].Cells[8].Value.ToString(), dataFactuVenta.Font, Brushes.Black, new RectangleF(345 + dataFactuVenta.Columns[0].Width, height, dataFactuVenta.Columns[0].Width - 30, dataFactuVenta.Rows[0].Height), str);
                    //Draw Row 7
                    e.Graphics.DrawRectangle(Pens.Black, 465 + dataFactuVenta.Columns[0].Width, height, dataFactuVenta.Columns[0].Width - 30, dataFactuVenta.Rows[0].Height);
                    e.Graphics.DrawString(dataFactuVenta.Rows[i].Cells[9].Value.ToString(), dataFactuVenta.Font, Brushes.Black, new RectangleF(465 + dataFactuVenta.Columns[0].Width, height, dataFactuVenta.Columns[0].Width - 30, dataFactuVenta.Rows[0].Height), str);
                    //Draw Row 8
                    e.Graphics.DrawRectangle(Pens.Black, 585 + dataFactuVenta.Columns[0].Width, height, dataFactuVenta.Columns[0].Width - 45, dataFactuVenta.Rows[0].Height);
                    e.Graphics.DrawString(dataFactuVenta.Rows[i].Cells[10].Value.ToString(), dataFactuVenta.Font, Brushes.Black, new RectangleF(585 + dataFactuVenta.Columns[0].Width, height, dataFactuVenta.Columns[0].Width - 45, dataFactuVenta.Rows[0].Height), str);

                    width += dataFactuVenta.Columns[0].Width;
                    i++;
                }

                #endregion

                r.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.UtcNow;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Facturas WHERE FLEmision < '" + dt + "'; ", fu.GetCONN());
            DataTable der = new DataTable();
            sda.Fill(der);
            dataFactuVenta.DataSource = dt;
        }


    }
}
