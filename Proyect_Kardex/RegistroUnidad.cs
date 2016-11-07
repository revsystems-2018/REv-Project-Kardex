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
    public partial class RegistroUnidad : Form
    {
        ValidacionText vc = new ValidacionText();

        public String codUser = "0";
        public String nomMedida = "";
        int pos = 0;
        int i = 0;

        public RegistroUnidad()
        {
            InitializeComponent();

            toolunidad.SetToolTip(selectboton,"Seleccionar Unidad");
            toolunidad.SetToolTip(nuevo, "Nueva Unidad");
            toolunidad.SetToolTip(editar, "Editar Unidad");
            toolunidad.SetToolTip(eliminar, "Eliminar Unidad");
            toolunidad.SetToolTip(actualizar, "Actualizar");
            toolunidad.SetToolTip(print, "Imprimir");
            toolunidad.SetToolTip(printview, "Pre-Vista");
            toolunidad.SetToolTip(save, "Guardar Excel");
            toolunidad.SetToolTip(salir, "Salir");        
        }

        private void RegistroUnidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Medidas' Puede moverla o quitarla según sea necesario.
            this.medidasTableAdapter.Fill(this.rEV_DataBaseDataSet.Medidas);

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {     
            AEEMedida ae = new AEEMedida();
            ae.savebtn.Visible = true;
            ae.gencode.Visible = true;
            ae.ShowDialog();                     
        }

        private void editar_Click(object sender, EventArgs e)
        {
            AEEMedida sd = new AEEMedida();
            sd.editbtn.Visible = true;
            sd.titulolabel.Text = "Modificar Medida";
            sd.buscarboton.Visible = true;
            //cargar datos ala interfaz.
            sd.textcod.Text = codUser.ToString();
            sd.textcod.ForeColor = SystemColors.WindowText;
            sd.textcod.Font = new Font(sd.textcod.Font, FontStyle.Regular);
            sd.ShowDialog();
        }


        private int comprobar()
        {
            int cnt = 0;
            Conexion w = new Conexion();
            string buscar = "SELECT * FROM Medidas WHERE codMed = '" + codUser + "' ; ";

            try
            {
                w.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, w.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
                w.CerrarCnn();
            }
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            w.CerrarCnn();
            return cnt;
        }


        private void eliminar_Click(object sender, EventArgs e)
        {
            Conexion w = new Conexion();
            if (codUser == "0")
            {             
                MessageBox.Show("Debe Seleccionar una Medida de la Tabla de Registros para Proceder la Eliminación", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {  //Codigo de Eliminar Marca.
                if (comprobar() == 1)
                {
                    try
                    {   // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = w.GetCONN();
                        cmd.CommandText = "DELETE FROM Medidas WHERE codMed = '" + codUser + "' ;";

                        w.OpenCnn();
                        cmd.ExecuteNonQuery();
                        w.CerrarCnn();

                        Messengers mr = new Messengers();
                        mr.textolb.Text = "Marca Eliminada";
                        mr.ShowDialog();                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR. Al Eliminar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, No Existen Registros de la Medida.\nActualizar el Registro.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void selectboton_Click(object sender, EventArgs e)
        {
            try
            {
                pos = dataGridMed.CurrentRow.Index;
                String valor = "";
                valor = dataGridMed[0, pos].Value.ToString();
                nomMedida = dataGridMed[1, pos].Value.ToString();
                codUser = valor;

                this.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            Export_Excel ex = new Export_Excel();
            ex.ExportarDatosExcel(dataGridMed);
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Medidas' Puede moverla o quitarla según sea necesario.
            this.medidasTableAdapter.Fill(this.rEV_DataBaseDataSet.Medidas);
        }

        private void dataGridMed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pos = dataGridMed.CurrentRow.Index;
                String valor = "";
                valor = dataGridMed[0, pos].Value.ToString();
                codUser = valor;

                selectboton.Enabled = true;
                selectboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Select; 
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
            Conexion w = new Conexion();
            string query = "SELECT * FROM Empresa ; ";
            SqlCommand sqlQ = new SqlCommand(query, w.GetCONN());
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
                w.OpenCnn();
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
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(250, 200, dataGridMed.Columns[0].Width, dataGridMed.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 250, 200, dataGridMed.Columns[0].Width, dataGridMed.Rows[0].Height);
                e.Graphics.DrawString(dataGridMed.Columns[0].HeaderText, dataGridMed.Font, Brushes.Black, new RectangleF(250, 200, dataGridMed.Columns[0].Width, dataGridMed.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(250 + dataGridMed.Columns[0].Width, 200, dataGridMed.Columns[0].Width + 30, dataGridMed.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 250 + dataGridMed.Columns[0].Width, 200, dataGridMed.Columns[0].Width + 30, dataGridMed.Rows[0].Height);
                e.Graphics.DrawString(dataGridMed.Columns[1].HeaderText, dataGridMed.Font, Brushes.Black, new RectangleF(250 + dataGridMed.Columns[0].Width, 200, dataGridMed.Columns[0].Width + 30, dataGridMed.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(380 + dataGridMed.Columns[0].Width, 200, dataGridMed.Columns[0].Width + 20, dataGridMed.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 380 + dataGridMed.Columns[0].Width, 200, dataGridMed.Columns[0].Width + 20, dataGridMed.Rows[0].Height);
                e.Graphics.DrawString(dataGridMed.Columns[2].HeaderText, dataGridMed.Font, Brushes.Black, new RectangleF(380 + dataGridMed.Columns[0].Width, 200, dataGridMed.Columns[0].Width + 20, dataGridMed.Rows[0].Height), str);
                #endregion


                #region Draw Rows N
                width = 10 + dataGridMed.Columns[0].Width;
                height = 200;
                //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
                while (i < dataGridMed.Rows.Count)
                {
                    if (height > e.MarginBounds.Height)
                    {
                        height = 200;
                        width = 10;
                        e.HasMorePages = true;
                        return;
                    }

                    height += dataGridMed.Rows[i].Height;
                    //Draw Row 1
                    e.Graphics.DrawRectangle(Pens.Black, 250, height, dataGridMed.Columns[0].Width, dataGridMed.Rows[0].Height);
                    e.Graphics.DrawString(dataGridMed.Rows[i].Cells[0].FormattedValue.ToString(), dataGridMed.Font, Brushes.Black, new RectangleF(250, height, dataGridMed.Columns[0].Width, dataGridMed.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, 250 + dataGridMed.Columns[0].Width, height, dataGridMed.Columns[0].Width - 30, dataGridMed.Rows[0].Height);
                    e.Graphics.DrawString(dataGridMed.Rows[i].Cells[1].Value.ToString(), dataGridMed.Font, Brushes.Black, new RectangleF(250 + dataGridMed.Columns[0].Width, height, dataGridMed.Columns[0].Width - 30, dataGridMed.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 380 + dataGridMed.Columns[0].Width, height, dataGridMed.Columns[0].Width + 20, dataGridMed.Rows[0].Height);
                    e.Graphics.DrawString(dataGridMed.Rows[i].Cells[2].Value.ToString(), dataGridMed.Font, Brushes.Black, new RectangleF(380 + dataGridMed.Columns[0].Width, height, dataGridMed.Columns[0].Width + 20, dataGridMed.Rows[0].Height), str);

                    width += dataGridMed.Columns[0].Width;
                    i++;
                }

                #endregion

                w.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                w.CerrarCnn();
            }
        }


    }
}
