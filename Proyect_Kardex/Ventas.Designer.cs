namespace Proyect_Kardex
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.tituloVentas = new System.Windows.Forms.Label();
            this.buscarprod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridVentas = new System.Windows.Forms.DataGridView();
            this.CodRegProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricetotalProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.printview = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.CleanList = new System.Windows.Forms.Button();
            this.PrintFacture = new System.Windows.Forms.Button();
            this.AddSale = new System.Windows.Forms.Button();
            this.groupBoxPay = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.PayButton = new System.Windows.Forms.Button();
            this.typePayCombo = new System.Windows.Forms.ComboBox();
            this.PayText = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBoxCantPay = new System.Windows.Forms.GroupBox();
            this.CantPay = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBoxtotal = new System.Windows.Forms.GroupBox();
            this.TotalPay = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxIva = new System.Windows.Forms.GroupBox();
            this.ivaPay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxSubTotal = new System.Windows.Forms.GroupBox();
            this.SubTotalPay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxNumProd = new System.Windows.Forms.GroupBox();
            this.NumProd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listClient = new System.Windows.Forms.Button();
            this.searchprod = new System.Windows.Forms.Button();
            this.nameClient = new System.Windows.Forms.TextBox();
            this.nitciclient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DetCheck = new System.Windows.Forms.CheckBox();
            this.detText = new System.Windows.Forms.TextBox();
            this.Descuentext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modulebuton = new System.Windows.Forms.Button();
            this.addDescuent = new System.Windows.Forms.Button();
            this.enterboton = new System.Windows.Forms.Button();
            this.listProd = new System.Windows.Forms.Button();
            this.SalesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxPay.SuspendLayout();
            this.groupBoxCantPay.SuspendLayout();
            this.groupBoxtotal.SuspendLayout();
            this.groupBoxIva.SuspendLayout();
            this.groupBoxSubTotal.SuspendLayout();
            this.groupBoxNumProd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloVentas
            // 
            this.tituloVentas.AutoSize = true;
            this.tituloVentas.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloVentas.Location = new System.Drawing.Point(12, 9);
            this.tituloVentas.Name = "tituloVentas";
            this.tituloVentas.Size = new System.Drawing.Size(164, 19);
            this.tituloVentas.TabIndex = 1;
            this.tituloVentas.Text = "Confirmación De Ventas";
            this.tituloVentas.Click += new System.EventHandler(this.tituloVentas_Click);
            // 
            // buscarprod
            // 
            this.buscarprod.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarprod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buscarprod.Location = new System.Drawing.Point(208, 29);
            this.buscarprod.Name = "buscarprod";
            this.buscarprod.Size = new System.Drawing.Size(307, 23);
            this.buscarprod.TabIndex = 2;
            this.buscarprod.Text = "Codigo de Barra del Producto";
            this.buscarprod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CodBarraProdClick);
            this.buscarprod.TextChanged += new System.EventHandler(this.MAtextCodProd);
            this.buscarprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codProdnum);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 12);
            this.label5.TabIndex = 214;
            this.label5.Text = "Codigo de Barras del Producto";
            // 
            // dataGridVentas
            // 
            this.dataGridVentas.AllowUserToAddRows = false;
            this.dataGridVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridVentas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodRegProd,
            this.NomProd,
            this.cantProd,
            this.PriceProd,
            this.pricetotalProd});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridVentas.Location = new System.Drawing.Point(1, 58);
            this.dataGridVentas.Name = "dataGridVentas";
            this.dataGridVentas.ReadOnly = true;
            this.dataGridVentas.Size = new System.Drawing.Size(570, 453);
            this.dataGridVentas.TabIndex = 218;
            this.dataGridVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVentas_CellClick);
            this.dataGridVentas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridVentas_KeyDown);
            // 
            // CodRegProd
            // 
            this.CodRegProd.HeaderText = "Codigo Registro";
            this.CodRegProd.Name = "CodRegProd";
            this.CodRegProd.ReadOnly = true;
            this.CodRegProd.Width = 180;
            // 
            // NomProd
            // 
            this.NomProd.HeaderText = "Nombre";
            this.NomProd.Name = "NomProd";
            this.NomProd.ReadOnly = true;
            this.NomProd.Width = 150;
            // 
            // cantProd
            // 
            this.cantProd.HeaderText = "Cantidad";
            this.cantProd.Name = "cantProd";
            this.cantProd.ReadOnly = true;
            this.cantProd.Width = 150;
            // 
            // PriceProd
            // 
            this.PriceProd.HeaderText = "Precio Unitario";
            this.PriceProd.Name = "PriceProd";
            this.PriceProd.ReadOnly = true;
            this.PriceProd.Width = 150;
            // 
            // pricetotalProd
            // 
            this.pricetotalProd.HeaderText = "Precio Total";
            this.pricetotalProd.Name = "pricetotalProd";
            this.pricetotalProd.ReadOnly = true;
            this.pricetotalProd.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(574, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 544);
            this.panel1.TabIndex = 219;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.printview);
            this.groupBox2.Controls.Add(this.SalirButton);
            this.groupBox2.Controls.Add(this.CleanList);
            this.groupBox2.Controls.Add(this.PrintFacture);
            this.groupBox2.Controls.Add(this.AddSale);
            this.groupBox2.Controls.Add(this.groupBoxPay);
            this.groupBox2.Controls.Add(this.groupBoxCantPay);
            this.groupBox2.Controls.Add(this.groupBoxtotal);
            this.groupBox2.Controls.Add(this.groupBoxIva);
            this.groupBox2.Controls.Add(this.groupBoxSubTotal);
            this.groupBox2.Controls.Add(this.groupBoxNumProd);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 416);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumen de Venta";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // printview
            // 
            this.printview.BackColor = System.Drawing.Color.Transparent;
            this.printview.BackgroundImage = global::Proyect_Kardex.Properties.Resources.dosnotify;
            this.printview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printview.Enabled = false;
            this.printview.FlatAppearance.BorderSize = 0;
            this.printview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.printview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.printview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printview.Location = new System.Drawing.Point(99, 366);
            this.printview.Name = "printview";
            this.printview.Size = new System.Drawing.Size(20, 20);
            this.printview.TabIndex = 25;
            this.printview.UseVisualStyleBackColor = false;
            this.printview.Click += new System.EventHandler(this.printview_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.BackColor = System.Drawing.Color.Transparent;
            this.SalirButton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.close_off_512;
            this.SalirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SalirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalirButton.FlatAppearance.BorderSize = 0;
            this.SalirButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SalirButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SalirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalirButton.Location = new System.Drawing.Point(221, 370);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(40, 40);
            this.SalirButton.TabIndex = 24;
            this.SalirButton.UseVisualStyleBackColor = false;
            this.SalirButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // CleanList
            // 
            this.CleanList.BackColor = System.Drawing.Color.Transparent;
            this.CleanList.BackgroundImage = global::Proyect_Kardex.Properties.Resources.clear_List;
            this.CleanList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CleanList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CleanList.FlatAppearance.BorderSize = 0;
            this.CleanList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CleanList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CleanList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanList.Location = new System.Drawing.Point(143, 370);
            this.CleanList.Name = "CleanList";
            this.CleanList.Size = new System.Drawing.Size(40, 40);
            this.CleanList.TabIndex = 23;
            this.CleanList.UseVisualStyleBackColor = false;
            this.CleanList.Click += new System.EventHandler(this.CleanList_Click);
            // 
            // PrintFacture
            // 
            this.PrintFacture.BackColor = System.Drawing.Color.Transparent;
            this.PrintFacture.BackgroundImage = global::Proyect_Kardex.Properties.Resources.Copywriting_Facture;
            this.PrintFacture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PrintFacture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintFacture.Enabled = false;
            this.PrintFacture.FlatAppearance.BorderSize = 0;
            this.PrintFacture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PrintFacture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PrintFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintFacture.Location = new System.Drawing.Point(74, 370);
            this.PrintFacture.Name = "PrintFacture";
            this.PrintFacture.Size = new System.Drawing.Size(40, 40);
            this.PrintFacture.TabIndex = 22;
            this.PrintFacture.UseVisualStyleBackColor = false;
            this.PrintFacture.Click += new System.EventHandler(this.PrintFacture_Click);
            // 
            // AddSale
            // 
            this.AddSale.BackColor = System.Drawing.Color.Transparent;
            this.AddSale.BackgroundImage = global::Proyect_Kardex.Properties.Resources.Hosting_512;
            this.AddSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSale.Enabled = false;
            this.AddSale.FlatAppearance.BorderSize = 0;
            this.AddSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSale.Location = new System.Drawing.Point(14, 370);
            this.AddSale.Name = "AddSale";
            this.AddSale.Size = new System.Drawing.Size(40, 40);
            this.AddSale.TabIndex = 21;
            this.AddSale.UseVisualStyleBackColor = false;
            this.AddSale.Click += new System.EventHandler(this.AddSale_Click);
            // 
            // groupBoxPay
            // 
            this.groupBoxPay.Controls.Add(this.button10);
            this.groupBoxPay.Controls.Add(this.PayButton);
            this.groupBoxPay.Controls.Add(this.typePayCombo);
            this.groupBoxPay.Controls.Add(this.PayText);
            this.groupBoxPay.Controls.Add(this.label16);
            this.groupBoxPay.Location = new System.Drawing.Point(6, 294);
            this.groupBoxPay.Name = "groupBoxPay";
            this.groupBoxPay.Size = new System.Drawing.Size(257, 68);
            this.groupBoxPay.TabIndex = 7;
            this.groupBoxPay.TabStop = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Window;
            this.button10.BackgroundImage = global::Proyect_Kardex.Properties.Resources.bolivia_boliviano;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button10.Enabled = false;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(187, 40);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(19, 18);
            this.button10.TabIndex = 257;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // PayButton
            // 
            this.PayButton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.pay;
            this.PayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayButton.FlatAppearance.BorderSize = 0;
            this.PayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayButton.Location = new System.Drawing.Point(221, 38);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(23, 23);
            this.PayButton.TabIndex = 16;
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // typePayCombo
            // 
            this.typePayCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typePayCombo.FormattingEnabled = true;
            this.typePayCombo.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARGETA DE REGALO",
            "TARGETA DE DÉBITO",
            "TARGETA DE CRÉDITO"});
            this.typePayCombo.Location = new System.Drawing.Point(100, 13);
            this.typePayCombo.Name = "typePayCombo";
            this.typePayCombo.Size = new System.Drawing.Size(148, 20);
            this.typePayCombo.TabIndex = 14;
            this.typePayCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.typePayCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.typepaynada);
            // 
            // PayText
            // 
            this.PayText.Location = new System.Drawing.Point(6, 39);
            this.PayText.Name = "PayText";
            this.PayText.Size = new System.Drawing.Size(202, 20);
            this.PayText.TabIndex = 15;
            this.PayText.Text = "0";
            this.PayText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PayClientnum);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "Agregar Pago:";
            // 
            // groupBoxCantPay
            // 
            this.groupBoxCantPay.Controls.Add(this.CantPay);
            this.groupBoxCantPay.Controls.Add(this.label15);
            this.groupBoxCantPay.Location = new System.Drawing.Point(6, 209);
            this.groupBoxCantPay.Name = "groupBoxCantPay";
            this.groupBoxCantPay.Size = new System.Drawing.Size(257, 79);
            this.groupBoxCantPay.TabIndex = 5;
            this.groupBoxCantPay.TabStop = false;
            // 
            // CantPay
            // 
            this.CantPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CantPay.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantPay.ForeColor = System.Drawing.Color.Crimson;
            this.CantPay.Location = new System.Drawing.Point(6, 36);
            this.CantPay.Name = "CantPay";
            this.CantPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CantPay.Size = new System.Drawing.Size(245, 40);
            this.CantPay.TabIndex = 13;
            this.CantPay.Text = "0.0";
            this.CantPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Cantidad a Pagar:";
            // 
            // groupBoxtotal
            // 
            this.groupBoxtotal.Controls.Add(this.TotalPay);
            this.groupBoxtotal.Controls.Add(this.label13);
            this.groupBoxtotal.Location = new System.Drawing.Point(6, 130);
            this.groupBoxtotal.Name = "groupBoxtotal";
            this.groupBoxtotal.Size = new System.Drawing.Size(257, 79);
            this.groupBoxtotal.TabIndex = 4;
            this.groupBoxtotal.TabStop = false;
            // 
            // TotalPay
            // 
            this.TotalPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalPay.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPay.ForeColor = System.Drawing.Color.Green;
            this.TotalPay.Location = new System.Drawing.Point(6, 36);
            this.TotalPay.Name = "TotalPay";
            this.TotalPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalPay.Size = new System.Drawing.Size(245, 40);
            this.TotalPay.TabIndex = 12;
            this.TotalPay.Text = "0.0";
            this.TotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Total:";
            // 
            // groupBoxIva
            // 
            this.groupBoxIva.Controls.Add(this.ivaPay);
            this.groupBoxIva.Controls.Add(this.label8);
            this.groupBoxIva.Location = new System.Drawing.Point(6, 87);
            this.groupBoxIva.Name = "groupBoxIva";
            this.groupBoxIva.Size = new System.Drawing.Size(257, 35);
            this.groupBoxIva.TabIndex = 3;
            this.groupBoxIva.TabStop = false;
            // 
            // ivaPay
            // 
            this.ivaPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ivaPay.Location = new System.Drawing.Point(165, 8);
            this.ivaPay.Name = "ivaPay";
            this.ivaPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ivaPay.Size = new System.Drawing.Size(86, 24);
            this.ivaPay.TabIndex = 11;
            this.ivaPay.Text = "0";
            this.ivaPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "13% IVA:";
            // 
            // groupBoxSubTotal
            // 
            this.groupBoxSubTotal.Controls.Add(this.SubTotalPay);
            this.groupBoxSubTotal.Controls.Add(this.label7);
            this.groupBoxSubTotal.Location = new System.Drawing.Point(6, 51);
            this.groupBoxSubTotal.Name = "groupBoxSubTotal";
            this.groupBoxSubTotal.Size = new System.Drawing.Size(257, 35);
            this.groupBoxSubTotal.TabIndex = 2;
            this.groupBoxSubTotal.TabStop = false;
            // 
            // SubTotalPay
            // 
            this.SubTotalPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SubTotalPay.Location = new System.Drawing.Point(165, 8);
            this.SubTotalPay.Name = "SubTotalPay";
            this.SubTotalPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SubTotalPay.Size = new System.Drawing.Size(86, 24);
            this.SubTotalPay.TabIndex = 10;
            this.SubTotalPay.Text = "0";
            this.SubTotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sub-Total:";
            // 
            // groupBoxNumProd
            // 
            this.groupBoxNumProd.Controls.Add(this.NumProd);
            this.groupBoxNumProd.Controls.Add(this.label6);
            this.groupBoxNumProd.Location = new System.Drawing.Point(6, 15);
            this.groupBoxNumProd.Name = "groupBoxNumProd";
            this.groupBoxNumProd.Size = new System.Drawing.Size(257, 35);
            this.groupBoxNumProd.TabIndex = 1;
            this.groupBoxNumProd.TabStop = false;
            // 
            // NumProd
            // 
            this.NumProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NumProd.Location = new System.Drawing.Point(165, 9);
            this.NumProd.Name = "NumProd";
            this.NumProd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NumProd.Size = new System.Drawing.Size(86, 24);
            this.NumProd.TabIndex = 9;
            this.NumProd.Text = "0";
            this.NumProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nro de Productos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listClient);
            this.groupBox1.Controls.Add(this.searchprod);
            this.groupBox1.Controls.Add(this.nameClient);
            this.groupBox1.Controls.Add(this.nitciclient);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listClient
            // 
            this.listClient.BackColor = System.Drawing.Color.Transparent;
            this.listClient.BackgroundImage = global::Proyect_Kardex.Properties.Resources.listClients;
            this.listClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.listClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listClient.FlatAppearance.BorderSize = 0;
            this.listClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.listClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.listClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listClient.Location = new System.Drawing.Point(222, 67);
            this.listClient.Name = "listClient";
            this.listClient.Size = new System.Drawing.Size(40, 40);
            this.listClient.TabIndex = 8;
            this.listClient.UseVisualStyleBackColor = false;
            this.listClient.Click += new System.EventHandler(this.listClient_Click);
            // 
            // searchprod
            // 
            this.searchprod.BackgroundImage = global::Proyect_Kardex.Properties.Resources.lupa;
            this.searchprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchprod.FlatAppearance.BorderSize = 0;
            this.searchprod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.searchprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.searchprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchprod.Location = new System.Drawing.Point(242, 35);
            this.searchprod.Name = "searchprod";
            this.searchprod.Size = new System.Drawing.Size(19, 18);
            this.searchprod.TabIndex = 6;
            this.searchprod.UseVisualStyleBackColor = true;
            this.searchprod.Click += new System.EventHandler(this.searchprod_Click);
            // 
            // nameClient
            // 
            this.nameClient.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameClient.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nameClient.Location = new System.Drawing.Point(22, 82);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(192, 20);
            this.nameClient.TabIndex = 7;
            this.nameClient.Text = "Nombre Completo del Cliente";
            this.nameClient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NameClienteClick);
            this.nameClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameClientLetra);
            // 
            // nitciclient
            // 
            this.nitciclient.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nitciclient.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nitciclient.Location = new System.Drawing.Point(22, 34);
            this.nitciclient.Name = "nitciclient";
            this.nitciclient.Size = new System.Drawing.Size(240, 20);
            this.nitciclient.TabIndex = 5;
            this.nitciclient.Text = "Nit o CI del Cliente (Nit: 10 Digitos)";
            this.nitciclient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nitClientClick);
            this.nitciclient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nitClientnum);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "NIT/CI";
            // 
            // DetCheck
            // 
            this.DetCheck.AutoSize = true;
            this.DetCheck.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetCheck.Location = new System.Drawing.Point(12, 520);
            this.DetCheck.Name = "DetCheck";
            this.DetCheck.Size = new System.Drawing.Size(207, 16);
            this.DetCheck.TabIndex = 17;
            this.DetCheck.Text = "Incluir Detalle del Total de la Venta";
            this.DetCheck.UseVisualStyleBackColor = true;
            this.DetCheck.CheckedChanged += new System.EventHandler(this.CheckDetalleVenta);
            // 
            // detText
            // 
            this.detText.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detText.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.detText.Location = new System.Drawing.Point(225, 517);
            this.detText.Name = "detText";
            this.detText.Size = new System.Drawing.Size(165, 20);
            this.detText.TabIndex = 18;
            this.detText.Text = "Ej: Cuarenta y Cuatro con 40/100 Bs";
            this.detText.Visible = false;
            this.detText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DetaVentaClick);
            this.detText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.detText_KeyPress);
            // 
            // Descuentext
            // 
            this.Descuentext.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descuentext.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Descuentext.Location = new System.Drawing.Point(474, 517);
            this.Descuentext.MaxLength = 3;
            this.Descuentext.Name = "Descuentext";
            this.Descuentext.Size = new System.Drawing.Size(65, 20);
            this.Descuentext.TabIndex = 19;
            this.Descuentext.Text = "Ej: 15";
            this.Descuentext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DescuentClick);
            this.Descuentext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descnum);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 256;
            this.label4.Text = "Descuento:";
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
            this.modulebuton.Location = new System.Drawing.Point(519, 518);
            this.modulebuton.Name = "modulebuton";
            this.modulebuton.Size = new System.Drawing.Size(19, 18);
            this.modulebuton.TabIndex = 253;
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
            this.addDescuent.Location = new System.Drawing.Point(545, 515);
            this.addDescuent.Name = "addDescuent";
            this.addDescuent.Size = new System.Drawing.Size(23, 23);
            this.addDescuent.TabIndex = 20;
            this.addDescuent.UseVisualStyleBackColor = true;
            this.addDescuent.Click += new System.EventHandler(this.button8_Click);
            // 
            // enterboton
            // 
            this.enterboton.BackColor = System.Drawing.SystemColors.Window;
            this.enterboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.intocar;
            this.enterboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enterboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterboton.FlatAppearance.BorderSize = 0;
            this.enterboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.enterboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.enterboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterboton.Location = new System.Drawing.Point(493, 30);
            this.enterboton.Name = "enterboton";
            this.enterboton.Size = new System.Drawing.Size(21, 21);
            this.enterboton.TabIndex = 3;
            this.enterboton.UseVisualStyleBackColor = false;
            this.enterboton.Click += new System.EventHandler(this.enterboton_Click);
            // 
            // listProd
            // 
            this.listProd.BackColor = System.Drawing.Color.Transparent;
            this.listProd.BackgroundImage = global::Proyect_Kardex.Properties.Resources.listProduct;
            this.listProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.listProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listProd.FlatAppearance.BorderSize = 0;
            this.listProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.listProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.listProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listProd.Location = new System.Drawing.Point(531, 12);
            this.listProd.Name = "listProd";
            this.listProd.Size = new System.Drawing.Size(40, 40);
            this.listProd.TabIndex = 4;
            this.listProd.UseVisualStyleBackColor = false;
            this.listProd.Click += new System.EventHandler(this.listProd_Click);
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
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(856, 542);
            this.Controls.Add(this.modulebuton);
            this.Controls.Add(this.addDescuent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Descuentext);
            this.Controls.Add(this.detText);
            this.Controls.Add(this.DetCheck);
            this.Controls.Add(this.enterboton);
            this.Controls.Add(this.listProd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridVentas);
            this.Controls.Add(this.tituloVentas);
            this.Controls.Add(this.buscarprod);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ventas_FormClosing);
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBoxPay.ResumeLayout(false);
            this.groupBoxPay.PerformLayout();
            this.groupBoxCantPay.ResumeLayout(false);
            this.groupBoxCantPay.PerformLayout();
            this.groupBoxtotal.ResumeLayout(false);
            this.groupBoxtotal.PerformLayout();
            this.groupBoxIva.ResumeLayout(false);
            this.groupBoxIva.PerformLayout();
            this.groupBoxSubTotal.ResumeLayout(false);
            this.groupBoxSubTotal.PerformLayout();
            this.groupBoxNumProd.ResumeLayout(false);
            this.groupBoxNumProd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox buscarprod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button searchprod;
        public System.Windows.Forms.Button listClient;
        public System.Windows.Forms.Button listProd;
        public System.Windows.Forms.Button enterboton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button PayButton;
        public System.Windows.Forms.Button SalirButton;
        public System.Windows.Forms.Button CleanList;
        public System.Windows.Forms.Button PrintFacture;
        public System.Windows.Forms.Button AddSale;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button addDescuent;
        public System.Windows.Forms.Button modulebuton;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.TextBox nitciclient;
        public System.Windows.Forms.TextBox nameClient;
        public System.Windows.Forms.ComboBox typePayCombo;
        public System.Windows.Forms.TextBox PayText;
        public System.Windows.Forms.Label CantPay;
        public System.Windows.Forms.Label TotalPay;
        public System.Windows.Forms.Label ivaPay;
        public System.Windows.Forms.Label SubTotalPay;
        public System.Windows.Forms.Label NumProd;
        public System.Windows.Forms.CheckBox DetCheck;
        public System.Windows.Forms.TextBox detText;
        public System.Windows.Forms.TextBox Descuentext;
        public System.Windows.Forms.ToolTip SalesToolTip;
        public System.Windows.Forms.Label tituloVentas;
        public System.Windows.Forms.GroupBox groupBoxPay;
        public System.Windows.Forms.GroupBox groupBoxCantPay;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBoxtotal;
        public System.Windows.Forms.GroupBox groupBoxIva;
        public System.Windows.Forms.GroupBox groupBoxSubTotal;
        public System.Windows.Forms.GroupBox groupBoxNumProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodRegProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricetotalProd;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.PrintDialog printMain;
        public System.Drawing.Printing.PrintDocument printDocx;
        public System.Windows.Forms.PrintPreviewDialog printPreview;
    }
}