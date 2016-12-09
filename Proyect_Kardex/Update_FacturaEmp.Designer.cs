namespace Proyect_Kardex
{
    partial class Update_FacturaEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_FacturaEmp));
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cdctxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ndatxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tituloemp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.salirboton = new System.Windows.Forms.Button();
            this.saveboton = new System.Windows.Forms.Button();
            this.logoview = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.qrtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenQr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoview)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(214, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 11);
            this.label17.TabIndex = 64;
            this.label17.Text = "Guardar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(282, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 11);
            this.label16.TabIndex = 63;
            this.label16.Text = "Cancelar";
            // 
            // cdctxt
            // 
            this.cdctxt.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdctxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cdctxt.Location = new System.Drawing.Point(139, 72);
            this.cdctxt.Name = "cdctxt";
            this.cdctxt.Size = new System.Drawing.Size(190, 20);
            this.cdctxt.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Codigo de Control";
            // 
            // ndatxt
            // 
            this.ndatxt.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndatxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ndatxt.Location = new System.Drawing.Point(139, 41);
            this.ndatxt.Name = "ndatxt";
            this.ndatxt.Size = new System.Drawing.Size(190, 20);
            this.ndatxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Número de Autorización";
            // 
            // tituloemp
            // 
            this.tituloemp.AutoSize = true;
            this.tituloemp.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloemp.Location = new System.Drawing.Point(12, 9);
            this.tituloemp.Name = "tituloemp";
            this.tituloemp.Size = new System.Drawing.Size(163, 19);
            this.tituloemp.TabIndex = 1;
            this.tituloemp.Text = "Codigo De Facturación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 11);
            this.label2.TabIndex = 67;
            this.label2.Text = "Generar";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Proyect_Kardex.Properties.Resources.qr_code;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(117, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salirboton
            // 
            this.salirboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.off;
            this.salirboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salirboton.FlatAppearance.BorderSize = 0;
            this.salirboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.salirboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.salirboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirboton.Location = new System.Drawing.Point(288, 139);
            this.salirboton.Name = "salirboton";
            this.salirboton.Size = new System.Drawing.Size(30, 30);
            this.salirboton.TabIndex = 7;
            this.salirboton.UseVisualStyleBackColor = true;
            this.salirboton.Click += new System.EventHandler(this.salirboton_Click);
            // 
            // saveboton
            // 
            this.saveboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.save;
            this.saveboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveboton.Enabled = false;
            this.saveboton.FlatAppearance.BorderSize = 0;
            this.saveboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.saveboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveboton.Location = new System.Drawing.Point(219, 139);
            this.saveboton.Name = "saveboton";
            this.saveboton.Size = new System.Drawing.Size(30, 30);
            this.saveboton.TabIndex = 6;
            this.saveboton.UseVisualStyleBackColor = true;
            this.saveboton.Click += new System.EventHandler(this.saveboton_Click);
            // 
            // logoview
            // 
            this.logoview.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.logoview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoview.Location = new System.Drawing.Point(335, 9);
            this.logoview.Name = "logoview";
            this.logoview.Size = new System.Drawing.Size(179, 174);
            this.logoview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoview.TabIndex = 55;
            this.logoview.TabStop = false;
            // 
            // qrtxt
            // 
            this.qrtxt.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.qrtxt.Location = new System.Drawing.Point(139, 103);
            this.qrtxt.Name = "qrtxt";
            this.qrtxt.Size = new System.Drawing.Size(190, 20);
            this.qrtxt.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Codigo QR";
            // 
            // btnOpenQr
            // 
            this.btnOpenQr.BackgroundImage = global::Proyect_Kardex.Properties.Resources.list_1;
            this.btnOpenQr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenQr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenQr.FlatAppearance.BorderSize = 0;
            this.btnOpenQr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOpenQr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnOpenQr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenQr.Location = new System.Drawing.Point(309, 104);
            this.btnOpenQr.Name = "btnOpenQr";
            this.btnOpenQr.Size = new System.Drawing.Size(19, 18);
            this.btnOpenQr.TabIndex = 70;
            this.btnOpenQr.UseVisualStyleBackColor = true;
            this.btnOpenQr.Click += new System.EventHandler(this.btnOpenQr_Click);
            // 
            // Update_FacturaEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(519, 186);
            this.Controls.Add(this.btnOpenQr);
            this.Controls.Add(this.qrtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.salirboton);
            this.Controls.Add(this.saveboton);
            this.Controls.Add(this.cdctxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ndatxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoview);
            this.Controls.Add(this.tituloemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update_FacturaEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codigos de Factura";
            this.Load += new System.EventHandler(this.Update_FacturaEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button salirboton;
        private System.Windows.Forms.Button saveboton;
        public System.Windows.Forms.TextBox cdctxt;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox ndatxt;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox logoview;
        public System.Windows.Forms.Label tituloemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox qrtxt;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnOpenQr;
    }
}