namespace Proyect_Kardex
{
    partial class AEECategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AEECategoria));
            this.textcod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.titulolabel = new System.Windows.Forms.Label();
            this.textnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.salirboton = new System.Windows.Forms.Button();
            this.saveboton = new System.Windows.Forms.Button();
            this.deleteboton = new System.Windows.Forms.Button();
            this.buscarboton = new System.Windows.Forms.Button();
            this.toolCate = new System.Windows.Forms.ToolTip(this.components);
            this.textDet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btngen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textcod
            // 
            this.textcod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textcod.Location = new System.Drawing.Point(79, 33);
            this.textcod.MaxLength = 3;
            this.textcod.Name = "textcod";
            this.textcod.Size = new System.Drawing.Size(171, 20);
            this.textcod.TabIndex = 2;
            this.textcod.Text = "Codigo de Registro";
            this.textcod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.codcatClick);
            this.textcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numcodcat);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 220;
            this.label5.Text = "Codigo";
            // 
            // titulolabel
            // 
            this.titulolabel.AutoSize = true;
            this.titulolabel.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulolabel.Location = new System.Drawing.Point(12, 9);
            this.titulolabel.Name = "titulolabel";
            this.titulolabel.Size = new System.Drawing.Size(145, 19);
            this.titulolabel.TabIndex = 1;
            this.titulolabel.Text = "Registrar Categoría";
            this.titulolabel.Click += new System.EventHandler(this.titulolabel_Click);
            // 
            // textnom
            // 
            this.textnom.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textnom.Location = new System.Drawing.Point(79, 64);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(258, 20);
            this.textnom.TabIndex = 6;
            this.textnom.Text = "Descripción o Nombre de la Categoría";
            this.textnom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.namecatClick);
            this.textnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numletname);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 225;
            this.label3.Text = "Descripción";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(285, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 11);
            this.label13.TabIndex = 258;
            this.label13.Text = "Cancelar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(39, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 11);
            this.label12.TabIndex = 257;
            this.label12.Text = "Guardar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 11);
            this.label2.TabIndex = 254;
            this.label2.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 11);
            this.label1.TabIndex = 260;
            this.label1.Text = "Editar";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editpencil;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(114, 160);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
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
            this.salirboton.Location = new System.Drawing.Point(291, 160);
            this.salirboton.Name = "salirboton";
            this.salirboton.Size = new System.Drawing.Size(30, 30);
            this.salirboton.TabIndex = 11;
            this.salirboton.UseVisualStyleBackColor = false;
            this.salirboton.Click += new System.EventHandler(this.salirboton_Click);
            // 
            // saveboton
            // 
            this.saveboton.BackColor = System.Drawing.Color.Transparent;
            this.saveboton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveboton.BackgroundImage")));
            this.saveboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveboton.Enabled = false;
            this.saveboton.FlatAppearance.BorderSize = 0;
            this.saveboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.saveboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveboton.Location = new System.Drawing.Point(43, 160);
            this.saveboton.Name = "saveboton";
            this.saveboton.Size = new System.Drawing.Size(30, 30);
            this.saveboton.TabIndex = 8;
            this.saveboton.UseVisualStyleBackColor = false;
            this.saveboton.Click += new System.EventHandler(this.saveboton_Click);
            // 
            // deleteboton
            // 
            this.deleteboton.BackColor = System.Drawing.Color.Transparent;
            this.deleteboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.remove_logo;
            this.deleteboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteboton.Enabled = false;
            this.deleteboton.FlatAppearance.BorderSize = 0;
            this.deleteboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.deleteboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteboton.Location = new System.Drawing.Point(187, 160);
            this.deleteboton.Name = "deleteboton";
            this.deleteboton.Size = new System.Drawing.Size(30, 30);
            this.deleteboton.TabIndex = 10;
            this.deleteboton.UseVisualStyleBackColor = false;
            this.deleteboton.Click += new System.EventHandler(this.deleteboton_Click);
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
            this.buscarboton.Location = new System.Drawing.Point(230, 34);
            this.buscarboton.Name = "buscarboton";
            this.buscarboton.Size = new System.Drawing.Size(19, 18);
            this.buscarboton.TabIndex = 5;
            this.buscarboton.UseVisualStyleBackColor = true;
            this.buscarboton.Visible = false;
            this.buscarboton.Click += new System.EventHandler(this.buscarboton_Click);
            // 
            // textDet
            // 
            this.textDet.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDet.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textDet.Location = new System.Drawing.Point(79, 90);
            this.textDet.Multiline = true;
            this.textDet.Name = "textDet";
            this.textDet.Size = new System.Drawing.Size(258, 64);
            this.textDet.TabIndex = 7;
            this.textDet.Text = "Descripción o Detalle de la Categoría";
            this.textDet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textDet_MouseClick);
            this.textDet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDet_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 261;
            this.label4.Text = "Detalle";
            // 
            // btngen
            // 
            this.btngen.BackColor = System.Drawing.SystemColors.Menu;
            this.btngen.BackgroundImage = global::Proyect_Kardex.Properties.Resources.magic;
            this.btngen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngen.FlatAppearance.BorderSize = 0;
            this.btngen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btngen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btngen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngen.Location = new System.Drawing.Point(230, 34);
            this.btngen.Name = "btngen";
            this.btngen.Size = new System.Drawing.Size(19, 18);
            this.btngen.TabIndex = 3;
            this.btngen.UseVisualStyleBackColor = false;
            this.btngen.Visible = false;
            this.btngen.Click += new System.EventHandler(this.btngen_Click);
            // 
            // AEECategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(342, 209);
            this.Controls.Add(this.textDet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.salirboton);
            this.Controls.Add(this.saveboton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteboton);
            this.Controls.Add(this.textnom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titulolabel);
            this.Controls.Add(this.btngen);
            this.Controls.Add(this.buscarboton);
            this.Controls.Add(this.textcod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AEECategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoría";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AEECategoria_FormClosing);
            this.Load += new System.EventHandler(this.AEECategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buscarboton;
        public System.Windows.Forms.TextBox textcod;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label titulolabel;
        public System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button salirboton;
        public System.Windows.Forms.Button saveboton;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button deleteboton;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolTip toolCate;
        public System.Windows.Forms.TextBox textDet;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btngen;
    }
}