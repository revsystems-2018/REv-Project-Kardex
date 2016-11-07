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
    public partial class RegistroMarcas : Form
    {
        public int codUser = 0;
        int pos = 0;
        int i = 0;
        public String nomMarca = "";

        public RegistroMarcas()
        {
            InitializeComponent();
            toolregmarca.SetToolTip(btnSelect, "Seleccionar");
            toolregmarca.SetToolTip(nuevo, "Nueva Marca");
            toolregmarca.SetToolTip(editar, "Editar Marca");
            toolregmarca.SetToolTip(eliminar, "Eliminar Marca");
            toolregmarca.SetToolTip(actualizar, "Actualizar");
            toolregmarca.SetToolTip(print, "Imprimir");
            toolregmarca.SetToolTip(printview, "Pre-Vista");
            toolregmarca.SetToolTip(save, "Exportar Excel");
            toolregmarca.SetToolTip(salir, "Salir");
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            AEEMarca am = new AEEMarca();
            am.titulolabel.Text = "Eliminar Marca";
            am.buscarboton.Visible = true;
            am.deleteboton.Visible = true;
            am.labeldelete.Visible = true;
            am.textcod.Text = codUser.ToString();
            am.textcod.ForeColor = SystemColors.WindowText;
            am.textcod.Font = new Font(am.textcod.Font, FontStyle.Regular);
            am.ShowDialog();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            AEEMarca ae = new AEEMarca();
            ae.titulolabel.Text = "Modificar Marca";
            ae.buscarboton.Visible = true;
            ae.btnEdit.Visible = true;
            ae.labeledit.Visible = true;
            ae.textcod.Text = codUser.ToString();
            ae.textcod.ForeColor = SystemColors.WindowText;
            ae.textcod.Font = new Font(ae.textcod.Font, FontStyle.Regular);
            ae.ShowDialog();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            AEEMarca we = new AEEMarca();
            we.saveboton.Visible = true;
            we.labelsave.Visible = true;
            we.gencode.Visible = true;
            we.ShowDialog();
        }

        private void RegistroMarcas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.rEV_DataBaseDataSet.Marcas);

        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.rEV_DataBaseDataSet.Marcas);
        }

        private void save_Click(object sender, EventArgs e)
        {
            Export_Excel ex = new Export_Excel();
            ex.ExportarDatosExcel(dataGridMark);
        }

        private void dataGridMark_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pos = dataGridMark.CurrentRow.Index;
                String valor = "";
                valor = dataGridMark[0, pos].Value.ToString();
                codUser = Int32.Parse(valor);

                btnSelect.Enabled = true;
                btnSelect.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Select; 
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pos = dataGridMark.CurrentRow.Index;
                String valor = "";
                valor = dataGridMark[0, pos].Value.ToString();
                nomMarca = dataGridMark[2, pos].Value.ToString();
                codUser = Int32.Parse(valor);

                this.Close();
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
            try
            {
                printPreview.Document = printDocx;
                printPreview.ShowDialog();
                i = 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
                e.Graphics.DrawString("Registro de Marcas", new Font("Lucida Sans", 18), new SolidBrush(Color.DarkBlue), img.Width + 400, 60);
                //fin Encabezado Documento.



                //Insert DataGrid Print.
                #region Draw Column 1
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(250, 200, dataGridMark.Columns[0].Width, dataGridMark.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 250, 200, dataGridMark.Columns[0].Width, dataGridMark.Rows[0].Height);
                e.Graphics.DrawString(dataGridMark.Columns[0].HeaderText, dataGridMark.Font, Brushes.Black, new RectangleF(250, 200, dataGridMark.Columns[0].Width, dataGridMark.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(250 + dataGridMark.Columns[0].Width, 200, dataGridMark.Columns[0].Width+30, dataGridMark.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 250 + dataGridMark.Columns[0].Width, 200, dataGridMark.Columns[0].Width+30, dataGridMark.Rows[0].Height);
                e.Graphics.DrawString(dataGridMark.Columns[1].HeaderText, dataGridMark.Font, Brushes.Black, new RectangleF(250 + dataGridMark.Columns[0].Width, 200, dataGridMark.Columns[0].Width+30, dataGridMark.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(380 + dataGridMark.Columns[0].Width, 200, dataGridMark.Columns[0].Width+20, dataGridMark.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 380 + dataGridMark.Columns[0].Width, 200, dataGridMark.Columns[0].Width+20, dataGridMark.Rows[0].Height);
                e.Graphics.DrawString(dataGridMark.Columns[2].HeaderText, dataGridMark.Font, Brushes.Black, new RectangleF(380 + dataGridMark.Columns[0].Width, 200, dataGridMark.Columns[0].Width+20, dataGridMark.Rows[0].Height), str);
                #endregion


                #region Draw Rows N
                width = 10 + dataGridMark.Columns[0].Width;
                height = 200;
                //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
                while (i < dataGridMark.Rows.Count)
                {
                    if (height > e.MarginBounds.Height)
                    {
                        height = 200;
                        width = 10;
                        e.HasMorePages = true;
                        return;
                    }

                    height += dataGridMark.Rows[i].Height;
                    //Draw Row 1
                    e.Graphics.DrawRectangle(Pens.Black, 250, height, dataGridMark.Columns[0].Width, dataGridMark.Rows[0].Height);
                    e.Graphics.DrawString(dataGridMark.Rows[i].Cells[0].FormattedValue.ToString(), dataGridMark.Font, Brushes.Black, new RectangleF(250, height, dataGridMark.Columns[0].Width, dataGridMark.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, 250 + dataGridMark.Columns[0].Width, height, dataGridMark.Columns[0].Width-10, dataGridMark.Rows[0].Height);
                    e.Graphics.DrawString(dataGridMark.Rows[i].Cells[1].Value.ToString(), dataGridMark.Font, Brushes.Black, new RectangleF(250 + dataGridMark.Columns[0].Width, height, dataGridMark.Columns[0].Width-10, dataGridMark.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 380 + dataGridMark.Columns[0].Width, height, dataGridMark.Columns[0].Width+20, dataGridMark.Rows[0].Height);
                    e.Graphics.DrawString(dataGridMark.Rows[i].Cells[2].Value.ToString(), dataGridMark.Font, Brushes.Black, new RectangleF(380 + dataGridMark.Columns[0].Width, height, dataGridMark.Columns[0].Width+20, dataGridMark.Rows[0].Height), str);
                    
                    width += dataGridMark.Columns[0].Width;
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
    }
}
