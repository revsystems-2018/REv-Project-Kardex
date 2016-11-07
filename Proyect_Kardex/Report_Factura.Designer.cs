namespace Proyect_Kardex
{
    partial class Report_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Factura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechas = new System.Windows.Forms.Button();
            this.seeProd = new System.Windows.Forms.Button();
            this.printview = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.txtTotalV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cantlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataFactuVenta = new System.Windows.Forms.DataGridView();
            this.numFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAutorizDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitFEmpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitciClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomFCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotalFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleVenFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codControlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVenFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEV_DataBaseDataSet = new Proyect_Kardex.REV_DataBaseDataSet();
            this.facturasTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.FacturasTableAdapter();
            this.toolTipF = new System.Windows.Forms.ToolTip(this.components);
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFactuVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnFechas);
            this.panel1.Controls.Add(this.seeProd);
            this.panel1.Controls.Add(this.printview);
            this.panel1.Controls.Add(this.actualizar);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 51);
            this.panel1.TabIndex = 310;
            // 
            // btnFechas
            // 
            this.btnFechas.BackColor = System.Drawing.Color.Transparent;
            this.btnFechas.BackgroundImage = global::Proyect_Kardex.Properties.Resources.datetimeCancel;
            this.btnFechas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechas.FlatAppearance.BorderSize = 0;
            this.btnFechas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFechas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechas.Location = new System.Drawing.Point(116, 5);
            this.btnFechas.Name = "btnFechas";
            this.btnFechas.Size = new System.Drawing.Size(40, 40);
            this.btnFechas.TabIndex = 307;
            this.btnFechas.UseVisualStyleBackColor = false;
            this.btnFechas.Click += new System.EventHandler(this.btnFechas_Click);
            // 
            // seeProd
            // 
            this.seeProd.BackColor = System.Drawing.Color.Transparent;
            this.seeProd.BackgroundImage = global::Proyect_Kardex.Properties.Resources.seeCliente;
            this.seeProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seeProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seeProd.FlatAppearance.BorderSize = 0;
            this.seeProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.seeProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.seeProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeProd.Location = new System.Drawing.Point(42, 5);
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
            this.printview.Location = new System.Drawing.Point(300, 2);
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
            this.actualizar.Location = new System.Drawing.Point(188, 5);
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
            this.print.Location = new System.Drawing.Point(274, 5);
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
            this.save.Location = new System.Drawing.Point(366, 5);
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
            this.salir.Location = new System.Drawing.Point(452, 5);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(40, 40);
            this.salir.TabIndex = 251;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // txtTotalV
            // 
            this.txtTotalV.AutoSize = true;
            this.txtTotalV.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTotalV.Location = new System.Drawing.Point(370, 80);
            this.txtTotalV.Name = "txtTotalV";
            this.txtTotalV.Size = new System.Drawing.Size(81, 14);
            this.txtTotalV.TabIndex = 316;
            this.txtTotalV.Text = "120910  Bs.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 315;
            this.label3.Text = "Total en Ventas: ";
            // 
            // cantlabel
            // 
            this.cantlabel.AutoSize = true;
            this.cantlabel.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantlabel.ForeColor = System.Drawing.Color.Green;
            this.cantlabel.Location = new System.Drawing.Point(154, 80);
            this.cantlabel.Name = "cantlabel";
            this.cantlabel.Size = new System.Drawing.Size(91, 14);
            this.cantlabel.TabIndex = 314;
            this.cantlabel.Text = "120910  Und.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 313;
            this.label1.Text = "Información De Factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 12);
            this.label5.TabIndex = 312;
            this.label5.Text = "Cantidad Productos: ";
            // 
            // dataFactuVenta
            // 
            this.dataFactuVenta.AllowUserToAddRows = false;
            this.dataFactuVenta.AllowUserToDeleteRows = false;
            this.dataFactuVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataFactuVenta.AutoGenerateColumns = false;
            this.dataFactuVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataFactuVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFactuVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataFactuVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFactuVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numFacturaDataGridViewTextBoxColumn,
            this.numAutorizDataGridViewTextBoxColumn,
            this.nitFEmpDataGridViewTextBoxColumn,
            this.fechaVDataGridViewTextBoxColumn,
            this.nitciClienteDataGridViewTextBoxColumn,
            this.nomFCliDataGridViewTextBoxColumn,
            this.montoTotalFDataGridViewTextBoxColumn,
            this.detalleVenFDataGridViewTextBoxColumn,
            this.codControlDataGridViewTextBoxColumn,
            this.fLEmisionDataGridViewTextBoxColumn,
            this.codVenFDataGridViewTextBoxColumn});
            this.dataFactuVenta.DataSource = this.facturasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataFactuVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataFactuVenta.Location = new System.Drawing.Point(0, 98);
            this.dataFactuVenta.Name = "dataFactuVenta";
            this.dataFactuVenta.ReadOnly = true;
            this.dataFactuVenta.Size = new System.Drawing.Size(533, 324);
            this.dataFactuVenta.TabIndex = 311;
            this.dataFactuVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFactuVenta_CellClick);
            // 
            // numFacturaDataGridViewTextBoxColumn
            // 
            this.numFacturaDataGridViewTextBoxColumn.DataPropertyName = "numFactura";
            this.numFacturaDataGridViewTextBoxColumn.HeaderText = "Número de Factura";
            this.numFacturaDataGridViewTextBoxColumn.Name = "numFacturaDataGridViewTextBoxColumn";
            this.numFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numFacturaDataGridViewTextBoxColumn.Width = 150;
            // 
            // numAutorizDataGridViewTextBoxColumn
            // 
            this.numAutorizDataGridViewTextBoxColumn.DataPropertyName = "numAutoriz";
            this.numAutorizDataGridViewTextBoxColumn.HeaderText = "Número Autorización";
            this.numAutorizDataGridViewTextBoxColumn.Name = "numAutorizDataGridViewTextBoxColumn";
            this.numAutorizDataGridViewTextBoxColumn.ReadOnly = true;
            this.numAutorizDataGridViewTextBoxColumn.Width = 170;
            // 
            // nitFEmpDataGridViewTextBoxColumn
            // 
            this.nitFEmpDataGridViewTextBoxColumn.DataPropertyName = "nitFEmp";
            this.nitFEmpDataGridViewTextBoxColumn.HeaderText = "NIT Empresa";
            this.nitFEmpDataGridViewTextBoxColumn.Name = "nitFEmpDataGridViewTextBoxColumn";
            this.nitFEmpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaVDataGridViewTextBoxColumn
            // 
            this.fechaVDataGridViewTextBoxColumn.DataPropertyName = "fechaV";
            this.fechaVDataGridViewTextBoxColumn.HeaderText = "Fecha Venta";
            this.fechaVDataGridViewTextBoxColumn.Name = "fechaVDataGridViewTextBoxColumn";
            this.fechaVDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaVDataGridViewTextBoxColumn.Width = 120;
            // 
            // nitciClienteDataGridViewTextBoxColumn
            // 
            this.nitciClienteDataGridViewTextBoxColumn.DataPropertyName = "nitciCliente";
            this.nitciClienteDataGridViewTextBoxColumn.HeaderText = "NIT Cliente";
            this.nitciClienteDataGridViewTextBoxColumn.Name = "nitciClienteDataGridViewTextBoxColumn";
            this.nitciClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomFCliDataGridViewTextBoxColumn
            // 
            this.nomFCliDataGridViewTextBoxColumn.DataPropertyName = "nomFCli";
            this.nomFCliDataGridViewTextBoxColumn.HeaderText = "Nombre Cliente";
            this.nomFCliDataGridViewTextBoxColumn.Name = "nomFCliDataGridViewTextBoxColumn";
            this.nomFCliDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomFCliDataGridViewTextBoxColumn.Width = 130;
            // 
            // montoTotalFDataGridViewTextBoxColumn
            // 
            this.montoTotalFDataGridViewTextBoxColumn.DataPropertyName = "montoTotalF";
            this.montoTotalFDataGridViewTextBoxColumn.HeaderText = "Total";
            this.montoTotalFDataGridViewTextBoxColumn.Name = "montoTotalFDataGridViewTextBoxColumn";
            this.montoTotalFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalleVenFDataGridViewTextBoxColumn
            // 
            this.detalleVenFDataGridViewTextBoxColumn.DataPropertyName = "detalleVenF";
            this.detalleVenFDataGridViewTextBoxColumn.HeaderText = "Detalle Total";
            this.detalleVenFDataGridViewTextBoxColumn.Name = "detalleVenFDataGridViewTextBoxColumn";
            this.detalleVenFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codControlDataGridViewTextBoxColumn
            // 
            this.codControlDataGridViewTextBoxColumn.DataPropertyName = "codControl";
            this.codControlDataGridViewTextBoxColumn.HeaderText = "Codigo de Control";
            this.codControlDataGridViewTextBoxColumn.Name = "codControlDataGridViewTextBoxColumn";
            this.codControlDataGridViewTextBoxColumn.ReadOnly = true;
            this.codControlDataGridViewTextBoxColumn.Width = 140;
            // 
            // fLEmisionDataGridViewTextBoxColumn
            // 
            this.fLEmisionDataGridViewTextBoxColumn.DataPropertyName = "FLEmision";
            this.fLEmisionDataGridViewTextBoxColumn.HeaderText = "Fecha Limite Emisión";
            this.fLEmisionDataGridViewTextBoxColumn.Name = "fLEmisionDataGridViewTextBoxColumn";
            this.fLEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fLEmisionDataGridViewTextBoxColumn.Width = 170;
            // 
            // codVenFDataGridViewTextBoxColumn
            // 
            this.codVenFDataGridViewTextBoxColumn.DataPropertyName = "codVenF";
            this.codVenFDataGridViewTextBoxColumn.HeaderText = "Codigo de Venta";
            this.codVenFDataGridViewTextBoxColumn.Name = "codVenFDataGridViewTextBoxColumn";
            this.codVenFDataGridViewTextBoxColumn.ReadOnly = true;
            this.codVenFDataGridViewTextBoxColumn.Width = 130;
            // 
            // facturasBindingSource
            // 
            this.facturasBindingSource.DataMember = "Facturas";
            this.facturasBindingSource.DataSource = this.rEV_DataBaseDataSet;
            // 
            // rEV_DataBaseDataSet
            // 
            this.rEV_DataBaseDataSet.DataSetName = "REV_DataBaseDataSet";
            this.rEV_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturasTableAdapter
            // 
            this.facturasTableAdapter.ClearBeforeFill = true;
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
            // Report_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(533, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotalV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataFactuVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Report_Factura_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFactuVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button seeProd;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.Button actualizar;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button salir;
        public System.Windows.Forms.Label txtTotalV;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label cantlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataFactuVenta;
        private REV_DataBaseDataSet rEV_DataBaseDataSet;
        private System.Windows.Forms.BindingSource facturasBindingSource;
        private REV_DataBaseDataSetTableAdapters.FacturasTableAdapter facturasTableAdapter;
        private System.Windows.Forms.ToolTip toolTipF;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAutorizDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitFEmpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitciClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotalFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleVenFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codControlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVenFDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintDialog printMain;
        private System.Drawing.Printing.PrintDocument printDocx;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
        public System.Windows.Forms.Button btnFechas;

    }
}