namespace Proyect_Kardex
{
    partial class SearchMensseger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMensseger));
            this.textbuscar = new System.Windows.Forms.TextBox();
            this.btnCode = new System.Windows.Forms.Button();
            this.btnDet = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.xsalir = new System.Windows.Forms.Button();
            this.toolBuscarSMS = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textbuscar
            // 
            this.textbuscar.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbuscar.Location = new System.Drawing.Point(12, 38);
            this.textbuscar.Name = "textbuscar";
            this.textbuscar.Size = new System.Drawing.Size(239, 32);
            this.textbuscar.TabIndex = 0;
            this.textbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbuscar_KeyPress);
            // 
            // btnCode
            // 
            this.btnCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCode.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarCode_B;
            this.btnCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCode.FlatAppearance.BorderSize = 0;
            this.btnCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCode.Location = new System.Drawing.Point(74, 8);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(25, 25);
            this.btnCode.TabIndex = 33;
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // btnDet
            // 
            this.btnDet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDet.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarDetalle_B;
            this.btnDet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDet.FlatAppearance.BorderSize = 0;
            this.btnDet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDet.Location = new System.Drawing.Point(43, 6);
            this.btnDet.Name = "btnDet";
            this.btnDet.Size = new System.Drawing.Size(25, 25);
            this.btnDet.TabIndex = 32;
            this.btnDet.UseVisualStyleBackColor = true;
            this.btnDet.Click += new System.EventHandler(this.btnDet_Click);
            // 
            // btnName
            // 
            this.btnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnName.BackgroundImage = global::Proyect_Kardex.Properties.Resources.BuscarName;
            this.btnName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnName.FlatAppearance.BorderSize = 0;
            this.btnName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnName.Location = new System.Drawing.Point(12, 7);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(25, 25);
            this.btnName.TabIndex = 31;
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.button1_Click);
            // 
            // xsalir
            // 
            this.xsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xsalir.BackgroundImage = global::Proyect_Kardex.Properties.Resources.cross_close_quit_512;
            this.xsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xsalir.FlatAppearance.BorderSize = 0;
            this.xsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.xsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.xsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xsalir.Location = new System.Drawing.Point(244, 3);
            this.xsalir.Name = "xsalir";
            this.xsalir.Size = new System.Drawing.Size(15, 15);
            this.xsalir.TabIndex = 30;
            this.xsalir.UseVisualStyleBackColor = true;
            this.xsalir.Click += new System.EventHandler(this.xsalir_Click);
            // 
            // SearchMensseger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(263, 78);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.btnDet);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.xsalir);
            this.Controls.Add(this.textbuscar);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchMensseger";
            this.Load += new System.EventHandler(this.SearchMensseger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textbuscar;
        public System.Windows.Forms.Button xsalir;
        public System.Windows.Forms.Button btnName;
        public System.Windows.Forms.Button btnDet;
        public System.Windows.Forms.Button btnCode;
        public System.Windows.Forms.ToolTip toolBuscarSMS;
    }
}