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
    public partial class Registro_Usuario : Form
    {
        public int CodUsr = 0; // admin o user
        public int codUser = 0; //mostrar user
        int pos = 0;
        int i = 0;

        public Registro_Usuario()
        {
            InitializeComponent();

            toolRegUser.SetToolTip(nuevo, "Registrar Un Nuevo Usuario");
            toolRegUser.SetToolTip(editar, "Modificar Usuario Registrado");
            toolRegUser.SetToolTip(eliminar, "Eliminar Usuario Registrado");
            toolRegUser.SetToolTip(actualizar, "Actualizar Lista de Usuarios");
            toolRegUser.SetToolTip(print, "Imprimir Lista de Usuarios");
            toolRegUser.SetToolTip(save, "Guardar Planillas Excel");
            toolRegUser.SetToolTip(seebtn, "Ver Usuario");
            toolRegUser.SetToolTip(printview, "Pre-Vista");
            toolRegUser.SetToolTip(botonselect, "Seleccionar Usuario");
            toolRegUser.SetToolTip(salir, "Salir");
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            RegAdmin ra = new RegAdmin();
            ra.Text = "Datos de Usuario";
            ra.label1.Text = "Registro De Usuario";
            ra.ShowDialog();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            EditUser eu = new EditUser();
            eu.ciedu.Text = "";
            eu.ciedu.Text = codUser.ToString();
            eu.ciedu.ForeColor = SystemColors.WindowText;
            eu.ciedu.Font = new Font(eu.ciedu.Font, FontStyle.Regular);
            eu.ShowDialog();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            DelUser du = new DelUser();
            du.textci.Text = "";
            du.textci.Text = codUser.ToString();
            du.textci.ForeColor = SystemColors.WindowText;
            du.textci.Font = new Font(du.textci.Font, FontStyle.Regular);
            du.ShowDialog();
        }

        private void Registro_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.rEV_DataBaseDataSet.Usuario);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CodUsr == 0)
            {
                try
                {
                    pos = dataGridUsr.CurrentRow.Index;
                    String valor = "";
                    valor = dataGridUsr[0, pos].Value.ToString();
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
                    pos = dataGridUsr.CurrentRow.Index;
                    String valor = "";
                    valor = dataGridUsr[0, pos].Value.ToString();
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

        private void seebtn_Click(object sender, EventArgs e)
        {
            VerAdmin va = new VerAdmin();
            va.codUser = codUser;
            va.ShowDialog();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.rEV_DataBaseDataSet.Usuario);
        }

        private void save_Click(object sender, EventArgs e)
        {
            Export_Excel ee = new Export_Excel();
            ee.ExportarDatosExcel(dataGridUsr);
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
            String name=""; 
            String nit = "";
            String tel = "";
            String cel= "";
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
                e.Graphics.DrawString("Registro de Usuarios", new Font("Lucida Sans", 18), new SolidBrush(Color.DarkBlue), img.Width + 400, 60);
                //fin Encabezado Documento.



                //Insert DataGrid Print.
                #region Draw Column 1
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10, 200, dataGridUsr.Columns[0].Width-45, dataGridUsr.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10, 200, dataGridUsr.Columns[0].Width-45, dataGridUsr.Rows[0].Height);
                e.Graphics.DrawString(dataGridUsr.Columns[0].HeaderText, dataGridUsr.Font, Brushes.Black, new RectangleF(10, 200, dataGridUsr.Columns[0].Width-45, dataGridUsr.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10 + dataGridUsr.Columns[0].Width-45, 200, dataGridUsr.Columns[0].Width, dataGridUsr.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10 + dataGridUsr.Columns[0].Width-45, 200, dataGridUsr.Columns[0].Width, dataGridUsr.Rows[0].Height);
                e.Graphics.DrawString(dataGridUsr.Columns[1].HeaderText, dataGridUsr.Font, Brushes.Black, new RectangleF(10 + dataGridUsr.Columns[0].Width-45, 200, dataGridUsr.Columns[0].Width, dataGridUsr.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(65 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width, dataGridUsr.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 65 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width, dataGridUsr.Rows[0].Height);
                e.Graphics.DrawString(dataGridUsr.Columns[2].HeaderText, dataGridUsr.Font, Brushes.Black, new RectangleF(65 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width, dataGridUsr.Rows[0].Height), str);
                #endregion

                #region Draw column 4
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(165 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width, dataGridUsr.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 165 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width, dataGridUsr.Rows[0].Height);
                e.Graphics.DrawString(dataGridUsr.Columns[3].HeaderText, dataGridUsr.Font, Brushes.Black, new RectangleF(165 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width, dataGridUsr.Rows[0].Height), str);
                #endregion

                #region Draw column 5
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(265 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width, dataGridUsr.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 265 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width, dataGridUsr.Rows[0].Height);
                e.Graphics.DrawString(dataGridUsr.Columns[7].HeaderText, dataGridUsr.Font, Brushes.Black, new RectangleF(265 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width, dataGridUsr.Rows[0].Height), str);
                #endregion

                #region Draw column 6
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(365 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width + 10, dataGridUsr.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 365 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width + 10, dataGridUsr.Rows[0].Height);
                e.Graphics.DrawString(dataGridUsr.Columns[14].HeaderText, dataGridUsr.Font, Brushes.Black, new RectangleF(365 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width + 10, dataGridUsr.Rows[0].Height), str);
                #endregion

                #region Draw column 7
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(495 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width - 20, dataGridUsr.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 495 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width - 20, dataGridUsr.Rows[0].Height);
                e.Graphics.DrawString(dataGridUsr.Columns[5].HeaderText, dataGridUsr.Font, Brushes.Black, new RectangleF(495 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width - 20, dataGridUsr.Rows[0].Height), str);
                #endregion

                #region Draw column 8
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(595 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width - 60, dataGridUsr.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 595 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width - 60, dataGridUsr.Rows[0].Height);
                e.Graphics.DrawString(dataGridUsr.Columns[11].HeaderText, dataGridUsr.Font, Brushes.Black, new RectangleF(595 + dataGridUsr.Columns[0].Width, 200, dataGridUsr.Columns[0].Width - 60, dataGridUsr.Rows[0].Height), str);
                #endregion

                #region Draw Rows N
                width = 10 + dataGridUsr.Columns[0].Width;
                height = 200;
                //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
                while (i < dataGridUsr.Rows.Count)
                {
                    if (height > e.MarginBounds.Height)
                    {
                        height = 200;
                        width = 10;
                        e.HasMorePages = true;
                        return;
                    }

                    height += dataGridUsr.Rows[i].Height;
                    //Draw Row 1
                    e.Graphics.DrawRectangle(Pens.Black, 10, height, dataGridUsr.Columns[0].Width-45, dataGridUsr.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUsr.Rows[i].Cells[0].FormattedValue.ToString(), dataGridUsr.Font, Brushes.Black, new RectangleF(10, height, dataGridUsr.Columns[0].Width-45, dataGridUsr.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, 10 + dataGridUsr.Columns[0].Width-45, height, dataGridUsr.Columns[0].Width - 50, dataGridUsr.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUsr.Rows[i].Cells[1].Value.ToString(), dataGridUsr.Font, Brushes.Black, new RectangleF(10 + dataGridUsr.Columns[0].Width-45, height, dataGridUsr.Columns[0].Width - 50, dataGridUsr.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 65 + dataGridUsr.Columns[0].Width, height, dataGridUsr.Columns[0].Width - 50, dataGridUsr.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUsr.Rows[i].Cells[2].Value.ToString(), dataGridUsr.Font, Brushes.Black, new RectangleF(65 + dataGridUsr.Columns[0].Width, height, dataGridUsr.Columns[0].Width - 50, dataGridUsr.Rows[0].Height), str);
                    //Draw Row 4
                    e.Graphics.DrawRectangle(Pens.Black, 165 + dataGridUsr.Columns[0].Width, height, dataGridUsr.Columns[0].Width - 50, dataGridUsr.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUsr.Rows[i].Cells[3].Value.ToString(), dataGridUsr.Font, Brushes.Black, new RectangleF(165 + dataGridUsr.Columns[0].Width, height, dataGridUsr.Columns[0].Width - 50, dataGridUsr.Rows[0].Height), str);
                    //Draw Row 5
                    e.Graphics.DrawRectangle(Pens.Black, 265 + dataGridUsr.Columns[0].Width, height, dataGridUsr.Columns[0].Width - 50, dataGridUsr.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUsr.Rows[i].Cells[7].Value.ToString(), dataGridUsr.Font, Brushes.Black, new RectangleF(265 + dataGridUsr.Columns[0].Width, height, dataGridUsr.Columns[0].Width - 50, dataGridUsr.Rows[0].Height), str);
                    //Draw Row 6
                    e.Graphics.DrawRectangle(Pens.Black, 365 + dataGridUsr.Columns[0].Width, height, dataGridUsr.Columns[0].Width - 20, dataGridUsr.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUsr.Rows[i].Cells[14].Value.ToString(), dataGridUsr.Font, Brushes.Black, new RectangleF(365 + dataGridUsr.Columns[0].Width, height, dataGridUsr.Columns[0].Width - 20, dataGridUsr.Rows[0].Height), str);
                    //Draw Row 7
                    e.Graphics.DrawRectangle(Pens.Black, 495 + dataGridUsr.Columns[0].Width, height, dataGridUsr.Columns[0].Width - 50, dataGridUsr.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUsr.Rows[i].Cells[5].Value.ToString(), dataGridUsr.Font, Brushes.Black, new RectangleF(495 + dataGridUsr.Columns[0].Width, height, dataGridUsr.Columns[0].Width - 50, dataGridUsr.Rows[0].Height), str);
                    //Draw Row 8
                    e.Graphics.DrawRectangle(Pens.Black, 595 + dataGridUsr.Columns[0].Width, height, dataGridUsr.Columns[0].Width - 60, dataGridUsr.Rows[0].Height);
                    e.Graphics.DrawString(dataGridUsr.Rows[i].Cells[11].Value.ToString(), dataGridUsr.Font, Brushes.Black, new RectangleF(595 + dataGridUsr.Columns[0].Width, height, dataGridUsr.Columns[0].Width - 60, dataGridUsr.Rows[0].Height), str);

                    width += dataGridUsr.Columns[0].Width;
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
                pos = dataGridUsr.CurrentRow.Index;
                String valor = "";
                valor = dataGridUsr[0, pos].Value.ToString();
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
