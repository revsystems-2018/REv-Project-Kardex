﻿namespace Proyect_Kardex
{
    partial class DelUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelUser));
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textci = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteboton = new System.Windows.Forms.Button();
            this.regboton = new System.Windows.Forms.Button();
            this.buscarboton = new System.Windows.Forms.Button();
            this.toolUser = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(463, 61);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 11);
            this.label23.TabIndex = 205;
            this.label23.Text = "Regsitro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eliminar Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textci
            // 
            this.textci.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textci.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textci.Location = new System.Drawing.Point(148, 34);
            this.textci.Name = "textci";
            this.textci.Size = new System.Drawing.Size(307, 20);
            this.textci.TabIndex = 2;
            this.textci.Text = "C.I. del Usuario a Eliminar";
            this.textci.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DelUserClick);
            this.textci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ciUser);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 12);
            this.label5.TabIndex = 200;
            this.label5.Text = "Carnet de Identidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 11);
            this.label2.TabIndex = 207;
            this.label2.Text = "Eliminar";
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
            this.deleteboton.Location = new System.Drawing.Point(524, 28);
            this.deleteboton.Name = "deleteboton";
            this.deleteboton.Size = new System.Drawing.Size(30, 30);
            this.deleteboton.TabIndex = 5;
            this.deleteboton.UseVisualStyleBackColor = false;
            this.deleteboton.Click += new System.EventHandler(this.deleteboton_Click);
            // 
            // regboton
            // 
            this.regboton.BackColor = System.Drawing.Color.Transparent;
            this.regboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.list;
            this.regboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regboton.FlatAppearance.BorderSize = 0;
            this.regboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.regboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.regboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regboton.Location = new System.Drawing.Point(468, 28);
            this.regboton.Name = "regboton";
            this.regboton.Size = new System.Drawing.Size(30, 30);
            this.regboton.TabIndex = 4;
            this.regboton.UseVisualStyleBackColor = false;
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
            this.buscarboton.Location = new System.Drawing.Point(435, 35);
            this.buscarboton.Name = "buscarboton";
            this.buscarboton.Size = new System.Drawing.Size(19, 18);
            this.buscarboton.TabIndex = 3;
            this.buscarboton.UseVisualStyleBackColor = true;
            this.buscarboton.Click += new System.EventHandler(this.buscarboton_Click);
            // 
            // DelUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(564, 76);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteboton);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.regboton);
            this.Controls.Add(this.buscarboton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textci);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DelUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Usuario ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ToolTip toolUser;
        public System.Windows.Forms.Button regboton;
        public System.Windows.Forms.Button buscarboton;
        public System.Windows.Forms.TextBox textci;
        public System.Windows.Forms.Button deleteboton;
    }
}