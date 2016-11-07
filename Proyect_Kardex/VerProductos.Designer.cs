namespace Proyect_Kardex
{
    partial class VerProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerProductos));
            this.NomP = new System.Windows.Forms.Label();
            this.codFotoP = new System.Windows.Forms.PictureBox();
            this.fotoP = new System.Windows.Forms.PictureBox();
            this.botonmax = new System.Windows.Forms.Button();
            this.botonmin = new System.Windows.Forms.Button();
            this.xsalir = new System.Windows.Forms.Button();
            this.codP = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.volP = new System.Windows.Forms.Label();
            this.pesoP = new System.Windows.Forms.Label();
            this.fechaC = new System.Windows.Forms.Label();
            this.fechav = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.descP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxP = new System.Windows.Forms.Label();
            this.MinP = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cantP = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CCUP = new System.Windows.Forms.Label();
            this.PVUP = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.codFotoP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoP)).BeginInit();
            this.SuspendLayout();
            // 
            // NomP
            // 
            this.NomP.AutoSize = true;
            this.NomP.Font = new System.Drawing.Font("Exotc350 Bd BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomP.ForeColor = System.Drawing.Color.Black;
            this.NomP.Location = new System.Drawing.Point(177, 29);
            this.NomP.Name = "NomP";
            this.NomP.Size = new System.Drawing.Size(372, 34);
            this.NomP.TabIndex = 2;
            this.NomP.Text = "Nombre del Producto BREVE";
            // 
            // codFotoP
            // 
            this.codFotoP.Location = new System.Drawing.Point(12, 220);
            this.codFotoP.Name = "codFotoP";
            this.codFotoP.Size = new System.Drawing.Size(159, 76);
            this.codFotoP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.codFotoP.TabIndex = 1;
            this.codFotoP.TabStop = false;
            // 
            // fotoP
            // 
            this.fotoP.Location = new System.Drawing.Point(12, 12);
            this.fotoP.Name = "fotoP";
            this.fotoP.Size = new System.Drawing.Size(159, 202);
            this.fotoP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoP.TabIndex = 0;
            this.fotoP.TabStop = false;
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
            this.botonmax.Location = new System.Drawing.Point(509, 3);
            this.botonmax.Name = "botonmax";
            this.botonmax.Size = new System.Drawing.Size(15, 15);
            this.botonmax.TabIndex = 62;
            this.botonmax.UseVisualStyleBackColor = true;
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
            this.botonmin.Location = new System.Drawing.Point(528, 3);
            this.botonmin.Name = "botonmin";
            this.botonmin.Size = new System.Drawing.Size(15, 15);
            this.botonmin.TabIndex = 61;
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
            this.xsalir.Location = new System.Drawing.Point(547, 3);
            this.xsalir.Name = "xsalir";
            this.xsalir.Size = new System.Drawing.Size(15, 15);
            this.xsalir.TabIndex = 60;
            this.xsalir.UseVisualStyleBackColor = true;
            this.xsalir.Click += new System.EventHandler(this.xsalir_Click);
            // 
            // codP
            // 
            this.codP.AutoSize = true;
            this.codP.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codP.Location = new System.Drawing.Point(177, 70);
            this.codP.Name = "codP";
            this.codP.Size = new System.Drawing.Size(166, 22);
            this.codP.TabIndex = 63;
            this.codP.Text = "7985636521254";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.ForeColor = System.Drawing.Color.LimeGreen;
            this.state.Location = new System.Drawing.Point(180, 99);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(60, 18);
            this.state.TabIndex = 65;
            this.state.Text = "Nuevo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(181, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 12);
            this.label13.TabIndex = 68;
            this.label13.Text = "Volumen:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(181, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 12);
            this.label11.TabIndex = 67;
            this.label11.Text = "Peso:";
            // 
            // volP
            // 
            this.volP.AutoSize = true;
            this.volP.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volP.Location = new System.Drawing.Point(245, 244);
            this.volP.Name = "volP";
            this.volP.Size = new System.Drawing.Size(68, 12);
            this.volP.TabIndex = 70;
            this.volP.Text = "443694528";
            // 
            // pesoP
            // 
            this.pesoP.AutoSize = true;
            this.pesoP.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoP.Location = new System.Drawing.Point(245, 223);
            this.pesoP.Name = "pesoP";
            this.pesoP.Size = new System.Drawing.Size(68, 12);
            this.pesoP.TabIndex = 69;
            this.pesoP.Text = "443694528";
            // 
            // fechaC
            // 
            this.fechaC.AutoSize = true;
            this.fechaC.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaC.Location = new System.Drawing.Point(301, 149);
            this.fechaC.Name = "fechaC";
            this.fechaC.Size = new System.Drawing.Size(68, 12);
            this.fechaC.TabIndex = 74;
            this.fechaC.Text = "443694528";
            // 
            // fechav
            // 
            this.fechav.AutoSize = true;
            this.fechav.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechav.Location = new System.Drawing.Point(319, 128);
            this.fechav.Name = "fechav";
            this.fechav.Size = new System.Drawing.Size(68, 12);
            this.fechav.TabIndex = 73;
            this.fechav.Text = "443694528";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 12);
            this.label5.TabIndex = 72;
            this.label5.Text = "Fecha de Creación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 12);
            this.label6.TabIndex = 71;
            this.label6.Text = "Fecha de Vencimiento:";
            // 
            // descP
            // 
            this.descP.AutoSize = true;
            this.descP.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descP.Location = new System.Drawing.Point(181, 202);
            this.descP.Name = "descP";
            this.descP.Size = new System.Drawing.Size(147, 12);
            this.descP.TabIndex = 77;
            this.descP.Text = "La direccion de la Empresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 14);
            this.label7.TabIndex = 75;
            this.label7.Text = "Descripción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(401, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 78;
            this.label8.Text = "Almacen:";
            // 
            // MaxP
            // 
            this.MaxP.AutoSize = true;
            this.MaxP.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxP.Location = new System.Drawing.Point(495, 223);
            this.MaxP.Name = "MaxP";
            this.MaxP.Size = new System.Drawing.Size(54, 12);
            this.MaxP.TabIndex = 82;
            this.MaxP.Text = "4436945";
            // 
            // MinP
            // 
            this.MinP.AutoSize = true;
            this.MinP.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinP.Location = new System.Drawing.Point(495, 202);
            this.MinP.Name = "MinP";
            this.MinP.Size = new System.Drawing.Size(33, 12);
            this.MinP.TabIndex = 81;
            this.MinP.Text = "4436";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(402, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 12);
            this.label12.TabIndex = 80;
            this.label12.Text = "Stock Máximo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(402, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 12);
            this.label14.TabIndex = 79;
            this.label14.Text = "Stock Mínimo:";
            // 
            // cantP
            // 
            this.cantP.AutoSize = true;
            this.cantP.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantP.Location = new System.Drawing.Point(465, 244);
            this.cantP.Name = "cantP";
            this.cantP.Size = new System.Drawing.Size(68, 12);
            this.cantP.TabIndex = 84;
            this.cantP.Text = "443694528";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(402, 244);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 12);
            this.label16.TabIndex = 83;
            this.label16.Text = "Cantidad:";
            // 
            // CCUP
            // 
            this.CCUP.AutoSize = true;
            this.CCUP.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCUP.Location = new System.Drawing.Point(222, 281);
            this.CCUP.Name = "CCUP";
            this.CCUP.Size = new System.Drawing.Size(79, 15);
            this.CCUP.TabIndex = 88;
            this.CCUP.Text = "443694528";
            // 
            // PVUP
            // 
            this.PVUP.AutoSize = true;
            this.PVUP.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PVUP.Location = new System.Drawing.Point(430, 281);
            this.PVUP.Name = "PVUP";
            this.PVUP.Size = new System.Drawing.Size(79, 15);
            this.PVUP.TabIndex = 87;
            this.PVUP.Text = "443694528";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(402, 264);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 12);
            this.label19.TabIndex = 86;
            this.label19.Text = "Precio Venta Unitaria:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(181, 264);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 12);
            this.label20.TabIndex = 85;
            this.label20.Text = "Costo Compra Unitaria:";
            // 
            // VerProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(566, 301);
            this.Controls.Add(this.CCUP);
            this.Controls.Add(this.PVUP);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cantP);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.MaxP);
            this.Controls.Add(this.MinP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.descP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fechaC);
            this.Controls.Add(this.fechav);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.volP);
            this.Controls.Add(this.pesoP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.state);
            this.Controls.Add(this.codP);
            this.Controls.Add(this.botonmax);
            this.Controls.Add(this.botonmin);
            this.Controls.Add(this.xsalir);
            this.Controls.Add(this.NomP);
            this.Controls.Add(this.codFotoP);
            this.Controls.Add(this.fotoP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerProductos";
            this.Text = "VerProductos";
            this.Load += new System.EventHandler(this.VerProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codFotoP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button botonmax;
        public System.Windows.Forms.Button botonmin;
        public System.Windows.Forms.Button xsalir;
        public System.Windows.Forms.Label state;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label volP;
        public System.Windows.Forms.Label pesoP;
        public System.Windows.Forms.Label fechaC;
        public System.Windows.Forms.Label fechav;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label descP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label MaxP;
        public System.Windows.Forms.Label MinP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label cantP;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label CCUP;
        public System.Windows.Forms.Label PVUP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.PictureBox fotoP;
        public System.Windows.Forms.PictureBox codFotoP;
        public System.Windows.Forms.Label NomP;
        public System.Windows.Forms.Label codP;
    }
}