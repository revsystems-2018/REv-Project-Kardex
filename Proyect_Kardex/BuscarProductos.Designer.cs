namespace Proyect_Kardex
{
    partial class BuscarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarProductos));
            this.searchprod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarprod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listproduct = new System.Windows.Forms.DataGridView();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ubicacionprod = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.categoriaprod = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.codprod = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nameprod = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imagenprod = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.productosTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.ProductosTableAdapter();
            this.btnCode = new System.Windows.Forms.Button();
            this.btnDet = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenprod)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchprod
            // 
            this.searchprod.BackColor = System.Drawing.SystemColors.Menu;
            this.searchprod.BackgroundImage = global::Proyect_Kardex.Properties.Resources.lupa;
            this.searchprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchprod.FlatAppearance.BorderSize = 0;
            this.searchprod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.searchprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.searchprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchprod.Location = new System.Drawing.Point(654, 30);
            this.searchprod.Name = "searchprod";
            this.searchprod.Size = new System.Drawing.Size(19, 18);
            this.searchprod.TabIndex = 213;
            this.searchprod.UseVisualStyleBackColor = false;
            this.searchprod.Click += new System.EventHandler(this.searchci_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 19);
            this.label1.TabIndex = 212;
            this.label1.Text = "Confirmación De Búsqueda ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buscarprod
            // 
            this.buscarprod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarprod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buscarprod.Location = new System.Drawing.Point(209, 29);
            this.buscarprod.Name = "buscarprod";
            this.buscarprod.Size = new System.Drawing.Size(465, 20);
            this.buscarprod.TabIndex = 211;
            this.buscarprod.Text = "Escribir Codigo de Barras del Producto (Nombre; Descripción)";
            this.buscarprod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BusquedaProdClick);
            this.buscarprod.TextChanged += new System.EventHandler(this.buscarprod_TextChanged);
            this.buscarprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscarprod_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 12);
            this.label5.TabIndex = 210;
            this.label5.Text = "Codigo de Barras del Producto";
            // 
            // listproduct
            // 
            this.listproduct.AllowUserToAddRows = false;
            this.listproduct.AllowUserToDeleteRows = false;
            this.listproduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listproduct.AutoGenerateColumns = false;
            this.listproduct.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.listproduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listproduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listproduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.listproduct.DataSource = this.productosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listproduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.listproduct.Location = new System.Drawing.Point(1, 55);
            this.listproduct.Name = "listproduct";
            this.listproduct.ReadOnly = true;
            this.listproduct.Size = new System.Drawing.Size(555, 417);
            this.listproduct.TabIndex = 214;
            this.listproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listproduct_CellClick);
            // 
            // codBarPDataGridViewTextBoxColumn
            // 
            this.codBarPDataGridViewTextBoxColumn.DataPropertyName = "CodBarP";
            this.codBarPDataGridViewTextBoxColumn.HeaderText = "Codigo de Registro";
            this.codBarPDataGridViewTextBoxColumn.Name = "codBarPDataGridViewTextBoxColumn";
            this.codBarPDataGridViewTextBoxColumn.ReadOnly = true;
            this.codBarPDataGridViewTextBoxColumn.Width = 170;
            // 
            // nomProdDataGridViewTextBoxColumn
            // 
            this.nomProdDataGridViewTextBoxColumn.DataPropertyName = "nomProd";
            this.nomProdDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomProdDataGridViewTextBoxColumn.Name = "nomProdDataGridViewTextBoxColumn";
            this.nomProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomProdDataGridViewTextBoxColumn.Width = 150;
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
            this.fnProdDataGridViewTextBoxColumn.HeaderText = "Fecha de Vencimiento";
            this.fnProdDataGridViewTextBoxColumn.Name = "fnProdDataGridViewTextBoxColumn";
            this.fnProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.fnProdDataGridViewTextBoxColumn.Width = 200;
            // 
            // fcProdDataGridViewTextBoxColumn
            // 
            this.fcProdDataGridViewTextBoxColumn.DataPropertyName = "fcProd";
            this.fcProdDataGridViewTextBoxColumn.HeaderText = "Fecha Creación";
            this.fcProdDataGridViewTextBoxColumn.Name = "fcProdDataGridViewTextBoxColumn";
            this.fcProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.fcProdDataGridViewTextBoxColumn.Width = 150;
            // 
            // imgProdDataGridViewImageColumn
            // 
            this.imgProdDataGridViewImageColumn.DataPropertyName = "imgProd";
            this.imgProdDataGridViewImageColumn.HeaderText = "Imagen";
            this.imgProdDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imgProdDataGridViewImageColumn.Name = "imgProdDataGridViewImageColumn";
            this.imgProdDataGridViewImageColumn.ReadOnly = true;
            // 
            // imgCodDataGridViewImageColumn
            // 
            this.imgCodDataGridViewImageColumn.DataPropertyName = "imgCod";
            this.imgCodDataGridViewImageColumn.HeaderText = "Imagen Codigo";
            this.imgCodDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imgCodDataGridViewImageColumn.Name = "imgCodDataGridViewImageColumn";
            this.imgCodDataGridViewImageColumn.ReadOnly = true;
            this.imgCodDataGridViewImageColumn.Visible = false;
            // 
            // cCUProdDataGridViewTextBoxColumn
            // 
            this.cCUProdDataGridViewTextBoxColumn.DataPropertyName = "CCUProd";
            this.cCUProdDataGridViewTextBoxColumn.HeaderText = "Costo Compra";
            this.cCUProdDataGridViewTextBoxColumn.Name = "cCUProdDataGridViewTextBoxColumn";
            this.cCUProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cCUProdDataGridViewTextBoxColumn.Width = 150;
            // 
            // pVUProdDataGridViewTextBoxColumn
            // 
            this.pVUProdDataGridViewTextBoxColumn.DataPropertyName = "PVUProd";
            this.pVUProdDataGridViewTextBoxColumn.HeaderText = "Precio Venta";
            this.pVUProdDataGridViewTextBoxColumn.Name = "pVUProdDataGridViewTextBoxColumn";
            this.pVUProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pVUProdDataGridViewTextBoxColumn.Width = 130;
            // 
            // rcivaProdDataGridViewTextBoxColumn
            // 
            this.rcivaProdDataGridViewTextBoxColumn.DataPropertyName = "rcivaProd";
            this.rcivaProdDataGridViewTextBoxColumn.HeaderText = "RC-IVA";
            this.rcivaProdDataGridViewTextBoxColumn.Name = "rcivaProdDataGridViewTextBoxColumn";
            this.rcivaProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.rcivaProdDataGridViewTextBoxColumn.Visible = false;
            // 
            // cantProdDataGridViewTextBoxColumn
            // 
            this.cantProdDataGridViewTextBoxColumn.DataPropertyName = "CantProd";
            this.cantProdDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantProdDataGridViewTextBoxColumn.Name = "cantProdDataGridViewTextBoxColumn";
            this.cantProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantProdDataGridViewTextBoxColumn.Width = 120;
            // 
            // sMinProdDataGridViewTextBoxColumn
            // 
            this.sMinProdDataGridViewTextBoxColumn.DataPropertyName = "SMinProd";
            this.sMinProdDataGridViewTextBoxColumn.HeaderText = "Stock Mínimo";
            this.sMinProdDataGridViewTextBoxColumn.Name = "sMinProdDataGridViewTextBoxColumn";
            this.sMinProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sMinProdDataGridViewTextBoxColumn.Width = 150;
            // 
            // sMaxProdDataGridViewTextBoxColumn
            // 
            this.sMaxProdDataGridViewTextBoxColumn.DataPropertyName = "SMaxProd";
            this.sMaxProdDataGridViewTextBoxColumn.HeaderText = "Stock Máximo";
            this.sMaxProdDataGridViewTextBoxColumn.Name = "sMaxProdDataGridViewTextBoxColumn";
            this.sMaxProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sMaxProdDataGridViewTextBoxColumn.Width = 150;
            // 
            // cateCodDataGridViewTextBoxColumn
            // 
            this.cateCodDataGridViewTextBoxColumn.DataPropertyName = "cateCod";
            this.cateCodDataGridViewTextBoxColumn.HeaderText = "Categoría";
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
            // 
            // idProveDataGridViewTextBoxColumn
            // 
            this.idProveDataGridViewTextBoxColumn.DataPropertyName = "idProve";
            this.idProveDataGridViewTextBoxColumn.HeaderText = "Codigo Proveedor";
            this.idProveDataGridViewTextBoxColumn.Name = "idProveDataGridViewTextBoxColumn";
            this.idProveDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProveDataGridViewTextBoxColumn.Width = 170;
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.ubicacionprod);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.categoriaprod);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.codprod);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nameprod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.imagenprod);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(558, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 417);
            this.groupBox1.TabIndex = 215;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ubicacionprod
            // 
            this.ubicacionprod.AutoSize = true;
            this.ubicacionprod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubicacionprod.Location = new System.Drawing.Point(28, 392);
            this.ubicacionprod.Name = "ubicacionprod";
            this.ubicacionprod.Size = new System.Drawing.Size(118, 12);
            this.ubicacionprod.TabIndex = 10;
            this.ubicacionprod.Text = "Comestibles Nro 112";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 374);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "Ubicación en Tienda";
            // 
            // categoriaprod
            // 
            this.categoriaprod.AutoSize = true;
            this.categoriaprod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaprod.Location = new System.Drawing.Point(28, 352);
            this.categoriaprod.Name = "categoriaprod";
            this.categoriaprod.Size = new System.Drawing.Size(112, 12);
            this.categoriaprod.TabIndex = 8;
            this.categoriaprod.Text = "Bebidas Y Refrescos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "Categoría";
            // 
            // codprod
            // 
            this.codprod.AutoSize = true;
            this.codprod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codprod.Location = new System.Drawing.Point(28, 312);
            this.codprod.Name = "codprod";
            this.codprod.Size = new System.Drawing.Size(110, 12);
            this.codprod.TabIndex = 6;
            this.codprod.Text = "123456789987654";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "Codigo de Barra del Producto";
            // 
            // nameprod
            // 
            this.nameprod.AutoSize = true;
            this.nameprod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameprod.Location = new System.Drawing.Point(28, 272);
            this.nameprod.Name = "nameprod";
            this.nameprod.Size = new System.Drawing.Size(88, 12);
            this.nameprod.TabIndex = 4;
            this.nameprod.Text = "Coca Cola 2.5 L";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre del Producto";
            // 
            // imagenprod
            // 
            this.imagenprod.Location = new System.Drawing.Point(30, 101);
            this.imagenprod.Name = "imagenprod";
            this.imagenprod.Size = new System.Drawing.Size(177, 149);
            this.imagenprod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenprod.TabIndex = 2;
            this.imagenprod.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.stock);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(115, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 76);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "Unidades";
            // 
            // stock
            // 
            this.stock.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.stock.Location = new System.Drawing.Point(6, 31);
            this.stock.Name = "stock";
            this.stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stock.Size = new System.Drawing.Size(88, 20);
            this.stock.TabIndex = 1;
            this.stock.Text = "0";
            this.stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stock";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.precio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 76);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bs";
            // 
            // precio
            // 
            this.precio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.precio.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.ForeColor = System.Drawing.Color.Green;
            this.precio.Location = new System.Drawing.Point(6, 31);
            this.precio.Name = "precio";
            this.precio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.precio.Size = new System.Drawing.Size(88, 20);
            this.precio.TabIndex = 1;
            this.precio.Text = "0.0";
            this.precio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Precio";
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // btnCode
            // 
            this.btnCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCode.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarCode_B;
            this.btnCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCode.FlatAppearance.BorderSize = 0;
            this.btnCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCode.Location = new System.Drawing.Point(749, 25);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(25, 25);
            this.btnCode.TabIndex = 218;
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // btnDet
            // 
            this.btnDet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDet.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarDetalle_B;
            this.btnDet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDet.FlatAppearance.BorderSize = 0;
            this.btnDet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDet.Location = new System.Drawing.Point(718, 24);
            this.btnDet.Name = "btnDet";
            this.btnDet.Size = new System.Drawing.Size(25, 25);
            this.btnDet.TabIndex = 217;
            this.btnDet.UseVisualStyleBackColor = true;
            this.btnDet.Click += new System.EventHandler(this.btnDet_Click);
            // 
            // btnName
            // 
            this.btnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnName.BackgroundImage = global::Proyect_Kardex.Properties.Resources.BuscarName;
            this.btnName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnName.FlatAppearance.BorderSize = 0;
            this.btnName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnName.Location = new System.Drawing.Point(687, 24);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(25, 25);
            this.btnName.TabIndex = 216;
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // BuscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(780, 473);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.btnDet);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listproduct);
            this.Controls.Add(this.searchprod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarprod);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Productos";
            this.Load += new System.EventHandler(this.BuscarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenprod)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button searchprod;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox buscarprod;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView listproduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox imagenprod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label stock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label precio;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label ubicacionprod;
        public System.Windows.Forms.Label categoriaprod;
        public System.Windows.Forms.Label codprod;
        public System.Windows.Forms.Label nameprod;
        public System.Windows.Forms.ToolTip toolTip1;
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
        public System.Windows.Forms.Button btnCode;
        public System.Windows.Forms.Button btnDet;
        public System.Windows.Forms.Button btnName;
    }
}