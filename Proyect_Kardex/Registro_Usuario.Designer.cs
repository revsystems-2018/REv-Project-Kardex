namespace Proyect_Kardex
{
    partial class Registro_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Usuario));
            this.dataGridUsr = new System.Windows.Forms.DataGridView();
            this.ciUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNaciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoUserDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.emailUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDepaUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rEV_DataBaseDataSet = new Proyect_Kardex.REV_DataBaseDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printview = new System.Windows.Forms.Button();
            this.seebtn = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.toolRegUser = new System.Windows.Forms.ToolTip(this.components);
            this.usuarioTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.TableAdapterManager();
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridUsr
            // 
            this.dataGridUsr.AllowUserToAddRows = false;
            this.dataGridUsr.AllowUserToDeleteRows = false;
            this.dataGridUsr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.ciUserDataGridViewTextBoxColumn,
            this.nombreUserDataGridViewTextBoxColumn,
            this.apeUserDataGridViewTextBoxColumn,
            this.nuUsuarioDataGridViewTextBoxColumn,
            this.contraUserDataGridViewTextBoxColumn,
            this.dirUserDataGridViewTextBoxColumn,
            this.nivelUserDataGridViewTextBoxColumn,
            this.cargoUserDataGridViewTextBoxColumn,
            this.sexoUserDataGridViewTextBoxColumn,
            this.fechaNaciDataGridViewTextBoxColumn,
            this.telUserDataGridViewTextBoxColumn,
            this.celUserDataGridViewTextBoxColumn,
            this.faxUserDataGridViewTextBoxColumn,
            this.fotoUserDataGridViewImageColumn,
            this.emailUserDataGridViewTextBoxColumn,
            this.idUserDataGridViewTextBoxColumn,
            this.codDepaUDataGridViewTextBoxColumn});
            this.dataGridUsr.DataSource = this.usuarioBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsr.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsr.Location = new System.Drawing.Point(0, 51);
            this.dataGridUsr.Name = "dataGridUsr";
            this.dataGridUsr.ReadOnly = true;
            this.dataGridUsr.Size = new System.Drawing.Size(539, 442);
            this.dataGridUsr.TabIndex = 299;
            this.dataGridUsr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ciUserDataGridViewTextBoxColumn
            // 
            this.ciUserDataGridViewTextBoxColumn.DataPropertyName = "ciUser";
            this.ciUserDataGridViewTextBoxColumn.HeaderText = "Carnet Identidad";
            this.ciUserDataGridViewTextBoxColumn.Name = "ciUserDataGridViewTextBoxColumn";
            this.ciUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciUserDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreUserDataGridViewTextBoxColumn
            // 
            this.nombreUserDataGridViewTextBoxColumn.DataPropertyName = "nombreUser";
            this.nombreUserDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombreUserDataGridViewTextBoxColumn.Name = "nombreUserDataGridViewTextBoxColumn";
            this.nombreUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apeUserDataGridViewTextBoxColumn
            // 
            this.apeUserDataGridViewTextBoxColumn.DataPropertyName = "apeUser";
            this.apeUserDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apeUserDataGridViewTextBoxColumn.Name = "apeUserDataGridViewTextBoxColumn";
            this.apeUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nuUsuarioDataGridViewTextBoxColumn
            // 
            this.nuUsuarioDataGridViewTextBoxColumn.DataPropertyName = "nuUsuario";
            this.nuUsuarioDataGridViewTextBoxColumn.HeaderText = "Nombre Usuario";
            this.nuUsuarioDataGridViewTextBoxColumn.Name = "nuUsuarioDataGridViewTextBoxColumn";
            this.nuUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nuUsuarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // contraUserDataGridViewTextBoxColumn
            // 
            this.contraUserDataGridViewTextBoxColumn.DataPropertyName = "contraUser";
            this.contraUserDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraUserDataGridViewTextBoxColumn.Name = "contraUserDataGridViewTextBoxColumn";
            this.contraUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dirUserDataGridViewTextBoxColumn
            // 
            this.dirUserDataGridViewTextBoxColumn.DataPropertyName = "DirUser";
            this.dirUserDataGridViewTextBoxColumn.HeaderText = "Ubicación";
            this.dirUserDataGridViewTextBoxColumn.Name = "dirUserDataGridViewTextBoxColumn";
            this.dirUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nivelUserDataGridViewTextBoxColumn
            // 
            this.nivelUserDataGridViewTextBoxColumn.DataPropertyName = "nivelUser";
            this.nivelUserDataGridViewTextBoxColumn.HeaderText = "Nivel Profesional";
            this.nivelUserDataGridViewTextBoxColumn.Name = "nivelUserDataGridViewTextBoxColumn";
            this.nivelUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.nivelUserDataGridViewTextBoxColumn.Width = 150;
            // 
            // cargoUserDataGridViewTextBoxColumn
            // 
            this.cargoUserDataGridViewTextBoxColumn.DataPropertyName = "cargoUser";
            this.cargoUserDataGridViewTextBoxColumn.HeaderText = "Cargo Trabajo";
            this.cargoUserDataGridViewTextBoxColumn.Name = "cargoUserDataGridViewTextBoxColumn";
            this.cargoUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargoUserDataGridViewTextBoxColumn.Width = 150;
            // 
            // sexoUserDataGridViewTextBoxColumn
            // 
            this.sexoUserDataGridViewTextBoxColumn.DataPropertyName = "sexoUser";
            this.sexoUserDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoUserDataGridViewTextBoxColumn.Name = "sexoUserDataGridViewTextBoxColumn";
            this.sexoUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNaciDataGridViewTextBoxColumn
            // 
            this.fechaNaciDataGridViewTextBoxColumn.DataPropertyName = "fechaNaci";
            this.fechaNaciDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento";
            this.fechaNaciDataGridViewTextBoxColumn.Name = "fechaNaciDataGridViewTextBoxColumn";
            this.fechaNaciDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaNaciDataGridViewTextBoxColumn.Width = 150;
            // 
            // telUserDataGridViewTextBoxColumn
            // 
            this.telUserDataGridViewTextBoxColumn.DataPropertyName = "telUser";
            this.telUserDataGridViewTextBoxColumn.HeaderText = "Télefono";
            this.telUserDataGridViewTextBoxColumn.Name = "telUserDataGridViewTextBoxColumn";
            this.telUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celUserDataGridViewTextBoxColumn
            // 
            this.celUserDataGridViewTextBoxColumn.DataPropertyName = "celUser";
            this.celUserDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celUserDataGridViewTextBoxColumn.Name = "celUserDataGridViewTextBoxColumn";
            this.celUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxUserDataGridViewTextBoxColumn
            // 
            this.faxUserDataGridViewTextBoxColumn.DataPropertyName = "faxUser";
            this.faxUserDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxUserDataGridViewTextBoxColumn.Name = "faxUserDataGridViewTextBoxColumn";
            this.faxUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fotoUserDataGridViewImageColumn
            // 
            this.fotoUserDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fotoUserDataGridViewImageColumn.DataPropertyName = "fotoUser";
            this.fotoUserDataGridViewImageColumn.HeaderText = "Fotografia";
            this.fotoUserDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.fotoUserDataGridViewImageColumn.Name = "fotoUserDataGridViewImageColumn";
            this.fotoUserDataGridViewImageColumn.ReadOnly = true;
            this.fotoUserDataGridViewImageColumn.Visible = false;
            // 
            // emailUserDataGridViewTextBoxColumn
            // 
            this.emailUserDataGridViewTextBoxColumn.DataPropertyName = "emailUser";
            this.emailUserDataGridViewTextBoxColumn.HeaderText = "Correo Electrónico";
            this.emailUserDataGridViewTextBoxColumn.Name = "emailUserDataGridViewTextBoxColumn";
            this.emailUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailUserDataGridViewTextBoxColumn.Width = 170;
            // 
            // idUserDataGridViewTextBoxColumn
            // 
            this.idUserDataGridViewTextBoxColumn.DataPropertyName = "idUser";
            this.idUserDataGridViewTextBoxColumn.HeaderText = "ID Usuario";
            this.idUserDataGridViewTextBoxColumn.Name = "idUserDataGridViewTextBoxColumn";
            this.idUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codDepaUDataGridViewTextBoxColumn
            // 
            this.codDepaUDataGridViewTextBoxColumn.DataPropertyName = "CodDepaU";
            this.codDepaUDataGridViewTextBoxColumn.HeaderText = "Codigo Departamento";
            this.codDepaUDataGridViewTextBoxColumn.Name = "codDepaUDataGridViewTextBoxColumn";
            this.codDepaUDataGridViewTextBoxColumn.ReadOnly = true;
            this.codDepaUDataGridViewTextBoxColumn.Width = 190;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this.rEV_DataBaseDataSet;
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
            this.panel1.Controls.Add(this.seebtn);
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
            this.printview.Location = new System.Drawing.Point(363, 4);
            this.printview.Name = "printview";
            this.printview.Size = new System.Drawing.Size(20, 20);
            this.printview.TabIndex = 295;
            this.printview.UseVisualStyleBackColor = false;
            this.printview.Click += new System.EventHandler(this.printview_Click);
            // 
            // seebtn
            // 
            this.seebtn.BackColor = System.Drawing.Color.Transparent;
            this.seebtn.BackgroundImage = global::Proyect_Kardex.Properties.Resources.seePerfil;
            this.seebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seebtn.FlatAppearance.BorderSize = 0;
            this.seebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.seebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.seebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seebtn.Location = new System.Drawing.Point(206, 5);
            this.seebtn.Name = "seebtn";
            this.seebtn.Size = new System.Drawing.Size(40, 40);
            this.seebtn.TabIndex = 294;
            this.seebtn.UseVisualStyleBackColor = false;
            this.seebtn.Click += new System.EventHandler(this.seebtn_Click);
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
            this.actualizar.Location = new System.Drawing.Point(271, 5);
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
            this.editar.Location = new System.Drawing.Point(79, 5);
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
            this.nuevo.Location = new System.Drawing.Point(23, 5);
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
            this.eliminar.Location = new System.Drawing.Point(133, 5);
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
            this.save.Location = new System.Drawing.Point(422, 5);
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
            this.salir.Location = new System.Drawing.Point(489, 5);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(40, 40);
            this.salir.TabIndex = 251;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.Detalle_VentaTableAdapter = null;
            this.tableAdapterManager.DetallePedidosTableAdapter = null;
            this.tableAdapterManager.EmpresaTableAdapter = null;
            this.tableAdapterManager.MarcasTableAdapter = null;
            this.tableAdapterManager.MedidasTableAdapter = null;
            this.tableAdapterManager.PedidosTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.ProvinciaTableAdapter = null;
            this.tableAdapterManager.REV_VentasTableAdapter = null;
            this.tableAdapterManager.SolClientesTableAdapter = null;
            this.tableAdapterManager.SolUserTableAdapter = null;
            this.tableAdapterManager.SubCategoriasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyect_Kardex.REV_DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
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
            this.printPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Document = this.printDocx;
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.ShowIcon = false;
            this.printPreview.Visible = false;
            // 
            // Registro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(540, 494);
            this.Controls.Add(this.dataGridUsr);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuarios";
            this.Load += new System.EventHandler(this.Registro_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridUsr;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button actualizar;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button editar;
        public System.Windows.Forms.Button nuevo;
        public System.Windows.Forms.Button eliminar;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button salir;
        public System.Windows.Forms.ToolTip toolRegUser;
        private REV_DataBaseDataSet rEV_DataBaseDataSet;
        private REV_DataBaseDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private REV_DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nuUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNaciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoUserDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDepaUDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button seebtn;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.PrintDialog printMain;
        public System.Drawing.Printing.PrintDocument printDocx;
        public System.Windows.Forms.PrintPreviewDialog printPreview;
    }
}