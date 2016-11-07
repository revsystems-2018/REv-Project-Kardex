namespace Proyect_Kardex
{
    partial class AEEMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AEEMarca));
            this.titulolabel = new System.Windows.Forms.Label();
            this.labeldelete = new System.Windows.Forms.Label();
            this.deleteboton = new System.Windows.Forms.Button();
            this.buscarboton = new System.Windows.Forms.Button();
            this.textcod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textlogo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textini = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picturelogo = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.verboton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.labelsave = new System.Windows.Forms.Label();
            this.salirboton = new System.Windows.Forms.Button();
            this.saveboton = new System.Windows.Forms.Button();
            this.openlogo = new System.Windows.Forms.Button();
            this.toolMarca = new System.Windows.Forms.ToolTip(this.components);
            this.gencode = new System.Windows.Forms.Button();
            this.labeledit = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogo)).BeginInit();
            this.SuspendLayout();
            // 
            // titulolabel
            // 
            this.titulolabel.AutoSize = true;
            this.titulolabel.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulolabel.Location = new System.Drawing.Point(12, 9);
            this.titulolabel.Name = "titulolabel";
            this.titulolabel.Size = new System.Drawing.Size(121, 19);
            this.titulolabel.TabIndex = 1;
            this.titulolabel.Text = "Registrar Marca";
            this.titulolabel.Click += new System.EventHandler(this.titulolabel_Click);
            // 
            // labeldelete
            // 
            this.labeldelete.AutoSize = true;
            this.labeldelete.Font = new System.Drawing.Font("Lucida Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldelete.Location = new System.Drawing.Point(73, 154);
            this.labeldelete.Name = "labeldelete";
            this.labeldelete.Size = new System.Drawing.Size(42, 11);
            this.labeldelete.TabIndex = 222;
            this.labeldelete.Text = "Eliminar";
            this.labeldelete.Visible = false;
            // 
            // deleteboton
            // 
            this.deleteboton.BackColor = System.Drawing.Color.Transparent;
            this.deleteboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.remove_logo;
            this.deleteboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteboton.FlatAppearance.BorderSize = 0;
            this.deleteboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.deleteboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteboton.Location = new System.Drawing.Point(79, 121);
            this.deleteboton.Name = "deleteboton";
            this.deleteboton.Size = new System.Drawing.Size(30, 30);
            this.deleteboton.TabIndex = 12;
            this.deleteboton.UseVisualStyleBackColor = false;
            this.deleteboton.Visible = false;
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
            this.buscarboton.TabIndex = 3;
            this.buscarboton.UseVisualStyleBackColor = true;
            this.buscarboton.Visible = false;
            this.buscarboton.Click += new System.EventHandler(this.buscarboton_Click);
            // 
            // textcod
            // 
            this.textcod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textcod.Location = new System.Drawing.Point(79, 33);
            this.textcod.MaxLength = 6;
            this.textcod.Name = "textcod";
            this.textcod.Size = new System.Drawing.Size(171, 20);
            this.textcod.TabIndex = 2;
            this.textcod.Text = "Codigo de Registro";
            this.textcod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.codregmClick);
            this.textcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solonumcodm);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 216;
            this.label5.Text = "Codigo";
            // 
            // textnom
            // 
            this.textnom.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textnom.Location = new System.Drawing.Point(79, 63);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(258, 20);
            this.textnom.TabIndex = 5;
            this.textnom.Text = "Descripción o Nombre de la Marca";
            this.textnom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nombregmClick);
            this.textnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.leternumCod);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 223;
            this.label3.Text = "Descripción";
            // 
            // textlogo
            // 
            this.textlogo.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textlogo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textlogo.Location = new System.Drawing.Point(79, 92);
            this.textlogo.Name = "textlogo";
            this.textlogo.Size = new System.Drawing.Size(258, 20);
            this.textlogo.TabIndex = 7;
            this.textlogo.Text = "Ubicación del Logotipo de la Marca";
            this.textlogo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.logoregmClick);
            this.textlogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textlogo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 225;
            this.label4.Text = "Logotipo";
            // 
            // textini
            // 
            this.textini.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textini.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textini.Location = new System.Drawing.Point(343, 33);
            this.textini.Name = "textini";
            this.textini.Size = new System.Drawing.Size(121, 20);
            this.textini.TabIndex = 6;
            this.textini.Text = "Iniciales de la Marca";
            this.textini.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iniregmClick);
            this.textini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letrasynumerosini);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 12);
            this.label6.TabIndex = 227;
            this.label6.Text = "Abreviatura";
            // 
            // picturelogo
            // 
            this.picturelogo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picturelogo.Location = new System.Drawing.Point(343, 63);
            this.picturelogo.Name = "picturelogo";
            this.picturelogo.Size = new System.Drawing.Size(121, 103);
            this.picturelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturelogo.TabIndex = 229;
            this.picturelogo.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(156, 154);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 11);
            this.label19.TabIndex = 252;
            this.label19.Text = "Ver";
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
            this.verboton.Location = new System.Drawing.Point(150, 121);
            this.verboton.Name = "verboton";
            this.verboton.Size = new System.Drawing.Size(30, 30);
            this.verboton.TabIndex = 11;
            this.verboton.UseVisualStyleBackColor = true;
            this.verboton.Click += new System.EventHandler(this.verboton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(291, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 11);
            this.label13.TabIndex = 250;
            this.label13.Text = "Cancelar";
            // 
            // labelsave
            // 
            this.labelsave.AutoSize = true;
            this.labelsave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsave.Location = new System.Drawing.Point(224, 154);
            this.labelsave.Name = "labelsave";
            this.labelsave.Size = new System.Drawing.Size(40, 11);
            this.labelsave.TabIndex = 249;
            this.labelsave.Text = "Guardar";
            this.labelsave.Visible = false;
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
            this.salirboton.Location = new System.Drawing.Point(297, 121);
            this.salirboton.Name = "salirboton";
            this.salirboton.Size = new System.Drawing.Size(30, 30);
            this.salirboton.TabIndex = 13;
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
            this.saveboton.Location = new System.Drawing.Point(229, 121);
            this.saveboton.Name = "saveboton";
            this.saveboton.Size = new System.Drawing.Size(30, 30);
            this.saveboton.TabIndex = 9;
            this.saveboton.UseVisualStyleBackColor = false;
            this.saveboton.Visible = false;
            this.saveboton.Click += new System.EventHandler(this.saveboton_Click);
            // 
            // openlogo
            // 
            this.openlogo.BackgroundImage = global::Proyect_Kardex.Properties.Resources.list_1;
            this.openlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openlogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openlogo.FlatAppearance.BorderSize = 0;
            this.openlogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openlogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.openlogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openlogo.Location = new System.Drawing.Point(317, 93);
            this.openlogo.Name = "openlogo";
            this.openlogo.Size = new System.Drawing.Size(19, 18);
            this.openlogo.TabIndex = 8;
            this.openlogo.UseVisualStyleBackColor = true;
            this.openlogo.Click += new System.EventHandler(this.openlogo_Click);
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
            this.gencode.Location = new System.Drawing.Point(230, 34);
            this.gencode.Name = "gencode";
            this.gencode.Size = new System.Drawing.Size(19, 18);
            this.gencode.TabIndex = 4;
            this.gencode.UseVisualStyleBackColor = false;
            this.gencode.Visible = false;
            this.gencode.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeledit
            // 
            this.labeledit.AutoSize = true;
            this.labeledit.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeledit.Location = new System.Drawing.Point(216, 154);
            this.labeledit.Name = "labeledit";
            this.labeledit.Size = new System.Drawing.Size(35, 11);
            this.labeledit.TabIndex = 256;
            this.labeledit.Text = "Editar";
            this.labeledit.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editpencil;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(219, 121);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AEEMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(476, 172);
            this.Controls.Add(this.gencode);
            this.Controls.Add(this.buscarboton);
            this.Controls.Add(this.labeledit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.openlogo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.verboton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelsave);
            this.Controls.Add(this.salirboton);
            this.Controls.Add(this.saveboton);
            this.Controls.Add(this.picturelogo);
            this.Controls.Add(this.textini);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textlogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textnom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labeldelete);
            this.Controls.Add(this.deleteboton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titulolabel);
            this.Controls.Add(this.textcod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AEEMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.AEEMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturelogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button deleteboton;
        public System.Windows.Forms.Button buscarboton;
        public System.Windows.Forms.TextBox textcod;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textlogo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textini;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.Button verboton;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button salirboton;
        public System.Windows.Forms.Button saveboton;
        public System.Windows.Forms.Button openlogo;
        public System.Windows.Forms.PictureBox picturelogo;
        public System.Windows.Forms.Label titulolabel;
        public System.Windows.Forms.ToolTip toolMarca;
        public System.Windows.Forms.Label labeldelete;
        public System.Windows.Forms.Button gencode;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Label labelsave;
        public System.Windows.Forms.Label labeledit;
    }
}