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
    public partial class List_DetalleVenta : Form
    {
        Conexion fu = new Conexion();
        public String coddet = "79064429/28/2016 00:00:00";
        public Int64 codP = 0;
        Int64 codprod = 0;

        int pos = 0;
        int i = 0;

        public List_DetalleVenta()
        {
            InitializeComponent();

            toolTipDet.SetToolTip(seeProd, "Mostrar Producto");
            toolTipDet.SetToolTip(btnlistV, "Mostrar Venta");
            toolTipDet.SetToolTip(actualizar, "Actualizar");
            toolTipDet.SetToolTip(print, "Imprimir Detalle de Venta");
            toolTipDet.SetToolTip(printview, "PRE-Vista");
            toolTipDet.SetToolTip(save, "Exportar a Excel");
            toolTipDet.SetToolTip(salir, "Salir");
            toolTipDet.SetToolTip(cantlabel, "Cantidad de Productos");
            toolTipDet.SetToolTip(txtTotalV, "Total Vendido");
        }

        private void List_DetalleVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Detalle_Venta' Puede moverla o quitarla según sea necesario.
            this.detalle_VentaTableAdapter.Fill(this.rEV_DataBaseDataSet.Detalle_Venta);

            try
            {
                if (codP > 0)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Detalle_Venta WHERE id_prod = '" + codP + "'; ", fu.GetCONN());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataDetVenta.DataSource = dt;
                    UpdateTC();
                }
                else 
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Detalle_Venta ; ", fu.GetCONN());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataDetVenta.DataSource = dt;
                    UpdateTC();
                }
            }
            catch (Exception) { }

        }

        public void UpdateTC()
        {
            int res = 0;
            Double ttal = 0;
            foreach (DataGridViewRow row in dataDetVenta.Rows)
            {
                res = res + Convert.ToInt32(row.Cells[2].Value);
                ttal = ttal + Convert.ToDouble(row.Cells[6].Value);
            }

            txtTotalV.Text = "" + ttal + " Bs.";
            cantlabel.Text = "" + res + " Und.";
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seeProd_Click(object sender, EventArgs e)
        {
            VerProductos vp = new VerProductos();
            vp.codUser = codprod;
            vp.ShowDialog();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Export_Excel es = new Export_Excel();
            es.ExportarDatosExcel(dataDetVenta);
        }

        private void dataDetVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pos = dataDetVenta.CurrentRow.Index;
                String valor = "";
                valor = dataDetVenta[0, pos].Value.ToString();
                coddet = dataDetVenta[7, pos].Value.ToString();
                codprod = Int64.Parse(valor);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (codP > 0)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Detalle_Venta WHERE id_prod = '" + codP + "'; ", fu.GetCONN());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataDetVenta.DataSource = dt;
                    UpdateTC();
                }
                else
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Detalle_Venta ; ", fu.GetCONN());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataDetVenta.DataSource = dt;
                    UpdateTC();
                }
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List_Ventas lv = new List_Ventas();
            lv.codUser = 0;

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM REV_Ventas id_Venta = '"+coddet+"'; ", fu.GetCONN());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lv.regprodtable.DataSource = dt;
            lv.ShowDialog();
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
                e.Graphics.DrawString("Reporte de Detalle en Venta", new Font("Lucida Sans", 18), new SolidBrush(Color.DarkBlue), img.Width + 320, 60);
                //fin Encabezado Documento.

                //Datos de los totales.
                e.Graphics.DrawString("Cantidad de Productos: ", new Font("Lucida Sans", 12), new SolidBrush(Color.Black), 40, 170);
                e.Graphics.DrawString(cantlabel.Text, new Font("Lucida Sans", 14), new SolidBrush(Color.Black), 235, 170);
                e.Graphics.DrawString("Valor Total: ", new Font("Lucida Sans", 12), new SolidBrush(Color.Black), 550, 170);
                e.Graphics.DrawString(txtTotalV.Text, new Font("Lucida Sans", 14), new SolidBrush(Color.Black), 650, 170);
                //fin totales.

                //Insert DataGrid Print.
                #region Draw Column 1
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(70, 200, dataDetVenta.Columns[0].Width - 45, dataDetVenta.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 70, 200, dataDetVenta.Columns[0].Width - 45, dataDetVenta.Rows[0].Height);
                e.Graphics.DrawString(dataDetVenta.Columns[0].HeaderText, dataDetVenta.Font, Brushes.Black, new RectangleF(70, 200, dataDetVenta.Columns[0].Width - 45, dataDetVenta.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(70 + dataDetVenta.Columns[0].Width - 45, 200, dataDetVenta.Columns[0].Width, dataDetVenta.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 70 + dataDetVenta.Columns[0].Width - 45, 200, dataDetVenta.Columns[0].Width, dataDetVenta.Rows[0].Height);
                e.Graphics.DrawString(dataDetVenta.Columns[1].HeaderText, dataDetVenta.Font, Brushes.Black, new RectangleF(70 + dataDetVenta.Columns[0].Width - 45, 200, dataDetVenta.Columns[0].Width, dataDetVenta.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(125 + dataDetVenta.Columns[0].Width, 200, dataDetVenta.Columns[0].Width, dataDetVenta.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 125 + dataDetVenta.Columns[0].Width, 200, dataDetVenta.Columns[0].Width, dataDetVenta.Rows[0].Height);
                e.Graphics.DrawString(dataDetVenta.Columns[2].HeaderText, dataDetVenta.Font, Brushes.Black, new RectangleF(125 + dataDetVenta.Columns[0].Width, 200, dataDetVenta.Columns[0].Width, dataDetVenta.Rows[0].Height), str);
                #endregion

                #region Draw column 4
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(205 + dataDetVenta.Columns[0].Width, 200, dataDetVenta.Columns[0].Width, dataDetVenta.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 205 + dataDetVenta.Columns[0].Width, 200, dataDetVenta.Columns[0].Width, dataDetVenta.Rows[0].Height);
                e.Graphics.DrawString(dataDetVenta.Columns[3].HeaderText, dataDetVenta.Font, Brushes.Black, new RectangleF(205 + dataDetVenta.Columns[0].Width, 200, dataDetVenta.Columns[0].Width, dataDetVenta.Rows[0].Height), str);
                #endregion

                #region Draw column 5
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(285 + dataDetVenta.Columns[0].Width, 200, dataDetVenta.Columns[0].Width, dataDetVenta.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 285 + dataDetVenta.Columns[0].Width, 200, dataDetVenta.Columns[0].Width, dataDetVenta.Rows[0].Height);
                e.Graphics.DrawString(dataDetVenta.Columns[6].HeaderText, dataDetVenta.Font, Brushes.Black, new RectangleF(285 + dataDetVenta.Columns[0].Width, 200, dataDetVenta.Columns[0].Width, dataDetVenta.Rows[0].Height), str);
                #endregion

                #region Draw column 6
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(365 + dataDetVenta.Columns[0].Width, 200, dataDetVenta.Columns[0].Width + 10, dataDetVenta.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 365 + dataDetVenta.Columns[0].Width, 200, dataDetVenta.Columns[0].Width + 10, dataDetVenta.Rows[0].Height);
                e.Graphics.DrawString(dataDetVenta.Columns[4].HeaderText, dataDetVenta.Font, Brushes.Black, new RectangleF(365 + dataDetVenta.Columns[0].Width, 200, dataDetVenta.Columns[0].Width + 10, dataDetVenta.Rows[0].Height), str);
                #endregion

                #region Draw Rows N
                width = 10 + dataDetVenta.Columns[0].Width;
                height = 200;
                //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
                while (i < dataDetVenta.Rows.Count)
                {
                    if (height > e.MarginBounds.Height)
                    {
                        height = 200;
                        width = 10;
                        e.HasMorePages = true;
                        return;
                    }

                    height += dataDetVenta.Rows[i].Height;
                    //Draw Row 1
                    e.Graphics.DrawRectangle(Pens.Black, 70, height, dataDetVenta.Columns[0].Width - 45, dataDetVenta.Rows[0].Height);
                    e.Graphics.DrawString(dataDetVenta.Rows[i].Cells[0].FormattedValue.ToString(), dataDetVenta.Font, Brushes.Black, new RectangleF(70, height, dataDetVenta.Columns[0].Width - 45, dataDetVenta.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, 70 + dataDetVenta.Columns[0].Width - 45, height, dataDetVenta.Columns[0].Width - 80, dataDetVenta.Rows[0].Height);
                    e.Graphics.DrawString(dataDetVenta.Rows[i].Cells[1].Value.ToString(), dataDetVenta.Font, Brushes.Black, new RectangleF(70 + dataDetVenta.Columns[0].Width - 45, height, dataDetVenta.Columns[0].Width - 50, dataDetVenta.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 125 + dataDetVenta.Columns[0].Width, height, dataDetVenta.Columns[0].Width - 100, dataDetVenta.Rows[0].Height);
                    e.Graphics.DrawString(dataDetVenta.Rows[i].Cells[2].Value.ToString(), dataDetVenta.Font, Brushes.Black, new RectangleF(125 + dataDetVenta.Columns[0].Width, height, dataDetVenta.Columns[0].Width - 50, dataDetVenta.Rows[0].Height), str);
                    //Draw Row 4
                    e.Graphics.DrawRectangle(Pens.Black, 205 + dataDetVenta.Columns[0].Width, height, dataDetVenta.Columns[0].Width - 100, dataDetVenta.Rows[0].Height);
                    e.Graphics.DrawString(dataDetVenta.Rows[i].Cells[3].Value.ToString(), dataDetVenta.Font, Brushes.Black, new RectangleF(205 + dataDetVenta.Columns[0].Width, height, dataDetVenta.Columns[0].Width - 50, dataDetVenta.Rows[0].Height), str);
                    //Draw Row 5
                    e.Graphics.DrawRectangle(Pens.Black, 285 + dataDetVenta.Columns[0].Width, height, dataDetVenta.Columns[0].Width - 100, dataDetVenta.Rows[0].Height);
                    e.Graphics.DrawString(dataDetVenta.Rows[i].Cells[6].Value.ToString(), dataDetVenta.Font, Brushes.Black, new RectangleF(285 + dataDetVenta.Columns[0].Width, height, dataDetVenta.Columns[0].Width - 50, dataDetVenta.Rows[0].Height), str);
                    //Draw Row 6
                    e.Graphics.DrawRectangle(Pens.Black, 365 + dataDetVenta.Columns[0].Width, height, dataDetVenta.Columns[0].Width + 10, dataDetVenta.Rows[0].Height);
                    e.Graphics.DrawString(dataDetVenta.Rows[i].Cells[4].Value.ToString(), dataDetVenta.Font, Brushes.Black, new RectangleF(365 + dataDetVenta.Columns[0].Width, height, dataDetVenta.Columns[0].Width - 20, dataDetVenta.Rows[0].Height), str);

                    width += dataDetVenta.Columns[0].Width;
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


    }
}
