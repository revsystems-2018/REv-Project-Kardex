namespace Proyect_Kardex
{
    partial class SolUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ciuser = new System.Windows.Forms.TextBox();
            this.nomus = new System.Windows.Forms.TextBox();
            this.apeus = new System.Windows.Forms.TextBox();
            this.sexmax = new System.Windows.Forms.RadioButton();
            this.sexfem = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dia = new System.Windows.Forms.ComboBox();
            this.mes = new System.Windows.Forms.ComboBox();
            this.anno = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dirus = new System.Windows.Forms.TextBox();
            this.depaus = new System.Windows.Forms.ComboBox();
            this.provus = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.salirboton = new System.Windows.Forms.Button();
            this.saveboton = new System.Windows.Forms.Button();
            this.passus = new System.Windows.Forms.TextBox();
            this.confpsss = new System.Windows.Forms.TextBox();
            this.nameus = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.corrus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.celus = new System.Windows.Forms.TextBox();
            this.telus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.toolSolUser = new System.Windows.Forms.ToolTip(this.components);
            this.buscaredboton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro De Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Carnet de Identidad";
            // 
            // ciuser
            // 
            this.ciuser.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciuser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ciuser.Location = new System.Drawing.Point(136, 37);
            this.ciuser.Name = "ciuser";
            this.ciuser.Size = new System.Drawing.Size(161, 20);
            this.ciuser.TabIndex = 2;
            this.ciuser.Text = "C.I. del Usuario";
            this.ciuser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cisolClick);
            this.ciuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ciNumero);
            // 
            // nomus
            // 
            this.nomus.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nomus.Location = new System.Drawing.Point(136, 66);
            this.nomus.Name = "nomus";
            this.nomus.Size = new System.Drawing.Size(161, 20);
            this.nomus.TabIndex = 3;
            this.nomus.Text = "Nombres del Usuario";
            this.nomus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nombsolClick);
            this.nomus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomletra);
            // 
            // apeus
            // 
            this.apeus.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apeus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.apeus.Location = new System.Drawing.Point(136, 95);
            this.apeus.Name = "apeus";
            this.apeus.Size = new System.Drawing.Size(161, 20);
            this.apeus.TabIndex = 4;
            this.apeus.Text = "Apellido Paterno; Materno";
            this.apeus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.apelsolClick);
            this.apeus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apletra);
            // 
            // sexmax
            // 
            this.sexmax.AutoSize = true;
            this.sexmax.Checked = true;
            this.sexmax.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexmax.Location = new System.Drawing.Point(10, 28);
            this.sexmax.Name = "sexmax";
            this.sexmax.Size = new System.Drawing.Size(77, 16);
            this.sexmax.TabIndex = 11;
            this.sexmax.TabStop = true;
            this.sexmax.Text = "Masculino";
            this.sexmax.UseVisualStyleBackColor = true;
            // 
            // sexfem
            // 
            this.sexfem.AutoSize = true;
            this.sexfem.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexfem.Location = new System.Drawing.Point(93, 28);
            this.sexfem.Name = "sexfem";
            this.sexfem.Size = new System.Drawing.Size(75, 16);
            this.sexfem.TabIndex = 12;
            this.sexfem.Text = "Femenino";
            this.sexfem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sexmax);
            this.groupBox1.Controls.Add(this.sexfem);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(321, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 55);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha de Nacimiento ";
            // 
            // dia
            // 
            this.dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dia.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dia.FormattingEnabled = true;
            this.dia.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dia.Location = new System.Drawing.Point(335, 119);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(39, 20);
            this.dia.TabIndex = 13;
            // 
            // mes
            // 
            this.mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mes.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes.FormattingEnabled = true;
            this.mes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.mes.Location = new System.Drawing.Point(380, 119);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(43, 20);
            this.mes.TabIndex = 14;
            // 
            // anno
            // 
            this.anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anno.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anno.FormattingEnabled = true;
            this.anno.Items.AddRange(new object[] {
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018"});
            this.anno.Location = new System.Drawing.Point(429, 119);
            this.anno.Name = "anno";
            this.anno.Size = new System.Drawing.Size(53, 20);
            this.anno.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "Departamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "Provincia ";
            // 
            // dirus
            // 
            this.dirus.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dirus.Location = new System.Drawing.Point(136, 225);
            this.dirus.Name = "dirus";
            this.dirus.Size = new System.Drawing.Size(161, 20);
            this.dirus.TabIndex = 8;
            this.dirus.Text = "Ubicación del Usuario";
            this.dirus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dirsolClick);
            this.dirus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dirus_KeyPress);
            // 
            // depaus
            // 
            this.depaus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depaus.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depaus.FormattingEnabled = true;
            this.depaus.Location = new System.Drawing.Point(136, 254);
            this.depaus.Name = "depaus";
            this.depaus.Size = new System.Drawing.Size(161, 20);
            this.depaus.TabIndex = 9;
            this.depaus.SelectedIndexChanged += new System.EventHandler(this.depaus_SelectedIndexChanged);
            // 
            // provus
            // 
            this.provus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provus.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provus.FormattingEnabled = true;
            this.provus.Location = new System.Drawing.Point(136, 285);
            this.provus.Name = "provus";
            this.provus.Size = new System.Drawing.Size(161, 20);
            this.provus.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(362, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 11);
            this.label12.TabIndex = 32;
            this.label12.Text = "Guardar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(444, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 11);
            this.label13.TabIndex = 33;
            this.label13.Text = "Cancelar";
            // 
            // salirboton
            // 
            this.salirboton.BackColor = System.Drawing.Color.Transparent;
            this.salirboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.off;
            this.salirboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salirboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salirboton.FlatAppearance.BorderSize = 0;
            this.salirboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.salirboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.salirboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirboton.Location = new System.Drawing.Point(449, 267);
            this.salirboton.Name = "salirboton";
            this.salirboton.Size = new System.Drawing.Size(30, 30);
            this.salirboton.TabIndex = 20;
            this.salirboton.UseVisualStyleBackColor = false;
            this.salirboton.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveboton
            // 
            this.saveboton.BackColor = System.Drawing.Color.Transparent;
            this.saveboton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveboton.BackgroundImage")));
            this.saveboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveboton.FlatAppearance.BorderSize = 0;
            this.saveboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.saveboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveboton.Location = new System.Drawing.Point(367, 267);
            this.saveboton.Name = "saveboton";
            this.saveboton.Size = new System.Drawing.Size(30, 30);
            this.saveboton.TabIndex = 19;
            this.saveboton.UseVisualStyleBackColor = false;
            this.saveboton.Click += new System.EventHandler(this.saveboton_Click);
            // 
            // passus
            // 
            this.passus.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passus.Location = new System.Drawing.Point(136, 153);
            this.passus.Name = "passus";
            this.passus.PasswordChar = '*';
            this.passus.Size = new System.Drawing.Size(161, 21);
            this.passus.TabIndex = 6;
            // 
            // confpsss
            // 
            this.confpsss.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confpsss.Location = new System.Drawing.Point(136, 181);
            this.confpsss.Name = "confpsss";
            this.confpsss.PasswordChar = '*';
            this.confpsss.Size = new System.Drawing.Size(161, 21);
            this.confpsss.TabIndex = 7;
            // 
            // nameus
            // 
            this.nameus.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nameus.Location = new System.Drawing.Point(136, 124);
            this.nameus.Name = "nameus";
            this.nameus.Size = new System.Drawing.Size(161, 20);
            this.nameus.TabIndex = 5;
            this.nameus.Text = "Nombre de Usuario";
            this.nameus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.namesolClick);
            this.nameus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameus_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 12);
            this.label14.TabIndex = 36;
            this.label14.Text = "Confirmar Contraseña";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(63, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 12);
            this.label15.TabIndex = 35;
            this.label15.Text = "Contraseña";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 12);
            this.label16.TabIndex = 34;
            this.label16.Text = "Nombre de Usuario";
            // 
            // corrus
            // 
            this.corrus.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corrus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.corrus.Location = new System.Drawing.Point(329, 161);
            this.corrus.Name = "corrus";
            this.corrus.Size = new System.Drawing.Size(161, 20);
            this.corrus.TabIndex = 16;
            this.corrus.Text = "Correo Electrónico";
            this.corrus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.corrsolClick);
            this.corrus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.corrus_KeyPress);
            this.corrus.Leave += new System.EventHandler(this.corrus_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "E-mail";
            // 
            // celus
            // 
            this.celus.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.celus.Location = new System.Drawing.Point(329, 240);
            this.celus.Name = "celus";
            this.celus.Size = new System.Drawing.Size(161, 20);
            this.celus.TabIndex = 18;
            this.celus.Text = "Teléfono Privado";
            this.celus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.celsolClick);
            this.celus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.celNum);
            // 
            // telus
            // 
            this.telus.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.telus.Location = new System.Drawing.Point(329, 201);
            this.telus.Name = "telus";
            this.telus.Size = new System.Drawing.Size(161, 20);
            this.telus.TabIndex = 17;
            this.telus.Text = "Teléfono Fijo";
            this.telus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.telsolClick);
            this.telus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telNum);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(327, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 12);
            this.label11.TabIndex = 51;
            this.label11.Text = "Celular";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(327, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 12);
            this.label17.TabIndex = 50;
            this.label17.Text = "Teléfono";
            // 
            // buscaredboton
            // 
            this.buscaredboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.search1;
            this.buscaredboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscaredboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscaredboton.FlatAppearance.BorderSize = 0;
            this.buscaredboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buscaredboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buscaredboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscaredboton.Location = new System.Drawing.Point(277, 38);
            this.buscaredboton.Name = "buscaredboton";
            this.buscaredboton.Size = new System.Drawing.Size(19, 18);
            this.buscaredboton.TabIndex = 52;
            this.buscaredboton.UseVisualStyleBackColor = true;
            this.buscaredboton.Visible = false;
            this.buscaredboton.Click += new System.EventHandler(this.buscaredboton_Click);
            // 
            // SolUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(500, 313);
            this.Controls.Add(this.buscaredboton);
            this.Controls.Add(this.celus);
            this.Controls.Add(this.telus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.corrus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passus);
            this.Controls.Add(this.confpsss);
            this.Controls.Add(this.nameus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.salirboton);
            this.Controls.Add(this.saveboton);
            this.Controls.Add(this.provus);
            this.Controls.Add(this.depaus);
            this.Controls.Add(this.dirus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.anno);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.apeus);
            this.Controls.Add(this.nomus);
            this.Controls.Add(this.ciuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SolUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de Usuario";
            this.Load += new System.EventHandler(this.SolUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.ToolTip toolSolUser;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton sexmax;
        public System.Windows.Forms.RadioButton sexfem;
        public System.Windows.Forms.Button buscaredboton;
        public System.Windows.Forms.TextBox ciuser;
        public System.Windows.Forms.TextBox nomus;
        public System.Windows.Forms.TextBox apeus;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox dia;
        public System.Windows.Forms.ComboBox mes;
        public System.Windows.Forms.ComboBox anno;
        public System.Windows.Forms.TextBox dirus;
        public System.Windows.Forms.ComboBox depaus;
        public System.Windows.Forms.ComboBox provus;
        public System.Windows.Forms.Button saveboton;
        public System.Windows.Forms.Button salirboton;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox passus;
        public System.Windows.Forms.TextBox confpsss;
        public System.Windows.Forms.TextBox nameus;
        public System.Windows.Forms.TextBox corrus;
        public System.Windows.Forms.TextBox celus;
        public System.Windows.Forms.TextBox telus;
    }
}