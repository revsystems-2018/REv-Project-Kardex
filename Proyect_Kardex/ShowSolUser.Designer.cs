namespace Proyect_Kardex
{
    partial class ShowSolUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSolUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.printview = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarcic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridUsr = new System.Windows.Forms.DataGridView();
            this.codSolUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciSolUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSolUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeSolUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSolUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passSolUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirSolUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexSolUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnSolUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corrSolUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telSolUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celSolUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDepaSUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUsrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEV_DataBaseDataSet = new Proyect_Kardex.REV_DataBaseDataSet();
            this.searchci = new System.Windows.Forms.Button();
            this.solUserTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.SolUserTableAdapter();
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 296;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 19);
            this.label1.TabIndex = 297;
            this.label1.Text = "Confirmación De Usuarios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buscarcic
            // 
            this.buscarcic.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarcic.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buscarcic.Location = new System.Drawing.Point(142, 76);
            this.buscarcic.Name = "buscarcic";
            this.buscarcic.Size = new System.Drawing.Size(379, 20);
            this.buscarcic.TabIndex = 298;
            this.buscarcic.Text = "C.I. del Usuario a Seleccionar";
            this.buscarcic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buscarcic_MouseClick);
            this.buscarcic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscarcic_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 12);
            this.label5.TabIndex = 300;
            this.label5.Text = "Carnet de Identidad";
            // 
            // dataGridUsr
            // 
            this.dataGridUsr.AllowUserToAddRows = false;
            this.dataGridUsr.AllowUserToDeleteRows = false;
            this.dataGridUsr.AutoGenerateColumns = false;
            this.dataGridUsr.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridUsr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codSolUDataGridViewTextBoxColumn,
            this.ciSolUDataGridViewTextBoxColumn,
            this.nomSolUDataGridViewTextBoxColumn,
            this.apeSolUDataGridViewTextBoxColumn,
            this.nameSolUDataGridViewTextBoxColumn,
            this.passSolUDataGridViewTextBoxColumn,
            this.dirSolUDataGridViewTextBoxColumn,
            this.sexSolUDataGridViewTextBoxColumn,
            this.fnSolUDataGridViewTextBoxColumn,
            this.corrSolUDataGridViewTextBoxColumn,
            this.telSolUDataGridViewTextBoxColumn,
            this.celSolUDataGridViewTextBoxColumn,
            this.codDepaSUDataGridViewTextBoxColumn,
            this.codUsrDataGridViewTextBoxColumn});
            this.dataGridUsr.DataSource = this.solUserBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsr.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsr.Location = new System.Drawing.Point(0, 102);
            this.dataGridUsr.Name = "dataGridUsr";
            this.dataGridUsr.ReadOnly = true;
            this.dataGridUsr.Size = new System.Drawing.Size(541, 401);
            this.dataGridUsr.TabIndex = 299;
            this.dataGridUsr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsr_CellClick);
            // 
            // codSolUDataGridViewTextBoxColumn
            // 
            this.codSolUDataGridViewTextBoxColumn.DataPropertyName = "codSolU";
            this.codSolUDataGridViewTextBoxColumn.HeaderText = "Codigo Registro";
            this.codSolUDataGridViewTextBoxColumn.Name = "codSolUDataGridViewTextBoxColumn";
            this.codSolUDataGridViewTextBoxColumn.ReadOnly = true;
            this.codSolUDataGridViewTextBoxColumn.Width = 140;
            // 
            // ciSolUDataGridViewTextBoxColumn
            // 
            this.ciSolUDataGridViewTextBoxColumn.DataPropertyName = "ciSolU";
            this.ciSolUDataGridViewTextBoxColumn.HeaderText = "Carnet Identidad";
            this.ciSolUDataGridViewTextBoxColumn.Name = "ciSolUDataGridViewTextBoxColumn";
            this.ciSolUDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciSolUDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomSolUDataGridViewTextBoxColumn
            // 
            this.nomSolUDataGridViewTextBoxColumn.DataPropertyName = "nomSolU";
            this.nomSolUDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nomSolUDataGridViewTextBoxColumn.Name = "nomSolUDataGridViewTextBoxColumn";
            this.nomSolUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apeSolUDataGridViewTextBoxColumn
            // 
            this.apeSolUDataGridViewTextBoxColumn.DataPropertyName = "apeSolU";
            this.apeSolUDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apeSolUDataGridViewTextBoxColumn.Name = "apeSolUDataGridViewTextBoxColumn";
            this.apeSolUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameSolUDataGridViewTextBoxColumn
            // 
            this.nameSolUDataGridViewTextBoxColumn.DataPropertyName = "nameSolU";
            this.nameSolUDataGridViewTextBoxColumn.HeaderText = "Nombre Usuario";
            this.nameSolUDataGridViewTextBoxColumn.Name = "nameSolUDataGridViewTextBoxColumn";
            this.nameSolUDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameSolUDataGridViewTextBoxColumn.Width = 150;
            // 
            // passSolUDataGridViewTextBoxColumn
            // 
            this.passSolUDataGridViewTextBoxColumn.DataPropertyName = "passSolU";
            this.passSolUDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.passSolUDataGridViewTextBoxColumn.Name = "passSolUDataGridViewTextBoxColumn";
            this.passSolUDataGridViewTextBoxColumn.ReadOnly = true;
            this.passSolUDataGridViewTextBoxColumn.Width = 110;
            // 
            // dirSolUDataGridViewTextBoxColumn
            // 
            this.dirSolUDataGridViewTextBoxColumn.DataPropertyName = "dirSolU";
            this.dirSolUDataGridViewTextBoxColumn.HeaderText = "Ubicación";
            this.dirSolUDataGridViewTextBoxColumn.Name = "dirSolUDataGridViewTextBoxColumn";
            this.dirSolUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexSolUDataGridViewTextBoxColumn
            // 
            this.sexSolUDataGridViewTextBoxColumn.DataPropertyName = "sexSolU";
            this.sexSolUDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexSolUDataGridViewTextBoxColumn.Name = "sexSolUDataGridViewTextBoxColumn";
            this.sexSolUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnSolUDataGridViewTextBoxColumn
            // 
            this.fnSolUDataGridViewTextBoxColumn.DataPropertyName = "fnSolU";
            this.fnSolUDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento";
            this.fnSolUDataGridViewTextBoxColumn.Name = "fnSolUDataGridViewTextBoxColumn";
            this.fnSolUDataGridViewTextBoxColumn.ReadOnly = true;
            this.fnSolUDataGridViewTextBoxColumn.Width = 160;
            // 
            // corrSolUDataGridViewTextBoxColumn
            // 
            this.corrSolUDataGridViewTextBoxColumn.DataPropertyName = "corrSolU";
            this.corrSolUDataGridViewTextBoxColumn.HeaderText = "Correo Electrónico";
            this.corrSolUDataGridViewTextBoxColumn.Name = "corrSolUDataGridViewTextBoxColumn";
            this.corrSolUDataGridViewTextBoxColumn.ReadOnly = true;
            this.corrSolUDataGridViewTextBoxColumn.Width = 160;
            // 
            // telSolUDataGridViewTextBoxColumn
            // 
            this.telSolUDataGridViewTextBoxColumn.DataPropertyName = "telSolU";
            this.telSolUDataGridViewTextBoxColumn.HeaderText = "Télefono";
            this.telSolUDataGridViewTextBoxColumn.Name = "telSolUDataGridViewTextBoxColumn";
            this.telSolUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celSolUDataGridViewTextBoxColumn
            // 
            this.celSolUDataGridViewTextBoxColumn.DataPropertyName = "celSolU";
            this.celSolUDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celSolUDataGridViewTextBoxColumn.Name = "celSolUDataGridViewTextBoxColumn";
            this.celSolUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codDepaSUDataGridViewTextBoxColumn
            // 
            this.codDepaSUDataGridViewTextBoxColumn.DataPropertyName = "CodDepaSU";
            this.codDepaSUDataGridViewTextBoxColumn.HeaderText = "Codigo Departamento";
            this.codDepaSUDataGridViewTextBoxColumn.Name = "codDepaSUDataGridViewTextBoxColumn";
            this.codDepaSUDataGridViewTextBoxColumn.ReadOnly = true;
            this.codDepaSUDataGridViewTextBoxColumn.Width = 180;
            // 
            // codUsrDataGridViewTextBoxColumn
            // 
            this.codUsrDataGridViewTextBoxColumn.DataPropertyName = "codUsr";
            this.codUsrDataGridViewTextBoxColumn.HeaderText = "Codigo Usuario";
            this.codUsrDataGridViewTextBoxColumn.Name = "codUsrDataGridViewTextBoxColumn";
            this.codUsrDataGridViewTextBoxColumn.ReadOnly = true;
            this.codUsrDataGridViewTextBoxColumn.Width = 140;
            // 
            // solUserBindingSource
            // 
            this.solUserBindingSource.DataMember = "SolUser";
            this.solUserBindingSource.DataSource = this.rEV_DataBaseDataSet;
            // 
            // rEV_DataBaseDataSet
            // 
            this.rEV_DataBaseDataSet.DataSetName = "REV_DataBaseDataSet";
            this.rEV_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.searchci.Location = new System.Drawing.Point(501, 77);
            this.searchci.Name = "searchci";
            this.searchci.Size = new System.Drawing.Size(19, 18);
            this.searchci.TabIndex = 301;
            this.searchci.UseVisualStyleBackColor = true;
            this.searchci.Click += new System.EventHandler(this.searchci_Click);
            // 
            // solUserTableAdapter
            // 
            this.solUserTableAdapter.ClearBeforeFill = true;
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
            // ShowSolUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(541, 503);
            this.Controls.Add(this.searchci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarcic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridUsr);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowSolUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de Usuarios";
            this.Load += new System.EventHandler(this.ShowSolUser_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.Button actualizar;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button editar;
        public System.Windows.Forms.Button nuevo;
        public System.Windows.Forms.Button eliminar;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox buscarcic;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridUsr;
        public System.Windows.Forms.Button searchci;
        private REV_DataBaseDataSet rEV_DataBaseDataSet;
        private System.Windows.Forms.BindingSource solUserBindingSource;
        private REV_DataBaseDataSetTableAdapters.SolUserTableAdapter solUserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSolUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciSolUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSolUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeSolUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSolUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passSolUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirSolUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexSolUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnSolUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corrSolUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telSolUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celSolUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDepaSUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUsrDataGridViewTextBoxColumn;
        public System.Windows.Forms.PrintDialog printMain;
        public System.Drawing.Printing.PrintDocument printDocx;
        public System.Windows.Forms.PrintPreviewDialog printPreview;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}