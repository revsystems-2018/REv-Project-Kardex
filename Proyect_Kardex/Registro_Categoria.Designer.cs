namespace Proyect_Kardex
{
    partial class Registro_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Categoria));
            this.dataGridCat = new System.Windows.Forms.DataGridView();
            this.codCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descSubCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEV_DataBaseDataSet = new Proyect_Kardex.REV_DataBaseDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubCat = new System.Windows.Forms.Button();
            this.printview = new System.Windows.Forms.Button();
            this.selectboton = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.toolCategoria = new System.Windows.Forms.ToolTip(this.components);
            this.categoriasTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.CategoriasTableAdapter();
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCat
            // 
            this.dataGridCat.AllowUserToAddRows = false;
            this.dataGridCat.AllowUserToDeleteRows = false;
            this.dataGridCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCat.AutoGenerateColumns = false;
            this.dataGridCat.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCatDataGridViewTextBoxColumn,
            this.descCatDataGridViewTextBoxColumn,
            this.descSubCatDataGridViewTextBoxColumn});
            this.dataGridCat.DataSource = this.categoriasBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCat.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCat.Location = new System.Drawing.Point(0, 51);
            this.dataGridCat.Name = "dataGridCat";
            this.dataGridCat.ReadOnly = true;
            this.dataGridCat.Size = new System.Drawing.Size(534, 350);
            this.dataGridCat.TabIndex = 10;
            this.dataGridCat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCat_CellClick);
            // 
            // codCatDataGridViewTextBoxColumn
            // 
            this.codCatDataGridViewTextBoxColumn.DataPropertyName = "codCat";
            this.codCatDataGridViewTextBoxColumn.HeaderText = "Código de Registro";
            this.codCatDataGridViewTextBoxColumn.Name = "codCatDataGridViewTextBoxColumn";
            this.codCatDataGridViewTextBoxColumn.ReadOnly = true;
            this.codCatDataGridViewTextBoxColumn.Width = 180;
            // 
            // descCatDataGridViewTextBoxColumn
            // 
            this.descCatDataGridViewTextBoxColumn.DataPropertyName = "DescCat";
            this.descCatDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.descCatDataGridViewTextBoxColumn.Name = "descCatDataGridViewTextBoxColumn";
            this.descCatDataGridViewTextBoxColumn.ReadOnly = true;
            this.descCatDataGridViewTextBoxColumn.Width = 150;
            // 
            // descSubCatDataGridViewTextBoxColumn
            // 
            this.descSubCatDataGridViewTextBoxColumn.DataPropertyName = "DescSubCat";
            this.descSubCatDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descSubCatDataGridViewTextBoxColumn.Name = "descSubCatDataGridViewTextBoxColumn";
            this.descSubCatDataGridViewTextBoxColumn.ReadOnly = true;
            this.descSubCatDataGridViewTextBoxColumn.Width = 180;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.rEV_DataBaseDataSet;
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
            this.panel1.Controls.Add(this.btnSubCat);
            this.panel1.Controls.Add(this.printview);
            this.panel1.Controls.Add(this.selectboton);
            this.panel1.Controls.Add(this.actualizar);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.nuevo);
            this.panel1.Controls.Add(this.eliminar);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 51);
            this.panel1.TabIndex = 301;
            // 
            // btnSubCat
            // 
            this.btnSubCat.BackColor = System.Drawing.Color.Transparent;
            this.btnSubCat.BackgroundImage = global::Proyect_Kardex.Properties.Resources.subcat_settings;
            this.btnSubCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubCat.FlatAppearance.BorderSize = 0;
            this.btnSubCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubCat.Location = new System.Drawing.Point(219, 5);
            this.btnSubCat.Name = "btnSubCat";
            this.btnSubCat.Size = new System.Drawing.Size(40, 40);
            this.btnSubCat.TabIndex = 10;
            this.btnSubCat.UseVisualStyleBackColor = false;
            this.btnSubCat.Click += new System.EventHandler(this.button1_Click);
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
            this.printview.Location = new System.Drawing.Point(375, 4);
            this.printview.Name = "printview";
            this.printview.Size = new System.Drawing.Size(20, 20);
            this.printview.TabIndex = 7;
            this.printview.UseVisualStyleBackColor = false;
            this.printview.Click += new System.EventHandler(this.printview_Click);
            // 
            // selectboton
            // 
            this.selectboton.BackColor = System.Drawing.Color.Transparent;
            this.selectboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Selectb;
            this.selectboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectboton.Enabled = false;
            this.selectboton.FlatAppearance.BorderSize = 0;
            this.selectboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.selectboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.selectboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectboton.Location = new System.Drawing.Point(12, 5);
            this.selectboton.Name = "selectboton";
            this.selectboton.Size = new System.Drawing.Size(40, 40);
            this.selectboton.TabIndex = 1;
            this.selectboton.UseVisualStyleBackColor = false;
            this.selectboton.Click += new System.EventHandler(this.selectboton_Click);
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
            this.actualizar.Location = new System.Drawing.Point(281, 5);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(40, 40);
            this.actualizar.TabIndex = 5;
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
            this.print.Location = new System.Drawing.Point(347, 5);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(40, 40);
            this.print.TabIndex = 6;
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
            this.editar.Location = new System.Drawing.Point(114, 5);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(40, 40);
            this.editar.TabIndex = 3;
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
            this.nuevo.Location = new System.Drawing.Point(68, 5);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(40, 40);
            this.nuevo.TabIndex = 2;
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
            this.eliminar.Location = new System.Drawing.Point(160, 5);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(40, 40);
            this.eliminar.TabIndex = 4;
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
            this.save.Location = new System.Drawing.Point(417, 5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(40, 40);
            this.save.TabIndex = 8;
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
            this.salir.Location = new System.Drawing.Point(482, 5);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(40, 40);
            this.salir.TabIndex = 9;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
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
            // Registro_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(534, 400);
            this.Controls.Add(this.dataGridCat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Categorías";
            this.Load += new System.EventHandler(this.Registro_Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridCat;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button selectboton;
        public System.Windows.Forms.Button actualizar;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button editar;
        public System.Windows.Forms.Button nuevo;
        public System.Windows.Forms.Button eliminar;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button salir;
        public System.Windows.Forms.ToolTip toolCategoria;
        public System.Windows.Forms.Button printview;
        private REV_DataBaseDataSet rEV_DataBaseDataSet;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private REV_DataBaseDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descCatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descSubCatDataGridViewTextBoxColumn;
        public System.Windows.Forms.PrintDialog printMain;
        public System.Drawing.Printing.PrintDocument printDocx;
        public System.Windows.Forms.PrintPreviewDialog printPreview;
        public System.Windows.Forms.Button btnSubCat;
    }
}