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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contenedorRegistrarCompra = new System.Windows.Forms.Panel();
            this.LRegistrarCompra = new System.Windows.Forms.Label();
            this.contenedorBotones = new System.Windows.Forms.Panel();
            this.btnRegistrarCompra = new FontAwesome.Sharp.IconButton();
            this.TBtotalPagar = new System.Windows.Forms.TextBox();
            this.LTotalPagar = new System.Windows.Forms.Label();
            this.btnAgregarProd = new FontAwesome.Sharp.IconButton();
            this.listaCompras = new System.Windows.Forms.DataGridView();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenedorDatos = new System.Windows.Forms.Panel();
            this.gbInfoProducto = new System.Windows.Forms.GroupBox();
            this.TBCodProd = new System.Windows.Forms.TextBox();
            this.LCodigo = new System.Windows.Forms.Label();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.TBbuscarProducto = new System.Windows.Forms.TextBox();
            this.LBuscarProducto = new System.Windows.Forms.Label();
            this.cantProd = new System.Windows.Forms.NumericUpDown();
            this.LCantidad = new System.Windows.Forms.Label();
            this.LPrecioCompra = new System.Windows.Forms.Label();
            this.TBprecio = new System.Windows.Forms.TextBox();
            this.TBproducto = new System.Windows.Forms.TextBox();
            this.LProducto = new System.Windows.Forms.Label();
            this.gbInfoProveedor = new System.Windows.Forms.GroupBox();
            this.btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.TBrazonSocial = new System.Windows.Forms.TextBox();
            this.TBcuit = new System.Windows.Forms.TextBox();
            this.LRazonSocial = new System.Windows.Forms.Label();
            this.LCuit = new System.Windows.Forms.Label();
            this.gbInfoCompra = new System.Windows.Forms.GroupBox();
            this.TBNumFactura = new System.Windows.Forms.TextBox();
            this.dtFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.LTipoDoc = new System.Windows.Forms.Label();
            this.LFechaCompra = new System.Windows.Forms.Label();
            this.contenedorRegistrarCompra.SuspendLayout();
            this.contenedorBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCompras)).BeginInit();
            this.contenedorDatos.SuspendLayout();
            this.gbInfoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantProd)).BeginInit();
            this.gbInfoProveedor.SuspendLayout();
            this.gbInfoCompra.SuspendLayout();
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
            this.LRegistrarCompra.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistrarCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.LRegistrarCompra.Location = new System.Drawing.Point(0, 0);
            this.LRegistrarCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LRegistrarCompra.Name = "LRegistrarCompra";
            this.LRegistrarCompra.Size = new System.Drawing.Size(330, 62);
            this.LRegistrarCompra.TabIndex = 0;
            this.LRegistrarCompra.Text = "Registrar Compra";
            this.LRegistrarCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // contenedorBotones
            // 
            this.contenedorBotones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorBotones.Controls.Add(this.btnRegistrarCompra);
            this.contenedorBotones.Controls.Add(this.TBtotalPagar);
            this.contenedorBotones.Controls.Add(this.LTotalPagar);
            this.contenedorBotones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contenedorBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.contenedorBotones.Location = new System.Drawing.Point(986, 62);
            this.contenedorBotones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorBotones.Name = "contenedorBotones";
            this.contenedorBotones.Size = new System.Drawing.Size(196, 592);
            this.contenedorBotones.TabIndex = 1;
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarCompra.BackColor = System.Drawing.Color.White;
            this.btnRegistrarCompra.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnRegistrarCompra.IconColor = System.Drawing.Color.DarkRed;
            this.btnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarCompra.IconSize = 25;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(33, 325);
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
            this.TBtotalPagar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtotalPagar.Location = new System.Drawing.Point(33, 203);
            this.TBtotalPagar.Name = "TBtotalPagar";
            this.TBtotalPagar.ReadOnly = true;
            this.TBtotalPagar.Size = new System.Drawing.Size(129, 28);
            this.TBtotalPagar.TabIndex = 2;
            // 
            // LTotalPagar
            // 
            this.LTotalPagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LTotalPagar.AutoSize = true;
            this.LTotalPagar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalPagar.ForeColor = System.Drawing.Color.DarkRed;
            this.LTotalPagar.Location = new System.Drawing.Point(33, 169);
            this.LTotalPagar.Name = "LTotalPagar";
            this.LTotalPagar.Size = new System.Drawing.Size(132, 21);
            this.LTotalPagar.TabIndex = 1;
            this.LTotalPagar.Text = "Total a Pagar:";
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
            this.btnAgregarProd.Location = new System.Drawing.Point(855, 53);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(94, 58);
            this.btnAgregarProd.TabIndex = 0;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            this.btnAgregarProd.Click += new System.EventHandler(this.BAgregarProd_Click);
            // 
            // listaCompras
            // 
            this.listaCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaCompras.BackgroundColor = System.Drawing.Color.White;
            this.listaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.listaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProducto,
            this.nombreProducto,
            this.precioCompra,
            this.cantidadProducto,
            this.num_compra,
            this.subTotalProducto});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaCompras.DefaultCellStyle = dataGridViewCellStyle28;
            this.listaCompras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaCompras.Location = new System.Drawing.Point(0, 445);
            this.listaCompras.Name = "listaCompras";
            this.listaCompras.RowHeadersWidth = 51;
            this.listaCompras.Size = new System.Drawing.Size(986, 209);
            this.listaCompras.TabIndex = 2;
            // 
            // codigoProducto
            // 
            this.codigoProducto.HeaderText = "Código";
            this.codigoProducto.MinimumWidth = 6;
            this.codigoProducto.Name = "codigoProducto";
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Producto";
            this.nombreProducto.MinimumWidth = 6;
            this.nombreProducto.Name = "nombreProducto";
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio Compra";
            this.precioCompra.MinimumWidth = 6;
            this.precioCompra.Name = "precioCompra";
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "Cantidad";
            this.cantidadProducto.MinimumWidth = 6;
            this.cantidadProducto.Name = "cantidadProducto";
            // 
            // num_compra
            // 
            this.num_compra.HeaderText = "Número Compra";
            this.num_compra.MinimumWidth = 6;
            this.num_compra.Name = "num_compra";
            // 
            // subTotalProducto
            // 
            this.subTotalProducto.HeaderText = "Subtotal";
            this.subTotalProducto.MinimumWidth = 6;
            this.subTotalProducto.Name = "subTotalProducto";
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
            this.contenedorDatos.Size = new System.Drawing.Size(986, 383);
            this.contenedorDatos.TabIndex = 3;
            // 
            // gbInfoProducto
            // 
            this.gbInfoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInfoProducto.Controls.Add(this.TBCodProd);
            this.gbInfoProducto.Controls.Add(this.LCodigo);
            this.gbInfoProducto.Controls.Add(this.cbProductos);
            this.gbInfoProducto.Controls.Add(this.btnAgregarProd);
            this.gbInfoProducto.Controls.Add(this.btnBuscarProducto);
            this.gbInfoProducto.Controls.Add(this.TBbuscarProducto);
            this.gbInfoProducto.Controls.Add(this.LBuscarProducto);
            this.gbInfoProducto.Controls.Add(this.cantProd);
            this.gbInfoProducto.Controls.Add(this.LCantidad);
            this.gbInfoProducto.Controls.Add(this.LPrecioCompra);
            this.gbInfoProducto.Controls.Add(this.TBprecio);
            this.gbInfoProducto.Controls.Add(this.TBproducto);
            this.gbInfoProducto.Controls.Add(this.LProducto);
            this.gbInfoProducto.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProducto.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInfoProducto.Location = new System.Drawing.Point(16, 203);
            this.gbInfoProducto.Name = "gbInfoProducto";
            this.gbInfoProducto.Size = new System.Drawing.Size(963, 144);
            this.gbInfoProducto.TabIndex = 5;
            this.gbInfoProducto.TabStop = false;
            this.gbInfoProducto.Text = "Información de Producto";
            // 
            // TBCodProd
            // 
            this.TBCodProd.Location = new System.Drawing.Point(511, 83);
            this.TBCodProd.Name = "TBCodProd";
            this.TBCodProd.ReadOnly = true;
            this.TBCodProd.Size = new System.Drawing.Size(75, 28);
            this.TBCodProd.TabIndex = 30;
            // 
            // LCodigo
            // 
            this.LCodigo.AutoSize = true;
            this.LCodigo.Location = new System.Drawing.Point(511, 57);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(75, 21);
            this.LCodigo.TabIndex = 29;
            this.LCodigo.Text = "Código:";
            // 
            // cbProductos
            // 
            this.cbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductos.ForeColor = System.Drawing.Color.Black;
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Items.AddRange(new object[] {
            "Nombre",
            "Codigo"});
            this.cbProductos.Location = new System.Drawing.Point(20, 82);
            this.cbProductos.Margin = new System.Windows.Forms.Padding(4);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(107, 29);
            this.cbProductos.TabIndex = 28;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 18;
            this.btnBuscarProducto.Location = new System.Drawing.Point(298, 85);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(46, 26);
            this.btnBuscarProducto.TabIndex = 27;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // TBbuscarProducto
            // 
            this.TBbuscarProducto.Location = new System.Drawing.Point(134, 83);
            this.TBbuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.TBbuscarProducto.MaxLength = 100;
            this.TBbuscarProducto.Name = "TBbuscarProducto";
            this.TBbuscarProducto.ShortcutsEnabled = false;
            this.TBbuscarProducto.Size = new System.Drawing.Size(156, 28);
            this.TBbuscarProducto.TabIndex = 26;
            // 
            // LBuscarProducto
            // 
            this.LBuscarProducto.AutoSize = true;
            this.LBuscarProducto.Location = new System.Drawing.Point(20, 57);
            this.LBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBuscarProducto.Name = "LBuscarProducto";
            this.LBuscarProducto.Size = new System.Drawing.Size(111, 21);
            this.LBuscarProducto.TabIndex = 25;
            this.LBuscarProducto.Text = "Buscar por:";
            // 
            // cantProd
            // 
            this.cantProd.Location = new System.Drawing.Point(739, 83);
            this.cantProd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantProd.Name = "cantProd";
            this.cantProd.Size = new System.Drawing.Size(95, 28);
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
            this.LCantidad.Location = new System.Drawing.Point(739, 57);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(95, 21);
            this.LCantidad.TabIndex = 10;
            this.LCantidad.Text = "Cantidad:";
            // 
            // LPrecioCompra
            // 
            this.LPrecioCompra.AutoSize = true;
            this.LPrecioCompra.Location = new System.Drawing.Point(592, 57);
            this.LPrecioCompra.Name = "LPrecioCompra";
            this.LPrecioCompra.Size = new System.Drawing.Size(141, 21);
            this.LPrecioCompra.TabIndex = 9;
            this.LPrecioCompra.Text = "Precio compra:";
            // 
            // TBprecio
            // 
            this.TBprecio.Location = new System.Drawing.Point(592, 83);
            this.TBprecio.Name = "TBprecio";
            this.TBprecio.ShortcutsEnabled = false;
            this.TBprecio.Size = new System.Drawing.Size(141, 28);
            this.TBprecio.TabIndex = 8;
            this.TBprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // TBproducto
            // 
            this.TBproducto.Location = new System.Drawing.Point(352, 83);
            this.TBproducto.Name = "TBproducto";
            this.TBproducto.ReadOnly = true;
            this.TBproducto.Size = new System.Drawing.Size(153, 28);
            this.TBproducto.TabIndex = 7;
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Location = new System.Drawing.Point(352, 57);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(96, 21);
            this.LProducto.TabIndex = 6;
            this.LProducto.Text = "Producto:";
            // 
            // gbInfoProveedor
            // 
            this.gbInfoProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInfoProveedor.Controls.Add(this.btnBuscarProveedor);
            this.gbInfoProveedor.Controls.Add(this.TBrazonSocial);
            this.gbInfoProveedor.Controls.Add(this.TBcuit);
            this.gbInfoProveedor.Controls.Add(this.LRazonSocial);
            this.gbInfoProveedor.Controls.Add(this.LCuit);
            this.gbInfoProveedor.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProveedor.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInfoProveedor.Location = new System.Drawing.Point(515, 34);
            this.gbInfoProveedor.Name = "gbInfoProveedor";
            this.gbInfoProveedor.Size = new System.Drawing.Size(464, 144);
            this.gbInfoProveedor.TabIndex = 4;
            this.gbInfoProveedor.TabStop = false;
            this.gbInfoProveedor.Text = "Información Proveedor";
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
            this.btnBuscarProveedor.Size = new System.Drawing.Size(46, 26);
            this.btnBuscarProveedor.TabIndex = 4;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // TBrazonSocial
            // 
            this.TBrazonSocial.Location = new System.Drawing.Point(253, 74);
            this.TBrazonSocial.Name = "TBrazonSocial";
            this.TBrazonSocial.ReadOnly = true;
            this.TBrazonSocial.Size = new System.Drawing.Size(164, 28);
            this.TBrazonSocial.TabIndex = 3;
            // 
            // TBcuit
            // 
            this.TBcuit.Location = new System.Drawing.Point(20, 74);
            this.TBcuit.MaxLength = 11;
            this.TBcuit.Name = "TBcuit";
            this.TBcuit.ShortcutsEnabled = false;
            this.TBcuit.Size = new System.Drawing.Size(160, 28);
            this.TBcuit.TabIndex = 2;
            this.TBcuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LRazonSocial
            // 
            this.LRazonSocial.AutoSize = true;
            this.LRazonSocial.Location = new System.Drawing.Point(253, 47);
            this.LRazonSocial.Name = "LRazonSocial";
            this.LRazonSocial.Size = new System.Drawing.Size(127, 21);
            this.LRazonSocial.TabIndex = 1;
            this.LRazonSocial.Text = "Razón Social:";
            // 
            // LCuit
            // 
            this.LCuit.AutoSize = true;
            this.LCuit.Location = new System.Drawing.Point(20, 47);
            this.LCuit.Name = "LCuit";
            this.LCuit.Size = new System.Drawing.Size(53, 21);
            this.LCuit.TabIndex = 0;
            this.LCuit.Text = "Cuit:";
            // 
            // gbInfoCompra
            // 
            this.gbInfoCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInfoCompra.Controls.Add(this.TBNumFactura);
            this.gbInfoCompra.Controls.Add(this.dtFechaCompra);
            this.gbInfoCompra.Controls.Add(this.label1);
            this.gbInfoCompra.Controls.Add(this.cbTipoDoc);
            this.gbInfoCompra.Controls.Add(this.LTipoDoc);
            this.gbInfoCompra.Controls.Add(this.LFechaCompra);
            this.gbInfoCompra.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInfoCompra.Location = new System.Drawing.Point(16, 34);
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
            this.TBNumFactura.Size = new System.Drawing.Size(164, 28);
            this.TBNumFactura.TabIndex = 6;
            this.TBNumFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // dtFechaCompra
            // 
            this.dtFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaCompra.Location = new System.Drawing.Point(29, 74);
            this.dtFechaCompra.MaxDate = new System.DateTime(2024, 10, 4, 0, 0, 0, 0);
            this.dtFechaCompra.MinDate = new System.DateTime(2024, 10, 4, 0, 0, 0, 0);
            this.dtFechaCompra.Name = "dtFechaCompra";
            this.dtFechaCompra.Size = new System.Drawing.Size(160, 28);
            this.dtFechaCompra.TabIndex = 6;
            this.dtFechaCompra.Value = new System.DateTime(2024, 10, 4, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número Factura:";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Items.AddRange(new object[] {
            "Factura A",
            "Factura B",
            "Factura C"});
            this.cbTipoDoc.Location = new System.Drawing.Point(225, 44);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(160, 29);
            this.cbTipoDoc.TabIndex = 3;
            // 
            // LTipoDoc
            // 
            this.LTipoDoc.AutoSize = true;
            this.LTipoDoc.Location = new System.Drawing.Point(225, 18);
            this.LTipoDoc.Name = "LTipoDoc";
            this.LTipoDoc.Size = new System.Drawing.Size(158, 21);
            this.LTipoDoc.TabIndex = 1;
            this.LTipoDoc.Text = "Tipo Documento:";
            // 
            // LFechaCompra
            // 
            this.LFechaCompra.AutoSize = true;
            this.LFechaCompra.Location = new System.Drawing.Point(29, 47);
            this.LFechaCompra.Name = "LFechaCompra";
            this.LFechaCompra.Size = new System.Drawing.Size(68, 21);
            this.LFechaCompra.TabIndex = 0;
            this.LFechaCompra.Text = "Fecha:";
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
        private System.Windows.Forms.TextBox TBprecio;
        private System.Windows.Forms.TextBox TBproducto;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.DateTimePicker dtFechaCompra;
        private System.Windows.Forms.ComboBox cbProductos;
        public FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.TextBox TBbuscarProducto;
        private System.Windows.Forms.Label LBuscarProducto;
        private System.Windows.Forms.TextBox TBCodProd;
        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalProducto;
        private System.Windows.Forms.TextBox TBNumFactura;
        private System.Windows.Forms.Label label1;
    }
}