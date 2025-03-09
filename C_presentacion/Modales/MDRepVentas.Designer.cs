namespace FankyRecords.C_presentacion.Modales
{
    partial class MDRepVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBfechaInicioV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBfechaFinV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(44, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Inicio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TBfechaInicioV
            // 
            this.TBfechaInicioV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TBfechaInicioV.Location = new System.Drawing.Point(133, 406);
            this.TBfechaInicioV.Name = "TBfechaInicioV";
            this.TBfechaInicioV.ReadOnly = true;
            this.TBfechaInicioV.Size = new System.Drawing.Size(100, 20);
            this.TBfechaInicioV.TabIndex = 2;
            this.TBfechaInicioV.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(586, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Fin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TBfechaFinV
            // 
            this.TBfechaFinV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBfechaFinV.Location = new System.Drawing.Point(661, 409);
            this.TBfechaFinV.Name = "TBfechaFinV";
            this.TBfechaFinV.ReadOnly = true;
            this.TBfechaFinV.Size = new System.Drawing.Size(100, 20);
            this.TBfechaFinV.TabIndex = 4;
            this.TBfechaFinV.TabStop = false;
            // 
            // MDRepVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBfechaFinV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBfechaInicioV);
            this.Controls.Add(this.label1);
            this.Name = "MDRepVentas";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.MDRepVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBfechaInicioV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBfechaFinV;
    }
}