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
    public partial class Devoluciones : Form
    {
        ValidacionText cs = new ValidacionText();
        Conexion sd = new Conexion();

        public int codUsr = 7906442;
        public String id_Venta = "";
        DateTime dateday = DateTime.Today;

        public Devoluciones()
        {
            InitializeComponent();

            toolTipdevo.SetToolTip(buscarprod, "Ingresar Codigo de Barras del Producto");
            toolTipdevo.SetToolTip(enterboton, "ENTER, Añadir a la lista de Ventas");
            toolTipdevo.SetToolTip(listProd, "Registro de Productos");
            toolTipdevo.SetToolTip(nitciclient, "Ingresar NIT o Carnet de Identidad del Cliente [Opcional]");
            toolTipdevo.SetToolTip(searchprod, "Buscar Cliente Registrado");
            toolTipdevo.SetToolTip(nameClient, "Ingresar Nombre del Cliente [Opcional]");
            toolTipdevo.SetToolTip(listClient, "Registro de Clientes");
            toolTipdevo.SetToolTip(NumProd, "Cantidad de Productos a Vender");
            toolTipdevo.SetToolTip(SubTotalPay, "Costo Sin Impuestos");
            toolTipdevo.SetToolTip(ivaPay, "RC-IVA, del 13% del Costo Total");
            toolTipdevo.SetToolTip(CantPay, "Efectivo a Devolver al Cliente");
            toolTipdevo.SetToolTip(AddSale, "Rgistrar Devolución");
            toolTipdevo.SetToolTip(CleanList, "Suspender/Limpiar Lista de Devolución");
            toolTipdevo.SetToolTip(SalirButton, "Salir");
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            string message = "Esta Seguro que Desea Cancelar el Proceso de la Devolución en Ventas.?";
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
                nitciclient.Text = "";
                nameClient.Text = "";
                NumProd.Text = "0";
                SubTotalPay.Text = "0";
                ivaPay.Text = "0";               
                CantPay.Text = "0";               
                AddSale.Enabled = false;
                buscarprod.Enabled = true;
                enterboton.Enabled = true;
                listProd.Enabled = true;               
                CleanList.Enabled = true;
                SalirButton.Enabled = true;
                id_Venta = "";

            }
        }

        private void buscarprod_MouseClick(object sender, MouseEventArgs e)
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

        private void nitciclient_MouseClick(object sender, MouseEventArgs e)
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

        private void nameClient_MouseClick(object sender, MouseEventArgs e)
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

        private void nameClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            cs.soloLetras(e);
            nameClient.ForeColor = SystemColors.WindowText;
            nameClient.Font = new Font(nameClient.Font, FontStyle.Regular);
        }

        private void nitciclient_KeyPress(object sender, KeyPressEventArgs e)
        {
            cs.soloNumeros(e);
            nitciclient.ForeColor = SystemColors.WindowText;
            nitciclient.Font = new Font(nitciclient.Font, FontStyle.Regular);
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

        private void tituloVentas_Click(object sender, EventArgs e)
        {
            Read_Code_Qr_Bar re = new Read_Code_Qr_Bar();
            re.ShowDialog();
            buscarprod.Text = re.code;
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

            CantPay.Text = res.ToString();

            SubTotalPay.Text = sub.ToString();
            ivaPay.Text = iva.ToString();
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
                        {   //comparar mismo producto.
                            if (ComprobarCodigoTb(codigo) == 1)
                            {
                                InsertMismoTb(codigo, precio);
                                SumarCantProd();
                                UpdateTotales();
                            }
                            else
                            {
                                InsertNuevoTb(codigo, nombre, cantidad, precio, total);
                                SumarCantProd();
                                UpdateTotales();
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

        private void buscarprod_KeyPress(object sender, KeyPressEventArgs e)
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

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
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
                {  //Codigo de ENTER PRESS de las Ventas.                
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
                            {   //comparar mismo producto.
                                if (ComprobarCodigoTb(codigo) == 1)
                                {
                                    InsertMismoTb(codigo, precio);
                                    SumarCantProd();
                                    UpdateTotales();
                                }
                                else
                                {
                                    InsertNuevoTb(codigo, nombre, cantidad, precio, total);
                                    SumarCantProd();
                                    UpdateTotales();
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
            else if (e.KeyChar == (char)13)
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
                        {   //comparar mismo producto.
                            if (ComprobarCodigoTb(codigo) == 1)
                            {
                                InsertMismoTb(codigo, precio);
                                SumarCantProd();
                                UpdateTotales();
                            }
                            else
                            {
                                InsertNuevoTb(codigo, nombre, cantidad, precio, total);
                                SumarCantProd();
                                UpdateTotales();
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

        private void txtCodeV_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (txtCodeV.Text != "" && txtCodeV.Font.Italic == true)
                {
                    txtCodeV.Text = "";
                    txtCodeV.ForeColor = SystemColors.WindowText;
                    txtCodeV.Font = new Font(txtCodeV.Font, FontStyle.Regular);
                }
                else
                {
                    txtCodeV.ForeColor = SystemColors.WindowText;
                    txtCodeV.Font = new Font(txtCodeV.Font, FontStyle.Regular);
                }
            }
        }

        private void txtCodeV_KeyPress(object sender, KeyPressEventArgs e)
        {
            cs.soloLetrasYNumeros(e);
            txtCodeV.ForeColor = SystemColors.WindowText;
            txtCodeV.Font = new Font(txtCodeV.Font, FontStyle.Regular);
        }

        private void btnListventas_Click(object sender, EventArgs e)
        {
            List_Ventas lv = new List_Ventas();
            lv.ShowDialog();
            txtCodeV.Text = "";
            txtCodeV.ForeColor = SystemColors.WindowText;
            txtCodeV.Font = new Font(txtCodeV.Font, FontStyle.Regular);
            txtCodeV.Text = lv.devcod;
            nitciclient.Text = "";
            nitciclient.ForeColor = SystemColors.WindowText;
            nitciclient.Font = new Font(nitciclient.Font, FontStyle.Regular);
            nitciclient.Text = lv.nitCli;

        }

        private void AddSale_Click(object sender, EventArgs e)
        {
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
            else if (txtCodeV.Text == "" || txtCodeV.Font.Italic == true)
            {
                MessageBox.Show("Ingrese el Codigo de Registro de la Venta que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dateday = DateTime.UtcNow;
                id_Venta = txtCodeV.Text;
                Conexion c = new Conexion();
                try
                {   // Objetos de conexión y comando
                    foreach (DataGridViewRow row in dataGridVentas.Rows)
                    {
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = c.GetCONN();
                        cmd.CommandText = "INSERT INTO Devolucion_Ventas VALUES (@id, @name, @cant, @price, @fecha, @total, @idv)";

                        // Creando los parámetros necesarios
                        cmd.Parameters.Add("@id", System.Data.SqlDbType.BigInt);
                        cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@cant", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@price", System.Data.SqlDbType.Float);
                        cmd.Parameters.Add("@fecha", System.Data.SqlDbType.DateTime);
                        cmd.Parameters.Add("@total", System.Data.SqlDbType.Float);
                        cmd.Parameters.Add("@idv", System.Data.SqlDbType.VarChar);

                        // Asignando los valores a los atributos
                        //row.Cells[0].Value
                        cmd.Parameters["@id"].Value = Convert.ToInt64(row.Cells[0].Value);
                        cmd.Parameters["@name"].Value = Convert.ToString(row.Cells[1].Value);
                        cmd.Parameters["@cant"].Value = Convert.ToInt32(row.Cells[2].Value);
                        cmd.Parameters["@price"].Value = Convert.ToDouble(row.Cells[3].Value);
                        cmd.Parameters["@fecha"].Value = dateday;
                        cmd.Parameters["@total"].Value = Convert.ToDouble(row.Cells[4].Value);
                        cmd.Parameters["@idv"].Value = id_Venta;

                        c.OpenCnn();
                        cmd.ExecuteNonQuery();
                        c.CerrarCnn();
                    }

                    Messengers sms = new Messengers();
                    sms.textolb.Text = "Devolución Exitosa";
                    sms.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR. Al Insertar Los Datos de la Devolución. " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




    }
}
