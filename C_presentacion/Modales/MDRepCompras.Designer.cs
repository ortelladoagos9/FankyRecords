namespace FankyRecords.C_presentacion.Modales
{
    partial class MDRepCompras
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graficoCompras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.graficoCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // graficoCompras
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoCompras.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoCompras.Legends.Add(legend1);
            this.graficoCompras.Location = new System.Drawing.Point(113, 29);
            this.graficoCompras.Name = "graficoCompras";
            this.graficoCompras.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.graficoCompras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series";
            this.graficoCompras.Series.Add(series1);
            this.graficoCompras.Size = new System.Drawing.Size(416, 362);
            this.graficoCompras.TabIndex = 0;
            this.graficoCompras.Text = "graficoCompras";
            // 
            // MDRepCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.graficoCompras);
            this.Name = "MDRepCompras";
            this.Text = "Reporte de Compras";
            this.Load += new System.EventHandler(this.MDRepCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graficoCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficoCompras;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}