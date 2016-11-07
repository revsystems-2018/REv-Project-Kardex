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
    public partial class Registro_Clientes : Form
    {
        public int codUser = 0;
        public int CodUsr = 0;

        public String nitCli = "";
        int pos = 0;
        int i = 0;

        public Registro_Clientes()
        {
            InitializeComponent();

            toolRegClient.SetToolTip(nuevo, "Registrar Un Nuevo Cliente");
            toolRegClient.SetToolTip(editar, "Modificar Cliente Registrado");
            toolRegClient.SetToolTip(eliminar, "Eliminar Cliente Registrado");
            toolRegClient.SetToolTip(actualizar, "Actualizar Lista de Clientes");
            toolRegClient.SetToolTip(print, "Imprimir Lista de Clientes");
            toolRegClient.SetToolTip(save, "Guardar Planillas Excel");
            toolRegClient.SetToolTip(verbtn, "Ver Cliente");
            toolRegClient.SetToolTip(printview, "Pre-Vista");
            toolRegClient.SetToolTip(salir, "Salir");
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            RegCliente rc = new RegCliente();
            rc.ShowDialog();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            EditCliente ec = new EditCliente();
            ec.ciedcli.Text = "";
            ec.ciedcli.Text = codUser.ToString();
            ec.ciedcli.ForeColor = SystemColors.WindowText;
            ec.ciedcli.Font = new Font(ec.ciedcli.Font, FontStyle.Regular);
            ec.ShowDialog();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            DelCliente dc = new DelCliente();
            dc.textci.Text = "";
            dc.textci.Text = codUser.ToString();
            dc.textci.ForeColor = SystemColors.WindowText;
            dc.textci.Font = new Font(dc.textci.Font, FontStyle.Regular);
            dc.ShowDialog();

        }

        private void Registro_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.rEV_DataBaseDataSet.Clientes);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.rEV_DataBaseDataSet.Clientes);
        }

        private void save_Click(object sender, EventArgs e)
        {
            Export_Excel ee = new Export_Excel();
            ee.ExportarDatosExcel(dataGridClientes);
        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CodUsr == 0)
            {
                try
                {
                    pos = dataGridClientes.CurrentRow.Index;
                    String valor = "";
                    nitCli = dataGridClientes[3, pos].Value.ToString();
                    valor = dataGridClientes[0, pos].Value.ToString();
                    codUser = Int32.Parse(valor);
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    pos = dataGridClientes.CurrentRow.Index;
                    String valor = "";
                    nitCli = dataGridClientes[3, pos].Value.ToString();
                    valor = dataGridClientes[0, pos].Value.ToString();
                    codUser = Int32.Parse(valor);

                    botonselect.Enabled = true;
                    botonselect.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Select;
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerCliente ve = new VerCliente();
            ve.codUser = codUser;
            ve.ShowDialog();
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
                e.Graphics.DrawString("Registro de Clientes", new Font("Lucida Sans", 18), new SolidBrush(Color.DarkBlue), img.Width + 400, 60);
                //fin Encabezado Documento.



                //Insert DataGrid Print.
                #region Draw Column 1
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10, 200, dataGridClientes.Columns[0].Width - 45, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10, 200, dataGridClientes.Columns[0].Width - 45, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[0].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(10, 200, dataGridClientes.Columns[0].Width - 45, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10 + dataGridClientes.Columns[0].Width - 45, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10 + dataGridClientes.Columns[0].Width - 45, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[1].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(10 + dataGridClientes.Columns[0].Width - 45, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(65 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 65 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[2].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(65 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 4
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(165 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 165 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[3].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(165 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 5
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(265 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 265 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[4].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(265 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 6
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(365 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width + 10, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 365 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width + 10, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[6].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(365 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width + 10, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 7
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(495 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 495 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[9].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(495 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 8
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(595 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width - 60, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 595 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width - 60, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[15].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(595 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width - 60, dataGridClientes.Rows[0].Height), str);
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
                    e.Graphics.DrawRectangle(Pens.Black, 10, height, dataGridClientes.Columns[0].Width - 45, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[0].FormattedValue.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(10, height, dataGridClientes.Columns[0].Width - 45, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, 10 + dataGridClientes.Columns[0].Width - 45, height, dataGridClientes.Columns[0].Width - 50, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[1].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(10 + dataGridClientes.Columns[0].Width - 45, height, dataGridClientes.Columns[0].Width - 50, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 65 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 50, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[2].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(65 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 50, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 4
                    e.Graphics.DrawRectangle(Pens.Black, 165 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 50, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[3].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(165 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 50, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 5
                    e.Graphics.DrawRectangle(Pens.Black, 265 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 50, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[4].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(265 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 50, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 6
                    e.Graphics.DrawRectangle(Pens.Black, 365 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[6].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(365 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 7
                    e.Graphics.DrawRectangle(Pens.Black, 495 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 50, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[9].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(495 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 50, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 8
                    e.Graphics.DrawRectangle(Pens.Black, 595 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 60, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[15].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(595 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 60, dataGridClientes.Rows[0].Height), str);

                    width += dataGridClientes.Columns[0].Width;
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

        private void botonselect_Click(object sender, EventArgs e)
        {
            try
            {
                pos = dataGridClientes.CurrentRow.Index;
                String valor = "";
                valor = dataGridClientes[0, pos].Value.ToString();
                nitCli = dataGridClientes[3, pos].Value.ToString();
                codUser = Int32.Parse(valor);

                this.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
