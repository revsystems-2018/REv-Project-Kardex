namespace Proyect_Kardex
{
    partial class Read_Code_Qr_Bar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Read_Code_Qr_Bar));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabScan = new System.Windows.Forms.TabPage();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnSalir1 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSelect1 = new System.Windows.Forms.Button();
            this.textScan = new System.Windows.Forms.TextBox();
            this.fotoCamera = new System.Windows.Forms.PictureBox();
            this.tabLect = new System.Windows.Forms.TabPage();
            this.textLee = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.btnLee = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.fotoLee = new System.Windows.Forms.PictureBox();
            this.timeScan = new System.Windows.Forms.Timer(this.components);
            this.toolRead = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabScan.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCamera)).BeginInit();
            this.tabLect.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoLee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabScan);
            this.tabControl1.Controls.Add(this.tabLect);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabScan
            // 
            this.tabScan.BackColor = System.Drawing.Color.Transparent;
            this.tabScan.Controls.Add(this.cbCamera);
            this.tabScan.Controls.Add(this.panel1);
            this.tabScan.Controls.Add(this.textScan);
            this.tabScan.Controls.Add(this.fotoCamera);
            this.tabScan.Location = new System.Drawing.Point(4, 21);
            this.tabScan.Name = "tabScan";
            this.tabScan.Padding = new System.Windows.Forms.Padding(3);
            this.tabScan.Size = new System.Drawing.Size(348, 436);
            this.tabScan.TabIndex = 0;
            this.tabScan.Text = "Escanner";
            this.tabScan.Click += new System.EventHandler(this.tabScan_Click);
            // 
            // cbCamera
            // 
            this.cbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(3, 54);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(341, 20);
            this.cbCamera.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnScan);
            this.panel1.Controls.Add(this.btnSalir1);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnSelect1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 51);
            this.panel1.TabIndex = 2;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.Transparent;
            this.btnScan.BackgroundImage = global::Proyect_Kardex.Properties.Resources.Scannear;
            this.btnScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScan.FlatAppearance.BorderSize = 0;
            this.btnScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Location = new System.Drawing.Point(213, 6);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(40, 40);
            this.btnScan.TabIndex = 295;
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnSalir1
            // 
            this.btnSalir1.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir1.BackgroundImage = global::Proyect_Kardex.Properties.Resources.close_off_512;
            this.btnSalir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir1.FlatAppearance.BorderSize = 0;
            this.btnSalir1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir1.Location = new System.Drawing.Point(282, 6);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.Size = new System.Drawing.Size(40, 40);
            this.btnSalir1.TabIndex = 294;
            this.btnSalir1.UseVisualStyleBackColor = false;
            this.btnSalir1.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::Proyect_Kardex.Properties.Resources.no_Photo;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(152, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 40);
            this.btnStop.TabIndex = 293;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::Proyect_Kardex.Properties.Resources.playGame;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(91, 6);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 292;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSelect1
            // 
            this.btnSelect1.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect1.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Select;
            this.btnSelect1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect1.FlatAppearance.BorderSize = 0;
            this.btnSelect1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSelect1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSelect1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect1.Location = new System.Drawing.Point(22, 6);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(40, 40);
            this.btnSelect1.TabIndex = 291;
            this.btnSelect1.UseVisualStyleBackColor = false;
            this.btnSelect1.Click += new System.EventHandler(this.btnSelect1_Click);
            // 
            // textScan
            // 
            this.textScan.Location = new System.Drawing.Point(3, 363);
            this.textScan.Multiline = true;
            this.textScan.Name = "textScan";
            this.textScan.Size = new System.Drawing.Size(341, 66);
            this.textScan.TabIndex = 1;
            // 
            // fotoCamera
            // 
            this.fotoCamera.Location = new System.Drawing.Point(3, 78);
            this.fotoCamera.Name = "fotoCamera";
            this.fotoCamera.Size = new System.Drawing.Size(341, 279);
            this.fotoCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoCamera.TabIndex = 0;
            this.fotoCamera.TabStop = false;
            // 
            // tabLect
            // 
            this.tabLect.Controls.Add(this.textLee);
            this.tabLect.Controls.Add(this.panel2);
            this.tabLect.Controls.Add(this.fotoLee);
            this.tabLect.Location = new System.Drawing.Point(4, 21);
            this.tabLect.Name = "tabLect";
            this.tabLect.Padding = new System.Windows.Forms.Padding(3);
            this.tabLect.Size = new System.Drawing.Size(348, 436);
            this.tabLect.TabIndex = 1;
            this.tabLect.Text = "Lector";
            this.tabLect.UseVisualStyleBackColor = true;
            // 
            // textLee
            // 
            this.textLee.Location = new System.Drawing.Point(3, 342);
            this.textLee.Multiline = true;
            this.textLee.Name = "textLee";
            this.textLee.Size = new System.Drawing.Size(341, 88);
            this.textLee.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.btnSalir2);
            this.panel2.Controls.Add(this.btnLee);
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.btnSelect2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 51);
            this.panel2.TabIndex = 3;
            // 
            // btnSalir2
            // 
            this.btnSalir2.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir2.BackgroundImage = global::Proyect_Kardex.Properties.Resources.close_off_512;
            this.btnSalir2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir2.FlatAppearance.BorderSize = 0;
            this.btnSalir2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir2.Location = new System.Drawing.Point(272, 6);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(40, 40);
            this.btnSalir2.TabIndex = 294;
            this.btnSalir2.UseVisualStyleBackColor = false;
            this.btnSalir2.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLee
            // 
            this.btnLee.BackColor = System.Drawing.Color.Transparent;
            this.btnLee.BackgroundImage = global::Proyect_Kardex.Properties.Resources.LectorCodeBarQr;
            this.btnLee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLee.FlatAppearance.BorderSize = 0;
            this.btnLee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLee.Location = new System.Drawing.Point(193, 6);
            this.btnLee.Name = "btnLee";
            this.btnLee.Size = new System.Drawing.Size(40, 40);
            this.btnLee.TabIndex = 293;
            this.btnLee.UseVisualStyleBackColor = false;
            this.btnLee.Click += new System.EventHandler(this.btnLee_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.BackgroundImage = global::Proyect_Kardex.Properties.Resources.LoadCode2;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(110, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(40, 40);
            this.btnLoad.TabIndex = 292;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSelect2
            // 
            this.btnSelect2.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect2.BackgroundImage = global::Proyect_Kardex.Properties.Resources.document_Select;
            this.btnSelect2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect2.FlatAppearance.BorderSize = 0;
            this.btnSelect2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSelect2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSelect2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect2.Location = new System.Drawing.Point(32, 6);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(40, 40);
            this.btnSelect2.TabIndex = 291;
            this.btnSelect2.UseVisualStyleBackColor = false;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect2_Click);
            // 
            // fotoLee
            // 
            this.fotoLee.Location = new System.Drawing.Point(3, 57);
            this.fotoLee.Name = "fotoLee";
            this.fotoLee.Size = new System.Drawing.Size(341, 279);
            this.fotoLee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoLee.TabIndex = 1;
            this.fotoLee.TabStop = false;
            // 
            // timeScan
            // 
            this.timeScan.Tick += new System.EventHandler(this.timeScan_Tick);
            // 
            // Read_Code_Qr_Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(354, 460);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Read_Code_Qr_Bar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lector Codigos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Read_Code_Qr_Bar_FormClosing);
            this.Load += new System.EventHandler(this.Read_Code_Qr_Bar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabScan.ResumeLayout(false);
            this.tabScan.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fotoCamera)).EndInit();
            this.tabLect.ResumeLayout(false);
            this.tabLect.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fotoLee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabScan;
        public System.Windows.Forms.TabPage tabLect;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnSelect1;
        public System.Windows.Forms.Button btnSalir1;
        public System.Windows.Forms.Button btnStop;
        public System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnSalir2;
        public System.Windows.Forms.Button btnLee;
        public System.Windows.Forms.Button btnLoad;
        public System.Windows.Forms.Button btnSelect2;
        public System.Windows.Forms.Button btnScan;
        public System.Windows.Forms.TextBox textScan;
        public System.Windows.Forms.PictureBox fotoCamera;
        public System.Windows.Forms.ComboBox cbCamera;
        public System.Windows.Forms.TextBox textLee;
        public System.Windows.Forms.PictureBox fotoLee;
        public System.Windows.Forms.Timer timeScan;
        public System.Windows.Forms.ToolTip toolRead;
    }
}