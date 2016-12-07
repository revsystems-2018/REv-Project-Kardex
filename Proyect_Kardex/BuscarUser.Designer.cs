namespace Proyect_Kardex
{
    partial class BuscarUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarUser));
            this.label1 = new System.Windows.Forms.Label();
            this.citext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolfind = new System.Windows.Forms.ToolTip(this.components);
            this.botonmax = new System.Windows.Forms.Button();
            this.botonmin = new System.Windows.Forms.Button();
            this.xsalir = new System.Windows.Forms.Button();
            this.regboton = new System.Windows.Forms.Button();
            this.findbtn = new System.Windows.Forms.Button();
            this.sexo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fax = new System.Windows.Forms.Label();
            this.cel = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dir = new System.Windows.Forms.Label();
            this.depa = new System.Windows.Forms.Label();
            this.cargo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.nivel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.ci = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 208;
            this.label1.Text = "Datos Del Usuario";
            // 
            // citext
            // 
            this.citext.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citext.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.citext.Location = new System.Drawing.Point(148, 38);
            this.citext.Name = "citext";
            this.citext.Size = new System.Drawing.Size(322, 23);
            this.citext.TabIndex = 207;
            this.citext.Text = "C.I. o Nombre del Usuario";
            this.citext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ciUserClick);
            this.citext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.civerUser);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 12);
            this.label2.TabIndex = 206;
            this.label2.Text = "Carnet de Identidad";
            // 
            // toolfind
            // 
            this.toolfind.IsBalloon = true;
            // 
            // botonmax
            // 
            this.botonmax.BackgroundImage = global::Proyect_Kardex.Properties.Resources.maximizar;
            this.botonmax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonmax.Cursor = System.Windows.Forms.Cursors.No;
            this.botonmax.Enabled = false;
            this.botonmax.FlatAppearance.BorderSize = 0;
            this.botonmax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonmax.Location = new System.Drawing.Point(481, 4);
            this.botonmax.Name = "botonmax";
            this.botonmax.Size = new System.Drawing.Size(15, 15);
            this.botonmax.TabIndex = 216;
            this.botonmax.UseVisualStyleBackColor = true;
            this.botonmax.Click += new System.EventHandler(this.botonmax_Click);
            // 
            // botonmin
            // 
            this.botonmin.BackgroundImage = global::Proyect_Kardex.Properties.Resources.minimizar;
            this.botonmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonmin.FlatAppearance.BorderSize = 0;
            this.botonmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonmin.Location = new System.Drawing.Point(500, 4);
            this.botonmin.Name = "botonmin";
            this.botonmin.Size = new System.Drawing.Size(15, 15);
            this.botonmin.TabIndex = 215;
            this.botonmin.UseVisualStyleBackColor = true;
            this.botonmin.Click += new System.EventHandler(this.botonmin_Click);
            // 
            // xsalir
            // 
            this.xsalir.BackgroundImage = global::Proyect_Kardex.Properties.Resources.cross_close_quit_512;
            this.xsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xsalir.FlatAppearance.BorderSize = 0;
            this.xsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.xsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.xsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xsalir.Location = new System.Drawing.Point(519, 4);
            this.xsalir.Name = "xsalir";
            this.xsalir.Size = new System.Drawing.Size(15, 15);
            this.xsalir.TabIndex = 214;
            this.xsalir.UseVisualStyleBackColor = true;
            this.xsalir.Click += new System.EventHandler(this.xsalir_Click);
            // 
            // regboton
            // 
            this.regboton.BackColor = System.Drawing.Color.Transparent;
            this.regboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.listEmps;
            this.regboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regboton.FlatAppearance.BorderSize = 0;
            this.regboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.regboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.regboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regboton.Location = new System.Drawing.Point(488, 28);
            this.regboton.Name = "regboton";
            this.regboton.Size = new System.Drawing.Size(40, 40);
            this.regboton.TabIndex = 210;
            this.regboton.UseVisualStyleBackColor = false;
            this.regboton.Click += new System.EventHandler(this.regboton_Click);
            // 
            // findbtn
            // 
            this.findbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.findbtn.BackgroundImage = global::Proyect_Kardex.Properties.Resources.lupa;
            this.findbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.findbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findbtn.FlatAppearance.BorderSize = 0;
            this.findbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.findbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.findbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findbtn.Location = new System.Drawing.Point(448, 40);
            this.findbtn.Name = "findbtn";
            this.findbtn.Size = new System.Drawing.Size(21, 20);
            this.findbtn.TabIndex = 229;
            this.findbtn.UseVisualStyleBackColor = false;
            this.findbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexo.Location = new System.Drawing.Point(217, 235);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(84, 14);
            this.sexo.TabIndex = 251;
            this.sexo.Text = "-----------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 12);
            this.label3.TabIndex = 250;
            this.label3.Text = "Sexo:";
            // 
            // fax
            // 
            this.fax.AutoSize = true;
            this.fax.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fax.Location = new System.Drawing.Point(439, 284);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(55, 12);
            this.fax.TabIndex = 249;
            this.fax.Text = "**********";
            // 
            // cel
            // 
            this.cel.AutoSize = true;
            this.cel.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cel.Location = new System.Drawing.Point(439, 265);
            this.cel.Name = "cel";
            this.cel.Size = new System.Drawing.Size(55, 12);
            this.cel.TabIndex = 248;
            this.cel.Text = "**********";
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel.Location = new System.Drawing.Point(439, 247);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(60, 12);
            this.tel.TabIndex = 247;
            this.tel.Text = "***********";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(375, 284);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 12);
            this.label17.TabIndex = 246;
            this.label17.Text = "Fax:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(375, 265);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 12);
            this.label16.TabIndex = 245;
            this.label16.Text = "Celular:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(375, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 12);
            this.label15.TabIndex = 244;
            this.label15.Text = "Teléfono:";
            // 
            // dir
            // 
            this.dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dir.AutoSize = true;
            this.dir.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dir.Location = new System.Drawing.Point(130, 284);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(137, 12);
            this.dir.TabIndex = 243;
            this.dir.Text = "----------------------";
            // 
            // depa
            // 
            this.depa.AutoSize = true;
            this.depa.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depa.Location = new System.Drawing.Point(160, 265);
            this.depa.Name = "depa";
            this.depa.Size = new System.Drawing.Size(131, 12);
            this.depa.TabIndex = 242;
            this.depa.Text = "++++++++++++++";
            // 
            // cargo
            // 
            this.cargo.AutoSize = true;
            this.cargo.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo.Location = new System.Drawing.Point(217, 211);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(112, 14);
            this.cargo.TabIndex = 241;
            this.cargo.Text = "---------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(160, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 240;
            this.label9.Text = "Cargo:";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(217, 189);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(140, 14);
            this.user.TabIndex = 239;
            this.user.Text = "-------------------";
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel.Location = new System.Drawing.Point(357, 154);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(151, 18);
            this.nivel.TabIndex = 238;
            this.nivel.Text = "+++++++++++";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 237;
            this.label6.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 236;
            this.label5.Text = "Nivel:";
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(183, 321);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(167, 12);
            this.correo.TabIndex = 235;
            this.correo.TabStop = true;
            this.correo.Text = "---------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 234;
            this.label4.Text = "E-mail:";
            // 
            // ci
            // 
            this.ci.AutoSize = true;
            this.ci.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ci.Location = new System.Drawing.Point(158, 151);
            this.ci.Name = "ci";
            this.ci.Size = new System.Drawing.Size(109, 22);
            this.ci.TabIndex = 233;
            this.ci.Text = "***********";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nom.Location = new System.Drawing.Point(158, 83);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(142, 22);
            this.nom.TabIndex = 232;
            this.nom.Text = "-----------";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.apellido.Location = new System.Drawing.Point(266, 110);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(214, 22);
            this.apellido.TabIndex = 231;
            this.apellido.Text = "-----------------";
            // 
            // foto
            // 
            this.foto.BackColor = System.Drawing.Color.Transparent;
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.foto.Location = new System.Drawing.Point(12, 72);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(140, 187);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto.TabIndex = 230;
            this.foto.TabStop = false;
            // 
            // BuscarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(540, 343);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fax);
            this.Controls.Add(this.cel);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dir);
            this.Controls.Add(this.depa);
            this.Controls.Add(this.cargo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.user);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ci);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.findbtn);
            this.Controls.Add(this.botonmax);
            this.Controls.Add(this.botonmin);
            this.Controls.Add(this.xsalir);
            this.Controls.Add(this.regboton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.citext);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarUser";
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regboton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox citext;
        public System.Windows.Forms.ToolTip toolfind;
        public System.Windows.Forms.Button botonmax;
        public System.Windows.Forms.Button botonmin;
        public System.Windows.Forms.Button xsalir;
        public System.Windows.Forms.Button findbtn;
        public System.Windows.Forms.Label sexo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label fax;
        public System.Windows.Forms.Label cel;
        public System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label dir;
        public System.Windows.Forms.Label depa;
        public System.Windows.Forms.Label cargo;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label user;
        public System.Windows.Forms.Label nivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.LinkLabel correo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label ci;
        public System.Windows.Forms.Label nom;
        public System.Windows.Forms.Label apellido;
        public System.Windows.Forms.PictureBox foto;
    }
}