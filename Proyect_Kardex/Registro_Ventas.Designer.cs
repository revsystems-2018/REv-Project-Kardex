namespace Proyect_Kardex
{
    partial class Registro_Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Ventas));
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.idVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typePayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleCashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cambioSellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nittocliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEVVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEV_DataBaseDataSet = new Proyect_Kardex.REV_DataBaseDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rEV_VentasTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.REV_VentasTableAdapter();
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printview = new System.Windows.Forms.Button();
            this.verbtn = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridClientes.AutoGenerateColumns = false;
            this.dataGridClientes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVentaDataGridViewTextBoxColumn,
            this.idUserDataGridViewTextBoxColumn,
            this.nameUserDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.nameClienteDataGridViewTextBoxColumn,
            this.numProdDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn,
            this.rCivaDataGridViewTextBoxColumn,
            this.totalPayDataGridViewTextBoxColumn,
            this.pagoClienteDataGridViewTextBoxColumn,
            this.typePayDataGridViewTextBoxColumn,
            this.toPayDataGridViewTextBoxColumn,
            this.descuentPayDataGridViewTextBoxColumn,
            this.detalleCashDataGridViewTextBoxColumn,
            this.cambioSellDataGridViewTextBoxColumn,
            this.fechaVentaDataGridViewTextBoxColumn,
            this.nittocliDataGridViewTextBoxColumn});
            this.dataGridClientes.DataSource = this.rEVVentasBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridClientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridClientes.Location = new System.Drawing.Point(1, 51);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.Size = new System.Drawing.Size(784, 432);
            this.dataGridClientes.TabIndex = 299;
            this.dataGridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellClick);
            // 
            // idVentaDataGridViewTextBoxColumn
            // 
            this.idVentaDataGridViewTextBoxColumn.DataPropertyName = "id_Venta";
            this.idVentaDataGridViewTextBoxColumn.HeaderText = "Codigo de Registro";
            this.idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
            this.idVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVentaDataGridViewTextBoxColumn.Width = 140;
            // 
            // idUserDataGridViewTextBoxColumn
            // 
            this.idUserDataGridViewTextBoxColumn.DataPropertyName = "id_User";
            this.idUserDataGridViewTextBoxColumn.HeaderText = "Codigo de Usuario";
            this.idUserDataGridViewTextBoxColumn.Name = "idUserDataGridViewTextBoxColumn";
            this.idUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUserDataGridViewTextBoxColumn.Width = 140;
            // 
            // nameUserDataGridViewTextBoxColumn
            // 
            this.nameUserDataGridViewTextBoxColumn.DataPropertyName = "name_User";
            this.nameUserDataGridViewTextBoxColumn.HeaderText = "Nombre de Usuario";
            this.nameUserDataGridViewTextBoxColumn.Name = "nameUserDataGridViewTextBoxColumn";
            this.nameUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameUserDataGridViewTextBoxColumn.Width = 140;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "Codigo de Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Width = 130;
            // 
            // nameClienteDataGridViewTextBoxColumn
            // 
            this.nameClienteDataGridViewTextBoxColumn.DataPropertyName = "name_Cliente";
            this.nameClienteDataGridViewTextBoxColumn.HeaderText = "Nombre de Cliente";
            this.nameClienteDataGridViewTextBoxColumn.Name = "nameClienteDataGridViewTextBoxColumn";
            this.nameClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameClienteDataGridViewTextBoxColumn.Width = 140;
            // 
            // numProdDataGridViewTextBoxColumn
            // 
            this.numProdDataGridViewTextBoxColumn.DataPropertyName = "num_Prod";
            this.numProdDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.numProdDataGridViewTextBoxColumn.Name = "numProdDataGridViewTextBoxColumn";
            this.numProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "sub_Total";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "Sub-Total";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rCivaDataGridViewTextBoxColumn
            // 
            this.rCivaDataGridViewTextBoxColumn.DataPropertyName = "RC_iva";
            this.rCivaDataGridViewTextBoxColumn.HeaderText = "RC IVA";
            this.rCivaDataGridViewTextBoxColumn.Name = "rCivaDataGridViewTextBoxColumn";
            this.rCivaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPayDataGridViewTextBoxColumn
            // 
            this.totalPayDataGridViewTextBoxColumn.DataPropertyName = "total_Pay";
            this.totalPayDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalPayDataGridViewTextBoxColumn.Name = "totalPayDataGridViewTextBoxColumn";
            this.totalPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagoClienteDataGridViewTextBoxColumn
            // 
            this.pagoClienteDataGridViewTextBoxColumn.DataPropertyName = "pago_Cliente";
            this.pagoClienteDataGridViewTextBoxColumn.HeaderText = "Total a Pagar";
            this.pagoClienteDataGridViewTextBoxColumn.Name = "pagoClienteDataGridViewTextBoxColumn";
            this.pagoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.pagoClienteDataGridViewTextBoxColumn.Width = 120;
            // 
            // typePayDataGridViewTextBoxColumn
            // 
            this.typePayDataGridViewTextBoxColumn.DataPropertyName = "type_Pay";
            this.typePayDataGridViewTextBoxColumn.HeaderText = "Tipo de Pago";
            this.typePayDataGridViewTextBoxColumn.Name = "typePayDataGridViewTextBoxColumn";
            this.typePayDataGridViewTextBoxColumn.ReadOnly = true;
            this.typePayDataGridViewTextBoxColumn.Width = 120;
            // 
            // toPayDataGridViewTextBoxColumn
            // 
            this.toPayDataGridViewTextBoxColumn.DataPropertyName = "to_Pay";
            this.toPayDataGridViewTextBoxColumn.HeaderText = "Efectivo";
            this.toPayDataGridViewTextBoxColumn.Name = "toPayDataGridViewTextBoxColumn";
            this.toPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descuentPayDataGridViewTextBoxColumn
            // 
            this.descuentPayDataGridViewTextBoxColumn.DataPropertyName = "Descuent_Pay";
            this.descuentPayDataGridViewTextBoxColumn.HeaderText = "Descuento";
            this.descuentPayDataGridViewTextBoxColumn.Name = "descuentPayDataGridViewTextBoxColumn";
            this.descuentPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalleCashDataGridViewTextBoxColumn
            // 
            this.detalleCashDataGridViewTextBoxColumn.DataPropertyName = "Detalle_Cash";
            this.detalleCashDataGridViewTextBoxColumn.HeaderText = "Detalle Total";
            this.detalleCashDataGridViewTextBoxColumn.Name = "detalleCashDataGridViewTextBoxColumn";
            this.detalleCashDataGridViewTextBoxColumn.ReadOnly = true;
            this.detalleCashDataGridViewTextBoxColumn.Width = 120;
            // 
            // cambioSellDataGridViewTextBoxColumn
            // 
            this.cambioSellDataGridViewTextBoxColumn.DataPropertyName = "cambio_Sell";
            this.cambioSellDataGridViewTextBoxColumn.HeaderText = "Devuelto";
            this.cambioSellDataGridViewTextBoxColumn.Name = "cambioSellDataGridViewTextBoxColumn";
            this.cambioSellDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaVentaDataGridViewTextBoxColumn
            // 
            this.fechaVentaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Venta";
            this.fechaVentaDataGridViewTextBoxColumn.HeaderText = "Fecha de Venta";
            this.fechaVentaDataGridViewTextBoxColumn.Name = "fechaVentaDataGridViewTextBoxColumn";
            this.fechaVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaVentaDataGridViewTextBoxColumn.Width = 130;
            // 
            // nittocliDataGridViewTextBoxColumn
            // 
            this.nittocliDataGridViewTextBoxColumn.DataPropertyName = "nit_to_cli";
            this.nittocliDataGridViewTextBoxColumn.HeaderText = "NIT de Cliente";
            this.nittocliDataGridViewTextBoxColumn.Name = "nittocliDataGridViewTextBoxColumn";
            this.nittocliDataGridViewTextBoxColumn.ReadOnly = true;
            this.nittocliDataGridViewTextBoxColumn.Width = 120;
            // 
            // rEVVentasBindingSource
            // 
            this.rEVVentasBindingSource.DataMember = "REV_Ventas";
            this.rEVVentasBindingSource.DataSource = this.rEV_DataBaseDataSet;
            // 
            // rEV_DataBaseDataSet
            // 
            this.rEV_DataBaseDataSet.DataSetName = "REV_DataBaseDataSet";
            this.rEV_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.printview);
            this.panel1.Controls.Add(this.verbtn);
            this.panel1.Controls.Add(this.actualizar);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.nuevo);
            this.panel1.Controls.Add(this.eliminar);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 51);
            this.panel1.TabIndex = 298;
            // 
            // rEV_VentasTableAdapter
            // 
            this.rEV_VentasTableAdapter.ClearBeforeFill = true;
            // 
            // printMain
            // 
            this.printMain.Document = this.printDocx;
            this.printMain.UseEXDialog = true;
            // 
            // printDocx
            // 
            this.printDocx.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocx_PrintPage);
            // 
            // printPreview
            // 
            this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Document = this.printDocx;
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.ShowIcon = false;
            this.printPreview.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Proyect_Kardex.Properties.Resources.fechaventa;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(604, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 301;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Proyect_Kardex.Properties.Resources.devolDocxs;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(409, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 300;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Proyect_Kardex.Properties.Resources.FacturaDocx;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(353, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 299;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Proyect_Kardex.Properties.Resources.detalleDocx;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(297, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 298;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Proyect_Kardex.Properties.Resources.seeCliente;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(231, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 297;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printview
            // 
            this.printview.BackColor = System.Drawing.Color.Transparent;
            this.printview.BackgroundImage = global::Proyect_Kardex.Properties.Resources.dosnotify;
            this.printview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printview.FlatAppearance.BorderSize = 0;
            this.printview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.printview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.printview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printview.Location = new System.Drawing.Point(558, 4);
            this.printview.Name = "printview";
            this.printview.Size = new System.Drawing.Size(20, 20);
            this.printview.TabIndex = 296;
            this.printview.UseVisualStyleBackColor = false;
            this.printview.Click += new System.EventHandler(this.printview_Click);
            // 
            // verbtn
            // 
            this.verbtn.BackColor = System.Drawing.Color.Transparent;
            this.verbtn.BackgroundImage = global::Proyect_Kardex.Properties.Resources.seePerfil;
            this.verbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verbtn.FlatAppearance.BorderSize = 0;
            this.verbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.verbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.verbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verbtn.Location = new System.Drawing.Point(175, 5);
            this.verbtn.Name = "verbtn";
            this.verbtn.Size = new System.Drawing.Size(40, 40);
            this.verbtn.TabIndex = 294;
            this.verbtn.UseVisualStyleBackColor = false;
            this.verbtn.Click += new System.EventHandler(this.verbtn_Click);
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.Color.Transparent;
            this.actualizar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.update;
            this.actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actualizar.FlatAppearance.BorderSize = 0;
            this.actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizar.Location = new System.Drawing.Point(475, 5);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(40, 40);
            this.actualizar.TabIndex = 293;
            this.actualizar.UseVisualStyleBackColor = false;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.Transparent;
            this.print.BackgroundImage = global::Proyect_Kardex.Properties.Resources.print;
            this.print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print.FlatAppearance.BorderSize = 0;
            this.print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Location = new System.Drawing.Point(531, 5);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(40, 40);
            this.print.TabIndex = 292;
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.Transparent;
            this.editar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editdocumento;
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editar.FlatAppearance.BorderSize = 0;
            this.editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Location = new System.Drawing.Point(60, 5);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(40, 40);
            this.editar.TabIndex = 291;
            this.editar.UseVisualStyleBackColor = false;
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.Transparent;
            this.nuevo.BackgroundImage = global::Proyect_Kardex.Properties.Resources.novo;
            this.nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuevo.FlatAppearance.BorderSize = 0;
            this.nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevo.Location = new System.Drawing.Point(11, 5);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(40, 40);
            this.nuevo.TabIndex = 290;
            this.nuevo.UseVisualStyleBackColor = false;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.Transparent;
            this.eliminar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_delete;
            this.eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminar.FlatAppearance.BorderSize = 0;
            this.eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.Location = new System.Drawing.Point(109, 5);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(40, 40);
            this.eliminar.TabIndex = 289;
            this.eliminar.UseVisualStyleBackColor = false;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.savedexcel;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(670, 5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(40, 40);
            this.save.TabIndex = 250;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.BackgroundImage = global::Proyect_Kardex.Properties.Resources.close_off_512;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.FlatAppearance.BorderSize = 0;
            this.salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Location = new System.Drawing.Point(733, 5);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(40, 40);
            this.salir.TabIndex = 251;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Registro_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(786, 483);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.Registro_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridClientes;
        public System.Windows.Forms.Button verbtn;
        public System.Windows.Forms.Button actualizar;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button editar;
        public System.Windows.Forms.Button nuevo;
        public System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button salir;
        private REV_DataBaseDataSet rEV_DataBaseDataSet;
        private System.Windows.Forms.BindingSource rEVVentasBindingSource;
        private REV_DataBaseDataSetTableAdapters.REV_VentasTableAdapter rEV_VentasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typePayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleCashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cambioSellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nittocliDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printMain;
        private System.Drawing.Printing.PrintDocument printDocx;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
    }
}