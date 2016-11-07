namespace Proyect_Kardex
{
    partial class AEESubCat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AEESubCat));
            this.textcod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.titulolabel = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.toolSUB = new System.Windows.Forms.ToolTip(this.components);
            this.genboton = new System.Windows.Forms.Button();
            this.codetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridSub = new System.Windows.Forms.DataGridView();
            this.codSubCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSubCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEV_DataBaseDataSet = new Proyect_Kardex.REV_DataBaseDataSet();
            this.novoBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.subCategoriasTableAdapter = new Proyect_Kardex.REV_DataBaseDataSetTableAdapters.SubCategoriasTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textcod
            // 
            this.textcod.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textcod.Location = new System.Drawing.Point(77, 95);
            this.textcod.Name = "textcod";
            this.textcod.Size = new System.Drawing.Size(205, 20);
            this.textcod.TabIndex = 5;
            this.textcod.Text = "Descripción de la Sub-Categoría";
            this.textcod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.namesubClick);
            this.textcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.namesub);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 224;
            this.label5.Text = "Nombre";
            // 
            // titulolabel
            // 
            this.titulolabel.AutoSize = true;
            this.titulolabel.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulolabel.Location = new System.Drawing.Point(12, 9);
            this.titulolabel.Name = "titulolabel";
            this.titulolabel.Size = new System.Drawing.Size(170, 19);
            this.titulolabel.TabIndex = 1;
            this.titulolabel.Text = "Registrar SubCategoría";
            this.titulolabel.Click += new System.EventHandler(this.titulolabel_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Transparent;
            this.savebtn.BackgroundImage = global::Proyect_Kardex.Properties.Resources.addListC;
            this.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.savebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Location = new System.Drawing.Point(300, 85);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(30, 30);
            this.savebtn.TabIndex = 6;
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // genboton
            // 
            this.genboton.BackColor = System.Drawing.SystemColors.Menu;
            this.genboton.BackgroundImage = global::Proyect_Kardex.Properties.Resources.magic;
            this.genboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.genboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genboton.FlatAppearance.BorderSize = 0;
            this.genboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.genboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.genboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genboton.Location = new System.Drawing.Point(228, 70);
            this.genboton.Name = "genboton";
            this.genboton.Size = new System.Drawing.Size(19, 18);
            this.genboton.TabIndex = 4;
            this.genboton.UseVisualStyleBackColor = false;
            this.genboton.Click += new System.EventHandler(this.genboton_Click);
            // 
            // codetxt
            // 
            this.codetxt.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codetxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.codetxt.Location = new System.Drawing.Point(77, 69);
            this.codetxt.MaxLength = 5;
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(171, 20);
            this.codetxt.TabIndex = 3;
            this.codetxt.Text = "Codigo de Registro";
            this.codetxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.codetxt_MouseClick);
            this.codetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codetxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 225;
            this.label1.Text = "Codigo";
            // 
            // cbCat
            // 
            this.cbCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(77, 43);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(171, 20);
            this.cbCat.TabIndex = 2;
            this.cbCat.SelectedIndexChanged += new System.EventHandler(this.cbCat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 227;
            this.label2.Text = "Categoría";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridSub);
            this.groupBox1.Controls.Add(this.novoBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.editBtn);
            this.groupBox1.Location = new System.Drawing.Point(6, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 291);
            this.groupBox1.TabIndex = 228;
            this.groupBox1.TabStop = false;
            // 
            // dataGridSub
            // 
            this.dataGridSub.AllowUserToAddRows = false;
            this.dataGridSub.AllowUserToDeleteRows = false;
            this.dataGridSub.AutoGenerateColumns = false;
            this.dataGridSub.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codSubCDataGridViewTextBoxColumn,
            this.nameSubCDataGridViewTextBoxColumn,
            this.catCodDataGridViewTextBoxColumn});
            this.dataGridSub.DataSource = this.subCategoriasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSub.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSub.Location = new System.Drawing.Point(6, 55);
            this.dataGridSub.Name = "dataGridSub";
            this.dataGridSub.ReadOnly = true;
            this.dataGridSub.Size = new System.Drawing.Size(327, 230);
            this.dataGridSub.TabIndex = 10;
            this.dataGridSub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSub_CellClick);
            // 
            // codSubCDataGridViewTextBoxColumn
            // 
            this.codSubCDataGridViewTextBoxColumn.DataPropertyName = "CodSubC";
            this.codSubCDataGridViewTextBoxColumn.HeaderText = "Código de Registro";
            this.codSubCDataGridViewTextBoxColumn.Name = "codSubCDataGridViewTextBoxColumn";
            this.codSubCDataGridViewTextBoxColumn.ReadOnly = true;
            this.codSubCDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameSubCDataGridViewTextBoxColumn
            // 
            this.nameSubCDataGridViewTextBoxColumn.DataPropertyName = "nameSubC";
            this.nameSubCDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameSubCDataGridViewTextBoxColumn.Name = "nameSubCDataGridViewTextBoxColumn";
            this.nameSubCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // catCodDataGridViewTextBoxColumn
            // 
            this.catCodDataGridViewTextBoxColumn.DataPropertyName = "catCod";
            this.catCodDataGridViewTextBoxColumn.HeaderText = "Código Categoría";
            this.catCodDataGridViewTextBoxColumn.Name = "catCodDataGridViewTextBoxColumn";
            this.catCodDataGridViewTextBoxColumn.ReadOnly = true;
            this.catCodDataGridViewTextBoxColumn.Width = 150;
            // 
            // subCategoriasBindingSource
            // 
            this.subCategoriasBindingSource.DataMember = "SubCategorias";
            this.subCategoriasBindingSource.DataSource = this.rEV_DataBaseDataSet;
            // 
            // rEV_DataBaseDataSet
            // 
            this.rEV_DataBaseDataSet.DataSetName = "REV_DataBaseDataSet";
            this.rEV_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // novoBtn
            // 
            this.novoBtn.BackColor = System.Drawing.Color.Transparent;
            this.novoBtn.BackgroundImage = global::Proyect_Kardex.Properties.Resources.newListC;
            this.novoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.novoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.novoBtn.FlatAppearance.BorderSize = 0;
            this.novoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.novoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.novoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novoBtn.Location = new System.Drawing.Point(222, 19);
            this.novoBtn.Name = "novoBtn";
            this.novoBtn.Size = new System.Drawing.Size(30, 30);
            this.novoBtn.TabIndex = 9;
            this.novoBtn.UseVisualStyleBackColor = false;
            this.novoBtn.Click += new System.EventHandler(this.novoBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BackgroundImage = global::Proyect_Kardex.Properties.Resources.delListC;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Enabled = false;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(158, 19);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(30, 30);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.BackgroundImage = global::Proyect_Kardex.Properties.Resources.editListC;
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Enabled = false;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(95, 19);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(30, 30);
            this.editBtn.TabIndex = 7;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // subCategoriasTableAdapter
            // 
            this.subCategoriasTableAdapter.ClearBeforeFill = true;
            // 
            // AEESubCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(350, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.genboton);
            this.Controls.Add(this.codetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.textcod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titulolabel);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AEESubCat";
            this.Text = "Sub-Categoría";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AEESubCat_FormClosing);
            this.Load += new System.EventHandler(this.AEESubCat_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEV_DataBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textcod;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label titulolabel;
        public System.Windows.Forms.Button savebtn;
        public System.Windows.Forms.ToolTip toolSUB;
        public System.Windows.Forms.Button genboton;
        public System.Windows.Forms.TextBox codetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridSub;
        public System.Windows.Forms.Button novoBtn;
        public System.Windows.Forms.Button deleteBtn;
        public System.Windows.Forms.Button editBtn;
        private REV_DataBaseDataSet rEV_DataBaseDataSet;
        private System.Windows.Forms.BindingSource subCategoriasBindingSource;
        private REV_DataBaseDataSetTableAdapters.SubCategoriasTableAdapter subCategoriasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSubCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSubCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catCodDataGridViewTextBoxColumn;
    }
}