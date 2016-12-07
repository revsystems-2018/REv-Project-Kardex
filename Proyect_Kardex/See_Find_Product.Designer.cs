namespace Proyect_Kardex
{
    partial class See_Find_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(See_Find_Product));
            this.label1 = new System.Windows.Forms.Label();
            this.citext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.findbtn = new System.Windows.Forms.Button();
            this.botonmax = new System.Windows.Forms.Button();
            this.botonmin = new System.Windows.Forms.Button();
            this.xsalir = new System.Windows.Forms.Button();
            this.regboton = new System.Windows.Forms.Button();
            this.CCUP = new System.Windows.Forms.Label();
            this.PVUP = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cantP = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.MaxP = new System.Windows.Forms.Label();
            this.MinP = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.descP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fechaC = new System.Windows.Forms.Label();
            this.fechav = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.volP = new System.Windows.Forms.Label();
            this.pesoP = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.codP = new System.Windows.Forms.Label();
            this.NomP = new System.Windows.Forms.Label();
            this.codFotoP = new System.Windows.Forms.PictureBox();
            this.fotoP = new System.Windows.Forms.PictureBox();
            this.toolTipfind = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.codFotoP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 219;
            this.label1.Text = "Datos Del Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // citext
            // 
            this.citext.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citext.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.citext.Location = new System.Drawing.Point(148, 37);
            this.citext.Name = "citext";
            this.citext.Size = new System.Drawing.Size(345, 23);
            this.citext.TabIndex = 218;
            this.citext.Text = "Codigo de Registro del Producto";
            this.citext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.citext_MouseClick);
            this.citext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.citext_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 12);
            this.label2.TabIndex = 217;
            this.label2.Text = "Codigo de Registro";
            // 
            // findbtn
            // 
            this.findbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.findbtn.BackgroundImage = global::Proyect_Kardex.Properties.Resources.lupa;
            this.findbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.findbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findbtn.FlatAppearance.BorderSize = 0;
            this.findbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.findbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.findbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findbtn.Location = new System.Drawing.Point(471, 39);
            this.findbtn.Name = "findbtn";
            this.findbtn.Size = new System.Drawing.Size(21, 20);
            this.findbtn.TabIndex = 228;
            this.findbtn.UseVisualStyleBackColor = false;
            this.findbtn.Click += new System.EventHandler(this.findbtn_Click);
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
            this.botonmax.Location = new System.Drawing.Point(503, 4);
            this.botonmax.Name = "botonmax";
            this.botonmax.Size = new System.Drawing.Size(15, 15);
            this.botonmax.TabIndex = 227;
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
            this.botonmin.Location = new System.Drawing.Point(522, 4);
            this.botonmin.Name = "botonmin";
            this.botonmin.Size = new System.Drawing.Size(15, 15);
            this.botonmin.TabIndex = 226;
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
            this.xsalir.Location = new System.Drawing.Point(541, 4);
            this.xsalir.Name = "xsalir";
            this.xsalir.Size = new System.Drawing.Size(15, 15);
            this.xsalir.TabIndex = 225;
            this.xsalir.UseVisualStyleBackColor = true;
            this.xsalir.Click += new System.EventHandler(this.xsalir_Click);
            // 
            // regboton
            // 
            this.regboton.BackColor = System.Drawing.Color.Transparent;
            this.regboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.listProduct;
            this.regboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regboton.FlatAppearance.BorderSize = 0;
            this.regboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.regboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.regboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regboton.Location = new System.Drawing.Point(512, 27);
            this.regboton.Name = "regboton";
            this.regboton.Size = new System.Drawing.Size(40, 40);
            this.regboton.TabIndex = 221;
            this.regboton.UseVisualStyleBackColor = false;
            this.regboton.Click += new System.EventHandler(this.regboton_Click);
            // 
            // CCUP
            // 
            this.CCUP.AutoSize = true;
            this.CCUP.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCUP.Location = new System.Drawing.Point(222, 344);
            this.CCUP.Name = "CCUP";
            this.CCUP.Size = new System.Drawing.Size(91, 15);
            this.CCUP.TabIndex = 254;
            this.CCUP.Text = "____________";
            // 
            // PVUP
            // 
            this.PVUP.AutoSize = true;
            this.PVUP.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PVUP.Location = new System.Drawing.Point(430, 344);
            this.PVUP.Name = "PVUP";
            this.PVUP.Size = new System.Drawing.Size(77, 15);
            this.PVUP.TabIndex = 253;
            this.PVUP.Text = "__________";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(402, 327);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 12);
            this.label19.TabIndex = 252;
            this.label19.Text = "Precio Venta Unitaria:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(181, 327);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 12);
            this.label20.TabIndex = 251;
            this.label20.Text = "Costo Compra Unitaria:";
            // 
            // cantP
            // 
            this.cantP.AutoSize = true;
            this.cantP.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantP.Location = new System.Drawing.Point(465, 307);
            this.cantP.Name = "cantP";
            this.cantP.Size = new System.Drawing.Size(60, 12);
            this.cantP.TabIndex = 250;
            this.cantP.Text = "***********";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(402, 307);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 12);
            this.label16.TabIndex = 249;
            this.label16.Text = "Cantidad:";
            // 
            // MaxP
            // 
            this.MaxP.AutoSize = true;
            this.MaxP.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxP.Location = new System.Drawing.Point(495, 286);
            this.MaxP.Name = "MaxP";
            this.MaxP.Size = new System.Drawing.Size(41, 12);
            this.MaxP.TabIndex = 248;
            this.MaxP.Text = "------";
            // 
            // MinP
            // 
            this.MinP.AutoSize = true;
            this.MinP.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinP.Location = new System.Drawing.Point(495, 265);
            this.MinP.Name = "MinP";
            this.MinP.Size = new System.Drawing.Size(35, 12);
            this.MinP.TabIndex = 247;
            this.MinP.Text = "-----";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(402, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 12);
            this.label12.TabIndex = 246;
            this.label12.Text = "Stock Máximo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(402, 265);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 12);
            this.label14.TabIndex = 245;
            this.label14.Text = "Stock Mínimo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(401, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 244;
            this.label8.Text = "Almacen:";
            // 
            // descP
            // 
            this.descP.AutoSize = true;
            this.descP.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descP.Location = new System.Drawing.Point(181, 265);
            this.descP.Name = "descP";
            this.descP.Size = new System.Drawing.Size(35, 12);
            this.descP.TabIndex = 243;
            this.descP.Text = "-----";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 14);
            this.label7.TabIndex = 242;
            this.label7.Text = "Descripción:";
            // 
            // fechaC
            // 
            this.fechaC.AutoSize = true;
            this.fechaC.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaC.Location = new System.Drawing.Point(301, 212);
            this.fechaC.Name = "fechaC";
            this.fechaC.Size = new System.Drawing.Size(45, 12);
            this.fechaC.TabIndex = 241;
            this.fechaC.Text = "********";
            // 
            // fechav
            // 
            this.fechav.AutoSize = true;
            this.fechav.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechav.Location = new System.Drawing.Point(319, 191);
            this.fechav.Name = "fechav";
            this.fechav.Size = new System.Drawing.Size(45, 12);
            this.fechav.TabIndex = 240;
            this.fechav.Text = "********";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 12);
            this.label5.TabIndex = 239;
            this.label5.Text = "Fecha de Creación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 12);
            this.label6.TabIndex = 238;
            this.label6.Text = "Fecha de Vencimiento:";
            // 
            // volP
            // 
            this.volP.AutoSize = true;
            this.volP.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volP.Location = new System.Drawing.Point(245, 307);
            this.volP.Name = "volP";
            this.volP.Size = new System.Drawing.Size(40, 12);
            this.volP.TabIndex = 237;
            this.volP.Text = "*******";
            // 
            // pesoP
            // 
            this.pesoP.AutoSize = true;
            this.pesoP.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoP.Location = new System.Drawing.Point(245, 286);
            this.pesoP.Name = "pesoP";
            this.pesoP.Size = new System.Drawing.Size(45, 12);
            this.pesoP.TabIndex = 236;
            this.pesoP.Text = "********";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(181, 307);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 12);
            this.label13.TabIndex = 235;
            this.label13.Text = "Volumen:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(181, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 12);
            this.label11.TabIndex = 234;
            this.label11.Text = "Peso:";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.ForeColor = System.Drawing.Color.LimeGreen;
            this.state.Location = new System.Drawing.Point(180, 162);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(29, 18);
            this.state.TabIndex = 233;
            this.state.Text = "***";
            // 
            // codP
            // 
            this.codP.AutoSize = true;
            this.codP.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codP.Location = new System.Drawing.Point(177, 133);
            this.codP.Name = "codP";
            this.codP.Size = new System.Drawing.Size(28, 22);
            this.codP.TabIndex = 232;
            this.codP.Text = "...";
            // 
            // NomP
            // 
            this.NomP.AutoSize = true;
            this.NomP.Font = new System.Drawing.Font("Exotc350 Bd BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomP.ForeColor = System.Drawing.Color.Black;
            this.NomP.Location = new System.Drawing.Point(177, 92);
            this.NomP.Name = "NomP";
            this.NomP.Size = new System.Drawing.Size(42, 34);
            this.NomP.TabIndex = 231;
            this.NomP.Text = "...";
            // 
            // codFotoP
            // 
            this.codFotoP.Location = new System.Drawing.Point(12, 283);
            this.codFotoP.Name = "codFotoP";
            this.codFotoP.Size = new System.Drawing.Size(159, 76);
            this.codFotoP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.codFotoP.TabIndex = 230;
            this.codFotoP.TabStop = false;
            // 
            // fotoP
            // 
            this.fotoP.Location = new System.Drawing.Point(12, 75);
            this.fotoP.Name = "fotoP";
            this.fotoP.Size = new System.Drawing.Size(159, 202);
            this.fotoP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoP.TabIndex = 229;
            this.fotoP.TabStop = false;
            // 
            // See_Find_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(564, 371);
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
            this.Controls.Add(this.NomP);
            this.Controls.Add(this.codFotoP);
            this.Controls.Add(this.fotoP);
            this.Controls.Add(this.findbtn);
            this.Controls.Add(this.botonmax);
            this.Controls.Add(this.botonmin);
            this.Controls.Add(this.xsalir);
            this.Controls.Add(this.regboton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.citext);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "See_Find_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar/Mostrar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.codFotoP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button botonmax;
        public System.Windows.Forms.Button botonmin;
        public System.Windows.Forms.Button xsalir;
        private System.Windows.Forms.Button regboton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox citext;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button findbtn;
        public System.Windows.Forms.Label CCUP;
        public System.Windows.Forms.Label PVUP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label cantP;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label MaxP;
        public System.Windows.Forms.Label MinP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label descP;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label fechaC;
        public System.Windows.Forms.Label fechav;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label volP;
        public System.Windows.Forms.Label pesoP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label state;
        public System.Windows.Forms.Label codP;
        public System.Windows.Forms.Label NomP;
        public System.Windows.Forms.PictureBox codFotoP;
        public System.Windows.Forms.PictureBox fotoP;
        public System.Windows.Forms.ToolTip toolTipfind;
    }
}