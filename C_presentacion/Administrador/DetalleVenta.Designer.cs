namespace FankyRecords.C_presentacion.Administrador
{
    partial class detalleVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contenedor = new System.Windows.Forms.Panel();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.TBNroVenta = new System.Windows.Forms.TextBox();
            this.TBTotalPagado = new System.Windows.Forms.TextBox();
            this.LTotalPagado = new System.Windows.Forms.Label();
            this.LNroDoc = new System.Windows.Forms.Label();
            this.gbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.TBNombreCompleto = new System.Windows.Forms.TextBox();
            this.TBNroDocumento = new System.Windows.Forms.TextBox();
            this.LNombreCompleto = new System.Windows.Forms.Label();
            this.LNroDocumento = new System.Windows.Forms.Label();
            this.gbInformacionVentas = new System.Windows.Forms.GroupBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBTipoDoc = new System.Windows.Forms.TextBox();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.LTipoDoc = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.contenedorRegistrarVenta = new System.Windows.Forms.Panel();
            this.LDetalleVenta = new System.Windows.Forms.Label();
            this.listadoVentas = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenedor.SuspendLayout();
            this.gbInformacionCliente.SuspendLayout();
            this.gbInformacionVentas.SuspendLayout();
            this.contenedorRegistrarVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedor.Controls.Add(this.btnLimpiar);
            this.contenedor.Controls.Add(this.btnBuscar);
            this.contenedor.Controls.Add(this.TBNroVenta);
            this.contenedor.Controls.Add(this.TBTotalPagado);
            this.contenedor.Controls.Add(this.LTotalPagado);
            this.contenedor.Controls.Add(this.LNroDoc);
            this.contenedor.Controls.Add(this.gbInformacionCliente);
            this.contenedor.Controls.Add(this.gbInformacionVentas);
            this.contenedor.Controls.Add(this.contenedorRegistrarVenta);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contenedor.ForeColor = System.Drawing.Color.DarkRed;
            this.contenedor.Location = new System.Drawing.Point(0, 0);
            this.contenedor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1418, 739);
            this.contenedor.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 20;
            this.btnLimpiar.Location = new System.Drawing.Point(1330, 160);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(48, 35);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(1275, 160);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 35);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TBNroVenta
            // 
            this.TBNroVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBNroVenta.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNroVenta.Location = new System.Drawing.Point(1173, 116);
            this.TBNroVenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBNroVenta.Name = "TBNroVenta";
            this.TBNroVenta.ReadOnly = true;
            this.TBNroVenta.ShortcutsEnabled = false;
            this.TBNroVenta.Size = new System.Drawing.Size(205, 35);
            this.TBNroVenta.TabIndex = 41;
            this.TBNroVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // TBTotalPagado
            // 
            this.TBTotalPagado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TBTotalPagado.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTotalPagado.Location = new System.Drawing.Point(1002, 388);
            this.TBTotalPagado.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBTotalPagado.Name = "TBTotalPagado";
            this.TBTotalPagado.ReadOnly = true;
            this.TBTotalPagado.Size = new System.Drawing.Size(193, 35);
            this.TBTotalPagado.TabIndex = 34;
            // 
            // LTotalPagado
            // 
            this.LTotalPagado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LTotalPagado.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LTotalPagado.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalPagado.ForeColor = System.Drawing.Color.DarkRed;
            this.LTotalPagado.Location = new System.Drawing.Point(1002, 353);
            this.LTotalPagado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LTotalPagado.Name = "LTotalPagado";
            this.LTotalPagado.Size = new System.Drawing.Size(211, 30);
            this.LTotalPagado.TabIndex = 33;
            this.LTotalPagado.Text = "Total pagado:";
            // 
            // LNroDoc
            // 
            this.LNroDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LNroDoc.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LNroDoc.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNroDoc.ForeColor = System.Drawing.Color.DarkRed;
            this.LNroDoc.Location = new System.Drawing.Point(1168, 83);
            this.LNroDoc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LNroDoc.Name = "LNroDoc";
            this.LNroDoc.Size = new System.Drawing.Size(239, 30);
            this.LNroDoc.TabIndex = 40;
            this.LNroDoc.Text = "Número Factura:";
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInformacionCliente.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.gbInformacionCliente.Controls.Add(this.TBNombreCompleto);
            this.gbInformacionCliente.Controls.Add(this.TBNroDocumento);
            this.gbInformacionCliente.Controls.Add(this.LNombreCompleto);
            this.gbInformacionCliente.Controls.Add(this.LNroDocumento);
            this.gbInformacionCliente.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInformacionCliente.Location = new System.Drawing.Point(29, 286);
            this.gbInformacionCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInformacionCliente.Size = new System.Drawing.Size(750, 182);
            this.gbInformacionCliente.TabIndex = 24;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "Información Cliente";
            // 
            // TBNombreCompleto
            // 
            this.TBNombreCompleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBNombreCompleto.Location = new System.Drawing.Point(418, 103);
            this.TBNombreCompleto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBNombreCompleto.Name = "TBNombreCompleto";
            this.TBNombreCompleto.ReadOnly = true;
            this.TBNombreCompleto.Size = new System.Drawing.Size(255, 35);
            this.TBNombreCompleto.TabIndex = 5;
            // 
            // TBNroDocumento
            // 
            this.TBNroDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBNroDocumento.Location = new System.Drawing.Point(100, 103);
            this.TBNroDocumento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBNroDocumento.Name = "TBNroDocumento";
            this.TBNroDocumento.ReadOnly = true;
            this.TBNroDocumento.Size = new System.Drawing.Size(255, 35);
            this.TBNroDocumento.TabIndex = 4;
            // 
            // LNombreCompleto
            // 
            this.LNombreCompleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LNombreCompleto.AutoSize = true;
            this.LNombreCompleto.Location = new System.Drawing.Point(418, 70);
            this.LNombreCompleto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LNombreCompleto.Name = "LNombreCompleto";
            this.LNombreCompleto.Size = new System.Drawing.Size(207, 27);
            this.LNombreCompleto.TabIndex = 3;
            this.LNombreCompleto.Text = "Nombre Cliente:";
            // 
            // LNroDocumento
            // 
            this.LNroDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LNroDocumento.AutoSize = true;
            this.LNroDocumento.Location = new System.Drawing.Point(100, 70);
            this.LNroDocumento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LNroDocumento.Name = "LNroDocumento";
            this.LNroDocumento.Size = new System.Drawing.Size(160, 27);
            this.LNroDocumento.TabIndex = 2;
            this.LNroDocumento.Text = "DNI Cliente:";
            // 
            // gbInformacionVentas
            // 
            this.gbInformacionVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInformacionVentas.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.gbInformacionVentas.Controls.Add(this.LUsuario);
            this.gbInformacionVentas.Controls.Add(this.TBUsuario);
            this.gbInformacionVentas.Controls.Add(this.TBTipoDoc);
            this.gbInformacionVentas.Controls.Add(this.TBFecha);
            this.gbInformacionVentas.Controls.Add(this.LTipoDoc);
            this.gbInformacionVentas.Controls.Add(this.LFecha);
            this.gbInformacionVentas.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionVentas.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInformacionVentas.Location = new System.Drawing.Point(29, 83);
            this.gbInformacionVentas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInformacionVentas.Name = "gbInformacionVentas";
            this.gbInformacionVentas.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInformacionVentas.Size = new System.Drawing.Size(1115, 182);
            this.gbInformacionVentas.TabIndex = 23;
            this.gbInformacionVentas.TabStop = false;
            this.gbInformacionVentas.Text = "Información Venta";
            // 
            // LUsuario
            // 
            this.LUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(743, 62);
            this.LUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(114, 27);
            this.LUsuario.TabIndex = 9;
            this.LUsuario.Text = "Usuario:";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBUsuario.Location = new System.Drawing.Point(743, 97);
            this.TBUsuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.ReadOnly = true;
            this.TBUsuario.Size = new System.Drawing.Size(255, 35);
            this.TBUsuario.TabIndex = 8;
            // 
            // TBTipoDoc
            // 
            this.TBTipoDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBTipoDoc.Location = new System.Drawing.Point(418, 97);
            this.TBTipoDoc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBTipoDoc.Name = "TBTipoDoc";
            this.TBTipoDoc.ReadOnly = true;
            this.TBTipoDoc.Size = new System.Drawing.Size(255, 35);
            this.TBTipoDoc.TabIndex = 7;
            // 
            // TBFecha
            // 
            this.TBFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBFecha.Location = new System.Drawing.Point(100, 97);
            this.TBFecha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(255, 35);
            this.TBFecha.TabIndex = 6;
            // 
            // LTipoDoc
            // 
            this.LTipoDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LTipoDoc.AutoSize = true;
            this.LTipoDoc.Location = new System.Drawing.Point(418, 62);
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
            this.LFecha.Location = new System.Drawing.Point(100, 62);
            this.LFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(91, 27);
            this.LFecha.TabIndex = 2;
            this.LFecha.Text = "Fecha:";
            // 
            // contenedorRegistrarVenta
            // 
            this.contenedorRegistrarVenta.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorRegistrarVenta.Controls.Add(this.LDetalleVenta);
            this.contenedorRegistrarVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorRegistrarVenta.Location = new System.Drawing.Point(0, 0);
            this.contenedorRegistrarVenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.contenedorRegistrarVenta.Name = "contenedorRegistrarVenta";
            this.contenedorRegistrarVenta.Size = new System.Drawing.Size(1418, 75);
            this.contenedorRegistrarVenta.TabIndex = 39;
            // 
            // LDetalleVenta
            // 
            this.LDetalleVenta.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LDetalleVenta.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalleVenta.ForeColor = System.Drawing.Color.DarkRed;
            this.LDetalleVenta.Location = new System.Drawing.Point(0, 0);
            this.LDetalleVenta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LDetalleVenta.Name = "LDetalleVenta";
            this.LDetalleVenta.Size = new System.Drawing.Size(1418, 75);
            this.LDetalleVenta.TabIndex = 0;
            this.LDetalleVenta.Text = "Detalle Venta";
            this.LDetalleVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // listadoVentas
            // 
            this.listadoVentas.AllowUserToAddRows = false;
            this.listadoVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listadoVentas.BackgroundColor = System.Drawing.Color.White;
            this.listadoVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.listadoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.producto,
            this.precio,
            this.cantidad,
            this.nombre_cliente,
            this.fecha,
            this.subtotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoVentas.DefaultCellStyle = dataGridViewCellStyle6;
            this.listadoVentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoVentas.Location = new System.Drawing.Point(0, 496);
            this.listadoVentas.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listadoVentas.Name = "listadoVentas";
            this.listadoVentas.ReadOnly = true;
            this.listadoVentas.RowHeadersWidth = 51;
            this.listadoVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoVentas.Size = new System.Drawing.Size(1418, 243);
            this.listadoVentas.TabIndex = 21;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio Venta";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.HeaderText = "Nombre Cliente";
            this.nombre_cliente.MinimumWidth = 6;
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // detalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 739);
            this.Controls.Add(this.listadoVentas);
            this.Controls.Add(this.contenedor);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "detalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            this.gbInformacionCliente.ResumeLayout(false);
            this.gbInformacionCliente.PerformLayout();
            this.gbInformacionVentas.ResumeLayout(false);
            this.gbInformacionVentas.PerformLayout();
            this.contenedorRegistrarVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        public System.Windows.Forms.DataGridView listadoVentas;
        private System.Windows.Forms.GroupBox gbInformacionVentas;
        private System.Windows.Forms.Label LTipoDoc;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.GroupBox gbInformacionCliente;
        private System.Windows.Forms.TextBox TBNombreCompleto;
        private System.Windows.Forms.TextBox TBNroDocumento;
        private System.Windows.Forms.Label LNombreCompleto;
        private System.Windows.Forms.Label LNroDocumento;
        private System.Windows.Forms.TextBox TBTotalPagado;
        private System.Windows.Forms.Label LTotalPagado;
        public System.Windows.Forms.Panel contenedorRegistrarVenta;
        public System.Windows.Forms.Label LDetalleVenta;
        public FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox TBNroVenta;
        private System.Windows.Forms.Label LNroDoc;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBTipoDoc;
        private System.Windows.Forms.TextBox TBFecha;
        private System.Windows.Forms.Label LUsuario;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}