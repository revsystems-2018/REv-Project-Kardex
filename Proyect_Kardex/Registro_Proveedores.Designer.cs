namespace Proyect_Kardex
{
    partial class Registro_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Proveedores));
            this.dataGridProve = new System.Windows.Forms.DataGridView();
            this.codProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corrProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameEmpProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telEmpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celEmpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxEmpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoProveDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.fcProveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDepaPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEV_DataBaseDataSet = new Proyect_Kardex.REV_DataBaseDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printview = new System.Windows.Forms.Button();
            this.verbtn = new System.Windows.Forms.Button();
            this.botonselect = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.toolRegProve = new System.Windows.Forms.ToolTip(this.components);
            this.proveedoresTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.ProveedoresTableAdapter();
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridProve
            // 
            this.dataGridProve.AllowUserToAddRows = false;
            this.dataGridProve.AllowUserToDeleteRows = false;
            this.dataGridProve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProve.AutoGenerateColumns = false;
            this.dataGridProve.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridProve.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProveDataGridViewTextBoxColumn,
            this.ciProveDataGridViewTextBoxColumn,
            this.nomProveDataGridViewTextBoxColumn,
            this.apeProveDataGridViewTextBoxColumn,
            this.sexProveDataGridViewTextBoxColumn,
            this.fnProveDataGridViewTextBoxColumn,
            this.telProveDataGridViewTextBoxColumn,
            this.celProveDataGridViewTextBoxColumn,
            this.corrProveDataGridViewTextBoxColumn,
            this.webProveDataGridViewTextBoxColumn,
            this.dirProveDataGridViewTextBoxColumn,
            this.formPayDataGridViewTextBoxColumn,
            this.estadoProveDataGridViewTextBoxColumn,
            this.nitProveDataGridViewTextBoxColumn,
            this.nameEmpProveDataGridViewTextBoxColumn,
            this.telEmpDataGridViewTextBoxColumn,
            this.celEmpDataGridViewTextBoxColumn,
            this.faxEmpDataGridViewTextBoxColumn,
            this.logoProveDataGridViewImageColumn,
            this.fcProveDataGridViewTextBoxColumn,
            this.codDepaPDataGridViewTextBoxColumn});
            this.dataGridProve.DataSource = this.proveedoresBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProve.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProve.Location = new System.Drawing.Point(0, 51);
            this.dataGridProve.Name = "dataGridProve";
            this.dataGridProve.ReadOnly = true;
            this.dataGridProve.Size = new System.Drawing.Size(568, 444);
            this.dataGridProve.TabIndex = 299;
            this.dataGridProve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProve_CellClick);
            // 
            // codProveDataGridViewTextBoxColumn
            // 
            this.codProveDataGridViewTextBoxColumn.DataPropertyName = "codProve";
            this.codProveDataGridViewTextBoxColumn.HeaderText = "Codigo Registro";
            this.codProveDataGridViewTextBoxColumn.Name = "codProveDataGridViewTextBoxColumn";
            this.codProveDataGridViewTextBoxColumn.ReadOnly = true;
            this.codProveDataGridViewTextBoxColumn.Width = 130;
            // 
            // ciProveDataGridViewTextBoxColumn
            // 
            this.ciProveDataGridViewTextBoxColumn.DataPropertyName = "ciProve";
            this.ciProveDataGridViewTextBoxColumn.HeaderText = "Carnet Identidad";
            this.ciProveDataGridViewTextBoxColumn.Name = "ciProveDataGridViewTextBoxColumn";
            this.ciProveDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciProveDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomProveDataGridViewTextBoxColumn
            // 
            this.nomProveDataGridViewTextBoxColumn.DataPropertyName = "nomProve";
            this.nomProveDataGridViewTextBoxColumn.HeaderText = "Nombres Supervisor";
            this.nomProveDataGridViewTextBoxColumn.Name = "nomProveDataGridViewTextBoxColumn";
            this.nomProveDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomProveDataGridViewTextBoxColumn.Width = 150;
            // 
            // apeProveDataGridViewTextBoxColumn
            // 
            this.apeProveDataGridViewTextBoxColumn.DataPropertyName = "apeProve";
            this.apeProveDataGridViewTextBoxColumn.HeaderText = "Apellidos Supervisor";
            this.apeProveDataGridViewTextBoxColumn.Name = "apeProveDataGridViewTextBoxColumn";
            this.apeProveDataGridViewTextBoxColumn.ReadOnly = true;
            this.apeProveDataGridViewTextBoxColumn.Width = 150;
            // 
            // sexProveDataGridViewTextBoxColumn
            // 
            this.sexProveDataGridViewTextBoxColumn.DataPropertyName = "sexProve";
            this.sexProveDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexProveDataGridViewTextBoxColumn.Name = "sexProveDataGridViewTextBoxColumn";
            this.sexProveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnProveDataGridViewTextBoxColumn
            // 
            this.fnProveDataGridViewTextBoxColumn.DataPropertyName = "fnProve";
            this.fnProveDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento";
            this.fnProveDataGridViewTextBoxColumn.Name = "fnProveDataGridViewTextBoxColumn";
            this.fnProveDataGridViewTextBoxColumn.ReadOnly = true;
            this.fnProveDataGridViewTextBoxColumn.Width = 150;
            // 
            // telProveDataGridViewTextBoxColumn
            // 
            this.telProveDataGridViewTextBoxColumn.DataPropertyName = "telProve";
            this.telProveDataGridViewTextBoxColumn.HeaderText = "Télefono Supervisor";
            this.telProveDataGridViewTextBoxColumn.Name = "telProveDataGridViewTextBoxColumn";
            this.telProveDataGridViewTextBoxColumn.ReadOnly = true;
            this.telProveDataGridViewTextBoxColumn.Width = 160;
            // 
            // celProveDataGridViewTextBoxColumn
            // 
            this.celProveDataGridViewTextBoxColumn.DataPropertyName = "celProve";
            this.celProveDataGridViewTextBoxColumn.HeaderText = "Celular Supervisor";
            this.celProveDataGridViewTextBoxColumn.Name = "celProveDataGridViewTextBoxColumn";
            this.celProveDataGridViewTextBoxColumn.ReadOnly = true;
            this.celProveDataGridViewTextBoxColumn.Width = 150;
            // 
            // corrProveDataGridViewTextBoxColumn
            // 
            this.corrProveDataGridViewTextBoxColumn.DataPropertyName = "corrProve";
            this.corrProveDataGridViewTextBoxColumn.HeaderText = "Correo Electrónico";
            this.corrProveDataGridViewTextBoxColumn.Name = "corrProveDataGridViewTextBoxColumn";
            this.corrProveDataGridViewTextBoxColumn.ReadOnly = true;
            this.corrProveDataGridViewTextBoxColumn.Width = 160;
            // 
            // webProveDataGridViewTextBoxColumn
            // 
            this.webProveDataGridViewTextBoxColumn.DataPropertyName = "webProve";
            this.webProveDataGridViewTextBoxColumn.HeaderText = "Pagina Web";
            this.webProveDataGridViewTextBoxColumn.Name = "webProveDataGridViewTextBoxColumn";
            this.webProveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dirProveDataGridViewTextBoxColumn
            // 
            this.dirProveDataGridViewTextBoxColumn.DataPropertyName = "DirProve";
            this.dirProveDataGridViewTextBoxColumn.HeaderText = "Ubicación";
            this.dirProveDataGridViewTextBoxColumn.Name = "dirProveDataGridViewTextBoxColumn";
            this.dirProveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formPayDataGridViewTextBoxColumn
            // 
            this.formPayDataGridViewTextBoxColumn.DataPropertyName = "formPay";
            this.formPayDataGridViewTextBoxColumn.HeaderText = "Forma de Pago";
            this.formPayDataGridViewTextBoxColumn.Name = "formPayDataGridViewTextBoxColumn";
            this.formPayDataGridViewTextBoxColumn.ReadOnly = true;
            this.formPayDataGridViewTextBoxColumn.Width = 130;
            // 
            // estadoProveDataGridViewTextBoxColumn
            // 
            this.estadoProveDataGridViewTextBoxColumn.DataPropertyName = "estadoProve";
            this.estadoProveDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoProveDataGridViewTextBoxColumn.Name = "estadoProveDataGridViewTextBoxColumn";
            this.estadoProveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nitProveDataGridViewTextBoxColumn
            // 
            this.nitProveDataGridViewTextBoxColumn.DataPropertyName = "nitProve";
            this.nitProveDataGridViewTextBoxColumn.HeaderText = "Número de NIT";
            this.nitProveDataGridViewTextBoxColumn.Name = "nitProveDataGridViewTextBoxColumn";
            this.nitProveDataGridViewTextBoxColumn.ReadOnly = true;
            this.nitProveDataGridViewTextBoxColumn.Width = 130;
            // 
            // nameEmpProveDataGridViewTextBoxColumn
            // 
            this.nameEmpProveDataGridViewTextBoxColumn.DataPropertyName = "nameEmpProve";
            this.nameEmpProveDataGridViewTextBoxColumn.HeaderText = "Nombre Empresa";
            this.nameEmpProveDataGridViewTextBoxColumn.Name = "nameEmpProveDataGridViewTextBoxColumn";
            this.nameEmpProveDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameEmpProveDataGridViewTextBoxColumn.Width = 130;
            // 
            // telEmpDataGridViewTextBoxColumn
            // 
            this.telEmpDataGridViewTextBoxColumn.DataPropertyName = "telEmp";
            this.telEmpDataGridViewTextBoxColumn.HeaderText = "Télefono";
            this.telEmpDataGridViewTextBoxColumn.Name = "telEmpDataGridViewTextBoxColumn";
            this.telEmpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celEmpDataGridViewTextBoxColumn
            // 
            this.celEmpDataGridViewTextBoxColumn.DataPropertyName = "CelEmp";
            this.celEmpDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celEmpDataGridViewTextBoxColumn.Name = "celEmpDataGridViewTextBoxColumn";
            this.celEmpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxEmpDataGridViewTextBoxColumn
            // 
            this.faxEmpDataGridViewTextBoxColumn.DataPropertyName = "faxEmp";
            this.faxEmpDataGridViewTextBoxColumn.HeaderText = "NúmeroFax";
            this.faxEmpDataGridViewTextBoxColumn.Name = "faxEmpDataGridViewTextBoxColumn";
            this.faxEmpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logoProveDataGridViewImageColumn
            // 
            this.logoProveDataGridViewImageColumn.DataPropertyName = "logoProve";
            this.logoProveDataGridViewImageColumn.HeaderText = "Logotipo";
            this.logoProveDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.logoProveDataGridViewImageColumn.Name = "logoProveDataGridViewImageColumn";
            this.logoProveDataGridViewImageColumn.ReadOnly = true;
            this.logoProveDataGridViewImageColumn.Visible = false;
            // 
            // fcProveDataGridViewTextBoxColumn
            // 
            this.fcProveDataGridViewTextBoxColumn.DataPropertyName = "fcProve";
            this.fcProveDataGridViewTextBoxColumn.HeaderText = "Fecha Creación";
            this.fcProveDataGridViewTextBoxColumn.Name = "fcProveDataGridViewTextBoxColumn";
            this.fcProveDataGridViewTextBoxColumn.ReadOnly = true;
            this.fcProveDataGridViewTextBoxColumn.Width = 130;
            // 
            // codDepaPDataGridViewTextBoxColumn
            // 
            this.codDepaPDataGridViewTextBoxColumn.DataPropertyName = "CodDepaP";
            this.codDepaPDataGridViewTextBoxColumn.HeaderText = "Codigo Departamento";
            this.codDepaPDataGridViewTextBoxColumn.Name = "codDepaPDataGridViewTextBoxColumn";
            this.codDepaPDataGridViewTextBoxColumn.ReadOnly = true;
            this.codDepaPDataGridViewTextBoxColumn.Width = 190;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.rEV_DataBaseDataSet;
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
            this.panel1.Controls.Add(this.verbtn);
            this.panel1.Controls.Add(this.botonselect);
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
            this.panel1.TabIndex = 298;
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
            this.printview.Location = new System.Drawing.Point(402, 4);
            this.printview.Name = "printview";
            this.printview.Size = new System.Drawing.Size(20, 20);
            this.printview.TabIndex = 8;
            this.printview.UseVisualStyleBackColor = false;
            this.printview.Click += new System.EventHandler(this.printview_Click);
            // 
            // verbtn
            // 
            this.verbtn.BackColor = System.Drawing.Color.Transparent;
            this.verbtn.BackgroundImage = global::Proyect_Kardex.Properties.Resources.seeProve;
            this.verbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verbtn.FlatAppearance.BorderSize = 0;
            this.verbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.verbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.verbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verbtn.Location = new System.Drawing.Point(254, 5);
            this.verbtn.Name = "verbtn";
            this.verbtn.Size = new System.Drawing.Size(40, 40);
            this.verbtn.TabIndex = 5;
            this.verbtn.UseVisualStyleBackColor = false;
            this.verbtn.Click += new System.EventHandler(this.button1_Click);
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
            this.botonselect.TabIndex = 1;
            this.botonselect.UseVisualStyleBackColor = false;
            this.botonselect.Click += new System.EventHandler(this.botonselect_Click);
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
            this.actualizar.Location = new System.Drawing.Point(313, 5);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(40, 40);
            this.actualizar.TabIndex = 6;
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
            this.print.Location = new System.Drawing.Point(374, 5);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(40, 40);
            this.print.TabIndex = 7;
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
            this.editar.Location = new System.Drawing.Point(127, 5);
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
            this.nuevo.Location = new System.Drawing.Point(77, 5);
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
            this.eliminar.Location = new System.Drawing.Point(177, 5);
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
            this.save.Location = new System.Drawing.Point(453, 5);
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
            this.salir.Location = new System.Drawing.Point(517, 5);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(40, 40);
            this.salir.TabIndex = 10;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
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
            // Registro_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(569, 496);
            this.Controls.Add(this.dataGridProve);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Proveedores";
            this.Load += new System.EventHandler(this.Registro_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridProve;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button actualizar;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button editar;
        public System.Windows.Forms.Button nuevo;
        public System.Windows.Forms.Button eliminar;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button salir;
        public System.Windows.Forms.ToolTip toolRegProve;
        public System.Windows.Forms.Button botonselect;
        private REV_DataBaseDataSet rEV_DataBaseDataSet;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private REV_DataBaseDataSetTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        public System.Windows.Forms.Button verbtn;
        public System.Windows.Forms.Button printview;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corrProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameEmpProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telEmpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celEmpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxEmpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn logoProveDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcProveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDepaPDataGridViewTextBoxColumn;
        public System.Windows.Forms.PrintDialog printMain;
        public System.Drawing.Printing.PrintDocument printDocx;
        public System.Windows.Forms.PrintPreviewDialog printPreview;
    }
}