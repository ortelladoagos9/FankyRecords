namespace FankyRecords.C_presentacion.Vendedor
{
    partial class FormMenuVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuVendedor));
            this.menuVendedor = new System.Windows.Forms.MenuStrip();
            this.MenuClientesVendedor = new FontAwesome.Sharp.IconMenuItem();
            this.MenuVentasVendedor = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuRegistrarVentasVendedor = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuDetalleVentasVendedor = new FontAwesome.Sharp.IconMenuItem();
            this.MenuProductoVendedor = new FontAwesome.Sharp.IconMenuItem();
            this.menuTituloVendedor = new System.Windows.Forms.MenuStrip();
            this.IconSalirVendedor = new FontAwesome.Sharp.IconMenuItem();
            this.IconExpandirVendedor = new FontAwesome.Sharp.IconMenuItem();
            this.IconMinimizarVendedor = new FontAwesome.Sharp.IconMenuItem();
            this.contenedorVendedor = new System.Windows.Forms.Panel();
            this.labVendedor = new System.Windows.Forms.Label();
            this.picFankyRecordsVendedor = new System.Windows.Forms.PictureBox();
            this.labFankyRecordsMenuVendedor = new System.Windows.Forms.Label();
            this.labUsuarioRolVendedor = new System.Windows.Forms.Label();
            this.menuVendedor.SuspendLayout();
            this.menuTituloVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFankyRecordsVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVendedor
            // 
            this.menuVendedor.AutoSize = false;
            this.menuVendedor.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.menuVendedor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuVendedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuClientesVendedor,
            this.MenuVentasVendedor,
            this.MenuProductoVendedor});
            this.menuVendedor.Location = new System.Drawing.Point(0, 97);
            this.menuVendedor.Name = "menuVendedor";
            this.menuVendedor.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuVendedor.Size = new System.Drawing.Size(1200, 63);
            this.menuVendedor.TabIndex = 0;
            // 
            // MenuClientesVendedor
            // 
            this.MenuClientesVendedor.AutoSize = false;
            this.MenuClientesVendedor.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuClientesVendedor.ForeColor = System.Drawing.Color.DarkRed;
            this.MenuClientesVendedor.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.MenuClientesVendedor.IconColor = System.Drawing.Color.DarkRed;
            this.MenuClientesVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuClientesVendedor.IconSize = 45;
            this.MenuClientesVendedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuClientesVendedor.Name = "MenuClientesVendedor";
            this.MenuClientesVendedor.Size = new System.Drawing.Size(150, 59);
            this.MenuClientesVendedor.Text = "Clientes";
            this.MenuClientesVendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuVentasVendedor
            // 
            this.MenuVentasVendedor.AutoSize = false;
            this.MenuVentasVendedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuRegistrarVentasVendedor,
            this.SubmenuDetalleVentasVendedor});
            this.MenuVentasVendedor.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuVentasVendedor.ForeColor = System.Drawing.Color.DarkRed;
            this.MenuVentasVendedor.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.MenuVentasVendedor.IconColor = System.Drawing.Color.DarkRed;
            this.MenuVentasVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVentasVendedor.IconSize = 45;
            this.MenuVentasVendedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentasVendedor.Name = "MenuVentasVendedor";
            this.MenuVentasVendedor.Size = new System.Drawing.Size(152, 59);
            this.MenuVentasVendedor.Text = "Ventas";
            this.MenuVentasVendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubmenuRegistrarVentasVendedor
            // 
            this.SubmenuRegistrarVentasVendedor.AutoSize = false;
            this.SubmenuRegistrarVentasVendedor.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.SubmenuRegistrarVentasVendedor.ForeColor = System.Drawing.Color.DarkRed;
            this.SubmenuRegistrarVentasVendedor.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.SubmenuRegistrarVentasVendedor.IconColor = System.Drawing.Color.DarkRed;
            this.SubmenuRegistrarVentasVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuRegistrarVentasVendedor.IconSize = 25;
            this.SubmenuRegistrarVentasVendedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SubmenuRegistrarVentasVendedor.Name = "SubmenuRegistrarVentasVendedor";
            this.SubmenuRegistrarVentasVendedor.Size = new System.Drawing.Size(230, 35);
            this.SubmenuRegistrarVentasVendedor.Text = "Registrar ventas";
            this.SubmenuRegistrarVentasVendedor.Click += new System.EventHandler(this.SubmenuRegistrarVentasVendedor_Click);
            // 
            // SubmenuDetalleVentasVendedor
            // 
            this.SubmenuDetalleVentasVendedor.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.SubmenuDetalleVentasVendedor.ForeColor = System.Drawing.Color.DarkRed;
            this.SubmenuDetalleVentasVendedor.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.SubmenuDetalleVentasVendedor.IconColor = System.Drawing.Color.DarkRed;
            this.SubmenuDetalleVentasVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuDetalleVentasVendedor.IconSize = 25;
            this.SubmenuDetalleVentasVendedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SubmenuDetalleVentasVendedor.Name = "SubmenuDetalleVentasVendedor";
            this.SubmenuDetalleVentasVendedor.Size = new System.Drawing.Size(229, 32);
            this.SubmenuDetalleVentasVendedor.Text = "Detalle de venta";
            this.SubmenuDetalleVentasVendedor.Click += new System.EventHandler(this.SubmenuDetalleVentasVendedor_Click);
            // 
            // MenuProductoVendedor
            // 
            this.MenuProductoVendedor.AutoSize = false;
            this.MenuProductoVendedor.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProductoVendedor.ForeColor = System.Drawing.Color.DarkRed;
            this.MenuProductoVendedor.IconChar = FontAwesome.Sharp.IconChar.CompactDisc;
            this.MenuProductoVendedor.IconColor = System.Drawing.Color.DarkRed;
            this.MenuProductoVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProductoVendedor.IconSize = 45;
            this.MenuProductoVendedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProductoVendedor.Name = "MenuProductoVendedor";
            this.MenuProductoVendedor.Size = new System.Drawing.Size(150, 59);
            this.MenuProductoVendedor.Text = "Productos";
            this.MenuProductoVendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuProductoVendedor.Click += new System.EventHandler(this.MenuProductoVendedor_Click);
            // 
            // menuTituloVendedor
            // 
            this.menuTituloVendedor.AutoSize = false;
            this.menuTituloVendedor.BackColor = System.Drawing.Color.DarkRed;
            this.menuTituloVendedor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTituloVendedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconSalirVendedor,
            this.IconExpandirVendedor,
            this.IconMinimizarVendedor});
            this.menuTituloVendedor.Location = new System.Drawing.Point(0, 0);
            this.menuTituloVendedor.Name = "menuTituloVendedor";
            this.menuTituloVendedor.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuTituloVendedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTituloVendedor.Size = new System.Drawing.Size(1200, 97);
            this.menuTituloVendedor.TabIndex = 1;
            // 
            // IconSalirVendedor
            // 
            this.IconSalirVendedor.AutoSize = false;
            this.IconSalirVendedor.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.IconSalirVendedor.IconColor = System.Drawing.Color.Gold;
            this.IconSalirVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconSalirVendedor.IconSize = 30;
            this.IconSalirVendedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconSalirVendedor.Name = "IconSalirVendedor";
            this.IconSalirVendedor.Size = new System.Drawing.Size(50, 93);
            this.IconSalirVendedor.Click += new System.EventHandler(this.IconSalirVendedor_Click);
            // 
            // IconExpandirVendedor
            // 
            this.IconExpandirVendedor.AutoSize = false;
            this.IconExpandirVendedor.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.IconExpandirVendedor.IconColor = System.Drawing.Color.Gold;
            this.IconExpandirVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconExpandirVendedor.IconSize = 25;
            this.IconExpandirVendedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconExpandirVendedor.Name = "IconExpandirVendedor";
            this.IconExpandirVendedor.Size = new System.Drawing.Size(50, 93);
            this.IconExpandirVendedor.Click += new System.EventHandler(this.IconExpandirVendedor_Click);
            // 
            // IconMinimizarVendedor
            // 
            this.IconMinimizarVendedor.AutoSize = false;
            this.IconMinimizarVendedor.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.IconMinimizarVendedor.IconColor = System.Drawing.Color.Gold;
            this.IconMinimizarVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconMinimizarVendedor.IconSize = 30;
            this.IconMinimizarVendedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconMinimizarVendedor.Name = "IconMinimizarVendedor";
            this.IconMinimizarVendedor.Size = new System.Drawing.Size(50, 93);
            this.IconMinimizarVendedor.Click += new System.EventHandler(this.IconMinimizarVendedor_Click);
            // 
            // contenedorVendedor
            // 
            this.contenedorVendedor.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorVendedor.BackgroundImage = global::FankyRecords.Properties.Resources.fondoFanky1;
            this.contenedorVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.contenedorVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorVendedor.Location = new System.Drawing.Point(0, 160);
            this.contenedorVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorVendedor.Name = "contenedorVendedor";
            this.contenedorVendedor.Size = new System.Drawing.Size(1200, 652);
            this.contenedorVendedor.TabIndex = 7;
            // 
            // labVendedor
            // 
            this.labVendedor.AutoSize = true;
            this.labVendedor.BackColor = System.Drawing.Color.DarkRed;
            this.labVendedor.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVendedor.ForeColor = System.Drawing.Color.Gold;
            this.labVendedor.Location = new System.Drawing.Point(879, 35);
            this.labVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labVendedor.Name = "labVendedor";
            this.labVendedor.Size = new System.Drawing.Size(94, 20);
            this.labVendedor.TabIndex = 5;
            this.labVendedor.Text = "Vendedor";
            // 
            // picFankyRecordsVendedor
            // 
            this.picFankyRecordsVendedor.BackColor = System.Drawing.Color.DarkRed;
            this.picFankyRecordsVendedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.picFankyRecordsVendedor.Image = global::FankyRecords.Properties.Resources.Fanky_records1;
            this.picFankyRecordsVendedor.Location = new System.Drawing.Point(12, 12);
            this.picFankyRecordsVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.picFankyRecordsVendedor.Name = "picFankyRecordsVendedor";
            this.picFankyRecordsVendedor.Size = new System.Drawing.Size(72, 72);
            this.picFankyRecordsVendedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFankyRecordsVendedor.TabIndex = 3;
            this.picFankyRecordsVendedor.TabStop = false;
            // 
            // labFankyRecordsMenuVendedor
            // 
            this.labFankyRecordsMenuVendedor.AutoSize = true;
            this.labFankyRecordsMenuVendedor.BackColor = System.Drawing.Color.DarkRed;
            this.labFankyRecordsMenuVendedor.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFankyRecordsMenuVendedor.ForeColor = System.Drawing.Color.Gold;
            this.labFankyRecordsMenuVendedor.Location = new System.Drawing.Point(102, 35);
            this.labFankyRecordsMenuVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFankyRecordsMenuVendedor.Name = "labFankyRecordsMenuVendedor";
            this.labFankyRecordsMenuVendedor.Size = new System.Drawing.Size(210, 29);
            this.labFankyRecordsMenuVendedor.TabIndex = 2;
            this.labFankyRecordsMenuVendedor.Text = "Fanky Records";
            // 
            // labUsuarioRolVendedor
            // 
            this.labUsuarioRolVendedor.AutoSize = true;
            this.labUsuarioRolVendedor.BackColor = System.Drawing.Color.DarkRed;
            this.labUsuarioRolVendedor.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsuarioRolVendedor.ForeColor = System.Drawing.Color.Gold;
            this.labUsuarioRolVendedor.Location = new System.Drawing.Point(795, 35);
            this.labUsuarioRolVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUsuarioRolVendedor.Name = "labUsuarioRolVendedor";
            this.labUsuarioRolVendedor.Size = new System.Drawing.Size(86, 20);
            this.labUsuarioRolVendedor.TabIndex = 4;
            this.labUsuarioRolVendedor.Text = "Usuario:";
            // 
            // FormMenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 812);
            this.Controls.Add(this.labVendedor);
            this.Controls.Add(this.labUsuarioRolVendedor);
            this.Controls.Add(this.labFankyRecordsMenuVendedor);
            this.Controls.Add(this.picFankyRecordsVendedor);
            this.Controls.Add(this.contenedorVendedor);
            this.Controls.Add(this.menuVendedor);
            this.Controls.Add(this.menuTituloVendedor);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuVendedor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenuVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Vendedor";
            this.menuVendedor.ResumeLayout(false);
            this.menuVendedor.PerformLayout();
            this.menuTituloVendedor.ResumeLayout(false);
            this.menuTituloVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFankyRecordsVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picFankyRecordsVendedor;
        private System.Windows.Forms.Label labFankyRecordsMenuVendedor;
        private System.Windows.Forms.Label labUsuarioRolVendedor;
        private System.Windows.Forms.Label labVendedor;
        private FontAwesome.Sharp.IconMenuItem IconSalirVendedor;
        private FontAwesome.Sharp.IconMenuItem IconExpandirVendedor;
        private FontAwesome.Sharp.IconMenuItem IconMinimizarVendedor;
        private FontAwesome.Sharp.IconMenuItem MenuClientesVendedor;
        private FontAwesome.Sharp.IconMenuItem MenuVentasVendedor;
        private FontAwesome.Sharp.IconMenuItem SubmenuRegistrarVentasVendedor;
        private FontAwesome.Sharp.IconMenuItem SubmenuDetalleVentasVendedor;
        private FontAwesome.Sharp.IconMenuItem MenuProductoVendedor;
        public System.Windows.Forms.MenuStrip menuVendedor;
        public System.Windows.Forms.MenuStrip menuTituloVendedor;
        public System.Windows.Forms.Panel contenedorVendedor;
    }
}