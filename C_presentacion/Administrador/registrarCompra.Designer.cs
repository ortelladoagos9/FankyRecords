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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contenedorRegistrarCompra = new System.Windows.Forms.Panel();
            this.LRegistrarCompra = new System.Windows.Forms.Label();
            this.contenedorBotones = new System.Windows.Forms.Panel();
            this.btnRegistrarCompra = new FontAwesome.Sharp.IconButton();
            this.TBtotalPagar = new System.Windows.Forms.TextBox();
            this.LTotalPagar = new System.Windows.Forms.Label();
            this.listaCompras = new System.Windows.Forms.DataGridView();
            this.ID_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID_compras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenedorDatos = new System.Windows.Forms.Panel();
            this.gbInfoProducto = new System.Windows.Forms.GroupBox();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.LDescripcion = new System.Windows.Forms.Label();
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
            this.contenedorRegistrarCompra.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.contenedorRegistrarCompra.Name = "contenedorRegistrarCompra";
            this.contenedorRegistrarCompra.Size = new System.Drawing.Size(1418, 69);
            this.contenedorRegistrarCompra.TabIndex = 0;
            // 
            // LRegistrarCompra
            // 
            this.LRegistrarCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LRegistrarCompra.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistrarCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.LRegistrarCompra.Location = new System.Drawing.Point(0, 0);
            this.LRegistrarCompra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LRegistrarCompra.Name = "LRegistrarCompra";
            this.LRegistrarCompra.Size = new System.Drawing.Size(1418, 69);
            this.LRegistrarCompra.TabIndex = 0;
            this.LRegistrarCompra.Text = "Registrar Compra";
            this.LRegistrarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contenedorBotones
            // 
            this.contenedorBotones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorBotones.Controls.Add(this.btnRegistrarCompra);
            this.contenedorBotones.Controls.Add(this.TBtotalPagar);
            this.contenedorBotones.Controls.Add(this.LTotalPagar);
            this.contenedorBotones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contenedorBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.contenedorBotones.Location = new System.Drawing.Point(1163, 69);
            this.contenedorBotones.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.contenedorBotones.Name = "contenedorBotones";
            this.contenedorBotones.Size = new System.Drawing.Size(255, 670);
            this.contenedorBotones.TabIndex = 1;
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRegistrarCompra.BackColor = System.Drawing.Color.White;
            this.btnRegistrarCompra.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnRegistrarCompra.IconColor = System.Drawing.Color.DarkRed;
            this.btnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarCompra.IconSize = 25;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(23, 322);
            this.btnRegistrarCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(184, 70);
            this.btnRegistrarCompra.TabIndex = 3;
            this.btnRegistrarCompra.Text = "Registrar";
            this.btnRegistrarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegistrarCompra.UseVisualStyleBackColor = false;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.registrarCompra_Click);
            // 
            // TBtotalPagar
            // 
            this.TBtotalPagar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TBtotalPagar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtotalPagar.Location = new System.Drawing.Point(23, 198);
            this.TBtotalPagar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBtotalPagar.Name = "TBtotalPagar";
            this.TBtotalPagar.ReadOnly = true;
            this.TBtotalPagar.Size = new System.Drawing.Size(184, 35);
            this.TBtotalPagar.TabIndex = 2;
            // 
            // LTotalPagar
            // 
            this.LTotalPagar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LTotalPagar.AutoSize = true;
            this.LTotalPagar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalPagar.ForeColor = System.Drawing.Color.DarkRed;
            this.LTotalPagar.Location = new System.Drawing.Point(23, 160);
            this.LTotalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTotalPagar.Name = "LTotalPagar";
            this.LTotalPagar.Size = new System.Drawing.Size(184, 27);
            this.LTotalPagar.TabIndex = 1;
            this.LTotalPagar.Text = "Importe Total:";
            // 
            // listaCompras
            // 
            this.listaCompras.AllowUserToAddRows = false;
            this.listaCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaCompras.BackgroundColor = System.Drawing.Color.White;
            this.listaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_producto,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Precio_Compra,
            this.Precio_Venta,
            this.Cantidad,
            this.Fecha_compra,
            this.Subtotal,
            this.BtnEliminar,
            this.ID_compras});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaCompras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaCompras.Location = new System.Drawing.Point(0, 508);
            this.listaCompras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listaCompras.Name = "listaCompras";
            this.listaCompras.ReadOnly = true;
            this.listaCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listaCompras.RowHeadersWidth = 51;
            this.listaCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaCompras.Size = new System.Drawing.Size(1163, 231);
            this.listaCompras.TabIndex = 2;
            this.listaCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaCompras_CellContentClick);
            this.listaCompras.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.listaCompras_CellPainting);
            // 
            // ID_producto
            // 
            this.ID_producto.HeaderText = "ID producto";
            this.ID_producto.MinimumWidth = 6;
            this.ID_producto.Name = "ID_producto";
            this.ID_producto.ReadOnly = true;
            this.ID_producto.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
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
            // ID_compras
            // 
            this.ID_compras.HeaderText = "ID_compras";
            this.ID_compras.MinimumWidth = 6;
            this.ID_compras.Name = "ID_compras";
            this.ID_compras.ReadOnly = true;
            this.ID_compras.Visible = false;
            // 
            // contenedorDatos
            // 
            this.contenedorDatos.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDatos.Controls.Add(this.gbInfoProducto);
            this.contenedorDatos.Controls.Add(this.gbInfoProveedor);
            this.contenedorDatos.Controls.Add(this.gbInfoCompra);
            this.contenedorDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorDatos.Location = new System.Drawing.Point(0, 69);
            this.contenedorDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorDatos.Name = "contenedorDatos";
            this.contenedorDatos.Size = new System.Drawing.Size(1163, 439);
            this.contenedorDatos.TabIndex = 3;
            // 
            // gbInfoProducto
            // 
            this.gbInfoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfoProducto.Controls.Add(this.TBDescripcion);
            this.gbInfoProducto.Controls.Add(this.LDescripcion);
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
            this.gbInfoProducto.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProducto.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInfoProducto.Location = new System.Drawing.Point(13, 222);
            this.gbInfoProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInfoProducto.Name = "gbInfoProducto";
            this.gbInfoProducto.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInfoProducto.Size = new System.Drawing.Size(1131, 183);
            this.gbInfoProducto.TabIndex = 5;
            this.gbInfoProducto.TabStop = false;
            this.gbInfoProducto.Text = "Información de Producto";
            this.gbInfoProducto.Enter += new System.EventHandler(this.gbInfoProducto_Enter);
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBDescripcion.Location = new System.Drawing.Point(436, 100);
            this.TBDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.ReadOnly = true;
            this.TBDescripcion.Size = new System.Drawing.Size(188, 35);
            this.TBDescripcion.TabIndex = 35;
            // 
            // LDescripcion
            // 
            this.LDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Location = new System.Drawing.Point(436, 66);
            this.LDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(163, 27);
            this.LDescripcion.TabIndex = 34;
            this.LDescripcion.Text = "Descripción:";
            // 
            // TBIdProducto
            // 
            this.TBIdProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBIdProducto.Location = new System.Drawing.Point(124, 58);
            this.TBIdProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBIdProducto.Name = "TBIdProducto";
            this.TBIdProducto.ReadOnly = true;
            this.TBIdProducto.Size = new System.Drawing.Size(45, 35);
            this.TBIdProducto.TabIndex = 33;
            this.TBIdProducto.Visible = false;
            // 
            // TBPrecio_Venta
            // 
            this.TBPrecio_Venta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBPrecio_Venta.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecio_Venta.Location = new System.Drawing.Point(640, 58);
            this.TBPrecio_Venta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBPrecio_Venta.MaxLength = 6;
            this.TBPrecio_Venta.Name = "TBPrecio_Venta";
            this.TBPrecio_Venta.ReadOnly = true;
            this.TBPrecio_Venta.ShortcutsEnabled = false;
            this.TBPrecio_Venta.Size = new System.Drawing.Size(198, 35);
            this.TBPrecio_Venta.TabIndex = 32;
            // 
            // LPrecio_Venta
            // 
            this.LPrecio_Venta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LPrecio_Venta.AutoSize = true;
            this.LPrecio_Venta.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio_Venta.Location = new System.Drawing.Point(640, 24);
            this.LPrecio_Venta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LPrecio_Venta.Name = "LPrecio_Venta";
            this.LPrecio_Venta.Size = new System.Drawing.Size(173, 27);
            this.LPrecio_Venta.TabIndex = 31;
            this.LPrecio_Venta.Text = "Precio Venta:";
            // 
            // TBCodProd
            // 
            this.TBCodProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBCodProd.Location = new System.Drawing.Point(19, 100);
            this.TBCodProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBCodProd.Name = "TBCodProd";
            this.TBCodProd.ReadOnly = true;
            this.TBCodProd.Size = new System.Drawing.Size(150, 35);
            this.TBCodProd.TabIndex = 30;
            // 
            // LCodigo
            // 
            this.LCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LCodigo.AutoSize = true;
            this.LCodigo.Location = new System.Drawing.Point(19, 66);
            this.LCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(102, 27);
            this.LCodigo.TabIndex = 29;
            this.LCodigo.Text = "Código:";
            this.LCodigo.Click += new System.EventHandler(this.LCodigo_Click);
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarProd.BackColor = System.Drawing.Color.White;
            this.btnAgregarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarProd.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAgregarProd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarProd.IconColor = System.Drawing.Color.DarkRed;
            this.btnAgregarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProd.IconSize = 25;
            this.btnAgregarProd.Location = new System.Drawing.Point(1001, 67);
            this.btnAgregarProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(113, 68);
            this.btnAgregarProd.TabIndex = 0;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            this.btnAgregarProd.Click += new System.EventHandler(this.BAgregarProd_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarProducto.BackColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 20;
            this.btnBuscarProducto.Location = new System.Drawing.Point(178, 100);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(48, 35);
            this.btnBuscarProducto.TabIndex = 27;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // cantProd
            // 
            this.cantProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cantProd.Location = new System.Drawing.Point(855, 100);
            this.cantProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cantProd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantProd.Name = "cantProd";
            this.cantProd.Size = new System.Drawing.Size(129, 35);
            this.cantProd.TabIndex = 11;
            this.cantProd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LCantidad
            // 
            this.LCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(855, 66);
            this.LCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(129, 27);
            this.LCantidad.TabIndex = 10;
            this.LCantidad.Text = "Cantidad:";
            // 
            // LPrecioCompra
            // 
            this.LPrecioCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LPrecioCompra.AutoSize = true;
            this.LPrecioCompra.Location = new System.Drawing.Point(640, 104);
            this.LPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPrecioCompra.Name = "LPrecioCompra";
            this.LPrecioCompra.Size = new System.Drawing.Size(198, 27);
            this.LPrecioCompra.TabIndex = 9;
            this.LPrecioCompra.Text = "Precio Compra:";
            // 
            // TBprecio_compra
            // 
            this.TBprecio_compra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBprecio_compra.Location = new System.Drawing.Point(640, 137);
            this.TBprecio_compra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBprecio_compra.MaxLength = 6;
            this.TBprecio_compra.Name = "TBprecio_compra";
            this.TBprecio_compra.ShortcutsEnabled = false;
            this.TBprecio_compra.Size = new System.Drawing.Size(198, 35);
            this.TBprecio_compra.TabIndex = 8;
            this.TBprecio_compra.TextChanged += new System.EventHandler(this.TBprecio_compra_TextChanged);
            this.TBprecio_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // TBproducto
            // 
            this.TBproducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBproducto.Location = new System.Drawing.Point(237, 100);
            this.TBproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBproducto.Name = "TBproducto";
            this.TBproducto.ReadOnly = true;
            this.TBproducto.Size = new System.Drawing.Size(186, 35);
            this.TBproducto.TabIndex = 7;
            // 
            // LProducto
            // 
            this.LProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LProducto.AutoSize = true;
            this.LProducto.Location = new System.Drawing.Point(237, 66);
            this.LProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(113, 27);
            this.LProducto.TabIndex = 6;
            this.LProducto.Text = "Nombre:";
            // 
            // gbInfoProveedor
            // 
            this.gbInfoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfoProveedor.Controls.Add(this.TBIdProveedor);
            this.gbInfoProveedor.Controls.Add(this.btnBuscarProveedor);
            this.gbInfoProveedor.Controls.Add(this.TBrazonSocial);
            this.gbInfoProveedor.Controls.Add(this.TBcuit);
            this.gbInfoProveedor.Controls.Add(this.LRazonSocial);
            this.gbInfoProveedor.Controls.Add(this.LCuit);
            this.gbInfoProveedor.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProveedor.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInfoProveedor.Location = new System.Drawing.Point(569, 25);
            this.gbInfoProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInfoProveedor.Name = "gbInfoProveedor";
            this.gbInfoProveedor.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInfoProveedor.Size = new System.Drawing.Size(575, 183);
            this.gbInfoProveedor.TabIndex = 4;
            this.gbInfoProveedor.TabStop = false;
            this.gbInfoProveedor.Text = "Información Proveedor";
            // 
            // TBIdProveedor
            // 
            this.TBIdProveedor.Location = new System.Drawing.Point(196, 56);
            this.TBIdProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBIdProveedor.Name = "TBIdProveedor";
            this.TBIdProveedor.ReadOnly = true;
            this.TBIdProveedor.Size = new System.Drawing.Size(45, 35);
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
            this.btnBuscarProveedor.IconSize = 20;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(248, 96);
            this.btnBuscarProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(48, 35);
            this.btnBuscarProveedor.TabIndex = 4;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // TBrazonSocial
            // 
            this.TBrazonSocial.Location = new System.Drawing.Point(322, 96);
            this.TBrazonSocial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBrazonSocial.Name = "TBrazonSocial";
            this.TBrazonSocial.ReadOnly = true;
            this.TBrazonSocial.Size = new System.Drawing.Size(191, 35);
            this.TBrazonSocial.TabIndex = 3;
            // 
            // TBcuit
            // 
            this.TBcuit.Location = new System.Drawing.Point(50, 96);
            this.TBcuit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBcuit.MaxLength = 11;
            this.TBcuit.Name = "TBcuit";
            this.TBcuit.ReadOnly = true;
            this.TBcuit.ShortcutsEnabled = false;
            this.TBcuit.Size = new System.Drawing.Size(191, 35);
            this.TBcuit.TabIndex = 2;
            this.TBcuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LRazonSocial
            // 
            this.LRazonSocial.AutoSize = true;
            this.LRazonSocial.Location = new System.Drawing.Point(322, 66);
            this.LRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LRazonSocial.Name = "LRazonSocial";
            this.LRazonSocial.Size = new System.Drawing.Size(173, 27);
            this.LRazonSocial.TabIndex = 1;
            this.LRazonSocial.Text = "Razón Social:";
            // 
            // LCuit
            // 
            this.LCuit.AutoSize = true;
            this.LCuit.Location = new System.Drawing.Point(50, 66);
            this.LCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCuit.Name = "LCuit";
            this.LCuit.Size = new System.Drawing.Size(71, 27);
            this.LCuit.TabIndex = 0;
            this.LCuit.Text = "Cuit:";
            // 
            // gbInfoCompra
            // 
            this.gbInfoCompra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbInfoCompra.Controls.Add(this.TBNumFactura);
            this.gbInfoCompra.Controls.Add(this.dtFechaCompra);
            this.gbInfoCompra.Controls.Add(this.LNum_factura);
            this.gbInfoCompra.Controls.Add(this.cbTipoDoc);
            this.gbInfoCompra.Controls.Add(this.LTipoDoc);
            this.gbInfoCompra.Controls.Add(this.LFechaCompra);
            this.gbInfoCompra.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInfoCompra.Location = new System.Drawing.Point(13, 25);
            this.gbInfoCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInfoCompra.Name = "gbInfoCompra";
            this.gbInfoCompra.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInfoCompra.Size = new System.Drawing.Size(536, 183);
            this.gbInfoCompra.TabIndex = 3;
            this.gbInfoCompra.TabStop = false;
            this.gbInfoCompra.Text = "Información Compra";
            // 
            // TBNumFactura
            // 
            this.TBNumFactura.Location = new System.Drawing.Point(276, 133);
            this.TBNumFactura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBNumFactura.MaxLength = 6;
            this.TBNumFactura.Name = "TBNumFactura";
            this.TBNumFactura.ShortcutsEnabled = false;
            this.TBNumFactura.Size = new System.Drawing.Size(217, 35);
            this.TBNumFactura.TabIndex = 6;
            this.TBNumFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // dtFechaCompra
            // 
            this.dtFechaCompra.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaCompra.Location = new System.Drawing.Point(21, 95);
            this.dtFechaCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtFechaCompra.MaxDate = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            this.dtFechaCompra.MinDate = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            this.dtFechaCompra.Name = "dtFechaCompra";
            this.dtFechaCompra.Size = new System.Drawing.Size(232, 35);
            this.dtFechaCompra.TabIndex = 6;
            this.dtFechaCompra.Value = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            // 
            // LNum_factura
            // 
            this.LNum_factura.AutoSize = true;
            this.LNum_factura.Location = new System.Drawing.Point(276, 103);
            this.LNum_factura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNum_factura.Name = "LNum_factura";
            this.LNum_factura.Size = new System.Drawing.Size(217, 27);
            this.LNum_factura.TabIndex = 5;
            this.LNum_factura.Text = "Número Factura:";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDoc.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.ItemHeight = 27;
            this.cbTipoDoc.Location = new System.Drawing.Point(276, 58);
            this.cbTipoDoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTipoDoc.MaxLength = 100;
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(217, 35);
            this.cbTipoDoc.TabIndex = 3;
            // 
            // LTipoDoc
            // 
            this.LTipoDoc.AutoSize = true;
            this.LTipoDoc.Location = new System.Drawing.Point(276, 29);
            this.LTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTipoDoc.Name = "LTipoDoc";
            this.LTipoDoc.Size = new System.Drawing.Size(217, 27);
            this.LTipoDoc.TabIndex = 1;
            this.LTipoDoc.Text = "Tipo Documento:";
            // 
            // LFechaCompra
            // 
            this.LFechaCompra.AutoSize = true;
            this.LFechaCompra.Location = new System.Drawing.Point(21, 65);
            this.LFechaCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFechaCompra.Name = "LFechaCompra";
            this.LFechaCompra.Size = new System.Drawing.Size(91, 27);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 739);
            this.Controls.Add(this.contenedorDatos);
            this.Controls.Add(this.listaCompras);
            this.Controls.Add(this.contenedorBotones);
            this.Controls.Add(this.contenedorRegistrarCompra);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
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
        private System.Windows.Forms.TextBox TBIdProducto;
        private System.Windows.Forms.TextBox TBIdProveedor;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_compras;
    }
}