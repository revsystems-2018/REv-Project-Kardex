namespace Proyect_Kardex
{
    partial class List_Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_Ventas));
            this.regprodtable = new System.Windows.Forms.DataGridView();
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
            this.botonselect = new System.Windows.Forms.Button();
            this.seeProd = new System.Windows.Forms.Button();
            this.printview = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.rEV_VentasTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.REV_VentasTableAdapter();
            this.toolTipventas = new System.Windows.Forms.ToolTip(this.components);
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.regprodtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // regprodtable
            // 
            this.regprodtable.AllowUserToAddRows = false;
            this.regprodtable.AllowUserToDeleteRows = false;
            this.regprodtable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regprodtable.AutoGenerateColumns = false;
            this.regprodtable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.regprodtable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.regprodtable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.regprodtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regprodtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.regprodtable.DataSource = this.rEVVentasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.regprodtable.DefaultCellStyle = dataGridViewCellStyle2;
            this.regprodtable.Location = new System.Drawing.Point(1, 51);
            this.regprodtable.Name = "regprodtable";
            this.regprodtable.ReadOnly = true;
            this.regprodtable.Size = new System.Drawing.Size(534, 453);
            this.regprodtable.TabIndex = 303;
            this.regprodtable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.regprodtable_CellClick);
            // 
            // idVentaDataGridViewTextBoxColumn
            // 
            this.idVentaDataGridViewTextBoxColumn.DataPropertyName = "id_Venta";
            this.idVentaDataGridViewTextBoxColumn.HeaderText = "Codigo de Registro";
            this.idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
            this.idVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVentaDataGridViewTextBoxColumn.Width = 150;
            // 
            // idUserDataGridViewTextBoxColumn
            // 
            this.idUserDataGridViewTextBoxColumn.DataPropertyName = "id_User";
            this.idUserDataGridViewTextBoxColumn.HeaderText = "Codigo Usuario";
            this.idUserDataGridViewTextBoxColumn.Name = "idUserDataGridViewTextBoxColumn";
            this.idUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUserDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameUserDataGridViewTextBoxColumn
            // 
            this.nameUserDataGridViewTextBoxColumn.DataPropertyName = "name_User";
            this.nameUserDataGridViewTextBoxColumn.HeaderText = "Nombre Usuario";
            this.nameUserDataGridViewTextBoxColumn.Name = "nameUserDataGridViewTextBoxColumn";
            this.nameUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameUserDataGridViewTextBoxColumn.Width = 120;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "Codigo Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameClienteDataGridViewTextBoxColumn
            // 
            this.nameClienteDataGridViewTextBoxColumn.DataPropertyName = "name_Cliente";
            this.nameClienteDataGridViewTextBoxColumn.HeaderText = "Nombre Cliente";
            this.nameClienteDataGridViewTextBoxColumn.Name = "nameClienteDataGridViewTextBoxColumn";
            this.nameClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameClienteDataGridViewTextBoxColumn.Width = 120;
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
            this.pagoClienteDataGridViewTextBoxColumn.HeaderText = "Efectivo Cliente";
            this.pagoClienteDataGridViewTextBoxColumn.Name = "pagoClienteDataGridViewTextBoxColumn";
            this.pagoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.pagoClienteDataGridViewTextBoxColumn.Width = 130;
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
            this.toPayDataGridViewTextBoxColumn.HeaderText = "Importe Total";
            this.toPayDataGridViewTextBoxColumn.Name = "toPayDataGridViewTextBoxColumn";
            this.toPayDataGridViewTextBoxColumn.ReadOnly = true;
            this.toPayDataGridViewTextBoxColumn.Width = 120;
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
            this.detalleCashDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.detalleCashDataGridViewTextBoxColumn.Name = "detalleCashDataGridViewTextBoxColumn";
            this.detalleCashDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.fechaVentaDataGridViewTextBoxColumn.HeaderText = "Fecha/Hora";
            this.fechaVentaDataGridViewTextBoxColumn.Name = "fechaVentaDataGridViewTextBoxColumn";
            this.fechaVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nittocliDataGridViewTextBoxColumn
            // 
            this.nittocliDataGridViewTextBoxColumn.DataPropertyName = "nit_to_cli";
            this.nittocliDataGridViewTextBoxColumn.HeaderText = "NIT Cliente";
            this.nittocliDataGridViewTextBoxColumn.Name = "nittocliDataGridViewTextBoxColumn";
            this.nittocliDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.panel1.Controls.Add(this.botonselect);
            this.panel1.Controls.Add(this.seeProd);
            this.panel1.Controls.Add(this.printview);
            this.panel1.Controls.Add(this.actualizar);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 51);
            this.panel1.TabIndex = 302;
            // 
            // botonselect
            // 
            this.botonselect.BackColor = System.Drawing.Color.Transparent;
            this.botonselect.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Selectb;
            this.botonselect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonselect.Enabled = false;
            this.botonselect.FlatAppearance.BorderSize = 0;
            this.botonselect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonselect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.botonselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonselect.Location = new System.Drawing.Point(37, 5);
            this.botonselect.Name = "botonselect";
            this.botonselect.Size = new System.Drawing.Size(40, 40);
            this.botonselect.TabIndex = 301;
            this.botonselect.UseVisualStyleBackColor = false;
            this.botonselect.Click += new System.EventHandler(this.botonselect_Click);
            // 
            // seeProd
            // 
            this.seeProd.BackColor = System.Drawing.Color.Transparent;
            this.seeProd.BackgroundImage = global::Proyect_Kardex.Properties.Resources.detalleDocx;
            this.seeProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seeProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seeProd.FlatAppearance.BorderSize = 0;
            this.seeProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.seeProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.seeProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeProd.Location = new System.Drawing.Point(113, 5);
            this.seeProd.Name = "seeProd";
            this.seeProd.Size = new System.Drawing.Size(40, 40);
            this.seeProd.TabIndex = 306;
            this.seeProd.UseVisualStyleBackColor = false;
            this.seeProd.Click += new System.EventHandler(this.seeProd_Click);
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
            this.printview.Location = new System.Drawing.Point(320, 2);
            this.printview.Name = "printview";
            this.printview.Size = new System.Drawing.Size(20, 20);
            this.printview.TabIndex = 298;
            this.printview.UseVisualStyleBackColor = false;
            this.printview.Click += new System.EventHandler(this.printview_Click);
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
            this.actualizar.Location = new System.Drawing.Point(199, 5);
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
            this.print.Location = new System.Drawing.Point(294, 5);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(40, 40);
            this.print.TabIndex = 292;
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
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
            this.save.Location = new System.Drawing.Point(383, 5);
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
            this.salir.Location = new System.Drawing.Point(459, 5);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(40, 40);
            this.salir.TabIndex = 251;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
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
            // List_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(536, 504);
            this.Controls.Add(this.regprodtable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "List_Ventas";
            this.Text = "Registro de Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.List_Ventas_FormClosing);
            this.Load += new System.EventHandler(this.List_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regprodtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView regprodtable;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button botonselect;
        public System.Windows.Forms.Button seeProd;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.Button actualizar;
        public System.Windows.Forms.Button print;
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
        public System.Windows.Forms.ToolTip toolTipventas;
        public System.Windows.Forms.PrintDialog printMain;
        public System.Drawing.Printing.PrintDocument printDocx;
        public System.Windows.Forms.PrintPreviewDialog printPreview;
    }
}