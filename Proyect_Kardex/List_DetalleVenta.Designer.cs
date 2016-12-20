namespace Proyect_Kardex
{
    partial class List_DetalleVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_DetalleVenta));
            this.txtTotalV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cantlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataDetVenta = new System.Windows.Forms.DataGridView();
            this.idprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicasellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importesellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEV_DataBaseDataSet = new Proyect_Kardex.REV_DataBaseDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlistV = new System.Windows.Forms.Button();
            this.seeProd = new System.Windows.Forms.Button();
            this.printview = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.detalle_VentaTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.Detalle_VentaTableAdapter();
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTipDet = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataDetVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotalV
            // 
            this.txtTotalV.AutoSize = true;
            this.txtTotalV.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTotalV.Location = new System.Drawing.Point(372, 80);
            this.txtTotalV.Name = "txtTotalV";
            this.txtTotalV.Size = new System.Drawing.Size(81, 14);
            this.txtTotalV.TabIndex = 316;
            this.txtTotalV.Text = "120910  Bs.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 81);
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
            this.cantlabel.Location = new System.Drawing.Point(156, 80);
            this.cantlabel.Name = "cantlabel";
            this.cantlabel.Size = new System.Drawing.Size(91, 14);
            this.cantlabel.TabIndex = 314;
            this.cantlabel.Text = "120910  Und.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 313;
            this.label1.Text = "Información De Venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 12);
            this.label5.TabIndex = 312;
            this.label5.Text = "Cantidad Productos: ";
            // 
            // dataDetVenta
            // 
            this.dataDetVenta.AllowUserToAddRows = false;
            this.dataDetVenta.AllowUserToDeleteRows = false;
            this.dataDetVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDetVenta.AutoGenerateColumns = false;
            this.dataDetVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataDetVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataDetVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDetVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodDataGridViewTextBoxColumn,
            this.nameprodDataGridViewTextBoxColumn,
            this.cantprodDataGridViewTextBoxColumn,
            this.precioprodDataGridViewTextBoxColumn,
            this.fechaventaDataGridViewTextBoxColumn,
            this.ubicasellDataGridViewTextBoxColumn,
            this.importesellDataGridViewTextBoxColumn,
            this.codVentaDataGridViewTextBoxColumn});
            this.dataDetVenta.DataSource = this.detalleVentaBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDetVenta.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataDetVenta.Location = new System.Drawing.Point(0, 98);
            this.dataDetVenta.Name = "dataDetVenta";
            this.dataDetVenta.ReadOnly = true;
            this.dataDetVenta.Size = new System.Drawing.Size(487, 382);
            this.dataDetVenta.TabIndex = 311;
            this.dataDetVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDetVenta_CellClick);
            // 
            // idprodDataGridViewTextBoxColumn
            // 
            this.idprodDataGridViewTextBoxColumn.DataPropertyName = "id_prod";
            this.idprodDataGridViewTextBoxColumn.HeaderText = "Codigo del Producto";
            this.idprodDataGridViewTextBoxColumn.Name = "idprodDataGridViewTextBoxColumn";
            this.idprodDataGridViewTextBoxColumn.ReadOnly = true;
            this.idprodDataGridViewTextBoxColumn.Width = 180;
            // 
            // nameprodDataGridViewTextBoxColumn
            // 
            this.nameprodDataGridViewTextBoxColumn.DataPropertyName = "name_prod";
            this.nameprodDataGridViewTextBoxColumn.HeaderText = "Nombre del Producto";
            this.nameprodDataGridViewTextBoxColumn.Name = "nameprodDataGridViewTextBoxColumn";
            this.nameprodDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameprodDataGridViewTextBoxColumn.Width = 180;
            // 
            // cantprodDataGridViewTextBoxColumn
            // 
            this.cantprodDataGridViewTextBoxColumn.DataPropertyName = "cant_prod";
            this.cantprodDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantprodDataGridViewTextBoxColumn.Name = "cantprodDataGridViewTextBoxColumn";
            this.cantprodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioprodDataGridViewTextBoxColumn
            // 
            this.precioprodDataGridViewTextBoxColumn.DataPropertyName = "precio_prod";
            this.precioprodDataGridViewTextBoxColumn.HeaderText = "Precio Unitario";
            this.precioprodDataGridViewTextBoxColumn.Name = "precioprodDataGridViewTextBoxColumn";
            this.precioprodDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioprodDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaventaDataGridViewTextBoxColumn
            // 
            this.fechaventaDataGridViewTextBoxColumn.DataPropertyName = "fecha_venta";
            this.fechaventaDataGridViewTextBoxColumn.HeaderText = "Fecha de Venta";
            this.fechaventaDataGridViewTextBoxColumn.Name = "fechaventaDataGridViewTextBoxColumn";
            this.fechaventaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaventaDataGridViewTextBoxColumn.Width = 150;
            // 
            // ubicasellDataGridViewTextBoxColumn
            // 
            this.ubicasellDataGridViewTextBoxColumn.DataPropertyName = "ubica_sell";
            this.ubicasellDataGridViewTextBoxColumn.HeaderText = "Ubicación";
            this.ubicasellDataGridViewTextBoxColumn.Name = "ubicasellDataGridViewTextBoxColumn";
            this.ubicasellDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importesellDataGridViewTextBoxColumn
            // 
            this.importesellDataGridViewTextBoxColumn.DataPropertyName = "importe_sell";
            this.importesellDataGridViewTextBoxColumn.HeaderText = "Total Venta";
            this.importesellDataGridViewTextBoxColumn.Name = "importesellDataGridViewTextBoxColumn";
            this.importesellDataGridViewTextBoxColumn.ReadOnly = true;
            this.importesellDataGridViewTextBoxColumn.Width = 120;
            // 
            // codVentaDataGridViewTextBoxColumn
            // 
            this.codVentaDataGridViewTextBoxColumn.DataPropertyName = "cod_Venta";
            this.codVentaDataGridViewTextBoxColumn.HeaderText = "Codigo de Venta";
            this.codVentaDataGridViewTextBoxColumn.Name = "codVentaDataGridViewTextBoxColumn";
            this.codVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codVentaDataGridViewTextBoxColumn.Width = 170;
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataMember = "Detalle_Venta";
            this.detalleVentaBindingSource.DataSource = this.rEV_DataBaseDataSet;
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
            this.panel1.Controls.Add(this.btnlistV);
            this.panel1.Controls.Add(this.seeProd);
            this.panel1.Controls.Add(this.printview);
            this.panel1.Controls.Add(this.actualizar);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 51);
            this.panel1.TabIndex = 310;
            // 
            // btnlistV
            // 
            this.btnlistV.BackColor = System.Drawing.Color.Transparent;
            this.btnlistV.BackgroundImage = global::Proyect_Kardex.Properties.Resources.listVentas;
            this.btnlistV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlistV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlistV.FlatAppearance.BorderSize = 0;
            this.btnlistV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlistV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnlistV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlistV.Location = new System.Drawing.Point(95, 5);
            this.btnlistV.Name = "btnlistV";
            this.btnlistV.Size = new System.Drawing.Size(40, 40);
            this.btnlistV.TabIndex = 307;
            this.btnlistV.UseVisualStyleBackColor = false;
            this.btnlistV.Click += new System.EventHandler(this.button1_Click);
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
            this.seeProd.Location = new System.Drawing.Point(22, 5);
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
            this.printview.Location = new System.Drawing.Point(284, 2);
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
            this.actualizar.Location = new System.Drawing.Point(172, 5);
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
            this.print.Location = new System.Drawing.Point(258, 5);
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
            this.save.Location = new System.Drawing.Point(350, 5);
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
            this.salir.Location = new System.Drawing.Point(436, 5);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(40, 40);
            this.salir.TabIndex = 251;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // detalle_VentaTableAdapter
            // 
            this.detalle_VentaTableAdapter.ClearBeforeFill = true;
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
            this.printPreview.Visible = false;
            // 
            // List_DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(487, 479);
            this.Controls.Add(this.txtTotalV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataDetVenta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "List_DetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.List_DetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDetVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label txtTotalV;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label cantlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataDetVenta;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button seeProd;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.Button actualizar;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button salir;
        public System.Windows.Forms.Button btnlistV;
        private REV_DataBaseDataSet rEV_DataBaseDataSet;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private REV_DataBaseDataSetTableAdapters.Detalle_VentaTableAdapter detalle_VentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicasellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importesellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
        public System.Drawing.Printing.PrintDocument printDocx;
        public System.Windows.Forms.PrintDialog printMain;
        private System.Windows.Forms.ToolTip toolTipDet;
    }
}