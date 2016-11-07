namespace Proyect_Kardex
{
    partial class REV_CodeQr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REV_CodeQr));
            this.panel1 = new System.Windows.Forms.Panel();
            this.printview = new System.Windows.Forms.Button();
            this.magicode = new System.Windows.Forms.Button();
            this.gencode = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.eliminarreg = new System.Windows.Forms.Button();
            this.Buscaritem = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictucodeQr = new System.Windows.Forms.PictureBox();
            this.textcod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.titulolabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.panelfondo = new System.Windows.Forms.Panel();
            this.panelcode = new System.Windows.Forms.Panel();
            this.checkForza = new System.Windows.Forms.CheckBox();
            this.textPixel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combotipo = new System.Windows.Forms.ComboBox();
            this.printMain = new System.Windows.Forms.PrintDialog();
            this.printDocx = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictucodeQr)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.Buscaritem);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 51);
            this.panel1.TabIndex = 303;
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
            this.printview.Location = new System.Drawing.Point(273, 5);
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
            this.gencode.BackgroundImage = global::Proyect_Kardex.Properties.Resources.GenQr;
            this.gencode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gencode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gencode.FlatAppearance.BorderSize = 0;
            this.gencode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.gencode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.gencode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gencode.Location = new System.Drawing.Point(326, 5);
            this.gencode.Name = "gencode";
            this.gencode.Size = new System.Drawing.Size(40, 40);
            this.gencode.TabIndex = 10;
            this.gencode.UseVisualStyleBackColor = false;
            this.gencode.Click += new System.EventHandler(this.gencode_Click);
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
            this.print.Location = new System.Drawing.Point(246, 5);
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
            this.eliminarreg.Location = new System.Drawing.Point(90, 5);
            this.eliminarreg.Name = "eliminarreg";
            this.eliminarreg.Size = new System.Drawing.Size(40, 40);
            this.eliminarreg.TabIndex = 14;
            this.eliminarreg.UseVisualStyleBackColor = false;
            this.eliminarreg.Click += new System.EventHandler(this.eliminarreg_Click);
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
            this.Buscaritem.Location = new System.Drawing.Point(166, 5);
            this.Buscaritem.Name = "Buscaritem";
            this.Buscaritem.Size = new System.Drawing.Size(40, 40);
            this.Buscaritem.TabIndex = 9;
            this.Buscaritem.UseVisualStyleBackColor = false;
            this.Buscaritem.Click += new System.EventHandler(this.Buscaritem_Click);
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
            this.save.Location = new System.Drawing.Point(407, 5);
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
            this.salir.Location = new System.Drawing.Point(480, 5);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(40, 40);
            this.salir.TabIndex = 15;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.pictucodeQr);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 244);
            this.groupBox1.TabIndex = 307;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vista Previa";
            // 
            // pictucodeQr
            // 
            this.pictucodeQr.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictucodeQr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictucodeQr.Location = new System.Drawing.Point(6, 19);
            this.pictucodeQr.Name = "pictucodeQr";
            this.pictucodeQr.Size = new System.Drawing.Size(356, 219);
            this.pictucodeQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictucodeQr.TabIndex = 0;
            this.pictucodeQr.TabStop = false;
            // 
            // textcod
            // 
            this.textcod.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textcod.Location = new System.Drawing.Point(18, 97);
            this.textcod.Multiline = true;
            this.textcod.Name = "textcod";
            this.textcod.Size = new System.Drawing.Size(362, 36);
            this.textcod.TabIndex = 304;
            this.textcod.Text = "Ingresar/Generar Codigo de Registro";
            this.textcod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textcod_MouseClick);
            this.textcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textcod_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 306;
            this.label5.Text = "Codigo";
            // 
            // titulolabel
            // 
            this.titulolabel.AutoSize = true;
            this.titulolabel.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulolabel.Location = new System.Drawing.Point(12, 54);
            this.titulolabel.Name = "titulolabel";
            this.titulolabel.Size = new System.Drawing.Size(185, 19);
            this.titulolabel.TabIndex = 305;
            this.titulolabel.Text = "Generador De Codigo QR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbMode);
            this.groupBox2.Controls.Add(this.panelfondo);
            this.groupBox2.Controls.Add(this.panelcode);
            this.groupBox2.Controls.Add(this.checkForza);
            this.groupBox2.Controls.Add(this.textPixel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.combotipo);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(386, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 326);
            this.groupBox2.TabIndex = 308;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajustes del Codigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 12);
            this.label6.TabIndex = 317;
            this.label6.Text = "Modo Codificación";
            // 
            // cbMode
            // 
            this.cbMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Byte",
            "Alpha Numerico",
            "Numerico"});
            this.cbMode.Location = new System.Drawing.Point(8, 132);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(126, 20);
            this.cbMode.TabIndex = 316;
            // 
            // panelfondo
            // 
            this.panelfondo.BackColor = System.Drawing.Color.White;
            this.panelfondo.Location = new System.Drawing.Point(8, 237);
            this.panelfondo.Name = "panelfondo";
            this.panelfondo.Size = new System.Drawing.Size(126, 28);
            this.panelfondo.TabIndex = 315;
            this.panelfondo.DoubleClick += new System.EventHandler(this.panelfondo_DoubleClick);
            // 
            // panelcode
            // 
            this.panelcode.BackColor = System.Drawing.Color.Black;
            this.panelcode.Location = new System.Drawing.Point(8, 177);
            this.panelcode.Name = "panelcode";
            this.panelcode.Size = new System.Drawing.Size(126, 28);
            this.panelcode.TabIndex = 314;
            this.panelcode.DoubleClick += new System.EventHandler(this.panelcode_DoubleClick);
            // 
            // checkForza
            // 
            this.checkForza.AutoSize = true;
            this.checkForza.Checked = true;
            this.checkForza.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkForza.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkForza.Location = new System.Drawing.Point(8, 24);
            this.checkForza.Name = "checkForza";
            this.checkForza.Size = new System.Drawing.Size(96, 16);
            this.checkForza.TabIndex = 313;
            this.checkForza.Text = "Forzar UTF-8";
            this.checkForza.UseVisualStyleBackColor = true;
            // 
            // textPixel
            // 
            this.textPixel.Location = new System.Drawing.Point(8, 300);
            this.textPixel.MaxLength = 2;
            this.textPixel.Name = "textPixel";
            this.textPixel.Size = new System.Drawing.Size(126, 20);
            this.textPixel.TabIndex = 312;
            this.textPixel.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 12);
            this.label3.TabIndex = 311;
            this.label3.Text = "Color de Fondo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 12);
            this.label4.TabIndex = 309;
            this.label4.Text = "Escala Pixel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 305;
            this.label2.Text = "Color de Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 303;
            this.label1.Text = "Corrección Level";
            // 
            // combotipo
            // 
            this.combotipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotipo.FormattingEnabled = true;
            this.combotipo.Items.AddRange(new object[] {
            "Bajo (7%)",
            "Medio (15%)",
            "Calidad (25%)",
            "Alto (30%)"});
            this.combotipo.Location = new System.Drawing.Point(8, 83);
            this.combotipo.Name = "combotipo";
            this.combotipo.Size = new System.Drawing.Size(126, 20);
            this.combotipo.TabIndex = 3;
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
            this.printPreview.Visible = false;
            // 
            // REV_CodeQr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(532, 389);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textcod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titulolabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "REV_CodeQr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codigos Qr";
            this.Load += new System.EventHandler(this.REV_CodeQr_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictucodeQr)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button printview;
        public System.Windows.Forms.Button magicode;
        public System.Windows.Forms.Button gencode;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button eliminarreg;
        public System.Windows.Forms.Button Buscaritem;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button salir;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.PictureBox pictucodeQr;
        public System.Windows.Forms.TextBox textcod;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label titulolabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox combotipo;
        public System.Windows.Forms.TextBox textPixel;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PrintDialog printMain;
        public System.Drawing.Printing.PrintDocument printDocx;
        public System.Windows.Forms.PrintPreviewDialog printPreview;
        public System.Windows.Forms.Panel panelfondo;
        public System.Windows.Forms.Panel panelcode;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbMode;
        public System.Windows.Forms.CheckBox checkForza;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}