namespace Proyect_Kardex
{
    partial class ReportClientes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.titulolabel = new System.Windows.Forms.Label();
            this.dataprodgrid = new System.Windows.Forms.DataGridView();
            this.chartorta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataprodgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 12);
            this.label1.TabIndex = 224;
            this.label1.Text = "Registro de Clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 12);
            this.label5.TabIndex = 223;
            this.label5.Text = "Diagrama % por Efectivo Pagado";
            // 
            // titulolabel
            // 
            this.titulolabel.AutoSize = true;
            this.titulolabel.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulolabel.Location = new System.Drawing.Point(285, 4);
            this.titulolabel.Name = "titulolabel";
            this.titulolabel.Size = new System.Drawing.Size(146, 19);
            this.titulolabel.TabIndex = 222;
            this.titulolabel.Text = "Reporte De Clientes";
            // 
            // dataprodgrid
            // 
            this.dataprodgrid.AllowUserToAddRows = false;
            this.dataprodgrid.AllowUserToDeleteRows = false;
            this.dataprodgrid.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataprodgrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataprodgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataprodgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataprodgrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataprodgrid.Location = new System.Drawing.Point(370, 274);
            this.dataprodgrid.Name = "dataprodgrid";
            this.dataprodgrid.ReadOnly = true;
            this.dataprodgrid.Size = new System.Drawing.Size(317, 256);
            this.dataprodgrid.TabIndex = 221;
            // 
            // chartorta
            // 
            this.chartorta.BackColor = System.Drawing.SystemColors.MenuBar;
            chartArea1.Name = "ChartArea1";
            this.chartorta.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartorta.Legends.Add(legend1);
            this.chartorta.Location = new System.Drawing.Point(2, 274);
            this.chartorta.Name = "chartorta";
            this.chartorta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chartorta.Series.Add(series1);
            this.chartorta.Size = new System.Drawing.Size(362, 256);
            this.chartorta.TabIndex = 220;
            this.chartorta.Text = "chart1";
            // 
            // chartProd
            // 
            this.chartProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartProd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chartProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chartProd.BorderlineColor = System.Drawing.SystemColors.ControlLight;
            chartArea2.Name = "ChartArea1";
            this.chartProd.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartProd.Legends.Add(legend2);
            this.chartProd.Location = new System.Drawing.Point(2, 14);
            this.chartProd.Name = "chartProd";
            this.chartProd.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series2.Legend = "Legend1";
            series2.LegendToolTip = "Cantidad";
            series2.MarkerSize = 7;
            series2.Name = "Series1";
            series2.YValuesPerPoint = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.LegendToolTip = "Precios";
            series3.Name = "Series2";
            this.chartProd.Series.Add(series2);
            this.chartProd.Series.Add(series3);
            this.chartProd.Size = new System.Drawing.Size(687, 239);
            this.chartProd.TabIndex = 219;
            this.chartProd.Text = "Productos";
            // 
            // ReportClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(687, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titulolabel);
            this.Controls.Add(this.dataprodgrid);
            this.Controls.Add(this.chartorta);
            this.Controls.Add(this.chartProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafico Estadistico";
            this.Load += new System.EventHandler(this.ReportClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataprodgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label titulolabel;
        public System.Windows.Forms.DataGridView dataprodgrid;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartorta;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartProd;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}