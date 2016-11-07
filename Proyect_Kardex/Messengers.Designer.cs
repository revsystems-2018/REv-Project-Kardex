namespace Proyect_Kardex
{
    partial class Messengers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messengers));
            this.xsalir = new System.Windows.Forms.Button();
            this.textolb = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.xsalir.Location = new System.Drawing.Point(204, 3);
            this.xsalir.Name = "xsalir";
            this.xsalir.Size = new System.Drawing.Size(15, 15);
            this.xsalir.TabIndex = 29;
            this.xsalir.UseVisualStyleBackColor = true;
            this.xsalir.Click += new System.EventHandler(this.xsalir_Click);
            // 
            // textolb
            // 
            this.textolb.AutoSize = true;
            this.textolb.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textolb.Location = new System.Drawing.Point(23, 21);
            this.textolb.Name = "textolb";
            this.textolb.Size = new System.Drawing.Size(157, 22);
            this.textolb.TabIndex = 30;
            this.textolb.Text = "Cliente Guardado.";
            this.textolb.Click += new System.EventHandler(this.label1_Click);
            // 
            // Messengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(223, 61);
            this.Controls.Add(this.textolb);
            this.Controls.Add(this.xsalir);
            this.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1140, 10);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Messengers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Messengers";
            this.Load += new System.EventHandler(this.Messengers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button xsalir;
        public System.Windows.Forms.Label textolb;
    }
}