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
    public partial class Ventas : Form
    {
        ValidacionText cs = new ValidacionText();
        Conexion sd = new Conexion();
        int i = 0;

        public Double Devuelto = 0;

        public int codUsr = 7906442;
        public String id_Venta = "";
        DateTime dateday = DateTime.Today;

        //Variables para la Factura.
        String numf = "";
        String numA = "";
        String nitE = "";
        String fV = "";
        String nitci = "";
        String namecli = "";
        String detvf = "";
        String codCon = "";
        String fle = "";
        String codcli = "";
        String codnomusr = "";


        public Ventas()
        {
            InitializeComponent();

            SalesToolTip.SetToolTip(buscarprod, "Ingresar Codigo de Barras del Producto");
            SalesToolTip.SetToolTip(enterboton, "ENTER, Añadir a la lista de Ventas");
            SalesToolTip.SetToolTip(listProd, "Registro de Productos");
            SalesToolTip.SetToolTip(nitciclient, "Ingresar NIT o Carnet de Identidad del Cliente [Opcional]");
            SalesToolTip.SetToolTip(searchprod, "Buscar Cliente Registrado");
            SalesToolTip.SetToolTip(nameClient, "Ingresar Nombre del Cliente [Opcional]");
            SalesToolTip.SetToolTip(listClient, "Registro de Clientes");
            SalesToolTip.SetToolTip(NumProd, "Cantidad de Productos a Vender");
            SalesToolTip.SetToolTip(SubTotalPay, "Costo Sin Impuestos");
            SalesToolTip.SetToolTip(ivaPay, "RC-IVA, del 13% del Costo Total");
            SalesToolTip.SetToolTip(TotalPay, "Costo Total de la Lista de Ventas");
            SalesToolTip.SetToolTip(CantPay, "Efectivo a Pagar del Cliente");
            SalesToolTip.SetToolTip(typePayCombo, "Tipo de Pago del Cliente");
            SalesToolTip.SetToolTip(PayText, "Ingresar Monto que Pago el Cliente");
            SalesToolTip.SetToolTip(PayButton, "Agregar Pago del Cliente");
            SalesToolTip.SetToolTip(AddSale, "Completar Venta");
            SalesToolTip.SetToolTip(PrintFacture, "Generar/Imprimir Factura");
            SalesToolTip.SetToolTip(CleanList, "Suspender/Limpiar Lista de Ventas");
            SalesToolTip.SetToolTip(SalirButton, "Salir");
            SalesToolTip.SetToolTip(Descuentext, "Ingresar Descuento del Total de Venta [1-100]");
            SalesToolTip.SetToolTip(DetCheck, "Activar/Desactivar la Descripción");
            SalesToolTip.SetToolTip(detText, "Ingresar Descripción del Total de Ventas");
            SalesToolTip.SetToolTip(addDescuent, "Agregar Descuento [Opcional]");

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            typePayCombo.SelectedIndex = 0; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string message = "Esta Seguro que Desea Cancelar el Proceso de Venta.?";
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

        private void button8_Click(object sender, EventArgs e)
        {
            Double res = 0;
            foreach (DataGridViewRow row in dataGridVentas.Rows)
            {
                res = res + Convert.ToDouble(row.Cells[4].Value);
            }
            if (Descuentext.Text != "" && Descuentext.Font.Italic == true)
            {
                res = Math.Round(res, 2);
                CantPay.Text = res.ToString();
                UpdateDetVenta(CantPay.Text);
            }
            else
            {
                if (double.Parse(Descuentext.Text) > 0)
                {
                    Double de = (double.Parse(Descuentext.Text)) / 100;
                    Double pordesc = res * de;
                    res = res - pordesc;
                    res = Math.Round(res, 2);
                    CantPay.Text = res.ToString();
                    UpdateDetVenta(CantPay.Text);
                }
                else
                {
                    res = Math.Round(res, 2);
                    CantPay.Text = res.ToString();
                    UpdateDetVenta(CantPay.Text);
                }
            }
        }

        private String GetNameUsr(int val) 
        {
            String res = "";
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            Conexion d = new Conexion();
            string buscar = "SELECT nombreUser FROM Usuario WHERE ciUser = '" + val + "' ; ";
            d.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, d.GetCONN());
            try
            {
                SqlDataReader fb;
                fb = find.ExecuteReader();
                while (fb.Read())
                {
                    res = fb.GetString(0);
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            d.CerrarCnn();
            return res;
        }

        private int GetIdCliente() 
        {
            int res = 0;
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Clientes WHERE nitCliente = '" + nitciclient.Text + "' ; ";
            d.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, d.GetCONN());
            try
            {
                SqlDataReader fb;
                fb = find.ExecuteReader();
                while (fb.Read())
                {
                    res = fb.GetInt32(0);
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            d.CerrarCnn();
            return res;
        }

        private int VerClienteDB() 
        {
            int res = 0;
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Clientes WHERE nitCliente = '" + nitciclient.Text + "' ; ";
            d.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, d.GetCONN());
            try
            {
                SqlDataReader fb;
                fb = find.ExecuteReader();
                while (fb.Read())
                {
                    res = res + 1;
                }
            }
            catch (Exception) {  }
            d.CerrarCnn();
            return res;
        }

        private String GetDetVenta() 
        {
            String res = "";
            if (detText.Text == "" || detText.Font.Italic == true)
            {
                res = "";
            }
            else {
                res = "Son: " +detText.Text;
            }
            return res;
        }

        private Double GetDescVenta() 
        {
            Double res = 0;
            if (Descuentext.Text == "" || Descuentext.Font.Italic == true)
            {
                res = 0;
            }
            else 
            {
                res = Convert.ToDouble(Descuentext.Text);    
            }
            return res;
        }

        private void ActuaCantProd(Int64 qqq, int www, int rrr) 
        {
            Conexion ert = new Conexion();
            try
            {   // Objetos de conexión y comando
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = ert.GetCONN();
                cmd.CommandText = "UPDATE Productos SET CantProd=@id WHERE CodBarP = @ciid ;";

                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@ciid", System.Data.SqlDbType.BigInt);

                // Asignando los valores a los atributos
                cmd.Parameters["@id"].Value = (rrr - www);
                cmd.Parameters["@ciid"].Value = qqq;

                ert.OpenCnn();
                cmd.ExecuteNonQuery();
                ert.CerrarCnn();
            }
            catch (Exception) { }
        }

        public void ActualizarProducto(Int64 aaa, int bbb)  
        {
            int ccc = 0;
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Productos WHERE CodBarP = '" + aaa + "' ; ";
            d.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, d.GetCONN());
            try
            {
                SqlDataReader fb;
                fb = find.ExecuteReader();
                while (fb.Read())
                {
                    ccc = fb.GetInt32(13);
                }
                ActuaCantProd(aaa, bbb, ccc);
            }
            catch (Exception) { }
            d.CerrarCnn();
        }

        public void RegistrarDBVentas(String codigo)
        {
            Conexion d = new Conexion();
            try
            {   // Objetos de conexión y comando
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = d.GetCONN();
                cmd.CommandText = "INSERT INTO REV_Ventas VALUES (@id, @idusr, @nameusr, @nit, @namecli, @num, @sub, @iva, @total, @pago, @type, @apay, @desc, @cambio, @det, @fechav, @tonit)";

                // Creando los parámetros necesarios
                cmd.Parameters.Add("@id", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@idusr", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@nameusr", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@nit", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@namecli", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@num", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@sub", System.Data.SqlDbType.Float);
                cmd.Parameters.Add("@iva", System.Data.SqlDbType.Float);
                cmd.Parameters.Add("@total", System.Data.SqlDbType.Float);
                cmd.Parameters.Add("@pago", System.Data.SqlDbType.Float);
                cmd.Parameters.Add("@type", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@apay", System.Data.SqlDbType.Float);
                cmd.Parameters.Add("@desc", System.Data.SqlDbType.Float);
                cmd.Parameters.Add("@cambio", System.Data.SqlDbType.Float);
                cmd.Parameters.Add("@det", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@fechav", System.Data.SqlDbType.DateTime2);
                cmd.Parameters.Add("@tonit", System.Data.SqlDbType.VarChar);
           
                // Asignando los valores a los atributos
                cmd.Parameters["@id"].Value = codigo;
                cmd.Parameters["@idusr"].Value = codUsr;
                cmd.Parameters["@nameusr"].Value = GetNameUsr(codUsr);

                cmd.Parameters["@namecli"].Value = nameClient.Text;
                cmd.Parameters["@num"].Value = double.Parse(NumProd.Text);
                cmd.Parameters["@sub"].Value = double.Parse(SubTotalPay.Text);
                cmd.Parameters["@iva"].Value = double.Parse(ivaPay.Text);
                cmd.Parameters["@total"].Value = double.Parse(TotalPay.Text);
                cmd.Parameters["@pago"].Value = double.Parse(CantPay.Text);
                cmd.Parameters["@type"].Value = typePayCombo.Text;
                cmd.Parameters["@apay"].Value = double.Parse(PayText.Text);
                cmd.Parameters["@desc"].Value = GetDescVenta();
                cmd.Parameters["@cambio"].Value = Devuelto;
                cmd.Parameters["@det"].Value = GetDetVenta();
                cmd.Parameters["@fechav"].Value = dateday;
                cmd.Parameters["@tonit"].Value = nitciclient.Text;

                if (VerClienteDB() == 1) { cmd.Parameters["@nit"].Value = GetIdCliente(); } else { cmd.Parameters["@nit"].Value = DBNull.Value; }

                d.OpenCnn();
                cmd.ExecuteNonQuery();
                d.CerrarCnn();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. Al Insertar Los Datos Ventas. " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }


        private void AddSale_Click(object sender, EventArgs e)
        {
            dateday = DateTime.UtcNow;
            id_Venta = "V :" + codUsr + ": " + dateday.ToString();
            Conexion c = new Conexion();
            RegistrarDBVentas(id_Venta);

            try
            {   // Objetos de conexión y comando
                foreach (DataGridViewRow row in dataGridVentas.Rows)
                {
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                    // Estableciento propiedades
                    cmd.Connection = c.GetCONN();
                    cmd.CommandText = "INSERT INTO Detalle_Venta VALUES (@id, @name, @cant, @price, @fecha, @ubica, @total, @codv)";

                    // Creando los parámetros necesarios
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.BigInt);
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@cant", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@price", System.Data.SqlDbType.Float);
                    cmd.Parameters.Add("@fecha", System.Data.SqlDbType.DateTime);
                    cmd.Parameters.Add("@ubica", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@total", System.Data.SqlDbType.Float);
                    cmd.Parameters.Add("@codv", System.Data.SqlDbType.VarChar);

                    // Asignando los valores a los atributos
                    //row.Cells[0].Value
                    cmd.Parameters["@id"].Value = Convert.ToInt64(row.Cells[0].Value);
                    cmd.Parameters["@name"].Value = Convert.ToString(row.Cells[1].Value);
                    cmd.Parameters["@cant"].Value = Convert.ToInt32(row.Cells[2].Value);
                    cmd.Parameters["@price"].Value = Convert.ToDouble(row.Cells[3].Value);
                    cmd.Parameters["@fecha"].Value = dateday;
                    cmd.Parameters["@ubica"].Value = "Almacen Principal";
                    cmd.Parameters["@total"].Value = Convert.ToDouble(row.Cells[4].Value);
                    cmd.Parameters["@codv"].Value = id_Venta;

                    ActualizarProducto(Convert.ToInt64(row.Cells[0].Value), Convert.ToInt32(row.Cells[2].Value));

                    c.OpenCnn();
                    cmd.ExecuteNonQuery();
                    c.CerrarCnn();
                }

                Messengers sms = new Messengers();
                sms.textolb.Text = "Venta Registrada";
                sms.ShowDialog();
                PrintFacture.Enabled = true;
                printview.Enabled = true;
                AddSale.Enabled = false;
                CleanList.Enabled = false;
                SalirButton.Enabled = false;
                PayButton.Enabled = false;
                PayText.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. Al Insertar Los Datos del Detalle de Venta. " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void codProdnum(object sender, KeyPressEventArgs e)
        {
            cs.soloNumeros(e);
            buscarprod.ForeColor = SystemColors.WindowText;
            buscarprod.Font = new Font(buscarprod.Font, FontStyle.Regular);

            Conexion d = new Conexion();

            String nombre = "";
            Int64 codigo = 0;
            double precio = 0;
            int cantidad = 1;
            double total = 0;
            DateTime fecha = new DateTime();
            int cantidadProducto = 0;

            if(e.KeyChar == Convert.ToChar(Keys.Enter)){

                if (buscarprod.Text != "" && buscarprod.Font.Italic == true)
                {
                    if (buscarprod.Text == "")
                    {
                        MessageBox.Show("Ingrese el Codigo de Registro o Codigo de Barras del Producto que Muestra en la Tabla de Solicitudes", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el Codigo de Registro o Codigo de Barras del Producto que Muestra en la Tabla de Solicitudes", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (buscarprod.Text == "")
                {
                    MessageBox.Show("Ingrese el Codigo de Registro o Codigo de Barras del Producto que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //Codigo de ENTER PRESS de las Ventas.                
                    string query = "SELECT * FROM Productos WHERE CodBarP ='" + Convert.ToInt64(buscarprod.Text) + "' ; ";

                    SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
                    d.OpenCnn();
                    SqlDataReader read;
                    if (comprobarProducto() == 1)
                    {
                        try
                        {
                            read = sqlQ.ExecuteReader();
                            while (read.Read())
                            {
                                codigo = read.GetInt64(0);
                                nombre = read.GetString(1);
                                precio = read.GetDouble(11);
                                fecha = read.GetDateTime(6);
                                cantidadProducto = read.GetInt32(13);
                                total = precio;
                            }
                            //Verificar Stock y fechas.
                            if (cantidadProducto > 1)
                            {
                                int res = DateTime.Compare(fecha, dateday);
                                if (res > 0 || res == 0)
                                {
                                    //comparar mismo producto.
                                    if (ComprobarCodigoTb(codigo) == 1)
                                    {
                                        InsertMismoTb(codigo, precio);
                                        SumarCantProd();
                                        UpdateTotales();
                                        UpdatePayDesc();
                                        UpdateDetVenta(CantPay.Text);
                                    }
                                    else
                                    {
                                        InsertNuevoTb(codigo, nombre, cantidad, precio, total);
                                        SumarCantProd();
                                        UpdateTotales();
                                        UpdatePayDesc();
                                        UpdateDetVenta(CantPay.Text);
                                    }
                                }
                                else
                                {
                                    string message = "El Producto Está en el Limite del Vencimiento.\nDeseas Continuar Registrando la Venta.";
                                    string caption = "Advertencia";
                                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                    DialogResult result;
                                    // Displays the MessageBox.
                                    result = MessageBox.Show(message, caption, buttons);

                                    if (result == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        //comparar mismo producto.
                                        if (ComprobarCodigoTb(codigo) == 1)
                                        {
                                            InsertMismoTb(codigo, precio);
                                            SumarCantProd();
                                            UpdateTotales();
                                            UpdatePayDesc();
                                            UpdateDetVenta(CantPay.Text);
                                        }
                                        else
                                        {
                                            InsertNuevoTb(codigo, nombre, cantidad, precio, total);
                                            SumarCantProd();
                                            UpdateTotales();
                                            UpdatePayDesc();
                                            UpdateDetVenta(CantPay.Text);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("El Producto Está Inactivo.\nEl Producto Paso del Stock Mínimo.\nContacte con el Administrador.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        d.CerrarCnn();
                    }
                    else
                    {
                        MessageBox.Show("ERROR, El Producto Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else if(e.KeyChar == (char)13)
            {
                //Codigo de ENTER PRESS de las Ventas.                
                string query = "SELECT * FROM Productos WHERE CodBarP ='" + Convert.ToInt64(buscarprod.Text) + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
                d.OpenCnn();
                SqlDataReader read;
                if (comprobarProducto() == 1)
                {
                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            codigo = read.GetInt64(0);
                            nombre = read.GetString(1);
                            precio = read.GetDouble(11);
                            fecha = read.GetDateTime(6);
                            cantidadProducto = read.GetInt32(13);
                            total = precio;
                        }
                        //Verificar Stock y fechas.
                        if (cantidadProducto > 1)
                        {
                            int res = DateTime.Compare(fecha, dateday);
                            if (res > 0 || res == 0)
                            {
                                //comparar mismo producto.
                                if (ComprobarCodigoTb(codigo) == 1)
                                {
                                    InsertMismoTb(codigo, precio);
                                    SumarCantProd();
                                    UpdateTotales();
                                    UpdatePayDesc();
                                    UpdateDetVenta(CantPay.Text);
                                }
                                else
                                {
                                    InsertNuevoTb(codigo, nombre, cantidad, precio, total);
                                    SumarCantProd();
                                    UpdateTotales();
                                    UpdatePayDesc();
                                    UpdateDetVenta(CantPay.Text);
                                }
                            }
                            else
                            {
                                string message = "El Producto Está en el Limite del Vencimiento.\nDeseas Continuar Registrando la Venta.";
                                string caption = "Advertencia";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result;
                                // Displays the MessageBox.
                                result = MessageBox.Show(message, caption, buttons);

                                if (result == System.Windows.Forms.DialogResult.Yes)
                                {
                                    //comparar mismo producto.
                                    if (ComprobarCodigoTb(codigo) == 1)
                                    {
                                        InsertMismoTb(codigo, precio);
                                        SumarCantProd();
                                        UpdateTotales();
                                        UpdatePayDesc();
                                        UpdateDetVenta(CantPay.Text);
                                    }
                                    else
                                    {
                                        InsertNuevoTb(codigo, nombre, cantidad, precio, total);
                                        SumarCantProd();
                                        UpdateTotales();
                                        UpdatePayDesc();
                                        UpdateDetVenta(CantPay.Text);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El Producto Está Inactivo.\nEl Producto Paso del Stock Mínimo.\nContacte con el Administrador.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    d.CerrarCnn();
                }
                else
                {
                    MessageBox.Show("ERROR, El Producto Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void nitClientnum(object sender, KeyPressEventArgs e)
        {
            cs.soloNumeros(e);
            nitciclient.ForeColor = SystemColors.WindowText;
            nitciclient.Font = new Font(nitciclient.Font, FontStyle.Regular);
        }

        private void nameClientLetra(object sender, KeyPressEventArgs e)
        {
            cs.soloLetras(e);
            nameClient.ForeColor = SystemColors.WindowText;
            nameClient.Font = new Font(nameClient.Font, FontStyle.Regular);
        }

        private void PayClientnum(object sender, KeyPressEventArgs e)
        {
            cs.soloNumeros(e);
            PayText.ForeColor = SystemColors.WindowText;
            PayText.Font = new Font(PayText.Font, FontStyle.Regular);
        }

        private void descnum(object sender, KeyPressEventArgs e)
        {
            cs.soloNumeros(e);
            Descuentext.ForeColor = SystemColors.WindowText;
            Descuentext.Font = new Font(Descuentext.Font, FontStyle.Regular);
        }

        private void typepaynada(object sender, KeyPressEventArgs e)
        {
            cs.Nada(e);
        }

        private void MAtextCodProd(object sender, EventArgs e)
        {
        }

        private void DescuentClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (Descuentext.Text != "" && Descuentext.Font.Italic == true)
                {
                    Descuentext.Text = "";
                    Descuentext.ForeColor = SystemColors.WindowText;
                    Descuentext.Font = new Font(Descuentext.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    Descuentext.ForeColor = SystemColors.WindowText;
                    Descuentext.Font = new Font(Descuentext.Font, FontStyle.Regular);
                }
                addDescuent.Enabled = true;
            }
        }

        private void DetaVentaClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (detText.Text != "" && detText.Font.Italic == true)
                {
                    detText.Text = "";
                    detText.ForeColor = SystemColors.WindowText;
                    detText.Font = new Font(detText.Font, FontStyle.Regular);
                }
                else
                {
                    detText.ForeColor = SystemColors.WindowText;
                    detText.Font = new Font(detText.Font, FontStyle.Regular);
                }
            }
        }

        private void NameClienteClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nameClient.Text != "" && nameClient.Font.Italic == true)
                {
                    nameClient.Text = "";
                    nameClient.ForeColor = SystemColors.WindowText;
                    nameClient.Font = new Font(nameClient.Font, FontStyle.Regular);
                }
                else
                {
                    nameClient.ForeColor = SystemColors.WindowText;
                    nameClient.Font = new Font(nameClient.Font, FontStyle.Regular);
                }
            }
        }

        private void nitClientClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nitciclient.Text != "" && nitciclient.Font.Italic == true)
                {
                    nitciclient.Text = "";
                    nitciclient.ForeColor = SystemColors.WindowText;
                    nitciclient.Font = new Font(nitciclient.Font, FontStyle.Regular);
                }
                else
                {
                    nitciclient.ForeColor = SystemColors.WindowText;
                    nitciclient.Font = new Font(nitciclient.Font, FontStyle.Regular);
                }
            }
        }

        private void CodBarraProdClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (buscarprod.Text != "" && buscarprod.Font.Italic == true)
                {
                    buscarprod.Text = "";
                    buscarprod.ForeColor = SystemColors.WindowText;
                    buscarprod.Font = new Font(buscarprod.Font, FontStyle.Regular);
                }
                else
                {
                    buscarprod.ForeColor = SystemColors.WindowText;
                    buscarprod.Font = new Font(buscarprod.Font, FontStyle.Regular);
                }
            }
        }

        private void listProd_Click(object sender, EventArgs e)
        {
            List_Productos le = new List_Productos();
            le.ShowDialog();

            buscarprod.Text = "";
            buscarprod.ForeColor = SystemColors.WindowText;
            buscarprod.Font = new Font(buscarprod.Font, FontStyle.Regular);
            buscarprod.Text = le.codUser.ToString();          
        }

        private void CheckDetalleVenta(object sender, EventArgs e)
        {
            if (DetCheck.Checked)
            {
                detText.Visible = true;
            }
            else {
                detText.Visible = false;
            }
        }

        private void listClient_Click(object sender, EventArgs e)
        {
            Registro_Clientes re = new Registro_Clientes();
            re.CodUsr = codUsr;
            re.ShowDialog();
            nitciclient.Text = "";
            nitciclient.ForeColor = SystemColors.WindowText;
            nitciclient.Font = new Font(nitciclient.Font, FontStyle.Regular);
            nitciclient.Text = re.nitCli.ToString();          
        }

        private int comprobarProducto() 
        {
            int cnt = 0;
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Productos WHERE CodBarP= '" + Convert.ToInt64(buscarprod.Text) + "' ; ";
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

        private int ComprobarCodigoTb(Int64 valor) 
        {
            int res = 0;

            foreach (DataGridViewRow row in dataGridVentas.Rows)
            {
                if (Convert.ToInt64(row.Cells[0].Value) == valor)
                {
                    res += 1;
                }
            }           
            return res;
        }

        private void InsertMismoTb(Int64 valor, Double costo) 
        {
            int lago = 0;
            foreach (DataGridViewRow row in dataGridVentas.Rows)
            {
                if (Convert.ToInt64(row.Cells[0].Value) == valor)
                {
                    lago = dataGridVentas.Rows.IndexOf(row);
                }
            }

            dataGridVentas[2, lago].Value = (Convert.ToInt32(dataGridVentas[2, lago].Value) + 1);
            dataGridVentas[4, lago].Value = (Convert.ToDouble(dataGridVentas[4, lago].Value) + costo);
            //dataGridVentas[4, lago].Value = Math.Round(Convert.ToDouble(dataGridVentas[4, lago].Value), 2);
        }

        private void InsertNuevoTb(Int64 code, String name, int c, Double costo, Double total) 
        {
            costo = Math.Round(costo, 2);
            total = Math.Round(total, 2);

            string[] row0 = { code.ToString(), name, c.ToString(), costo.ToString(), total.ToString() }; 

            dataGridVentas.Rows.Add(row0);
        }


        private void SumarCantProd() 
        {
            int res = 0;
            foreach (DataGridViewRow row in dataGridVentas.Rows)
            {
                res = res + Convert.ToInt32(row.Cells[2].Value);
            }

            NumProd.Text = res.ToString();
        }

        private void UpdateTotales() 
        {
            Double res = 0;
            Double sub = 0;
            Double iva = 0;
            foreach (DataGridViewRow row in dataGridVentas.Rows)
            {
                res = res + Convert.ToDouble(row.Cells[4].Value);
            }

            sub = res * 0.87;
            sub = Math.Round(sub, 2);
            iva = res * 0.13;
            iva = Math.Round(iva, 2);

            TotalPay.Text = res.ToString();

            SubTotalPay.Text = sub.ToString();
            ivaPay.Text = iva.ToString();
        }

        private void UpdatePayDesc() 
        {
            Double res = 0;
            foreach (DataGridViewRow row in dataGridVentas.Rows)
            {
                res = res + Convert.ToDouble(row.Cells[4].Value);
            }
            if (Descuentext.Text != "" && Descuentext.Font.Italic == true)
            {
                res = Math.Round(res, 2);
                CantPay.Text = res.ToString();
            }
            else {
                if (double.Parse(Descuentext.Text) > 0)
                {
                    Double de = (double.Parse(Descuentext.Text))/100;
                    Double pordesc = res * de;
                    res = res - pordesc;
                    res = Math.Round(res, 2);
                    CantPay.Text = res.ToString();
                }
                else {
                    res = Math.Round(res, 2);
                    CantPay.Text = res.ToString();
                }
            }
        }


        private void UpdateDetVenta(String tot) 
        {
            DetMontoFactura fu = new DetMontoFactura();
            detText.Text = "";
            detText.ForeColor = SystemColors.WindowText;
            detText.Font = new Font(detText.Font, FontStyle.Regular);
            detText.Text = fu.Convertir(tot, true);
        }


        private void enterboton_Click(object sender, EventArgs e)
        {
            Conexion d = new Conexion();

            String nombre = "";
            Int64 codigo = 0;
            double precio = 0;
            int cantidad = 1;
            double total = 0;
            DateTime fecha = new DateTime(); 
            int cantidadProducto = 0;

            if (buscarprod.Text != "" && buscarprod.Font.Italic == true)
            {
                if (buscarprod.Text == "")
                {
                    MessageBox.Show("Ingrese el Codigo de Registro o Codigo de Barras del Producto que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo de Registro o Codigo de Barras del Producto que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (buscarprod.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo de Registro o Codigo de Barras del Producto que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {    //Codigo de ENTER PRESS de las Ventas.                
                string query = "SELECT * FROM Productos WHERE CodBarP ='" + Convert.ToInt64(buscarprod.Text) + "' ; ";                

                SqlCommand sqlQ = new SqlCommand(query, d.GetCONN());
                d.OpenCnn();
                SqlDataReader read;
                if (comprobarProducto() == 1)
                {
                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            codigo = read.GetInt64(0);
                            nombre = read.GetString(1);
                            precio = read.GetDouble(11);
                            fecha = read.GetDateTime(6);
                            cantidadProducto = read.GetInt32(13);
                            total = precio;
                        }
                        //Verificar Stock y fechas.
                        if (cantidadProducto > 1)
                        {
                            int res = DateTime.Compare(fecha, dateday);
                            if (res > 0 || res == 0)
                            {
                                //comparar mismo producto.
                                if (ComprobarCodigoTb(codigo) == 1)
                                {
                                    InsertMismoTb(codigo, precio);
                                    SumarCantProd();
                                    UpdateTotales();
                                    UpdatePayDesc();
                                    UpdateDetVenta(CantPay.Text);
                                }
                                else
                                {
                                    InsertNuevoTb(codigo, nombre, cantidad, precio, total);
                                    SumarCantProd();
                                    UpdateTotales();
                                    UpdatePayDesc();
                                    UpdateDetVenta(CantPay.Text);
                                }
                            }
                            else
                            {
                                string message = "El Producto Está en el Limite del Vencimiento.\nDeseas Continuar Registrando la Venta.";
                                string caption = "Advertencia";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result;
                                // Displays the MessageBox.
                                result = MessageBox.Show(message, caption, buttons);

                                if (result == System.Windows.Forms.DialogResult.Yes)
                                {
                                    //comparar mismo producto.
                                    if (ComprobarCodigoTb(codigo) == 1)
                                    {
                                        InsertMismoTb(codigo, precio);
                                        SumarCantProd();
                                        UpdateTotales();
                                        UpdatePayDesc();
                                        UpdateDetVenta(CantPay.Text);
                                    }
                                    else
                                    {
                                        InsertNuevoTb(codigo, nombre, cantidad, precio, total);
                                        SumarCantProd();
                                        UpdateTotales();
                                        UpdatePayDesc();
                                        UpdateDetVenta(CantPay.Text);
                                    }
                                }
                            }
                        }
                        else 
                        {
                            MessageBox.Show("El Producto Está Inactivo.\nEl Producto Paso del Stock Mínimo.\nContacte con el Administrador.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    d.CerrarCnn();
                }
                else
                {
                    MessageBox.Show("ERROR, El Producto Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int comprobarCliente() 
        {
            int cnt = 0;
            Conexion f = new Conexion();
            string buscar = "SELECT * FROM Clientes WHERE nitCliente= '" + nitciclient.Text + "' ; ";
            f.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, f.GetCONN());
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
            f.CerrarCnn();
            return cnt;
        }

        private void searchprod_Click(object sender, EventArgs e)
        {
            Conexion s = new Conexion();
            if (nitciclient.Text != "" && nitciclient.Font.Italic == true)
            {
                if (nitciclient.Text == "")
                {
                    MessageBox.Show("Ingrese el NIT o C.I. del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el NIT o C.I. del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (nitciclient.Text == "")
            {
                MessageBox.Show("Ingrese el NIT o C.I. del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   //Codigo de modificacion del cliente.
                string query = "SELECT * FROM Clientes WHERE nitCliente ='" + nitciclient.Text + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, s.GetCONN());
                s.OpenCnn();
                SqlDataReader read;
                if (comprobarCliente() == 1)
                {
                    nameClient.Text = "";
                    nameClient.ForeColor = SystemColors.WindowText;
                    nameClient.Font = new Font(nameClient.Font, FontStyle.Regular);                   

                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            nameClient.Text = read.GetString(1);                          
                        }
                        s.CerrarCnn();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, El Cliente Solicitado no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void detText_KeyPress(object sender, KeyPressEventArgs e)
        {
            detText.ForeColor = SystemColors.WindowText;
            detText.Font = new Font(detText.Font, FontStyle.Regular);
        }

        private void dataGridVentas_KeyDown(object sender, KeyEventArgs e)
        {
            Double res = 0;
            int pos = dataGridVentas.CurrentRow.Index;

            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    if (Convert.ToInt32(dataGridVentas[2, pos].Value) > 1)
                    {
                        dataGridVentas[2, pos].Value = (Convert.ToInt32(dataGridVentas[2, pos].Value) - 1);
                        res = Convert.ToDouble(dataGridVentas[3, pos].Value);
                        dataGridVentas[4, pos].Value = (Convert.ToDouble(dataGridVentas[4, pos].Value) - res);

                        SumarCantProd();
                        UpdateTotales();
                        UpdatePayDesc();
                        UpdateDetVenta(CantPay.Text);
                    }
                    else
                    {
                        dataGridVentas.Rows.RemoveAt(pos);
                        SumarCantProd();
                        UpdateTotales();
                        UpdatePayDesc();
                        UpdateDetVenta(CantPay.Text);
                    }
                }
                catch(Exception){}
            }

        }

        private void dataGridVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CleanList_Click(object sender, EventArgs e)
        {
            string message = "Esta Seguro que Desea Limpiar el Detalle de la Venta Realizada para el Cliente?";
            string caption = "Limpiar Venta";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            { // Closes the parent form.
                dataGridVentas.Rows.Clear();
                buscarprod.Text = "";
                nitciclient.Text="";
                nameClient.Text="";
                NumProd.Text = "0";
                SubTotalPay.Text = "0";
                ivaPay.Text = "0";
                TotalPay.Text = "0";
                CantPay.Text = "0";
                PayText.Text = "0";
                Descuentext.Text = "";
                detText.Text = "";
                PrintFacture.Enabled = false;
                printview.Enabled = false;
                AddSale.Enabled = false;
                buscarprod.Enabled = true;
                enterboton.Enabled = true;
                listProd.Enabled = true;
                Descuentext.Enabled = true;
                addDescuent.Enabled = true;
                PayButton.Enabled = true;
                PayText.Enabled = true;
                CleanList.Enabled = true;
                SalirButton.Enabled = true;
                id_Venta = "";

            }
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PayText.Text == "" || PayText.Text == "0")
                {
                    MessageBox.Show("ERROR, Debe Ingresar el Monto con el Cual Pago el Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    Devuelto = Convert.ToDouble(PayText.Text) - Convert.ToDouble(CantPay.Text);
                    if (Devuelto < 0)
                    {
                        MessageBox.Show("ERROR, Debe Ingresar el Monto Mayor o Igual Para Cumplir con la Deuda del Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        Messengers cd = new Messengers();
                        cd.textolb.ForeColor = SystemColors.Highlight;
                        cd.textolb.Text = Devuelto.ToString() + "  Bs.";
                        cd.ShowDialog();
                        AddSale.Enabled = true;
                        buscarprod.Text = "";
                        buscarprod.Enabled = false;
                        enterboton.Enabled = false;
                        listProd.Enabled = false;
                        Descuentext.Enabled = false;
                        addDescuent.Enabled = false;
                        CleanList.Enabled = false;
                        SalirButton.Enabled = false;
                    }
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Esta Seguro que Desea Cancelar el Proceso de Venta.?";
            string caption = "Cancelar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.No)
            { // Closes the parent form.
                if (SalirButton.Enabled == false)
                {
                    MessageBox.Show("Debe Emitir Facturación de la Compra Realizada por el Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void PrintFacture_Click(object sender, EventArgs e)
        {
            if (this.printMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.printDocx.DocumentName = "Preparando Documento...";
                this.printDocx.Print();
                i = 0;
            }

            CleanList.Enabled = true;
            SalirButton.Enabled = true;
        }

        private void printview_Click(object sender, EventArgs e)
        {
            printPreview.Document = printDocx;
            printPreview.ShowDialog();
            i = 0;
        }

        private String GetDepa(String rest) 
        {
            String cnt = "";
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Departamento WHERE codigoDep = '" + rest + "' ; ";
            d.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, d.GetCONN());
            try
            {
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = fb.GetString(1);
                }
            }
            catch (Exception) {  }
            d.CerrarCnn();
            return cnt;
        }

        private int GetIdCliente(String rest) 
        {
            int cnt = 0;     
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Clientes WHERE nitCliente = '" + rest + "' ; ";
            d.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, d.GetCONN());
            try
            {
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = fb.GetInt32(0);
                }
            }
            catch (Exception) { }
            d.CerrarCnn();
            return cnt;
        }

        private String GetNomUsr(int rest) 
        {
            String cnt = "";
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Usuario WHERE ciUser = '" + rest + "' ; ";
            d.OpenCnn();
            SqlCommand find = new SqlCommand(buscar, d.GetCONN());
            try
            {
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    cnt = fb.GetString(1);
                }
            }
            catch (Exception) { }
            d.CerrarCnn();
            return cnt;
        }

        private void GetDataFactura() 
        {
            Conexion r = new Conexion();
            String query2 = "SELECT * FROM Facturas WHERE codVenF = '" + id_Venta + "' ;";
            SqlCommand sql2 = new SqlCommand(query2, r.GetCONN());
            r.OpenCnn();
            SqlDataReader read2;
            try 
            {
                read2 = sql2.ExecuteReader();

                while (read2.Read())
                {
                    numf = read2.GetInt32(0).ToString();
                    numA = read2.GetString(1);
                    nitE = read2.GetString(2);
                    fV = read2.GetDateTime(3).ToString();
                    nitci = read2.GetString(4);
                    namecli = read2.GetString(5);
                    detvf = read2.GetString(7);
                    codCon = read2.GetString(8);
                    fle = read2.GetDateTime(9).ToString();
                    codcli = GetIdCliente(read2.GetString(4)).ToString();
                    codnomusr = GetNomUsr(codUsr);
                }
                r.CerrarCnn();
            }
            catch(Exception){}
        }


        private void printDocx_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {   //Inicio del encabezado del Documento.
            GetDataFactura();
            Conexion r = new Conexion();
            string query = "SELECT * FROM Empresa ; ";

            SqlCommand sqlQ = new SqlCommand(query, r.GetCONN());
            r.OpenCnn();
            SqlDataReader read;

            //Variables Guardar los Datos de la Empresa.
            Image img = null; 
            Image qr = null;
            String name = "";
            String tel = "";
            String cel = "";
            String dir = "";
            String web = "";
            String Fax1 = "";
            String Fax2 = "";
            String correo = "";
            String codD = "";

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
                    name = read.GetString(1);
                    dir = read.GetString(2);
                    tel = read.GetInt32(3).ToString();
                    cel = read.GetInt32(4).ToString();
                    Fax1 = read.GetInt32(5).ToString();
                    Fax2 = read.GetInt32(6).ToString();
                    correo = read.GetString(7);
                    web = read.GetString(8);
                    byte[] imageBuffer = (byte[])(read[9]);
                    codD = GetDepa(read.GetString(16));
                    byte[] imageQr = (byte[])(read[17]);

                    if (imageBuffer == null || read[9] == null)  {  img = null; }
                    else{
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        img = Image.FromStream(ms); //Logotipo 
                        }

                    if (imageQr == null || read[17] == null) { qr = null; }
                    else
                    {
                        System.IO.MemoryStream ms2 = new System.IO.MemoryStream(imageQr);
                        qr = Image.FromStream(ms2); //imgCodeQR 
                    }

                }      //Datos de la Empresa.
                e.Graphics.DrawImage(img, 10, 10, 100, 100);
                e.Graphics.DrawString(name, new Font("Lucida Sans", 11, FontStyle.Bold), new SolidBrush(Color.Black), 120, 10);

                e.Graphics.DrawString(dir, new Font("Lucida Sans", 8), new SolidBrush(Color.Black), 120, 30);
                e.Graphics.DrawString("Teléfonos: "+tel+" "+cel, new Font("Lucida Sans", 8), new SolidBrush(Color.Black), 120, 45);
                e.Graphics.DrawString("Fax: "+Fax1+" "+Fax2, new Font("Lucida Sans", 8), new SolidBrush(Color.Black), 120, 60);
                e.Graphics.DrawString(correo, new Font("Lucida Sans", 8), new SolidBrush(Color.Black), 120, 75);
                e.Graphics.DrawString(web, new Font("Lucida Sans", 8), new SolidBrush(Color.Black), 120, 90);

                e.Graphics.DrawString(codD+ " - BOLIVIA", new Font("Lucida Sans", 7), new SolidBrush(Color.Black), 130, 105);
                //fin Encabezado Documento 1.           

                //Datos de la Factura.
                e.Graphics.DrawString("NIT: " +nitE, new Font("Lucida Sans", 8), new SolidBrush(Color.Red), 250, 72);
                e.Graphics.DrawString("Nro. Factura: " + numf, new Font("Lucida Sans", 6), new SolidBrush(Color.Black), 250, 90);
                e.Graphics.DrawString("Nro. Autorización: " + numA, new Font("Lucida Sans", 6), new SolidBrush(Color.Black), 250, 105);

                e.Graphics.DrawString("FACTURA", new Font("Lucida Sans", 16, FontStyle.Bold), new SolidBrush(Color.DarkBlue), 150, 130);

                e.Graphics.DrawString("NIT/CI: " + nitci, new Font("Lucida Sans", 7), new SolidBrush(Color.Black), 30, 170);
                e.Graphics.DrawString("Codigo Cliente: " + codcli, new Font("Lucida Sans", 7), new SolidBrush(Color.Black), 30, 185);
                e.Graphics.DrawString("Nombre Cliente: " + namecli, new Font("Lucida Sans", 7), new SolidBrush(Color.Black), 30, 200);
                e.Graphics.DrawString("Fecha: " + fV, new Font("Lucida Sans", 7), new SolidBrush(Color.Black), 30, 215);
                e.Graphics.DrawString("Forma de Pago: " + typePayCombo.Text, new Font("Lucida Sans", 7), new SolidBrush(Color.Black), 220, 185);
                e.Graphics.DrawString("Codigo Usuario: " + codUsr, new Font("Lucida Sans", 7), new SolidBrush(Color.Black), 220, 200);
                e.Graphics.DrawString("Nombre Usuario: " + codnomusr, new Font("Lucida Sans", 7), new SolidBrush(Color.Black), 220, 215);

                //Insert DataGrid Print.
                #region Draw Column 1
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(20, 240, dataGridVentas.Columns[0].Width - 45, dataGridVentas.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 20, 240, dataGridVentas.Columns[0].Width - 45, dataGridVentas.Rows[0].Height);
                e.Graphics.DrawString(dataGridVentas.Columns[1].HeaderText, dataGridVentas.Font, Brushes.Black, new RectangleF(20, 240, dataGridVentas.Columns[0].Width - 45, dataGridVentas.Rows[0].Height), str);
                #endregion

                #region Draw column 2
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(20 + dataGridVentas.Columns[0].Width - 45, 240, dataGridVentas.Columns[0].Width-20, dataGridVentas.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 20 + dataGridVentas.Columns[0].Width - 45, 240, dataGridVentas.Columns[0].Width-20, dataGridVentas.Rows[0].Height);
                e.Graphics.DrawString(dataGridVentas.Columns[2].HeaderText, dataGridVentas.Font, Brushes.Black, new RectangleF(20 + dataGridVentas.Columns[0].Width - 45, 240, dataGridVentas.Columns[0].Width-20, dataGridVentas.Rows[0].Height), str);
                #endregion

                #region Draw column 3
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(70+dataGridVentas.Columns[0].Width, 240, dataGridVentas.Columns[0].Width-20, dataGridVentas.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black,70 + dataGridVentas.Columns[0].Width, 240, dataGridVentas.Columns[0].Width-20, dataGridVentas.Rows[0].Height);
                e.Graphics.DrawString(dataGridVentas.Columns[3].HeaderText, dataGridVentas.Font, Brushes.Black, new RectangleF(70 + dataGridVentas.Columns[0].Width, 240, dataGridVentas.Columns[0].Width-20, dataGridVentas.Rows[0].Height), str);
                #endregion

                #region Draw column 4
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(165 + dataGridVentas.Columns[0].Width, 240, dataGridVentas.Columns[0].Width-90, dataGridVentas.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 165 + dataGridVentas.Columns[0].Width, 240, dataGridVentas.Columns[0].Width-90, dataGridVentas.Rows[0].Height);
                e.Graphics.DrawString(dataGridVentas.Columns[4].HeaderText, dataGridVentas.Font, Brushes.Black, new RectangleF(165 + dataGridVentas.Columns[0].Width, 240, dataGridVentas.Columns[0].Width-90, dataGridVentas.Rows[0].Height), str);
                #endregion

                #region Draw Rows N
                width = 10 + dataGridVentas.Columns[0].Width;
                height = 240;
                //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
                while (i < dataGridVentas.Rows.Count)
                {
                    if (height > e.MarginBounds.Height)
                    {
                        height = 240;
                        width = 10;
                        e.HasMorePages = true;
                        return;
                    }

                    height += dataGridVentas.Rows[i].Height;
                    //Draw Row 1
                    e.Graphics.DrawRectangle(Pens.Black, 20, height, dataGridVentas.Columns[0].Width - 45, dataGridVentas.Rows[0].Height);
                    e.Graphics.DrawString(dataGridVentas.Rows[i].Cells[1].FormattedValue.ToString(), dataGridVentas.Font, Brushes.Black, new RectangleF(20, height, dataGridVentas.Columns[0].Width - 45, dataGridVentas.Rows[0].Height), str);
                    //Draw Row 2
                    e.Graphics.DrawRectangle(Pens.Black, dataGridVentas.Columns[0].Width-25, height, dataGridVentas.Columns[0].Width - 85, dataGridVentas.Rows[0].Height);
                    e.Graphics.DrawString(dataGridVentas.Rows[i].Cells[2].Value.ToString(), dataGridVentas.Font, Brushes.Black, new RectangleF(dataGridVentas.Columns[0].Width-25, height, dataGridVentas.Columns[0].Width - 85, dataGridVentas.Rows[0].Height), str);
                    //Draw Row 3
                    e.Graphics.DrawRectangle(Pens.Black, 70 + dataGridVentas.Columns[0].Width, height, dataGridVentas.Columns[0].Width - 85, dataGridVentas.Rows[0].Height);
                    e.Graphics.DrawString(dataGridVentas.Rows[i].Cells[3].Value.ToString(), dataGridVentas.Font, Brushes.Black, new RectangleF(70 + dataGridVentas.Columns[0].Width, height, dataGridVentas.Columns[0].Width - 85, dataGridVentas.Rows[0].Height), str);
                    //Draw Row 4
                    e.Graphics.DrawRectangle(Pens.Black, 165 + dataGridVentas.Columns[0].Width, height, dataGridVentas.Columns[0].Width - 90, dataGridVentas.Rows[0].Height);
                    e.Graphics.DrawString(dataGridVentas.Rows[i].Cells[4].Value.ToString(), dataGridVentas.Font, Brushes.Black, new RectangleF(165 + dataGridVentas.Columns[0].Width, height, dataGridVentas.Columns[0].Width - 90, dataGridVentas.Rows[0].Height), str);

                    width += dataGridVentas.Columns[0].Width;
                    i++;
                }

                e.Graphics.DrawString("Total de Productos: " + NumProd.Text, new Font("Lucida Sans", 8), new SolidBrush(Color.Black), 30, height + 25);
                e.Graphics.DrawString("Total a Pagar: " + CantPay.Text, new Font("Lucida Sans", 8), new SolidBrush(Color.Black), 180, height + 25);
                e.Graphics.DrawString("Efectivo: " + PayText.Text, new Font("Lucida Sans", 8), new SolidBrush(Color.Black), 180, height+ 40);
                e.Graphics.DrawString("Cambio: " + Devuelto.ToString(), new Font("Lucida Sans", 8), new SolidBrush(Color.Black), 180, height + 55);

                e.Graphics.DrawString("" + detvf, new Font("Lucida Sans", 8), new SolidBrush(Color.Black), 30, height+70);
                e.Graphics.DrawString("Codigo de Control: " + codCon, new Font("Lucida Sans", 8), new SolidBrush(Color.Black), 30, height+85);
                e.Graphics.DrawString("Fecha Limite de Emisión: " + fle, new Font("Lucida Sans", 8), new SolidBrush(Color.Black), 30, height+100);

                e.Graphics.DrawImage(qr, 340, height+40, 80, 80);
                e.Graphics.DrawString("ESTA FACTURA CONTRIBUYE AL DESARROLLO DEL PAÍS. EL USO ILÍCITO DE ÉSTA SERÁ SANCIONADO DE ACUERDO A LEY", new Font("Lucida Sans", 4), new SolidBrush(Color.Red), 20, height+120);
                e.Graphics.DrawString("Ley Nro. 453: Esta prohibidas las prácticas comerciales abusivas, tienes derecho a denunciarlas.", new Font("Lucida Sans", 4), new SolidBrush(Color.Black), 20, height+130);
                
                #endregion

                r.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }
        }

        private void tituloVentas_Click(object sender, EventArgs e)
        {
            Read_Code_Qr_Bar re = new Read_Code_Qr_Bar();
            re.ShowDialog();
            buscarprod.Text = re.code;
        }


    }
}
