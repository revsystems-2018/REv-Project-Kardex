namespace Proyect_Kardex
{
    partial class Report_Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Devolucion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cantlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataDevoVenta = new System.Windows.Forms.DataGridView();
            this.pIDdevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPdevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPdevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUPdevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fVdevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impTdevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDVdevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucionVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEV_DataBaseDataSet = new Proyect_Kardex.REV_DataBaseDataSet();
            this.devolucion_VentasTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.Devolucion_VentasTableAdapter();
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTipDev = new System.Windows.Forms.ToolTip(this.components);
            this.btnFechas = new System.Windows.Forms.Button();
            this.seeProd = new System.Windows.Forms.Button();
            this.printview = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDevoVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionVentasBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 317;
            // 
            // txtTotalV
            // 
            this.txtTotalV.AutoSize = true;
            this.txtTotalV.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTotalV.Location = new System.Drawing.Point(370, 80);
            this.txtTotalV.Name = "txtTotalV";
            this.txtTotalV.Size = new System.Drawing.Size(81, 14);
            this.txtTotalV.TabIndex = 323;
            this.txtTotalV.Text = "120910  Bs.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 322;
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
            this.cantlabel.TabIndex = 321;
            this.cantlabel.Text = "120910  Und.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 19);
            this.label1.TabIndex = 320;
            this.label1.Text = "Información En Devolución";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 12);
            this.label5.TabIndex = 319;
            this.label5.Text = "Cantidad Productos: ";
            // 
            // dataDevoVenta
            // 
            this.dataDevoVenta.AllowUserToAddRows = false;
            this.dataDevoVenta.AllowUserToDeleteRows = false;
            this.dataDevoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDevoVenta.AutoGenerateColumns = false;
            this.dataDevoVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataDevoVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDevoVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDevoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDevoVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDdevDataGridViewTextBoxColumn,
            this.nPdevDataGridViewTextBoxColumn,
            this.cPdevDataGridViewTextBoxColumn,
            this.pUPdevDataGridViewTextBoxColumn,
            this.fVdevDataGridViewTextBoxColumn,
            this.impTdevDataGridViewTextBoxColumn,
            this.iDVdevDataGridViewTextBoxColumn});
            this.dataDevoVenta.DataSource = this.devolucionVentasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDevoVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataDevoVenta.Location = new System.Drawing.Point(0, 98);
            this.dataDevoVenta.Name = "dataDevoVenta";
            this.dataDevoVenta.ReadOnly = true;
            this.dataDevoVenta.Size = new System.Drawing.Size(533, 324);
            this.dataDevoVenta.TabIndex = 318;
            this.dataDevoVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDevoVenta_CellClick);
            // 
            // pIDdevDataGridViewTextBoxColumn
            // 
            this.pIDdevDataGridViewTextBoxColumn.DataPropertyName = "PID_dev";
            this.pIDdevDataGridViewTextBoxColumn.HeaderText = "Codigo del Producto";
            this.pIDdevDataGridViewTextBoxColumn.Name = "pIDdevDataGridViewTextBoxColumn";
            this.pIDdevDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIDdevDataGridViewTextBoxColumn.Width = 180;
            // 
            // nPdevDataGridViewTextBoxColumn
            // 
            this.nPdevDataGridViewTextBoxColumn.DataPropertyName = "NP_dev";
            this.nPdevDataGridViewTextBoxColumn.HeaderText = "Nombre ";
            this.nPdevDataGridViewTextBoxColumn.Name = "nPdevDataGridViewTextBoxColumn";
            this.nPdevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPdevDataGridViewTextBoxColumn
            // 
            this.cPdevDataGridViewTextBoxColumn.DataPropertyName = "CP_dev";
            this.cPdevDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cPdevDataGridViewTextBoxColumn.Name = "cPdevDataGridViewTextBoxColumn";
            this.cPdevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pUPdevDataGridViewTextBoxColumn
            // 
            this.pUPdevDataGridViewTextBoxColumn.DataPropertyName = "PUP_dev";
            this.pUPdevDataGridViewTextBoxColumn.HeaderText = "Precio Unitario";
            this.pUPdevDataGridViewTextBoxColumn.Name = "pUPdevDataGridViewTextBoxColumn";
            this.pUPdevDataGridViewTextBoxColumn.ReadOnly = true;
            this.pUPdevDataGridViewTextBoxColumn.Width = 120;
            // 
            // fVdevDataGridViewTextBoxColumn
            // 
            this.fVdevDataGridViewTextBoxColumn.DataPropertyName = "FV_dev";
            this.fVdevDataGridViewTextBoxColumn.HeaderText = "Fecha Registro";
            this.fVdevDataGridViewTextBoxColumn.Name = "fVdevDataGridViewTextBoxColumn";
            this.fVdevDataGridViewTextBoxColumn.ReadOnly = true;
            this.fVdevDataGridViewTextBoxColumn.Width = 120;
            // 
            // impTdevDataGridViewTextBoxColumn
            // 
            this.impTdevDataGridViewTextBoxColumn.DataPropertyName = "ImpT_dev";
            this.impTdevDataGridViewTextBoxColumn.HeaderText = "Total";
            this.impTdevDataGridViewTextBoxColumn.Name = "impTdevDataGridViewTextBoxColumn";
            this.impTdevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDVdevDataGridViewTextBoxColumn
            // 
            this.iDVdevDataGridViewTextBoxColumn.DataPropertyName = "IDV_dev";
            this.iDVdevDataGridViewTextBoxColumn.HeaderText = "ID Venta";
            this.iDVdevDataGridViewTextBoxColumn.Name = "iDVdevDataGridViewTextBoxColumn";
            this.iDVdevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devolucionVentasBindingSource
            // 
            this.devolucionVentasBindingSource.DataMember = "Devolucion_Ventas";
            this.devolucionVentasBindingSource.DataSource = this.rEV_DataBaseDataSet;
            // 
            // rEV_DataBaseDataSet
            // 
            this.rEV_DataBaseDataSet.DataSetName = "REV_DataBaseDataSet";
            this.rEV_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devolucion_VentasTableAdapter
            // 
            this.devolucion_VentasTableAdapter.ClearBeforeFill = true;
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
            // btnFechas
            // 
            this.btnFechas.BackColor = System.Drawing.Color.Transparent;
            this.btnFechas.BackgroundImage = global::Proyect_Kardex.Properties.Resources.fechaventa;
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
            this.seeProd.BackgroundImage = global::Proyect_Kardex.Properties.Resources.VerProduct;
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
            // Report_Devolucion
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
            this.Controls.Add(this.dataDevoVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report_Devolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.Report_Devolucion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDevoVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnFechas;
        public System.Windows.Forms.Button seeProd;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.Button actualizar;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button salir;
        public System.Windows.Forms.Label txtTotalV;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label cantlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataDevoVenta;
        private REV_DataBaseDataSet rEV_DataBaseDataSet;
        private System.Windows.Forms.BindingSource devolucionVentasBindingSource;
        private REV_DataBaseDataSetTableAdapters.Devolucion_VentasTableAdapter devolucion_VentasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDdevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPdevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPdevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUPdevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fVdevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impTdevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVdevDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintDialog printMain;
        private System.Drawing.Printing.PrintDocument printDocx;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
        private System.Windows.Forms.ToolTip toolTipDev;
    }
}