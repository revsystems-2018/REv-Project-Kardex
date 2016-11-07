namespace Proyect_Kardex
{
    partial class REV_BarCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REV_BarCode));
            this.textcod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.titulolabel = new System.Windows.Forms.Label();
            this.combotipo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictucodebar = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buscaredboton = new System.Windows.Forms.Button();
            this.picturejem = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combofont = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combotam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combocolor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printview = new System.Windows.Forms.Button();
            this.magicode = new System.Windows.Forms.Button();
            this.gencode = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.eliminarreg = new System.Windows.Forms.Button();
            this.VerEjem = new System.Windows.Forms.Button();
            this.Buscaritem = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.toolCodebar = new System.Windows.Forms.ToolTip(this.components);
            this.DocxPrint = new System.Drawing.Printing.PrintDocument();
            this.PrintMain = new System.Windows.Forms.PrintDialog();
            this.buscarboton = new System.Windows.Forms.Button();
            this.PrintPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictucodebar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturejem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textcod
            // 
            this.textcod.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textcod.Location = new System.Drawing.Point(18, 98);
            this.textcod.Name = "textcod";
            this.textcod.Size = new System.Drawing.Size(282, 25);
            this.textcod.TabIndex = 1;
            this.textcod.Text = "Ingresar/Generar Codigo de Barras";
            this.textcod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.codebartextClick);
            this.textcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numcodebar);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 262;
            this.label5.Text = "Codigo";
            // 
            // titulolabel
            // 
            this.titulolabel.AutoSize = true;
            this.titulolabel.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulolabel.Location = new System.Drawing.Point(12, 55);
            this.titulolabel.Name = "titulolabel";
            this.titulolabel.Size = new System.Drawing.Size(232, 19);
            this.titulolabel.TabIndex = 261;
            this.titulolabel.Text = "Generador De Codigo De Barras";
            // 
            // combotipo
            // 
            this.combotipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotipo.FormattingEnabled = true;
            this.combotipo.Items.AddRange(new object[] {
            "Code 11",
            "Code 128",
            "Code 39",
            "Code 39 Model 43",
            "Code 93",
            "Code EAN 13",
            "Code Industrial 2 of 5",
            "Code ITF 14"});
            this.combotipo.Location = new System.Drawing.Point(18, 45);
            this.combotipo.Name = "combotipo";
            this.combotipo.Size = new System.Drawing.Size(196, 20);
            this.combotipo.TabIndex = 3;
            this.combotipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.combotipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nadatipo);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.pictucodebar);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 190);
            this.groupBox1.TabIndex = 266;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vista Previa";
            // 
            // pictucodebar
            // 
            this.pictucodebar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictucodebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictucodebar.Location = new System.Drawing.Point(6, 19);
            this.pictucodebar.Name = "pictucodebar";
            this.pictucodebar.Size = new System.Drawing.Size(282, 165);
            this.pictucodebar.TabIndex = 0;
            this.pictucodebar.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buscaredboton);
            this.groupBox2.Controls.Add(this.picturejem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.combofont);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.combotam);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.combocolor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.combotipo);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(312, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 273);
            this.groupBox2.TabIndex = 267;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajustes del Codigo";
            // 
            // buscaredboton
            // 
            this.buscaredboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.Question_512;
            this.buscaredboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscaredboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscaredboton.FlatAppearance.BorderSize = 0;
            this.buscaredboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buscaredboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buscaredboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscaredboton.Location = new System.Drawing.Point(231, 44);
            this.buscaredboton.Name = "buscaredboton";
            this.buscaredboton.Size = new System.Drawing.Size(22, 22);
            this.buscaredboton.TabIndex = 7;
            this.buscaredboton.UseVisualStyleBackColor = true;
            this.buscaredboton.Click += new System.EventHandler(this.buscaredboton_Click);
            // 
            // picturejem
            // 
            this.picturejem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picturejem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturejem.Location = new System.Drawing.Point(18, 168);
            this.picturejem.Name = "picturejem";
            this.picturejem.Size = new System.Drawing.Size(235, 99);
            this.picturejem.TabIndex = 1;
            this.picturejem.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 12);
            this.label3.TabIndex = 311;
            this.label3.Text = "Color de Fondo";
            // 
            // combofont
            // 
            this.combofont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combofont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combofont.FormattingEnabled = true;
            this.combofont.Items.AddRange(new object[] {
            "Blanco",
            "Color Agua"});
            this.combofont.Location = new System.Drawing.Point(149, 90);
            this.combofont.Name = "combofont";
            this.combofont.Size = new System.Drawing.Size(104, 20);
            this.combofont.TabIndex = 5;
            this.combofont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nadaFondo);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 309;
            this.label4.Text = "Tamaño";
            // 
            // combotam
            // 
            this.combotam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combotam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotam.FormattingEnabled = true;
            this.combotam.Items.AddRange(new object[] {
            "400 x 150 (Grande)",
            "300 x 150 (Mediano)",
            "200 x 150 (Pequeño)"});
            this.combotam.Location = new System.Drawing.Point(18, 135);
            this.combotam.Name = "combotam";
            this.combotam.Size = new System.Drawing.Size(196, 20);
            this.combotam.TabIndex = 6;
            this.combotam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nadatam);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 305;
            this.label2.Text = "Color de Codigo";
            // 
            // combocolor
            // 
            this.combocolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combocolor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocolor.FormattingEnabled = true;
            this.combocolor.Items.AddRange(new object[] {
            "Negro",
            "Verde Oscuro",
            "Rojo Oscuro"});
            this.combocolor.Location = new System.Drawing.Point(18, 90);
            this.combocolor.Name = "combocolor";
            this.combocolor.Size = new System.Drawing.Size(104, 20);
            this.combocolor.TabIndex = 4;
            this.combocolor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nadacolor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 303;
            this.label1.Text = "Simbologia";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.printview);
            this.panel1.Controls.Add(this.magicode);
            this.panel1.Controls.Add(this.gencode);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.eliminarreg);
            this.panel1.Controls.Add(this.VerEjem);
            this.panel1.Controls.Add(this.Buscaritem);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 51);
            this.panel1.TabIndex = 302;
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
            this.printview.TabIndex = 13;
            this.printview.UseVisualStyleBackColor = false;
            this.printview.Click += new System.EventHandler(this.printview_Click);
            // 
            // magicode
            // 
            this.magicode.BackColor = System.Drawing.Color.Transparent;
            this.magicode.BackgroundImage = global::Proyect_Kardex.Properties.Resources.magicode;
            this.magicode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.magicode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicode.FlatAppearance.BorderSize = 0;
            this.magicode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.magicode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.magicode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magicode.Location = new System.Drawing.Point(16, 5);
            this.magicode.Name = "magicode";
            this.magicode.Size = new System.Drawing.Size(40, 40);
            this.magicode.TabIndex = 2;
            this.magicode.UseVisualStyleBackColor = false;
            this.magicode.Click += new System.EventHandler(this.magicode_Click);
            // 
            // gencode
            // 
            this.gencode.BackColor = System.Drawing.Color.Transparent;
            this.gencode.BackgroundImage = global::Proyect_Kardex.Properties.Resources.GenerarCode;
            this.gencode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gencode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gencode.FlatAppearance.BorderSize = 0;
            this.gencode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.gencode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.gencode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gencode.Location = new System.Drawing.Point(379, 5);
            this.gencode.Name = "gencode";
            this.gencode.Size = new System.Drawing.Size(40, 40);
            this.gencode.TabIndex = 10;
            this.gencode.UseVisualStyleBackColor = false;
            this.gencode.Click += new System.EventHandler(this.button1_Click);
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
            this.print.TabIndex = 12;
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // eliminarreg
            // 
            this.eliminarreg.BackColor = System.Drawing.Color.Transparent;
            this.eliminarreg.BackgroundImage = global::Proyect_Kardex.Properties.Resources.eliminardata;
            this.eliminarreg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminarreg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarreg.FlatAppearance.BorderSize = 0;
            this.eliminarreg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eliminarreg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.eliminarreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarreg.Location = new System.Drawing.Point(143, 5);
            this.eliminarreg.Name = "eliminarreg";
            this.eliminarreg.Size = new System.Drawing.Size(40, 40);
            this.eliminarreg.TabIndex = 14;
            this.eliminarreg.UseVisualStyleBackColor = false;
            this.eliminarreg.Click += new System.EventHandler(this.eliminarreg_Click);
            // 
            // VerEjem
            // 
            this.VerEjem.BackColor = System.Drawing.Color.Transparent;
            this.VerEjem.BackgroundImage = global::Proyect_Kardex.Properties.Resources.viewfoto;
            this.VerEjem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VerEjem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerEjem.FlatAppearance.BorderSize = 0;
            this.VerEjem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VerEjem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.VerEjem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerEjem.Location = new System.Drawing.Point(77, 5);
            this.VerEjem.Name = "VerEjem";
            this.VerEjem.Size = new System.Drawing.Size(40, 40);
            this.VerEjem.TabIndex = 8;
            this.VerEjem.UseVisualStyleBackColor = false;
            this.VerEjem.Click += new System.EventHandler(this.VerEjem_Click);
            // 
            // Buscaritem
            // 
            this.Buscaritem.BackColor = System.Drawing.Color.Transparent;
            this.Buscaritem.BackgroundImage = global::Proyect_Kardex.Properties.Resources.Loop_512;
            this.Buscaritem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Buscaritem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscaritem.FlatAppearance.BorderSize = 0;
            this.Buscaritem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Buscaritem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Buscaritem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscaritem.Location = new System.Drawing.Point(219, 5);
            this.Buscaritem.Name = "Buscaritem";
            this.Buscaritem.Size = new System.Drawing.Size(40, 40);
            this.Buscaritem.TabIndex = 9;
            this.Buscaritem.UseVisualStyleBackColor = false;
            this.Buscaritem.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.BackgroundImage = global::Proyect_Kardex.Properties.Resources.saveblok;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Enabled = false;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(461, 5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(40, 40);
            this.save.TabIndex = 11;
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
            this.salir.Location = new System.Drawing.Point(533, 5);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(40, 40);
            this.salir.TabIndex = 15;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // DocxPrint
            // 
            this.DocxPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DocxPrint_PrintPage);
            // 
            // PrintMain
            // 
            this.PrintMain.Document = this.DocxPrint;
            this.PrintMain.UseEXDialog = true;
            // 
            // buscarboton
            // 
            this.buscarboton.BackColor = System.Drawing.SystemColors.Menu;
            this.buscarboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.magic;
            this.buscarboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarboton.FlatAppearance.BorderSize = 0;
            this.buscarboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buscarboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buscarboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarboton.Location = new System.Drawing.Point(266, 141);
            this.buscarboton.Name = "buscarboton";
            this.buscarboton.Size = new System.Drawing.Size(25, 23);
            this.buscarboton.TabIndex = 264;
            this.buscarboton.UseVisualStyleBackColor = false;
            // 
            // PrintPreview
            // 
            this.PrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreview.Document = this.DocxPrint;
            this.PrintPreview.Enabled = true;
            this.PrintPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreview.Icon")));
            this.PrintPreview.Name = "PrintPreview";
            this.PrintPreview.Visible = false;
            // 
            // REV_BarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(585, 339);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buscarboton);
            this.Controls.Add(this.textcod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titulolabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "REV_BarCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codigo de Barras";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictucodebar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturejem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buscarboton;
        public System.Windows.Forms.TextBox textcod;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label titulolabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button gencode;
        public System.Windows.Forms.PictureBox pictucodebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button eliminarreg;
        public System.Windows.Forms.Button VerEjem;
        public System.Windows.Forms.Button Buscaritem;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button salir;
        public System.Windows.Forms.PictureBox picturejem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button buscaredboton;
        public System.Windows.Forms.Button magicode;
        public System.Windows.Forms.ComboBox combotipo;
        public System.Windows.Forms.ComboBox combocolor;
        public System.Windows.Forms.ComboBox combofont;
        public System.Windows.Forms.ComboBox combotam;
        public System.Windows.Forms.ToolTip toolCodebar;
        public System.Drawing.Printing.PrintDocument DocxPrint;
        public System.Windows.Forms.PrintDialog PrintMain;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.PrintPreviewDialog PrintPreview;
    }
}