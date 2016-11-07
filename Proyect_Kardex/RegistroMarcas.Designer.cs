namespace Proyect_Kardex
{
    partial class RegistroMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroMarcas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.printview = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.dataGridMark = new System.Windows.Forms.DataGridView();
            this.codMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iniMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoMarcaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEV_DataBaseDataSet = new Proyect_Kardex.REV_DataBaseDataSet();
            this.toolregmarca = new System.Windows.Forms.ToolTip(this.components);
            this.marcasTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.MarcasTableAdapter();
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.printview);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.actualizar);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.nuevo);
            this.panel1.Controls.Add(this.eliminar);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 51);
            this.panel1.TabIndex = 299;
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
            this.printview.Location = new System.Drawing.Point(330, 4);
            this.printview.Name = "printview";
            this.printview.Size = new System.Drawing.Size(20, 20);
            this.printview.TabIndex = 301;
            this.printview.UseVisualStyleBackColor = false;
            this.printview.Click += new System.EventHandler(this.printview_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Selectb;
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.Enabled = false;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(12, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(40, 40);
            this.btnSelect.TabIndex = 294;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.button1_Click);
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
            this.actualizar.Location = new System.Drawing.Point(230, 5);
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
            this.print.Location = new System.Drawing.Point(303, 5);
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
            this.editar.Location = new System.Drawing.Point(114, 5);
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
            this.nuevo.Location = new System.Drawing.Point(68, 5);
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
            this.eliminar.Location = new System.Drawing.Point(160, 5);
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
            this.save.Location = new System.Drawing.Point(379, 5);
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
            this.salir.Location = new System.Drawing.Point(442, 5);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(40, 40);
            this.salir.TabIndex = 251;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // dataGridMark
            // 
            this.dataGridMark.AllowUserToAddRows = false;
            this.dataGridMark.AllowUserToDeleteRows = false;
            this.dataGridMark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMark.AutoGenerateColumns = false;
            this.dataGridMark.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridMark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMark.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMarcaDataGridViewTextBoxColumn,
            this.iniMarcaDataGridViewTextBoxColumn,
            this.descMarcaDataGridViewTextBoxColumn,
            this.logoMarcaDataGridViewImageColumn});
            this.dataGridMark.DataSource = this.marcasBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMark.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridMark.Location = new System.Drawing.Point(0, 51);
            this.dataGridMark.Name = "dataGridMark";
            this.dataGridMark.ReadOnly = true;
            this.dataGridMark.Size = new System.Drawing.Size(494, 350);
            this.dataGridMark.TabIndex = 300;
            this.dataGridMark.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMark_CellClick);
            // 
            // codMarcaDataGridViewTextBoxColumn
            // 
            this.codMarcaDataGridViewTextBoxColumn.DataPropertyName = "codMarca";
            this.codMarcaDataGridViewTextBoxColumn.HeaderText = "Código Registro";
            this.codMarcaDataGridViewTextBoxColumn.Name = "codMarcaDataGridViewTextBoxColumn";
            this.codMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codMarcaDataGridViewTextBoxColumn.Width = 140;
            // 
            // iniMarcaDataGridViewTextBoxColumn
            // 
            this.iniMarcaDataGridViewTextBoxColumn.DataPropertyName = "iniMarca";
            this.iniMarcaDataGridViewTextBoxColumn.HeaderText = "Iniciales de Marca";
            this.iniMarcaDataGridViewTextBoxColumn.Name = "iniMarcaDataGridViewTextBoxColumn";
            this.iniMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iniMarcaDataGridViewTextBoxColumn.Width = 140;
            // 
            // descMarcaDataGridViewTextBoxColumn
            // 
            this.descMarcaDataGridViewTextBoxColumn.DataPropertyName = "DescMarca";
            this.descMarcaDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descMarcaDataGridViewTextBoxColumn.Name = "descMarcaDataGridViewTextBoxColumn";
            this.descMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descMarcaDataGridViewTextBoxColumn.Width = 120;
            // 
            // logoMarcaDataGridViewImageColumn
            // 
            this.logoMarcaDataGridViewImageColumn.DataPropertyName = "logoMarca";
            this.logoMarcaDataGridViewImageColumn.HeaderText = "Logotipo de Empresa";
            this.logoMarcaDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.logoMarcaDataGridViewImageColumn.Name = "logoMarcaDataGridViewImageColumn";
            this.logoMarcaDataGridViewImageColumn.ReadOnly = true;
            this.logoMarcaDataGridViewImageColumn.Width = 150;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.rEV_DataBaseDataSet;
            // 
            // rEV_DataBaseDataSet
            // 
            this.rEV_DataBaseDataSet.DataSetName = "REV_DataBaseDataSet";
            this.rEV_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
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
            // RegistroMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(494, 400);
            this.Controls.Add(this.dataGridMark);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Marcas";
            this.Load += new System.EventHandler(this.RegistroMarcas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnSelect;
        public System.Windows.Forms.Button actualizar;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button editar;
        public System.Windows.Forms.Button nuevo;
        public System.Windows.Forms.Button eliminar;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button salir;
        public System.Windows.Forms.DataGridView dataGridMark;
        public System.Windows.Forms.ToolTip toolregmarca;
        private REV_DataBaseDataSet rEV_DataBaseDataSet;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private REV_DataBaseDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iniMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn logoMarcaDataGridViewImageColumn;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.PrintDialog printMain;
        public System.Drawing.Printing.PrintDocument printDocx;
        public System.Windows.Forms.PrintPreviewDialog printPreview;
    }
}