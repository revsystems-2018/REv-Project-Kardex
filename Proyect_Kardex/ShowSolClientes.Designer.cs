namespace Proyect_Kardex
{
    partial class ShowSolClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSolClientes));
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.codSolCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciSolCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSolCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeSolCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitSolCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirSolCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corrSolCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telSolCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celSolCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDepaSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUsrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEV_DataBaseDataSet = new Proyect_Kardex.REV_DataBaseDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printview = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.titulosol = new System.Windows.Forms.Label();
            this.buscarcic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.soltooltip = new System.Windows.Forms.ToolTip(this.components);
            this.solClientesTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.SolClientesTableAdapter();
            this.searchci = new System.Windows.Forms.Button();
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.PreviewPrint = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.AutoGenerateColumns = false;
            this.dataGridClientes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codSolCDataGridViewTextBoxColumn,
            this.ciSolCDataGridViewTextBoxColumn,
            this.nomSolCDataGridViewTextBoxColumn,
            this.apeSolCDataGridViewTextBoxColumn,
            this.nitSolCDataGridViewTextBoxColumn,
            this.dirSolCDataGridViewTextBoxColumn,
            this.corrSolCDataGridViewTextBoxColumn,
            this.telSolCDataGridViewTextBoxColumn,
            this.celSolCDataGridViewTextBoxColumn,
            this.codDepaSCDataGridViewTextBoxColumn,
            this.codUsrDataGridViewTextBoxColumn});
            this.dataGridClientes.DataSource = this.solClientesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridClientes.Location = new System.Drawing.Point(0, 104);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.Size = new System.Drawing.Size(541, 401);
            this.dataGridClientes.TabIndex = 294;
            this.dataGridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellClick);
            // 
            // codSolCDataGridViewTextBoxColumn
            // 
            this.codSolCDataGridViewTextBoxColumn.DataPropertyName = "codSolC";
            this.codSolCDataGridViewTextBoxColumn.HeaderText = "Codigo de Registro";
            this.codSolCDataGridViewTextBoxColumn.Name = "codSolCDataGridViewTextBoxColumn";
            this.codSolCDataGridViewTextBoxColumn.ReadOnly = true;
            this.codSolCDataGridViewTextBoxColumn.Width = 150;
            // 
            // ciSolCDataGridViewTextBoxColumn
            // 
            this.ciSolCDataGridViewTextBoxColumn.DataPropertyName = "ciSolC";
            this.ciSolCDataGridViewTextBoxColumn.HeaderText = "Carnet Identidad";
            this.ciSolCDataGridViewTextBoxColumn.Name = "ciSolCDataGridViewTextBoxColumn";
            this.ciSolCDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciSolCDataGridViewTextBoxColumn.Width = 120;
            // 
            // nomSolCDataGridViewTextBoxColumn
            // 
            this.nomSolCDataGridViewTextBoxColumn.DataPropertyName = "nomSolC";
            this.nomSolCDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nomSolCDataGridViewTextBoxColumn.Name = "nomSolCDataGridViewTextBoxColumn";
            this.nomSolCDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomSolCDataGridViewTextBoxColumn.Width = 120;
            // 
            // apeSolCDataGridViewTextBoxColumn
            // 
            this.apeSolCDataGridViewTextBoxColumn.DataPropertyName = "apeSolC";
            this.apeSolCDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apeSolCDataGridViewTextBoxColumn.Name = "apeSolCDataGridViewTextBoxColumn";
            this.apeSolCDataGridViewTextBoxColumn.ReadOnly = true;
            this.apeSolCDataGridViewTextBoxColumn.Width = 120;
            // 
            // nitSolCDataGridViewTextBoxColumn
            // 
            this.nitSolCDataGridViewTextBoxColumn.DataPropertyName = "nitSolC";
            this.nitSolCDataGridViewTextBoxColumn.HeaderText = "NIT";
            this.nitSolCDataGridViewTextBoxColumn.Name = "nitSolCDataGridViewTextBoxColumn";
            this.nitSolCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dirSolCDataGridViewTextBoxColumn
            // 
            this.dirSolCDataGridViewTextBoxColumn.DataPropertyName = "dirSolC";
            this.dirSolCDataGridViewTextBoxColumn.HeaderText = "Ubicación";
            this.dirSolCDataGridViewTextBoxColumn.Name = "dirSolCDataGridViewTextBoxColumn";
            this.dirSolCDataGridViewTextBoxColumn.ReadOnly = true;
            this.dirSolCDataGridViewTextBoxColumn.Width = 150;
            // 
            // corrSolCDataGridViewTextBoxColumn
            // 
            this.corrSolCDataGridViewTextBoxColumn.DataPropertyName = "corrSolC";
            this.corrSolCDataGridViewTextBoxColumn.HeaderText = "Correo Electrónico";
            this.corrSolCDataGridViewTextBoxColumn.Name = "corrSolCDataGridViewTextBoxColumn";
            this.corrSolCDataGridViewTextBoxColumn.ReadOnly = true;
            this.corrSolCDataGridViewTextBoxColumn.Width = 180;
            // 
            // telSolCDataGridViewTextBoxColumn
            // 
            this.telSolCDataGridViewTextBoxColumn.DataPropertyName = "telSolC";
            this.telSolCDataGridViewTextBoxColumn.HeaderText = "Télefono";
            this.telSolCDataGridViewTextBoxColumn.Name = "telSolCDataGridViewTextBoxColumn";
            this.telSolCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celSolCDataGridViewTextBoxColumn
            // 
            this.celSolCDataGridViewTextBoxColumn.DataPropertyName = "celSolC";
            this.celSolCDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celSolCDataGridViewTextBoxColumn.Name = "celSolCDataGridViewTextBoxColumn";
            this.celSolCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codDepaSCDataGridViewTextBoxColumn
            // 
            this.codDepaSCDataGridViewTextBoxColumn.DataPropertyName = "CodDepaSC";
            this.codDepaSCDataGridViewTextBoxColumn.HeaderText = "Codigo Departamento";
            this.codDepaSCDataGridViewTextBoxColumn.Name = "codDepaSCDataGridViewTextBoxColumn";
            this.codDepaSCDataGridViewTextBoxColumn.ReadOnly = true;
            this.codDepaSCDataGridViewTextBoxColumn.Width = 150;
            // 
            // codUsrDataGridViewTextBoxColumn
            // 
            this.codUsrDataGridViewTextBoxColumn.DataPropertyName = "codUsr";
            this.codUsrDataGridViewTextBoxColumn.HeaderText = "Codigo del Usuario";
            this.codUsrDataGridViewTextBoxColumn.Name = "codUsrDataGridViewTextBoxColumn";
            this.codUsrDataGridViewTextBoxColumn.ReadOnly = true;
            this.codUsrDataGridViewTextBoxColumn.Width = 150;
            // 
            // solClientesBindingSource
            // 
            this.solClientesBindingSource.DataMember = "SolClientes";
            this.solClientesBindingSource.DataSource = this.rEV_DataBaseDataSet;
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
            this.panel1.Controls.Add(this.printview);
            this.panel1.Controls.Add(this.actualizar);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.nuevo);
            this.panel1.Controls.Add(this.eliminar);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 51);
            this.panel1.TabIndex = 295;
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
            this.printview.Location = new System.Drawing.Point(343, 4);
            this.printview.Name = "printview";
            this.printview.Size = new System.Drawing.Size(20, 20);
            this.printview.TabIndex = 14;
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
            this.actualizar.Location = new System.Drawing.Point(238, 5);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(40, 40);
            this.actualizar.TabIndex = 7;
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
            this.print.Location = new System.Drawing.Point(316, 5);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(40, 40);
            this.print.TabIndex = 8;
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.Transparent;
            this.editar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editdocumentob;
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editar.Enabled = false;
            this.editar.FlatAppearance.BorderSize = 0;
            this.editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Location = new System.Drawing.Point(79, 5);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(40, 40);
            this.editar.TabIndex = 5;
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
            this.nuevo.Location = new System.Drawing.Point(23, 5);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(40, 40);
            this.nuevo.TabIndex = 4;
            this.nuevo.UseVisualStyleBackColor = false;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.Transparent;
            this.eliminar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_deleteb;
            this.eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminar.Enabled = false;
            this.eliminar.FlatAppearance.BorderSize = 0;
            this.eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.Location = new System.Drawing.Point(133, 5);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(40, 40);
            this.eliminar.TabIndex = 6;
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
            this.save.Location = new System.Drawing.Point(422, 5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(40, 40);
            this.save.TabIndex = 9;
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
            this.salir.Location = new System.Drawing.Point(489, 5);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(40, 40);
            this.salir.TabIndex = 10;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // titulosol
            // 
            this.titulosol.AutoSize = true;
            this.titulosol.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulosol.Location = new System.Drawing.Point(12, 56);
            this.titulosol.Name = "titulosol";
            this.titulosol.Size = new System.Drawing.Size(176, 19);
            this.titulosol.TabIndex = 1;
            this.titulosol.Text = "Confirmación De Clientes";
            this.titulosol.Click += new System.EventHandler(this.label1_Click);
            // 
            // buscarcic
            // 
            this.buscarcic.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarcic.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buscarcic.Location = new System.Drawing.Point(142, 78);
            this.buscarcic.Name = "buscarcic";
            this.buscarcic.Size = new System.Drawing.Size(379, 20);
            this.buscarcic.TabIndex = 2;
            this.buscarcic.Text = "C.I. del Cliente a Seleccionar";
            this.buscarcic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cibuscarClick);
            this.buscarcic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cibuscar);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 12);
            this.label5.TabIndex = 296;
            this.label5.Text = "Carnet de Identidad";
            // 
            // solClientesTableAdapter
            // 
            this.solClientesTableAdapter.ClearBeforeFill = true;
            // 
            // searchci
            // 
            this.searchci.BackgroundImage = global::Proyect_Kardex.Properties.Resources.lupa;
            this.searchci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchci.FlatAppearance.BorderSize = 0;
            this.searchci.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.searchci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.searchci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchci.Location = new System.Drawing.Point(501, 79);
            this.searchci.Name = "searchci";
            this.searchci.Size = new System.Drawing.Size(19, 18);
            this.searchci.TabIndex = 3;
            this.searchci.UseVisualStyleBackColor = true;
            this.searchci.Click += new System.EventHandler(this.searchci_Click);
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
            // PreviewPrint
            // 
            this.PreviewPrint.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PreviewPrint.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PreviewPrint.ClientSize = new System.Drawing.Size(400, 300);
            this.PreviewPrint.Document = this.printDocx;
            this.PreviewPrint.Enabled = true;
            this.PreviewPrint.Icon = ((System.Drawing.Icon)(resources.GetObject("PreviewPrint.Icon")));
            this.PreviewPrint.Name = "printPreviewDialog1";
            this.PreviewPrint.ShowIcon = false;
            this.PreviewPrint.Visible = false;
            // 
            // ShowSolClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(541, 503);
            this.Controls.Add(this.searchci);
            this.Controls.Add(this.titulosol);
            this.Controls.Add(this.buscarcic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowSolClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de Clientes";
            this.Load += new System.EventHandler(this.ShowSolClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button actualizar;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button editar;
        public System.Windows.Forms.Button nuevo;
        public System.Windows.Forms.Button eliminar;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button salir;
        public System.Windows.Forms.Button searchci;
        public System.Windows.Forms.TextBox buscarcic;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ToolTip soltooltip;
        private REV_DataBaseDataSet rEV_DataBaseDataSet;
        private System.Windows.Forms.BindingSource solClientesBindingSource;
        private REV_DataBaseDataSetTableAdapters.SolClientesTableAdapter solClientesTableAdapter;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.PrintDialog printMain;
        public System.Drawing.Printing.PrintDocument printDocx;
        public System.Windows.Forms.PrintPreviewDialog PreviewPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSolCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciSolCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSolCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeSolCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitSolCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirSolCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corrSolCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telSolCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celSolCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDepaSCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUsrDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label titulosol;
    }
}