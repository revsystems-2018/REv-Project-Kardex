namespace Proyect_Kardex
{
    partial class AddProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductos));
            this.tituloprod = new System.Windows.Forms.Label();
            this.codprod = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.nameprod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textcant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textnamep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.catebox = new System.Windows.Forms.ComboBox();
            this.subcatebox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botoncate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonmarca = new System.Windows.Forms.Button();
            this.nommarca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.botonMed = new System.Windows.Forms.Button();
            this.textvol = new System.Windows.Forms.TextBox();
            this.textpeso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nommed = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.statebox = new System.Windows.Forms.ComboBox();
            this.dateprod = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buscarprov = new System.Windows.Forms.Button();
            this.botonprove = new System.Windows.Forms.Button();
            this.textemprov = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textcodprov = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ivabox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textPVU = new System.Windows.Forms.TextBox();
            this.textCCU = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textMax = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textMin = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textfoto = new System.Windows.Forms.TextBox();
            this.textcodbar = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.toolRegProd = new System.Windows.Forms.ToolTip(this.components);
            this.opencodbar = new System.Windows.Forms.Button();
            this.openimg = new System.Windows.Forms.Button();
            this.codGen = new System.Windows.Forms.Button();
            this.picturefoto = new System.Windows.Forms.PictureBox();
            this.picturecodebar = new System.Windows.Forms.PictureBox();
            this.veboton = new System.Windows.Forms.Button();
            this.salirboton = new System.Windows.Forms.Button();
            this.saveboton = new System.Windows.Forms.Button();
            this.dateTime2 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.checkdate = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturefoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturecodebar)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloprod
            // 
            this.tituloprod.AutoSize = true;
            this.tituloprod.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloprod.Location = new System.Drawing.Point(12, 9);
            this.tituloprod.Name = "tituloprod";
            this.tituloprod.Size = new System.Drawing.Size(142, 19);
            this.tituloprod.TabIndex = 1;
            this.tituloprod.Text = "Registrar Producto";
            // 
            // codprod
            // 
            this.codprod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codprod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.codprod.Location = new System.Drawing.Point(105, 34);
            this.codprod.Name = "codprod";
            this.codprod.Size = new System.Drawing.Size(242, 20);
            this.codprod.TabIndex = 2;
            this.codprod.Text = "Codigo de Barras del Producto";
            this.codprod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.codprodClick);
            this.codprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numcodprod);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(55, 38);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 12);
            this.label26.TabIndex = 204;
            this.label26.Text = "Codigo";
            // 
            // nameprod
            // 
            this.nameprod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameprod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nameprod.Location = new System.Drawing.Point(105, 65);
            this.nameprod.Name = "nameprod";
            this.nameprod.Size = new System.Drawing.Size(203, 20);
            this.nameprod.TabIndex = 3;
            this.nameprod.Text = "Nombre del Producto";
            this.nameprod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nameprodClick);
            this.nameprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letranameprod);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 207;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 209;
            this.label2.Text = "Descripción";
            // 
            // textcant
            // 
            this.textcant.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcant.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textcant.Location = new System.Drawing.Point(33, 36);
            this.textcant.Name = "textcant";
            this.textcant.Size = new System.Drawing.Size(162, 20);
            this.textcant.TabIndex = 30;
            this.textcant.Text = "Número de Productos";
            this.textcant.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cantprodClick);
            this.textcant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numcantprod);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 211;
            this.label3.Text = "Cantidad";
            // 
            // textnamep
            // 
            this.textnamep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnamep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textnamep.Location = new System.Drawing.Point(105, 91);
            this.textnamep.Multiline = true;
            this.textnamep.Name = "textnamep";
            this.textnamep.Size = new System.Drawing.Size(203, 64);
            this.textnamep.TabIndex = 4;
            this.textnamep.Text = "[Entrar Descripción Completa Aquí]";
            this.textnamep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.descprodClick);
            this.textnamep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dosdescprod);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 213;
            this.label4.Text = "Categoría";
            // 
            // catebox
            // 
            this.catebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catebox.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catebox.FormattingEnabled = true;
            this.catebox.Location = new System.Drawing.Point(97, 12);
            this.catebox.Name = "catebox";
            this.catebox.Size = new System.Drawing.Size(168, 20);
            this.catebox.TabIndex = 5;
            this.catebox.SelectedIndexChanged += new System.EventHandler(this.catebox_SelectedIndexChanged);
            // 
            // subcatebox
            // 
            this.subcatebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subcatebox.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subcatebox.FormattingEnabled = true;
            this.subcatebox.Location = new System.Drawing.Point(97, 43);
            this.subcatebox.Name = "subcatebox";
            this.subcatebox.Size = new System.Drawing.Size(168, 20);
            this.subcatebox.TabIndex = 6;
            this.subcatebox.SelectedIndexChanged += new System.EventHandler(this.subcatebox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 215;
            this.label5.Text = "Sub-Categoría";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botoncate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.subcatebox);
            this.groupBox1.Controls.Add(this.catebox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 71);
            this.groupBox1.TabIndex = 217;
            this.groupBox1.TabStop = false;
            // 
            // botoncate
            // 
            this.botoncate.BackColor = System.Drawing.Color.Transparent;
            this.botoncate.BackgroundImage = global::Proyect_Kardex.Properties.Resources.listCateg;
            this.botoncate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botoncate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoncate.FlatAppearance.BorderSize = 0;
            this.botoncate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botoncate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.botoncate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoncate.Location = new System.Drawing.Point(299, 16);
            this.botoncate.Name = "botoncate";
            this.botoncate.Size = new System.Drawing.Size(40, 40);
            this.botoncate.TabIndex = 7;
            this.botoncate.UseVisualStyleBackColor = false;
            this.botoncate.Click += new System.EventHandler(this.botoncate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonmarca);
            this.groupBox2.Controls.Add(this.nommarca);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 63);
            this.groupBox2.TabIndex = 218;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marca del Producto";
            // 
            // botonmarca
            // 
            this.botonmarca.BackColor = System.Drawing.Color.Transparent;
            this.botonmarca.BackgroundImage = global::Proyect_Kardex.Properties.Resources.listMarca;
            this.botonmarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonmarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonmarca.FlatAppearance.BorderSize = 0;
            this.botonmarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonmarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.botonmarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonmarca.Location = new System.Drawing.Point(299, 17);
            this.botonmarca.Name = "botonmarca";
            this.botonmarca.Size = new System.Drawing.Size(40, 40);
            this.botonmarca.TabIndex = 9;
            this.botonmarca.UseVisualStyleBackColor = false;
            this.botonmarca.Click += new System.EventHandler(this.botonmarca_Click);
            // 
            // nommarca
            // 
            this.nommarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nommarca.FormattingEnabled = true;
            this.nommarca.Location = new System.Drawing.Point(97, 37);
            this.nommarca.Name = "nommarca";
            this.nommarca.Size = new System.Drawing.Size(168, 20);
            this.nommarca.TabIndex = 8;
            this.nommarca.SelectedIndexChanged += new System.EventHandler(this.nommarca_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 12);
            this.label6.TabIndex = 217;
            this.label6.Text = "Nombre de la Empresa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.botonMed);
            this.groupBox3.Controls.Add(this.textvol);
            this.groupBox3.Controls.Add(this.textpeso);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.nommed);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 95);
            this.groupBox3.TabIndex = 219;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unidad de Medida";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Window;
            this.button12.BackgroundImage = global::Proyect_Kardex.Properties.Resources.ml;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(318, 68);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(19, 18);
            this.button12.TabIndex = 13;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Window;
            this.button11.BackgroundImage = global::Proyect_Kardex.Properties.Resources.gr;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(119, 68);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(19, 18);
            this.button11.TabIndex = 12;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // botonMed
            // 
            this.botonMed.BackColor = System.Drawing.Color.Transparent;
            this.botonMed.BackgroundImage = global::Proyect_Kardex.Properties.Resources.listMedida;
            this.botonMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonMed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMed.FlatAppearance.BorderSize = 0;
            this.botonMed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonMed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.botonMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonMed.Location = new System.Drawing.Point(299, 17);
            this.botonMed.Name = "botonMed";
            this.botonMed.Size = new System.Drawing.Size(40, 40);
            this.botonMed.TabIndex = 11;
            this.botonMed.UseVisualStyleBackColor = false;
            this.botonMed.Click += new System.EventHandler(this.botonMed_Click);
            // 
            // textvol
            // 
            this.textvol.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textvol.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textvol.Location = new System.Drawing.Point(242, 67);
            this.textvol.Name = "textvol";
            this.textvol.Size = new System.Drawing.Size(97, 20);
            this.textvol.TabIndex = 13;
            this.textvol.Text = "0,00";
            this.textvol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.volprodClick);
            this.textvol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decivol);
            // 
            // textpeso
            // 
            this.textpeso.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpeso.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textpeso.Location = new System.Drawing.Point(43, 67);
            this.textpeso.Name = "textpeso";
            this.textpeso.Size = new System.Drawing.Size(97, 20);
            this.textpeso.TabIndex = 12;
            this.textpeso.Text = "0,00";
            this.textpeso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pesoprodClick);
            this.textpeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decipeso);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(184, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 12);
            this.label9.TabIndex = 219;
            this.label9.Text = "Volumen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 12);
            this.label8.TabIndex = 218;
            this.label8.Text = "Peso";
            // 
            // nommed
            // 
            this.nommed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nommed.FormattingEnabled = true;
            this.nommed.Location = new System.Drawing.Point(97, 37);
            this.nommed.Name = "nommed";
            this.nommed.Size = new System.Drawing.Size(168, 20);
            this.nommed.TabIndex = 10;
            this.nommed.SelectedIndexChanged += new System.EventHandler(this.nommed_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 12);
            this.label7.TabIndex = 217;
            this.label7.Text = "Nombre de la Medida";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 220;
            this.label10.Text = "Estado";
            // 
            // statebox
            // 
            this.statebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statebox.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statebox.FormattingEnabled = true;
            this.statebox.Items.AddRange(new object[] {
            "Nuevo",
            "Activo",
            "Promoción",
            "Inactivo",
            "Suspendido",
            "Descatalogado"});
            this.statebox.Location = new System.Drawing.Point(105, 408);
            this.statebox.Name = "statebox";
            this.statebox.Size = new System.Drawing.Size(168, 20);
            this.statebox.TabIndex = 14;
            // 
            // dateprod
            // 
            this.dateprod.Enabled = false;
            this.dateprod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateprod.Location = new System.Drawing.Point(105, 457);
            this.dateprod.Name = "dateprod";
            this.dateprod.Size = new System.Drawing.Size(203, 20);
            this.dateprod.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buscarprov);
            this.groupBox4.Controls.Add(this.botonprove);
            this.groupBox4.Controls.Add(this.textemprov);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textcodprov);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(374, 59);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 96);
            this.groupBox4.TabIndex = 229;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proveedor";
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
            this.buscarprov.TabIndex = 24;
            this.buscarprov.UseVisualStyleBackColor = false;
            this.buscarprov.Click += new System.EventHandler(this.buscarprov_Click);
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
            this.botonprove.Location = new System.Drawing.Point(226, 21);
            this.botonprove.Name = "botonprove";
            this.botonprove.Size = new System.Drawing.Size(40, 40);
            this.botonprove.TabIndex = 26;
            this.botonprove.UseVisualStyleBackColor = false;
            this.botonprove.Click += new System.EventHandler(this.botonprove_Click);
            // 
            // textemprov
            // 
            this.textemprov.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textemprov.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textemprov.Location = new System.Drawing.Point(20, 71);
            this.textemprov.Name = "textemprov";
            this.textemprov.Size = new System.Drawing.Size(240, 20);
            this.textemprov.TabIndex = 25;
            this.textemprov.Text = "Nombre de la Empresa del Proveedor ";
            this.textemprov.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nameempproveClick);
            this.textemprov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dosnameemp);
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
            this.textcodprov.TabIndex = 23;
            this.textcodprov.Text = "Codigo de Registro";
            this.textcodprov.MouseClick += new System.Windows.Forms.MouseEventHandler(this.codregProveClick);
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
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.ivabox);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.textPVU);
            this.groupBox5.Controls.Add(this.textCCU);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(374, 161);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(276, 140);
            this.groupBox5.TabIndex = 230;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Precios";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Window;
            this.button6.BackgroundImage = global::Proyect_Kardex.Properties.Resources.bolivia_boliviano;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(240, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(19, 18);
            this.button6.TabIndex = 233;
            this.button6.UseVisualStyleBackColor = false;
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
            // ivabox
            // 
            this.ivabox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ivabox.FormattingEnabled = true;
            this.ivabox.Items.AddRange(new object[] {
            "Ninguno",
            "Predeterminado",
            "Impuesto en Ventas"});
            this.ivabox.Location = new System.Drawing.Point(20, 114);
            this.ivabox.Name = "ivabox";
            this.ivabox.Size = new System.Drawing.Size(175, 20);
            this.ivabox.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 12);
            this.label18.TabIndex = 231;
            this.label18.Text = "Impuestos";
            // 
            // textPVU
            // 
            this.textPVU.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPVU.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textPVU.Location = new System.Drawing.Point(20, 75);
            this.textPVU.Name = "textPVU";
            this.textPVU.Size = new System.Drawing.Size(240, 20);
            this.textPVU.TabIndex = 28;
            this.textPVU.Text = "Ej: 22,80";
            this.textPVU.MouseClick += new System.Windows.Forms.MouseEventHandler(this.precioClick);
            this.textPVU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decipvu);
            // 
            // textCCU
            // 
            this.textCCU.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCCU.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textCCU.Location = new System.Drawing.Point(20, 31);
            this.textCCU.Name = "textCCU";
            this.textCCU.Size = new System.Drawing.Size(240, 20);
            this.textCCU.TabIndex = 27;
            this.textCCU.Text = "Ej: 20,90";
            this.textCCU.MouseClick += new System.Windows.Forms.MouseEventHandler(this.costoProdClick);
            this.textCCU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deciccu);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 12);
            this.label17.TabIndex = 231;
            this.label17.Text = "Precio de Venta Unitario";
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
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.textMax);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.textMin);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.textcant);
            this.groupBox6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(374, 307);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(276, 120);
            this.groupBox6.TabIndex = 232;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Inventario";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(135, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 12);
            this.label21.TabIndex = 215;
            this.label21.Text = "Stock Maximo";
            // 
            // textMax
            // 
            this.textMax.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMax.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textMax.Location = new System.Drawing.Point(162, 84);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(98, 20);
            this.textMax.TabIndex = 32;
            this.textMax.Text = "Número Maximo";
            this.textMax.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maxprodClick);
            this.textMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nummaxprod);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 12);
            this.label20.TabIndex = 213;
            this.label20.Text = "Stock Mínimo";
            // 
            // textMin
            // 
            this.textMin.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textMin.Location = new System.Drawing.Point(33, 84);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(98, 20);
            this.textMin.TabIndex = 31;
            this.textMin.Text = "Número Minimo";
            this.textMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minprodClick);
            this.textMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numminprod);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(55, 522);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 12);
            this.label22.TabIndex = 233;
            this.label22.Text = "Imagen";
            // 
            // textfoto
            // 
            this.textfoto.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textfoto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textfoto.Location = new System.Drawing.Point(51, 537);
            this.textfoto.Name = "textfoto";
            this.textfoto.Size = new System.Drawing.Size(296, 20);
            this.textfoto.TabIndex = 19;
            this.textfoto.Text = "Ubicación de la Imagen del Producto";
            this.textfoto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgprodClick);
            this.textfoto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textfoto_KeyPress);
            // 
            // textcodbar
            // 
            this.textcodbar.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcodbar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textcodbar.Location = new System.Drawing.Point(51, 579);
            this.textcodbar.Name = "textcodbar";
            this.textcodbar.Size = new System.Drawing.Size(296, 20);
            this.textcodbar.TabIndex = 21;
            this.textcodbar.Text = "Ubicación de la Imagen del Codigo de Barras";
            this.textcodbar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgcodbarClick);
            this.textcodbar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textcodbar_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(55, 564);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 12);
            this.label23.TabIndex = 235;
            this.label23.Text = "Imagen de Codigo";
            // 
            // opencodbar
            // 
            this.opencodbar.BackgroundImage = global::Proyect_Kardex.Properties.Resources.list_1;
            this.opencodbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.opencodbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opencodbar.FlatAppearance.BorderSize = 0;
            this.opencodbar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.opencodbar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.opencodbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opencodbar.Location = new System.Drawing.Point(326, 580);
            this.opencodbar.Name = "opencodbar";
            this.opencodbar.Size = new System.Drawing.Size(19, 18);
            this.opencodbar.TabIndex = 22;
            this.opencodbar.UseVisualStyleBackColor = true;
            this.opencodbar.Click += new System.EventHandler(this.opencodbar_Click);
            // 
            // openimg
            // 
            this.openimg.BackgroundImage = global::Proyect_Kardex.Properties.Resources.list_1;
            this.openimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openimg.FlatAppearance.BorderSize = 0;
            this.openimg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openimg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.openimg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openimg.Location = new System.Drawing.Point(326, 538);
            this.openimg.Name = "openimg";
            this.openimg.Size = new System.Drawing.Size(19, 18);
            this.openimg.TabIndex = 20;
            this.openimg.UseVisualStyleBackColor = true;
            this.openimg.Click += new System.EventHandler(this.openimg_Click);
            // 
            // codGen
            // 
            this.codGen.BackgroundImage = global::Proyect_Kardex.Properties.Resources.barcodcol;
            this.codGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.codGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.codGen.FlatAppearance.BorderSize = 0;
            this.codGen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.codGen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.codGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codGen.Location = new System.Drawing.Point(382, 561);
            this.codGen.Name = "codGen";
            this.codGen.Size = new System.Drawing.Size(40, 40);
            this.codGen.TabIndex = 33;
            this.codGen.UseVisualStyleBackColor = true;
            this.codGen.Click += new System.EventHandler(this.codGen_Click);
            // 
            // picturefoto
            // 
            this.picturefoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picturefoto.Location = new System.Drawing.Point(527, 433);
            this.picturefoto.Name = "picturefoto";
            this.picturefoto.Size = new System.Drawing.Size(107, 122);
            this.picturefoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturefoto.TabIndex = 237;
            this.picturefoto.TabStop = false;
            // 
            // picturecodebar
            // 
            this.picturecodebar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picturecodebar.Location = new System.Drawing.Point(382, 454);
            this.picturecodebar.Name = "picturecodebar";
            this.picturecodebar.Size = new System.Drawing.Size(139, 82);
            this.picturecodebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturecodebar.TabIndex = 236;
            this.picturecodebar.TabStop = false;
            // 
            // veboton
            // 
            this.veboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.viewfoto;
            this.veboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.veboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.veboton.FlatAppearance.BorderSize = 0;
            this.veboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.veboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.veboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.veboton.Location = new System.Drawing.Point(443, 561);
            this.veboton.Name = "veboton";
            this.veboton.Size = new System.Drawing.Size(40, 40);
            this.veboton.TabIndex = 34;
            this.veboton.UseVisualStyleBackColor = true;
            this.veboton.Click += new System.EventHandler(this.veboton_Click);
            // 
            // salirboton
            // 
            this.salirboton.BackColor = System.Drawing.Color.Transparent;
            this.salirboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.close_off_512;
            this.salirboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salirboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salirboton.FlatAppearance.BorderSize = 0;
            this.salirboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.salirboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.salirboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirboton.Location = new System.Drawing.Point(600, 561);
            this.salirboton.Name = "salirboton";
            this.salirboton.Size = new System.Drawing.Size(40, 40);
            this.salirboton.TabIndex = 36;
            this.salirboton.UseVisualStyleBackColor = false;
            this.salirboton.Click += new System.EventHandler(this.salirboton_Click);
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
            this.saveboton.Location = new System.Drawing.Point(526, 561);
            this.saveboton.Name = "saveboton";
            this.saveboton.Size = new System.Drawing.Size(40, 40);
            this.saveboton.TabIndex = 35;
            this.saveboton.UseVisualStyleBackColor = false;
            this.saveboton.Click += new System.EventHandler(this.saveboton_Click);
            // 
            // dateTime2
            // 
            this.dateTime2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime2.Location = new System.Drawing.Point(105, 497);
            this.dateTime2.Name = "dateTime2";
            this.dateTime2.Size = new System.Drawing.Size(203, 20);
            this.dateTime2.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "Fecha de Creación";
            // 
            // checkdate
            // 
            this.checkdate.AutoSize = true;
            this.checkdate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkdate.Location = new System.Drawing.Point(17, 438);
            this.checkdate.Name = "checkdate";
            this.checkdate.Size = new System.Drawing.Size(140, 16);
            this.checkdate.TabIndex = 15;
            this.checkdate.Text = "Fecha de Vencimiento";
            this.checkdate.UseVisualStyleBackColor = true;
            this.checkdate.CheckedChanged += new System.EventHandler(this.checkdate_CheckedChanged);
            // 
            // AddProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(656, 606);
            this.Controls.Add(this.checkdate);
            this.Controls.Add(this.dateTime2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.opencodbar);
            this.Controls.Add(this.openimg);
            this.Controls.Add(this.codGen);
            this.Controls.Add(this.picturefoto);
            this.Controls.Add(this.picturecodebar);
            this.Controls.Add(this.textcodbar);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.textfoto);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.veboton);
            this.Controls.Add(this.salirboton);
            this.Controls.Add(this.saveboton);
            this.Controls.Add(this.dateprod);
            this.Controls.Add(this.statebox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textnamep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameprod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tituloprod);
            this.Controls.Add(this.codprod);
            this.Controls.Add(this.label26);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.AddProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturefoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturecodebar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox codprod;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.TextBox nameprod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textcant;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textnamep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox textvol;
        public System.Windows.Forms.TextBox textpeso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button botoncate;
        public System.Windows.Forms.Button botonmarca;
        public System.Windows.Forms.Button botonMed;
        public System.Windows.Forms.Button veboton;
        public System.Windows.Forms.Button salirboton;
        public System.Windows.Forms.Button saveboton;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Button botonprove;
        public System.Windows.Forms.TextBox textemprov;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox textcodprov;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox textPVU;
        public System.Windows.Forms.TextBox textCCU;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Button buscarprov;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox textfoto;
        public System.Windows.Forms.TextBox textcodbar;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.Button codGen;
        public System.Windows.Forms.Button openimg;
        public System.Windows.Forms.Button opencodbar;
        public System.Windows.Forms.Label tituloprod;
        public System.Windows.Forms.ComboBox catebox;
        public System.Windows.Forms.ComboBox subcatebox;
        public System.Windows.Forms.ComboBox nommarca;
        public System.Windows.Forms.ComboBox nommed;
        public System.Windows.Forms.ComboBox statebox;
        public System.Windows.Forms.DateTimePicker dateprod;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        public System.Windows.Forms.ComboBox ivabox;
        public System.Windows.Forms.PictureBox picturecodebar;
        public System.Windows.Forms.PictureBox picturefoto;
        public System.Windows.Forms.ToolTip toolRegProd;
        public System.Windows.Forms.DateTimePicker dateTime2;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.CheckBox checkdate;
    }
}