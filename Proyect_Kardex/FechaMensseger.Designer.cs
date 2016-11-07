namespace Proyect_Kardex
{
    partial class FechaMensseger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FechaMensseger));
            this.xsalir = new System.Windows.Forms.Button();
            this.dateTimeini = new System.Windows.Forms.DateTimePicker();
            this.dateTimefin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.toolTipFecha = new System.Windows.Forms.ToolTip(this.components);
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
            this.xsalir.Location = new System.Drawing.Point(274, 3);
            this.xsalir.Name = "xsalir";
            this.xsalir.Size = new System.Drawing.Size(15, 15);
            this.xsalir.TabIndex = 31;
            this.xsalir.UseVisualStyleBackColor = true;
            this.xsalir.Click += new System.EventHandler(this.xsalir_Click);
            // 
            // dateTimeini
            // 
            this.dateTimeini.Location = new System.Drawing.Point(33, 37);
            this.dateTimeini.Name = "dateTimeini";
            this.dateTimeini.Size = new System.Drawing.Size(200, 20);
            this.dateTimeini.TabIndex = 32;
            // 
            // dateTimefin
            // 
            this.dateTimefin.Location = new System.Drawing.Point(33, 81);
            this.dateTimefin.Name = "dateTimefin";
            this.dateTimefin.Size = new System.Drawing.Size(200, 20);
            this.dateTimefin.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 320;
            this.label5.Text = "Fecha de Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 12);
            this.label1.TabIndex = 321;
            this.label1.Text = "Fecha de Inicio";
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.Transparent;
            this.send.BackgroundImage = global::Proyect_Kardex.Properties.Resources.sendSMS;
            this.send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.FlatAppearance.BorderSize = 0;
            this.send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Location = new System.Drawing.Point(242, 51);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(35, 35);
            this.send.TabIndex = 322;
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // FechaMensseger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(291, 112);
            this.Controls.Add(this.send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimefin);
            this.Controls.Add(this.dateTimeini);
            this.Controls.Add(this.xsalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FechaMensseger";
            this.Load += new System.EventHandler(this.FechaMensseger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button xsalir;
        private System.Windows.Forms.DateTimePicker dateTimeini;
        private System.Windows.Forms.DateTimePicker dateTimefin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button send;
        public System.Windows.Forms.ToolTip toolTipFecha;
    }
}