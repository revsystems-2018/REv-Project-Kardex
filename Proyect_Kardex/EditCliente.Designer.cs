namespace Proyect_Kardex
{
    partial class EditCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCliente));
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ciedcli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.staed = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.fotoed = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.fechaed = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.webed = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.faxed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.celed = new System.Windows.Forms.TextBox();
            this.teled = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.corred = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nited = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.proved = new System.Windows.Forms.ComboBox();
            this.depaed = new System.Windows.Forms.ComboBox();
            this.dired = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.apeled = new System.Windows.Forms.TextBox();
            this.nomed = new System.Windows.Forms.TextBox();
            this.ci = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.anno = new System.Windows.Forms.ComboBox();
            this.mes = new System.Windows.Forms.ComboBox();
            this.dia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sexMax = new System.Windows.Forms.RadioButton();
            this.sexFem = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.tooleditcliente = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.verboton = new System.Windows.Forms.Button();
            this.openboton = new System.Windows.Forms.Button();
            this.fotoCliente = new System.Windows.Forms.PictureBox();
            this.salirboton = new System.Windows.Forms.Button();
            this.saveboton = new System.Windows.Forms.Button();
            this.regboton = new System.Windows.Forms.Button();
            this.buscaredboton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(512, 57);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 11);
            this.label23.TabIndex = 205;
            this.label23.Text = "Regsitro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificar Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ciedcli
            // 
            this.ciedcli.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciedcli.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ciedcli.Location = new System.Drawing.Point(148, 34);
            this.ciedcli.Name = "ciedcli";
            this.ciedcli.Size = new System.Drawing.Size(347, 20);
            this.ciedcli.TabIndex = 2;
            this.ciedcli.Text = "C.I. del Cliente a Modificar";
            this.ciedcli.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ciedclientClick);
            this.ciedcli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.busquedaci);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 12);
            this.label5.TabIndex = 200;
            this.label5.Text = "Carnet de Identidad";
            // 
            // staed
            // 
            this.staed.AutoCompleteCustomSource.AddRange(new string[] {
            "Nuevo",
            "Activo",
            "Inactivo",
            "Suspendido"});
            this.staed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staed.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staed.FormattingEnabled = true;
            this.staed.Items.AddRange(new object[] {
            "Nuevo",
            "Disponible",
            "Activo",
            "Ausente"});
            this.staed.Location = new System.Drawing.Point(148, 376);
            this.staed.Name = "staed";
            this.staed.Size = new System.Drawing.Size(161, 20);
            this.staed.TabIndex = 16;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(101, 380);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 248;
            this.label20.Text = "Estado";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(343, 388);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 11);
            this.label19.TabIndex = 246;
            this.label19.Text = "Ver";
            // 
            // fotoed
            // 
            this.fotoed.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fotoed.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.fotoed.Location = new System.Drawing.Point(331, 320);
            this.fotoed.Name = "fotoed";
            this.fotoed.Size = new System.Drawing.Size(222, 20);
            this.fotoed.TabIndex = 25;
            this.fotoed.Text = "Cambiar Fotografia de Perfil";
            this.fotoed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fotoedClientClick);
            this.fotoed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fotoed_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(329, 305);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 12);
            this.label18.TabIndex = 243;
            this.label18.Text = "Foto de Perfil";
            // 
            // fechaed
            // 
            this.fechaed.CalendarFont = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaed.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaed.Location = new System.Drawing.Point(126, 349);
            this.fechaed.Name = "fechaed";
            this.fechaed.Size = new System.Drawing.Size(183, 20);
            this.fechaed.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 334);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 12);
            this.label15.TabIndex = 239;
            this.label15.Text = "Fecha de Modificación";
            // 
            // webed
            // 
            this.webed.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webed.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.webed.Location = new System.Drawing.Point(85, 213);
            this.webed.Name = "webed";
            this.webed.Size = new System.Drawing.Size(224, 20);
            this.webed.TabIndex = 10;
            this.webed.Text = "Nueva Pagina Web";
            this.webed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.webedClienteClick);
            this.webed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.webed_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(52, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 12);
            this.label14.TabIndex = 238;
            this.label14.Text = "Web";
            // 
            // faxed
            // 
            this.faxed.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxed.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.faxed.Location = new System.Drawing.Point(331, 280);
            this.faxed.Name = "faxed";
            this.faxed.Size = new System.Drawing.Size(116, 20);
            this.faxed.TabIndex = 24;
            this.faxed.Text = "Nuevo Fax";
            this.faxed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.faxedClientClick);
            this.faxed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.faxCliente);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(329, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 12);
            this.label10.TabIndex = 236;
            this.label10.Text = "Fax";
            // 
            // celed
            // 
            this.celed.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celed.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.celed.Location = new System.Drawing.Point(331, 241);
            this.celed.Name = "celed";
            this.celed.Size = new System.Drawing.Size(116, 20);
            this.celed.TabIndex = 23;
            this.celed.Text = "Nuevo Celular";
            this.celed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.celedClientClick);
            this.celed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.celCliente);
            // 
            // teled
            // 
            this.teled.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teled.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.teled.Location = new System.Drawing.Point(331, 202);
            this.teled.Name = "teled";
            this.teled.Size = new System.Drawing.Size(116, 20);
            this.teled.TabIndex = 22;
            this.teled.Text = "Nuevo Teléfono";
            this.teled.MouseClick += new System.Windows.Forms.MouseEventHandler(this.teledClientClick);
            this.teled.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telCliente);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(329, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 12);
            this.label11.TabIndex = 234;
            this.label11.Text = "Celular";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(329, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 12);
            this.label17.TabIndex = 233;
            this.label17.Text = "Teléfono";
            // 
            // corred
            // 
            this.corred.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corred.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.corred.Location = new System.Drawing.Point(85, 187);
            this.corred.Name = "corred";
            this.corred.Size = new System.Drawing.Size(224, 20);
            this.corred.TabIndex = 9;
            this.corred.Text = "Nuevo Correo Electrónico";
            this.corred.MouseClick += new System.Windows.Forms.MouseEventHandler(this.coredClientClick);
            this.corred.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.corred_KeyPress);
            this.corred.Leave += new System.EventHandler(this.emailClientreg);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 12);
            this.label4.TabIndex = 230;
            this.label4.Text = "E-mail";
            // 
            // nited
            // 
            this.nited.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nited.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nited.Location = new System.Drawing.Point(148, 159);
            this.nited.Name = "nited";
            this.nited.Size = new System.Drawing.Size(161, 20);
            this.nited.TabIndex = 8;
            this.nited.Text = "NIT del Cliente";
            this.nited.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nitedClienteClick);
            this.nited.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nitCliente);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(119, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 12);
            this.label16.TabIndex = 229;
            this.label16.Text = "NIT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(496, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 11);
            this.label13.TabIndex = 228;
            this.label13.Text = "Cancelar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(431, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 11);
            this.label12.TabIndex = 227;
            this.label12.Text = "Editar";
            // 
            // proved
            // 
            this.proved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proved.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proved.FormattingEnabled = true;
            this.proved.Location = new System.Drawing.Point(148, 304);
            this.proved.Name = "proved";
            this.proved.Size = new System.Drawing.Size(161, 20);
            this.proved.TabIndex = 14;
            // 
            // depaed
            // 
            this.depaed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depaed.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depaed.FormattingEnabled = true;
            this.depaed.Location = new System.Drawing.Point(148, 273);
            this.depaed.Name = "depaed";
            this.depaed.Size = new System.Drawing.Size(161, 20);
            this.depaed.TabIndex = 13;
            this.depaed.SelectedIndexChanged += new System.EventHandler(this.depaed_SelectedIndexChanged);
            // 
            // dired
            // 
            this.dired.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dired.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dired.Location = new System.Drawing.Point(148, 244);
            this.dired.Name = "dired";
            this.dired.Size = new System.Drawing.Size(161, 20);
            this.dired.TabIndex = 12;
            this.dired.Text = "Nueva Ubicación del Cliente";
            this.dired.MouseClick += new System.Windows.Forms.MouseEventHandler(this.diredClientClick);
            this.dired.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dired_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(85, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 226;
            this.label9.Text = "Provincia ";
            // 
            // apeled
            // 
            this.apeled.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apeled.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.apeled.Location = new System.Drawing.Point(148, 130);
            this.apeled.Name = "apeled";
            this.apeled.Size = new System.Drawing.Size(161, 20);
            this.apeled.TabIndex = 7;
            this.apeled.Text = "Apellido Paterno; Materno";
            this.apeled.MouseClick += new System.Windows.Forms.MouseEventHandler(this.apedClientClick);
            this.apeled.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apeCliente);
            // 
            // nomed
            // 
            this.nomed.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomed.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nomed.Location = new System.Drawing.Point(148, 101);
            this.nomed.Name = "nomed";
            this.nomed.Size = new System.Drawing.Size(161, 20);
            this.nomed.TabIndex = 6;
            this.nomed.Text = "Nombres del Cliente";
            this.nomed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nomedClientClick);
            this.nomed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomCliente);
            // 
            // ci
            // 
            this.ci.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ci.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ci.Location = new System.Drawing.Point(148, 72);
            this.ci.Name = "ci";
            this.ci.Size = new System.Drawing.Size(161, 20);
            this.ci.TabIndex = 5;
            this.ci.Text = "C.I. del Cliente";
            this.ci.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ciClientClick);
            this.ci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ciCliente);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 12);
            this.label2.TabIndex = 210;
            this.label2.Text = "Carnet de Identidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 209;
            this.label3.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 12);
            this.label6.TabIndex = 206;
            this.label6.Text = "Nombres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 12);
            this.label8.TabIndex = 222;
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
            this.anno.Location = new System.Drawing.Point(431, 154);
            this.anno.Name = "anno";
            this.anno.Size = new System.Drawing.Size(53, 20);
            this.anno.TabIndex = 21;
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
            this.mes.Location = new System.Drawing.Point(382, 154);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(43, 20);
            this.mes.TabIndex = 20;
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
            this.dia.Location = new System.Drawing.Point(337, 154);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(39, 20);
            this.dia.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 12);
            this.label7.TabIndex = 218;
            this.label7.Text = "Fecha de Nacimiento ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sexMax);
            this.groupBox1.Controls.Add(this.sexFem);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(323, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 55);
            this.groupBox1.TabIndex = 216;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // sexMax
            // 
            this.sexMax.AutoSize = true;
            this.sexMax.Checked = true;
            this.sexMax.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexMax.Location = new System.Drawing.Point(10, 28);
            this.sexMax.Name = "sexMax";
            this.sexMax.Size = new System.Drawing.Size(77, 16);
            this.sexMax.TabIndex = 17;
            this.sexMax.TabStop = true;
            this.sexMax.Text = "Masculino";
            this.sexMax.UseVisualStyleBackColor = true;
            // 
            // sexFem
            // 
            this.sexFem.AutoSize = true;
            this.sexFem.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexFem.Location = new System.Drawing.Point(93, 28);
            this.sexFem.Name = "sexFem";
            this.sexFem.Size = new System.Drawing.Size(75, 16);
            this.sexFem.TabIndex = 18;
            this.sexFem.Text = "Femenino";
            this.sexFem.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(61, 277);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 12);
            this.label21.TabIndex = 224;
            this.label21.Text = "Departamento";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.BackgroundImage = global::Proyect_Kardex.Properties.Resources.weblogo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(289, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 18);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // verboton
            // 
            this.verboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.ver;
            this.verboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verboton.FlatAppearance.BorderSize = 0;
            this.verboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.verboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.verboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verboton.Location = new System.Drawing.Point(337, 355);
            this.verboton.Name = "verboton";
            this.verboton.Size = new System.Drawing.Size(30, 30);
            this.verboton.TabIndex = 27;
            this.verboton.UseVisualStyleBackColor = true;
            this.verboton.Click += new System.EventHandler(this.verboton_Click);
            // 
            // openboton
            // 
            this.openboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.list_1;
            this.openboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openboton.FlatAppearance.BorderSize = 0;
            this.openboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.openboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openboton.Location = new System.Drawing.Point(532, 321);
            this.openboton.Name = "openboton";
            this.openboton.Size = new System.Drawing.Size(19, 18);
            this.openboton.TabIndex = 26;
            this.openboton.UseVisualStyleBackColor = true;
            this.openboton.Click += new System.EventHandler(this.openboton_Click);
            // 
            // fotoCliente
            // 
            this.fotoCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fotoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fotoCliente.ImageLocation = "";
            this.fotoCliente.Location = new System.Drawing.Point(453, 191);
            this.fotoCliente.Name = "fotoCliente";
            this.fotoCliente.Size = new System.Drawing.Size(100, 123);
            this.fotoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoCliente.TabIndex = 241;
            this.fotoCliente.TabStop = false;
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
            this.salirboton.Location = new System.Drawing.Point(502, 355);
            this.salirboton.Name = "salirboton";
            this.salirboton.Size = new System.Drawing.Size(30, 30);
            this.salirboton.TabIndex = 29;
            this.salirboton.UseVisualStyleBackColor = false;
            this.salirboton.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveboton
            // 
            this.saveboton.BackColor = System.Drawing.Color.Transparent;
            this.saveboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editpencil;
            this.saveboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveboton.FlatAppearance.BorderSize = 0;
            this.saveboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.saveboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveboton.Location = new System.Drawing.Point(434, 355);
            this.saveboton.Name = "saveboton";
            this.saveboton.Size = new System.Drawing.Size(30, 30);
            this.saveboton.TabIndex = 28;
            this.saveboton.UseVisualStyleBackColor = false;
            this.saveboton.Click += new System.EventHandler(this.saveboton_Click);
            // 
            // regboton
            // 
            this.regboton.BackColor = System.Drawing.Color.Transparent;
            this.regboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.list;
            this.regboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regboton.FlatAppearance.BorderSize = 0;
            this.regboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.regboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.regboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regboton.Location = new System.Drawing.Point(518, 24);
            this.regboton.Name = "regboton";
            this.regboton.Size = new System.Drawing.Size(30, 30);
            this.regboton.TabIndex = 4;
            this.regboton.UseVisualStyleBackColor = false;
            this.regboton.Click += new System.EventHandler(this.regboton_Click);
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
            this.buscaredboton.Location = new System.Drawing.Point(475, 35);
            this.buscaredboton.Name = "buscaredboton";
            this.buscaredboton.Size = new System.Drawing.Size(19, 18);
            this.buscaredboton.TabIndex = 3;
            this.buscaredboton.UseVisualStyleBackColor = true;
            this.buscaredboton.Click += new System.EventHandler(this.buscaredboton_Click);
            // 
            // EditCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(560, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.staed);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.verboton);
            this.Controls.Add(this.openboton);
            this.Controls.Add(this.fotoed);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.fotoCliente);
            this.Controls.Add(this.fechaed);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.webed);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.faxed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.celed);
            this.Controls.Add(this.teled);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.corred);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nited);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.salirboton);
            this.Controls.Add(this.saveboton);
            this.Controls.Add(this.proved);
            this.Controls.Add(this.depaed);
            this.Controls.Add(this.dired);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.apeled);
            this.Controls.Add(this.nomed);
            this.Controls.Add(this.ci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.anno);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.regboton);
            this.Controls.Add(this.buscaredboton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ciedcli);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Cliente";
            this.Load += new System.EventHandler(this.EditCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.PictureBox fotoCliente;
        public System.Windows.Forms.ToolTip tooleditcliente;
        public System.Windows.Forms.Button regboton;
        public System.Windows.Forms.Button buscaredboton;
        public System.Windows.Forms.TextBox ciedcli;
        public System.Windows.Forms.ComboBox staed;
        public System.Windows.Forms.Button verboton;
        public System.Windows.Forms.Button openboton;
        public System.Windows.Forms.TextBox fotoed;
        public System.Windows.Forms.DateTimePicker fechaed;
        public System.Windows.Forms.TextBox webed;
        public System.Windows.Forms.TextBox faxed;
        public System.Windows.Forms.TextBox celed;
        public System.Windows.Forms.TextBox teled;
        public System.Windows.Forms.TextBox corred;
        public System.Windows.Forms.TextBox nited;
        public System.Windows.Forms.Button salirboton;
        public System.Windows.Forms.Button saveboton;
        public System.Windows.Forms.ComboBox proved;
        public System.Windows.Forms.ComboBox depaed;
        public System.Windows.Forms.TextBox dired;
        public System.Windows.Forms.TextBox apeled;
        public System.Windows.Forms.TextBox nomed;
        public System.Windows.Forms.TextBox ci;
        public System.Windows.Forms.ComboBox anno;
        public System.Windows.Forms.ComboBox mes;
        public System.Windows.Forms.ComboBox dia;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.RadioButton sexMax;
        public System.Windows.Forms.RadioButton sexFem;
    }
}