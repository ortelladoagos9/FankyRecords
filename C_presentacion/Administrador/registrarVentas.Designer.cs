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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listadoVentaProducto = new System.Windows.Forms.DataGridView();
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
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.TBIdProducto = new System.Windows.Forms.TextBox();
            this.LCodigo = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.LCantidad = new System.Windows.Forms.Label();
            this.TBStock = new System.Windows.Forms.TextBox();
            this.LStock = new System.Windows.Forms.Label();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.LPrecio = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.TBNombreProd = new System.Windows.Forms.TextBox();
            this.TBCodigoProd = new System.Windows.Forms.TextBox();
            this.LProducto = new System.Windows.Forms.Label();
            this.gbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.TBIdCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.TBNombreCompleto = new System.Windows.Forms.TextBox();
            this.TBNroDocumento = new System.Windows.Forms.TextBox();
            this.LNombreCompleto = new System.Windows.Forms.Label();
            this.LNroDocumento = new System.Windows.Forms.Label();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.listadoVentaProducto.AllowUserToAddRows = false;
            this.listadoVentaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoVentaProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listadoVentaProducto.BackgroundColor = System.Drawing.Color.White;
            this.listadoVentaProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoVentaProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoVentaProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.listadoVentaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoVentaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.Codigo,
            this.nombreProd,
            this.Descripcion,
            this.precioVenta,
            this.stock,
            this.cantidad,
            this.subtotal,
            this.btnEliminar,
            this.ID_venta});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoVentaProducto.DefaultCellStyle = dataGridViewCellStyle8;
            this.listadoVentaProducto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoVentaProducto.Location = new System.Drawing.Point(0, 508);
            this.listadoVentaProducto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listadoVentaProducto.Name = "listadoVentaProducto";
            this.listadoVentaProducto.ReadOnly = true;
            this.listadoVentaProducto.RowHeadersWidth = 51;
            this.listadoVentaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoVentaProducto.Size = new System.Drawing.Size(1163, 231);
            this.listadoVentaProducto.TabIndex = 12;
            this.listadoVentaProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoVentaProducto_CellContentClick);
            this.listadoVentaProducto.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.listadoVentaProducto_CellPainting);
            // 
            // contenedorRegistrarVenta
            // 
            this.contenedorRegistrarVenta.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorRegistrarVenta.Controls.Add(this.LRegistrarVenta);
            this.contenedorRegistrarVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorRegistrarVenta.Location = new System.Drawing.Point(0, 0);
            this.contenedorRegistrarVenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.contenedorRegistrarVenta.Name = "contenedorRegistrarVenta";
            this.contenedorRegistrarVenta.Size = new System.Drawing.Size(1418, 69);
            this.contenedorRegistrarVenta.TabIndex = 20;
            // 
            // LRegistrarVenta
            // 
            this.LRegistrarVenta.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LRegistrarVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LRegistrarVenta.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistrarVenta.ForeColor = System.Drawing.Color.DarkRed;
            this.LRegistrarVenta.Location = new System.Drawing.Point(0, 0);
            this.LRegistrarVenta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LRegistrarVenta.Name = "LRegistrarVenta";
            this.LRegistrarVenta.Size = new System.Drawing.Size(1418, 69);
            this.LRegistrarVenta.TabIndex = 0;
            this.LRegistrarVenta.Text = "Registrar Venta";
            this.LRegistrarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.contenedorBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.contenedorBotones.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contenedorBotones.ForeColor = System.Drawing.Color.Transparent;
            this.contenedorBotones.Location = new System.Drawing.Point(1163, 69);
            this.contenedorBotones.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.contenedorBotones.Name = "contenedorBotones";
            this.contenedorBotones.Size = new System.Drawing.Size(255, 670);
            this.contenedorBotones.TabIndex = 21;
            // 
            // btnCrearVenta
            // 
            this.btnCrearVenta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrearVenta.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearVenta.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCrearVenta.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnCrearVenta.IconColor = System.Drawing.Color.DarkRed;
            this.btnCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearVenta.IconSize = 25;
            this.btnCrearVenta.Location = new System.Drawing.Point(34, 406);
            this.btnCrearVenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCrearVenta.Name = "btnCrearVenta";
            this.btnCrearVenta.Size = new System.Drawing.Size(178, 74);
            this.btnCrearVenta.TabIndex = 33;
            this.btnCrearVenta.Text = "Crear Venta";
            this.btnCrearVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCrearVenta.UseVisualStyleBackColor = true;
            this.btnCrearVenta.Click += new System.EventHandler(this.btnCrearVenta_Click);
            // 
            // TBCambio
            // 
            this.TBCambio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TBCambio.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCambio.Location = new System.Drawing.Point(34, 333);
            this.TBCambio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBCambio.Name = "TBCambio";
            this.TBCambio.ReadOnly = true;
            this.TBCambio.Size = new System.Drawing.Size(178, 35);
            this.TBCambio.TabIndex = 32;
            // 
            // TBRecibe
            // 
            this.TBRecibe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TBRecibe.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRecibe.Location = new System.Drawing.Point(34, 240);
            this.TBRecibe.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBRecibe.MaxLength = 6;
            this.TBRecibe.Name = "TBRecibe";
            this.TBRecibe.ShortcutsEnabled = false;
            this.TBRecibe.Size = new System.Drawing.Size(178, 35);
            this.TBRecibe.TabIndex = 31;
            this.TBRecibe.TextChanged += new System.EventHandler(this.TBRecibe_TextChanged);
            this.TBRecibe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBRecibe_KeyPress);
            // 
            // LCambio
            // 
            this.LCambio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LCambio.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LCambio.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCambio.ForeColor = System.Drawing.Color.DarkRed;
            this.LCambio.Location = new System.Drawing.Point(34, 299);
            this.LCambio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LCambio.Name = "LCambio";
            this.LCambio.Size = new System.Drawing.Size(178, 30);
            this.LCambio.TabIndex = 30;
            this.LCambio.Text = "Cambio:";
            // 
            // LRecibe
            // 
            this.LRecibe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LRecibe.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LRecibe.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRecibe.ForeColor = System.Drawing.Color.DarkRed;
            this.LRecibe.Location = new System.Drawing.Point(34, 205);
            this.LRecibe.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LRecibe.Name = "LRecibe";
            this.LRecibe.Size = new System.Drawing.Size(178, 30);
            this.LRecibe.TabIndex = 29;
            this.LRecibe.Text = "Se recibe:";
            // 
            // TBTotalAPagar
            // 
            this.TBTotalAPagar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TBTotalAPagar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTotalAPagar.Location = new System.Drawing.Point(34, 146);
            this.TBTotalAPagar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBTotalAPagar.Name = "TBTotalAPagar";
            this.TBTotalAPagar.ReadOnly = true;
            this.TBTotalAPagar.Size = new System.Drawing.Size(178, 35);
            this.TBTotalAPagar.TabIndex = 28;
            this.TBTotalAPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LTotalAPagar
            // 
            this.LTotalAPagar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LTotalAPagar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LTotalAPagar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalAPagar.ForeColor = System.Drawing.Color.DarkRed;
            this.LTotalAPagar.Location = new System.Drawing.Point(34, 112);
            this.LTotalAPagar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LTotalAPagar.Name = "LTotalAPagar";
            this.LTotalAPagar.Size = new System.Drawing.Size(188, 30);
            this.LTotalAPagar.TabIndex = 27;
            this.LTotalAPagar.Text = "Total a pagar:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregar.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.DarkRed;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.Location = new System.Drawing.Point(993, 67);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 68);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbInformacionVentas
            // 
            this.gbInformacionVentas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbInformacionVentas.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.gbInformacionVentas.Controls.Add(this.DTFechaVenta);
            this.gbInformacionVentas.Controls.Add(this.LTipoDoc);
            this.gbInformacionVentas.Controls.Add(this.LFecha);
            this.gbInformacionVentas.Controls.Add(this.cbTipoDoc);
            this.gbInformacionVentas.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionVentas.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInformacionVentas.Location = new System.Drawing.Point(13, 25);
            this.gbInformacionVentas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInformacionVentas.Name = "gbInformacionVentas";
            this.gbInformacionVentas.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInformacionVentas.Size = new System.Drawing.Size(494, 183);
            this.gbInformacionVentas.TabIndex = 22;
            this.gbInformacionVentas.TabStop = false;
            this.gbInformacionVentas.Text = "Información Venta";
            // 
            // DTFechaVenta
            // 
            this.DTFechaVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTFechaVenta.CalendarFont = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaVenta.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DTFechaVenta.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DTFechaVenta.Checked = false;
            this.DTFechaVenta.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaVenta.Location = new System.Drawing.Point(15, 98);
            this.DTFechaVenta.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.DTFechaVenta.MaxDate = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            this.DTFechaVenta.MinDate = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            this.DTFechaVenta.Name = "DTFechaVenta";
            this.DTFechaVenta.Size = new System.Drawing.Size(232, 35);
            this.DTFechaVenta.TabIndex = 23;
            this.DTFechaVenta.Value = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            // 
            // LTipoDoc
            // 
            this.LTipoDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LTipoDoc.AutoSize = true;
            this.LTipoDoc.Location = new System.Drawing.Point(260, 66);
            this.LTipoDoc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LTipoDoc.Name = "LTipoDoc";
            this.LTipoDoc.Size = new System.Drawing.Size(217, 27);
            this.LTipoDoc.TabIndex = 3;
            this.LTipoDoc.Text = "Tipo Documento:";
            // 
            // LFecha
            // 
            this.LFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(15, 66);
            this.LFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(91, 27);
            this.LFecha.TabIndex = 2;
            this.LFecha.Text = "Fecha:";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDoc.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDoc.ForeColor = System.Drawing.Color.Black;
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Location = new System.Drawing.Point(260, 98);
            this.cbTipoDoc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(217, 35);
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
            this.contenedorInformacion.Location = new System.Drawing.Point(0, 69);
            this.contenedorInformacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.contenedorInformacion.Name = "contenedorInformacion";
            this.contenedorInformacion.Size = new System.Drawing.Size(1418, 670);
            this.contenedorInformacion.TabIndex = 23;
            // 
            // gbInformacionProducto
            // 
            this.gbInformacionProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInformacionProducto.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.gbInformacionProducto.Controls.Add(this.TBDescripcion);
            this.gbInformacionProducto.Controls.Add(this.LDescripcion);
            this.gbInformacionProducto.Controls.Add(this.TBIdProducto);
            this.gbInformacionProducto.Controls.Add(this.LCodigo);
            this.gbInformacionProducto.Controls.Add(this.numCantidad);
            this.gbInformacionProducto.Controls.Add(this.LCantidad);
            this.gbInformacionProducto.Controls.Add(this.TBStock);
            this.gbInformacionProducto.Controls.Add(this.LStock);
            this.gbInformacionProducto.Controls.Add(this.TBPrecio);
            this.gbInformacionProducto.Controls.Add(this.LPrecio);
            this.gbInformacionProducto.Controls.Add(this.btnAgregar);
            this.gbInformacionProducto.Controls.Add(this.btnBuscarProducto);
            this.gbInformacionProducto.Controls.Add(this.TBNombreProd);
            this.gbInformacionProducto.Controls.Add(this.TBCodigoProd);
            this.gbInformacionProducto.Controls.Add(this.LProducto);
            this.gbInformacionProducto.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionProducto.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInformacionProducto.Location = new System.Drawing.Point(13, 225);
            this.gbInformacionProducto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInformacionProducto.Name = "gbInformacionProducto";
            this.gbInformacionProducto.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInformacionProducto.Size = new System.Drawing.Size(1131, 183);
            this.gbInformacionProducto.TabIndex = 24;
            this.gbInformacionProducto.TabStop = false;
            this.gbInformacionProducto.Text = "Información de Producto";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBDescripcion.Location = new System.Drawing.Point(489, 100);
            this.TBDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.ReadOnly = true;
            this.TBDescripcion.Size = new System.Drawing.Size(188, 35);
            this.TBDescripcion.TabIndex = 37;
            // 
            // LDescripcion
            // 
            this.LDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Location = new System.Drawing.Point(489, 68);
            this.LDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(163, 27);
            this.LDescripcion.TabIndex = 36;
            this.LDescripcion.Text = "Descripción:";
            // 
            // TBIdProducto
            // 
            this.TBIdProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBIdProducto.Location = new System.Drawing.Point(157, 58);
            this.TBIdProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBIdProducto.Name = "TBIdProducto";
            this.TBIdProducto.ReadOnly = true;
            this.TBIdProducto.Size = new System.Drawing.Size(45, 35);
            this.TBIdProducto.TabIndex = 34;
            this.TBIdProducto.Visible = false;
            // 
            // LCodigo
            // 
            this.LCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LCodigo.AutoSize = true;
            this.LCodigo.Location = new System.Drawing.Point(16, 68);
            this.LCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(102, 27);
            this.LCodigo.TabIndex = 30;
            this.LCodigo.Text = "Código:";
            // 
            // numCantidad
            // 
            this.numCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numCantidad.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.Location = new System.Drawing.Point(842, 135);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(129, 35);
            this.numCantidad.TabIndex = 25;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LCantidad
            // 
            this.LCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(842, 103);
            this.LCantidad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(129, 27);
            this.LCantidad.TabIndex = 11;
            this.LCantidad.Text = "Cantidad:";
            // 
            // TBStock
            // 
            this.TBStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBStock.Location = new System.Drawing.Point(842, 57);
            this.TBStock.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBStock.Name = "TBStock";
            this.TBStock.ReadOnly = true;
            this.TBStock.Size = new System.Drawing.Size(129, 35);
            this.TBStock.TabIndex = 10;
            // 
            // LStock
            // 
            this.LStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LStock.AutoSize = true;
            this.LStock.Location = new System.Drawing.Point(842, 25);
            this.LStock.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(85, 27);
            this.LStock.TabIndex = 9;
            this.LStock.Text = "Stock:";
            // 
            // TBPrecio
            // 
            this.TBPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBPrecio.Location = new System.Drawing.Point(696, 100);
            this.TBPrecio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.ReadOnly = true;
            this.TBPrecio.Size = new System.Drawing.Size(131, 35);
            this.TBPrecio.TabIndex = 8;
            this.TBPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LPrecio
            // 
            this.LPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LPrecio.AutoSize = true;
            this.LPrecio.Location = new System.Drawing.Point(696, 68);
            this.LPrecio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(96, 27);
            this.LPrecio.TabIndex = 7;
            this.LPrecio.Text = "Precio:";
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
            this.btnBuscarProducto.Location = new System.Drawing.Point(212, 100);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(48, 35);
            this.btnBuscarProducto.TabIndex = 6;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // TBNombreProd
            // 
            this.TBNombreProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBNombreProd.Location = new System.Drawing.Point(276, 100);
            this.TBNombreProd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBNombreProd.Name = "TBNombreProd";
            this.TBNombreProd.ReadOnly = true;
            this.TBNombreProd.Size = new System.Drawing.Size(196, 35);
            this.TBNombreProd.TabIndex = 5;
            // 
            // TBCodigoProd
            // 
            this.TBCodigoProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBCodigoProd.Location = new System.Drawing.Point(16, 100);
            this.TBCodigoProd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBCodigoProd.MaxLength = 100;
            this.TBCodigoProd.Name = "TBCodigoProd";
            this.TBCodigoProd.ReadOnly = true;
            this.TBCodigoProd.ShortcutsEnabled = false;
            this.TBCodigoProd.Size = new System.Drawing.Size(186, 35);
            this.TBCodigoProd.TabIndex = 4;
            // 
            // LProducto
            // 
            this.LProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LProducto.AutoSize = true;
            this.LProducto.Location = new System.Drawing.Point(276, 68);
            this.LProducto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(113, 27);
            this.LProducto.TabIndex = 3;
            this.LProducto.Text = "Nombre:";
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInformacionCliente.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.gbInformacionCliente.Controls.Add(this.TBIdCliente);
            this.gbInformacionCliente.Controls.Add(this.btnBuscarCliente);
            this.gbInformacionCliente.Controls.Add(this.TBNombreCompleto);
            this.gbInformacionCliente.Controls.Add(this.TBNroDocumento);
            this.gbInformacionCliente.Controls.Add(this.LNombreCompleto);
            this.gbInformacionCliente.Controls.Add(this.LNroDocumento);
            this.gbInformacionCliente.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInformacionCliente.Location = new System.Drawing.Point(531, 25);
            this.gbInformacionCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInformacionCliente.Size = new System.Drawing.Size(613, 183);
            this.gbInformacionCliente.TabIndex = 23;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "Información Cliente";
            // 
            // TBIdCliente
            // 
            this.TBIdCliente.Location = new System.Drawing.Point(291, 35);
            this.TBIdCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBIdCliente.Name = "TBIdCliente";
            this.TBIdCliente.ReadOnly = true;
            this.TBIdCliente.Size = new System.Drawing.Size(45, 35);
            this.TBIdCliente.TabIndex = 35;
            this.TBIdCliente.Visible = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarCliente.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCliente.IconSize = 20;
            this.btnBuscarCliente.Location = new System.Drawing.Point(291, 98);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(48, 35);
            this.btnBuscarCliente.TabIndex = 6;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // TBNombreCompleto
            // 
            this.TBNombreCompleto.Location = new System.Drawing.Point(357, 98);
            this.TBNombreCompleto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBNombreCompleto.Name = "TBNombreCompleto";
            this.TBNombreCompleto.ReadOnly = true;
            this.TBNombreCompleto.Size = new System.Drawing.Size(234, 35);
            this.TBNombreCompleto.TabIndex = 5;
            this.TBNombreCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // TBNroDocumento
            // 
            this.TBNroDocumento.Location = new System.Drawing.Point(24, 98);
            this.TBNroDocumento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBNroDocumento.MaxLength = 8;
            this.TBNroDocumento.Name = "TBNroDocumento";
            this.TBNroDocumento.ReadOnly = true;
            this.TBNroDocumento.ShortcutsEnabled = false;
            this.TBNroDocumento.Size = new System.Drawing.Size(258, 35);
            this.TBNroDocumento.TabIndex = 4;
            this.TBNroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LNombreCompleto
            // 
            this.LNombreCompleto.AutoSize = true;
            this.LNombreCompleto.Location = new System.Drawing.Point(357, 66);
            this.LNombreCompleto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LNombreCompleto.Name = "LNombreCompleto";
            this.LNombreCompleto.Size = new System.Drawing.Size(234, 27);
            this.LNombreCompleto.TabIndex = 3;
            this.LNombreCompleto.Text = "Nombre Completo:";
            // 
            // LNroDocumento
            // 
            this.LNroDocumento.AutoSize = true;
            this.LNroDocumento.Location = new System.Drawing.Point(24, 66);
            this.LNroDocumento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LNroDocumento.Name = "LNroDocumento";
            this.LNroDocumento.Size = new System.Drawing.Size(258, 27);
            this.LNroDocumento.TabIndex = 2;
            this.LNroDocumento.Text = "Número Documento:";
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID_Producto";
            this.ID_Producto.MinimumWidth = 6;
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.ReadOnly = true;
            this.ID_Producto.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // nombreProd
            // 
            this.nombreProd.HeaderText = "Nombre";
            this.nombreProd.MinimumWidth = 6;
            this.nombreProd.Name = "nombreProd";
            this.nombreProd.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio";
            this.precioVenta.MinimumWidth = 6;
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.MinimumWidth = 6;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            // 
            // ID_venta
            // 
            this.ID_venta.HeaderText = "ID_venta";
            this.ID_venta.MinimumWidth = 6;
            this.ID_venta.Name = "ID_venta";
            this.ID_venta.ReadOnly = true;
            this.ID_venta.Visible = false;
            // 
            // registrarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 739);
            this.Controls.Add(this.listadoVentaProducto);
            this.Controls.Add(this.contenedorBotones);
            this.Controls.Add(this.contenedorInformacion);
            this.Controls.Add(this.contenedorRegistrarVenta);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "registrarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registrarVentas";
            this.Load += new System.EventHandler(this.registrarVentas_Load);
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
        private System.Windows.Forms.TextBox TBNombreProd;
        private System.Windows.Forms.TextBox TBCodigoProd;
        private System.Windows.Forms.Label LProducto;
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
        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.TextBox TBIdProducto;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.TextBox TBIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_venta;
    }
}