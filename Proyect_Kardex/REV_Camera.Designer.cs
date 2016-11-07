namespace Proyect_Kardex
{
    partial class REV_Camera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REV_Camera));
            this.cbcamara2 = new System.Windows.Forms.ComboBox();
            this.titulo = new System.Windows.Forms.Label();
            this.cbCamara1 = new System.Windows.Forms.ComboBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.fotomini = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.onoff = new System.Windows.Forms.Button();
            this.fotomax = new System.Windows.Forms.PictureBox();
            this.onoff2 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnChanges = new System.Windows.Forms.Button();
            this.btnPhoto2 = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbphoto = new System.Windows.Forms.Label();
            this.lbpunto = new System.Windows.Forms.Label();
            this.toolCamera = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fotomini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotomax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbcamara2
            // 
            this.cbcamara2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbcamara2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcamara2.ForeColor = System.Drawing.SystemColors.Window;
            this.cbcamara2.FormattingEnabled = true;
            this.cbcamara2.Location = new System.Drawing.Point(444, 33);
            this.cbcamara2.Name = "cbcamara2";
            this.cbcamara2.Size = new System.Drawing.Size(138, 20);
            this.cbcamara2.TabIndex = 12;
            this.cbcamara2.Visible = false;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(406, 5);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(59, 19);
            this.titulo.TabIndex = 14;
            this.titulo.Text = "Galeria";
            // 
            // cbCamara1
            // 
            this.cbCamara1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbCamara1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamara1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamara1.ForeColor = System.Drawing.SystemColors.Window;
            this.cbCamara1.FormattingEnabled = true;
            this.cbCamara1.Location = new System.Drawing.Point(104, 4);
            this.cbCamara1.Name = "cbCamara1";
            this.cbCamara1.Size = new System.Drawing.Size(184, 23);
            this.cbCamara1.TabIndex = 15;
            this.cbCamara1.Visible = false;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.BackgroundImage = global::Proyect_Kardex.Properties.Resources.left;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Location = new System.Drawing.Point(379, 231);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(25, 40);
            this.btnLeft.TabIndex = 21;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Visible = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // fotomini
            // 
            this.fotomini.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fotomini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fotomini.Location = new System.Drawing.Point(31, 509);
            this.fotomini.Name = "fotomini";
            this.fotomini.Size = new System.Drawing.Size(30, 40);
            this.fotomini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotomini.TabIndex = 20;
            this.fotomini.TabStop = false;
            this.fotomini.Click += new System.EventHandler(this.fotomini_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::Proyect_Kardex.Properties.Resources.savePhoto;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(334, 511);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 35);
            this.btnSave.TabIndex = 19;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnPhoto.BackgroundImage = global::Proyect_Kardex.Properties.Resources.btnPhoto;
            this.btnPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhoto.FlatAppearance.BorderSize = 0;
            this.btnPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoto.Location = new System.Drawing.Point(184, 501);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(50, 50);
            this.btnPhoto.TabIndex = 17;
            this.btnPhoto.UseVisualStyleBackColor = false;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // onoff
            // 
            this.onoff.BackColor = System.Drawing.Color.Transparent;
            this.onoff.BackgroundImage = global::Proyect_Kardex.Properties.Resources.offA;
            this.onoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onoff.FlatAppearance.BorderSize = 0;
            this.onoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.onoff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.onoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onoff.Location = new System.Drawing.Point(31, 5);
            this.onoff.Name = "onoff";
            this.onoff.Size = new System.Drawing.Size(30, 20);
            this.onoff.TabIndex = 16;
            this.onoff.UseVisualStyleBackColor = false;
            this.onoff.Click += new System.EventHandler(this.onoff_Click);
            // 
            // fotomax
            // 
            this.fotomax.Location = new System.Drawing.Point(408, 69);
            this.fotomax.Name = "fotomax";
            this.fotomax.Size = new System.Drawing.Size(174, 202);
            this.fotomax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotomax.TabIndex = 13;
            this.fotomax.TabStop = false;
            // 
            // onoff2
            // 
            this.onoff2.BackColor = System.Drawing.Color.Transparent;
            this.onoff2.BackgroundImage = global::Proyect_Kardex.Properties.Resources.offA;
            this.onoff2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onoff2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onoff2.FlatAppearance.BorderSize = 0;
            this.onoff2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.onoff2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.onoff2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onoff2.Location = new System.Drawing.Point(408, 33);
            this.onoff2.Name = "onoff2";
            this.onoff2.Size = new System.Drawing.Size(30, 20);
            this.onoff2.TabIndex = 11;
            this.onoff2.UseVisualStyleBackColor = false;
            this.onoff2.Visible = false;
            this.onoff2.Click += new System.EventHandler(this.onoff2_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.Color.Transparent;
            this.btnSave2.BackgroundImage = global::Proyect_Kardex.Properties.Resources.savePhoto;
            this.btnSave2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave2.FlatAppearance.BorderSize = 0;
            this.btnSave2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave2.Location = new System.Drawing.Point(538, 442);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(30, 30);
            this.btnSave2.TabIndex = 10;
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Visible = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnChanges
            // 
            this.btnChanges.BackColor = System.Drawing.Color.Transparent;
            this.btnChanges.BackgroundImage = global::Proyect_Kardex.Properties.Resources.icamera2;
            this.btnChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChanges.FlatAppearance.BorderSize = 0;
            this.btnChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChanges.Location = new System.Drawing.Point(420, 442);
            this.btnChanges.Name = "btnChanges";
            this.btnChanges.Size = new System.Drawing.Size(30, 30);
            this.btnChanges.TabIndex = 9;
            this.btnChanges.UseVisualStyleBackColor = false;
            this.btnChanges.Visible = false;
            this.btnChanges.Click += new System.EventHandler(this.btnChanges_Click);
            // 
            // btnPhoto2
            // 
            this.btnPhoto2.BackColor = System.Drawing.Color.Transparent;
            this.btnPhoto2.BackgroundImage = global::Proyect_Kardex.Properties.Resources.btnPhoto;
            this.btnPhoto2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhoto2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhoto2.FlatAppearance.BorderSize = 0;
            this.btnPhoto2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPhoto2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPhoto2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoto2.Location = new System.Drawing.Point(476, 432);
            this.btnPhoto2.Name = "btnPhoto2";
            this.btnPhoto2.Size = new System.Drawing.Size(40, 40);
            this.btnPhoto2.TabIndex = 8;
            this.btnPhoto2.UseVisualStyleBackColor = false;
            this.btnPhoto2.Visible = false;
            this.btnPhoto2.Click += new System.EventHandler(this.btnPhoto2_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.BackgroundImage = global::Proyect_Kardex.Properties.Resources.icamera2;
            this.btnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Location = new System.Drawing.Point(334, 0);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(30, 30);
            this.btnChange.TabIndex = 6;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbphoto
            // 
            this.lbphoto.AutoSize = true;
            this.lbphoto.Font = new System.Drawing.Font("Lucida Sans", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbphoto.ForeColor = System.Drawing.Color.Gold;
            this.lbphoto.Location = new System.Drawing.Point(190, 491);
            this.lbphoto.Name = "lbphoto";
            this.lbphoto.Size = new System.Drawing.Size(38, 11);
            this.lbphoto.TabIndex = 22;
            this.lbphoto.Text = "PHOTO";
            // 
            // lbpunto
            // 
            this.lbpunto.AutoSize = true;
            this.lbpunto.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpunto.ForeColor = System.Drawing.Color.Gold;
            this.lbpunto.Location = new System.Drawing.Point(203, 471);
            this.lbpunto.Name = "lbpunto";
            this.lbpunto.Size = new System.Drawing.Size(15, 22);
            this.lbpunto.TabIndex = 23;
            this.lbpunto.Text = ".";
            // 
            // REV_Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(397, 556);
            this.Controls.Add(this.lbphoto);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.fotomini);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.onoff);
            this.Controls.Add(this.cbCamara1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.fotomax);
            this.Controls.Add(this.cbcamara2);
            this.Controls.Add(this.onoff2);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.btnChanges);
            this.Controls.Add(this.btnPhoto2);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbpunto);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "REV_Camera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cámara";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.REV_Camera_FormClosing);
            this.Load += new System.EventHandler(this.REV_Camera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotomini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotomax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnPhoto2;
        public System.Windows.Forms.Button btnChanges;
        public System.Windows.Forms.Button btnSave2;
        public System.Windows.Forms.Button onoff2;
        public System.Windows.Forms.ComboBox cbcamara2;
        public System.Windows.Forms.ComboBox cbCamara1;
        public System.Windows.Forms.Button onoff;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnPhoto;
        public System.Windows.Forms.Button btnLeft;
        public System.Windows.Forms.PictureBox fotomax;
        public System.Windows.Forms.Label titulo;
        public System.Windows.Forms.PictureBox fotomini;
        public System.Windows.Forms.Label lbphoto;
        public System.Windows.Forms.Label lbpunto;
        public System.Windows.Forms.ToolTip toolCamera;
    }
}