namespace Proyect_Kardex
{
    partial class SolCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolCliente));
            this.celc = new System.Windows.Forms.TextBox();
            this.telc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.corc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nitc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.salirboton = new System.Windows.Forms.Button();
            this.saveboton = new System.Windows.Forms.Button();
            this.provc = new System.Windows.Forms.ComboBox();
            this.depac = new System.Windows.Forms.ComboBox();
            this.dirc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.apec = new System.Windows.Forms.TextBox();
            this.nombc = new System.Windows.Forms.TextBox();
            this.cic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.saveLb = new System.Windows.Forms.Label();
            this.toolSolCliente = new System.Windows.Forms.ToolTip(this.components);
            this.buscaredboton = new System.Windows.Forms.Button();
            this.elimLb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.editLb = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // celc
            // 
            this.celc.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.celc.Location = new System.Drawing.Point(312, 145);
            this.celc.Name = "celc";
            this.celc.Size = new System.Drawing.Size(161, 20);
            this.celc.TabIndex = 12;
            this.celc.Text = "Teléfono Privado";
            this.celc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.celsolClick);
            this.celc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CelCliente);
            // 
            // telc
            // 
            this.telc.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.telc.Location = new System.Drawing.Point(312, 106);
            this.telc.Name = "telc";
            this.telc.Size = new System.Drawing.Size(161, 20);
            this.telc.TabIndex = 11;
            this.telc.Text = "Teléfono Fijo";
            this.telc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.telsolClick);
            this.telc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telCliente);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(310, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 12);
            this.label11.TabIndex = 83;
            this.label11.Text = "Celular";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(310, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 12);
            this.label17.TabIndex = 82;
            this.label17.Text = "Teléfono";
            // 
            // corc
            // 
            this.corc.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.corc.Location = new System.Drawing.Point(312, 66);
            this.corc.Name = "corc";
            this.corc.Size = new System.Drawing.Size(161, 20);
            this.corc.TabIndex = 10;
            this.corc.Text = "Correo Electrónico del Cliente";
            this.corc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.corrsolClick);
            this.corc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.corc_KeyPress);
            this.corc.Leave += new System.EventHandler(this.corc_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 12);
            this.label4.TabIndex = 79;
            this.label4.Text = "E-mail";
            // 
            // nitc
            // 
            this.nitc.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nitc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nitc.Location = new System.Drawing.Point(132, 124);
            this.nitc.Name = "nitc";
            this.nitc.Size = new System.Drawing.Size(161, 20);
            this.nitc.TabIndex = 6;
            this.nitc.Text = "NIT del Cliente";
            this.nitc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nitsolClick);
            this.nitc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nitCliente);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(106, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 12);
            this.label16.TabIndex = 76;
            this.label16.Text = "Nit";
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
            this.salirboton.Location = new System.Drawing.Point(434, 189);
            this.salirboton.Name = "salirboton";
            this.salirboton.Size = new System.Drawing.Size(30, 30);
            this.salirboton.TabIndex = 15;
            this.salirboton.UseVisualStyleBackColor = false;
            this.salirboton.Click += new System.EventHandler(this.salirboton_Click);
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
            this.saveboton.Location = new System.Drawing.Point(367, 189);
            this.saveboton.Name = "saveboton";
            this.saveboton.Size = new System.Drawing.Size(30, 30);
            this.saveboton.TabIndex = 13;
            this.saveboton.UseVisualStyleBackColor = false;
            this.saveboton.Click += new System.EventHandler(this.saveboton_Click);
            // 
            // provc
            // 
            this.provc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provc.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provc.FormattingEnabled = true;
            this.provc.Location = new System.Drawing.Point(132, 217);
            this.provc.Name = "provc";
            this.provc.Size = new System.Drawing.Size(161, 20);
            this.provc.TabIndex = 9;
            // 
            // depac
            // 
            this.depac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depac.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depac.FormattingEnabled = true;
            this.depac.Location = new System.Drawing.Point(132, 186);
            this.depac.Name = "depac";
            this.depac.Size = new System.Drawing.Size(161, 20);
            this.depac.TabIndex = 8;
            this.depac.SelectedIndexChanged += new System.EventHandler(this.depac_SelectedIndexChanged);
            // 
            // dirc
            // 
            this.dirc.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dirc.Location = new System.Drawing.Point(132, 157);
            this.dirc.Name = "dirc";
            this.dirc.Size = new System.Drawing.Size(161, 20);
            this.dirc.TabIndex = 7;
            this.dirc.Text = "Ubicación del Cliente";
            this.dirc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dirsolClick);
            this.dirc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dirc_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 75;
            this.label9.Text = "Provincia ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 74;
            this.label7.Text = "Departamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 12);
            this.label8.TabIndex = 71;
            this.label8.Text = "Dirección";
            // 
            // apec
            // 
            this.apec.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apec.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.apec.Location = new System.Drawing.Point(132, 95);
            this.apec.Name = "apec";
            this.apec.Size = new System.Drawing.Size(161, 20);
            this.apec.TabIndex = 5;
            this.apec.Text = "Apellido Paterno; Materno";
            this.apec.MouseClick += new System.Windows.Forms.MouseEventHandler(this.apesolClick);
            this.apec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apeCliente);
            // 
            // nombc
            // 
            this.nombc.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nombc.Location = new System.Drawing.Point(132, 66);
            this.nombc.Name = "nombc";
            this.nombc.Size = new System.Drawing.Size(161, 20);
            this.nombc.TabIndex = 4;
            this.nombc.Text = "Nombres del Cliente";
            this.nombc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nomsolClick);
            this.nombc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombCli);
            // 
            // cic
            // 
            this.cic.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cic.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cic.Location = new System.Drawing.Point(132, 37);
            this.cic.Name = "cic";
            this.cic.Size = new System.Drawing.Size(161, 20);
            this.cic.TabIndex = 2;
            this.cic.Text = "C.I. del Cliente";
            this.cic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cisolClick);
            this.cic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ciCliente);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 12);
            this.label5.TabIndex = 57;
            this.label5.Text = "Carnet de Identidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 55;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro De Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(428, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 11);
            this.label13.TabIndex = 85;
            this.label13.Text = "Cancelar";
            // 
            // saveLb
            // 
            this.saveLb.AutoSize = true;
            this.saveLb.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLb.Location = new System.Drawing.Point(364, 222);
            this.saveLb.Name = "saveLb";
            this.saveLb.Size = new System.Drawing.Size(40, 11);
            this.saveLb.TabIndex = 84;
            this.saveLb.Text = "Guardar";
            // 
            // buscaredboton
            // 
            this.buscaredboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.search1;
            this.buscaredboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscaredboton.FlatAppearance.BorderSize = 0;
            this.buscaredboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buscaredboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buscaredboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscaredboton.Location = new System.Drawing.Point(274, 38);
            this.buscaredboton.Name = "buscaredboton";
            this.buscaredboton.Size = new System.Drawing.Size(19, 18);
            this.buscaredboton.TabIndex = 3;
            this.buscaredboton.UseVisualStyleBackColor = true;
            this.buscaredboton.Visible = false;
            this.buscaredboton.Click += new System.EventHandler(this.buscaredboton_Click);
            // 
            // elimLb
            // 
            this.elimLb.AutoSize = true;
            this.elimLb.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elimLb.Location = new System.Drawing.Point(329, 222);
            this.elimLb.Name = "elimLb";
            this.elimLb.Size = new System.Drawing.Size(45, 11);
            this.elimLb.TabIndex = 206;
            this.elimLb.Text = "Eliminar";
            this.elimLb.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Proyect_Kardex.Properties.Resources.remove_logo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(333, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editLb
            // 
            this.editLb.AutoSize = true;
            this.editLb.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLb.Location = new System.Drawing.Point(354, 222);
            this.editLb.Name = "editLb";
            this.editLb.Size = new System.Drawing.Size(35, 11);
            this.editLb.TabIndex = 208;
            this.editLb.Text = "Editar";
            this.editLb.Visible = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editpencil;
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(354, 189);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(30, 30);
            this.editBtn.TabIndex = 16;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Visible = false;
            this.editBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SolCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(484, 243);
            this.Controls.Add(this.editLb);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.elimLb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscaredboton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.saveLb);
            this.Controls.Add(this.celc);
            this.Controls.Add(this.telc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.corc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nitc);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.salirboton);
            this.Controls.Add(this.saveboton);
            this.Controls.Add(this.provc);
            this.Controls.Add(this.depac);
            this.Controls.Add(this.dirc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.apec);
            this.Controls.Add(this.nombc);
            this.Controls.Add(this.cic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SolCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de Cliente";
            this.Load += new System.EventHandler(this.SolCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ToolTip toolSolCliente;
        public System.Windows.Forms.TextBox celc;
        public System.Windows.Forms.TextBox telc;
        public System.Windows.Forms.TextBox corc;
        public System.Windows.Forms.TextBox nitc;
        public System.Windows.Forms.Button salirboton;
        public System.Windows.Forms.Button saveboton;
        public System.Windows.Forms.ComboBox provc;
        public System.Windows.Forms.ComboBox depac;
        public System.Windows.Forms.TextBox dirc;
        public System.Windows.Forms.TextBox apec;
        public System.Windows.Forms.TextBox nombc;
        public System.Windows.Forms.TextBox cic;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buscaredboton;
        public System.Windows.Forms.Label elimLb;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label saveLb;
        public System.Windows.Forms.Label editLb;
        public System.Windows.Forms.Button editBtn;
    }
}