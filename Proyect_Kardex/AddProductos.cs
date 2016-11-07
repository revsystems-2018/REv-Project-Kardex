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
using System.IO;

namespace Proyect_Kardex
{
    public partial class AddProductos : Form
    {
        ValidacionText vb = new ValidacionText();
        OpenFileDialog img = new OpenFileDialog();
        OpenFileDialog img2 = new OpenFileDialog();

        public int codCate = 0;
        public String codSub = "";
        public int CodMark = 0;
        public String CodM = "";

        public AddProductos()
        {
            InitializeComponent();

            toolRegProd.SetToolTip(codprod,"Codigo de Barra del Producto");
            toolRegProd.SetToolTip(nameprod, "Nombre del Producto");
            toolRegProd.SetToolTip(textnamep, "Descripción del Producto");
            toolRegProd.SetToolTip(catebox, "Seleccionar Categoría");
            toolRegProd.SetToolTip(subcatebox, "Seleccionar Sub-Categoría");
            toolRegProd.SetToolTip(nommarca, "Seleccionar Marca");
            toolRegProd.SetToolTip(nommed, "Seleccionar Unidad de Medida");
            toolRegProd.SetToolTip(textpeso, "Peso del Producto [Gramos]");
            toolRegProd.SetToolTip(textvol, "Volumen del Producto [Mililitros]");
            toolRegProd.SetToolTip(statebox, "Seleccionar Estado del Producto");
            toolRegProd.SetToolTip(dateprod, "Seleccionar Fecha de Vencimiento del Producto");
            toolRegProd.SetToolTip(textfoto, "Abrir Ubicación de la Imagen del Producto");
            toolRegProd.SetToolTip(textcodbar, "Abrir Ubicación de la Imagen del Codigo de Barras");
            toolRegProd.SetToolTip(openimg, "Abrir");
            toolRegProd.SetToolTip(opencodbar, "Abrir");
            toolRegProd.SetToolTip(botoncate, "Registro de Categorías");
            toolRegProd.SetToolTip(botonmarca, "Registro de Marcas");
            toolRegProd.SetToolTip(botonMed, "Registro de Unidades de Medidas");
            toolRegProd.SetToolTip(botonprove, "Registro de Proveedores");
            toolRegProd.SetToolTip(textcodprov, "Codigo de Registro del Proveedor");
            toolRegProd.SetToolTip(textemprov, "Nombre de la Empresa del Proveedor");
            toolRegProd.SetToolTip(textCCU,"Costo de Compra Unitario");
            toolRegProd.SetToolTip(textPVU, "Precio de Venta Unitario");
            toolRegProd.SetToolTip(ivabox, "Seleccionar Impuesto de IVA");
            toolRegProd.SetToolTip(textcant, "Cantidad de Productos Entrantes");
            toolRegProd.SetToolTip(textMin, "Cantidad Mínima en Inventario");
            toolRegProd.SetToolTip(textMax, "Cantidad Máxima en Inventario");
            toolRegProd.SetToolTip(codGen, "Generar Codigo de Barras");
            toolRegProd.SetToolTip(veboton, "Mostrar Imagen del Producto");
            toolRegProd.SetToolTip(dateTime2, "Selecionar Fecha de Creación del Producto");
            toolRegProd.SetToolTip(saveboton, "Guardar");
            toolRegProd.SetToolTip(salirboton, "Salir");

        }

        private void numcodprod(object sender, KeyPressEventArgs e)
        {
            vb.soloNumeros(e);
            codprod.ForeColor = SystemColors.WindowText;
            codprod.Font = new Font(codprod.Font, FontStyle.Regular);

        }

        private void letranameprod(object sender, KeyPressEventArgs e)
        {
            vb.soloLetras(e);
            nameprod.ForeColor = SystemColors.WindowText;
            nameprod.Font = new Font(nameprod.Font, FontStyle.Regular);
        }

        private void dosdescprod(object sender, KeyPressEventArgs e)
        {
            textnamep.ForeColor = SystemColors.WindowText;
            textnamep.Font = new Font(textnamep.Font, FontStyle.Regular);
            vb.soloLetrasYNumeros(e);
        }

        private void numcodprove(object sender, KeyPressEventArgs e)
        {
            textcodprov.ForeColor = SystemColors.WindowText;
            textcodprov.Font = new Font(textcodprov.Font, FontStyle.Regular);
            vb.soloNumeros(e);
        }

        private void dosnameemp(object sender, KeyPressEventArgs e)
        {
            textemprov.ForeColor = SystemColors.WindowText;
            textemprov.Font = new Font(textemprov.Font, FontStyle.Regular);
            vb.soloLetrasYNumeros(e);
        }

        private void numcantprod(object sender, KeyPressEventArgs e)
        {
            textcant.ForeColor = SystemColors.WindowText;
            textcant.Font = new Font(textcant.Font, FontStyle.Regular);
            vb.soloNumeros(e);
        }

        private void numminprod(object sender, KeyPressEventArgs e)
        {
            textMin.ForeColor = SystemColors.WindowText;
            textMin.Font = new Font(textMin.Font, FontStyle.Regular);
            vb.soloNumeros(e);
        }

        private void nummaxprod(object sender, KeyPressEventArgs e)
        {
            textMax.ForeColor = SystemColors.WindowText;
            textMax.Font = new Font(textMax.Font, FontStyle.Regular);
            vb.soloNumeros(e);
        }

        private void codprodClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (codprod.Text != "" && codprod.Font.Italic == true)
                {
                    codprod.Text = "";
                    codprod.ForeColor = SystemColors.WindowText;
                    codprod.Font = new Font(codprod.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    codprod.ForeColor = SystemColors.WindowText;
                    codprod.Font = new Font(codprod.Font, FontStyle.Regular);
                }
            }
        }

        private void nameprodClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nameprod.Text != "" && nameprod.Font.Italic == true)
                {
                    nameprod.Text = "";
                    nameprod.ForeColor = SystemColors.WindowText;
                    nameprod.Font = new Font(nameprod.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    nameprod.ForeColor = SystemColors.WindowText;
                    nameprod.Font = new Font(nameprod.Font, FontStyle.Regular);
                }
            }
        }

        private void descprodClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textnamep.Text != "" && textnamep.Font.Italic == true)
                {
                    textnamep.Text = "";
                    textnamep.ForeColor = SystemColors.WindowText;
                    textnamep.Font = new Font(textnamep.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textnamep.ForeColor = SystemColors.WindowText;
                    textnamep.Font = new Font(textnamep.Font, FontStyle.Regular);
                }
            }
        }

        private void pesoprodClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textpeso.Text != "" && textpeso.Font.Italic == true)
                {
                    textpeso.Text = "";
                    textpeso.ForeColor = SystemColors.WindowText;
                    textpeso.Font = new Font(textpeso.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textpeso.ForeColor = SystemColors.WindowText;
                    textpeso.Font = new Font(textpeso.Font, FontStyle.Regular);
                }
            }
        }

        private void volprodClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textvol.Text != "" && textvol.Font.Italic == true)
                {
                    textvol.Text = "";
                    textvol.ForeColor = SystemColors.WindowText;
                    textvol.Font = new Font(textvol.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textvol.ForeColor = SystemColors.WindowText;
                    textvol.Font = new Font(textvol.Font, FontStyle.Regular);
                }
            }
        }

        private void imgprodClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textfoto.Text != "" && textfoto.Font.Italic == true)
                {
                    textfoto.Text = "";
                    textfoto.ForeColor = SystemColors.WindowText;
                    textfoto.Font = new Font(textfoto.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textfoto.ForeColor = SystemColors.WindowText;
                    textfoto.Font = new Font(textfoto.Font, FontStyle.Regular);
                }
            }
        }

        private void imgcodbarClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textcodbar.Text != "" && textcodbar.Font.Italic == true)
                {
                    textcodbar.Text = "";
                    textcodbar.ForeColor = SystemColors.WindowText;
                    textcodbar.Font = new Font(textcodbar.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textcodbar.ForeColor = SystemColors.WindowText;
                    textcodbar.Font = new Font(textcodbar.Font, FontStyle.Regular);
                }
            }
        }

        private void codregProveClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textcodprov.Text != "" && textcodprov.Font.Italic == true)
                {
                    textcodprov.Text = "";
                    textcodprov.ForeColor = SystemColors.WindowText;
                    textcodprov.Font = new Font(textcodprov.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textcodprov.ForeColor = SystemColors.WindowText;
                    textcodprov.Font = new Font(textcodprov.Font, FontStyle.Regular);
                }
            }
        }

        private void nameempproveClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textemprov.Text != "" && textemprov.Font.Italic == true)
                {
                    textemprov.Text = "";
                    textemprov.ForeColor = SystemColors.WindowText;
                    textemprov.Font = new Font(textemprov.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textemprov.ForeColor = SystemColors.WindowText;
                    textemprov.Font = new Font(textemprov.Font, FontStyle.Regular);
                }
            }
        }

        private void costoProdClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textCCU.Text != "" && textCCU.Font.Italic == true)
                {
                    textCCU.Text = "";
                    textCCU.ForeColor = SystemColors.WindowText;
                    textCCU.Font = new Font(textCCU.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textCCU.ForeColor = SystemColors.WindowText;
                    textCCU.Font = new Font(textCCU.Font, FontStyle.Regular);
                }
            }
        }

        private void precioClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textPVU.Text != "" && textPVU.Font.Italic == true)
                {
                    textPVU.Text = "";
                    textPVU.ForeColor = SystemColors.WindowText;
                    textPVU.Font = new Font(textPVU.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textPVU.ForeColor = SystemColors.WindowText;
                    textPVU.Font = new Font(textPVU.Font, FontStyle.Regular);
                }
            }
        }

        private void cantprodClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textcant.Text != "" && textcant.Font.Italic == true)
                {
                    textcant.Text = "";
                    textcant.ForeColor = SystemColors.WindowText;
                    textcant.Font = new Font(textcant.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textcant.ForeColor = SystemColors.WindowText;
                    textcant.Font = new Font(textcant.Font, FontStyle.Regular);
                }
            }
        }

        private void minprodClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textMin.Text != "" && textMin.Font.Italic == true)
                {
                    textMin.Text = "";
                    textMin.ForeColor = SystemColors.WindowText;
                    textMin.Font = new Font(textMin.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textMin.ForeColor = SystemColors.WindowText;
                    textMin.Font = new Font(textMin.Font, FontStyle.Regular);
                }
            }
        }

        private void maxprodClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (textMax.Text != "" && textMax.Font.Italic == true)
                {
                    textMax.Text = "";
                    textMax.ForeColor = SystemColors.WindowText;
                    textMax.Font = new Font(textMax.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    textMax.ForeColor = SystemColors.WindowText;
                    textMax.Font = new Font(textMax.Font, FontStyle.Regular);
                }
            }
        }

        private void salirboton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarprov_Click(object sender, EventArgs e)
        {
            if (textcodprov.Text != "" && textcodprov.Font.Italic == true)
            {
                if (textcodprov.Text == "")
                {
                    MessageBox.Show("Ingrese el Codigo de Registro del Proveedor que Muestra en la Tabla de Registro", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo de Registro del Proveedor que Muestra en la Tabla de Registro", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcodprov.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo de Registro del Proveedor que Muestra en la Tabla de Registro", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de Buscar proveedor.

            }
        }

        private void botonprove_Click(object sender, EventArgs e)
        {
            Registro_Proveedores re = new Registro_Proveedores();
            re.ShowDialog();

            textcodprov.ForeColor = SystemColors.WindowText;
            textcodprov.Font = new Font(textcodprov.Font, FontStyle.Regular);
            textcodprov.Text = re.codReg;

            textemprov.ForeColor = SystemColors.WindowText;
            textemprov.Font = new Font(textemprov.Font, FontStyle.Regular);
            textemprov.Text = re.nomEmp;
        }

        private void botoncate_Click(object sender, EventArgs e)
        {
            Registro_Categoria we = new Registro_Categoria();
            we.ShowDialog();
            catebox.SelectedItem = we.nomCate;
        }

        private void botonmarca_Click(object sender, EventArgs e)
        {
            RegistroMarcas zx = new RegistroMarcas();          
            zx.ShowDialog();
            nommarca.SelectedItem = zx.nomMarca;          
        }

        private void botonMed_Click(object sender, EventArgs e)
        {
            RegistroUnidad yu = new RegistroUnidad();
            yu.ShowDialog();
            nommed.SelectedItem = yu.nomMedida;
        }

        private void openimg_Click(object sender, EventArgs e)
        {
            img2.InitialDirectory = "C:\\";
            img2.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            img2.Title = "Abrir Imagen del Producto";

            if (img2.ShowDialog() == DialogResult.OK)
            {
                textfoto.Text = "";
                textfoto.ForeColor = SystemColors.WindowText;
                textfoto.Font = new Font(textfoto.Font, FontStyle.Regular);
                textfoto.Text = img2.FileName;
                //fotoCliente.ImageLocation = img2.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void veboton_Click(object sender, EventArgs e)
        {
            if (textfoto.Text != "" && textfoto.Font.Italic == true)
            {
                if (textfoto.Text == "")
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Abrir Y Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textfoto.Text == "")
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta o Escriba la Dirección de la Imagen.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                picturefoto.ImageLocation = img2.FileName;
            }
        }

        private void opencodbar_Click(object sender, EventArgs e)
        {
            img.InitialDirectory = "C:\\";
            img.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            img.Title = "Abrir Imagen de Codigo";

            if (img.ShowDialog() == DialogResult.OK)
            {
                textcodbar.Text = "";
                textcodbar.ForeColor = SystemColors.WindowText;
                textcodbar.Font = new Font(textcodbar.Font, FontStyle.Regular);
                textcodbar.Text = img.FileName;
                picturecodebar.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void decipeso(object sender, KeyPressEventArgs e)
        {
            textpeso.ForeColor = SystemColors.WindowText;
            textpeso.Font = new Font(textpeso.Font, FontStyle.Regular);
            try {

                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if ((e.KeyChar == ',') && (!textpeso.Text.Contains(",")))
                {
                    e.Handled = false;
                }
                else 
                {
                    e.Handled = true;
                }
            }
            catch (Exception){
            
            }
        }

        private void decivol(object sender, KeyPressEventArgs e)
        {
            textvol.ForeColor = SystemColors.WindowText;
            textvol.Font = new Font(textvol.Font, FontStyle.Regular);
            try
            {

                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if ((e.KeyChar == ',') && (!textvol.Text.Contains(",")))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void deciccu(object sender, KeyPressEventArgs e)
        {
            textCCU.ForeColor = SystemColors.WindowText;
            textCCU.Font = new Font(textCCU.Font, FontStyle.Regular);
            try
            {

                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if ((e.KeyChar == ',') && (!textCCU.Text.Contains(",")))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void decipvu(object sender, KeyPressEventArgs e)
        {
            textPVU.ForeColor = SystemColors.WindowText;
            textPVU.Font = new Font(textPVU.Font, FontStyle.Regular);
            try
            {

                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if ((e.KeyChar == ',') && (!textPVU.Text.Contains(",")))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void codGen_Click(object sender, EventArgs e)
        {
            REV_BarCode vb = new REV_BarCode();
            vb.ShowDialog();
        }

        private void checkdate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkdate.Checked)
            {
                dateprod.Enabled = true;
            }
            else
            {
                dateprod.Enabled = false;
            }
        }

        private void textfoto_KeyPress(object sender, KeyPressEventArgs e)
        {
            textfoto.ForeColor = SystemColors.WindowText;
            textfoto.Font = new Font(textfoto.Font, FontStyle.Regular);
        }

        private void textcodbar_KeyPress(object sender, KeyPressEventArgs e)
        {
            textcodbar.ForeColor = SystemColors.WindowText;
            textcodbar.Font = new Font(textcodbar.Font, FontStyle.Regular);
        }


        private void CargarCategoria() 
        {
            string query = "SELECT * FROM Categorias; ";
            Conexion cs = new Conexion();

            SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
            SqlDataReader read2;
            try
            {
                cs.OpenCnn();
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(1);
                    catebox.Items.Add(Scad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cs.CerrarCnn();
            }
        }

        private void CargarMedida() 
        {          
            string query = "SELECT * FROM Medidas; ";
            Conexion cd = new Conexion();

            SqlCommand sqlQ = new SqlCommand(query, cd.GetCONN());
            SqlDataReader read2;
            try
            {
                cd.OpenCnn();
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(1);
                    nommed.Items.Add(Scad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cd.CerrarCnn();
            }
        }

        private void CargarMarca() 
        {
            string query = "SELECT * FROM Marcas; ";
            Conexion cf = new Conexion();

            SqlCommand sqlQ = new SqlCommand(query, cf.GetCONN());
            SqlDataReader read2;
            try
            {
                cf.OpenCnn();
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(2);
                    nommarca.Items.Add(Scad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cf.CerrarCnn();
            }
        }

        private void AddProductos_Load(object sender, EventArgs e)
        {
            CargarCategoria();
            CargarMarca();
            CargarMedida();
        }

        private void catebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT nameSubC, codCat FROM SubCategorias, Categorias WHERE catCod=codCat AND DescCat= '" + catebox.Text + "' ; ";
            Conexion cd = new Conexion();

            SqlCommand sqlQ = new SqlCommand(query, cd.GetCONN());
            SqlDataReader read;

            try
            {
                cd.OpenCnn();
                read = sqlQ.ExecuteReader();
                subcatebox.Items.Clear();
                while (read.Read())
                {
                    String cade = read.GetString(0);
                    subcatebox.Items.Add(cade);
                    codCate = read.GetInt32(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cd.CerrarCnn();
            }
        }

        private void subcatebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT CodSubC FROM SubCategorias WHERE nameSubC= '" + subcatebox.Text + "' ; ";
            Conexion cs = new Conexion();

            SqlCommand sqlQ = new SqlCommand(query, cs.GetCONN());
            SqlDataReader read;

            try
            {
                cs.OpenCnn();
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {                   
                    codSub = read.GetString(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cs.CerrarCnn();
            }
        }

        private void nommarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT codMarca FROM Marcas WHERE DescMarca= '" + Convert.ToString(nommarca.Text) + "' ; ";
            Conexion cd = new Conexion();

            SqlCommand sqlQ = new SqlCommand(query, cd.GetCONN());
            SqlDataReader read;

            try
            {
                cd.OpenCnn();
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    CodMark = read.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.ToString() + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cd.CerrarCnn();
            }
        }

        private void nommed_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion cf = new Conexion();
            string query = "SELECT codMed FROM Medidas WHERE nameMed= '" + nommed.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, cf.GetCONN());
            SqlDataReader read;

            try
            {
                cf.OpenCnn();
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    CodM = read.GetString(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cf.CerrarCnn();
            }
        }


        private int comprobar()
        {
            int cnt = 0;
            Conexion cd = new Conexion();
            string buscar = "SELECT * FROM Productos WHERE CodBarP = '" + Convert.ToInt64(codprod.Text) + "' ; ";

            try
            {
                cd.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, cd.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            cd.CerrarCnn();
            return cnt;
        }


        private void saveboton_Click(object sender, EventArgs e)
        {
            Conexion cs = new Conexion();
            if ((codprod.Text != "" && codprod.Font.Italic == true) || nameprod.Font.Italic == true || textnamep.Font.Italic == true || textfoto.Font.Italic == true || textcodbar.Font.Italic == true || textcodprov.Font.Italic == true || textCCU.Font.Italic == true || textPVU.Font.Italic == true || textcant.Font.Italic == true || textMin.Font.Italic == true || textMax.Font.Italic == true)
            {
                if (codprod.Text == "")
                {
                    MessageBox.Show("Debe Ingresar los Datos del Producto a Registrar.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Ingresar los Datos del Producto a Registrar. Caso Contrario dejar en Blanco.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (codprod.Text == "")
            {
                MessageBox.Show("Ingrese el Código de Barras del Producto, para Proceder el Registro.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nameprod.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre o Identificación para el Producto. ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textcodprov.Text == "")
            {
                MessageBox.Show("Debe Ingresar el Codigo del Proveedor para el Producto a Registrar. ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textCCU.Text == "" || textPVU.Text == "")
            {
                MessageBox.Show("Debe Ingresar los Precios y Costos para el Producto. ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textcant.Text == "")
            {
                MessageBox.Show("Debe Ingresar un valor de Cantidad Entrante para el Producto. ", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(textMin.Text) >= int.Parse(textMax.Text))
            {
                MessageBox.Show("El Stock Mínimo No debe ser Mayor que el Stock Máximo.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comprobar() == 0)
                {
                    if (dateprod.Enabled == true)
                    {
                        DateTime date = Convert.ToDateTime(dateprod.Text);
                        try
                        {
                            // Objetos de conexión y comando
                           
                            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                            // Estableciento propiedades
                            cmd.Connection = cs.GetCONN();
                            cmd.CommandText = "INSERT INTO Productos VALUES (@cod, @nom, @desc, @peso, @vol, @state, @fnp, @fcp, @imgp, @imgc, @ccu, @pvu, @iva, @cant, @smin, @smax, @cat, @mark, @med, @sub, @prove)";

                            FileStream stream = new FileStream(textfoto.Text, FileMode.Open, FileAccess.Read);
                            FileStream stcod = new FileStream(textcodbar.Text, FileMode.Open, FileAccess.Read);
                            //Se inicializa un flujo de archivo con la imagen seleccionada desde el disco.
                            BinaryReader br = new BinaryReader(stream);
                            BinaryReader brcod = new BinaryReader(stcod);

                            FileInfo fi = new FileInfo(textfoto.Text);
                            FileInfo fj = new FileInfo(textcodbar.Text);

                            //Se inicializa un arreglo de Bytes del tamaño de la imagen
                            byte[] binData = new byte[stream.Length];
                            byte[] binCod = new byte[stcod.Length];
                            //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
                            //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
                            stream.Read(binData, 0, Convert.ToInt32(stream.Length));
                            stcod.Read(binCod, 0, Convert.ToInt32(stcod.Length));

                            // Creando los parámetros necesarios
                            cmd.Parameters.Add("@cod", System.Data.SqlDbType.BigInt);
                            cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@desc", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@peso", System.Data.SqlDbType.Float);
                            cmd.Parameters.Add("@vol", System.Data.SqlDbType.Float);
                            cmd.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@fnp", System.Data.SqlDbType.DateTime);
                            cmd.Parameters.Add("@fcp", System.Data.SqlDbType.DateTime);
                            cmd.Parameters.Add("@imgp", System.Data.SqlDbType.Image);
                            cmd.Parameters.Add("@imgc", System.Data.SqlDbType.Image);
                            cmd.Parameters.Add("@ccu", System.Data.SqlDbType.Float);
                            cmd.Parameters.Add("@pvu", System.Data.SqlDbType.Float);
                            cmd.Parameters.Add("@iva", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@cant", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@smin", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@smax", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@cat", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@mark", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@med", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@sub", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@prove", System.Data.SqlDbType.Int);

                            // Asignando el valor de la imagen
                            // Stream usado como buffer
                            //System.IO.MemoryStream mss = new System.IO.MemoryStream();
                            // Se guarda la imagen en el buffer
                            // picturelogo.Image.Save(mss, System.Drawing.Imaging.ImageFormat.Png);

                            // Asignando los valores a los atributos
                            cmd.Parameters["@cod"].Value = Int64.Parse(codprod.Text);
                            cmd.Parameters["@nom"].Value = nameprod.Text;
                            cmd.Parameters["@desc"].Value = textnamep.Text;
                            cmd.Parameters["@peso"].Value = float.Parse(textpeso.Text);
                            cmd.Parameters["@vol"].Value = float.Parse(textvol.Text);
                            cmd.Parameters["@state"].Value = statebox.Text;
                            cmd.Parameters["@fnp"].Value = date;
                            cmd.Parameters["@fcp"].Value = Convert.ToDateTime(dateTime2.Text);
                            cmd.Parameters["@imgp"].Value = binData;
                            cmd.Parameters["@imgc"].Value = binCod;
                            cmd.Parameters["@ccu"].Value = float.Parse(textCCU.Text);
                            cmd.Parameters["@pvu"].Value = float.Parse(textPVU.Text);
                            cmd.Parameters["@iva"].Value = ivabox.Text;
                            cmd.Parameters["@cant"].Value = int.Parse(textcant.Text);
                            cmd.Parameters["@smin"].Value = int.Parse(textMin.Text);
                            cmd.Parameters["@smax"].Value = int.Parse(textMax.Text);
                            cmd.Parameters["@cat"].Value = codCate;
                            cmd.Parameters["@mark"].Value = CodMark;
                            cmd.Parameters["@med"].Value = CodM;
                            cmd.Parameters["@sub"].Value = codSub;
                            cmd.Parameters["@prove"].Value = int.Parse(textcodprov.Text);

                            cs.OpenCnn();
                            cmd.ExecuteNonQuery();
                            cs.CerrarCnn();

                            Messengers mr = new Messengers();
                            mr.textolb.Text = "Producto Guardado";
                            mr.ShowDialog();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR. Al Insertar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else 
                    {
                        //DateTime date = Convert.ToDateTime("");
                        try
                        {
                            // Objetos de conexión y comando                          
                            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                            // Estableciento propiedades
                            cmd.Connection = cs.GetCONN();
                            cmd.CommandText = "INSERT INTO Productos VALUES (@cod, @nom, @desc, @peso, @vol, @state, @fnp, @fcp, @imgp, @imgc, @ccu, @pvu, @iva, @cant, @smin, @smax, @cat, @mark, @med, @sub, @prove)";

                            FileStream stream = new FileStream(textfoto.Text, FileMode.Open, FileAccess.Read);
                            FileStream stcod = new FileStream(textcodbar.Text, FileMode.Open, FileAccess.Read);
                            //Se inicializa un flujo de archivo con la imagen seleccionada desde el disco.
                            BinaryReader br = new BinaryReader(stream);
                            BinaryReader brcod = new BinaryReader(stcod);

                            FileInfo fi = new FileInfo(textfoto.Text);
                            FileInfo fj = new FileInfo(textcodbar.Text);

                            //Se inicializa un arreglo de Bytes del tamaño de la imagen
                            byte[] binData = new byte[stream.Length];
                            byte[] binCod = new byte[stcod.Length];
                            //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
                            //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
                            stream.Read(binData, 0, Convert.ToInt32(stream.Length));
                            stcod.Read(binCod, 0, Convert.ToInt32(stcod.Length));

                            // Creando los parámetros necesarios
                            cmd.Parameters.Add("@cod", System.Data.SqlDbType.BigInt);
                            cmd.Parameters.Add("@nom", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@desc", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@peso", System.Data.SqlDbType.Float);
                            cmd.Parameters.Add("@vol", System.Data.SqlDbType.Float);
                            cmd.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@fnp", System.Data.SqlDbType.DateTime);
                            cmd.Parameters.Add("@fcp", System.Data.SqlDbType.DateTime);
                            cmd.Parameters.Add("@imgp", System.Data.SqlDbType.Image);
                            cmd.Parameters.Add("@imgc", System.Data.SqlDbType.Image);
                            cmd.Parameters.Add("@ccu", System.Data.SqlDbType.Float);
                            cmd.Parameters.Add("@pvu", System.Data.SqlDbType.Float);
                            cmd.Parameters.Add("@iva", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@cant", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@smin", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@smax", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@cat", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@mark", System.Data.SqlDbType.Int);
                            cmd.Parameters.Add("@med", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@sub", System.Data.SqlDbType.VarChar);
                            cmd.Parameters.Add("@prove", System.Data.SqlDbType.Int);

                            // Asignando el valor de la imagen
                            // Stream usado como buffer
                            //System.IO.MemoryStream mss = new System.IO.MemoryStream();
                            // Se guarda la imagen en el buffer
                            // picturelogo.Image.Save(mss, System.Drawing.Imaging.ImageFormat.Png);

                            // Asignando los valores a los atributos
                            cmd.Parameters["@cod"].Value = Int64.Parse(codprod.Text);
                            cmd.Parameters["@nom"].Value = nameprod.Text;
                            cmd.Parameters["@desc"].Value = textnamep.Text;
                            cmd.Parameters["@peso"].Value = float.Parse(textpeso.Text);
                            cmd.Parameters["@vol"].Value = float.Parse(textvol.Text);
                            cmd.Parameters["@state"].Value = statebox.Text;
                            cmd.Parameters["@fnp"].Value = DBNull.Value;
                            cmd.Parameters["@fcp"].Value = Convert.ToDateTime(dateTime2.Text);
                            cmd.Parameters["@imgp"].Value = binData;
                            cmd.Parameters["@imgc"].Value = binCod;
                            cmd.Parameters["@ccu"].Value = float.Parse(textCCU.Text);
                            cmd.Parameters["@pvu"].Value = float.Parse(textPVU.Text);
                            cmd.Parameters["@iva"].Value = ivabox.Text;
                            cmd.Parameters["@cant"].Value = int.Parse(textcant.Text);
                            cmd.Parameters["@smin"].Value = int.Parse(textMin.Text);
                            cmd.Parameters["@smax"].Value = int.Parse(textMax.Text);
                            cmd.Parameters["@cat"].Value = codCate;
                            cmd.Parameters["@mark"].Value = CodMark;
                            cmd.Parameters["@med"].Value = CodM;
                            cmd.Parameters["@sub"].Value = codSub;
                            cmd.Parameters["@prove"].Value = int.Parse(textcodprov.Text);

                            cs.OpenCnn();
                            cmd.ExecuteNonQuery();
                            cs.CerrarCnn();

                            Messengers mr = new Messengers();
                            mr.textolb.Text = "Producto Guardado";
                            mr.ShowDialog();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR. Al Insertar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("ERROR. El Producto Ya Existe, Contacte Con el Administrador. ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



    }
}
