namespace Proyect_Kardex
{
    partial class Registro_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Clientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonselect = new System.Windows.Forms.Button();
            this.printview = new System.Windows.Forms.Button();
            this.verbtn = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoClienteDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.fidepuntosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDepaCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEV_DataBaseDataSet = new Proyect_Kardex.REV_DataBaseDataSet();
            this.toolRegClient = new System.Windows.Forms.ToolTip(this.components);
            this.clientesTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.ClientesTableAdapter();
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.botonselect);
            this.panel1.Controls.Add(this.printview);
            this.panel1.Controls.Add(this.verbtn);
            this.panel1.Controls.Add(this.actualizar);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.nuevo);
            this.panel1.Controls.Add(this.eliminar);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 51);
            this.panel1.TabIndex = 296;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.botonselect.Location = new System.Drawing.Point(12, 5);
            this.botonselect.Name = "botonselect";
            this.botonselect.Size = new System.Drawing.Size(40, 40);
            this.botonselect.TabIndex = 298;
            this.botonselect.UseVisualStyleBackColor = false;
            this.botonselect.Click += new System.EventHandler(this.botonselect_Click);
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
            this.printview.Location = new System.Drawing.Point(400, 4);
            this.printview.Name = "printview";
            this.printview.Size = new System.Drawing.Size(20, 20);
            this.printview.TabIndex = 296;
            this.printview.UseVisualStyleBackColor = false;
            this.printview.Click += new System.EventHandler(this.printview_Click);
            // 
            // verbtn
            // 
            this.verbtn.BackColor = System.Drawing.Color.Transparent;
            this.verbtn.BackgroundImage = global::Proyect_Kardex.Properties.Resources.seeCliente;
            this.verbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verbtn.FlatAppearance.BorderSize = 0;
            this.verbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.verbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.verbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verbtn.Location = new System.Drawing.Point(245, 5);
            this.verbtn.Name = "verbtn";
            this.verbtn.Size = new System.Drawing.Size(40, 40);
            this.verbtn.TabIndex = 294;
            this.verbtn.UseVisualStyleBackColor = false;
            this.verbtn.Click += new System.EventHandler(this.button1_Click);
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
            this.actualizar.Location = new System.Drawing.Point(308, 5);
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
            this.print.Location = new System.Drawing.Point(373, 5);
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
            this.editar.Location = new System.Drawing.Point(122, 5);
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
            this.nuevo.Location = new System.Drawing.Point(73, 5);
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
            this.eliminar.Location = new System.Drawing.Point(171, 5);
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
            this.save.Location = new System.Drawing.Point(454, 5);
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
            this.salir.Location = new System.Drawing.Point(517, 5);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(40, 40);
            this.salir.TabIndex = 251;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.idClienteDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.apellidoClienteDataGridViewTextBoxColumn,
            this.nitClienteDataGridViewTextBoxColumn,
            this.correoClienteDataGridViewTextBoxColumn,
            this.webClienteDataGridViewTextBoxColumn,
            this.dirClienteDataGridViewTextBoxColumn,
            this.sexoClienteDataGridViewTextBoxColumn,
            this.telClienteDataGridViewTextBoxColumn,
            this.celClienteDataGridViewTextBoxColumn,
            this.faxClienteDataGridViewTextBoxColumn,
            this.fnClienteDataGridViewTextBoxColumn,
            this.fcClienteDataGridViewTextBoxColumn,
            this.fotoClienteDataGridViewImageColumn,
            this.fidepuntosDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.codDepaCDataGridViewTextBoxColumn});
            this.dataGridClientes.DataSource = this.clientesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridClientes.Location = new System.Drawing.Point(0, 51);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.Size = new System.Drawing.Size(569, 442);
            this.dataGridClientes.TabIndex = 297;
            this.dataGridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellClick);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "Carnet Identidad";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "nombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoClienteDataGridViewTextBoxColumn
            // 
            this.apellidoClienteDataGridViewTextBoxColumn.DataPropertyName = "apellidoCliente";
            this.apellidoClienteDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidoClienteDataGridViewTextBoxColumn.Name = "apellidoClienteDataGridViewTextBoxColumn";
            this.apellidoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nitClienteDataGridViewTextBoxColumn
            // 
            this.nitClienteDataGridViewTextBoxColumn.DataPropertyName = "nitCliente";
            this.nitClienteDataGridViewTextBoxColumn.HeaderText = "Número NIT";
            this.nitClienteDataGridViewTextBoxColumn.Name = "nitClienteDataGridViewTextBoxColumn";
            this.nitClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoClienteDataGridViewTextBoxColumn
            // 
            this.correoClienteDataGridViewTextBoxColumn.DataPropertyName = "correoCliente";
            this.correoClienteDataGridViewTextBoxColumn.HeaderText = "Correo Electrónico";
            this.correoClienteDataGridViewTextBoxColumn.Name = "correoClienteDataGridViewTextBoxColumn";
            this.correoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoClienteDataGridViewTextBoxColumn.Width = 160;
            // 
            // webClienteDataGridViewTextBoxColumn
            // 
            this.webClienteDataGridViewTextBoxColumn.DataPropertyName = "webCliente";
            this.webClienteDataGridViewTextBoxColumn.HeaderText = "Pagina Web";
            this.webClienteDataGridViewTextBoxColumn.Name = "webClienteDataGridViewTextBoxColumn";
            this.webClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dirClienteDataGridViewTextBoxColumn
            // 
            this.dirClienteDataGridViewTextBoxColumn.DataPropertyName = "DirCliente";
            this.dirClienteDataGridViewTextBoxColumn.HeaderText = "Ubicación";
            this.dirClienteDataGridViewTextBoxColumn.Name = "dirClienteDataGridViewTextBoxColumn";
            this.dirClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoClienteDataGridViewTextBoxColumn
            // 
            this.sexoClienteDataGridViewTextBoxColumn.DataPropertyName = "sexoCliente";
            this.sexoClienteDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoClienteDataGridViewTextBoxColumn.Name = "sexoClienteDataGridViewTextBoxColumn";
            this.sexoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telClienteDataGridViewTextBoxColumn
            // 
            this.telClienteDataGridViewTextBoxColumn.DataPropertyName = "telCliente";
            this.telClienteDataGridViewTextBoxColumn.HeaderText = "Télefono";
            this.telClienteDataGridViewTextBoxColumn.Name = "telClienteDataGridViewTextBoxColumn";
            this.telClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celClienteDataGridViewTextBoxColumn
            // 
            this.celClienteDataGridViewTextBoxColumn.DataPropertyName = "celCliente";
            this.celClienteDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celClienteDataGridViewTextBoxColumn.Name = "celClienteDataGridViewTextBoxColumn";
            this.celClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxClienteDataGridViewTextBoxColumn
            // 
            this.faxClienteDataGridViewTextBoxColumn.DataPropertyName = "faxCliente";
            this.faxClienteDataGridViewTextBoxColumn.HeaderText = "Número Fax";
            this.faxClienteDataGridViewTextBoxColumn.Name = "faxClienteDataGridViewTextBoxColumn";
            this.faxClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnClienteDataGridViewTextBoxColumn
            // 
            this.fnClienteDataGridViewTextBoxColumn.DataPropertyName = "fnCliente";
            this.fnClienteDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento";
            this.fnClienteDataGridViewTextBoxColumn.Name = "fnClienteDataGridViewTextBoxColumn";
            this.fnClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.fnClienteDataGridViewTextBoxColumn.Width = 160;
            // 
            // fcClienteDataGridViewTextBoxColumn
            // 
            this.fcClienteDataGridViewTextBoxColumn.DataPropertyName = "fcCliente";
            this.fcClienteDataGridViewTextBoxColumn.HeaderText = "Fecha Creación";
            this.fcClienteDataGridViewTextBoxColumn.Name = "fcClienteDataGridViewTextBoxColumn";
            this.fcClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.fcClienteDataGridViewTextBoxColumn.Width = 120;
            // 
            // fotoClienteDataGridViewImageColumn
            // 
            this.fotoClienteDataGridViewImageColumn.DataPropertyName = "fotoCliente";
            this.fotoClienteDataGridViewImageColumn.HeaderText = "Fotografia";
            this.fotoClienteDataGridViewImageColumn.Name = "fotoClienteDataGridViewImageColumn";
            this.fotoClienteDataGridViewImageColumn.ReadOnly = true;
            this.fotoClienteDataGridViewImageColumn.Visible = false;
            // 
            // fidepuntosDataGridViewTextBoxColumn
            // 
            this.fidepuntosDataGridViewTextBoxColumn.DataPropertyName = "fidepuntos";
            this.fidepuntosDataGridViewTextBoxColumn.HeaderText = "Puntos";
            this.fidepuntosDataGridViewTextBoxColumn.Name = "fidepuntosDataGridViewTextBoxColumn";
            this.fidepuntosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codDepaCDataGridViewTextBoxColumn
            // 
            this.codDepaCDataGridViewTextBoxColumn.DataPropertyName = "CodDepaC";
            this.codDepaCDataGridViewTextBoxColumn.HeaderText = "Codigo Departamento";
            this.codDepaCDataGridViewTextBoxColumn.Name = "codDepaCDataGridViewTextBoxColumn";
            this.codDepaCDataGridViewTextBoxColumn.ReadOnly = true;
            this.codDepaCDataGridViewTextBoxColumn.Width = 180;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.rEV_DataBaseDataSet;
            // 
            // rEV_DataBaseDataSet
            // 
            this.rEV_DataBaseDataSet.DataSetName = "REV_DataBaseDataSet";
            this.rEV_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
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
            // Registro_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(569, 494);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Clientes";
            this.Load += new System.EventHandler(this.Registro_Clientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.ResumeLayout(false);

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
        public System.Windows.Forms.DataGridView dataGridClientes;
        public System.Windows.Forms.ToolTip toolRegClient;
        private REV_DataBaseDataSet rEV_DataBaseDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private REV_DataBaseDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        public System.Windows.Forms.Button verbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoClienteDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidepuntosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDepaCDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.PrintDialog printMain;
        public System.Drawing.Printing.PrintDocument printDocx;
        public System.Windows.Forms.PrintPreviewDialog printPreview;
        public System.Windows.Forms.Button botonselect;
    }
}