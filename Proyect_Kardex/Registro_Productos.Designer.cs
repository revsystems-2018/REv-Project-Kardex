namespace Proyect_Kardex
{
    partial class Registro_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Productos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CodeQR = new System.Windows.Forms.Button();
            this.seeProd = new System.Windows.Forms.Button();
            this.printview = new System.Windows.Forms.Button();
            this.graficStadis = new System.Windows.Forms.Button();
            this.buscardet = new System.Windows.Forms.Button();
            this.buscarQuick = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.gencodbar = new System.Windows.Forms.Button();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEV_DataBaseDataSet = new Proyect_Kardex.REV_DataBaseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cantlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.toolRegProd = new System.Windows.Forms.ToolTip(this.components);
            this.productosTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.ProductosTableAdapter();
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.idProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaxProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMinProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcivaProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVUProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCUProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgCodDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imgProdDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.fcProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codBarPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regprodtable = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regprodtable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.CodeQR);
            this.panel1.Controls.Add(this.seeProd);
            this.panel1.Controls.Add(this.printview);
            this.panel1.Controls.Add(this.graficStadis);
            this.panel1.Controls.Add(this.buscardet);
            this.panel1.Controls.Add(this.buscarQuick);
            this.panel1.Controls.Add(this.actualizar);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.nuevo);
            this.panel1.Controls.Add(this.eliminar);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Controls.Add(this.gencodbar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 51);
            this.panel1.TabIndex = 299;
            // 
            // CodeQR
            // 
            this.CodeQR.BackColor = System.Drawing.Color.Transparent;
            this.CodeQR.BackgroundImage = global::Proyect_Kardex.Properties.Resources.dosnotify;
            this.CodeQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CodeQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CodeQR.FlatAppearance.BorderSize = 0;
            this.CodeQR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CodeQR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CodeQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CodeQR.Location = new System.Drawing.Point(726, 5);
            this.CodeQR.Name = "CodeQR";
            this.CodeQR.Size = new System.Drawing.Size(20, 20);
            this.CodeQR.TabIndex = 307;
            this.CodeQR.UseVisualStyleBackColor = false;
            this.CodeQR.Click += new System.EventHandler(this.CodeQR_Click);
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
            this.seeProd.Location = new System.Drawing.Point(191, 5);
            this.seeProd.Name = "seeProd";
            this.seeProd.Size = new System.Drawing.Size(40, 40);
            this.seeProd.TabIndex = 306;
            this.seeProd.UseVisualStyleBackColor = false;
            this.seeProd.Click += new System.EventHandler(this.button1_Click);
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
            this.printview.Location = new System.Drawing.Point(362, 4);
            this.printview.Name = "printview";
            this.printview.Size = new System.Drawing.Size(20, 20);
            this.printview.TabIndex = 298;
            this.printview.UseVisualStyleBackColor = false;
            this.printview.Click += new System.EventHandler(this.printview_Click);
            // 
            // graficStadis
            // 
            this.graficStadis.BackColor = System.Drawing.Color.Transparent;
            this.graficStadis.BackgroundImage = global::Proyect_Kardex.Properties.Resources.shopping_21_512;
            this.graficStadis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.graficStadis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graficStadis.FlatAppearance.BorderSize = 0;
            this.graficStadis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.graficStadis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.graficStadis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graficStadis.Location = new System.Drawing.Point(485, 5);
            this.graficStadis.Name = "graficStadis";
            this.graficStadis.Size = new System.Drawing.Size(40, 40);
            this.graficStadis.TabIndex = 297;
            this.graficStadis.UseVisualStyleBackColor = false;
            this.graficStadis.Click += new System.EventHandler(this.graficStadis_Click);
            // 
            // buscardet
            // 
            this.buscardet.BackColor = System.Drawing.Color.Transparent;
            this.buscardet.BackgroundImage = global::Proyect_Kardex.Properties.Resources.search_good_512;
            this.buscardet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscardet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscardet.FlatAppearance.BorderSize = 0;
            this.buscardet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buscardet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buscardet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscardet.Location = new System.Drawing.Point(631, 5);
            this.buscardet.Name = "buscardet";
            this.buscardet.Size = new System.Drawing.Size(40, 40);
            this.buscardet.TabIndex = 295;
            this.buscardet.UseVisualStyleBackColor = false;
            this.buscardet.Click += new System.EventHandler(this.buscardet_Click);
            // 
            // buscarQuick
            // 
            this.buscarQuick.BackColor = System.Drawing.Color.Transparent;
            this.buscarQuick.BackgroundImage = global::Proyect_Kardex.Properties.Resources.Loop_512;
            this.buscarQuick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarQuick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarQuick.FlatAppearance.BorderSize = 0;
            this.buscarQuick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buscarQuick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buscarQuick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarQuick.Location = new System.Drawing.Point(564, 5);
            this.buscarQuick.Name = "buscarQuick";
            this.buscarQuick.Size = new System.Drawing.Size(40, 40);
            this.buscarQuick.TabIndex = 294;
            this.buscarQuick.UseVisualStyleBackColor = false;
            this.buscarQuick.Click += new System.EventHandler(this.buscarQuick_Click);
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
            this.actualizar.Location = new System.Drawing.Point(270, 5);
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
            this.print.Location = new System.Drawing.Point(336, 5);
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
            this.editar.Location = new System.Drawing.Point(68, 5);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(40, 40);
            this.editar.TabIndex = 291;
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
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
            this.nuevo.Location = new System.Drawing.Point(12, 5);
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
            this.eliminar.Location = new System.Drawing.Point(123, 5);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(40, 40);
            this.eliminar.TabIndex = 289;
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
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
            this.save.Location = new System.Drawing.Point(407, 5);
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
            this.salir.Location = new System.Drawing.Point(766, 5);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(40, 40);
            this.salir.TabIndex = 251;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // gencodbar
            // 
            this.gencodbar.BackColor = System.Drawing.Color.Transparent;
            this.gencodbar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.barcodcol;
            this.gencodbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gencodbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gencodbar.FlatAppearance.BorderSize = 0;
            this.gencodbar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.gencodbar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.gencodbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gencodbar.Location = new System.Drawing.Point(696, 5);
            this.gencodbar.Name = "gencodbar";
            this.gencodbar.Size = new System.Drawing.Size(40, 40);
            this.gencodbar.TabIndex = 296;
            this.gencodbar.UseVisualStyleBackColor = false;
            this.gencodbar.Click += new System.EventHandler(this.gencodbar_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 302;
            this.label1.Text = "Inventario de Productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 12);
            this.label5.TabIndex = 301;
            this.label5.Text = "Cantidad de Productos:";
            // 
            // cantlabel
            // 
            this.cantlabel.AutoSize = true;
            this.cantlabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantlabel.ForeColor = System.Drawing.Color.Green;
            this.cantlabel.Location = new System.Drawing.Point(234, 73);
            this.cantlabel.Name = "cantlabel";
            this.cantlabel.Size = new System.Drawing.Size(144, 22);
            this.cantlabel.TabIndex = 303;
            this.cantlabel.Text = "120910  Und.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 304;
            this.label3.Text = "Valor Total:";
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.totallabel.Location = new System.Drawing.Point(538, 73);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(120, 22);
            this.totallabel.TabIndex = 305;
            this.totallabel.Text = "950,50  Bs.";
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
            // idProveDataGridViewTextBoxColumn
            // 
            this.idProveDataGridViewTextBoxColumn.DataPropertyName = "idProve";
            this.idProveDataGridViewTextBoxColumn.HeaderText = "Codigo Proveedor";
            this.idProveDataGridViewTextBoxColumn.Name = "idProveDataGridViewTextBoxColumn";
            this.idProveDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProveDataGridViewTextBoxColumn.Width = 150;
            // 
            // subCodDataGridViewTextBoxColumn
            // 
            this.subCodDataGridViewTextBoxColumn.DataPropertyName = "subCod";
            this.subCodDataGridViewTextBoxColumn.HeaderText = "SubCategoría";
            this.subCodDataGridViewTextBoxColumn.Name = "subCodDataGridViewTextBoxColumn";
            this.subCodDataGridViewTextBoxColumn.ReadOnly = true;
            this.subCodDataGridViewTextBoxColumn.Visible = false;
            this.subCodDataGridViewTextBoxColumn.Width = 120;
            // 
            // medCodDataGridViewTextBoxColumn
            // 
            this.medCodDataGridViewTextBoxColumn.DataPropertyName = "medCod";
            this.medCodDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.medCodDataGridViewTextBoxColumn.Name = "medCodDataGridViewTextBoxColumn";
            this.medCodDataGridViewTextBoxColumn.ReadOnly = true;
            this.medCodDataGridViewTextBoxColumn.Visible = false;
            // 
            // markCodDataGridViewTextBoxColumn
            // 
            this.markCodDataGridViewTextBoxColumn.DataPropertyName = "markCod";
            this.markCodDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.markCodDataGridViewTextBoxColumn.Name = "markCodDataGridViewTextBoxColumn";
            this.markCodDataGridViewTextBoxColumn.ReadOnly = true;
            this.markCodDataGridViewTextBoxColumn.Visible = false;
            // 
            // cateCodDataGridViewTextBoxColumn
            // 
            this.cateCodDataGridViewTextBoxColumn.DataPropertyName = "cateCod";
            this.cateCodDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.cateCodDataGridViewTextBoxColumn.Name = "cateCodDataGridViewTextBoxColumn";
            this.cateCodDataGridViewTextBoxColumn.ReadOnly = true;
            this.cateCodDataGridViewTextBoxColumn.Visible = false;
            // 
            // sMaxProdDataGridViewTextBoxColumn
            // 
            this.sMaxProdDataGridViewTextBoxColumn.DataPropertyName = "SMaxProd";
            this.sMaxProdDataGridViewTextBoxColumn.HeaderText = "Stock Máximo";
            this.sMaxProdDataGridViewTextBoxColumn.Name = "sMaxProdDataGridViewTextBoxColumn";
            this.sMaxProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sMaxProdDataGridViewTextBoxColumn.Width = 120;
            // 
            // sMinProdDataGridViewTextBoxColumn
            // 
            this.sMinProdDataGridViewTextBoxColumn.DataPropertyName = "SMinProd";
            this.sMinProdDataGridViewTextBoxColumn.HeaderText = "Stock Mínimo";
            this.sMinProdDataGridViewTextBoxColumn.Name = "sMinProdDataGridViewTextBoxColumn";
            this.sMinProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sMinProdDataGridViewTextBoxColumn.Width = 120;
            // 
            // cantProdDataGridViewTextBoxColumn
            // 
            this.cantProdDataGridViewTextBoxColumn.DataPropertyName = "CantProd";
            this.cantProdDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantProdDataGridViewTextBoxColumn.Name = "cantProdDataGridViewTextBoxColumn";
            this.cantProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rcivaProdDataGridViewTextBoxColumn
            // 
            this.rcivaProdDataGridViewTextBoxColumn.DataPropertyName = "rcivaProd";
            this.rcivaProdDataGridViewTextBoxColumn.HeaderText = "RC - IVA";
            this.rcivaProdDataGridViewTextBoxColumn.Name = "rcivaProdDataGridViewTextBoxColumn";
            this.rcivaProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pVUProdDataGridViewTextBoxColumn
            // 
            this.pVUProdDataGridViewTextBoxColumn.DataPropertyName = "PVUProd";
            this.pVUProdDataGridViewTextBoxColumn.HeaderText = "Precio Venta";
            this.pVUProdDataGridViewTextBoxColumn.Name = "pVUProdDataGridViewTextBoxColumn";
            this.pVUProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cCUProdDataGridViewTextBoxColumn
            // 
            this.cCUProdDataGridViewTextBoxColumn.DataPropertyName = "CCUProd";
            this.cCUProdDataGridViewTextBoxColumn.HeaderText = "Costo Compra";
            this.cCUProdDataGridViewTextBoxColumn.Name = "cCUProdDataGridViewTextBoxColumn";
            this.cCUProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cCUProdDataGridViewTextBoxColumn.Width = 130;
            // 
            // imgCodDataGridViewImageColumn
            // 
            this.imgCodDataGridViewImageColumn.DataPropertyName = "imgCod";
            this.imgCodDataGridViewImageColumn.HeaderText = "Imagen de Codigo";
            this.imgCodDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imgCodDataGridViewImageColumn.Name = "imgCodDataGridViewImageColumn";
            this.imgCodDataGridViewImageColumn.ReadOnly = true;
            this.imgCodDataGridViewImageColumn.Width = 150;
            // 
            // imgProdDataGridViewImageColumn
            // 
            this.imgProdDataGridViewImageColumn.DataPropertyName = "imgProd";
            this.imgProdDataGridViewImageColumn.HeaderText = "Imagen";
            this.imgProdDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imgProdDataGridViewImageColumn.Name = "imgProdDataGridViewImageColumn";
            this.imgProdDataGridViewImageColumn.ReadOnly = true;
            // 
            // fcProdDataGridViewTextBoxColumn
            // 
            this.fcProdDataGridViewTextBoxColumn.DataPropertyName = "fcProd";
            this.fcProdDataGridViewTextBoxColumn.HeaderText = "Fecha de Creación";
            this.fcProdDataGridViewTextBoxColumn.Name = "fcProdDataGridViewTextBoxColumn";
            this.fcProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.fcProdDataGridViewTextBoxColumn.Width = 150;
            // 
            // fnProdDataGridViewTextBoxColumn
            // 
            this.fnProdDataGridViewTextBoxColumn.DataPropertyName = "fnProd";
            this.fnProdDataGridViewTextBoxColumn.HeaderText = "Fecha de Vencimiento";
            this.fnProdDataGridViewTextBoxColumn.Name = "fnProdDataGridViewTextBoxColumn";
            this.fnProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.fnProdDataGridViewTextBoxColumn.Width = 180;
            // 
            // estadoProdDataGridViewTextBoxColumn
            // 
            this.estadoProdDataGridViewTextBoxColumn.DataPropertyName = "EstadoProd";
            this.estadoProdDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoProdDataGridViewTextBoxColumn.Name = "estadoProdDataGridViewTextBoxColumn";
            this.estadoProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volProdDataGridViewTextBoxColumn
            // 
            this.volProdDataGridViewTextBoxColumn.DataPropertyName = "VolProd";
            this.volProdDataGridViewTextBoxColumn.HeaderText = "Volumen";
            this.volProdDataGridViewTextBoxColumn.Name = "volProdDataGridViewTextBoxColumn";
            this.volProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoProdDataGridViewTextBoxColumn
            // 
            this.pesoProdDataGridViewTextBoxColumn.DataPropertyName = "PesoProd";
            this.pesoProdDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoProdDataGridViewTextBoxColumn.Name = "pesoProdDataGridViewTextBoxColumn";
            this.pesoProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descProdDataGridViewTextBoxColumn
            // 
            this.descProdDataGridViewTextBoxColumn.DataPropertyName = "DescProd";
            this.descProdDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descProdDataGridViewTextBoxColumn.Name = "descProdDataGridViewTextBoxColumn";
            this.descProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.descProdDataGridViewTextBoxColumn.Width = 180;
            // 
            // nomProdDataGridViewTextBoxColumn
            // 
            this.nomProdDataGridViewTextBoxColumn.DataPropertyName = "nomProd";
            this.nomProdDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomProdDataGridViewTextBoxColumn.Name = "nomProdDataGridViewTextBoxColumn";
            this.nomProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomProdDataGridViewTextBoxColumn.Width = 160;
            // 
            // codBarPDataGridViewTextBoxColumn
            // 
            this.codBarPDataGridViewTextBoxColumn.DataPropertyName = "CodBarP";
            this.codBarPDataGridViewTextBoxColumn.HeaderText = "Codigo de Registro";
            this.codBarPDataGridViewTextBoxColumn.Name = "codBarPDataGridViewTextBoxColumn";
            this.codBarPDataGridViewTextBoxColumn.ReadOnly = true;
            this.codBarPDataGridViewTextBoxColumn.Width = 150;
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
            this.regprodtable.Location = new System.Drawing.Point(0, 98);
            this.regprodtable.Name = "regprodtable";
            this.regprodtable.ReadOnly = true;
            this.regprodtable.Size = new System.Drawing.Size(818, 448);
            this.regprodtable.TabIndex = 300;
            this.regprodtable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.regprodtable_CellClick);
            // 
            // Registro_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(818, 545);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.regprodtable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Productos";
            this.Load += new System.EventHandler(this.Registro_Productos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regprodtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button actualizar;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button editar;
        public System.Windows.Forms.Button nuevo;
        public System.Windows.Forms.Button eliminar;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button salir;
        public System.Windows.Forms.Button buscardet;
        public System.Windows.Forms.Button buscarQuick;
        public System.Windows.Forms.Button gencodbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button graficStadis;
        public System.Windows.Forms.Label cantlabel;
        public System.Windows.Forms.Label totallabel;
        public System.Windows.Forms.ToolTip toolRegProd;
        private REV_DataBaseDataSet rEV_DataBaseDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private REV_DataBaseDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.PrintDialog printMain;
        public System.Drawing.Printing.PrintDocument printDocx;
        public System.Windows.Forms.PrintPreviewDialog printPreview;
        public System.Windows.Forms.Button seeProd;
        public System.Windows.Forms.Button CodeQR;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaxProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMinProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcivaProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pVUProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCUProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgCodDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgProdDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBarPDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView regprodtable;
    }
}