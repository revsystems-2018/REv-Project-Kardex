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
using System.Collections;

namespace Proyect_Kardex
{
    public partial class ShowSolClientes : Form
    {
        Conexion cs = new Conexion();
        public int codUser = 0;
        int pos = 0;

        int i = 0;

        public ShowSolClientes()
        {
            InitializeComponent();

            soltooltip.SetToolTip(nuevo, "Crear Nuevo Cliente");
            soltooltip.SetToolTip(editar, "Editar Cliente");
            soltooltip.SetToolTip(eliminar, "Eliminar Cliente");
            soltooltip.SetToolTip(actualizar, "Actualizar Reporte de Clientes");
            soltooltip.SetToolTip(print, "Imprimir Reporte de Clientes");
            soltooltip.SetToolTip(save, "Guardar");
            soltooltip.SetToolTip(salir, "Salir");
            soltooltip.SetToolTip(buscarcic, "Introducir Carnet de Identidad del Cliente");
            soltooltip.SetToolTip(searchci, "Buscar");

        }


        public int CodigoAdmin()
        {
            int res = 0;
            Conexion d = new Conexion();
            string query = "SELECT ciUser, nuUsuario FROM Usuario WHERE idUser='1'; ";

            SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
            d.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    if (codUser == 0)
                    {
                        res = read2.GetInt32(0);
                        res = 0;
                    }
                    else
                    {
                        res = codUser;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Con el Codigo del Administrador.\n" + ex.Message + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            d.CerrarCnn();
            return res;
        }


        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            SolCliente sc = new SolCliente();
            sc.codUser = codUser;
            sc.ShowDialog();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            SolCliente sep = new SolCliente();
            sep.label1.Text = "Editar Cliente";
            sep.buscaredboton.Visible = true;
            sep.button1.Visible = false;
            sep.elimLb.Visible = false;
            sep.saveLb.Visible = false;
            sep.saveboton.Visible = false;
            sep.editBtn.Visible = true;
            sep.editLb.Visible = true;
            sep.codUser = codUser;
            sep.cic.Text = buscarcic.Text;
            sep.cic.ForeColor = SystemColors.WindowText;
            sep.cic.Font = new Font(sep.cic.Font, FontStyle.Regular);
            sep.ShowDialog();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (buscarcic.Text != "" && buscarcic.Font.Italic == true)
            {
                if (buscarcic.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (buscarcic.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //Codigo de Eliminar Cliente.
                if (comprobar() == 1)
                {
                    try
                    {   // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "DELETE FROM SolClientes WHERE ciSolC = '" + Convert.ToInt32(buscarcic.Text) + "' ;";

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();

                        Messengers mr = new Messengers();
                        mr.textolb.Text = "Cliente Eliminado";
                        mr.ShowDialog();
                        buscarcic.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR. Al Eliminar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, No Existen Registros del Cliente.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        private int comprobar()
        {
            int cnt = 0;
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM SolClientes WHERE ciSolC= '" + Convert.ToInt32(buscarcic.Text) + "' ; ";
            d.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, d.GetCONN());
            try
            {
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            d.CerrarCnn();
            return cnt;
        }


        private void searchci_Click(object sender, EventArgs e)
        {
            if (buscarcic.Text != "" && buscarcic.Font.Italic == true)
            {
                if (buscarcic.Text == "")
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente Como se Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Carnet de Identidad del Cliente Como se Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (buscarcic.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente Como se Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //Codigo de Buscar Cliente.               
                if (comprobar() == 1)
                {
                    editar.Enabled = true;
                    eliminar.Enabled = true;      
                    editar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editdocumento;
                    eliminar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_delete;                
                }
                else
                {
                    MessageBox.Show("ERROR, El Cliente Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cibuscar(object sender, KeyPressEventArgs e)
        {
            buscarcic.ForeColor = SystemColors.WindowText;
            buscarcic.Font = new Font(buscarcic.Font, FontStyle.Regular);
            ValidacionText ex = new ValidacionText();
            ex.soloNumeros(e);
        }

        private void cibuscarClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (buscarcic.Text != "" && buscarcic.Font.Italic == true)
                {
                    buscarcic.Text = "";
                    buscarcic.ForeColor = SystemColors.WindowText;
                    buscarcic.Font = new Font(buscarcic.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    buscarcic.ForeColor = SystemColors.WindowText;
                    buscarcic.Font = new Font(buscarcic.Font, FontStyle.Regular);
                }
            }
        }

        private void ShowSolClientes_Load(object sender, EventArgs e)
        {
            codUser = CodigoAdmin();
            Conexion f = new Conexion();
            if (codUser == 0)
            {
                // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.SolClientes' Puede moverla o quitarla según sea necesario.
                this.solClientesTableAdapter.Fill(this.rEV_DataBaseDataSet.SolClientes);
                System.Data.SqlClient.SqlDataAdapter asd = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM SolClientes ;", f.GetCONN());
                DataTable dt = new DataTable();
                asd.Fill(dt);
                dataGridClientes.DataSource = dt;
            }
            else
            {
                // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.SolClientes' Puede moverla o quitarla según sea necesario.
                this.solClientesTableAdapter.Fill(this.rEV_DataBaseDataSet.SolClientes);
                System.Data.SqlClient.SqlDataAdapter asd = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM SolClientes WHERE codUsr = '" + codUser + "' ;", f.GetCONN());
                DataTable dt = new DataTable();
                asd.Fill(dt);
                dataGridClientes.DataSource = dt;
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            codUser = CodigoAdmin();
            Conexion f = new Conexion();
            if (codUser == 0)
            {
                // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.SolClientes' Puede moverla o quitarla según sea necesario.
                this.solClientesTableAdapter.Fill(this.rEV_DataBaseDataSet.SolClientes);
                System.Data.SqlClient.SqlDataAdapter asd = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM SolClientes ;", f.GetCONN());
                DataTable dt = new DataTable();
                asd.Fill(dt);
                dataGridClientes.DataSource = dt;
            }
            else
            {
                // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.SolClientes' Puede moverla o quitarla según sea necesario.
                this.solClientesTableAdapter.Fill(this.rEV_DataBaseDataSet.SolClientes);
                System.Data.SqlClient.SqlDataAdapter asd = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM SolClientes WHERE codUsr = '" + codUser + "' ;", f.GetCONN());
                DataTable dt = new DataTable();
                asd.Fill(dt);
                dataGridClientes.DataSource = dt;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            buscarcic.Text = "";
            buscarcic.ForeColor = SystemColors.WindowText;
            buscarcic.Font = new Font(buscarcic.Font, FontStyle.Regular);
        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dataGridClientes.CurrentRow.Index;
            buscarcic.Text = "";
            buscarcic.ForeColor = SystemColors.WindowText;
            buscarcic.Font = new Font(buscarcic.Font, FontStyle.Regular);
            buscarcic.Text = dataGridClientes[1, pos].Value.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Export_Excel ee = new Export_Excel();
            ee.ExportarDatosExcel(dataGridClientes);
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (this.printMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.printDocx.DocumentName = "Preparando Documento...";
                this.printDocx.Print();
            }
        }

        private void printview_Click(object sender, EventArgs e)
        {
            PreviewPrint.Document = printDocx;          
            PreviewPrint.ShowDialog();
        }

        private void printDocx_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Inicio del encabezado del Documento.
            string query = "SELECT * FROM Empresa ; ";
            Conexion g = new Conexion();
            SqlCommand sqlQ = new SqlCommand(query, g.GetCONN());
            g.OpenCnn();
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
                e.Graphics.DrawString("Solicitudes de Clientes", new Font("Lucida Sans", 18), new SolidBrush(Color.DarkBlue), img.Width + 400, 60);
                //fin Encabezado Documento.



                //Insert DataGrid Print.
                #region Draw Column 1
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[1].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(10, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(10 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 10 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[2].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(10 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(110 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 110 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[3].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(110 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 4
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(210 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 210 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[4].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(210 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 5
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(310 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 310 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[5].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(310 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 6
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(410 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width+10, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 410 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width+10, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[6].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(410 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width+10, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 7
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(530 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width-20, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 530 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width-20, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[7].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(530 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width-20, dataGridClientes.Rows[0].Height), str);
                #endregion

                #region Draw column 8
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(610 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 610 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width-20, dataGridClientes.Rows[0].Height);
                e.Graphics.DrawString(dataGridClientes.Columns[8].HeaderText, dataGridClientes.Font, Brushes.Black, new RectangleF(610 + dataGridClientes.Columns[0].Width, 200, dataGridClientes.Columns[0].Width-20, dataGridClientes.Rows[0].Height), str);
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
                    e.Graphics.DrawRectangle(Pens.Black, 10, height, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[1].FormattedValue.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(10, height, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, 10 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width-20, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[2].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(10 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width-20, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 110 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width-20, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[3].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(110 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width-20, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 4
                    e.Graphics.DrawRectangle(Pens.Black, 210 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width-20, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[4].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(210 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width-20, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 5
                    e.Graphics.DrawRectangle(Pens.Black, 310 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[5].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(310 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 6
                    e.Graphics.DrawRectangle(Pens.Black, 410 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[6].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(410 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 7
                    e.Graphics.DrawRectangle(Pens.Black, 530 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 40, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[7].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(530 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 40, dataGridClientes.Rows[0].Height), str);
                    //Draw Row 8
                    e.Graphics.DrawRectangle(Pens.Black, 610 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height);
                    e.Graphics.DrawString(dataGridClientes.Rows[i].Cells[8].Value.ToString(), dataGridClientes.Font, Brushes.Black, new RectangleF(610 + dataGridClientes.Columns[0].Width, height, dataGridClientes.Columns[0].Width - 20, dataGridClientes.Rows[0].Height), str);

                    width += dataGridClientes.Columns[0].Width;
                    i++;
                }

                #endregion

                g.CerrarCnn();
            }
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }           
        }



    }
}
