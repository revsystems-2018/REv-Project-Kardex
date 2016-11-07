namespace Proyect_Kardex
{
    partial class REV_SendEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REV_SendEmail));
            this.textini = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.titulolabel = new System.Windows.Forms.Label();
            this.textcod = new System.Windows.Forms.TextBox();
            this.textAsunt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textAdjunt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSMS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labeledit = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SeePass = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.salirboton = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.toolTipSMS = new System.Windows.Forms.ToolTip(this.components);
            this.lbsendsms = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textini
            // 
            this.textini.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textini.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textini.Location = new System.Drawing.Point(71, 15);
            this.textini.Name = "textini";
            this.textini.Size = new System.Drawing.Size(258, 20);
            this.textini.TabIndex = 235;
            this.textini.Text = "Escribir el Correo Electrónico a Enviar";
            this.textini.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textini_MouseClick);
            this.textini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textini_KeyPress);
            this.textini.Leave += new System.EventHandler(this.textini_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 12);
            this.label6.TabIndex = 238;
            this.label6.Text = "Para";
            // 
            // textPass
            // 
            this.textPass.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textPass.Location = new System.Drawing.Point(76, 58);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(258, 20);
            this.textPass.TabIndex = 234;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 237;
            this.label3.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 12);
            this.label5.TabIndex = 236;
            this.label5.Text = "De";
            // 
            // titulolabel
            // 
            this.titulolabel.AutoSize = true;
            this.titulolabel.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulolabel.Location = new System.Drawing.Point(12, 9);
            this.titulolabel.Name = "titulolabel";
            this.titulolabel.Size = new System.Drawing.Size(106, 19);
            this.titulolabel.TabIndex = 230;
            this.titulolabel.Text = "Mensaje Nuevo";
            this.titulolabel.Click += new System.EventHandler(this.titulolabel_Click);
            // 
            // textcod
            // 
            this.textcod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textcod.Location = new System.Drawing.Point(76, 32);
            this.textcod.Name = "textcod";
            this.textcod.Size = new System.Drawing.Size(258, 20);
            this.textcod.TabIndex = 231;
            this.textcod.Text = "Escribir su Correo Personal";
            this.textcod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textcod_MouseClick);
            this.textcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textcod_KeyPress);
            this.textcod.Leave += new System.EventHandler(this.textcod_Leave);
            // 
            // textAsunt
            // 
            this.textAsunt.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAsunt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textAsunt.Location = new System.Drawing.Point(71, 41);
            this.textAsunt.Name = "textAsunt";
            this.textAsunt.Size = new System.Drawing.Size(258, 20);
            this.textAsunt.TabIndex = 239;
            this.textAsunt.Text = "Asunto del Mensaje ";
            this.textAsunt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textAsunt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAsunt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 240;
            this.label1.Text = "Asunto";
            // 
            // textAdjunt
            // 
            this.textAdjunt.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAdjunt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textAdjunt.Location = new System.Drawing.Point(71, 67);
            this.textAdjunt.Name = "textAdjunt";
            this.textAdjunt.Size = new System.Drawing.Size(258, 20);
            this.textAdjunt.TabIndex = 241;
            this.textAdjunt.Text = "Seleccionar Archivo a Enviar";
            this.textAdjunt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textAdjunt_MouseClick);
            this.textAdjunt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAdjunt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 242;
            this.label2.Text = "Adjuntar";
            // 
            // textSMS
            // 
            this.textSMS.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSMS.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textSMS.Location = new System.Drawing.Point(3, 110);
            this.textSMS.Multiline = true;
            this.textSMS.Name = "textSMS";
            this.textSMS.Size = new System.Drawing.Size(329, 130);
            this.textSMS.TabIndex = 243;
            this.textSMS.Text = "Redactar la Descripción del Mensaje a Enviar....";
            this.textSMS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textSMS_MouseClick);
            this.textSMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSMS_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 244;
            this.label4.Text = "Mensaje:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textSMS);
            this.groupBox1.Controls.Add(this.textini);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textAdjunt);
            this.groupBox1.Controls.Add(this.textAsunt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 250);
            this.groupBox1.TabIndex = 245;
            this.groupBox1.TabStop = false;
            // 
            // labeledit
            // 
            this.labeledit.AutoSize = true;
            this.labeledit.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeledit.Location = new System.Drawing.Point(210, 373);
            this.labeledit.Name = "labeledit";
            this.labeledit.Size = new System.Drawing.Size(35, 11);
            this.labeledit.TabIndex = 260;
            this.labeledit.Text = "Enviar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(285, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 11);
            this.label13.TabIndex = 259;
            this.label13.Text = "Cancelar";
            // 
            // SeePass
            // 
            this.SeePass.BackColor = System.Drawing.SystemColors.Window;
            this.SeePass.BackgroundImage = global::Proyect_Kardex.Properties.Resources.seePassword;
            this.SeePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeePass.FlatAppearance.BorderSize = 0;
            this.SeePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SeePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.SeePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeePass.Location = new System.Drawing.Point(314, 59);
            this.SeePass.Name = "SeePass";
            this.SeePass.Size = new System.Drawing.Size(19, 18);
            this.SeePass.TabIndex = 245;
            this.SeePass.UseVisualStyleBackColor = false;
            this.SeePass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SeePass_MouseDown);
            this.SeePass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SeePass_MouseUp);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackgroundImage = global::Proyect_Kardex.Properties.Resources.sendSMS;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(213, 340);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(30, 30);
            this.btnSend.TabIndex = 257;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
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
            this.salirboton.Location = new System.Drawing.Point(291, 340);
            this.salirboton.Name = "salirboton";
            this.salirboton.Size = new System.Drawing.Size(30, 30);
            this.salirboton.TabIndex = 258;
            this.salirboton.UseVisualStyleBackColor = false;
            this.salirboton.Click += new System.EventHandler(this.salirboton_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.Window;
            this.btnOpen.BackgroundImage = global::Proyect_Kardex.Properties.Resources.adjuntar;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(309, 68);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(19, 18);
            this.btnOpen.TabIndex = 233;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lbsendsms
            // 
            this.lbsendsms.AutoSize = true;
            this.lbsendsms.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsendsms.Location = new System.Drawing.Point(14, 350);
            this.lbsendsms.Name = "lbsendsms";
            this.lbsendsms.Size = new System.Drawing.Size(148, 12);
            this.lbsendsms.TabIndex = 245;
            this.lbsendsms.Text = "Enviando Mensaje Espere...";
            this.lbsendsms.Visible = false;
            // 
            // REV_SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(348, 388);
            this.Controls.Add(this.lbsendsms);
            this.Controls.Add(this.SeePass);
            this.Controls.Add(this.labeledit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.salirboton);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titulolabel);
            this.Controls.Add(this.textcod);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "REV_SendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar Correo Electrónico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnOpen;
        public System.Windows.Forms.TextBox textini;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label titulolabel;
        public System.Windows.Forms.TextBox textcod;
        public System.Windows.Forms.TextBox textAsunt;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textAdjunt;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textSMS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label labeledit;
        public System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button salirboton;
        public System.Windows.Forms.Button SeePass;
        public System.Windows.Forms.Label lbsendsms;
        public System.Windows.Forms.ToolTip toolTipSMS;
    }
}