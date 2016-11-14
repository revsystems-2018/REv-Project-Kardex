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
    public partial class Registro_Ventas : Form
    {
        Conexion fu = new Conexion();
        int i = 0;
        int pos = 0;
        int codUsr = 0;
        int codCliente = 0;

        public int codUser = 7906442; 
        public String idSell = "";
        DateTime dateDay = DateTime.Today; 

        public Registro_Ventas()
        {
            InitializeComponent();

            toolTipRegVen.SetToolTip(nuevo, "Nueva Venta");
            toolTipRegVen.SetToolTip(editar, "Editar Venta");
            toolTipRegVen.SetToolTip(eliminar, "Eliminar Venta");
            toolTipRegVen.SetToolTip(verbtn, "Mostrar Usuario");
            toolTipRegVen.SetToolTip(btnCli, "Mostrar Cliente");
            toolTipRegVen.SetToolTip(btnDetVen, "Mostrar Detalle de Venta");
            toolTipRegVen.SetToolTip(btnFac, "Mostrar Factura");
            toolTipRegVen.SetToolTip(btnDevo, "Mostrar Devolucion en Ventas");
            toolTipRegVen.SetToolTip(actualizar, "Actualizar");
            toolTipRegVen.SetToolTip(print, "Imprimir");
            toolTipRegVen.SetToolTip(printview, "PRE-Vista");
            toolTipRegVen.SetToolTip(btnFecha, "Mostrar Ventas por Fechas");
            toolTipRegVen.SetToolTip(save, "Exportar a Excel");
            toolTipRegVen.SetToolTip(salir, "Salir");

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


        private void Registro_Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.REV_Ventas' Puede moverla o quitarla según sea necesario.
            this.rEV_VentasTableAdapter.Fill(this.rEV_DataBaseDataSet.REV_Ventas);

            if (GetIDUsuario(codUser) == 2)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM REV_Ventas WHERE id_User = '" + codUser + "'; ", fu.GetCONN());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridClientes.DataSource = dt;
            }
            else 
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM REV_Ventas ; ", fu.GetCONN());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridClientes.DataSource = dt;
            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            Ventas ve = new Ventas();
            ve.codUsr = codUser;
            ve.ShowDialog();
        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pos = dataGridClientes.CurrentRow.Index;
                String valor = "";
                String nitCli = "";
                nitCli = dataGridClientes[3, pos].Value.ToString();
                valor = dataGridClientes[1, pos].Value.ToString();
                idSell = dataGridClientes[0, pos].Value.ToString();
                codUsr = Int32.Parse(valor);
                codCliente = Int32.Parse(nitCli);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verbtn_Click(object sender, EventArgs e)
        {
            VerAdmin va = new VerAdmin();
            va.codUser = codUsr;
            va.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerCliente vc = new VerCliente();
            vc.codUser = codCliente;
            vc.ShowDialog();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Export_Excel ex = new Export_Excel();
            ex.ExportarDatosExcel(dataGridClientes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report_DetalleVenta re = new Report_DetalleVenta();
            re.coddet = idSell;
            re.ShowDialog();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetIDUsuario(codUser) == 2)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM REV_Ventas WHERE id_User = '" + codUser + "'; ", fu.GetCONN());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridClientes.DataSource = dt;
                }
                else
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM REV_Ventas ; ", fu.GetCONN());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridClientes.DataSource = dt;
                }
            }
            catch (Exception) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report_Factura rf = new Report_Factura();
            rf.coddet = idSell;
            rf.codUser = codUser;
            rf.ShowDialog();
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
                e.Graphics.DrawString("Registro de Ventas", new Font("Lucida Sans", 18), new SolidBrush(Color.DarkBlue), img.Width + 400, 60);
                //fin Encabezado Documento.

                //Insert DataGrid Print.
                #region Draw Column 1
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[0].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(10, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10 + dataGridClientes.Columns[0].Width - 30, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10 + dataGridClientes.Columns[0].Width - 30, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[1].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(10 + dataGridClientes.Columns[0].Width - 30, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(95 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 95 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[16].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(95 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 4
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(185 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 185 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[5].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(185 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 5
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(265 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 265 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[9].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(265 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 6
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(365 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width + 10, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 365 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width + 10, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[11].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(365 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width + 10, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 7
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(465 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width -20, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 465 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width -20, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[14].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(465 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width -20, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 8
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(565 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 565 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[15].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(565 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw Rows N
                width = 10 + dataGridClientes.Columns[0].Width;
                height = 200;
                //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
                while (i < dataGridClientes.Rows.Count)
                {
                    if (height > e.MarginBounds.Height)
                    {
                        height = 200;
                        width = 10;
                        e.HasMorePages = true;
                        return;
                    }

                    height += dataGridClientes.Rows[i].Height;
                    //Draw Row 1
                    e.Graphics.DrawRectangle(Pens.Black, 10, height, dataGridClientes.Columns[0].Width - 30, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[0].FormattedValue.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(10, height, dataGridClientes.Columns[0].Width - 30, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, 10 + dataGridClientes.Columns[0].Width - 30, height, dataGridClientes.Columns[0].Width - 25, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[1].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(10 + dataGridClientes.Columns[0].Width - 30, height, dataGridClientes.Columns[0].Width - 25, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 95 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 50, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[16].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(95 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 50, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 4
                    e.Graphics.DrawRectangle(Pens.Black, 165 + dataGridClientes.Columns[0].Width+20, height, dataGridClientes.Columns[0].Width - 60, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[5].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(165 + dataGridClientes.Columns[0].Width+20, height, dataGridClientes.Columns[0].Width - 60, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 5
                    e.Graphics.DrawRectangle(Pens.Black, 265 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 40, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[9].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(265 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 40, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 6
                    e.Graphics.DrawRectangle(Pens.Black, 365 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 40, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[11].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(365 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 40, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 7
                    e.Graphics.DrawRectangle(Pens.Black, 465 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 40, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[14].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(465 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 40, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 8
                    e.Graphics.DrawRectangle(Pens.Black, 565 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[15].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(565 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height), str);

                    width += dataGridClientes.Columns[0].Width;
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

        private void button5_Click(object sender, EventArgs e)
        {
            FechaMensseger fm = new FechaMensseger();
            fm.codUsr = codUser;
            fm.indica = 1;
            fm.ShowDialog();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(fm.value, fu.GetCONN());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridClientes.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report_Devolucion rd = new Report_Devolucion();
            rd.codUser = codUser;
            rd.coddet = idSell;
            rd.ShowDialog();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            EditVentasDetFact ed = new EditVentasDetFact();
            ed.codUsr = codUser;
            ed.id_Venta = idSell;
            ed.codProdtxt.Text = "";
            ed.codProdtxt.ForeColor = SystemColors.WindowText;
            ed.codProdtxt.Font = new Font(ed.codProdtxt.Font, FontStyle.Regular);
            ed.codProdtxt.Text = idSell; 
            ed.ShowDialog();
        }


        public int compidDevo()
        {
            int res = 0;
            Conexion r = new Conexion();
            string buscar = "SELECT * FROM Detalle_Venta WHERE cod_Venta= '" + idSell + "' ; ";
            try
            {
                r.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, r.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    res = res + 1;
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

        private void DeleteDevo() 
        {
            try
            {
                if (compidDevo() == 1)
                {
                    // Objetos de conexión y comando
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                    // Estableciento propiedades
                    cmd.Connection = fu.GetCONN();
                    cmd.CommandText = "DELETE FROM Devolucion_Ventas WHERE IDV_dev = '" + idSell + "' ;";

                    fu.OpenCnn();
                    cmd.ExecuteNonQuery();
                    fu.CerrarCnn();
                }
                else { }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. Al Eliminar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }


        public int CompIdFact()
        {
            int res = 0;
            Conexion r = new Conexion();
            string buscar = "SELECT * FROM Facturas WHERE codVenF= '" + idSell + "' ; ";
            try
            {
                r.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, r.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    res = res + 1;
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

        private void DeleteFactura() 
        {
            try
            {
                if (CompIdFact() == 1)
                {
                    // Objetos de conexión y comando
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                    // Estableciento propiedades
                    cmd.Connection = fu.GetCONN();
                    cmd.CommandText = "DELETE FROM Facturas WHERE codVenF = '" + idSell + "' ;";

                    fu.OpenCnn();
                    cmd.ExecuteNonQuery();
                    fu.CerrarCnn();
                }
                else { }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. Al Eliminar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }


        public int CompIdDet()
        {
            int res = 0;
            Conexion r = new Conexion();
            string buscar = "SELECT * FROM Detalle_Venta WHERE cod_Venta= '" + idSell + "' ; ";
            try
            {
                r.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, r.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    res = res + 1;
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

        private void DeleteDetalle() 
        {
            try
            {
                if (CompIdDet() == 1)
                {
                    // Objetos de conexión y comando
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                    // Estableciento propiedades
                    cmd.Connection = fu.GetCONN();
                    cmd.CommandText = "DELETE FROM Detalle_Venta WHERE cod_Venta = '" + idSell + "' ;";

                    fu.OpenCnn();
                    cmd.ExecuteNonQuery();
                    fu.CerrarCnn();
                }
                else 
                { 
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. Al Eliminar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            DeleteDetalle();
            DeleteFactura();
            DeleteDevo();

            try
            {   // Objetos de conexión y comando
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = fu.GetCONN();
                cmd.CommandText = "DELETE FROM REV_Ventas WHERE id_Venta = '" + idSell + "' ;";

                fu.OpenCnn();
                cmd.ExecuteNonQuery();
                fu.CerrarCnn();

                Messengers mr = new Messengers();
                mr.textolb.Text = "Venta Eliminada";
                mr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. Al Eliminar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
