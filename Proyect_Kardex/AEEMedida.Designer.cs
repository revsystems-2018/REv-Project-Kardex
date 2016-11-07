namespace Proyect_Kardex
{
    partial class AEEMedida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AEEMedida));
            this.textcod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.titulolabel = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.botonmax = new System.Windows.Forms.Button();
            this.botonmin = new System.Windows.Forms.Button();
            this.xsalir = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textsimb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editbtn = new System.Windows.Forms.Button();
            this.toolRegMed = new System.Windows.Forms.ToolTip(this.components);
            this.gencode = new System.Windows.Forms.Button();
            this.buscarboton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textcod
            // 
            this.textcod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textcod.Location = new System.Drawing.Point(85, 39);
            this.textcod.MaxLength = 2;
            this.textcod.Name = "textcod";
            this.textcod.Size = new System.Drawing.Size(76, 20);
            this.textcod.TabIndex = 2;
            this.textcod.Text = "Codigo";
            this.textcod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.codClick);
            this.textcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numCod);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 268;
            this.label5.Text = "Código";
            // 
            // titulolabel
            // 
            this.titulolabel.AutoSize = true;
            this.titulolabel.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulolabel.Location = new System.Drawing.Point(12, 9);
            this.titulolabel.Name = "titulolabel";
            this.titulolabel.Size = new System.Drawing.Size(126, 19);
            this.titulolabel.TabIndex = 1;
            this.titulolabel.Text = "Registrar Medida";
            this.titulolabel.Click += new System.EventHandler(this.titulolabel_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Transparent;
            this.savebtn.BackgroundImage = global::Proyect_Kardex.Properties.Resources.addListC;
            this.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.savebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Location = new System.Drawing.Point(316, 39);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(30, 30);
            this.savebtn.TabIndex = 5;
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Visible = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
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
            this.botonmax.Location = new System.Drawing.Point(301, 3);
            this.botonmax.Name = "botonmax";
            this.botonmax.Size = new System.Drawing.Size(15, 15);
            this.botonmax.TabIndex = 9;
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
            this.botonmin.Location = new System.Drawing.Point(320, 3);
            this.botonmin.Name = "botonmin";
            this.botonmin.Size = new System.Drawing.Size(15, 15);
            this.botonmin.TabIndex = 7;
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
            this.xsalir.Location = new System.Drawing.Point(339, 3);
            this.xsalir.Name = "xsalir";
            this.xsalir.Size = new System.Drawing.Size(15, 15);
            this.xsalir.TabIndex = 8;
            this.xsalir.UseVisualStyleBackColor = true;
            this.xsalir.Click += new System.EventHandler(this.xsalir_Click);
            // 
            // textname
            // 
            this.textname.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textname.Location = new System.Drawing.Point(85, 66);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(205, 20);
            this.textname.TabIndex = 3;
            this.textname.Text = "Descripción de la Medida";
            this.textname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nombClick);
            this.textname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.namepr);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 271;
            this.label1.Text = "Nombre";
            // 
            // textsimb
            // 
            this.textsimb.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsimb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textsimb.Location = new System.Drawing.Point(85, 93);
            this.textsimb.Name = "textsimb";
            this.textsimb.Size = new System.Drawing.Size(205, 20);
            this.textsimb.TabIndex = 4;
            this.textsimb.Text = "Símbolo de la Madida";
            this.textsimb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.simbClick);
            this.textsimb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.simbpress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 273;
            this.label2.Text = "Símbolo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.Transparent;
            this.editbtn.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editListC;
            this.editbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbtn.FlatAppearance.BorderSize = 0;
            this.editbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Location = new System.Drawing.Point(316, 83);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(30, 30);
            this.editbtn.TabIndex = 6;
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Visible = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // gencode
            // 
            this.gencode.BackColor = System.Drawing.SystemColors.Menu;
            this.gencode.BackgroundImage = global::Proyect_Kardex.Properties.Resources.magic;
            this.gencode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gencode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gencode.FlatAppearance.BorderSize = 0;
            this.gencode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.gencode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.gencode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gencode.Location = new System.Drawing.Point(141, 40);
            this.gencode.Name = "gencode";
            this.gencode.Size = new System.Drawing.Size(19, 18);
            this.gencode.TabIndex = 274;
            this.gencode.UseVisualStyleBackColor = false;
            this.gencode.Visible = false;
            this.gencode.Click += new System.EventHandler(this.gencode_Click);
            // 
            // buscarboton
            // 
            this.buscarboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.search1;
            this.buscarboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarboton.FlatAppearance.BorderSize = 0;
            this.buscarboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buscarboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buscarboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarboton.Location = new System.Drawing.Point(141, 40);
            this.buscarboton.Name = "buscarboton";
            this.buscarboton.Size = new System.Drawing.Size(19, 18);
            this.buscarboton.TabIndex = 275;
            this.buscarboton.UseVisualStyleBackColor = true;
            this.buscarboton.Visible = false;
            this.buscarboton.Click += new System.EventHandler(this.buscarboton_Click);
            // 
            // AEEMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(358, 127);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.textsimb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titulolabel);
            this.Controls.Add(this.botonmax);
            this.Controls.Add(this.botonmin);
            this.Controls.Add(this.xsalir);
            this.Controls.Add(this.buscarboton);
            this.Controls.Add(this.gencode);
            this.Controls.Add(this.textcod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AEEMedida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button savebtn;
        public System.Windows.Forms.TextBox textcod;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label titulolabel;
        public System.Windows.Forms.Button botonmax;
        public System.Windows.Forms.Button botonmin;
        public System.Windows.Forms.Button xsalir;
        public System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textsimb;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button editbtn;
        public System.Windows.Forms.ToolTip toolRegMed;
        public System.Windows.Forms.Button gencode;
        public System.Windows.Forms.Button buscarboton;
    }
}