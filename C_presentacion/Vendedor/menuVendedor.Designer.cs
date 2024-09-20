namespace FankyRecords.C_presentacion.Vendedor
{
    partial class formMenuVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenuVendedor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTituloVendedor = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTituloVendedor
            // 
            this.menuTituloVendedor.BackColor = System.Drawing.Color.DarkRed;
            this.menuTituloVendedor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTituloVendedor.Location = new System.Drawing.Point(0, 0);
            this.menuTituloVendedor.Name = "menuTituloVendedor";
            this.menuTituloVendedor.Size = new System.Drawing.Size(1182, 24);
            this.menuTituloVendedor.TabIndex = 1;
            // 
            // formMenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 614);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuTituloVendedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMenuVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuTituloVendedor;
    }
}