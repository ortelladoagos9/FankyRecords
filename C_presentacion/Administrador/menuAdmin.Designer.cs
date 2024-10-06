namespace FankyRecords.C_presentacion.Administrador
{
    partial class FormMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAdmin));
            this.menuAdministrador = new System.Windows.Forms.MenuStrip();
            this.MenuUsuariosAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.MenuProductoAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.MenuCategoriaAdministrativo = new FontAwesome.Sharp.IconMenuItem();
            this.MenuProveedorAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.MenuVentasAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuRegistrarVentasAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuDetalleVentasAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.MenuDevolucionAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.MenuComprasAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuRegistrarComprasAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuDetalleCompraAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.MenuNegocioAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReportesAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuReporteVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuReporteCompras = new FontAwesome.Sharp.IconMenuItem();
            this.MenuGraficosAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.MenuBackupAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.menuTituloAdministrador = new System.Windows.Forms.MenuStrip();
            this.IconSalirAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.IconExpandirAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.IconMinimizarAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.labFankyRecordsMenuAdministrador = new System.Windows.Forms.Label();
            this.labUsuarioRolAdministrador = new System.Windows.Forms.Label();
            this.labAdministrador = new System.Windows.Forms.Label();
            this.contenedorAdministrador = new System.Windows.Forms.Panel();
            this.picFankyRecordsAdministrador = new System.Windows.Forms.PictureBox();
            this.menuAdministrador.SuspendLayout();
            this.menuTituloAdministrador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFankyRecordsAdministrador)).BeginInit();
            this.SuspendLayout();
            // 
            // menuAdministrador
            // 
            this.menuAdministrador.AutoSize = false;
            this.menuAdministrador.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.menuAdministrador.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAdministrador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuariosAdministrador,
            this.MenuProductoAdministrador,
            this.MenuCategoriaAdministrativo,
            this.MenuProveedorAdministrador,
            this.MenuVentasAdministrador,
            this.MenuDevolucionAdministrador,
            this.MenuComprasAdministrador,
            this.MenuNegocioAdministrador,
            this.MenuReportesAdministrador,
            this.MenuGraficosAdministrador,
            this.MenuBackupAdministrador});
            this.menuAdministrador.Location = new System.Drawing.Point(0, 97);
            this.menuAdministrador.Name = "menuAdministrador";
            this.menuAdministrador.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuAdministrador.Size = new System.Drawing.Size(1200, 63);
            this.menuAdministrador.TabIndex = 0;
            this.menuAdministrador.Text = "menuStrip1";
            // 
            // MenuUsuariosAdministrador
            // 
            this.MenuUsuariosAdministrador.AutoSize = false;
            this.MenuUsuariosAdministrador.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.MenuUsuariosAdministrador.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuUsuariosAdministrador.ForeColor = System.Drawing.Color.DarkRed;
            this.MenuUsuariosAdministrador.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.MenuUsuariosAdministrador.IconColor = System.Drawing.Color.DarkRed;
            this.MenuUsuariosAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuariosAdministrador.IconSize = 45;
            this.MenuUsuariosAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuariosAdministrador.Name = "MenuUsuariosAdministrador";
            this.MenuUsuariosAdministrador.Size = new System.Drawing.Size(100, 59);
            this.MenuUsuariosAdministrador.Text = "Usuarios";
            this.MenuUsuariosAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUsuariosAdministrador.Click += new System.EventHandler(this.MenuUsuariosAdministrador_Click);
            // 
            // MenuProductoAdministrador
            // 
            this.MenuProductoAdministrador.AutoSize = false;
            this.MenuProductoAdministrador.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProductoAdministrador.ForeColor = System.Drawing.Color.DarkRed;
            this.MenuProductoAdministrador.IconChar = FontAwesome.Sharp.IconChar.CompactDisc;
            this.MenuProductoAdministrador.IconColor = System.Drawing.Color.DarkRed;
            this.MenuProductoAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProductoAdministrador.IconSize = 45;
            this.MenuProductoAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProductoAdministrador.Name = "MenuProductoAdministrador";
            this.MenuProductoAdministrador.Size = new System.Drawing.Size(100, 59);
            this.MenuProductoAdministrador.Text = "Productos";
            this.MenuProductoAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuProductoAdministrador.Click += new System.EventHandler(this.MenuProductoAdministrador_Click);
            // 
            // MenuCategoriaAdministrativo
            // 
            this.MenuCategoriaAdministrativo.AutoSize = false;
            this.MenuCategoriaAdministrativo.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCategoriaAdministrativo.ForeColor = System.Drawing.Color.DarkRed;
            this.MenuCategoriaAdministrativo.IconChar = FontAwesome.Sharp.IconChar.List;
            this.MenuCategoriaAdministrativo.IconColor = System.Drawing.Color.DarkRed;
            this.MenuCategoriaAdministrativo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCategoriaAdministrativo.IconSize = 45;
            this.MenuCategoriaAdministrativo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCategoriaAdministrativo.Name = "MenuCategoriaAdministrativo";
            this.MenuCategoriaAdministrativo.Size = new System.Drawing.Size(100, 59);
            this.MenuCategoriaAdministrativo.Text = "Categorias";
            this.MenuCategoriaAdministrativo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuCategoriaAdministrativo.Click += new System.EventHandler(this.MenuCategoriaAdministrativo_Click);
            // 
            // MenuProveedorAdministrador
            // 
            this.MenuProveedorAdministrador.AutoSize = false;
            this.MenuProveedorAdministrador.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProveedorAdministrador.ForeColor = System.Drawing.Color.DarkRed;
            this.MenuProveedorAdministrador.IconChar = FontAwesome.Sharp.IconChar.TruckField;
            this.MenuProveedorAdministrador.IconColor = System.Drawing.Color.DarkRed;
            this.MenuProveedorAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProveedorAdministrador.IconSize = 45;
            this.MenuProveedorAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProveedorAdministrador.Name = "MenuProveedorAdministrador";
            this.MenuProveedorAdministrador.Size = new System.Drawing.Size(100, 59);
            this.MenuProveedorAdministrador.Text = "Proveedores";
            this.MenuProveedorAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuProveedorAdministrador.Click += new System.EventHandler(this.MenuProveedorAdministrador_Click);
            // 
            // MenuVentasAdministrador
            // 
            this.MenuVentasAdministrador.AutoSize = false;
            this.MenuVentasAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuRegistrarVentasAdministrador,
            this.SubmenuDetalleVentasAdministrador});
            this.MenuVentasAdministrador.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuVentasAdministrador.ForeColor = System.Drawing.Color.DarkRed;
            this.MenuVentasAdministrador.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.MenuVentasAdministrador.IconColor = System.Drawing.Color.DarkRed;
            this.MenuVentasAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVentasAdministrador.IconSize = 45;
            this.MenuVentasAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentasAdministrador.Name = "MenuVentasAdministrador";
            this.MenuVentasAdministrador.Size = new System.Drawing.Size(100, 59);
            this.MenuVentasAdministrador.Text = "Ventas";
            this.MenuVentasAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubmenuRegistrarVentasAdministrador
            // 
            this.SubmenuRegistrarVentasAdministrador.AutoSize = false;
            this.SubmenuRegistrarVentasAdministrador.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.SubmenuRegistrarVentasAdministrador.ForeColor = System.Drawing.Color.DarkRed;
            this.SubmenuRegistrarVentasAdministrador.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.SubmenuRegistrarVentasAdministrador.IconColor = System.Drawing.Color.DarkRed;
            this.SubmenuRegistrarVentasAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuRegistrarVentasAdministrador.IconSize = 25;
            this.SubmenuRegistrarVentasAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SubmenuRegistrarVentasAdministrador.Name = "SubmenuRegistrarVentasAdministrador";
            this.SubmenuRegistrarVentasAdministrador.Size = new System.Drawing.Size(230, 35);
            this.SubmenuRegistrarVentasAdministrador.Text = "Registrar ventas";
            this.SubmenuRegistrarVentasAdministrador.Click += new System.EventHandler(this.SubmenuRegistrarVentasAdministrador_Click);
            // 
            // SubmenuDetalleVentasAdministrador
            // 
            this.SubmenuDetalleVentasAdministrador.AutoSize = false;
            this.SubmenuDetalleVentasAdministrador.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.SubmenuDetalleVentasAdministrador.ForeColor = System.Drawing.Color.DarkRed;
            this.SubmenuDetalleVentasAdministrador.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.SubmenuDetalleVentasAdministrador.IconColor = System.Drawing.Color.DarkRed;
            this.SubmenuDetalleVentasAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuDetalleVentasAdministrador.IconSize = 25;
            this.SubmenuDetalleVentasAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SubmenuDetalleVentasAdministrador.Name = "SubmenuDetalleVentasAdministrador";
            this.SubmenuDetalleVentasAdministrador.Size = new System.Drawing.Size(230, 35);
            this.SubmenuDetalleVentasAdministrador.Text = "Detalle de venta";
            this.SubmenuDetalleVentasAdministrador.Click += new System.EventHandler(this.SubmenuDetalleVentasAdministrador_Click);
            // 
            // MenuDevolucionAdministrador
            // 
            this.MenuDevolucionAdministrador.AutoSize = false;
            this.MenuDevolucionAdministrador.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuDevolucionAdministrador.ForeColor = System.Drawing.Color.DarkRed;
            this.MenuDevolucionAdministrador.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.MenuDevolucionAdministrador.IconColor = System.Drawing.Color.DarkRed;
            this.MenuDevolucionAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuDevolucionAdministrador.IconSize = 45;
            this.MenuDevolucionAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuDevolucionAdministrador.Name = "MenuDevolucionAdministrador";
            this.MenuDevolucionAdministrador.Size = new System.Drawing.Size(105, 59);
            this.MenuDevolucionAdministrador.Text = "Devoluciones";
            this.MenuDevolucionAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuDevolucionAdministrador.Click += new System.EventHandler(this.MenuDevolucionAdministrador_Click);
            // 
            // MenuComprasAdministrador
            // 
            this.MenuComprasAdministrador.AutoSize = false;
            this.MenuComprasAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuRegistrarComprasAdministrador,
            this.SubmenuDetalleCompraAdministrador});
            this.MenuComprasAdministrador.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuComprasAdministrador.ForeColor = System.Drawing.Color.DarkRed;
            this.MenuComprasAdministrador.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.MenuComprasAdministrador.IconColor = System.Drawing.Color.DarkRed;
            this.MenuComprasAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuComprasAdministrador.IconSize = 45;
            this.MenuComprasAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuComprasAdministrador.Name = "MenuComprasAdministrador";
            this.MenuComprasAdministrador.Size = new System.Drawing.Size(100, 59);
            this.MenuComprasAdministrador.Text = "Compras";
            this.MenuComprasAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubmenuRegistrarComprasAdministrador
            // 
            this.SubmenuRegistrarComprasAdministrador.AutoSize = false;
            this.SubmenuRegistrarComprasAdministrador.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.SubmenuRegistrarComprasAdministrador.ForeColor = System.Drawing.Color.DarkRed;
            this.SubmenuRegistrarComprasAdministrador.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.SubmenuRegistrarComprasAdministrador.IconColor = System.Drawing.Color.DarkRed;
            this.SubmenuRegistrarComprasAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuRegistrarComprasAdministrador.IconSize = 25;
            this.SubmenuRegistrarComprasAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SubmenuRegistrarComprasAdministrador.Name = "SubmenuRegistrarComprasAdministrador";
            this.SubmenuRegistrarComprasAdministrador.Size = new System.Drawing.Size(230, 35);
            this.SubmenuRegistrarComprasAdministrador.Text = "Registrar compras";
            this.SubmenuRegistrarComprasAdministrador.Click += new System.EventHandler(this.SubmenuRegistrarComprasAdministrador_Click);
            // 
            // SubmenuDetalleCompraAdministrador
            // 
            this.SubmenuDetalleCompraAdministrador.AutoSize = false;
            this.SubmenuDetalleCompraAdministrador.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.SubmenuDetalleCompraAdministrador.ForeColor = System.Drawing.Color.DarkRed;
            this.SubmenuDetalleCompraAdministrador.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.SubmenuDetalleCompraAdministrador.IconColor = System.Drawing.Color.DarkRed;
            this.SubmenuDetalleCompraAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuDetalleCompraAdministrador.IconSize = 25;
            this.SubmenuDetalleCompraAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SubmenuDetalleCompraAdministrador.Name = "SubmenuDetalleCompraAdministrador";
            this.SubmenuDetalleCompraAdministrador.Size = new System.Drawing.Size(230, 35);
            this.SubmenuDetalleCompraAdministrador.Text = "Detalle de compra";
            this.SubmenuDetalleCompraAdministrador.Click += new System.EventHandler(this.SubmenuDetalleCompraAdministrador_Click);
            // 
            // MenuNegocioAdministrador
            // 
            this.MenuNegocioAdministrador.AutoSize = false;
            this.MenuNegocioAdministrador.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuNegocioAdministrador.ForeColor = System.Drawing.Color.DarkRed;
            this.MenuNegocioAdministrador.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.MenuNegocioAdministrador.IconColor = System.Drawing.Color.DarkRed;
            this.MenuNegocioAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuNegocioAdministrador.IconSize = 45;
            this.MenuNegocioAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuNegocioAdministrador.Name = "MenuNegocioAdministrador";
            this.MenuNegocioAdministrador.Size = new System.Drawing.Size(100, 59);
            this.MenuNegocioAdministrador.Text = "Negocio";
            this.MenuNegocioAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuNegocioAdministrador.Visible = false;
            // 
            // MenuReportesAdministrador
            // 
            this.MenuReportesAdministrador.AutoSize = false;
            this.MenuReportesAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuReporteVentas,
            this.SubmenuReporteCompras});
            this.MenuReportesAdministrador.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuReportesAdministrador.ForeColor = System.Drawing.Color.DarkRed;
            this.MenuReportesAdministrador.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.MenuReportesAdministrador.IconColor = System.Drawing.Color.DarkRed;
            this.MenuReportesAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReportesAdministrador.IconSize = 45;
            this.MenuReportesAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportesAdministrador.Name = "MenuReportesAdministrador";
            this.MenuReportesAdministrador.Size = new System.Drawing.Size(100, 59);
            this.MenuReportesAdministrador.Text = "Reportes";
            this.MenuReportesAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubmenuReporteVentas
            // 
            this.SubmenuReporteVentas.AutoSize = false;
            this.SubmenuReporteVentas.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.SubmenuReporteVentas.ForeColor = System.Drawing.Color.DarkRed;
            this.SubmenuReporteVentas.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.SubmenuReporteVentas.IconColor = System.Drawing.Color.DarkRed;
            this.SubmenuReporteVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuReporteVentas.IconSize = 25;
            this.SubmenuReporteVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SubmenuReporteVentas.Name = "SubmenuReporteVentas";
            this.SubmenuReporteVentas.Size = new System.Drawing.Size(230, 35);
            this.SubmenuReporteVentas.Text = "Reporte Ventas";
            this.SubmenuReporteVentas.Click += new System.EventHandler(this.SubmenuReporteVentas_Click);
            // 
            // SubmenuReporteCompras
            // 
            this.SubmenuReporteCompras.AutoSize = false;
            this.SubmenuReporteCompras.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.SubmenuReporteCompras.ForeColor = System.Drawing.Color.DarkRed;
            this.SubmenuReporteCompras.IconChar = FontAwesome.Sharp.IconChar.ChartGantt;
            this.SubmenuReporteCompras.IconColor = System.Drawing.Color.DarkRed;
            this.SubmenuReporteCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuReporteCompras.IconSize = 25;
            this.SubmenuReporteCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SubmenuReporteCompras.Name = "SubmenuReporteCompras";
            this.SubmenuReporteCompras.Size = new System.Drawing.Size(230, 35);
            this.SubmenuReporteCompras.Text = "Reporte Compras";
            this.SubmenuReporteCompras.Click += new System.EventHandler(this.SubmenuReporteCompras_Click);
            // 
            // MenuGraficosAdministrador
            // 
            this.MenuGraficosAdministrador.AutoSize = false;
            this.MenuGraficosAdministrador.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.MenuGraficosAdministrador.ForeColor = System.Drawing.Color.DarkRed;
            this.MenuGraficosAdministrador.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            this.MenuGraficosAdministrador.IconColor = System.Drawing.Color.DarkRed;
            this.MenuGraficosAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuGraficosAdministrador.IconSize = 45;
            this.MenuGraficosAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuGraficosAdministrador.Name = "MenuGraficosAdministrador";
            this.MenuGraficosAdministrador.Size = new System.Drawing.Size(100, 59);
            this.MenuGraficosAdministrador.Text = "Gráficos";
            this.MenuGraficosAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuGraficosAdministrador.Visible = false;
            // 
            // MenuBackupAdministrador
            // 
            this.MenuBackupAdministrador.AutoSize = false;
            this.MenuBackupAdministrador.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.MenuBackupAdministrador.ForeColor = System.Drawing.Color.DarkRed;
            this.MenuBackupAdministrador.IconChar = FontAwesome.Sharp.IconChar.CloudUploadAlt;
            this.MenuBackupAdministrador.IconColor = System.Drawing.Color.DarkRed;
            this.MenuBackupAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuBackupAdministrador.IconSize = 45;
            this.MenuBackupAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuBackupAdministrador.Name = "MenuBackupAdministrador";
            this.MenuBackupAdministrador.Size = new System.Drawing.Size(100, 59);
            this.MenuBackupAdministrador.Text = "Backup";
            this.MenuBackupAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuBackupAdministrador.Click += new System.EventHandler(this.MenuBackupAdministrador_Click);
            // 
            // menuTituloAdministrador
            // 
            this.menuTituloAdministrador.AutoSize = false;
            this.menuTituloAdministrador.BackColor = System.Drawing.Color.DarkRed;
            this.menuTituloAdministrador.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTituloAdministrador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconSalirAdministrador,
            this.IconExpandirAdministrador,
            this.IconMinimizarAdministrador});
            this.menuTituloAdministrador.Location = new System.Drawing.Point(0, 0);
            this.menuTituloAdministrador.Name = "menuTituloAdministrador";
            this.menuTituloAdministrador.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuTituloAdministrador.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTituloAdministrador.Size = new System.Drawing.Size(1200, 97);
            this.menuTituloAdministrador.TabIndex = 1;
            // 
            // IconSalirAdministrador
            // 
            this.IconSalirAdministrador.AutoSize = false;
            this.IconSalirAdministrador.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.IconSalirAdministrador.IconColor = System.Drawing.Color.Gold;
            this.IconSalirAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconSalirAdministrador.IconSize = 30;
            this.IconSalirAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconSalirAdministrador.Name = "IconSalirAdministrador";
            this.IconSalirAdministrador.Size = new System.Drawing.Size(50, 93);
            this.IconSalirAdministrador.Click += new System.EventHandler(this.IconSalirAdministrador_Click);
            // 
            // IconExpandirAdministrador
            // 
            this.IconExpandirAdministrador.AutoSize = false;
            this.IconExpandirAdministrador.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.IconExpandirAdministrador.IconColor = System.Drawing.Color.Gold;
            this.IconExpandirAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconExpandirAdministrador.IconSize = 25;
            this.IconExpandirAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconExpandirAdministrador.Name = "IconExpandirAdministrador";
            this.IconExpandirAdministrador.Size = new System.Drawing.Size(50, 93);
            this.IconExpandirAdministrador.Click += new System.EventHandler(this.IconExpandirAdministrador_Click);
            // 
            // IconMinimizarAdministrador
            // 
            this.IconMinimizarAdministrador.AutoSize = false;
            this.IconMinimizarAdministrador.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.IconMinimizarAdministrador.IconColor = System.Drawing.Color.Gold;
            this.IconMinimizarAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconMinimizarAdministrador.IconSize = 30;
            this.IconMinimizarAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconMinimizarAdministrador.Name = "IconMinimizarAdministrador";
            this.IconMinimizarAdministrador.Size = new System.Drawing.Size(50, 93);
            this.IconMinimizarAdministrador.Click += new System.EventHandler(this.IconMinimizarAdministrador_Click);
            // 
            // labFankyRecordsMenuAdministrador
            // 
            this.labFankyRecordsMenuAdministrador.AutoSize = true;
            this.labFankyRecordsMenuAdministrador.BackColor = System.Drawing.Color.DarkRed;
            this.labFankyRecordsMenuAdministrador.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFankyRecordsMenuAdministrador.ForeColor = System.Drawing.Color.Gold;
            this.labFankyRecordsMenuAdministrador.Location = new System.Drawing.Point(102, 35);
            this.labFankyRecordsMenuAdministrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFankyRecordsMenuAdministrador.Name = "labFankyRecordsMenuAdministrador";
            this.labFankyRecordsMenuAdministrador.Size = new System.Drawing.Size(210, 29);
            this.labFankyRecordsMenuAdministrador.TabIndex = 2;
            this.labFankyRecordsMenuAdministrador.Text = "Fanky Records";
            // 
            // labUsuarioRolAdministrador
            // 
            this.labUsuarioRolAdministrador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labUsuarioRolAdministrador.BackColor = System.Drawing.Color.DarkRed;
            this.labUsuarioRolAdministrador.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsuarioRolAdministrador.ForeColor = System.Drawing.Color.Gold;
            this.labUsuarioRolAdministrador.Location = new System.Drawing.Point(795, 35);
            this.labUsuarioRolAdministrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUsuarioRolAdministrador.Name = "labUsuarioRolAdministrador";
            this.labUsuarioRolAdministrador.Size = new System.Drawing.Size(93, 24);
            this.labUsuarioRolAdministrador.TabIndex = 4;
            this.labUsuarioRolAdministrador.Text = "Usuario:";
            // 
            // labAdministrador
            // 
            this.labAdministrador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labAdministrador.BackColor = System.Drawing.Color.DarkRed;
            this.labAdministrador.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAdministrador.ForeColor = System.Drawing.Color.Gold;
            this.labAdministrador.Location = new System.Drawing.Point(879, 35);
            this.labAdministrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAdministrador.Name = "labAdministrador";
            this.labAdministrador.Size = new System.Drawing.Size(153, 24);
            this.labAdministrador.TabIndex = 5;
            this.labAdministrador.Text = "Administrador";
            // 
            // contenedorAdministrador
            // 
            this.contenedorAdministrador.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorAdministrador.BackgroundImage = global::FankyRecords.Properties.Resources.fondoFanky1;
            this.contenedorAdministrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.contenedorAdministrador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorAdministrador.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contenedorAdministrador.Location = new System.Drawing.Point(0, 160);
            this.contenedorAdministrador.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorAdministrador.Name = "contenedorAdministrador";
            this.contenedorAdministrador.Size = new System.Drawing.Size(1200, 652);
            this.contenedorAdministrador.TabIndex = 6;
            // 
            // picFankyRecordsAdministrador
            // 
            this.picFankyRecordsAdministrador.BackColor = System.Drawing.Color.DarkRed;
            this.picFankyRecordsAdministrador.Cursor = System.Windows.Forms.Cursors.Default;
            this.picFankyRecordsAdministrador.Image = global::FankyRecords.Properties.Resources.Fanky_records1;
            this.picFankyRecordsAdministrador.Location = new System.Drawing.Point(12, 12);
            this.picFankyRecordsAdministrador.Margin = new System.Windows.Forms.Padding(4);
            this.picFankyRecordsAdministrador.Name = "picFankyRecordsAdministrador";
            this.picFankyRecordsAdministrador.Size = new System.Drawing.Size(72, 72);
            this.picFankyRecordsAdministrador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFankyRecordsAdministrador.TabIndex = 3;
            this.picFankyRecordsAdministrador.TabStop = false;
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 812);
            this.Controls.Add(this.contenedorAdministrador);
            this.Controls.Add(this.labAdministrador);
            this.Controls.Add(this.labUsuarioRolAdministrador);
            this.Controls.Add(this.picFankyRecordsAdministrador);
            this.Controls.Add(this.labFankyRecordsMenuAdministrador);
            this.Controls.Add(this.menuAdministrador);
            this.Controls.Add(this.menuTituloAdministrador);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Administrador";
            this.menuAdministrador.ResumeLayout(false);
            this.menuAdministrador.PerformLayout();
            this.menuTituloAdministrador.ResumeLayout(false);
            this.menuTituloAdministrador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFankyRecordsAdministrador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAdministrador;
        private System.Windows.Forms.MenuStrip menuTituloAdministrador;
        private FontAwesome.Sharp.IconMenuItem MenuNegocioAdministrador;
        private System.Windows.Forms.Label labFankyRecordsMenuAdministrador;
        private System.Windows.Forms.PictureBox picFankyRecordsAdministrador;
        private FontAwesome.Sharp.IconMenuItem IconMinimizarAdministrador;
        private System.Windows.Forms.Label labUsuarioRolAdministrador;
        private FontAwesome.Sharp.IconMenuItem MenuUsuariosAdministrador;
        private FontAwesome.Sharp.IconMenuItem MenuProductoAdministrador;
        private FontAwesome.Sharp.IconMenuItem MenuProveedorAdministrador;
        private FontAwesome.Sharp.IconMenuItem MenuVentasAdministrador;
        private FontAwesome.Sharp.IconMenuItem MenuDevolucionAdministrador;
        private FontAwesome.Sharp.IconMenuItem MenuComprasAdministrador;
        private FontAwesome.Sharp.IconMenuItem MenuReportesAdministrador;
        private FontAwesome.Sharp.IconMenuItem MenuGraficosAdministrador;
        private FontAwesome.Sharp.IconMenuItem MenuBackupAdministrador;
        private System.Windows.Forms.Label labAdministrador;
        private FontAwesome.Sharp.IconMenuItem SubmenuRegistrarVentasAdministrador;
        private FontAwesome.Sharp.IconMenuItem SubmenuDetalleVentasAdministrador;
        private FontAwesome.Sharp.IconMenuItem SubmenuRegistrarComprasAdministrador;
        private FontAwesome.Sharp.IconMenuItem SubmenuDetalleCompraAdministrador;
        private FontAwesome.Sharp.IconMenuItem IconSalirAdministrador;
        private FontAwesome.Sharp.IconMenuItem IconExpandirAdministrador;
        public System.Windows.Forms.Panel contenedorAdministrador;
        private FontAwesome.Sharp.IconMenuItem SubmenuReporteVentas;
        private FontAwesome.Sharp.IconMenuItem SubmenuReporteCompras;
        private FontAwesome.Sharp.IconMenuItem MenuCategoriaAdministrativo;
    }
}