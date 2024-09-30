namespace FankyRecords.C_presentacion.Administrador
{
    partial class registrarVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listadoVentaProducto = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenedorRegistrarVenta = new System.Windows.Forms.Panel();
            this.LRegistrarVenta = new System.Windows.Forms.Label();
            this.contenedorBotones = new System.Windows.Forms.Panel();
            this.btnCrearVenta = new FontAwesome.Sharp.IconButton();
            this.TBCambio = new System.Windows.Forms.TextBox();
            this.TBRecibe = new System.Windows.Forms.TextBox();
            this.LCambio = new System.Windows.Forms.Label();
            this.LRecibe = new System.Windows.Forms.Label();
            this.TBTotalAPagar = new System.Windows.Forms.TextBox();
            this.LTotalAPagar = new System.Windows.Forms.Label();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.gbInformacionVentas = new System.Windows.Forms.GroupBox();
            this.DTFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.LTipoDoc = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.contenedorInformacion = new System.Windows.Forms.Panel();
            this.gbInformacionProducto = new System.Windows.Forms.GroupBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.LCantidad = new System.Windows.Forms.Label();
            this.TBStock = new System.Windows.Forms.TextBox();
            this.LStock = new System.Windows.Forms.Label();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.LPrecio = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.TBProducto = new System.Windows.Forms.TextBox();
            this.TBCodProducto = new System.Windows.Forms.TextBox();
            this.LProducto = new System.Windows.Forms.Label();
            this.LCodProducto = new System.Windows.Forms.Label();
            this.gbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.TBNombreCompleto = new System.Windows.Forms.TextBox();
            this.TBNroDocumento = new System.Windows.Forms.TextBox();
            this.LNombreCompleto = new System.Windows.Forms.Label();
            this.LNroDocumento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadoVentaProducto)).BeginInit();
            this.contenedorRegistrarVenta.SuspendLayout();
            this.contenedorBotones.SuspendLayout();
            this.gbInformacionVentas.SuspendLayout();
            this.contenedorInformacion.SuspendLayout();
            this.gbInformacionProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.gbInformacionCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // listadoVentaProducto
            // 
            this.listadoVentaProducto.BackgroundColor = System.Drawing.Color.White;
            this.listadoVentaProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoVentaProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.listadoVentaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoVentaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.precio,
            this.cantidad,
            this.subtotal});
            this.listadoVentaProducto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoVentaProducto.Location = new System.Drawing.Point(0, 445);
            this.listadoVentaProducto.Margin = new System.Windows.Forms.Padding(4);
            this.listadoVentaProducto.Name = "listadoVentaProducto";
            this.listadoVentaProducto.RowHeadersWidth = 51;
            this.listadoVentaProducto.Size = new System.Drawing.Size(921, 209);
            this.listadoVentaProducto.TabIndex = 12;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.Width = 140;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 140;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 140;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 140;
            // 
            // contenedorRegistrarVenta
            // 
            this.contenedorRegistrarVenta.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorRegistrarVenta.Controls.Add(this.LRegistrarVenta);
            this.contenedorRegistrarVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorRegistrarVenta.Location = new System.Drawing.Point(0, 0);
            this.contenedorRegistrarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorRegistrarVenta.Name = "contenedorRegistrarVenta";
            this.contenedorRegistrarVenta.Size = new System.Drawing.Size(1182, 62);
            this.contenedorRegistrarVenta.TabIndex = 20;
            // 
            // LRegistrarVenta
            // 
            this.LRegistrarVenta.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LRegistrarVenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.LRegistrarVenta.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistrarVenta.ForeColor = System.Drawing.Color.DarkRed;
            this.LRegistrarVenta.Location = new System.Drawing.Point(0, 0);
            this.LRegistrarVenta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LRegistrarVenta.Name = "LRegistrarVenta";
            this.LRegistrarVenta.Size = new System.Drawing.Size(330, 62);
            this.LRegistrarVenta.TabIndex = 0;
            this.LRegistrarVenta.Text = "Registrar Venta";
            this.LRegistrarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // contenedorBotones
            // 
            this.contenedorBotones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorBotones.Controls.Add(this.btnCrearVenta);
            this.contenedorBotones.Controls.Add(this.TBCambio);
            this.contenedorBotones.Controls.Add(this.TBRecibe);
            this.contenedorBotones.Controls.Add(this.LCambio);
            this.contenedorBotones.Controls.Add(this.LRecibe);
            this.contenedorBotones.Controls.Add(this.TBTotalAPagar);
            this.contenedorBotones.Controls.Add(this.LTotalAPagar);
            this.contenedorBotones.Controls.Add(this.btnAgregar);
            this.contenedorBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.contenedorBotones.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contenedorBotones.ForeColor = System.Drawing.Color.Transparent;
            this.contenedorBotones.Location = new System.Drawing.Point(921, 62);
            this.contenedorBotones.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorBotones.Name = "contenedorBotones";
            this.contenedorBotones.Size = new System.Drawing.Size(261, 592);
            this.contenedorBotones.TabIndex = 21;
            // 
            // btnCrearVenta
            // 
            this.btnCrearVenta.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearVenta.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCrearVenta.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnCrearVenta.IconColor = System.Drawing.Color.DarkRed;
            this.btnCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearVenta.IconSize = 25;
            this.btnCrearVenta.Location = new System.Drawing.Point(69, 528);
            this.btnCrearVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearVenta.Name = "btnCrearVenta";
            this.btnCrearVenta.Size = new System.Drawing.Size(129, 58);
            this.btnCrearVenta.TabIndex = 33;
            this.btnCrearVenta.Text = "Crear Venta";
            this.btnCrearVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCrearVenta.UseVisualStyleBackColor = true;
            this.btnCrearVenta.Click += new System.EventHandler(this.btnCrearVenta_Click);
            // 
            // TBCambio
            // 
            this.TBCambio.Location = new System.Drawing.Point(69, 476);
            this.TBCambio.Margin = new System.Windows.Forms.Padding(4);
            this.TBCambio.Name = "TBCambio";
            this.TBCambio.ReadOnly = true;
            this.TBCambio.Size = new System.Drawing.Size(129, 28);
            this.TBCambio.TabIndex = 32;
            // 
            // TBRecibe
            // 
            this.TBRecibe.Location = new System.Drawing.Point(66, 411);
            this.TBRecibe.Margin = new System.Windows.Forms.Padding(4);
            this.TBRecibe.Name = "TBRecibe";
            this.TBRecibe.Size = new System.Drawing.Size(129, 28);
            this.TBRecibe.TabIndex = 31;
            this.TBRecibe.TextChanged += new System.EventHandler(this.TBRecibe_TextChanged);
            this.TBRecibe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBRecibe_KeyPress);
            // 
            // LCambio
            // 
            this.LCambio.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LCambio.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCambio.ForeColor = System.Drawing.Color.DarkRed;
            this.LCambio.Location = new System.Drawing.Point(69, 447);
            this.LCambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCambio.Name = "LCambio";
            this.LCambio.Size = new System.Drawing.Size(132, 21);
            this.LCambio.TabIndex = 30;
            this.LCambio.Text = "Cambio:";
            // 
            // LRecibe
            // 
            this.LRecibe.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LRecibe.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRecibe.ForeColor = System.Drawing.Color.DarkRed;
            this.LRecibe.Location = new System.Drawing.Point(66, 382);
            this.LRecibe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LRecibe.Name = "LRecibe";
            this.LRecibe.Size = new System.Drawing.Size(132, 21);
            this.LRecibe.TabIndex = 29;
            this.LRecibe.Text = "Se recibe:";
            // 
            // TBTotalAPagar
            // 
            this.TBTotalAPagar.Location = new System.Drawing.Point(66, 346);
            this.TBTotalAPagar.Margin = new System.Windows.Forms.Padding(4);
            this.TBTotalAPagar.Name = "TBTotalAPagar";
            this.TBTotalAPagar.ReadOnly = true;
            this.TBTotalAPagar.Size = new System.Drawing.Size(129, 28);
            this.TBTotalAPagar.TabIndex = 28;
            this.TBTotalAPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LTotalAPagar
            // 
            this.LTotalAPagar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LTotalAPagar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalAPagar.ForeColor = System.Drawing.Color.DarkRed;
            this.LTotalAPagar.Location = new System.Drawing.Point(66, 317);
            this.LTotalAPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTotalAPagar.Name = "LTotalAPagar";
            this.LTotalAPagar.Size = new System.Drawing.Size(132, 21);
            this.LTotalAPagar.TabIndex = 27;
            this.LTotalAPagar.Text = "Total a pagar:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.DarkRed;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.Location = new System.Drawing.Point(69, 203);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 58);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbInformacionVentas
            // 
            this.gbInformacionVentas.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.gbInformacionVentas.Controls.Add(this.DTFechaVenta);
            this.gbInformacionVentas.Controls.Add(this.LTipoDoc);
            this.gbInformacionVentas.Controls.Add(this.LFecha);
            this.gbInformacionVentas.Controls.Add(this.cbTipoDoc);
            this.gbInformacionVentas.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionVentas.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInformacionVentas.Location = new System.Drawing.Point(24, 34);
            this.gbInformacionVentas.Margin = new System.Windows.Forms.Padding(4);
            this.gbInformacionVentas.Name = "gbInformacionVentas";
            this.gbInformacionVentas.Padding = new System.Windows.Forms.Padding(4);
            this.gbInformacionVentas.Size = new System.Drawing.Size(434, 144);
            this.gbInformacionVentas.TabIndex = 22;
            this.gbInformacionVentas.TabStop = false;
            this.gbInformacionVentas.Text = "Información Venta";
            // 
            // DTFechaVenta
            // 
            this.DTFechaVenta.CalendarFont = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaVenta.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DTFechaVenta.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DTFechaVenta.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaVenta.Location = new System.Drawing.Point(29, 74);
            this.DTFechaVenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DTFechaVenta.Name = "DTFechaVenta";
            this.DTFechaVenta.Size = new System.Drawing.Size(160, 28);
            this.DTFechaVenta.TabIndex = 23;
            this.DTFechaVenta.Value = new System.DateTime(2024, 9, 25, 10, 46, 43, 0);
            // 
            // LTipoDoc
            // 
            this.LTipoDoc.AutoSize = true;
            this.LTipoDoc.Location = new System.Drawing.Point(225, 47);
            this.LTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTipoDoc.Name = "LTipoDoc";
            this.LTipoDoc.Size = new System.Drawing.Size(158, 21);
            this.LTipoDoc.TabIndex = 3;
            this.LTipoDoc.Text = "Tipo Documento:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(29, 47);
            this.LFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(68, 21);
            this.LFecha.TabIndex = 2;
            this.LFecha.Text = "Fecha:";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDoc.ForeColor = System.Drawing.Color.DarkRed;
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cbTipoDoc.Location = new System.Drawing.Point(225, 73);
            this.cbTipoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(160, 29);
            this.cbTipoDoc.TabIndex = 1;
            // 
            // contenedorInformacion
            // 
            this.contenedorInformacion.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorInformacion.Controls.Add(this.gbInformacionProducto);
            this.contenedorInformacion.Controls.Add(this.gbInformacionCliente);
            this.contenedorInformacion.Controls.Add(this.gbInformacionVentas);
            this.contenedorInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorInformacion.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contenedorInformacion.Location = new System.Drawing.Point(0, 62);
            this.contenedorInformacion.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorInformacion.Name = "contenedorInformacion";
            this.contenedorInformacion.Size = new System.Drawing.Size(921, 383);
            this.contenedorInformacion.TabIndex = 23;
            // 
            // gbInformacionProducto
            // 
            this.gbInformacionProducto.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.gbInformacionProducto.Controls.Add(this.numCantidad);
            this.gbInformacionProducto.Controls.Add(this.LCantidad);
            this.gbInformacionProducto.Controls.Add(this.TBStock);
            this.gbInformacionProducto.Controls.Add(this.LStock);
            this.gbInformacionProducto.Controls.Add(this.TBPrecio);
            this.gbInformacionProducto.Controls.Add(this.LPrecio);
            this.gbInformacionProducto.Controls.Add(this.btnBuscarProducto);
            this.gbInformacionProducto.Controls.Add(this.TBProducto);
            this.gbInformacionProducto.Controls.Add(this.TBCodProducto);
            this.gbInformacionProducto.Controls.Add(this.LProducto);
            this.gbInformacionProducto.Controls.Add(this.LCodProducto);
            this.gbInformacionProducto.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionProducto.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInformacionProducto.Location = new System.Drawing.Point(24, 203);
            this.gbInformacionProducto.Margin = new System.Windows.Forms.Padding(4);
            this.gbInformacionProducto.Name = "gbInformacionProducto";
            this.gbInformacionProducto.Padding = new System.Windows.Forms.Padding(4);
            this.gbInformacionProducto.Size = new System.Drawing.Size(874, 144);
            this.gbInformacionProducto.TabIndex = 24;
            this.gbInformacionProducto.TabStop = false;
            this.gbInformacionProducto.Text = "Información de Producto";
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.Location = new System.Drawing.Point(735, 81);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(105, 28);
            this.numCantidad.TabIndex = 25;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(735, 56);
            this.LCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(95, 21);
            this.LCantidad.TabIndex = 11;
            this.LCantidad.Text = "Cantidad:";
            // 
            // TBStock
            // 
            this.TBStock.Location = new System.Drawing.Point(608, 81);
            this.TBStock.Margin = new System.Windows.Forms.Padding(4);
            this.TBStock.Name = "TBStock";
            this.TBStock.ReadOnly = true;
            this.TBStock.Size = new System.Drawing.Size(105, 28);
            this.TBStock.TabIndex = 10;
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Location = new System.Drawing.Point(608, 56);
            this.LStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(63, 21);
            this.LStock.TabIndex = 9;
            this.LStock.Text = "Stock:";
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(491, 81);
            this.TBPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(105, 28);
            this.TBPrecio.TabIndex = 8;
            this.TBPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Location = new System.Drawing.Point(491, 56);
            this.LPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(72, 21);
            this.LPrecio.TabIndex = 7;
            this.LPrecio.Text = "Precio:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 18;
            this.btnBuscarProducto.Location = new System.Drawing.Point(180, 83);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(46, 26);
            this.btnBuscarProducto.TabIndex = 6;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // TBProducto
            // 
            this.TBProducto.Location = new System.Drawing.Point(251, 81);
            this.TBProducto.Margin = new System.Windows.Forms.Padding(4);
            this.TBProducto.Name = "TBProducto";
            this.TBProducto.ReadOnly = true;
            this.TBProducto.Size = new System.Drawing.Size(228, 28);
            this.TBProducto.TabIndex = 5;
            // 
            // TBCodProducto
            // 
            this.TBCodProducto.Location = new System.Drawing.Point(15, 83);
            this.TBCodProducto.Margin = new System.Windows.Forms.Padding(4);
            this.TBCodProducto.Name = "TBCodProducto";
            this.TBCodProducto.Size = new System.Drawing.Size(160, 28);
            this.TBCodProducto.TabIndex = 4;
            this.TBCodProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Location = new System.Drawing.Point(251, 56);
            this.LProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(96, 21);
            this.LProducto.TabIndex = 3;
            this.LProducto.Text = "Producto:";
            // 
            // LCodProducto
            // 
            this.LCodProducto.AutoSize = true;
            this.LCodProducto.Location = new System.Drawing.Point(15, 56);
            this.LCodProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCodProducto.Name = "LCodProducto";
            this.LCodProducto.Size = new System.Drawing.Size(161, 21);
            this.LCodProducto.TabIndex = 2;
            this.LCodProducto.Text = "Código Producto:";
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.gbInformacionCliente.Controls.Add(this.btnBuscarCliente);
            this.gbInformacionCliente.Controls.Add(this.TBNombreCompleto);
            this.gbInformacionCliente.Controls.Add(this.TBNroDocumento);
            this.gbInformacionCliente.Controls.Add(this.LNombreCompleto);
            this.gbInformacionCliente.Controls.Add(this.LNroDocumento);
            this.gbInformacionCliente.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInformacionCliente.Location = new System.Drawing.Point(464, 34);
            this.gbInformacionCliente.Margin = new System.Windows.Forms.Padding(4);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Padding = new System.Windows.Forms.Padding(4);
            this.gbInformacionCliente.Size = new System.Drawing.Size(434, 144);
            this.gbInformacionCliente.TabIndex = 23;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "Información Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarCliente.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCliente.IconSize = 18;
            this.btnBuscarCliente.Location = new System.Drawing.Point(185, 74);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(46, 26);
            this.btnBuscarCliente.TabIndex = 6;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // TBNombreCompleto
            // 
            this.TBNombreCompleto.Location = new System.Drawing.Point(253, 72);
            this.TBNombreCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.TBNombreCompleto.Name = "TBNombreCompleto";
            this.TBNombreCompleto.ReadOnly = true;
            this.TBNombreCompleto.Size = new System.Drawing.Size(160, 28);
            this.TBNombreCompleto.TabIndex = 5;
            this.TBNombreCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // TBNroDocumento
            // 
            this.TBNroDocumento.Location = new System.Drawing.Point(20, 74);
            this.TBNroDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.TBNroDocumento.Name = "TBNroDocumento";
            this.TBNroDocumento.Size = new System.Drawing.Size(160, 28);
            this.TBNroDocumento.TabIndex = 4;
            this.TBNroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LNombreCompleto
            // 
            this.LNombreCompleto.AutoSize = true;
            this.LNombreCompleto.Location = new System.Drawing.Point(253, 47);
            this.LNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombreCompleto.Name = "LNombreCompleto";
            this.LNombreCompleto.Size = new System.Drawing.Size(172, 21);
            this.LNombreCompleto.TabIndex = 3;
            this.LNombreCompleto.Text = "Nombre Completo:";
            // 
            // LNroDocumento
            // 
            this.LNroDocumento.AutoSize = true;
            this.LNroDocumento.Location = new System.Drawing.Point(20, 47);
            this.LNroDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNroDocumento.Name = "LNroDocumento";
            this.LNroDocumento.Size = new System.Drawing.Size(191, 21);
            this.LNroDocumento.TabIndex = 2;
            this.LNroDocumento.Text = "Número Documento:";
            // 
            // registrarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.contenedorInformacion);
            this.Controls.Add(this.listadoVentaProducto);
            this.Controls.Add(this.contenedorBotones);
            this.Controls.Add(this.contenedorRegistrarVenta);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "registrarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registrarVentas";
            ((System.ComponentModel.ISupportInitialize)(this.listadoVentaProducto)).EndInit();
            this.contenedorRegistrarVenta.ResumeLayout(false);
            this.contenedorBotones.ResumeLayout(false);
            this.contenedorBotones.PerformLayout();
            this.gbInformacionVentas.ResumeLayout(false);
            this.gbInformacionVentas.PerformLayout();
            this.contenedorInformacion.ResumeLayout(false);
            this.gbInformacionProducto.ResumeLayout(false);
            this.gbInformacionProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.gbInformacionCliente.ResumeLayout(false);
            this.gbInformacionCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView listadoVentaProducto;
        public System.Windows.Forms.Panel contenedorRegistrarVenta;
        public System.Windows.Forms.Label LRegistrarVenta;
        public System.Windows.Forms.Panel contenedorBotones;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.GroupBox gbInformacionVentas;
        private System.Windows.Forms.Panel contenedorInformacion;
        private System.Windows.Forms.Label LTipoDoc;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.ComboBox cbTipoDoc;
        public System.Windows.Forms.DateTimePicker DTFechaVenta;
        private System.Windows.Forms.GroupBox gbInformacionCliente;
        private System.Windows.Forms.Label LNombreCompleto;
        private System.Windows.Forms.Label LNroDocumento;
        private System.Windows.Forms.TextBox TBNombreCompleto;
        private System.Windows.Forms.TextBox TBNroDocumento;
        public FontAwesome.Sharp.IconButton btnBuscarCliente;
        private System.Windows.Forms.GroupBox gbInformacionProducto;
        public FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.TextBox TBProducto;
        private System.Windows.Forms.TextBox TBCodProducto;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.Label LCodProducto;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.TextBox TBStock;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label LRecibe;
        private System.Windows.Forms.TextBox TBTotalAPagar;
        private System.Windows.Forms.Label LTotalAPagar;
        private System.Windows.Forms.TextBox TBCambio;
        private System.Windows.Forms.TextBox TBRecibe;
        private System.Windows.Forms.Label LCambio;
        private FontAwesome.Sharp.IconButton btnCrearVenta;
    }
}