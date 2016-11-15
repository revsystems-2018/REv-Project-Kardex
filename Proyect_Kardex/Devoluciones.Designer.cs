namespace Proyect_Kardex
{
    partial class Devoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devoluciones));
            this.CantPay = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ivaPay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SubTotalPay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxSubTotal = new System.Windows.Forms.GroupBox();
            this.groupBoxNumProd = new System.Windows.Forms.GroupBox();
            this.NumProd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SalirButton = new System.Windows.Forms.Button();
            this.CleanList = new System.Windows.Forms.Button();
            this.AddSale = new System.Windows.Forms.Button();
            this.groupBoxCantPay = new System.Windows.Forms.GroupBox();
            this.groupBoxIva = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnListventas = new System.Windows.Forms.Button();
            this.txtCodeV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listClient = new System.Windows.Forms.Button();
            this.searchprod = new System.Windows.Forms.Button();
            this.nameClient = new System.Windows.Forms.TextBox();
            this.nitciclient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridVentas = new System.Windows.Forms.DataGridView();
            this.CodRegProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricetotalProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarprod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tituloVentas = new System.Windows.Forms.Label();
            this.enterboton = new System.Windows.Forms.Button();
            this.listProd = new System.Windows.Forms.Button();
            this.toolTipdevo = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxSubTotal.SuspendLayout();
            this.groupBoxNumProd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxCantPay.SuspendLayout();
            this.groupBoxIva.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // CantPay
            // 
            this.CantPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CantPay.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantPay.ForeColor = System.Drawing.Color.Red;
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.SalirButton);
            this.groupBox2.Controls.Add(this.CleanList);
            this.groupBox2.Controls.Add(this.AddSale);
            this.groupBox2.Controls.Add(this.groupBoxCantPay);
            this.groupBox2.Controls.Add(this.groupBoxIva);
            this.groupBox2.Controls.Add(this.groupBoxSubTotal);
            this.groupBox2.Controls.Add(this.groupBoxNumProd);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 268);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumen de la Devolución";
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
            this.SalirButton.Location = new System.Drawing.Point(203, 222);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(40, 40);
            this.SalirButton.TabIndex = 24;
            this.SalirButton.UseVisualStyleBackColor = false;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
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
            this.CleanList.Location = new System.Drawing.Point(125, 222);
            this.CleanList.Name = "CleanList";
            this.CleanList.Size = new System.Drawing.Size(40, 40);
            this.CleanList.TabIndex = 23;
            this.CleanList.UseVisualStyleBackColor = false;
            this.CleanList.Click += new System.EventHandler(this.CleanList_Click);
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
            this.AddSale.Location = new System.Drawing.Point(55, 222);
            this.AddSale.Name = "AddSale";
            this.AddSale.Size = new System.Drawing.Size(40, 40);
            this.AddSale.TabIndex = 21;
            this.AddSale.UseVisualStyleBackColor = false;
            this.AddSale.Click += new System.EventHandler(this.AddSale_Click);
            // 
            // groupBoxCantPay
            // 
            this.groupBoxCantPay.Controls.Add(this.CantPay);
            this.groupBoxCantPay.Controls.Add(this.label15);
            this.groupBoxCantPay.Location = new System.Drawing.Point(6, 128);
            this.groupBoxCantPay.Name = "groupBoxCantPay";
            this.groupBoxCantPay.Size = new System.Drawing.Size(257, 79);
            this.groupBoxCantPay.TabIndex = 5;
            this.groupBoxCantPay.TabStop = false;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(574, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 467);
            this.panel1.TabIndex = 226;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnListventas);
            this.groupBox3.Controls.Add(this.txtCodeV);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la Venta";
            // 
            // btnListventas
            // 
            this.btnListventas.BackColor = System.Drawing.Color.Transparent;
            this.btnListventas.BackgroundImage = global::Proyect_Kardex.Properties.Resources.listVentas;
            this.btnListventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListventas.FlatAppearance.BorderSize = 0;
            this.btnListventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnListventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnListventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListventas.Location = new System.Drawing.Point(222, 20);
            this.btnListventas.Name = "btnListventas";
            this.btnListventas.Size = new System.Drawing.Size(40, 40);
            this.btnListventas.TabIndex = 8;
            this.btnListventas.UseVisualStyleBackColor = false;
            this.btnListventas.Click += new System.EventHandler(this.btnListventas_Click);
            // 
            // txtCodeV
            // 
            this.txtCodeV.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeV.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCodeV.Location = new System.Drawing.Point(22, 35);
            this.txtCodeV.Name = "txtCodeV";
            this.txtCodeV.Size = new System.Drawing.Size(192, 20);
            this.txtCodeV.TabIndex = 7;
            this.txtCodeV.Text = "Ingresar el Codigo de Venta";
            this.txtCodeV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCodeV_MouseClick);
            this.txtCodeV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeV_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de Registro";
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
            this.nameClient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nameClient_MouseClick);
            this.nameClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameClient_KeyPress);
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
            this.nitciclient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nitciclient_MouseClick);
            this.nitciclient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nitciclient_KeyPress);
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
            this.dataGridVentas.Size = new System.Drawing.Size(570, 408);
            this.dataGridVentas.TabIndex = 225;
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
            // buscarprod
            // 
            this.buscarprod.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarprod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buscarprod.Location = new System.Drawing.Point(208, 29);
            this.buscarprod.Name = "buscarprod";
            this.buscarprod.Size = new System.Drawing.Size(307, 23);
            this.buscarprod.TabIndex = 221;
            this.buscarprod.Text = "Codigo de Barra del Producto";
            this.buscarprod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buscarprod_MouseClick);
            this.buscarprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscarprod_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 12);
            this.label5.TabIndex = 224;
            this.label5.Text = "Codigo de Barras del Producto";
            // 
            // tituloVentas
            // 
            this.tituloVentas.AutoSize = true;
            this.tituloVentas.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloVentas.Location = new System.Drawing.Point(12, 9);
            this.tituloVentas.Name = "tituloVentas";
            this.tituloVentas.Size = new System.Drawing.Size(159, 19);
            this.tituloVentas.TabIndex = 220;
            this.tituloVentas.Text = "Confirmar Devolución ";
            this.tituloVentas.Click += new System.EventHandler(this.tituloVentas_Click);
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
            this.enterboton.TabIndex = 222;
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
            this.listProd.TabIndex = 223;
            this.listProd.UseVisualStyleBackColor = false;
            this.listProd.Click += new System.EventHandler(this.listProd_Click);
            // 
            // Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(858, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.enterboton);
            this.Controls.Add(this.listProd);
            this.Controls.Add(this.dataGridVentas);
            this.Controls.Add(this.buscarprod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tituloVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Devoluciones";
            this.Text = " Devolución en Ventas";
            this.Load += new System.EventHandler(this.Devoluciones_Load);
            this.groupBoxSubTotal.ResumeLayout(false);
            this.groupBoxSubTotal.PerformLayout();
            this.groupBoxNumProd.ResumeLayout(false);
            this.groupBoxNumProd.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxCantPay.ResumeLayout(false);
            this.groupBoxCantPay.PerformLayout();
            this.groupBoxIva.ResumeLayout(false);
            this.groupBoxIva.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button SalirButton;
        public System.Windows.Forms.Button AddSale;
        public System.Windows.Forms.Label CantPay;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label ivaPay;
        public System.Windows.Forms.Button CleanList;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label SubTotalPay;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox groupBoxSubTotal;
        public System.Windows.Forms.GroupBox groupBoxNumProd;
        public System.Windows.Forms.Label NumProd;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBoxCantPay;
        public System.Windows.Forms.GroupBox groupBoxIva;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button listClient;
        public System.Windows.Forms.Button searchprod;
        public System.Windows.Forms.TextBox nameClient;
        public System.Windows.Forms.TextBox nitciclient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button enterboton;
        public System.Windows.Forms.Button listProd;
        private System.Windows.Forms.DataGridView dataGridVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodRegProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricetotalProd;
        public System.Windows.Forms.TextBox buscarprod;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label tituloVentas;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btnListventas;
        public System.Windows.Forms.TextBox txtCodeV;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolTip toolTipdevo;
    }
}