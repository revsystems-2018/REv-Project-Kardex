namespace Proyect_Kardex
{
    partial class RegProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegProveedor));
            this.pagorep = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.logorep = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.fecharep = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.webrep = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.faxrep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.celrep = new System.Windows.Forms.TextBox();
            this.telrep = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.correp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.apeduep = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.provrep = new System.Windows.Forms.ComboBox();
            this.deparep = new System.Windows.Forms.ComboBox();
            this.direp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nombduep = new System.Windows.Forms.TextBox();
            this.ciduep = new System.Windows.Forms.TextBox();
            this.codrep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.anno = new System.Windows.Forms.ComboBox();
            this.mes = new System.Windows.Forms.ComboBox();
            this.dia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sexmax = new System.Windows.Forms.RadioButton();
            this.sexfem = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.celduep = new System.Windows.Forms.TextBox();
            this.telduep = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.nitempp = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.namerep = new System.Windows.Forms.TextBox();
            this.starep = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.genboton = new System.Windows.Forms.Button();
            this.verboton = new System.Windows.Forms.Button();
            this.openboton = new System.Windows.Forms.Button();
            this.logoview = new System.Windows.Forms.PictureBox();
            this.salirboton = new System.Windows.Forms.Button();
            this.saveboton = new System.Windows.Forms.Button();
            this.toolregpro = new System.Windows.Forms.ToolTip(this.components);
            this.weboton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoview)).BeginInit();
            this.SuspendLayout();
            // 
            // pagorep
            // 
            this.pagorep.AutoCompleteCustomSource.AddRange(new string[] {
            "Nuevo",
            "Activo",
            "Inactivo",
            "Suspendido"});
            this.pagorep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagorep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagorep.FormattingEnabled = true;
            this.pagorep.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARGETA DE CRÉDITO",
            "TARGETA DE DÉBITO",
            "CHEQUE"});
            this.pagorep.Location = new System.Drawing.Point(136, 403);
            this.pagorep.Name = "pagorep";
            this.pagorep.Size = new System.Drawing.Size(114, 20);
            this.pagorep.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(76, 388);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 12);
            this.label20.TabIndex = 146;
            this.label20.Text = "Forma de Pago";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(413, 412);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 11);
            this.label19.TabIndex = 144;
            this.label19.Text = "Ver";
            // 
            // logorep
            // 
            this.logorep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logorep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.logorep.Location = new System.Drawing.Point(389, 247);
            this.logorep.Name = "logorep";
            this.logorep.Size = new System.Drawing.Size(222, 20);
            this.logorep.TabIndex = 25;
            this.logorep.Text = "Ubicación del Logotipo de Empresa";
            this.logorep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.logoempregClick);
            this.logorep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logorep_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(387, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 12);
            this.label18.TabIndex = 141;
            this.label18.Text = "Logo de la Empresa";
            // 
            // fecharep
            // 
            this.fecharep.CalendarFont = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharep.Location = new System.Drawing.Point(389, 305);
            this.fecharep.Name = "fecharep";
            this.fecharep.Size = new System.Drawing.Size(222, 20);
            this.fecharep.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(387, 286);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 12);
            this.label15.TabIndex = 137;
            this.label15.Text = "Fecha de Creación";
            // 
            // webrep
            // 
            this.webrep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webrep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.webrep.Location = new System.Drawing.Point(136, 278);
            this.webrep.Name = "webrep";
            this.webrep.Size = new System.Drawing.Size(222, 20);
            this.webrep.TabIndex = 13;
            this.webrep.Text = "Pagina Web de la Empresa";
            this.webrep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.webempregClick);
            this.webrep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.webrep_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(103, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 12);
            this.label14.TabIndex = 136;
            this.label14.Text = "Web";
            // 
            // faxrep
            // 
            this.faxrep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxrep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.faxrep.Location = new System.Drawing.Point(389, 207);
            this.faxrep.Name = "faxrep";
            this.faxrep.Size = new System.Drawing.Size(116, 20);
            this.faxrep.TabIndex = 24;
            this.faxrep.Text = "Número de Fax";
            this.faxrep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.faxempregClick);
            this.faxrep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.faxemp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(387, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 12);
            this.label10.TabIndex = 134;
            this.label10.Text = "Fax";
            // 
            // celrep
            // 
            this.celrep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celrep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.celrep.Location = new System.Drawing.Point(389, 168);
            this.celrep.Name = "celrep";
            this.celrep.Size = new System.Drawing.Size(116, 20);
            this.celrep.TabIndex = 23;
            this.celrep.Text = "Telélefono Privado";
            this.celrep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.celempregClick);
            this.celrep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.celemp);
            // 
            // telrep
            // 
            this.telrep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telrep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.telrep.Location = new System.Drawing.Point(389, 129);
            this.telrep.Name = "telrep";
            this.telrep.Size = new System.Drawing.Size(116, 20);
            this.telrep.TabIndex = 22;
            this.telrep.Text = "Teléfono Fijo";
            this.telrep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.telempregClick);
            this.telrep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telemp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(387, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 12);
            this.label11.TabIndex = 132;
            this.label11.Text = "Celular";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(387, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 12);
            this.label17.TabIndex = 131;
            this.label17.Text = "Teléfono";
            // 
            // correp
            // 
            this.correp.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.correp.Location = new System.Drawing.Point(136, 252);
            this.correp.Name = "correp";
            this.correp.Size = new System.Drawing.Size(222, 20);
            this.correp.TabIndex = 12;
            this.correp.Text = "Correo Electronico de la Empresa";
            this.correp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.corempregClick);
            this.correp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.correp_KeyPress);
            this.correp.Leave += new System.EventHandler(this.correp_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 12);
            this.label4.TabIndex = 128;
            this.label4.Text = "E-mail";
            // 
            // apeduep
            // 
            this.apeduep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apeduep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.apeduep.Location = new System.Drawing.Point(112, 67);
            this.apeduep.Name = "apeduep";
            this.apeduep.Size = new System.Drawing.Size(222, 20);
            this.apeduep.TabIndex = 4;
            this.apeduep.Text = "Apellido Paterno; Materno";
            this.apeduep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.apesuregClick);
            this.apeduep.TextChanged += new System.EventHandler(this.apeduep_TextChanged);
            this.apeduep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apedue);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 12);
            this.label16.TabIndex = 127;
            this.label16.Text = "Carnet Identidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(566, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 11);
            this.label13.TabIndex = 126;
            this.label13.Text = "Cancelar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(495, 412);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 11);
            this.label12.TabIndex = 125;
            this.label12.Text = "Guardar";
            // 
            // provrep
            // 
            this.provrep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provrep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provrep.FormattingEnabled = true;
            this.provrep.Location = new System.Drawing.Point(136, 361);
            this.provrep.Name = "provrep";
            this.provrep.Size = new System.Drawing.Size(222, 20);
            this.provrep.TabIndex = 17;
            // 
            // deparep
            // 
            this.deparep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deparep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deparep.FormattingEnabled = true;
            this.deparep.Location = new System.Drawing.Point(136, 334);
            this.deparep.Name = "deparep";
            this.deparep.Size = new System.Drawing.Size(222, 20);
            this.deparep.TabIndex = 16;
            this.deparep.SelectedIndexChanged += new System.EventHandler(this.deparep_SelectedIndexChanged);
            // 
            // direp
            // 
            this.direp.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.direp.Location = new System.Drawing.Point(136, 308);
            this.direp.Name = "direp";
            this.direp.Size = new System.Drawing.Size(222, 20);
            this.direp.TabIndex = 15;
            this.direp.Text = "Ubicación de la Empresa del Proveedor";
            this.direp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dirempregClick);
            this.direp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.direp_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(76, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 12);
            this.label9.TabIndex = 124;
            this.label9.Text = "Provincia";
            // 
            // nombduep
            // 
            this.nombduep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombduep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nombduep.Location = new System.Drawing.Point(112, 41);
            this.nombduep.Name = "nombduep";
            this.nombduep.Size = new System.Drawing.Size(222, 20);
            this.nombduep.TabIndex = 3;
            this.nombduep.Text = "Nombres del Supervisor";
            this.nombduep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.namesuregClick);
            this.nombduep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomdue);
            // 
            // ciduep
            // 
            this.ciduep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciduep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ciduep.Location = new System.Drawing.Point(112, 15);
            this.ciduep.Name = "ciduep";
            this.ciduep.Size = new System.Drawing.Size(161, 20);
            this.ciduep.TabIndex = 2;
            this.ciduep.Text = "C.I. de Supervisor";
            this.ciduep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cisuregClick);
            this.ciduep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // codrep
            // 
            this.codrep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codrep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.codrep.Location = new System.Drawing.Point(136, 37);
            this.codrep.Name = "codrep";
            this.codrep.Size = new System.Drawing.Size(161, 20);
            this.codrep.TabIndex = 2;
            this.codrep.Text = "Codigo de Registro";
            this.codrep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.codrepClick);
            this.codrep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codreg);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 12);
            this.label5.TabIndex = 108;
            this.label5.Text = "Código de Registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 107;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 104;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro De Proveedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 12);
            this.label8.TabIndex = 120;
            this.label8.Text = "Dirección";
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
            this.anno.Location = new System.Drawing.Point(281, 116);
            this.anno.Name = "anno";
            this.anno.Size = new System.Drawing.Size(53, 20);
            this.anno.TabIndex = 9;
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
            this.mes.Location = new System.Drawing.Point(232, 116);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(43, 20);
            this.mes.TabIndex = 8;
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
            this.dia.Location = new System.Drawing.Point(187, 116);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(39, 20);
            this.dia.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 12);
            this.label6.TabIndex = 116;
            this.label6.Text = "Fecha de Nacimiento ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sexmax);
            this.groupBox1.Controls.Add(this.sexfem);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 55);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // sexmax
            // 
            this.sexmax.AutoSize = true;
            this.sexmax.Checked = true;
            this.sexmax.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexmax.Location = new System.Drawing.Point(3, 23);
            this.sexmax.Name = "sexmax";
            this.sexmax.Size = new System.Drawing.Size(77, 16);
            this.sexmax.TabIndex = 5;
            this.sexmax.TabStop = true;
            this.sexmax.Text = "Masculino";
            this.sexmax.UseVisualStyleBackColor = true;
            // 
            // sexfem
            // 
            this.sexfem.AutoSize = true;
            this.sexfem.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexfem.Location = new System.Drawing.Point(86, 23);
            this.sexfem.Name = "sexfem";
            this.sexfem.Size = new System.Drawing.Size(75, 16);
            this.sexfem.TabIndex = 6;
            this.sexfem.Text = "Femenino";
            this.sexfem.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 122;
            this.label7.Text = "Departamento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.celduep);
            this.groupBox2.Controls.Add(this.telduep);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.ciduep);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nombduep);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.apeduep);
            this.groupBox2.Controls.Add(this.mes);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dia);
            this.groupBox2.Controls.Add(this.anno);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 181);
            this.groupBox2.TabIndex = 148;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supervisor";
            // 
            // celduep
            // 
            this.celduep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celduep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.celduep.Location = new System.Drawing.Point(232, 154);
            this.celduep.Name = "celduep";
            this.celduep.Size = new System.Drawing.Size(102, 20);
            this.celduep.TabIndex = 11;
            this.celduep.Text = "Teléfono Privado";
            this.celduep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.celsuregClick);
            this.celduep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.celdue);
            // 
            // telduep
            // 
            this.telduep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telduep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.telduep.Location = new System.Drawing.Point(112, 154);
            this.telduep.Name = "telduep";
            this.telduep.Size = new System.Drawing.Size(114, 20);
            this.telduep.TabIndex = 10;
            this.telduep.Text = "Teléfono Fijo";
            this.telduep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.telsuregClick);
            this.telduep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teldue);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(48, 157);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 12);
            this.label23.TabIndex = 154;
            this.label23.Text = "Teléfonos";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(387, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 12);
            this.label21.TabIndex = 149;
            this.label21.Text = "NIT";
            // 
            // nitempp
            // 
            this.nitempp.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nitempp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nitempp.Location = new System.Drawing.Point(416, 37);
            this.nitempp.Name = "nitempp";
            this.nitempp.Size = new System.Drawing.Size(195, 20);
            this.nitempp.TabIndex = 20;
            this.nitempp.Text = "NIT de la Empresa del Proveedor";
            this.nitempp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nitempregClick);
            this.nitempp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nitemp);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(387, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(125, 12);
            this.label22.TabIndex = 151;
            this.label22.Text = "Nombre de la Empresa";
            // 
            // namerep
            // 
            this.namerep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namerep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.namerep.Location = new System.Drawing.Point(416, 78);
            this.namerep.Name = "namerep";
            this.namerep.Size = new System.Drawing.Size(195, 20);
            this.namerep.TabIndex = 21;
            this.namerep.Text = "Nombre o Iniciales de la Empresa";
            this.namerep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nameempregClick);
            this.namerep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.namerep_KeyPress);
            // 
            // starep
            // 
            this.starep.AutoCompleteCustomSource.AddRange(new string[] {
            "Nuevo",
            "Activo",
            "Inactivo",
            "Suspendido"});
            this.starep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.starep.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starep.FormattingEnabled = true;
            this.starep.Items.AddRange(new object[] {
            "Nuevo",
            "Disponible",
            "Activo",
            "Ausente"});
            this.starep.Location = new System.Drawing.Point(256, 403);
            this.starep.Name = "starep";
            this.starep.Size = new System.Drawing.Size(102, 20);
            this.starep.TabIndex = 19;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(254, 388);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 12);
            this.label24.TabIndex = 154;
            this.label24.Text = "Estado";
            // 
            // genboton
            // 
            this.genboton.BackColor = System.Drawing.Color.Transparent;
            this.genboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.magic;
            this.genboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.genboton.FlatAppearance.BorderSize = 0;
            this.genboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.genboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.genboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genboton.Location = new System.Drawing.Point(277, 38);
            this.genboton.Name = "genboton";
            this.genboton.Size = new System.Drawing.Size(19, 18);
            this.genboton.TabIndex = 32;
            this.genboton.UseVisualStyleBackColor = false;
            this.genboton.Click += new System.EventHandler(this.genboton_Click);
            // 
            // verboton
            // 
            this.verboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.ver;
            this.verboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verboton.FlatAppearance.BorderSize = 0;
            this.verboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.verboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.verboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verboton.Location = new System.Drawing.Point(405, 379);
            this.verboton.Name = "verboton";
            this.verboton.Size = new System.Drawing.Size(30, 30);
            this.verboton.TabIndex = 28;
            this.verboton.UseVisualStyleBackColor = true;
            this.verboton.Click += new System.EventHandler(this.verboton_Click);
            // 
            // openboton
            // 
            this.openboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.list_1;
            this.openboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openboton.FlatAppearance.BorderSize = 0;
            this.openboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.openboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openboton.Location = new System.Drawing.Point(590, 248);
            this.openboton.Name = "openboton";
            this.openboton.Size = new System.Drawing.Size(19, 18);
            this.openboton.TabIndex = 26;
            this.openboton.UseVisualStyleBackColor = true;
            this.openboton.Click += new System.EventHandler(this.openboton_Click);
            // 
            // logoview
            // 
            this.logoview.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.logoview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoview.Location = new System.Drawing.Point(511, 118);
            this.logoview.Name = "logoview";
            this.logoview.Size = new System.Drawing.Size(100, 123);
            this.logoview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoview.TabIndex = 139;
            this.logoview.TabStop = false;
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
            this.salirboton.Location = new System.Drawing.Point(572, 379);
            this.salirboton.Name = "salirboton";
            this.salirboton.Size = new System.Drawing.Size(30, 30);
            this.salirboton.TabIndex = 30;
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
            this.saveboton.Location = new System.Drawing.Point(498, 379);
            this.saveboton.Name = "saveboton";
            this.saveboton.Size = new System.Drawing.Size(30, 30);
            this.saveboton.TabIndex = 29;
            this.saveboton.UseVisualStyleBackColor = false;
            this.saveboton.Click += new System.EventHandler(this.saveboton_Click);
            // 
            // weboton
            // 
            this.weboton.BackColor = System.Drawing.SystemColors.Menu;
            this.weboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.weblogo;
            this.weboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weboton.FlatAppearance.BorderSize = 0;
            this.weboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.weboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.weboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weboton.Location = new System.Drawing.Point(337, 279);
            this.weboton.Name = "weboton";
            this.weboton.Size = new System.Drawing.Size(19, 18);
            this.weboton.TabIndex = 14;
            this.weboton.UseVisualStyleBackColor = false;
            this.weboton.Click += new System.EventHandler(this.weboton_Click);
            // 
            // RegProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(625, 429);
            this.Controls.Add(this.weboton);
            this.Controls.Add(this.starep);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.namerep);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.nitempp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.genboton);
            this.Controls.Add(this.pagorep);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.verboton);
            this.Controls.Add(this.openboton);
            this.Controls.Add(this.logorep);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.logoview);
            this.Controls.Add(this.fecharep);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.webrep);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.faxrep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.celrep);
            this.Controls.Add(this.telrep);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.correp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.salirboton);
            this.Controls.Add(this.saveboton);
            this.Controls.Add(this.provrep);
            this.Controls.Add(this.deparep);
            this.Controls.Add(this.direp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.codrep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Proveedor";
            this.Load += new System.EventHandler(this.RegProveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.ToolTip toolregpro;
        public System.Windows.Forms.ComboBox pagorep;
        public System.Windows.Forms.Button verboton;
        public System.Windows.Forms.Button openboton;
        public System.Windows.Forms.TextBox logorep;
        public System.Windows.Forms.DateTimePicker fecharep;
        public System.Windows.Forms.TextBox webrep;
        public System.Windows.Forms.TextBox faxrep;
        public System.Windows.Forms.TextBox celrep;
        public System.Windows.Forms.TextBox telrep;
        public System.Windows.Forms.TextBox correp;
        public System.Windows.Forms.TextBox apeduep;
        public System.Windows.Forms.Button salirboton;
        public System.Windows.Forms.Button saveboton;
        public System.Windows.Forms.ComboBox provrep;
        public System.Windows.Forms.ComboBox deparep;
        public System.Windows.Forms.TextBox direp;
        public System.Windows.Forms.TextBox nombduep;
        public System.Windows.Forms.TextBox ciduep;
        public System.Windows.Forms.TextBox codrep;
        public System.Windows.Forms.ComboBox anno;
        public System.Windows.Forms.ComboBox mes;
        public System.Windows.Forms.ComboBox dia;
        public System.Windows.Forms.Button genboton;
        public System.Windows.Forms.TextBox celduep;
        public System.Windows.Forms.TextBox telduep;
        public System.Windows.Forms.TextBox nitempp;
        public System.Windows.Forms.TextBox namerep;
        public System.Windows.Forms.ComboBox starep;
        public System.Windows.Forms.PictureBox logoview;
        public System.Windows.Forms.Button weboton;
        public System.Windows.Forms.RadioButton sexmax;
        public System.Windows.Forms.RadioButton sexfem;
    }
}