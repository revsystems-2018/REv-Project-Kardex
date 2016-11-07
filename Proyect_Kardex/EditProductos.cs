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
    public partial class EditProductos : Form
    {
        Conexion cs = new Conexion();
        ValidacionText vb = new ValidacionText();
        OpenFileDialog img = new OpenFileDialog();
        OpenFileDialog img2 = new OpenFileDialog();

        public int codCate = 0;
        public String codSub = "";
        public int CodMark = 0;
        public String CodM = "";

        public EditProductos()
        {
            InitializeComponent();

            toolRegProd.SetToolTip(codprod, "Codigo de Barra del Producto");
            toolRegProd.SetToolTip(nameprod, "Nombre del Producto");
            toolRegProd.SetToolTip(textnamep, "Descripción del Producto");
            toolRegProd.SetToolTip(catebox, "Seleccionar Categoría");
            toolRegProd.SetToolTip(subcatebox, "Seleccionar Sub-Categoría");
            toolRegProd.SetToolTip(nommarca, "Seleccionar Marca");
            toolRegProd.SetToolTip(nommed, "Seleccionar Unidad de Medida");
            toolRegProd.SetToolTip(textpeso, "Peso del Producto [Gramos]");
            toolRegProd.SetToolTip(textvol, "Volumen del Producto [Mililitros]");
            toolRegProd.SetToolTip(statebox, "Seleccionar Estado del Producto");
            toolRegProd.SetToolTip(dateprod, "Seleccionar Fecha de Creación del Producto");
            toolRegProd.SetToolTip(dateTime2, "Seleccionar Fecha de Vencimiento del Producto");
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
            toolRegProd.SetToolTip(textCCU, "Costo de Compra Unitario");
            toolRegProd.SetToolTip(textPVU, "Precio de Venta Unitario");
            toolRegProd.SetToolTip(ivabox, "Seleccionar Impuesto de IVA");
            toolRegProd.SetToolTip(textcant, "Cantidad de Productos Entrantes");
            toolRegProd.SetToolTip(textMin, "Cantidad Mínima en Inventario");
            toolRegProd.SetToolTip(textMax, "Cantidad Máxima en Inventario");
            toolRegProd.SetToolTip(codGen, "Generar Codigo de Barras");
            toolRegProd.SetToolTip(veboton, "Mostrar Imagen del Producto");
            toolRegProd.SetToolTip(deleteboton, "Eliminar");
            toolRegProd.SetToolTip(button1, "Buscar");
            toolRegProd.SetToolTip(buscarprov, "Buscar");
            toolRegProd.SetToolTip(saveboton, "Guardar");
            toolRegProd.SetToolTip(salirboton, "Salir");
        }

        private void salirboton_Click(object sender, EventArgs e)
        {
            string message = "Esta Seguro que Desea Cancelar la Modificación del Producto?";
            string caption = "Cancelar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            { // Closes the parent form.
                this.Close();
            }
        }

        private void numcodprod(object sender, KeyPressEventArgs e)
        {
            codprod.ForeColor = SystemColors.WindowText;
            codprod.Font = new Font(codprod.Font, FontStyle.Regular);
            vb.soloNumeros(e);
        }

        private void nameprodnum(object sender, KeyPressEventArgs e)
        {
            nameprod.ForeColor = SystemColors.WindowText;
            nameprod.Font = new Font(nameprod.Font, FontStyle.Regular);
            vb.soloLetrasYNumeros(e);
        }

        private void numletdesc(object sender, KeyPressEventArgs e)
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

        private void numletemp(object sender, KeyPressEventArgs e)
        {
            textemprov.ForeColor = SystemColors.WindowText;
            textemprov.Font = new Font(textemprov.Font, FontStyle.Regular);
            vb.soloLetrasYNumeros(e);
        }

        private void numcant(object sender, KeyPressEventArgs e)
        {
            textcant.ForeColor = SystemColors.WindowText;
            textcant.Font = new Font(textcant.Font, FontStyle.Regular);
            vb.soloNumeros(e);
        }

        private void nummin(object sender, KeyPressEventArgs e)
        {
            textMin.ForeColor = SystemColors.WindowText;
            textMin.Font = new Font(textMin.Font, FontStyle.Regular);
            vb.soloNumeros(e);
        }

        private void nummax(object sender, KeyPressEventArgs e)
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

        private void pesoClick(object sender, MouseEventArgs e)
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

        private void volClick(object sender, MouseEventArgs e)
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

        private void codbarClick(object sender, MouseEventArgs e)
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

        private void codProveClick(object sender, MouseEventArgs e)
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

        private void nameempClick(object sender, MouseEventArgs e)
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

        private void ccuClick(object sender, MouseEventArgs e)
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

        private void pvuClick(object sender, MouseEventArgs e)
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

        private void cantProdClick(object sender, MouseEventArgs e)
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

        private void minClick(object sender, MouseEventArgs e)
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

        private void maxClick(object sender, MouseEventArgs e)
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


        private int comprobar() 
        {
            int cnt = 0;
            Conexion a = new Conexion();
            string buscar = "SELECT * FROM Productos WHERE CodBarP = '" + Int64.Parse(codbuscprod.Text) + "' ; ";

            try
            {
                a.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, a.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            a.CerrarCnn();
            return cnt;
        }


        private int comprobarProveedor()
        {
            int cnt = 0;
            Conexion b = new Conexion();
            string buscar = "SELECT * FROM Proveedores WHERE codProve = '" + Convert.ToInt32(textcodprov.Text) + "' ; ";

            try
            {
                b.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, b.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = cnt + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            b.CerrarCnn();
            return cnt;
        }


        private void buscarprov_Click(object sender, EventArgs e)
        {
            Conexion s = new Conexion();
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
            { //Codigo de Buscar proveedor.
                string query = "SELECT * FROM Proveedores WHERE codProve ='" + Convert.ToInt32(textcodprov.Text) + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, s.GetCONN());
                SqlDataReader read;
                if (comprobarProveedor() == 1)
                {
                    textemprov.Text = "";
                    textemprov.ForeColor = SystemColors.WindowText;
                    textemprov.Font = new Font(textemprov.Font, FontStyle.Regular);                   

                    try
                    {
                        s.OpenCnn();
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            textemprov.Text = read.GetString(14);                                                                    
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Existe Datos Nulos con el Proveedor Ingresado. \n" + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con el Proveedor Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, El Proveedor Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    s.CerrarCnn();
                }
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
            img.InitialDirectory = "C:\\";
            img.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            img.Title = "Abrir Imagen del Producto";

            if (img.ShowDialog() == DialogResult.OK)
            {
                textfoto.Text = "";
                textfoto.ForeColor = SystemColors.WindowText;
                textfoto.Font = new Font(textfoto.Font, FontStyle.Regular);
                textfoto.Text = img.FileName;
                //fotoCliente.ImageLocation = img.FileName;
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
                picturefoto.ImageLocation = img.FileName;
            }
        }

        private void opencodbar_Click(object sender, EventArgs e)
        {
            img2.InitialDirectory = "C:\\";
            img2.Filter = "PNG Imagen (*.png)|*.png| Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";
            img2.Title = "Abrir Imagen de Codigo";

            if (img2.ShowDialog() == DialogResult.OK)
            {
                textcodbar.Text = "";
                textcodbar.ForeColor = SystemColors.WindowText;
                textcodbar.Font = new Font(textfoto.Font, FontStyle.Regular);
                textcodbar.Text = img2.FileName;
                picturecodebar.ImageLocation = img2.FileName;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen Correcta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private String GetCategory(int value) 
        {
            String res = "";
            Conexion d = new Conexion();
            string query = "SELECT * FROM Categorias WHERE codCat = '"+value+"' ; ";

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
            catch (Exception){ }
            d.CerrarCnn();
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
            catch (Exception) { }
            f.CerrarCnn();
            return re;
        }


        private String GetMark(int value) 
        {
            String res = "";
            Conexion g = new Conexion();
            string query = "SELECT * FROM Marcas WHERE codMarca = '" + value + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, g.GetCONN());
            g.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    res = read2.GetString(2);
                }
            }
            catch (Exception) { }
            g.CerrarCnn();
            return res;
        }


        private String GetMedida(String value) 
        {
            String res = "";
            Conexion h = new Conexion();
            string query = "SELECT * FROM Medidas WHERE codMed = '" + value + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, h.GetCONN());
            h.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    res = read2.GetString(1);
                }
            }
            catch (Exception) { }
            h.CerrarCnn();
            return res;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            if (codbuscprod.Text != "" && codbuscprod.Font.Italic == true)
            {
                if (codbuscprod.Text == "")
                {
                    MessageBox.Show("Ingrese el Codigo de Barras del Producto que Muestra en la Tabla de Registro", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo de Barras del Producto que Muestra en la Tabla de Registro", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (codbuscprod.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo de Barras del Producto que Muestra en la Tabla de Registro", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "SELECT * FROM Productos WHERE CodBarP ='" + Int64.Parse(codbuscprod.Text) + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, c.GetCONN());
                SqlDataReader read;

                if (comprobar() == 1)
                {
                    codprod.Enabled = true;
                    nameprod.Enabled = true;
                    textnamep.Enabled = true;
                    catebox.Enabled = true;
                    subcatebox.Enabled = true;
                    nommarca.Enabled = true;
                    nommed.Enabled = true;
                    textpeso.Enabled = true;
                    textvol.Enabled = true;
                    statebox.Enabled = true;
                    dateprod.Enabled = false;
                    textfoto.Enabled = true;
                    textcodbar.Enabled = true;
                    opencodbar.Enabled = true;
                    openimg.Enabled = true;
                    botoncate.Enabled = true;
                    botonmarca.Enabled = true;
                    botonMed.Enabled = true;
                    botonprove.Enabled = true;
                    textcodprov.Enabled = true;
                    buscarprov.Enabled = true;
                    textemprov.Enabled = true;
                    textCCU.Enabled = true;
                    textPVU.Enabled = true;
                    ivabox.Enabled = true;
                    textcant.Enabled = true;
                    textMin.Enabled = true;
                    textMax.Enabled = true;
                    veboton.Enabled = true;
                    saveboton.Enabled = true;
                    dateTime2.Enabled = true;
                    checkdate.Enabled = true;
                    textfoto.Enabled = true;
                    textcodbar.Enabled = true;
                    picturecodebar.Enabled = true;
                    picturefoto.Enabled = true;

                    //Codigo de Buscar producto.

                    codprod.Text = "";
                    codprod.ForeColor = SystemColors.WindowText;
                    codprod.Font = new Font(codprod.Font, FontStyle.Regular);
                    nameprod.Text = "";
                    nameprod.ForeColor = SystemColors.WindowText;
                    nameprod.Font = new Font(nameprod.Font, FontStyle.Regular);
                    textnamep.Text = "";
                    textnamep.ForeColor = SystemColors.WindowText;
                    textnamep.Font = new Font(textnamep.Font, FontStyle.Regular);
                    textpeso.Text = "";
                    textpeso.ForeColor = SystemColors.WindowText;
                    textpeso.Font = new Font(textpeso.Font, FontStyle.Regular);
                    textvol.Text = "";
                    textvol.ForeColor = SystemColors.WindowText;
                    textvol.Font = new Font(textvol.Font, FontStyle.Regular);
                    textfoto.Text = "";
                    textfoto.ForeColor = SystemColors.WindowText;
                    textfoto.Font = new Font(textfoto.Font, FontStyle.Regular);
                    textcodbar.Text = "";
                    textcodbar.ForeColor = SystemColors.WindowText;
                    textcodbar.Font = new Font(textcodbar.Font, FontStyle.Regular);
                    textcodprov.Text = "";
                    textcodprov.ForeColor = SystemColors.WindowText;
                    textcodprov.Font = new Font(textcodprov.Font, FontStyle.Regular);
                    textemprov.Text = "";
                    textemprov.ForeColor = SystemColors.WindowText;
                    textemprov.Font = new Font(textemprov.Font, FontStyle.Regular);
                    textCCU.Text = "";
                    textCCU.ForeColor = SystemColors.WindowText;
                    textCCU.Font = new Font(textCCU.Font, FontStyle.Regular);
                    textPVU.Text = "";
                    textPVU.ForeColor = SystemColors.WindowText;
                    textPVU.Font = new Font(textPVU.Font, FontStyle.Regular);
                    textcant.Text = "";
                    textcant.ForeColor = SystemColors.WindowText;
                    textcant.Font = new Font(textcant.Font, FontStyle.Regular);
                    textMin.Text = "";
                    textMin.ForeColor = SystemColors.WindowText;
                    textMin.Font = new Font(textMin.Font, FontStyle.Regular);
                    textMax.Text = "";
                    textMax.ForeColor = SystemColors.WindowText;
                    textMax.Font = new Font(textMax.Font, FontStyle.Regular);

                    try
                    {
                        c.OpenCnn();
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            codprod.Text = read.GetInt64(0).ToString();
                            nameprod.Text = read.GetString(1);
                            textnamep.Text = read.GetString(2);
                            textpeso.Text = read.GetDouble(3).ToString();
                            textvol.Text = read.GetDouble(4).ToString();
                            statebox.SelectedItem = read.GetString(5);
                            //textfoto.Text = read.GetString(14);
                            //textcodbar.Text = read.GetString(14);
                            //textemprov.Text = read.GetString(14);
                            ivabox.SelectedItem = read.GetString(12);
                            textCCU.Text = read.GetDouble(10).ToString();
                            textPVU.Text = read.GetDouble(11).ToString();
                            textcant.Text = read.GetInt32(13).ToString();
                            textMin.Text = read.GetInt32(14).ToString();
                            textMax.Text = read.GetInt32(15).ToString();
                            catebox.SelectedItem = GetCategory(read.GetInt32(16));
                            subcatebox.SelectedItem = GetSubCategory(read.GetString(19));
                            nommarca.SelectedItem = GetMark(read.GetInt32(17));
                            nommed.SelectedItem = GetMedida(read.GetString(18));
                            textcodprov.Text = read.GetInt32(20).ToString();

                            // El campo productImage primero se almacena en un buffer
                            byte[] imageBuffer = (byte[])(read[8]);
                            byte[] imgCode = (byte[])(read[9]);
                            // Se crea un MemoryStream a partir de ese buffer                        
                            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                            System.IO.MemoryStream ms2 = new System.IO.MemoryStream(imgCode);

                            picturefoto.Image = Image.FromStream(ms);
                            picturecodebar.Image = Image.FromStream(ms2);                           
                        }
                        c.CerrarCnn();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Existe Datos Nulos con el Producto Ingresado. \n" + ex.Message + "\nCompruebe Que No Exista Datos Nulos o Vacios con el Producto Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        c.CerrarCnn();
                    }
                }
                else 
                {
                    MessageBox.Show("ERROR, El Producto Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    c.CerrarCnn();
                }
            }
        }

        private void deleteboton_Click(object sender, EventArgs e)
        {
            if (codbuscprod.Text != "" && codbuscprod.Font.Italic == true)
            {
                if (codbuscprod.Text == "")
                {
                    MessageBox.Show("Ingrese el Codigo de Barras del Producto que Muestra en la Tabla de Registro", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo de Barras del Producto que Muestra en la Tabla de Registro", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (codbuscprod.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo de Barras del Producto que Muestra en la Tabla de Registro", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de Eliminar producto.
                if (comprobar() == 1)
                {
                    try
                    {   // Objetos de conexión y comando
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = cs.GetCONN();
                        cmd.CommandText = "DELETE FROM Productos WHERE CodBarP = '" + Int64.Parse(codbuscprod.Text) + "' ;";

                        cs.OpenCnn();
                        cmd.ExecuteNonQuery();
                        cs.CerrarCnn();

                        Messengers mr = new Messengers();
                        mr.textolb.Text = "Producto Eliminado";
                        mr.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR. Al Eliminar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, No Existen Registros del Producto.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void decipesoe(object sender, KeyPressEventArgs e)
        {
            textpeso.ForeColor = SystemColors.WindowText;
            textpeso.Font = new Font(textpeso.Font, FontStyle.Regular);
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
                else if ((e.KeyChar == ',') && (!textpeso.Text.Contains(",")))
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

        private void decivole(object sender, KeyPressEventArgs e)
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

        private void deciccue(object sender, KeyPressEventArgs e)
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

        private void decipvue(object sender, KeyPressEventArgs e)
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
            REV_BarCode re = new REV_BarCode();
            re.ShowDialog();
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

        private void codbuscprod_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (codbuscprod.Text != "" && codbuscprod.Font.Italic == true)
                {
                    codbuscprod.Text = "";
                    codbuscprod.ForeColor = SystemColors.WindowText;
                    codbuscprod.Font = new Font(codbuscprod.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    codbuscprod.ForeColor = SystemColors.WindowText;
                    codbuscprod.Font = new Font(codbuscprod.Font, FontStyle.Regular);
                }
            }
        }

        private void codbuscprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            codbuscprod.ForeColor = SystemColors.WindowText;
            codbuscprod.Font = new Font(codbuscprod.Font, FontStyle.Regular);
            vb.soloNumeros(e);
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
            Conexion j = new Conexion();
            string query = "SELECT * FROM Categorias; ";

            SqlCommand sqlQ = new SqlCommand(query, j.GetCONN());
            j.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(1);
                    catebox.Items.Add(Scad);
                }
                j.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                j.CerrarCnn();
            }
        }

        private void CargarMedida()
        {
            Conexion k = new Conexion();
            string query = "SELECT * FROM Medidas; ";

            SqlCommand sqlQ = new SqlCommand(query, k.GetCONN());
            k.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(1);
                    nommed.Items.Add(Scad);
                }
                k.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                k.CerrarCnn();
            }
        }

        private void CargarMarca()
        {
            Conexion l = new Conexion();
            string query = "SELECT * FROM Marcas; ";

            SqlCommand sqlQ = new SqlCommand(query, l.GetCONN());
            l.OpenCnn();
            SqlDataReader read2;
            try
            {
                read2 = sqlQ.ExecuteReader();
                while (read2.Read())
                {
                    string Scad = read2.GetString(2);
                    nommarca.Items.Add(Scad);
                }
                l.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                l.CerrarCnn();
            }
        }


        private void EditProductos_Load(object sender, EventArgs e)
        {
            CargarCategoria();
            CargarMarca();
            CargarMedida();
        }

        private void catebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion q = new Conexion();
            string query = "SELECT nameSubC, codCat FROM SubCategorias, Categorias WHERE catCod=codCat AND DescCat= '" + catebox.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, q.GetCONN());
            q.OpenCnn();
            SqlDataReader read;
            try
            {
                read = sqlQ.ExecuteReader();
                subcatebox.Items.Clear();
                while (read.Read())
                {
                    String cade = read.GetString(0);
                    subcatebox.Items.Add(cade);
                    codCate = read.GetInt32(1);
                }
                q.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                q.CerrarCnn();
            }
        }

        private void subcatebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion w = new Conexion();
            string query = "SELECT CodSubC FROM SubCategorias WHERE nameSubC= '" + subcatebox.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, w.GetCONN());
            w.OpenCnn();
            SqlDataReader read;

            try
            {
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    codSub = read.GetString(0);
                }
                w.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                w.CerrarCnn();
            }
        }

        private void nommarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion ef = new Conexion();
            string query = "SELECT codMarca FROM Marcas WHERE DescMarca= '" + Convert.ToString(nommarca.Text) + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, ef.GetCONN());
            ef.OpenCnn();
            SqlDataReader read;

            try
            {
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    CodMark = read.GetInt32(0);
                }
                ef.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.ToString() + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ef.CerrarCnn();
            }
        }

        private void nommed_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion r = new Conexion();
            string query = "SELECT codMed FROM Medidas WHERE nameMed= '" + nommed.Text + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
            r.OpenCnn();
            SqlDataReader read;

            try
            {
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    CodM = read.GetString(0);
                }
                r.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado. " + ex.Message + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }
        }

        private void saveboton_Click(object sender, EventArgs e)
        {

            if ((codprod.Text != "" && codprod.Font.Italic == true) || nameprod.Font.Italic == true || textnamep.Font.Italic == true || textfoto.Font.Italic == true || textcodbar.Font.Italic == true || textcodprov.Font.Italic == true || textCCU.Font.Italic == true || textPVU.Font.Italic == true || textcant.Font.Italic == true || textMin.Font.Italic == true || textMax.Font.Italic == true)
            {
                if (codprod.Text == "")
                {
                    MessageBox.Show("Debe Ingresar los Datos del Producto a Modificar.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Ingresar los Datos del Producto a Modificar. Caso Contrario dejar en Blanco.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (codprod.Text == "")
            {
                MessageBox.Show("Ingrese el Código de Barras del Producto, para Proceder la Modificación del Registro.", "ERROR",
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
                if (comprobar() == 1)
                {
                    if (dateprod.Enabled == true)
                    {
                        DateTime date = Convert.ToDateTime(dateprod.Text);
                        try
                        {   // Objetos de conexión y comando
                            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                            // Estableciento propiedades
                            cmd.Connection = cs.GetCONN();
                            cmd.CommandText = "UPDATE Productos SET CodBarP=@cod, nomProd=@nom, DescProd=@desc, PesoProd=@peso, VolProd=@vol, EstadoProd=@state, fnProd=@fnp, fcProd=@fcp, imgProd=@imgp, imgCod=@imgc, CCUProd=@ccu, PVUProd=@pvu, rcivaProd=@iva, CantProd=@cant, SMinProd=@smin, SMaxProd=@smax, cateCod=@cat, markCod=@mark, medCod=@med, subCod=@sub, idProve=@prove WHERE CodBarP = @buscar ;";

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
                            cmd.Parameters.Add("@buscar", System.Data.SqlDbType.BigInt);

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
                            cmd.Parameters["@buscar"].Value = Int64.Parse(codbuscprod.Text);

                            cs.OpenCnn();
                            cmd.ExecuteNonQuery();
                            cs.CerrarCnn();

                            Messengers mr = new Messengers();
                            mr.textolb.Text = "Producto Modificado";
                            mr.ShowDialog();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR. Al Modificar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //DateTime date = Convert.ToDateTime("");
                        try
                        {   // Objetos de conexión y comando
                            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                            // Estableciento propiedades
                            cmd.Connection = cs.GetCONN();
                            cmd.CommandText = "UPDATE Productos SET CodBarP=@cod, nomProd=@nom, DescProd=@desc, PesoProd=@peso, VolProd=@vol, EstadoProd=@state, fnProd=@fnp, fcProd=@fcp, imgProd=@imgp, imgCod=@imgc, CCUProd=@ccu, PVUProd=@pvu, rcivaProd=@iva, CantProd=@cant, SMinProd=@smin, SMaxProd=@smax, cateCod=@cat, markCod=@mark, medCod=@med, subCod=@sub, idProve=@prove WHERE CodBarP = @buscar ;";

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
                            cmd.Parameters.Add("@buscar", System.Data.SqlDbType.BigInt);

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
                            cmd.Parameters["@buscar"].Value = Int64.Parse(codbuscprod.Text);

                            cs.OpenCnn();
                            cmd.ExecuteNonQuery();
                            cs.CerrarCnn();

                            Messengers mr = new Messengers();
                            mr.textolb.Text = "Producto Modificado";
                            mr.ShowDialog();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR. Al Modificar Los Datos. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("ERROR. El Producto No Existe, Contacte Con el Administrador. ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
