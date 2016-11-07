using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect_Kardex
{
    public partial class PedidosCompras : Form
    {
        ValidacionText vb = new ValidacionText();
        int pos = 0;
        Double var = 0.00;
        Double total = 0;
        public PedidosCompras()
        {
            InitializeComponent();

            toolTipedidos.SetToolTip(listlow, "Registro de Productos de Stock Mínimo");
            toolTipedidos.SetToolTip(veboton, "Buscar Producto");
            toolTipedidos.SetToolTip(botonprove, "Registro de Proveedores");
            toolTipedidos.SetToolTip(listprod, "Registro de Productos");
            toolTipedidos.SetToolTip(print, "Imprimir");
            toolTipedidos.SetToolTip(printview, "Vista Previa");
            toolTipedidos.SetToolTip(addprod, "Agregar Nuevo Producto");
            toolTipedidos.SetToolTip(buscarprod, "Buscar Detalle de Producto");
            toolTipedidos.SetToolTip(saveboton, "Guardar");
            toolTipedidos.SetToolTip(salir, "Salir");
            toolTipedidos.SetToolTip(codprod, "Ingrese el Codigo de Barras del Producto");
            toolTipedidos.SetToolTip(nameprod, "Ingrese el Nombre del Producto");
            toolTipedidos.SetToolTip(dateTime2, "Seleccionar un Fecha Estimada de Recibo del Pedido");
            toolTipedidos.SetToolTip(textcant, "Ingresar la Cantidad de Productos a Pedir");
            toolTipedidos.SetToolTip(dateprod, "Cambiar la Fecha de Vencimiento del Producto");
            toolTipedidos.SetToolTip(textcodprov, "Ingrese el Codigo de Registro del Proveedor");
            toolTipedidos.SetToolTip(textemprov, "Ingrese el Nombre de la Empresa del Proveedor");
            toolTipedidos.SetToolTip(buscarprod, "Buscar");
            toolTipedidos.SetToolTip(textCCU, "Ingrese/Cambiar el Costo de Compra Unitaria del Producto");
            toolTipedidos.SetToolTip(ivabox, "Seleccionar el Impuesto del Producto");
            toolTipedidos.SetToolTip(addboton, "Agregar Producto");
            toolTipedidos.SetToolTip(editboton, "Editar Producto");
            toolTipedidos.SetToolTip(elimboton, "Eliminar Producto");
            toolTipedidos.SetToolTip(btnnovo, "Agregar Nuevamente");
            toolTipedidos.SetToolTip(checkdesc, "Marcar para Agregar Descuento");
            toolTipedidos.SetToolTip(Descuentext, "Ingresar Porcentaje de Descuento");
            toolTipedidos.SetToolTip(addDescuent, "Agregar Descuento");
            toolTipedidos.SetToolTip(checkdate, "Marcar Si el Producto Tiene/Cambiar Fecha de Vencimiento");
            toolTipedidos.SetToolTip(textsub, "Subtotal del Pedido");
            toolTipedidos.SetToolTip(textdesc, "Descuento del Pedido");
            toolTipedidos.SetToolTip(textivarc, "RC-IVA 13%");
            toolTipedidos.SetToolTip(texttotal, "Costo Total del Pedido");
        }

        private void textcant_TextChanged(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            string message = "Esta Seguro que Desea Cancelar el Registro de Pedidos?";
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

        private void buscarprod_Click(object sender, EventArgs e)
        {
            BuscarProductos bv = new BuscarProductos();
            bv.ShowDialog();
        }

        private void addprod_Click(object sender, EventArgs e)
        {
            AddProductos ad = new AddProductos();
            ad.ShowDialog();
        }

        private void listprod_Click(object sender, EventArgs e)
        {
            Registro_Productos re = new Registro_Productos();
            codprod.Text = "";
            codprod.ForeColor = SystemColors.WindowText;
            codprod.Font = new Font(codprod.Font, FontStyle.Regular);
            nameprod.Text = "";
            nameprod.ForeColor = SystemColors.WindowText;
            nameprod.Font = new Font(codprod.Font, FontStyle.Regular);
            textcant.Text = "";
            textcant.ForeColor = SystemColors.WindowText;
            textcant.Font = new Font(codprod.Font, FontStyle.Regular);
            textCCU.Text = "";
            textCCU.ForeColor = SystemColors.WindowText;
            textCCU.Font = new Font(codprod.Font, FontStyle.Regular);

            re.nuevo.Enabled = false;
            re.nuevo.BackgroundImage = global::Proyect_Kardex.Properties.Resources.novob;
            re.editar.Enabled = false;
            re.editar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editdocumentob;
            re.eliminar.Enabled = false;
            re.eliminar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_deleteb;
            re.ShowDialog();
        }

        private void botonprove_Click(object sender, EventArgs e)
        {
            Registro_Proveedores rt = new Registro_Proveedores();
            textcodprov.Text = "";
            textcodprov.ForeColor = SystemColors.WindowText;
            textcodprov.Font = new Font(codprod.Font, FontStyle.Regular);
            textemprov.Text = "";
            textemprov.ForeColor = SystemColors.WindowText;
            textemprov.Font = new Font(codprod.Font, FontStyle.Regular);
            rt.ShowDialog();
        }

        private void veboton_Click(object sender, EventArgs e)
        {
            if (codprod.Text != "" && codprod.Font.Italic == true)
            {
                if (codprod.Text == "")
                {
                    MessageBox.Show("Ingrese el Codigo de Barras del Producto (13 Digitos).", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el Codigo de Barras del Producto (13 Digitos).", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (codprod.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo de Barras del Producto (13 Digitos).", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //Codigo de Buscar el Codigo existente.
            }
        }

        private void buscarprov_Click(object sender, EventArgs e)
        {
            if (textcodprov.Text != "" && textcodprov.Font.Italic == true)
            {
                if (textcodprov.Text == "")
                {
                    MessageBox.Show("Ingrese el codigo de Registro del Proveedor Como muestra en la Tabla de Registro.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese el codigo de Registro del Proveedor Como muestra en la Tabla de Registro.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcodprov.Text == "")
            {
                MessageBox.Show("Ingrese el codigo de Registro del Proveedor Como muestra en la Tabla de Registro.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //Codigo de Buscar el Codigo existente.
            }
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

        private void checkdesc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkdesc.Checked)
            {
                Descuentext.Enabled = true;
                addDescuent.Enabled = true;
            }
            else
            {
                Descuentext.Enabled = false;
                addDescuent.Enabled = false;
                textdesc.Text = "0,00";
                total = 0.00;
                foreach (DataGridViewRow row in dataTabla.Rows)
                {
                    int n = row.Index;
                    total += Convert.ToDouble(dataTabla.Rows[n].Cells[7].Value);
                }
                texttotal.Text = Convert.ToString(total);
            }
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

        private void codproveClick(object sender, MouseEventArgs e)
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

        private void nameproveClick(object sender, MouseEventArgs e)
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

        private void desctextClick(object sender, MouseEventArgs e)
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
            }
        }

        private void numcodprod(object sender, KeyPressEventArgs e)
        {
            codprod.ForeColor = SystemColors.WindowText;
            codprod.Font = new Font(Descuentext.Font, FontStyle.Regular);
            vb.soloNumeros(e);
        }

        private void lettername(object sender, KeyPressEventArgs e)
        {
            nameprod.ForeColor = SystemColors.WindowText;
            nameprod.Font = new Font(Descuentext.Font, FontStyle.Regular);
            vb.soloLetras(e);
        }

        private void numCant(object sender, KeyPressEventArgs e)
        {
            textcant.ForeColor = SystemColors.WindowText;
            textcant.Font = new Font(Descuentext.Font, FontStyle.Regular);
            vb.soloNumeros(e);
        }

        private void numcodprove(object sender, KeyPressEventArgs e)
        {
            textcodprov.ForeColor = SystemColors.WindowText;
            textcodprov.Font = new Font(Descuentext.Font, FontStyle.Regular);
            vb.soloNumeros(e);
        }

        private void numlettername(object sender, KeyPressEventArgs e)
        {
            textemprov.ForeColor = SystemColors.WindowText;
            textemprov.Font = new Font(Descuentext.Font, FontStyle.Regular);
            vb.soloNumeros(e);
            vb.soloLetras(e);
        }

        private void decimalCCU(object sender, KeyPressEventArgs e)
        {
            textCCU.ForeColor = SystemColors.WindowText;
            textCCU.Font = new Font(Descuentext.Font, FontStyle.Regular);

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

        public void limpiar() {

            this.codprod.Text = "";
            this.nameprod.Text = "";
            this.textcant.Text = "";
            this.textcodprov.Text = "";
            this.textemprov.Text = "";
            this.textCCU.Text = "";
        }

        private void addboton_Click(object sender, EventArgs e)
        {
            if (codprod.Font.Italic == true || nameprod.Font.Italic == true || textcant.Font.Italic == true || textcodprov.Font.Italic == true || textCCU.Font.Italic == true)
            {
                if (textcodprov.Text == "" || codprod.Text == "" || nameprod.Text == "" || textcant.Text =="" || textCCU.Text == "")
                {
                    MessageBox.Show("Debe Ingresar los Datos Respectivos para Realizar el Registro de Pedidos.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe Ingresar los Datos Respectivos para Realizar el Registro de Pedidos.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textcodprov.Text == "" || codprod.Text == "" || nameprod.Text == "" || textcant.Text == "" || textCCU.Text == "")
            {
                MessageBox.Show("Debe Ingresar los Datos Respectivos para Realizar el Registro de Pedidos.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Codigo de add.
                if (dateprod.Enabled == true)
                {
                    var = (Convert.ToDouble(textCCU.Text)) * (Convert.ToDouble(textcant.Text));
                    dataTabla.Rows.Add(codprod.Text, nameprod.Text, textcant.Text, textcodprov.Text, dateprod.Text, textCCU.Text, (var*0.13)+ "", var + "");
                    limpiar();
                    total = 0.00;
                    foreach(DataGridViewRow row in dataTabla.Rows)
                    {
                        int n = row.Index;
                        total += Convert.ToDouble(dataTabla.Rows[n].Cells[7].Value);
                    }
                    texttotal.Text = Convert.ToString(total);
                    textsub.Text = Convert.ToString((total*0.85));
                    textivarc.Text = Convert.ToString((total*0.13));
                }
                else
                {
                    var = (Convert.ToDouble(textCCU.Text)) * (Convert.ToDouble(textcant.Text));
                    dataTabla.Rows.Add(codprod.Text, nameprod.Text, textcant.Text, textcodprov.Text, "", textCCU.Text, (var * 0.13) + "", var + "");
                    limpiar();
                    total = 0.00;
                    foreach (DataGridViewRow row in dataTabla.Rows)
                    {
                        int n = row.Index;
                        total += Convert.ToDouble(dataTabla.Rows[n].Cells[7].Value);
                    }
                    texttotal.Text = Convert.ToString(total);
                    textsub.Text = Convert.ToString((total * 0.85));
                    textivarc.Text = Convert.ToString((total * 0.13));
                }
            }
        }

        private void dataTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dataTabla.CurrentRow.Index;
            codprod.Text = dataTabla[0, pos].Value.ToString();
            nameprod.Text = dataTabla[1, pos].Value.ToString();
            textcant.Text = dataTabla[2, pos].Value.ToString();
            textcodprov.Text = dataTabla[3, pos].Value.ToString();
            textCCU.Text = dataTabla[5, pos].Value.ToString();

            addboton.Enabled = false;
            editboton.Enabled = true;
            elimboton.Enabled = true;
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            limpiar();
            addboton.Enabled = true;
            editboton.Enabled = false;
            elimboton.Enabled = false;
        }

        private void editboton_Click(object sender, EventArgs e)
        {
            var = (Convert.ToDouble(textCCU.Text)) * (Convert.ToDouble(textcant.Text));
            pos = dataTabla.CurrentRow.Index;

            try
            {
                if (dateprod.Enabled == true)
                {
                    dataTabla[0, pos].Value = codprod.Text;
                    dataTabla[1, pos].Value = nameprod.Text;
                    dataTabla[2, pos].Value = textcant.Text;
                    dataTabla[3, pos].Value = textcodprov.Text;
                    dataTabla[4, pos].Value = dateprod.Text;
                    dataTabla[5, pos].Value = textCCU.Text;
                    dataTabla[6, pos].Value = (var * 0.13) + "";
                    dataTabla[7, pos].Value = var + "";
                    limpiar();
                    total = 0.00;
                    foreach (DataGridViewRow row in dataTabla.Rows)
                    {
                        int n = row.Index;
                        total += Convert.ToDouble(dataTabla.Rows[n].Cells[7].Value);
                    }
                    texttotal.Text = Convert.ToString(total);
                    textsub.Text = Convert.ToString((total * 0.85));
                    textivarc.Text = Convert.ToString((total * 0.13));
                }
                else
                {
                    dataTabla[0, pos].Value = codprod.Text;
                    dataTabla[1, pos].Value = nameprod.Text;
                    dataTabla[2, pos].Value = textcant.Text;
                    dataTabla[3, pos].Value = textcodprov.Text;
                    dataTabla[4, pos].Value = "";
                    dataTabla[5, pos].Value = textCCU.Text;
                    dataTabla[6, pos].Value = (var * 0.13) + "";
                    dataTabla[7, pos].Value = var + "";
                    limpiar();
                    total = 0.00;
                    foreach (DataGridViewRow row in dataTabla.Rows)
                    {
                        int n = row.Index;
                        total += Convert.ToDouble(dataTabla.Rows[n].Cells[7].Value);
                    }
                    texttotal.Text = Convert.ToString(total);
                    textsub.Text = Convert.ToString((total * 0.85));
                    textivarc.Text = Convert.ToString((total * 0.13));
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void elimboton_Click(object sender, EventArgs e)
        {
            try
            {
                dataTabla.Rows.RemoveAt(pos);
                limpiar();
                total = 0.00;
                foreach (DataGridViewRow row in dataTabla.Rows)
                {
                    int n = row.Index;
                    total += Convert.ToDouble(dataTabla.Rows[n].Cells[7].Value);
                }
                texttotal.Text = Convert.ToString(total);
                textsub.Text = Convert.ToString((total * 0.85));
                textivarc.Text = Convert.ToString((total * 0.13));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addDescuent_Click(object sender, EventArgs e)
        {
            Double re = 0;
            try
            {
                if (Descuentext.Enabled == true)
                {
                    if (Convert.ToDouble(Descuentext.Text) > 100.0)
                    {
                        re = Convert.ToDouble(Descuentext.Text) / 100;
                        Descuentext.Text = Convert.ToString(re);

                        textdesc.Text = Convert.ToString(((Convert.ToDouble(Descuentext.Text) / 100) * total));
                        texttotal.Text = Convert.ToString(total - Convert.ToDouble(textdesc.Text));
                        addboton.Enabled = false;
                        editboton.Enabled = false;
                        elimboton.Enabled = false;
                        btnnovo.Enabled = false;

                        MessageBox.Show("El Descuento No Debe Sobre pasar del 100%", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        re = Convert.ToDouble(Descuentext.Text);
                        Descuentext.Text = Convert.ToString(re);

                        textdesc.Text = Convert.ToString(((Convert.ToDouble(Descuentext.Text) / 100) * total));
                        texttotal.Text = Convert.ToString(total - Convert.ToDouble(textdesc.Text));
                        addboton.Enabled = false;
                        editboton.Enabled = false;
                        elimboton.Enabled = false;
                        btnnovo.Enabled = false;
                    }
                }
                else
                { 
                    textdesc.Text = "0,00";
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void desccoma(object sender, KeyPressEventArgs e)
        {
            Descuentext.ForeColor = SystemColors.WindowText;
            Descuentext.Font = new Font(Descuentext.Font, FontStyle.Regular);

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
                else if ((e.KeyChar == ',') && (!Descuentext.Text.Contains(",")))
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
    }
}
