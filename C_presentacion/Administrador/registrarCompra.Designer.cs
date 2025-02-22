namespace FankyRecords.C_presentacion.Administrador
{
    partial class registrarCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contenedorRegistrarCompra = new System.Windows.Forms.Panel();
            this.LRegistrarCompra = new System.Windows.Forms.Label();
            this.contenedorBotones = new System.Windows.Forms.Panel();
            this.btnRegistrarCompra = new FontAwesome.Sharp.IconButton();
            this.TBtotalPagar = new System.Windows.Forms.TextBox();
            this.LTotalPagar = new System.Windows.Forms.Label();
            this.listaCompras = new System.Windows.Forms.DataGridView();
            this.ID_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contenedorDatos = new System.Windows.Forms.Panel();
            this.gbInfoProducto = new System.Windows.Forms.GroupBox();
            this.TBIdProducto = new System.Windows.Forms.TextBox();
            this.TBPrecio_Venta = new System.Windows.Forms.TextBox();
            this.LPrecio_Venta = new System.Windows.Forms.Label();
            this.TBCodProd = new System.Windows.Forms.TextBox();
            this.LCodigo = new System.Windows.Forms.Label();
            this.btnAgregarProd = new FontAwesome.Sharp.IconButton();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.cantProd = new System.Windows.Forms.NumericUpDown();
            this.LCantidad = new System.Windows.Forms.Label();
            this.LPrecioCompra = new System.Windows.Forms.Label();
            this.TBprecio_compra = new System.Windows.Forms.TextBox();
            this.TBproducto = new System.Windows.Forms.TextBox();
            this.LProducto = new System.Windows.Forms.Label();
            this.gbInfoProveedor = new System.Windows.Forms.GroupBox();
            this.TBIdProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.TBrazonSocial = new System.Windows.Forms.TextBox();
            this.TBcuit = new System.Windows.Forms.TextBox();
            this.LRazonSocial = new System.Windows.Forms.Label();
            this.LCuit = new System.Windows.Forms.Label();
            this.gbInfoCompra = new System.Windows.Forms.GroupBox();
            this.TBNumFactura = new System.Windows.Forms.TextBox();
            this.dtFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.LNum_factura = new System.Windows.Forms.Label();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.LTipoDoc = new System.Windows.Forms.Label();
            this.LFechaCompra = new System.Windows.Forms.Label();
            this.registrarCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contenedorRegistrarCompra.SuspendLayout();
            this.contenedorBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCompras)).BeginInit();
            this.contenedorDatos.SuspendLayout();
            this.gbInfoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantProd)).BeginInit();
            this.gbInfoProveedor.SuspendLayout();
            this.gbInfoCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrarCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedorRegistrarCompra
            // 
            this.contenedorRegistrarCompra.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorRegistrarCompra.Controls.Add(this.LRegistrarCompra);
            this.contenedorRegistrarCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorRegistrarCompra.Location = new System.Drawing.Point(0, 0);
            this.contenedorRegistrarCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorRegistrarCompra.Name = "contenedorRegistrarCompra";
            this.contenedorRegistrarCompra.Size = new System.Drawing.Size(1182, 62);
            this.contenedorRegistrarCompra.TabIndex = 0;
            // 
            // LRegistrarCompra
            // 
            this.LRegistrarCompra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LRegistrarCompra.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistrarCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.LRegistrarCompra.Location = new System.Drawing.Point(0, 0);
            this.LRegistrarCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LRegistrarCompra.Name = "LRegistrarCompra";
            this.LRegistrarCompra.Size = new System.Drawing.Size(297, 62);
            this.LRegistrarCompra.TabIndex = 0;
            this.LRegistrarCompra.Text = "Registrar Compra";
            this.LRegistrarCompra.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // contenedorBotones
            // 
            this.contenedorBotones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorBotones.Controls.Add(this.btnRegistrarCompra);
            this.contenedorBotones.Controls.Add(this.TBtotalPagar);
            this.contenedorBotones.Controls.Add(this.LTotalPagar);
            this.contenedorBotones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contenedorBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.contenedorBotones.Location = new System.Drawing.Point(988, 62);
            this.contenedorBotones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorBotones.Name = "contenedorBotones";
            this.contenedorBotones.Size = new System.Drawing.Size(194, 592);
            this.contenedorBotones.TabIndex = 1;
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarCompra.BackColor = System.Drawing.Color.White;
            this.btnRegistrarCompra.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnRegistrarCompra.IconColor = System.Drawing.Color.DarkRed;
            this.btnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarCompra.IconSize = 25;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(32, 325);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(129, 58);
            this.btnRegistrarCompra.TabIndex = 3;
            this.btnRegistrarCompra.Text = "Registrar";
            this.btnRegistrarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegistrarCompra.UseVisualStyleBackColor = false;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.registrarCompra_Click);
            // 
            // TBtotalPagar
            // 
            this.TBtotalPagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBtotalPagar.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtotalPagar.Location = new System.Drawing.Point(32, 203);
            this.TBtotalPagar.Name = "TBtotalPagar";
            this.TBtotalPagar.ReadOnly = true;
            this.TBtotalPagar.Size = new System.Drawing.Size(129, 29);
            this.TBtotalPagar.TabIndex = 2;
            // 
            // LTotalPagar
            // 
            this.LTotalPagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LTotalPagar.AutoSize = true;
            this.LTotalPagar.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalPagar.ForeColor = System.Drawing.Color.DarkRed;
            this.LTotalPagar.Location = new System.Drawing.Point(32, 169);
            this.LTotalPagar.Name = "LTotalPagar";
            this.LTotalPagar.Size = new System.Drawing.Size(141, 21);
            this.LTotalPagar.TabIndex = 1;
            this.LTotalPagar.Text = "Total a Pagar:";
            // 
            // listaCompras
            // 
            this.listaCompras.AllowUserToAddRows = false;
            this.listaCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaCompras.BackgroundColor = System.Drawing.Color.White;
            this.listaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_producto,
            this.Codigo,
            this.Productos,
            this.Precio_Compra,
            this.Precio_Venta,
            this.Cantidad,
            this.Fecha_compra,
            this.Subtotal,
            this.BtnEliminar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaCompras.DefaultCellStyle = dataGridViewCellStyle4;
            this.listaCompras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaCompras.Location = new System.Drawing.Point(0, 445);
            this.listaCompras.Name = "listaCompras";
            this.listaCompras.ReadOnly = true;
            this.listaCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listaCompras.RowHeadersWidth = 51;
            this.listaCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaCompras.Size = new System.Drawing.Size(988, 209);
            this.listaCompras.TabIndex = 2;
            this.listaCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaCompras_CellContentClick);
            this.listaCompras.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.listaCompras_CellPainting);
            // 
            // ID_producto
            // 
            this.ID_producto.HeaderText = "ID_producto";
            this.ID_producto.MinimumWidth = 6;
            this.ID_producto.Name = "ID_producto";
            this.ID_producto.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Productos
            // 
            this.Productos.HeaderText = "Producto";
            this.Productos.MinimumWidth = 6;
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            // 
            // Precio_Compra
            // 
            this.Precio_Compra.HeaderText = "Precio Compra";
            this.Precio_Compra.MinimumWidth = 6;
            this.Precio_Compra.Name = "Precio_Compra";
            this.Precio_Compra.ReadOnly = true;
            // 
            // Precio_Venta
            // 
            this.Precio_Venta.HeaderText = "Precio Venta";
            this.Precio_Venta.MinimumWidth = 6;
            this.Precio_Venta.Name = "Precio_Venta";
            this.Precio_Venta.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Fecha_compra
            // 
            this.Fecha_compra.HeaderText = "Fecha Compra";
            this.Fecha_compra.MinimumWidth = 6;
            this.Fecha_compra.Name = "Fecha_compra";
            this.Fecha_compra.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FillWeight = 50F;
            this.BtnEliminar.HeaderText = "";
            this.BtnEliminar.MinimumWidth = 6;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.ReadOnly = true;
            this.BtnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // contenedorDatos
            // 
            this.contenedorDatos.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDatos.Controls.Add(this.gbInfoProducto);
            this.contenedorDatos.Controls.Add(this.gbInfoProveedor);
            this.contenedorDatos.Controls.Add(this.gbInfoCompra);
            this.contenedorDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorDatos.Location = new System.Drawing.Point(0, 62);
            this.contenedorDatos.Name = "contenedorDatos";
            this.contenedorDatos.Size = new System.Drawing.Size(988, 383);
            this.contenedorDatos.TabIndex = 3;
            // 
            // gbInfoProducto
            // 
            this.gbInfoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInfoProducto.Controls.Add(this.TBIdProducto);
            this.gbInfoProducto.Controls.Add(this.TBPrecio_Venta);
            this.gbInfoProducto.Controls.Add(this.LPrecio_Venta);
            this.gbInfoProducto.Controls.Add(this.TBCodProd);
            this.gbInfoProducto.Controls.Add(this.LCodigo);
            this.gbInfoProducto.Controls.Add(this.btnAgregarProd);
            this.gbInfoProducto.Controls.Add(this.btnBuscarProducto);
            this.gbInfoProducto.Controls.Add(this.cantProd);
            this.gbInfoProducto.Controls.Add(this.LCantidad);
            this.gbInfoProducto.Controls.Add(this.LPrecioCompra);
            this.gbInfoProducto.Controls.Add(this.TBprecio_compra);
            this.gbInfoProducto.Controls.Add(this.TBproducto);
            this.gbInfoProducto.Controls.Add(this.LProducto);
            this.gbInfoProducto.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProducto.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInfoProducto.Location = new System.Drawing.Point(17, 203);
            this.gbInfoProducto.Name = "gbInfoProducto";
            this.gbInfoProducto.Size = new System.Drawing.Size(963, 144);
            this.gbInfoProducto.TabIndex = 5;
            this.gbInfoProducto.TabStop = false;
            this.gbInfoProducto.Text = "Información de Producto";
            // 
            // TBIdProducto
            // 
            this.TBIdProducto.Location = new System.Drawing.Point(109, 50);
            this.TBIdProducto.Name = "TBIdProducto";
            this.TBIdProducto.ReadOnly = true;
            this.TBIdProducto.Size = new System.Drawing.Size(38, 29);
            this.TBIdProducto.TabIndex = 33;
            this.TBIdProducto.Visible = false;
            // 
            // TBPrecio_Venta
            // 
            this.TBPrecio_Venta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBPrecio_Venta.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecio_Venta.Location = new System.Drawing.Point(402, 87);
            this.TBPrecio_Venta.Margin = new System.Windows.Forms.Padding(4);
            this.TBPrecio_Venta.MaxLength = 6;
            this.TBPrecio_Venta.Name = "TBPrecio_Venta";
            this.TBPrecio_Venta.ReadOnly = true;
            this.TBPrecio_Venta.ShortcutsEnabled = false;
            this.TBPrecio_Venta.Size = new System.Drawing.Size(138, 28);
            this.TBPrecio_Venta.TabIndex = 32;
            // 
            // LPrecio_Venta
            // 
            this.LPrecio_Venta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LPrecio_Venta.AutoSize = true;
            this.LPrecio_Venta.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio_Venta.Location = new System.Drawing.Point(402, 57);
            this.LPrecio_Venta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LPrecio_Venta.Name = "LPrecio_Venta";
            this.LPrecio_Venta.Size = new System.Drawing.Size(129, 21);
            this.LPrecio_Venta.TabIndex = 31;
            this.LPrecio_Venta.Text = "Precio Venta:";
            // 
            // TBCodProd
            // 
            this.TBCodProd.Location = new System.Drawing.Point(27, 87);
            this.TBCodProd.Name = "TBCodProd";
            this.TBCodProd.ReadOnly = true;
            this.TBCodProd.Size = new System.Drawing.Size(120, 29);
            this.TBCodProd.TabIndex = 30;
            // 
            // LCodigo
            // 
            this.LCodigo.AutoSize = true;
            this.LCodigo.Location = new System.Drawing.Point(27, 57);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(81, 21);
            this.LCodigo.TabIndex = 29;
            this.LCodigo.Text = "Código:";
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarProd.BackColor = System.Drawing.Color.White;
            this.btnAgregarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarProd.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAgregarProd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarProd.IconColor = System.Drawing.Color.DarkRed;
            this.btnAgregarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProd.IconSize = 25;
            this.btnAgregarProd.Location = new System.Drawing.Point(839, 57);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(94, 58);
            this.btnAgregarProd.TabIndex = 0;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            this.btnAgregarProd.Click += new System.EventHandler(this.BAgregarProd_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 18;
            this.btnBuscarProducto.Location = new System.Drawing.Point(154, 87);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(46, 28);
            this.btnBuscarProducto.TabIndex = 27;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // cantProd
            // 
            this.cantProd.Location = new System.Drawing.Point(716, 87);
            this.cantProd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantProd.Name = "cantProd";
            this.cantProd.Size = new System.Drawing.Size(95, 29);
            this.cantProd.TabIndex = 11;
            this.cantProd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(716, 57);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(102, 21);
            this.LCantidad.TabIndex = 10;
            this.LCantidad.Text = "Cantidad:";
            // 
            // LPrecioCompra
            // 
            this.LPrecioCompra.AutoSize = true;
            this.LPrecioCompra.Location = new System.Drawing.Point(556, 57);
            this.LPrecioCompra.Name = "LPrecioCompra";
            this.LPrecioCompra.Size = new System.Drawing.Size(155, 21);
            this.LPrecioCompra.TabIndex = 9;
            this.LPrecioCompra.Text = "Precio Compra:";
            // 
            // TBprecio_compra
            // 
            this.TBprecio_compra.Location = new System.Drawing.Point(556, 87);
            this.TBprecio_compra.Name = "TBprecio_compra";
            this.TBprecio_compra.ShortcutsEnabled = false;
            this.TBprecio_compra.Size = new System.Drawing.Size(145, 29);
            this.TBprecio_compra.TabIndex = 8;
            this.TBprecio_compra.TextChanged += new System.EventHandler(this.TBprecio_compra_TextChanged);
            this.TBprecio_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // TBproducto
            // 
            this.TBproducto.Location = new System.Drawing.Point(212, 87);
            this.TBproducto.Name = "TBproducto";
            this.TBproducto.ReadOnly = true;
            this.TBproducto.Size = new System.Drawing.Size(178, 29);
            this.TBproducto.TabIndex = 7;
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Location = new System.Drawing.Point(212, 57);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(102, 21);
            this.LProducto.TabIndex = 6;
            this.LProducto.Text = "Producto:";
            // 
            // gbInfoProveedor
            // 
            this.gbInfoProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInfoProveedor.Controls.Add(this.TBIdProveedor);
            this.gbInfoProveedor.Controls.Add(this.btnBuscarProveedor);
            this.gbInfoProveedor.Controls.Add(this.TBrazonSocial);
            this.gbInfoProveedor.Controls.Add(this.TBcuit);
            this.gbInfoProveedor.Controls.Add(this.LRazonSocial);
            this.gbInfoProveedor.Controls.Add(this.LCuit);
            this.gbInfoProveedor.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProveedor.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInfoProveedor.Location = new System.Drawing.Point(516, 34);
            this.gbInfoProveedor.Name = "gbInfoProveedor";
            this.gbInfoProveedor.Size = new System.Drawing.Size(464, 144);
            this.gbInfoProveedor.TabIndex = 4;
            this.gbInfoProveedor.TabStop = false;
            this.gbInfoProveedor.Text = "Información Proveedor";
            // 
            // TBIdProveedor
            // 
            this.TBIdProveedor.Location = new System.Drawing.Point(142, 40);
            this.TBIdProveedor.Name = "TBIdProveedor";
            this.TBIdProveedor.ReadOnly = true;
            this.TBIdProveedor.Size = new System.Drawing.Size(38, 29);
            this.TBIdProveedor.TabIndex = 34;
            this.TBIdProveedor.Visible = false;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProveedor.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProveedor.IconSize = 18;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(185, 74);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(46, 28);
            this.btnBuscarProveedor.TabIndex = 4;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // TBrazonSocial
            // 
            this.TBrazonSocial.Location = new System.Drawing.Point(253, 74);
            this.TBrazonSocial.Name = "TBrazonSocial";
            this.TBrazonSocial.ReadOnly = true;
            this.TBrazonSocial.Size = new System.Drawing.Size(164, 29);
            this.TBrazonSocial.TabIndex = 3;
            // 
            // TBcuit
            // 
            this.TBcuit.Location = new System.Drawing.Point(20, 74);
            this.TBcuit.MaxLength = 11;
            this.TBcuit.Name = "TBcuit";
            this.TBcuit.ReadOnly = true;
            this.TBcuit.ShortcutsEnabled = false;
            this.TBcuit.Size = new System.Drawing.Size(160, 29);
            this.TBcuit.TabIndex = 2;
            this.TBcuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LRazonSocial
            // 
            this.LRazonSocial.AutoSize = true;
            this.LRazonSocial.Location = new System.Drawing.Point(253, 47);
            this.LRazonSocial.Name = "LRazonSocial";
            this.LRazonSocial.Size = new System.Drawing.Size(136, 21);
            this.LRazonSocial.TabIndex = 1;
            this.LRazonSocial.Text = "Razón Social:";
            // 
            // LCuit
            // 
            this.LCuit.AutoSize = true;
            this.LCuit.Location = new System.Drawing.Point(20, 47);
            this.LCuit.Name = "LCuit";
            this.LCuit.Size = new System.Drawing.Size(56, 21);
            this.LCuit.TabIndex = 0;
            this.LCuit.Text = "Cuit:";
            // 
            // gbInfoCompra
            // 
            this.gbInfoCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInfoCompra.Controls.Add(this.TBNumFactura);
            this.gbInfoCompra.Controls.Add(this.dtFechaCompra);
            this.gbInfoCompra.Controls.Add(this.LNum_factura);
            this.gbInfoCompra.Controls.Add(this.cbTipoDoc);
            this.gbInfoCompra.Controls.Add(this.LTipoDoc);
            this.gbInfoCompra.Controls.Add(this.LFechaCompra);
            this.gbInfoCompra.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInfoCompra.Location = new System.Drawing.Point(17, 34);
            this.gbInfoCompra.Name = "gbInfoCompra";
            this.gbInfoCompra.Size = new System.Drawing.Size(464, 144);
            this.gbInfoCompra.TabIndex = 3;
            this.gbInfoCompra.TabStop = false;
            this.gbInfoCompra.Text = "Información Compra";
            // 
            // TBNumFactura
            // 
            this.TBNumFactura.Location = new System.Drawing.Point(225, 107);
            this.TBNumFactura.Name = "TBNumFactura";
            this.TBNumFactura.ShortcutsEnabled = false;
            this.TBNumFactura.Size = new System.Drawing.Size(164, 29);
            this.TBNumFactura.TabIndex = 6;
            this.TBNumFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // dtFechaCompra
            // 
            this.dtFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaCompra.Location = new System.Drawing.Point(29, 74);
            this.dtFechaCompra.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtFechaCompra.MinDate = new System.DateTime(2025, 2, 22, 0, 0, 0, 0);
            this.dtFechaCompra.Name = "dtFechaCompra";
            this.dtFechaCompra.Size = new System.Drawing.Size(160, 29);
            this.dtFechaCompra.TabIndex = 6;
            this.dtFechaCompra.Value = new System.DateTime(2025, 2, 22, 0, 0, 0, 0);
            // 
            // LNum_factura
            // 
            this.LNum_factura.AutoSize = true;
            this.LNum_factura.Location = new System.Drawing.Point(225, 80);
            this.LNum_factura.Name = "LNum_factura";
            this.LNum_factura.Size = new System.Drawing.Size(168, 21);
            this.LNum_factura.TabIndex = 5;
            this.LNum_factura.Text = "Número Factura:";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.ItemHeight = 21;
            this.cbTipoDoc.Location = new System.Drawing.Point(225, 44);
            this.cbTipoDoc.MaxLength = 100;
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(160, 29);
            this.cbTipoDoc.TabIndex = 3;
            // 
            // LTipoDoc
            // 
            this.LTipoDoc.AutoSize = true;
            this.LTipoDoc.Location = new System.Drawing.Point(225, 18);
            this.LTipoDoc.Name = "LTipoDoc";
            this.LTipoDoc.Size = new System.Drawing.Size(169, 21);
            this.LTipoDoc.TabIndex = 1;
            this.LTipoDoc.Text = "Tipo Documento:";
            // 
            // LFechaCompra
            // 
            this.LFechaCompra.AutoSize = true;
            this.LFechaCompra.Location = new System.Drawing.Point(29, 47);
            this.LFechaCompra.Name = "LFechaCompra";
            this.LFechaCompra.Size = new System.Drawing.Size(71, 21);
            this.LFechaCompra.TabIndex = 0;
            this.LFechaCompra.Text = "Fecha:";
            // 
            // registrarCompraBindingSource
            // 
            this.registrarCompraBindingSource.DataSource = typeof(FankyRecords.C_presentacion.Administrador.registrarCompra);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataSource = typeof(FankyRecords.C_entidad.Productos);
            // 
            // registrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.contenedorDatos);
            this.Controls.Add(this.listaCompras);
            this.Controls.Add(this.contenedorBotones);
            this.Controls.Add(this.contenedorRegistrarCompra);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "registrarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "++";
            this.Load += new System.EventHandler(this.registrarCompra_Load);
            this.contenedorRegistrarCompra.ResumeLayout(false);
            this.contenedorBotones.ResumeLayout(false);
            this.contenedorBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCompras)).EndInit();
            this.contenedorDatos.ResumeLayout(false);
            this.gbInfoProducto.ResumeLayout(false);
            this.gbInfoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantProd)).EndInit();
            this.gbInfoProveedor.ResumeLayout(false);
            this.gbInfoProveedor.PerformLayout();
            this.gbInfoCompra.ResumeLayout(false);
            this.gbInfoCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrarCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedorRegistrarCompra;
        private System.Windows.Forms.Panel contenedorBotones;
        private System.Windows.Forms.Label LRegistrarCompra;
        private System.Windows.Forms.DataGridView listaCompras;
        private System.Windows.Forms.Panel contenedorDatos;
        private FontAwesome.Sharp.IconButton btnAgregarProd;
        private System.Windows.Forms.GroupBox gbInfoCompra;
        private System.Windows.Forms.Label LTipoDoc;
        private System.Windows.Forms.Label LFechaCompra;
        private System.Windows.Forms.GroupBox gbInfoProveedor;
        private System.Windows.Forms.ComboBox cbTipoDoc;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private System.Windows.Forms.TextBox TBrazonSocial;
        private System.Windows.Forms.TextBox TBcuit;
        private System.Windows.Forms.Label LRazonSocial;
        private System.Windows.Forms.Label LCuit;
        private FontAwesome.Sharp.IconButton btnRegistrarCompra;
        private System.Windows.Forms.TextBox TBtotalPagar;
        private System.Windows.Forms.Label LTotalPagar;
        private System.Windows.Forms.GroupBox gbInfoProducto;
        private System.Windows.Forms.NumericUpDown cantProd;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label LPrecioCompra;
        private System.Windows.Forms.TextBox TBprecio_compra;
        private System.Windows.Forms.TextBox TBproducto;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.DateTimePicker dtFechaCompra;
        public FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.TextBox TBCodProd;
        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.TextBox TBNumFactura;
        private System.Windows.Forms.Label LNum_factura;
        public System.Windows.Forms.TextBox TBPrecio_Venta;
        public System.Windows.Forms.Label LPrecio_Venta;
        private System.Windows.Forms.BindingSource registrarCompraBindingSource;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
        private System.Windows.Forms.TextBox TBIdProducto;
        private System.Windows.Forms.TextBox TBIdProveedor;
    }
}