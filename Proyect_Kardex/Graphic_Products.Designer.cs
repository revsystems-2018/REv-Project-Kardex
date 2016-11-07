﻿namespace Proyect_Kardex
{
    partial class Graphic_Products
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphic_Products));
            this.chartProd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartorta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataprodgrid = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataprodgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProd
            // 
            this.chartProd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chartProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chartProd.BorderlineColor = System.Drawing.SystemColors.ControlLight;
            chartArea1.Name = "ChartArea1";
            this.chartProd.ChartAreas.Add(chartArea1);
            this.chartProd.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chartProd.Legends.Add(legend1);
            this.chartProd.Location = new System.Drawing.Point(0, 0);
            this.chartProd.Name = "chartProd";
            this.chartProd.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series1.Legend = "Legend1";
            series1.MarkerSize = 7;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chartProd.Series.Add(series1);
            this.chartProd.Series.Add(series2);
            this.chartProd.Size = new System.Drawing.Size(687, 239);
            this.chartProd.TabIndex = 0;
            this.chartProd.Text = "Productos";
            // 
            // chartorta
            // 
            this.chartorta.BackColor = System.Drawing.SystemColors.MenuBar;
            chartArea2.Name = "ChartArea1";
            this.chartorta.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartorta.Legends.Add(legend2);
            this.chartorta.Location = new System.Drawing.Point(0, 245);
            this.chartorta.Name = "chartorta";
            this.chartorta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 4;
            this.chartorta.Series.Add(series3);
            this.chartorta.Size = new System.Drawing.Size(362, 256);
            this.chartorta.TabIndex = 1;
            this.chartorta.Text = "chart1";
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
            this.dataprodgrid.Location = new System.Drawing.Point(368, 245);
            this.dataprodgrid.Name = "dataprodgrid";
            this.dataprodgrid.ReadOnly = true;
            this.dataprodgrid.Size = new System.Drawing.Size(319, 256);
            this.dataprodgrid.TabIndex = 2;
            // 
            // Graphic_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(687, 502);
            this.Controls.Add(this.dataprodgrid);
            this.Controls.Add(this.chartorta);
            this.Controls.Add(this.chartProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Graphic_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Grafico";
            this.Load += new System.EventHandler(this.Graphic_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataprodgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chartProd;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartorta;
        public System.Windows.Forms.DataGridView dataprodgrid;
        public System.Windows.Forms.ToolTip toolTip1;

    }
}