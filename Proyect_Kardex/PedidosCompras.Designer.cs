namespace Proyect_Kardex
{
    partial class PedidosCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidosCompras));
            this.tituloprod = new System.Windows.Forms.Label();
            this.codprod = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.nameprod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textemprov = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textcodprov = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ivabox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textCCU = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textcant = new System.Windows.Forms.TextBox();
            this.dataTabla = new System.Windows.Forms.DataGridView();
            this.dateTime2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkdate = new System.Windows.Forms.CheckBox();
            this.dateprod = new System.Windows.Forms.DateTimePicker();
            this.Descuentext = new System.Windows.Forms.TextBox();
            this.checkdesc = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTipedidos = new System.Windows.Forms.ToolTip(this.components);
            this.Codtab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomtab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canttab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codprovetab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCUtab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivatab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totaltab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnnovo = new System.Windows.Forms.Button();
            this.modulebuton = new System.Windows.Forms.Button();
            this.addDescuent = new System.Windows.Forms.Button();
            this.listprod = new System.Windows.Forms.Button();
            this.addprod = new System.Windows.Forms.Button();
            this.buscarprod = new System.Windows.Forms.Button();
            this.printview = new System.Windows.Forms.Button();
            this.botonprove = new System.Windows.Forms.Button();
            this.veboton = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.saveboton = new System.Windows.Forms.Button();
            this.listlow = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.editboton = new System.Windows.Forms.Button();
            this.addboton = new System.Windows.Forms.Button();
            this.elimboton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buscarprov = new System.Windows.Forms.Button();
            this.texttotal = new System.Windows.Forms.TextBox();
            this.textsub = new System.Windows.Forms.TextBox();
            this.textdesc = new System.Windows.Forms.TextBox();
            this.textivarc = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabla)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloprod
            // 
            this.tituloprod.AutoSize = true;
            this.tituloprod.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloprod.Location = new System.Drawing.Point(12, 54);
            this.tituloprod.Name = "tituloprod";
            this.tituloprod.Size = new System.Drawing.Size(124, 19);
            this.tituloprod.TabIndex = 209;
            this.tituloprod.Text = "Registrar Pedido";
            // 
            // codprod
            // 
            this.codprod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codprod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.codprod.Location = new System.Drawing.Point(89, 75);
            this.codprod.Name = "codprod";
            this.codprod.Size = new System.Drawing.Size(242, 20);
            this.codprod.TabIndex = 208;
            this.codprod.Text = "Codigo de Barras del Producto";
            this.codprod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.codprodClick);
            this.codprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numcodprod);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(39, 79);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 12);
            this.label26.TabIndex = 207;
            this.label26.Text = "Codigo";
            // 
            // nameprod
            // 
            this.nameprod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameprod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nameprod.Location = new System.Drawing.Point(89, 101);
            this.nameprod.Name = "nameprod";
            this.nameprod.Size = new System.Drawing.Size(203, 20);
            this.nameprod.TabIndex = 211;
            this.nameprod.Text = "Nombre del Producto";
            this.nameprod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nameprodClick);
            this.nameprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lettername);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 210;
            this.label1.Text = "Nombre";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buscarprov);
            this.groupBox4.Controls.Add(this.textemprov);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textcodprov);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(353, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 96);
            this.groupBox4.TabIndex = 260;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proveedor";
            // 
            // textemprov
            // 
            this.textemprov.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textemprov.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textemprov.Location = new System.Drawing.Point(20, 71);
            this.textemprov.Name = "textemprov";
            this.textemprov.Size = new System.Drawing.Size(240, 20);
            this.textemprov.TabIndex = 230;
            this.textemprov.Text = "Nombre de la Empresa del Proveedor ";
            this.textemprov.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nameproveClick);
            this.textemprov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numlettername);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 12);
            this.label15.TabIndex = 230;
            this.label15.Text = "Nombre de la Empresa";
            // 
            // textcodprov
            // 
            this.textcodprov.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcodprov.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textcodprov.Location = new System.Drawing.Point(20, 31);
            this.textcodprov.Name = "textcodprov";
            this.textcodprov.Size = new System.Drawing.Size(175, 20);
            this.textcodprov.TabIndex = 230;
            this.textcodprov.Text = "Nuevo Codigo de Registro";
            this.textcodprov.MouseClick += new System.Windows.Forms.MouseEventHandler(this.codproveClick);
            this.textcodprov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numcodprove);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 12);
            this.label14.TabIndex = 230;
            this.label14.Text = "Codigo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.ivabox);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.textCCU);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(353, 181);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 96);
            this.groupBox5.TabIndex = 261;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Precios";
            // 
            // ivabox
            // 
            this.ivabox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ivabox.FormattingEnabled = true;
            this.ivabox.Items.AddRange(new object[] {
            "Ninguno",
            "Predeterminado",
            "Impuesto en Ventas"});
            this.ivabox.Location = new System.Drawing.Point(20, 70);
            this.ivabox.Name = "ivabox";
            this.ivabox.Size = new System.Drawing.Size(175, 20);
            this.ivabox.TabIndex = 230;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 12);
            this.label18.TabIndex = 231;
            this.label18.Text = "Impuestos";
            // 
            // textCCU
            // 
            this.textCCU.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCCU.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textCCU.Location = new System.Drawing.Point(20, 31);
            this.textCCU.Name = "textCCU";
            this.textCCU.Size = new System.Drawing.Size(240, 20);
            this.textCCU.TabIndex = 231;
            this.textCCU.Text = "Ej: 20,90";
            this.textCCU.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ccuClick);
            this.textCCU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimalCCU);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 12);
            this.label16.TabIndex = 231;
            this.label16.Text = "Costo de Compra Unitario";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkdate);
            this.groupBox6.Controls.Add(this.dateprod);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.textcant);
            this.groupBox6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(16, 174);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(327, 103);
            this.groupBox6.TabIndex = 263;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Inventario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 211;
            this.label3.Text = "Cantidad";
            // 
            // textcant
            // 
            this.textcant.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcant.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textcant.Location = new System.Drawing.Point(73, 19);
            this.textcant.Name = "textcant";
            this.textcant.Size = new System.Drawing.Size(203, 20);
            this.textcant.TabIndex = 212;
            this.textcant.Text = "Número de Productos a Pedir";
            this.textcant.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cantprodClick);
            this.textcant.TextChanged += new System.EventHandler(this.textcant_TextChanged);
            this.textcant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numCant);
            // 
            // dataTabla
            // 
            this.dataTabla.AllowUserToAddRows = false;
            this.dataTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTabla.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataTabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codtab,
            this.Nomtab,
            this.Canttab,
            this.Codprovetab,
            this.datetab,
            this.CCUtab,
            this.ivatab,
            this.Totaltab});
            this.dataTabla.Location = new System.Drawing.Point(0, 319);
            this.dataTabla.Name = "dataTabla";
            this.dataTabla.ReadOnly = true;
            this.dataTabla.Size = new System.Drawing.Size(630, 163);
            this.dataTabla.TabIndex = 298;
            this.dataTabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTabla_CellClick);
            // 
            // dateTime2
            // 
            this.dateTime2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime2.Location = new System.Drawing.Point(89, 146);
            this.dateTime2.Name = "dateTime2";
            this.dateTime2.Size = new System.Drawing.Size(203, 20);
            this.dateTime2.TabIndex = 300;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 12);
            this.label13.TabIndex = 299;
            this.label13.Text = "Fecha de Recibo";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.listprod);
            this.panel1.Controls.Add(this.addprod);
            this.panel1.Controls.Add(this.buscarprod);
            this.panel1.Controls.Add(this.printview);
            this.panel1.Controls.Add(this.botonprove);
            this.panel1.Controls.Add(this.veboton);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.saveboton);
            this.panel1.Controls.Add(this.listlow);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 51);
            this.panel1.TabIndex = 307;
            // 
            // checkdate
            // 
            this.checkdate.AutoSize = true;
            this.checkdate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkdate.Location = new System.Drawing.Point(6, 52);
            this.checkdate.Name = "checkdate";
            this.checkdate.Size = new System.Drawing.Size(140, 16);
            this.checkdate.TabIndex = 248;
            this.checkdate.Text = "Fecha de Vencimiento";
            this.checkdate.UseVisualStyleBackColor = true;
            this.checkdate.CheckedChanged += new System.EventHandler(this.checkdate_CheckedChanged);
            // 
            // dateprod
            // 
            this.dateprod.Enabled = false;
            this.dateprod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateprod.Location = new System.Drawing.Point(73, 74);
            this.dateprod.Name = "dateprod";
            this.dateprod.Size = new System.Drawing.Size(203, 20);
            this.dateprod.TabIndex = 247;
            // 
            // Descuentext
            // 
            this.Descuentext.Enabled = false;
            this.Descuentext.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descuentext.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Descuentext.Location = new System.Drawing.Point(97, 490);
            this.Descuentext.MaxLength = 4;
            this.Descuentext.Name = "Descuentext";
            this.Descuentext.Size = new System.Drawing.Size(65, 20);
            this.Descuentext.TabIndex = 310;
            this.Descuentext.Text = "Ej: 15";
            this.Descuentext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.desctextClick);
            this.Descuentext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.desccoma);
            // 
            // checkdesc
            // 
            this.checkdesc.AutoSize = true;
            this.checkdesc.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkdesc.Location = new System.Drawing.Point(8, 493);
            this.checkdesc.Name = "checkdesc";
            this.checkdesc.Size = new System.Drawing.Size(84, 16);
            this.checkdesc.TabIndex = 311;
            this.checkdesc.Text = "Descuento:";
            this.checkdesc.UseVisualStyleBackColor = true;
            this.checkdesc.CheckedChanged += new System.EventHandler(this.checkdesc_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 312;
            this.label2.Text = "SubTotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 313;
            this.label4.Text = "Descuento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 314;
            this.label5.Text = "RC-IVA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(534, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 12);
            this.label6.TabIndex = 315;
            this.label6.Text = "TOTAL";
            // 
            // toolTipedidos
            // 
            this.toolTipedidos.IsBalloon = true;
            // 
            // Codtab
            // 
            this.Codtab.HeaderText = "Codigo";
            this.Codtab.Name = "Codtab";
            this.Codtab.ReadOnly = true;
            this.Codtab.Width = 120;
            // 
            // Nomtab
            // 
            this.Nomtab.HeaderText = "Nombre";
            this.Nomtab.Name = "Nomtab";
            this.Nomtab.ReadOnly = true;
            this.Nomtab.Width = 170;
            // 
            // Canttab
            // 
            this.Canttab.HeaderText = "Cantidad";
            this.Canttab.Name = "Canttab";
            this.Canttab.ReadOnly = true;
            this.Canttab.Width = 60;
            // 
            // Codprovetab
            // 
            this.Codprovetab.HeaderText = "Codigo Proveedor";
            this.Codprovetab.Name = "Codprovetab";
            this.Codprovetab.ReadOnly = true;
            this.Codprovetab.Width = 150;
            // 
            // datetab
            // 
            this.datetab.HeaderText = "Fecha de Vencimiento";
            this.datetab.Name = "datetab";
            this.datetab.ReadOnly = true;
            this.datetab.Width = 180;
            // 
            // CCUtab
            // 
            this.CCUtab.HeaderText = "Costo Unitario";
            this.CCUtab.Name = "CCUtab";
            this.CCUtab.ReadOnly = true;
            // 
            // ivatab
            // 
            this.ivatab.HeaderText = "Impuesto";
            this.ivatab.Name = "ivatab";
            this.ivatab.ReadOnly = true;
            // 
            // Totaltab
            // 
            this.Totaltab.HeaderText = "Total";
            this.Totaltab.Name = "Totaltab";
            this.Totaltab.ReadOnly = true;
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.Color.Transparent;
            this.btnnovo.BackgroundImage = global::Proyect_Kardex.Properties.Resources.newListC;
            this.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnovo.FlatAppearance.BorderSize = 0;
            this.btnnovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnnovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovo.Location = new System.Drawing.Point(441, 283);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(30, 30);
            this.btnnovo.TabIndex = 320;
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // modulebuton
            // 
            this.modulebuton.BackColor = System.Drawing.SystemColors.Window;
            this.modulebuton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.percentage;
            this.modulebuton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modulebuton.Enabled = false;
            this.modulebuton.FlatAppearance.BorderSize = 0;
            this.modulebuton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.modulebuton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.modulebuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modulebuton.Location = new System.Drawing.Point(142, 491);
            this.modulebuton.Name = "modulebuton";
            this.modulebuton.Size = new System.Drawing.Size(19, 18);
            this.modulebuton.TabIndex = 308;
            this.modulebuton.UseVisualStyleBackColor = false;
            // 
            // addDescuent
            // 
            this.addDescuent.BackgroundImage = global::Proyect_Kardex.Properties.Resources.add_discount;
            this.addDescuent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addDescuent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDescuent.Enabled = false;
            this.addDescuent.FlatAppearance.BorderSize = 0;
            this.addDescuent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addDescuent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.addDescuent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDescuent.Location = new System.Drawing.Point(168, 488);
            this.addDescuent.Name = "addDescuent";
            this.addDescuent.Size = new System.Drawing.Size(23, 23);
            this.addDescuent.TabIndex = 309;
            this.addDescuent.UseVisualStyleBackColor = true;
            this.addDescuent.Click += new System.EventHandler(this.addDescuent_Click);
            // 
            // listprod
            // 
            this.listprod.BackColor = System.Drawing.Color.Transparent;
            this.listprod.BackgroundImage = global::Proyect_Kardex.Properties.Resources.listProduct;
            this.listprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listprod.FlatAppearance.BorderSize = 0;
            this.listprod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.listprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.listprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listprod.Location = new System.Drawing.Point(225, 5);
            this.listprod.Name = "listprod";
            this.listprod.Size = new System.Drawing.Size(40, 40);
            this.listprod.TabIndex = 309;
            this.listprod.UseVisualStyleBackColor = false;
            this.listprod.Click += new System.EventHandler(this.listprod_Click);
            // 
            // addprod
            // 
            this.addprod.BackColor = System.Drawing.Color.Transparent;
            this.addprod.BackgroundImage = global::Proyect_Kardex.Properties.Resources.Package_add;
            this.addprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addprod.FlatAppearance.BorderSize = 0;
            this.addprod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.addprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addprod.Location = new System.Drawing.Point(373, 5);
            this.addprod.Name = "addprod";
            this.addprod.Size = new System.Drawing.Size(40, 40);
            this.addprod.TabIndex = 308;
            this.addprod.UseVisualStyleBackColor = false;
            this.addprod.Click += new System.EventHandler(this.addprod_Click);
            // 
            // buscarprod
            // 
            this.buscarprod.BackColor = System.Drawing.Color.Transparent;
            this.buscarprod.BackgroundImage = global::Proyect_Kardex.Properties.Resources.search_good_512;
            this.buscarprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarprod.FlatAppearance.BorderSize = 0;
            this.buscarprod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buscarprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buscarprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarprod.Location = new System.Drawing.Point(441, 5);
            this.buscarprod.Name = "buscarprod";
            this.buscarprod.Size = new System.Drawing.Size(40, 40);
            this.buscarprod.TabIndex = 307;
            this.buscarprod.UseVisualStyleBackColor = false;
            this.buscarprod.Click += new System.EventHandler(this.buscarprod_Click);
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
            this.printview.Location = new System.Drawing.Point(326, 5);
            this.printview.Name = "printview";
            this.printview.Size = new System.Drawing.Size(20, 20);
            this.printview.TabIndex = 294;
            this.printview.UseVisualStyleBackColor = false;
            // 
            // botonprove
            // 
            this.botonprove.BackColor = System.Drawing.Color.Transparent;
            this.botonprove.BackgroundImage = global::Proyect_Kardex.Properties.Resources.listProve;
            this.botonprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonprove.FlatAppearance.BorderSize = 0;
            this.botonprove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonprove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.botonprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonprove.Location = new System.Drawing.Point(155, 5);
            this.botonprove.Name = "botonprove";
            this.botonprove.Size = new System.Drawing.Size(40, 40);
            this.botonprove.TabIndex = 230;
            this.botonprove.UseVisualStyleBackColor = false;
            this.botonprove.Click += new System.EventHandler(this.botonprove_Click);
            // 
            // veboton
            // 
            this.veboton.BackColor = System.Drawing.Color.Transparent;
            this.veboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.Loop_512;
            this.veboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.veboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.veboton.FlatAppearance.BorderSize = 0;
            this.veboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.veboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.veboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.veboton.Location = new System.Drawing.Point(89, 5);
            this.veboton.Name = "veboton";
            this.veboton.Size = new System.Drawing.Size(40, 40);
            this.veboton.TabIndex = 306;
            this.veboton.UseVisualStyleBackColor = false;
            this.veboton.Click += new System.EventHandler(this.veboton_Click);
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
            this.print.Location = new System.Drawing.Point(299, 5);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(40, 40);
            this.print.TabIndex = 292;
            this.print.UseVisualStyleBackColor = false;
            // 
            // saveboton
            // 
            this.saveboton.BackColor = System.Drawing.Color.Transparent;
            this.saveboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save_all;
            this.saveboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveboton.FlatAppearance.BorderSize = 0;
            this.saveboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.saveboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveboton.Location = new System.Drawing.Point(508, 5);
            this.saveboton.Name = "saveboton";
            this.saveboton.Size = new System.Drawing.Size(40, 40);
            this.saveboton.TabIndex = 304;
            this.saveboton.UseVisualStyleBackColor = false;
            // 
            // listlow
            // 
            this.listlow.BackColor = System.Drawing.Color.Transparent;
            this.listlow.BackgroundImage = global::Proyect_Kardex.Properties.Resources.docxListLow;
            this.listlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listlow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listlow.FlatAppearance.BorderSize = 0;
            this.listlow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.listlow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.listlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listlow.Location = new System.Drawing.Point(16, 5);
            this.listlow.Name = "listlow";
            this.listlow.Size = new System.Drawing.Size(40, 40);
            this.listlow.TabIndex = 243;
            this.listlow.UseVisualStyleBackColor = false;
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
            this.salir.Location = new System.Drawing.Point(572, 5);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(40, 40);
            this.salir.TabIndex = 251;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // editboton
            // 
            this.editboton.BackColor = System.Drawing.Color.Transparent;
            this.editboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editListC;
            this.editboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editboton.Enabled = false;
            this.editboton.FlatAppearance.BorderSize = 0;
            this.editboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.editboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editboton.Location = new System.Drawing.Point(251, 283);
            this.editboton.Name = "editboton";
            this.editboton.Size = new System.Drawing.Size(30, 30);
            this.editboton.TabIndex = 303;
            this.editboton.UseVisualStyleBackColor = false;
            this.editboton.Click += new System.EventHandler(this.editboton_Click);
            // 
            // addboton
            // 
            this.addboton.BackColor = System.Drawing.Color.Transparent;
            this.addboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.addListC;
            this.addboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addboton.FlatAppearance.BorderSize = 0;
            this.addboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.addboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addboton.Location = new System.Drawing.Point(146, 283);
            this.addboton.Name = "addboton";
            this.addboton.Size = new System.Drawing.Size(30, 30);
            this.addboton.TabIndex = 302;
            this.addboton.UseVisualStyleBackColor = false;
            this.addboton.Click += new System.EventHandler(this.addboton_Click);
            // 
            // elimboton
            // 
            this.elimboton.BackColor = System.Drawing.Color.Transparent;
            this.elimboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.delListC;
            this.elimboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elimboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elimboton.Enabled = false;
            this.elimboton.FlatAppearance.BorderSize = 0;
            this.elimboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.elimboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.elimboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elimboton.Location = new System.Drawing.Point(340, 283);
            this.elimboton.Name = "elimboton";
            this.elimboton.Size = new System.Drawing.Size(30, 30);
            this.elimboton.TabIndex = 301;
            this.elimboton.UseVisualStyleBackColor = false;
            this.elimboton.Click += new System.EventHandler(this.elimboton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.BackgroundImage = global::Proyect_Kardex.Properties.Resources.bolivia_boliviano;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(240, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(19, 18);
            this.button5.TabIndex = 232;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // buscarprov
            // 
            this.buscarprov.BackColor = System.Drawing.SystemColors.Menu;
            this.buscarprov.BackgroundImage = global::Proyect_Kardex.Properties.Resources.lupa;
            this.buscarprov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarprov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarprov.FlatAppearance.BorderSize = 0;
            this.buscarprov.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buscarprov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buscarprov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarprov.Location = new System.Drawing.Point(175, 32);
            this.buscarprov.Name = "buscarprov";
            this.buscarprov.Size = new System.Drawing.Size(19, 18);
            this.buscarprov.TabIndex = 242;
            this.buscarprov.UseVisualStyleBackColor = false;
            this.buscarprov.Click += new System.EventHandler(this.buscarprov_Click);
            // 
            // texttotal
            // 
            this.texttotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.texttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texttotal.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttotal.ForeColor = System.Drawing.Color.Crimson;
            this.texttotal.Location = new System.Drawing.Point(528, 506);
            this.texttotal.Name = "texttotal";
            this.texttotal.Size = new System.Drawing.Size(102, 16);
            this.texttotal.TabIndex = 233;
            this.texttotal.Text = "0,00";
            // 
            // textsub
            // 
            this.textsub.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textsub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textsub.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsub.ForeColor = System.Drawing.Color.Maroon;
            this.textsub.Location = new System.Drawing.Point(230, 506);
            this.textsub.MaxLength = 3;
            this.textsub.Name = "textsub";
            this.textsub.Size = new System.Drawing.Size(75, 14);
            this.textsub.TabIndex = 321;
            this.textsub.Text = "0,00";
            // 
            // textdesc
            // 
            this.textdesc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textdesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textdesc.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdesc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textdesc.Location = new System.Drawing.Point(344, 505);
            this.textdesc.MaxLength = 3;
            this.textdesc.Name = "textdesc";
            this.textdesc.Size = new System.Drawing.Size(65, 14);
            this.textdesc.TabIndex = 322;
            this.textdesc.Text = "0,00";
            // 
            // textivarc
            // 
            this.textivarc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textivarc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textivarc.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textivarc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textivarc.Location = new System.Drawing.Point(441, 505);
            this.textivarc.MaxLength = 3;
            this.textivarc.Name = "textivarc";
            this.textivarc.Size = new System.Drawing.Size(65, 14);
            this.textivarc.TabIndex = 323;
            this.textivarc.Text = "0,00";
            // 
            // PedidosCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(630, 527);
            this.Controls.Add(this.textivarc);
            this.Controls.Add(this.textdesc);
            this.Controls.Add(this.textsub);
            this.Controls.Add(this.texttotal);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkdesc);
            this.Controls.Add(this.modulebuton);
            this.Controls.Add(this.addDescuent);
            this.Controls.Add(this.Descuentext);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editboton);
            this.Controls.Add(this.addboton);
            this.Controls.Add(this.elimboton);
            this.Controls.Add(this.dateTime2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataTabla);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.nameprod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tituloprod);
            this.Controls.Add(this.codprod);
            this.Controls.Add(this.label26);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PedidosCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label tituloprod;
        public System.Windows.Forms.TextBox codprod;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.TextBox nameprod;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Button buscarprov;
        public System.Windows.Forms.Button botonprove;
        public System.Windows.Forms.TextBox textemprov;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox textcodprov;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.ComboBox ivabox;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox textCCU;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textcant;
        public System.Windows.Forms.DataGridView dataTabla;
        public System.Windows.Forms.DateTimePicker dateTime2;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button listlow;
        public System.Windows.Forms.Button editboton;
        public System.Windows.Forms.Button addboton;
        public System.Windows.Forms.Button elimboton;
        public System.Windows.Forms.Button veboton;
        public System.Windows.Forms.Button saveboton;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button salir;
        public System.Windows.Forms.Button addprod;
        public System.Windows.Forms.Button buscarprod;
        public System.Windows.Forms.CheckBox checkdate;
        public System.Windows.Forms.DateTimePicker dateprod;
        public System.Windows.Forms.Button addDescuent;
        public System.Windows.Forms.TextBox Descuentext;
        public System.Windows.Forms.CheckBox checkdesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button listprod;
        private System.Windows.Forms.Button modulebuton;
        public System.Windows.Forms.ToolTip toolTipedidos;
        public System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codtab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomtab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canttab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codprovetab;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetab;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCUtab;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivatab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totaltab;
        public System.Windows.Forms.TextBox texttotal;
        public System.Windows.Forms.TextBox textsub;
        public System.Windows.Forms.TextBox textdesc;
        public System.Windows.Forms.TextBox textivarc;
    }
}