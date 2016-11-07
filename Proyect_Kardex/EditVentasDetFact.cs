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
    public partial class EditVentasDetFact : Form
    {
        ValidacionText ve = new ValidacionText();
        Conexion cs = new Conexion();
        public int codUsr = 7906442;
        public String id_Venta = "";

        public Double Devuelto = 0;
        DateTime dateday = DateTime.Today;

        public EditVentasDetFact()
        {
            InitializeComponent();

            toolTipEditVenta.SetToolTip(codetxt, "Ingresar Codigo de Registro de la Venta");
            toolTipEditVenta.SetToolTip(cantxt, "Cantidad de Productos");
            toolTipEditVenta.SetToolTip(efectivetxt, "Efectivo Pagado por Cliente");
            toolTipEditVenta.SetToolTip(cbtype, "Tipo de Pago");
            toolTipEditVenta.SetToolTip(cambiotxt, "Monto a Devolver");
            toolTipEditVenta.SetToolTip(subtxt, "Monto del Sub-Total");
            toolTipEditVenta.SetToolTip(ivatxt, "Total de IVA");
            toolTipEditVenta.SetToolTip(TotalPaytxt, "Monto Total en Venta");
            toolTipEditVenta.SetToolTip(desctxt, "Ingresar Descuento en Ventas");
            toolTipEditVenta.SetToolTip(descbtn, "Agregar Descuento");
            toolTipEditVenta.SetToolTip(datefecha, "Fecha Actual");
            toolTipEditVenta.SetToolTip(detalletxt, "Detalle del Monto a Pagar");
            toolTipEditVenta.SetToolTip(CodUsrtxt, "Codigo de Registro del Usuario");
            toolTipEditVenta.SetToolTip(nameusrTxt, "Nombre del Usuario");
            toolTipEditVenta.SetToolTip(codClitxt, "Codigo de Registro del Cliente");
            toolTipEditVenta.SetToolTip(nitClitxt, "NIT o CI del Cliente");
            toolTipEditVenta.SetToolTip(nameusrTxt, "Nombre del Cliente");
            toolTipEditVenta.SetToolTip(findbtn, "Buscar Venta");
            toolTipEditVenta.SetToolTip(codProdtxt, "Codigo de Registro/Barras del Producto");
            toolTipEditVenta.SetToolTip(novoBtn, "Agregar Nuevo Producto");
            toolTipEditVenta.SetToolTip(deleteBtn, "Eliminar Producto");
            toolTipEditVenta.SetToolTip(SalirButton, "Salir");
            toolTipEditVenta.SetToolTip(addFacture, "Guardar Detalle de Venta");
            toolTipEditVenta.SetToolTip(AddSale, "Modificar Venta");
            toolTipEditVenta.SetToolTip(CleanList, "Limpiar Detalle de Venta");
        }

        private void codetxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (codetxt.Text != "" && codetxt.Font.Italic == true)
                {
                    codetxt.Text = "";
                    codetxt.ForeColor = SystemColors.WindowText;
                    codetxt.Font = new Font(codetxt.Font, FontStyle.Regular);
                }
                else
                {
                    codetxt.ForeColor = SystemColors.WindowText;
                    codetxt.Font = new Font(codetxt.Font, FontStyle.Regular);
                }
            }
        }

        private void cantxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (cantxt.Text != "" && cantxt.Font.Italic == true)
                {
                    cantxt.Text = "";
                    cantxt.ForeColor = SystemColors.WindowText;
                    cantxt.Font = new Font(cantxt.Font, FontStyle.Regular);
                }
                else
                {
                    cantxt.ForeColor = SystemColors.WindowText;
                    cantxt.Font = new Font(cantxt.Font, FontStyle.Regular);
                }
            }
        }

        private void efectivetxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (efectivetxt.Text != "" && efectivetxt.Font.Italic == true)
                {
                    efectivetxt.Text = "";
                    efectivetxt.ForeColor = SystemColors.WindowText;
                    efectivetxt.Font = new Font(efectivetxt.Font, FontStyle.Regular);
                }
                else
                {
                    efectivetxt.ForeColor = SystemColors.WindowText;
                    efectivetxt.Font = new Font(efectivetxt.Font, FontStyle.Regular);
                }
            }
        }

        private void cambiotxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (cambiotxt.Text != "" && cambiotxt.Font.Italic == true)
                {
                    cambiotxt.Text = "";
                    cambiotxt.ForeColor = SystemColors.WindowText;
                    cambiotxt.Font = new Font(cambiotxt.Font, FontStyle.Regular);
                }
                else
                {
                    cambiotxt.ForeColor = SystemColors.WindowText;
                    cambiotxt.Font = new Font(cambiotxt.Font, FontStyle.Regular);
                }
            }
        }

        private void subtxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (subtxt.Text != "" && subtxt.Font.Italic == true)
                {
                    subtxt.Text = "";
                    subtxt.ForeColor = SystemColors.WindowText;
                    subtxt.Font = new Font(subtxt.Font, FontStyle.Regular);
                }
                else
                {
                    subtxt.ForeColor = SystemColors.WindowText;
                    subtxt.Font = new Font(subtxt.Font, FontStyle.Regular);
                }
            }
        }

        private void ivatxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (ivatxt.Text != "" && ivatxt.Font.Italic == true)
                {
                    ivatxt.Text = "";
                    ivatxt.ForeColor = SystemColors.WindowText;
                    ivatxt.Font = new Font(ivatxt.Font, FontStyle.Regular);
                }
                else
                {
                    ivatxt.ForeColor = SystemColors.WindowText;
                    ivatxt.Font = new Font(ivatxt.Font, FontStyle.Regular);
                }
            }
        }

        private void totaltxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (totaltxt.Text != "" && totaltxt.Font.Italic == true)
                {
                    totaltxt.Text = "";
                    totaltxt.ForeColor = SystemColors.WindowText;
                    totaltxt.Font = new Font(totaltxt.Font, FontStyle.Regular);
                }
                else
                {
                    totaltxt.ForeColor = SystemColors.WindowText;
                    totaltxt.Font = new Font(totaltxt.Font, FontStyle.Regular);
                }
            }
        }

        private void TotalPaytxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (TotalPaytxt.Text != "" && TotalPaytxt.Font.Italic == true)
                {
                    TotalPaytxt.Text = "";
                    TotalPaytxt.ForeColor = SystemColors.WindowText;
                    TotalPaytxt.Font = new Font(TotalPaytxt.Font, FontStyle.Regular);
                }
                else
                {
                    TotalPaytxt.ForeColor = SystemColors.WindowText;
                    TotalPaytxt.Font = new Font(TotalPaytxt.Font, FontStyle.Regular);
                }
            }
        }

        private void desctxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (desctxt.Text != "" && desctxt.Font.Italic == true)
                {
                    desctxt.Text = "";
                    desctxt.ForeColor = SystemColors.WindowText;
                    desctxt.Font = new Font(desctxt.Font, FontStyle.Regular);
                }
                else
                {
                    desctxt.ForeColor = SystemColors.WindowText;
                    desctxt.Font = new Font(desctxt.Font, FontStyle.Regular);
                }
            }
        }

        private void detalletxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (detalletxt.Text != "" && detalletxt.Font.Italic == true)
                {
                    detalletxt.Text = "";
                    detalletxt.ForeColor = SystemColors.WindowText;
                    detalletxt.Font = new Font(detalletxt.Font, FontStyle.Regular);
                }
                else
                {
                    detalletxt.ForeColor = SystemColors.WindowText;
                    detalletxt.Font = new Font(detalletxt.Font, FontStyle.Regular);
                }
            }
        }

        private void CodUsrtxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (CodUsrtxt.Text != "" && CodUsrtxt.Font.Italic == true)
                {
                    CodUsrtxt.Text = "";
                    CodUsrtxt.ForeColor = SystemColors.WindowText;
                    CodUsrtxt.Font = new Font(CodUsrtxt.Font, FontStyle.Regular);
                }
                else
                {
                    CodUsrtxt.ForeColor = SystemColors.WindowText;
                    CodUsrtxt.Font = new Font(CodUsrtxt.Font, FontStyle.Regular);
                }
            }
        }

        private void codClitxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (codClitxt.Text != "" && codClitxt.Font.Italic == true)
                {
                    codClitxt.Text = "";
                    codClitxt.ForeColor = SystemColors.WindowText;
                    codClitxt.Font = new Font(codClitxt.Font, FontStyle.Regular);
                }
                else
                {
                    codClitxt.ForeColor = SystemColors.WindowText;
                    codClitxt.Font = new Font(codClitxt.Font, FontStyle.Regular);
                }
            }
        }

        private void nitClitxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nitClitxt.Text != "" && nitClitxt.Font.Italic == true)
                {
                    nitClitxt.Text = "";
                    nitClitxt.ForeColor = SystemColors.WindowText;
                    nitClitxt.Font = new Font(nitClitxt.Font, FontStyle.Regular);
                }
                else
                {
                    nitClitxt.ForeColor = SystemColors.WindowText;
                    nitClitxt.Font = new Font(nitClitxt.Font, FontStyle.Regular);
                }
            }
        }

        private void nameClitxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nameClitxt.Text != "" && nameClitxt.Font.Italic == true)
                {
                    nameClitxt.Text = "";
                    nameClitxt.ForeColor = SystemColors.WindowText;
                    nameClitxt.Font = new Font(nameClitxt.Font, FontStyle.Regular);
                }
                else
                {
                    nameClitxt.ForeColor = SystemColors.WindowText;
                    nameClitxt.Font = new Font(nameClitxt.Font, FontStyle.Regular);
                }
            }
        }

        private void nameusrTxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (nameusrTxt.Text != "" && nameusrTxt.Font.Italic == true)
                {
                    nameusrTxt.Text = "";
                    nameusrTxt.ForeColor = SystemColors.WindowText;
                    nameusrTxt.Font = new Font(nameusrTxt.Font, FontStyle.Regular);
                }
                else
                {
                    nameusrTxt.ForeColor = SystemColors.WindowText;
                    nameusrTxt.Font = new Font(nameusrTxt.Font, FontStyle.Regular);
                }
            }
        }

        private void codProdtxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (codProdtxt.Text != "" && codProdtxt.Font.Italic == true)
                {
                    codProdtxt.Text = "";
                    codProdtxt.ForeColor = SystemColors.WindowText;
                    codProdtxt.Font = new Font(codProdtxt.Font, FontStyle.Regular);
                }
                else
                {
                    codProdtxt.ForeColor = SystemColors.WindowText;
                    codProdtxt.Font = new Font(codProdtxt.Font, FontStyle.Regular);
                }
            }
        }

        private void codetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.Nada(e);
            codetxt.ForeColor = SystemColors.WindowText;
            codetxt.Font = new Font(codetxt.Font, FontStyle.Regular);
        }

        private void cantxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.Nada(e);
            cantxt.ForeColor = SystemColors.WindowText;
            cantxt.Font = new Font(cantxt.Font, FontStyle.Regular);
        }

        private void cambiotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.Nada(e);
            cambiotxt.ForeColor = SystemColors.WindowText;
            cambiotxt.Font = new Font(cambiotxt.Font, FontStyle.Regular);
        }

        private void subtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.Nada(e);
            subtxt.ForeColor = SystemColors.WindowText;
            subtxt.Font = new Font(subtxt.Font, FontStyle.Regular);
        }

        private void ivatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.Nada(e);
            ivatxt.ForeColor = SystemColors.WindowText;
            ivatxt.Font = new Font(ivatxt.Font, FontStyle.Regular);
        }

        private void totaltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.Nada(e);
            totaltxt.ForeColor = SystemColors.WindowText;
            totaltxt.Font = new Font(totaltxt.Font, FontStyle.Regular);
        }

        private void TotalPaytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.Nada(e);
            TotalPaytxt.ForeColor = SystemColors.WindowText;
            TotalPaytxt.Font = new Font(TotalPaytxt.Font, FontStyle.Regular);
        }

        private void CodUsrtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.Nada(e);
            CodUsrtxt.ForeColor = SystemColors.WindowText;
            CodUsrtxt.Font = new Font(CodUsrtxt.Font, FontStyle.Regular);
        }

        private void codClitxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.Nada(e);
            codClitxt.ForeColor = SystemColors.WindowText;
            codClitxt.Font = new Font(codClitxt.Font, FontStyle.Regular);
        }

        private void nitClitxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.soloNumeros(e);
            nitClitxt.ForeColor = SystemColors.WindowText;
            nitClitxt.Font = new Font(nitClitxt.Font, FontStyle.Regular);

            Conexion s = new Conexion();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (nitClitxt.Text != "" && nitClitxt.Font.Italic == true)
                {
                    if (nitClitxt.Text == "")
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
                else if (nitClitxt.Text == "")
                {
                    MessageBox.Show("Ingrese el NIT o C.I. del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {   //Codigo de modificacion del cliente.
                    string query = "SELECT * FROM Clientes WHERE nitCliente ='" + nitClitxt.Text + "' ; ";

                    SqlCommand sqlQ = new SqlCommand(query, s.GetCONN());
                    s.OpenCnn();
                    SqlDataReader read;
                    if (comprobarCliente() == 1)
                    {
                        nameClitxt.Text = "";
                        nameClitxt.ForeColor = SystemColors.WindowText;
                        nameClitxt.Font = new Font(nameClitxt.Font, FontStyle.Regular);
                        codClitxt.Text = "";
                        codClitxt.ForeColor = SystemColors.WindowText;
                        codClitxt.Font = new Font(codClitxt.Font, FontStyle.Regular);

                        try
                        {
                            read = sqlQ.ExecuteReader();
                            while (read.Read())
                            {
                                nameClitxt.Text = read.GetString(1);
                                codClitxt.Text = read.GetInt32(0).ToString();

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
        }

        private void detalletxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.soloLetrasYNumeros(e);
            detalletxt.ForeColor = SystemColors.WindowText;
            detalletxt.Font = new Font(detalletxt.Font, FontStyle.Regular);
        }

        private void nameusrTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.soloLetras(e);
            nameusrTxt.ForeColor = SystemColors.WindowText;
            nameusrTxt.Font = new Font(nameusrTxt.Font, FontStyle.Regular);
        }

        private void nameClitxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.soloLetras(e);
            nameClitxt.ForeColor = SystemColors.WindowText;
            nameClitxt.Font = new Font(nameClitxt.Font, FontStyle.Regular);
        }

        private void codProdtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.soloNumeros(e);
            codProdtxt.ForeColor = SystemColors.WindowText;
            codProdtxt.Font = new Font(codProdtxt.Font, FontStyle.Regular);
        }

        private void efectivetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.soloNumeros(e);
            efectivetxt.ForeColor = SystemColors.WindowText;
            efectivetxt.Font = new Font(efectivetxt.Font, FontStyle.Regular);
        }

        private void desctxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ve.soloNumeros(e);
            desctxt.ForeColor = SystemColors.WindowText;
            desctxt.Font = new Font(desctxt.Font, FontStyle.Regular);
        }

        private void UpdateDetVenta(String tot)
        {
            DetMontoFactura fu = new DetMontoFactura();
            detalletxt.Text = "";
            detalletxt.ForeColor = SystemColors.WindowText;
            detalletxt.Font = new Font(detalletxt.Font, FontStyle.Regular);
            detalletxt.Text = fu.Convertir(tot, true);
        }

        private void descbtn_Click(object sender, EventArgs e)
        {
            Double res = 0;
            foreach (DataGridViewRow row in dataGridDet.Rows)
            {
                res = res + Convert.ToDouble(row.Cells[4].Value);
            }
            if (desctxt.Text != "" && desctxt.Font.Italic == true)
            {
                res = Math.Round(res, 2);
                TotalPaytxt.Text = res.ToString();
                UpdateDetVenta(TotalPaytxt.Text);
            }
            else
            {
                if (double.Parse(desctxt.Text) > 0)
                {
                    Double de = (double.Parse(desctxt.Text)) / 100;
                    Double pordesc = res * de;
                    res = res - pordesc;
                    res = Math.Round(res, 2);
                    TotalPaytxt.Text = res.ToString();
                    UpdateDetVenta(TotalPaytxt.Text);    
                }
                else
                {
                    res = Math.Round(res, 2);
                    TotalPaytxt.Text = res.ToString();
                    UpdateDetVenta(TotalPaytxt.Text);
                }
            }
        }


        private int comprobar()
        {
            int cnt = 0;
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM REV_Ventas WHERE id_Venta ='" + codetxt.Text + "' ; ";

            try
            {
                d.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, d.GetCONN());
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

        public DataTable CargarDatos()
        {
            String slq = "SELECT * FROM Detalle_Venta WHERE cod_Venta = '" + codetxt.Text + "' ;";
            DataTable res = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(slq, cs.GetCONN());
            sda.Fill(res);
            return res;
        }

        private void findbtn_Click(object sender, EventArgs e)
        {
            Conexion f = new Conexion();
            if (codetxt.Text != "" && codetxt.Font.Italic == true)
            {
                if (codetxt.Text == "")
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
            else if (codetxt.Text == "")
            {
                MessageBox.Show("Ingrese el Carnet de Identidad del Cliente que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //Codigo de Buscar Cliente.
                string query = "SELECT * FROM REV_Ventas WHERE id_Venta ='" + codetxt.Text + "' ; ";

                SqlCommand sqlQ = new SqlCommand(query, f.GetCONN());
                f.OpenCnn();
                SqlDataReader read;
                if (comprobar() == 1)
                {
                    cantxt.Text = "";
                    cantxt.ForeColor = SystemColors.WindowText;
                    cantxt.Font = new Font(cantxt.Font, FontStyle.Regular);
                    efectivetxt.Text = "";
                    efectivetxt.ForeColor = SystemColors.WindowText;
                    efectivetxt.Font = new Font(efectivetxt.Font, FontStyle.Regular);
                    cambiotxt.Text = "";
                    cambiotxt.ForeColor = SystemColors.WindowText;
                    cambiotxt.Font = new Font(cambiotxt.Font, FontStyle.Regular);
                    subtxt.Text = "";
                    subtxt.ForeColor = SystemColors.WindowText;
                    subtxt.Font = new Font(subtxt.Font, FontStyle.Regular);
                    ivatxt.Text = "";
                    ivatxt.ForeColor = SystemColors.WindowText;
                    ivatxt.Font = new Font(ivatxt.Font, FontStyle.Regular);
                    totaltxt.Text = "";
                    totaltxt.ForeColor = SystemColors.WindowText;
                    totaltxt.Font = new Font(totaltxt.Font, FontStyle.Regular);
                    TotalPaytxt.Text = "";
                    TotalPaytxt.ForeColor = SystemColors.WindowText;
                    TotalPaytxt.Font = new Font(TotalPaytxt.Font, FontStyle.Regular);
                    desctxt.Text = "";
                    desctxt.ForeColor = SystemColors.WindowText;
                    desctxt.Font = new Font(desctxt.Font, FontStyle.Regular);
                    detalletxt.Text = "";
                    detalletxt.ForeColor = SystemColors.WindowText;
                    detalletxt.Font = new Font(detalletxt.Font, FontStyle.Regular);
                    CodUsrtxt.Text = "";
                    CodUsrtxt.ForeColor = SystemColors.WindowText;
                    CodUsrtxt.Font = new Font(CodUsrtxt.Font, FontStyle.Regular);
                    nameusrTxt.Text = "";
                    nameusrTxt.ForeColor = SystemColors.WindowText;
                    nameusrTxt.Font = new Font(nameusrTxt.Font, FontStyle.Regular);
                    codClitxt.Text = "";
                    codClitxt.ForeColor = SystemColors.WindowText;
                    codClitxt.Font = new Font(codClitxt.Font, FontStyle.Regular);
                    nitClitxt.Text = "";
                    nitClitxt.ForeColor = SystemColors.WindowText;
                    nitClitxt.Font = new Font(nitClitxt.Font, FontStyle.Regular);
                    nameClitxt.Text = "";
                    nameClitxt.ForeColor = SystemColors.WindowText;
                    nameClitxt.Font = new Font(nameClitxt.Font, FontStyle.Regular);

                    try
                    {
                        read = sqlQ.ExecuteReader();
                        while (read.Read())
                        {
                            cantxt.Text = read.GetInt32(5).ToString();
                            efectivetxt.Text = read.GetDouble(11).ToString();
                            cambiotxt.Text = read.GetDouble(13).ToString();
                            subtxt.Text = read.GetDouble(6).ToString();
                            ivatxt.Text = read.GetDouble(7).ToString();
                            totaltxt.Text = read.GetDouble(8).ToString();
                            TotalPaytxt.Text = read.GetDouble(9).ToString();
                            desctxt.Text = read.GetDouble(12).ToString();
                            detalletxt.Text = read.GetString(14);
                            CodUsrtxt.Text = read.GetInt32(1).ToString();
                            cbtype.SelectedItem = read.GetString(10);
                            nameusrTxt.Text = read.GetString(2);
                            codClitxt.Text = read.GetInt32(3).ToString();
                            nitClitxt.Text = read.GetString(16);
                            nameClitxt.Text = read.GetString(4);
                            dataGridDet.DataSource = CargarDatos();
                        }
                        f.CerrarCnn();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show( ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, La Venta Solicitada no Existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void novoBtn_Click(object sender, EventArgs e)
        {
            Conexion d = new Conexion();

            String nombre = "";
            Int64 codigo = 0;
            double precio = 0;
            int cantidad = 1;
            double total = 0;
            DateTime fecha = new DateTime();
            int cantidadProducto = 0;

            if (codProdtxt.Text != "" && codProdtxt.Font.Italic == true)
            {
                if (codProdtxt.Text == "")
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
            else if (codProdtxt.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo de Registro o Codigo de Barras del Producto que Muestra en la Tabla de Solicitudes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {    //Codigo de ENTER PRESS de las Ventas.                
                string query = "SELECT * FROM Productos WHERE CodBarP ='" + Convert.ToInt64(codProdtxt.Text) + "' ; ";

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
                                    UpdateDetVenta(TotalPaytxt.Text);
                                    ActualizarProducto(Convert.ToInt64(codProdtxt.Text), 1);
                                }
                                else
                                {
                                    InsertNuevoTb(codigo, nombre, cantidad, precio, total);
                                    SumarCantProd();
                                    UpdateTotales();
                                    UpdatePayDesc();
                                    UpdateDetVenta(TotalPaytxt.Text);
                                    ActualizarProducto(Convert.ToInt64(codProdtxt.Text), 1);
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
                                        UpdateDetVenta(TotalPaytxt.Text);
                                        ActualizarProducto(Convert.ToInt64(codProdtxt.Text), 1);
                                    }
                                    else
                                    {
                                        InsertNuevoTb(codigo, nombre, cantidad, precio, total);
                                        SumarCantProd();
                                        UpdateTotales();
                                        UpdatePayDesc();
                                        UpdateDetVenta(TotalPaytxt.Text);
                                        ActualizarProducto(Convert.ToInt64(codProdtxt.Text), 1);
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

        private void CleanList_Click(object sender, EventArgs e)
        {
            string message = "Esta Seguro que Desea Limpiar el Detalle de la Venta a Modificar?";
            string caption = "Limpiar Venta";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            { // Closes the parent form.
                dataGridDet.Rows.Clear();
                codetxt.Text = "";
                cantxt.Text = "";
                efectivetxt.Text = "";
                cambiotxt.Text = "0";
                subtxt.Text = "0";
                ivatxt.Text = "0";
                totaltxt.Text = "0";
                TotalPaytxt.Text = "0";
                desctxt.Text = "0";
                detalletxt.Text = "";
                CodUsrtxt.Text = "";
                nameusrTxt.Text = "";
                codClitxt.Text = "";
                nitClitxt.Text = "";
                nameClitxt.Text = "";
                codProdtxt.Text = "";
                codetxt.Enabled = true;
                addFacture.Enabled = true;
                AddSale.Enabled = false;
                SalirButton.Enabled = false;
                novoBtn.Enabled = true;
                deleteBtn.Enabled = true;
            }
        }


        private int comprobarProducto()
        {
            int cnt = 0;
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            Conexion d = new Conexion();
            string buscar = "SELECT * FROM Productos WHERE CodBarP= '" + Convert.ToInt64(codProdtxt.Text) + "' ; ";
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

            foreach (DataGridViewRow row in dataGridDet.Rows)
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
            foreach (DataGridViewRow row in dataGridDet.Rows)
            {
                if (Convert.ToInt64(row.Cells[0].Value) == valor)
                {
                    lago = dataGridDet.Rows.IndexOf(row);
                }
            }

            dataGridDet[2, lago].Value = (Convert.ToInt32(dataGridDet[2, lago].Value) + 1);
            dataGridDet[4, lago].Value = (Convert.ToDouble(dataGridDet[4, lago].Value) + costo);
            //dataGridVentas[4, lago].Value = Math.Round(Convert.ToDouble(dataGridVentas[4, lago].Value), 2);
        }

        private void InsertNuevoTb(Int64 code, String name, int c, Double costo, Double total)
        {
            costo = Math.Round(costo, 2);
            total = Math.Round(total, 2);

            string[] row0 = { code.ToString(), name, c.ToString(), costo.ToString(), total.ToString() };

            dataGridDet.Rows.Add(row0);
        }


        private void SumarCantProd()
        {
            int res = 0;
            foreach (DataGridViewRow row in dataGridDet.Rows)
            {
                res = res + Convert.ToInt32(row.Cells[2].Value);
            }

            cantxt.Text = res.ToString();
        }

        private void UpdateTotales()
        {
            Double res = 0;
            Double sub = 0;
            Double iva = 0;
            foreach (DataGridViewRow row in dataGridDet.Rows)
            {
                res = res + Convert.ToDouble(row.Cells[4].Value);
            }

            sub = res * 0.87;
            sub = Math.Round(sub, 2);
            iva = res * 0.13;
            iva = Math.Round(iva, 2);

            totaltxt.Text = res.ToString();

            subtxt.Text = sub.ToString();
            ivatxt.Text = iva.ToString();
        }

        private void UpdatePayDesc()
        {
            Double res = 0;
            foreach (DataGridViewRow row in dataGridDet.Rows)
            {
                res = res + Convert.ToDouble(row.Cells[4].Value);
            }
            if (desctxt.Text != "" && desctxt.Font.Italic == true)
            {
                res = Math.Round(res, 2);
                TotalPaytxt.Text = res.ToString();
            }
            else
            {
                if (double.Parse(desctxt.Text) > 0)
                {
                    Double de = (double.Parse(desctxt.Text)) / 100;
                    Double pordesc = res * de;
                    res = res - pordesc;
                    res = Math.Round(res, 2);
                    TotalPaytxt.Text = res.ToString();
                }
                else
                {
                    res = Math.Round(res, 2);
                    TotalPaytxt.Text = res.ToString();
                }
            }
        }





        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Double res = 0;
            int pos = dataGridDet.CurrentRow.Index;

            try
            {
                if (Convert.ToInt32(dataGridDet[2, pos].Value) > 1)
                {
                    dataGridDet[2, pos].Value = (Convert.ToInt32(dataGridDet[2, pos].Value) - 1);
                    res = Convert.ToDouble(dataGridDet[3, pos].Value);
                    dataGridDet[4, pos].Value = (Convert.ToDouble(dataGridDet[4, pos].Value) - res);

                    SumarCantProd();
                    UpdateTotales();
                    UpdatePayDesc();
                    UpdateDetVenta(TotalPaytxt.Text);
                    AumentarDelProducto(Convert.ToInt64(codProdtxt.Text), 1);
                }
                else
                {
                    dataGridDet.Rows.RemoveAt(pos);
                    SumarCantProd();
                    UpdateTotales();
                    UpdatePayDesc();
                    UpdateDetVenta(TotalPaytxt.Text);
                    AumentarDelProducto(Convert.ToInt64(codProdtxt.Text), 1);
                }
            }
            catch (Exception) { }
            
        }

        private void label18_Click(object sender, EventArgs e)
        {
            List_Productos le = new List_Productos();
            le.ShowDialog();

            codProdtxt.Text = "";
            codProdtxt.ForeColor = SystemColors.WindowText;
            codProdtxt.Font = new Font(codProdtxt.Font, FontStyle.Regular);
            codProdtxt.Text = le.codUser.ToString(); 
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Registro_Clientes re = new Registro_Clientes();
            re.CodUsr = codUsr;
            re.ShowDialog();
            nitClitxt.Text = "";
            nitClitxt.ForeColor = SystemColors.WindowText;
            nitClitxt.Font = new Font(nitClitxt.Font, FontStyle.Regular);
            nitClitxt.Text = re.nitCli.ToString();
        }

        private int comprobarCliente()
        {
            int cnt = 0;
            Conexion f = new Conexion();
            string buscar = "SELECT * FROM Clientes WHERE nitCliente= '" + nitClitxt.Text + "' ; ";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (efectivetxt.Text == "" || efectivetxt.Text == "0")
                {
                    MessageBox.Show("ERROR, Debe Ingresar el Monto con el Cual Pago el Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Devuelto = Convert.ToDouble(efectivetxt.Text) - Convert.ToDouble(efectivetxt.Text);
                    if (Devuelto < 0)
                    {
                        MessageBox.Show("ERROR, Debe Ingresar el Monto Mayor o Igual Para Cumplir con la Deuda del Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        cambiotxt.Text = Devuelto.ToString();
                        addFacture.Enabled = true;
                        AddSale.Enabled = false;
                        codProdtxt.Text = "";
                        codProdtxt.Enabled = false;
                        novoBtn.Enabled = false;
                        deleteBtn.Enabled = false;
                        codetxt.Enabled = false;
                        findbtn.Enabled = false;
                        descbtn.Enabled = false;
                        desctxt.Enabled = false;
                        CleanList.Enabled = false;
                        SalirButton.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void titulolabel_Click(object sender, EventArgs e)
        {
            List_Ventas lv = new List_Ventas();
            lv.codUser = codUsr;
            lv.ShowDialog();
            codetxt.Text = "";
            codetxt.ForeColor = SystemColors.WindowText;
            codetxt.Font = new Font(codetxt.Font, FontStyle.Regular);
            codetxt.Text = lv.devcod;
        }


        private void ActuaCantProd(Int64 qqq, int www, int rrr) //disminuye la cantidad del producto (ADD)
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

        private void ActuaDelCantProd(Int64 qqq, int www, int rrr) //aumenta la cantidad del producto (DELETE)
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
                cmd.Parameters["@id"].Value = (rrr + www);
                cmd.Parameters["@ciid"].Value = qqq;

                ert.OpenCnn();
                cmd.ExecuteNonQuery();
                ert.CerrarCnn();
            }
            catch (Exception) { }
        }

        public void ActualizarProducto(Int64 aaa, int bbb) //disminuye la cantidad del producto (ADD)
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

        private void AumentarDelProducto(Int64 aaa, int bbb) //aumenta la cantidad del producto (DELETE)
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
                ActuaDelCantProd(aaa, bbb, ccc);
            }
            catch (Exception) { }
            d.CerrarCnn();
        }

        private void BorrarDetalleVenta(String codv) 
        {
            try
            {
                // Objetos de conexión y comando
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = cs.GetCONN();
                cmd.CommandText = "DELETE FROM Detalle_Venta WHERE cod_Venta = '" + codetxt.Text + "' ;";

                cs.OpenCnn();
                cmd.ExecuteNonQuery();
                cs.CerrarCnn();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "ERROR" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addDetVent_Click(object sender, EventArgs e)
        {
            dateday = DateTime.UtcNow;
            Conexion c = new Conexion();
            BorrarDetalleVenta(codetxt.Text);

            try
            {   // Objetos de conexión y comando
                foreach (DataGridViewRow row in dataGridDet.Rows)
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
                    cmd.Parameters["@codv"].Value = codetxt.Text;

                    c.OpenCnn();
                    cmd.ExecuteNonQuery();
                    c.CerrarCnn();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. Al Insertar Los Datos del Detalle de Venta. " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
