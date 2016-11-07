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
    public partial class BuscarProductos : Form
    {
        Conexion cs = new Conexion();

        public int indica = 1;
        public Int64 codUser = 0;
        int pos = 0;

        public BuscarProductos()
        {
            InitializeComponent();

            toolTip1.SetToolTip(buscarprod, "Introducir Codigo de Barras del Producto o Referencia del Producto");
            toolTip1.SetToolTip(searchprod, "Buscar");
            toolTip1.SetToolTip(btnName, "Buscar por Nombre");
            toolTip1.SetToolTip(btnDet, "Buscar por Descripción");
            toolTip1.SetToolTip(btnCode, "Buscar por Codigo de Registro");
            toolTip1.SetToolTip(precio, "Precio Unitario del Producto [Bs]");
            toolTip1.SetToolTip(stock, "Numero de Unidades del Producto");
        }

        private void searchci_Click(object sender, EventArgs e)
        {
            if (buscarprod.Text != "" && buscarprod.Font.Italic == true)
            {
                if (buscarprod.Text == "")
                {
                    MessageBox.Show("Ingrese el Nombre o Descripción del Producto a Buscar.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    MessageBox.Show("Ingrese el Nombre o Descripción del Producto a Buscar.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (buscarprod.Text =="")
            {
                    MessageBox.Show("Ingrese el Nombre o Descripción del Producto a Buscar.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (indica == 1)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Productos WHERE nomProd LIKE '" + buscarprod.Text + "%'", cs.GetCONN());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    listproduct.DataSource = dt;
                }
                else if (indica == 2)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Productos WHERE DescProd LIKE '" + buscarprod.Text + "%'", cs.GetCONN());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    listproduct.DataSource = dt;
                }
                else if (indica == 3)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Productos WHERE CodBarP LIKE '" + buscarprod.Text + "%'", cs.GetCONN());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    listproduct.DataSource = dt;
                }
                else
                {
                    // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
                    this.productosTableAdapter.Fill(this.rEV_DataBaseDataSet.Productos);
                }               
            }
        }

        private void BusquedaProdClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (buscarprod.Text != "" && buscarprod.Font.Italic == true)
                {
                    buscarprod.Text = "";
                    buscarprod.ForeColor = SystemColors.WindowText;
                    buscarprod.Font = new Font(buscarprod.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    buscarprod.ForeColor = SystemColors.WindowText;
                    buscarprod.Font = new Font(buscarprod.Font, FontStyle.Regular);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BuscarProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.rEV_DataBaseDataSet.Productos);
        }

        private void btnDet_Click(object sender, EventArgs e)
        {
            indica = 2;
            btnName.BackgroundImage = global::Proyect_Kardex.Properties.Resources.BuscarName_B;
            btnDet.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarDetalle;
            btnCode.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarCode_B;
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            indica = 3;
            btnName.BackgroundImage = global::Proyect_Kardex.Properties.Resources.BuscarName_B;
            btnDet.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarDetalle_B;
            btnCode.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarCode;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            indica = 1;
            btnName.BackgroundImage = global::Proyect_Kardex.Properties.Resources.BuscarName;
            btnDet.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarDetalle_B;
            btnCode.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarCode_B;
        }

        private void buscarprod_TextChanged(object sender, EventArgs e)
        {
            if (indica == 1)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Productos WHERE nomProd LIKE '" + buscarprod.Text + "%'", cs.GetCONN());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listproduct.DataSource = dt;
            }
            else if (indica == 2)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Productos WHERE DescProd LIKE '" + buscarprod.Text + "%'", cs.GetCONN());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listproduct.DataSource = dt;
            }
            else if (indica == 3)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Productos WHERE CodBarP LIKE '" + buscarprod.Text + "%'", cs.GetCONN());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listproduct.DataSource = dt;
            }
            else
            {
                // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
                this.productosTableAdapter.Fill(this.rEV_DataBaseDataSet.Productos);
            }
        }

        private String GetCategory(int value)
        {
            String res = "";
            Conexion d = new Conexion();
            string query = "SELECT * FROM Categorias WHERE codCat = '" + value + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
            d.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    res = read2.GetString(1);
                }
            }
            catch (Exception) { d.CerrarCnn(); }
            return res;
        }

        private String GetSubCategory(String valor)
        {
            String re = "";
            Conexion f = new Conexion();
            string query = "SELECT * FROM SubCategorias WHERE CodSubC = '" + valor + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, f.GetCONN());
            f.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    re = read2.GetString(1);
                }
            }
            catch (Exception) { f.CerrarCnn(); }
            //f.CerrarCnn();
            return re;
        }

        private void MostrarProducto(Int64 valor) 
        {
            string query = "SELECT * FROM Productos WHERE CodBarP ='" + valor + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
            SqlDataReader read;
         
            precio.Text = "";
            stock.Text = "";
            nameprod.Text = "";
            codprod.Text = "";
            categoriaprod.Text = "";
            ubicacionprod.Text = "";

            try
            {
                cs.OpenCnn();
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    Double val = read.GetDouble(11);
                    precio.Text = (Math.Round(val, 2)).ToString();
                    stock.Text = read.GetInt32(13).ToString();
                    nameprod.Text = read.GetString(1);
                    codprod.Text = read.GetInt64(0).ToString();
                    categoriaprod.Text = GetCategory(read.GetInt32(16));
                    ubicacionprod.Text = GetSubCategory(read.GetString(19));

                    // El campo productImage primero se almacena en un buffer
                    byte[] imageBuffer = (byte[])(read[8]);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);

                    imagenprod.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cs.CerrarCnn();
            }
            cs.CerrarCnn();                
        }

        private void listproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pos = listproduct.CurrentRow.Index;
                String valor = "";
                valor = listproduct[0, pos].Value.ToString();
                codUser = Int64.Parse(valor);

                MostrarProducto(codUser);
            }
            catch (Exception) { }
        }

        private void buscarprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscarprod.ForeColor = SystemColors.WindowText;
            buscarprod.Font = new Font(buscarprod.Font, FontStyle.Regular);
        }

    }
}
