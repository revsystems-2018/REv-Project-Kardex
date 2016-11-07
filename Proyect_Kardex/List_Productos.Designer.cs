namespace Proyect_Kardex
{
    partial class List_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_Productos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonselect = new System.Windows.Forms.Button();
            this.seeProd = new System.Windows.Forms.Button();
            this.printview = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.regprodtable = new System.Windows.Forms.DataGridView();
            this.codBarPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgProdDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imgCodDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.cCUProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVUProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcivaProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMinProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaxProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEV_DataBaseDataSet = new Proyect_Kardex.REV_DataBaseDataSet();
            this.productosTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.ProductosTableAdapter();
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.toolRegProd = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regprodtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 300;
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
            this.seeProd.BackgroundImage = global::Proyect_Kardex.Properties.Resources.VerProduct;
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
            this.codBarPDataGridViewTextBoxColumn,
            this.nomProdDataGridViewTextBoxColumn,
            this.descProdDataGridViewTextBoxColumn,
            this.pesoProdDataGridViewTextBoxColumn,
            this.volProdDataGridViewTextBoxColumn,
            this.estadoProdDataGridViewTextBoxColumn,
            this.fnProdDataGridViewTextBoxColumn,
            this.fcProdDataGridViewTextBoxColumn,
            this.imgProdDataGridViewImageColumn,
            this.imgCodDataGridViewImageColumn,
            this.cCUProdDataGridViewTextBoxColumn,
            this.pVUProdDataGridViewTextBoxColumn,
            this.rcivaProdDataGridViewTextBoxColumn,
            this.cantProdDataGridViewTextBoxColumn,
            this.sMinProdDataGridViewTextBoxColumn,
            this.sMaxProdDataGridViewTextBoxColumn,
            this.cateCodDataGridViewTextBoxColumn,
            this.markCodDataGridViewTextBoxColumn,
            this.medCodDataGridViewTextBoxColumn,
            this.subCodDataGridViewTextBoxColumn,
            this.idProveDataGridViewTextBoxColumn});
            this.regprodtable.DataSource = this.productosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.regprodtable.DefaultCellStyle = dataGridViewCellStyle2;
            this.regprodtable.Location = new System.Drawing.Point(0, 51);
            this.regprodtable.Name = "regprodtable";
            this.regprodtable.ReadOnly = true;
            this.regprodtable.Size = new System.Drawing.Size(536, 454);
            this.regprodtable.TabIndex = 301;
            this.regprodtable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.regprodtable_CellClick);
            // 
            // codBarPDataGridViewTextBoxColumn
            // 
            this.codBarPDataGridViewTextBoxColumn.DataPropertyName = "CodBarP";
            this.codBarPDataGridViewTextBoxColumn.HeaderText = "Codigo Registro";
            this.codBarPDataGridViewTextBoxColumn.Name = "codBarPDataGridViewTextBoxColumn";
            this.codBarPDataGridViewTextBoxColumn.ReadOnly = true;
            this.codBarPDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomProdDataGridViewTextBoxColumn
            // 
            this.nomProdDataGridViewTextBoxColumn.DataPropertyName = "nomProd";
            this.nomProdDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomProdDataGridViewTextBoxColumn.Name = "nomProdDataGridViewTextBoxColumn";
            this.nomProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descProdDataGridViewTextBoxColumn
            // 
            this.descProdDataGridViewTextBoxColumn.DataPropertyName = "DescProd";
            this.descProdDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descProdDataGridViewTextBoxColumn.Name = "descProdDataGridViewTextBoxColumn";
            this.descProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.descProdDataGridViewTextBoxColumn.Width = 180;
            // 
            // pesoProdDataGridViewTextBoxColumn
            // 
            this.pesoProdDataGridViewTextBoxColumn.DataPropertyName = "PesoProd";
            this.pesoProdDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoProdDataGridViewTextBoxColumn.Name = "pesoProdDataGridViewTextBoxColumn";
            this.pesoProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volProdDataGridViewTextBoxColumn
            // 
            this.volProdDataGridViewTextBoxColumn.DataPropertyName = "VolProd";
            this.volProdDataGridViewTextBoxColumn.HeaderText = "Volumen";
            this.volProdDataGridViewTextBoxColumn.Name = "volProdDataGridViewTextBoxColumn";
            this.volProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoProdDataGridViewTextBoxColumn
            // 
            this.estadoProdDataGridViewTextBoxColumn.DataPropertyName = "EstadoProd";
            this.estadoProdDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoProdDataGridViewTextBoxColumn.Name = "estadoProdDataGridViewTextBoxColumn";
            this.estadoProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnProdDataGridViewTextBoxColumn
            // 
            this.fnProdDataGridViewTextBoxColumn.DataPropertyName = "fnProd";
            this.fnProdDataGridViewTextBoxColumn.HeaderText = "Fecha Vencimiento";
            this.fnProdDataGridViewTextBoxColumn.Name = "fnProdDataGridViewTextBoxColumn";
            this.fnProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.fnProdDataGridViewTextBoxColumn.Width = 190;
            // 
            // fcProdDataGridViewTextBoxColumn
            // 
            this.fcProdDataGridViewTextBoxColumn.DataPropertyName = "fcProd";
            this.fcProdDataGridViewTextBoxColumn.HeaderText = "Fecha Creación";
            this.fcProdDataGridViewTextBoxColumn.Name = "fcProdDataGridViewTextBoxColumn";
            this.fcProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.fcProdDataGridViewTextBoxColumn.Width = 130;
            // 
            // imgProdDataGridViewImageColumn
            // 
            this.imgProdDataGridViewImageColumn.DataPropertyName = "imgProd";
            this.imgProdDataGridViewImageColumn.HeaderText = "Fotografia";
            this.imgProdDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imgProdDataGridViewImageColumn.Name = "imgProdDataGridViewImageColumn";
            this.imgProdDataGridViewImageColumn.ReadOnly = true;
            // 
            // imgCodDataGridViewImageColumn
            // 
            this.imgCodDataGridViewImageColumn.DataPropertyName = "imgCod";
            this.imgCodDataGridViewImageColumn.HeaderText = "Imagen Codigo";
            this.imgCodDataGridViewImageColumn.Name = "imgCodDataGridViewImageColumn";
            this.imgCodDataGridViewImageColumn.ReadOnly = true;
            this.imgCodDataGridViewImageColumn.Visible = false;
            this.imgCodDataGridViewImageColumn.Width = 130;
            // 
            // cCUProdDataGridViewTextBoxColumn
            // 
            this.cCUProdDataGridViewTextBoxColumn.DataPropertyName = "CCUProd";
            this.cCUProdDataGridViewTextBoxColumn.HeaderText = "Costo Unitario";
            this.cCUProdDataGridViewTextBoxColumn.Name = "cCUProdDataGridViewTextBoxColumn";
            this.cCUProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cCUProdDataGridViewTextBoxColumn.Width = 130;
            // 
            // pVUProdDataGridViewTextBoxColumn
            // 
            this.pVUProdDataGridViewTextBoxColumn.DataPropertyName = "PVUProd";
            this.pVUProdDataGridViewTextBoxColumn.HeaderText = "Precio Unitario";
            this.pVUProdDataGridViewTextBoxColumn.Name = "pVUProdDataGridViewTextBoxColumn";
            this.pVUProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pVUProdDataGridViewTextBoxColumn.Width = 130;
            // 
            // rcivaProdDataGridViewTextBoxColumn
            // 
            this.rcivaProdDataGridViewTextBoxColumn.DataPropertyName = "rcivaProd";
            this.rcivaProdDataGridViewTextBoxColumn.HeaderText = "RC_IVA";
            this.rcivaProdDataGridViewTextBoxColumn.Name = "rcivaProdDataGridViewTextBoxColumn";
            this.rcivaProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantProdDataGridViewTextBoxColumn
            // 
            this.cantProdDataGridViewTextBoxColumn.DataPropertyName = "CantProd";
            this.cantProdDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantProdDataGridViewTextBoxColumn.Name = "cantProdDataGridViewTextBoxColumn";
            this.cantProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sMinProdDataGridViewTextBoxColumn
            // 
            this.sMinProdDataGridViewTextBoxColumn.DataPropertyName = "SMinProd";
            this.sMinProdDataGridViewTextBoxColumn.HeaderText = "Stock Mínimo";
            this.sMinProdDataGridViewTextBoxColumn.Name = "sMinProdDataGridViewTextBoxColumn";
            this.sMinProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sMinProdDataGridViewTextBoxColumn.Width = 140;
            // 
            // sMaxProdDataGridViewTextBoxColumn
            // 
            this.sMaxProdDataGridViewTextBoxColumn.DataPropertyName = "SMaxProd";
            this.sMaxProdDataGridViewTextBoxColumn.HeaderText = "Stock Máximo";
            this.sMaxProdDataGridViewTextBoxColumn.Name = "sMaxProdDataGridViewTextBoxColumn";
            this.sMaxProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sMaxProdDataGridViewTextBoxColumn.Width = 140;
            // 
            // cateCodDataGridViewTextBoxColumn
            // 
            this.cateCodDataGridViewTextBoxColumn.DataPropertyName = "cateCod";
            this.cateCodDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.cateCodDataGridViewTextBoxColumn.Name = "cateCodDataGridViewTextBoxColumn";
            this.cateCodDataGridViewTextBoxColumn.ReadOnly = true;
            this.cateCodDataGridViewTextBoxColumn.Visible = false;
            // 
            // markCodDataGridViewTextBoxColumn
            // 
            this.markCodDataGridViewTextBoxColumn.DataPropertyName = "markCod";
            this.markCodDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.markCodDataGridViewTextBoxColumn.Name = "markCodDataGridViewTextBoxColumn";
            this.markCodDataGridViewTextBoxColumn.ReadOnly = true;
            this.markCodDataGridViewTextBoxColumn.Visible = false;
            // 
            // medCodDataGridViewTextBoxColumn
            // 
            this.medCodDataGridViewTextBoxColumn.DataPropertyName = "medCod";
            this.medCodDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.medCodDataGridViewTextBoxColumn.Name = "medCodDataGridViewTextBoxColumn";
            this.medCodDataGridViewTextBoxColumn.ReadOnly = true;
            this.medCodDataGridViewTextBoxColumn.Visible = false;
            // 
            // subCodDataGridViewTextBoxColumn
            // 
            this.subCodDataGridViewTextBoxColumn.DataPropertyName = "subCod";
            this.subCodDataGridViewTextBoxColumn.HeaderText = "SubCategoria";
            this.subCodDataGridViewTextBoxColumn.Name = "subCodDataGridViewTextBoxColumn";
            this.subCodDataGridViewTextBoxColumn.ReadOnly = true;
            this.subCodDataGridViewTextBoxColumn.Visible = false;
            this.subCodDataGridViewTextBoxColumn.Width = 130;
            // 
            // idProveDataGridViewTextBoxColumn
            // 
            this.idProveDataGridViewTextBoxColumn.DataPropertyName = "idProve";
            this.idProveDataGridViewTextBoxColumn.HeaderText = "id Proveedor";
            this.idProveDataGridViewTextBoxColumn.Name = "idProveDataGridViewTextBoxColumn";
            this.idProveDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProveDataGridViewTextBoxColumn.Visible = false;
            this.idProveDataGridViewTextBoxColumn.Width = 130;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.rEV_DataBaseDataSet;
            // 
            // rEV_DataBaseDataSet
            // 
            this.rEV_DataBaseDataSet.DataSetName = "REV_DataBaseDataSet";
            this.rEV_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
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
            // List_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(536, 504);
            this.Controls.Add(this.regprodtable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "List_Productos";
            this.Text = "Registro de Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.List_Productos_FormClosing);
            this.Load += new System.EventHandler(this.List_Productos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.regprodtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button seeProd;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.Button actualizar;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button salir;
        public System.Windows.Forms.Button botonselect;
        public System.Windows.Forms.DataGridView regprodtable;
        private REV_DataBaseDataSet rEV_DataBaseDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private REV_DataBaseDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBarPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgProdDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgCodDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCUProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pVUProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcivaProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMinProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaxProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveDataGridViewTextBoxColumn;
        public System.Windows.Forms.PrintDialog printMain;
        public System.Drawing.Printing.PrintDocument printDocx;
        public System.Windows.Forms.PrintPreviewDialog printPreview;
        public System.Windows.Forms.ToolTip toolRegProd;
    }
}