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
    public partial class Registro_Proveedores : Form
    {
        public int codUser = 0;
        public String codReg = "";
        public String nomEmp = "";
        int pos = 0;
        int i = 0;

        public Registro_Proveedores()
        {
            InitializeComponent();

            toolRegProve.SetToolTip(nuevo, "Registrar Un Nuevo Proveedor");
            toolRegProve.SetToolTip(editar, "Modificar Proveedor Registrado");
            toolRegProve.SetToolTip(eliminar, "Eliminar Proveedor Registrado");
            toolRegProve.SetToolTip(actualizar, "Actualizar Lista de Proveedores");
            toolRegProve.SetToolTip(print, "Imprimir Lista de Proveedores");
            toolRegProve.SetToolTip(save, "Guardar Planillas Excel");
            toolRegProve.SetToolTip(verbtn, "Ver Proveedor");
            toolRegProve.SetToolTip(printview, "Pre-Vista");
            toolRegProve.SetToolTip(botonselect, "Seleccionar");
            toolRegProve.SetToolTip(salir, "Salir");
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            RegProveedor rp = new RegProveedor();
            rp.ShowDialog();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            EditProveedor ep = new EditProveedor();
            ep.codedprov.Text = "";
            ep.codedprov.Text = codUser.ToString();
            ep.codedprov.ForeColor = SystemColors.WindowText;
            ep.codedprov.Font = new Font(ep.codedprov.Font, FontStyle.Regular);
            ep.ShowDialog();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            DelProveedor dp = new DelProveedor();
            dp.textcod.Text = "";
            dp.textcod.Text = codUser.ToString();
            dp.textcod.ForeColor = SystemColors.WindowText;
            dp.textcod.Font = new Font(dp.textcod.Font, FontStyle.Regular);
            dp.ShowDialog();
        }

        private void Registro_Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.rEV_DataBaseDataSet.Proveedores);

        }

        private void save_Click(object sender, EventArgs e)
        {
            Export_Excel ee = new Export_Excel();
            ee.ExportarDatosExcel(dataGridProve);
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.rEV_DataBaseDataSet.Proveedores);
        }

        private void dataGridProve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pos = dataGridProve.CurrentRow.Index;
                String valor = "";
                valor = dataGridProve[0, pos].Value.ToString();
                codUser = Int32.Parse(valor);

                botonselect.Enabled = true;
                botonselect.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Select; 
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerProveedor ve = new VerProveedor();
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
        {
            //Inicio del encabezado del Documento.
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
                e.Graphics.DrawString("Registro de Proveedores", new Font("Lucida Sans", 18), new SolidBrush(Color.DarkBlue), img.Width + 400, 60);
                //fin Encabezado Documento.



                //Insert DataGrid Print.
                #region Draw Column 1
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10, 200, dataGridProve.Columns[0].Width - 30, dataGridProve.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10, 200, dataGridProve.Columns[0].Width - 30, dataGridProve.Rows[0].Height);
                e.Graphics.DrawString(dataGridProve.Columns[0].HeaderText, dataGridProve.Font, Brushes.Black, new RectangleF(10, 200, dataGridProve.Columns[0].Width - 30, dataGridProve.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10 + dataGridProve.Columns[0].Width - 30, 200, dataGridProve.Columns[0].Width, dataGridProve.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10 + dataGridProve.Columns[0].Width - 30, 200, dataGridProve.Columns[0].Width, dataGridProve.Rows[0].Height);
                e.Graphics.DrawString(dataGridProve.Columns[13].HeaderText, dataGridProve.Font, Brushes.Black, new RectangleF(10 + dataGridProve.Columns[0].Width - 30, 200, dataGridProve.Columns[0].Width, dataGridProve.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(80 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width+15, dataGridProve.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 80 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width+15, dataGridProve.Rows[0].Height);
                e.Graphics.DrawString(dataGridProve.Columns[2].HeaderText, dataGridProve.Font, Brushes.Black, new RectangleF(80 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width+15, dataGridProve.Rows[0].Height), str);
                #endregion

                #region Draw column 4
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(195 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width+15, dataGridProve.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 195 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width+15, dataGridProve.Rows[0].Height);
                e.Graphics.DrawString(dataGridProve.Columns[3].HeaderText, dataGridProve.Font, Brushes.Black, new RectangleF(195 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width+15, dataGridProve.Rows[0].Height), str);
                #endregion

                #region Draw column 5
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(310 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width+10, dataGridProve.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 310 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width+10, dataGridProve.Rows[0].Height);
                e.Graphics.DrawString(dataGridProve.Columns[14].HeaderText, dataGridProve.Font, Brushes.Black, new RectangleF(310 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width+10, dataGridProve.Rows[0].Height), str);
                #endregion

                #region Draw column 6
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(420 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width, dataGridProve.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 420 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width, dataGridProve.Rows[0].Height);
                e.Graphics.DrawString(dataGridProve.Columns[7].HeaderText, dataGridProve.Font, Brushes.Black, new RectangleF(420 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width, dataGridProve.Rows[0].Height), str);
                #endregion

                #region Draw column 7
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(520 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width +35, dataGridProve.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 520 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width +35, dataGridProve.Rows[0].Height);
                e.Graphics.DrawString(dataGridProve.Columns[9].HeaderText, dataGridProve.Font, Brushes.Black, new RectangleF(520 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width +35, dataGridProve.Rows[0].Height), str);
                #endregion

                #region Draw column 8
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(630 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width - 50, dataGridProve.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 630 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width - 50, dataGridProve.Rows[0].Height);
                e.Graphics.DrawString(dataGridProve.Columns[15].HeaderText, dataGridProve.Font, Brushes.Black, new RectangleF(630 + dataGridProve.Columns[0].Width, 200, dataGridProve.Columns[0].Width - 50, dataGridProve.Rows[0].Height), str);
                #endregion

                #region Draw Rows N
                width = 10 + dataGridProve.Columns[0].Width;
                height = 200;
                //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
                while (i < dataGridProve.Rows.Count)
                {
                    if (height > e.MarginBounds.Height)
                    {
                        height = 200;
                        width = 10;
                        e.HasMorePages = true;
                        return;
                    }

                    height += dataGridProve.Rows[i].Height;
                    //Draw Row 1
                    e.Graphics.DrawRectangle(Pens.Black, 10, height, dataGridProve.Columns[0].Width - 30, dataGridProve.Rows[0].Height);
                    e.Graphics.DrawString(dataGridProve.Rows[i].Cells[0].FormattedValue.ToString(), dataGridProve.Font, Brushes.Black, new RectangleF(10, height, dataGridProve.Columns[0].Width - 30, dataGridProve.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, 10 + dataGridProve.Columns[0].Width - 30, height, dataGridProve.Columns[0].Width-30, dataGridProve.Rows[0].Height);
                    e.Graphics.DrawString(dataGridProve.Rows[i].Cells[13].Value.ToString(), dataGridProve.Font, Brushes.Black, new RectangleF(10 + dataGridProve.Columns[0].Width - 30, height, dataGridProve.Columns[0].Width-30, dataGridProve.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 80 + dataGridProve.Columns[0].Width, height, dataGridProve.Columns[0].Width -15, dataGridProve.Rows[0].Height);
                    e.Graphics.DrawString(dataGridProve.Rows[i].Cells[2].Value.ToString(), dataGridProve.Font, Brushes.Black, new RectangleF(80 + dataGridProve.Columns[0].Width, height, dataGridProve.Columns[0].Width -15, dataGridProve.Rows[0].Height), str);
                    //Draw Row 4
                    e.Graphics.DrawRectangle(Pens.Black, 195 + dataGridProve.Columns[0].Width, height, dataGridProve.Columns[0].Width -15, dataGridProve.Rows[0].Height);
                    e.Graphics.DrawString(dataGridProve.Rows[i].Cells[3].Value.ToString(), dataGridProve.Font, Brushes.Black, new RectangleF(195 + dataGridProve.Columns[0].Width, height, dataGridProve.Columns[0].Width -15, dataGridProve.Rows[0].Height), str);
                    //Draw Row 5
                    e.Graphics.DrawRectangle(Pens.Black, 310 + dataGridProve.Columns[0].Width, height, dataGridProve.Columns[0].Width -20, dataGridProve.Rows[0].Height);
                    e.Graphics.DrawString(dataGridProve.Rows[i].Cells[14].Value.ToString(), dataGridProve.Font, Brushes.Black, new RectangleF(310 + dataGridProve.Columns[0].Width, height, dataGridProve.Columns[0].Width -20, dataGridProve.Rows[0].Height), str);
                    //Draw Row 6
                    e.Graphics.DrawRectangle(Pens.Black, 420 + dataGridProve.Columns[0].Width, height, dataGridProve.Columns[0].Width-30, dataGridProve.Rows[0].Height);
                    e.Graphics.DrawString(dataGridProve.Rows[i].Cells[7].Value.ToString(), dataGridProve.Font, Brushes.Black, new RectangleF(420 + dataGridProve.Columns[0].Width, height, dataGridProve.Columns[0].Width-30, dataGridProve.Rows[0].Height), str);
                    //Draw Row 7
                    e.Graphics.DrawRectangle(Pens.Black, 520 + dataGridProve.Columns[0].Width, height, dataGridProve.Columns[0].Width -20, dataGridProve.Rows[0].Height);
                    e.Graphics.DrawString(dataGridProve.Rows[i].Cells[9].Value.ToString(), dataGridProve.Font, Brushes.Black, new RectangleF(520 + dataGridProve.Columns[0].Width, height, dataGridProve.Columns[0].Width -20, dataGridProve.Rows[0].Height), str);
                    //Draw Row 8
                    e.Graphics.DrawRectangle(Pens.Black, 630 + dataGridProve.Columns[0].Width, height, dataGridProve.Columns[0].Width - 50, dataGridProve.Rows[0].Height);
                    e.Graphics.DrawString(dataGridProve.Rows[i].Cells[15].Value.ToString(), dataGridProve.Font, Brushes.Black, new RectangleF(630 + dataGridProve.Columns[0].Width, height, dataGridProve.Columns[0].Width - 50, dataGridProve.Rows[0].Height), str);

                    width += dataGridProve.Columns[0].Width;
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
                pos = dataGridProve.CurrentRow.Index;
                String valor = "";
                valor = dataGridProve[0, pos].Value.ToString();
                codReg = dataGridProve[0, pos].Value.ToString();
                nomEmp = dataGridProve[14, pos].Value.ToString();
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
