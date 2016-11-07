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
    public partial class Registro_Categoria : Form
    {
        public int codUser = 0;
        public String nomCate = "";
        int pos = 0;
        int i = 0;

        public Registro_Categoria()
        {
            InitializeComponent();

            toolCategoria.SetToolTip(selectboton,"Seleccionar Categoría");
            toolCategoria.SetToolTip(nuevo,"Agregar Categoría");
            toolCategoria.SetToolTip(editar,"Editar Categoría");
            toolCategoria.SetToolTip(eliminar,"Eliminar Categoría");
            toolCategoria.SetToolTip(btnSubCat, "Configurar Sub-Categorías");
            toolCategoria.SetToolTip(actualizar,"Actualizar Lista de Categoría");
            toolCategoria.SetToolTip(print, "Imprimir");
            toolCategoria.SetToolTip(printview, "Pre-Vista");
            toolCategoria.SetToolTip(save, "Guardar Excel");
            toolCategoria.SetToolTip(salir, "Salir");
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            AEECategoria ca = new AEECategoria();
            ca.btngen.Visible = true;
            ca.saveboton.Enabled = true;
            ca.ShowDialog();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            AEECategoria sd = new AEECategoria();
            sd.titulolabel.Text = "Modificar Categoría";
            sd.buscarboton.Visible = true;
            sd.btnEdit.Enabled = true;
            sd.textcod.ForeColor = SystemColors.WindowText;
            sd.textcod.Font = new Font(sd.textcod.Font, FontStyle.Regular);
            sd.textcod.Text = codUser.ToString();
            sd.ShowDialog();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            AEECategoria df = new AEECategoria();
            df.titulolabel.Text = "Eliminar Categoría";
            df.deleteboton.Enabled = true;
            df.buscarboton.Visible = true;
            df.textcod.ForeColor = SystemColors.WindowText;
            df.textcod.Font = new Font(df.textcod.Font, FontStyle.Regular);
            df.textcod.Text = codUser.ToString();
            df.ShowDialog();
        }

        private void Registro_Categoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.rEV_DataBaseDataSet.Categorias);

        }

        private void save_Click(object sender, EventArgs e)
        {
            Export_Excel ex = new Export_Excel();
            ex.ExportarDatosExcel(dataGridCat);
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.rEV_DataBaseDataSet.Categorias);
        }

        private void dataGridCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pos = dataGridCat.CurrentRow.Index;
                String valor = "";
                valor = dataGridCat[0, pos].Value.ToString();
                codUser = int.Parse(valor);

                selectboton.Enabled = true;
                selectboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Select; 
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectboton_Click(object sender, EventArgs e)
        {
            try
            {
                pos = dataGridCat.CurrentRow.Index;
                String valor = "";
                valor = dataGridCat[0, pos].Value.ToString();
                nomCate = dataGridCat[1, pos].Value.ToString();
                codUser = int.Parse(valor);

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
                e.Graphics.DrawString("Registro de Medidas", new Font("Lucida Sans", 18), new SolidBrush(Color.DarkBlue), img.Width + 400, 60);
                //fin Encabezado Documento.



                //Insert DataGrid Print.
                #region Draw Column 1
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(250, 200, dataGridCat.Columns[0].Width, dataGridCat.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 250, 200, dataGridCat.Columns[0].Width, dataGridCat.Rows[0].Height);
                e.Graphics.DrawString(dataGridCat.Columns[0].HeaderText, dataGridCat.Font, Brushes.Black, new RectangleF(250, 200, dataGridCat.Columns[0].Width, dataGridCat.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(250 + dataGridCat.Columns[0].Width, 200, dataGridCat.Columns[0].Width + 30, dataGridCat.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 250 + dataGridCat.Columns[0].Width, 200, dataGridCat.Columns[0].Width + 30, dataGridCat.Rows[0].Height);
                e.Graphics.DrawString(dataGridCat.Columns[1].HeaderText, dataGridCat.Font, Brushes.Black, new RectangleF(250 + dataGridCat.Columns[0].Width, 200, dataGridCat.Columns[0].Width + 30, dataGridCat.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(380 + dataGridCat.Columns[0].Width, 200, dataGridCat.Columns[0].Width + 20, dataGridCat.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 380 + dataGridCat.Columns[0].Width, 200, dataGridCat.Columns[0].Width + 20, dataGridCat.Rows[0].Height);
                e.Graphics.DrawString(dataGridCat.Columns[2].HeaderText, dataGridCat.Font, Brushes.Black, new RectangleF(380 + dataGridCat.Columns[0].Width, 200, dataGridCat.Columns[0].Width + 20, dataGridCat.Rows[0].Height), str);
                #endregion


                #region Draw Rows N
                width = 10 + dataGridCat.Columns[0].Width;
                height = 200;
                //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
                while (i < dataGridCat.Rows.Count)
                {
                    if (height > e.MarginBounds.Height)
                    {
                        height = 200;
                        width = 10;
                        e.HasMorePages = true;
                        return;
                    }

                    height += dataGridCat.Rows[i].Height;
                    //Draw Row 1
                    e.Graphics.DrawRectangle(Pens.Black, 250, height, dataGridCat.Columns[0].Width, dataGridCat.Rows[0].Height);
                    e.Graphics.DrawString(dataGridCat.Rows[i].Cells[0].FormattedValue.ToString(), dataGridCat.Font, Brushes.Black, new RectangleF(250, height, dataGridCat.Columns[0].Width, dataGridCat.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, 250 + dataGridCat.Columns[0].Width, height, dataGridCat.Columns[0].Width - 30, dataGridCat.Rows[0].Height);
                    e.Graphics.DrawString(dataGridCat.Rows[i].Cells[1].Value.ToString(), dataGridCat.Font, Brushes.Black, new RectangleF(250 + dataGridCat.Columns[0].Width, height, dataGridCat.Columns[0].Width - 30, dataGridCat.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 380 + dataGridCat.Columns[0].Width, height, dataGridCat.Columns[0].Width + 20, dataGridCat.Rows[0].Height);
                    e.Graphics.DrawString(dataGridCat.Rows[i].Cells[2].Value.ToString(), dataGridCat.Font, Brushes.Black, new RectangleF(380 + dataGridCat.Columns[0].Width, height, dataGridCat.Columns[0].Width + 20, dataGridCat.Rows[0].Height), str);

                    width += dataGridCat.Columns[0].Width;
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
            AEESubCat sb = new AEESubCat();
            sb.ShowDialog();
        }


    }
}
