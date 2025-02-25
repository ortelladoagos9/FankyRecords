namespace FankyRecords.C_presentacion.Administrador
{
    partial class detalleCompra
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBNumeroCompra = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscarNroCompra = new FontAwesome.Sharp.IconButton();
            this.contenedorDetalleCompra = new System.Windows.Forms.Panel();
            this.LdetalleCompra = new System.Windows.Forms.Label();
            this.TBmontoTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBrazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBcuit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LnumDoc = new System.Windows.Forms.Label();
            this.LmontoTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBNumFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.Lusuario = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBtipoDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaCompraDetalle = new System.Windows.Forms.Label();
            this.listadoCompras = new System.Windows.Forms.DataGridView();
            this.ProductoCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleCompraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detalleCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.contenedorDetalleCompra.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBNumeroCompra);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnBuscarNroCompra);
            this.panel1.Controls.Add(this.contenedorDetalleCompra);
            this.panel1.Controls.Add(this.TBmontoTotal);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.LnumDoc);
            this.panel1.Controls.Add(this.LmontoTotal);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1418, 508);
            this.panel1.TabIndex = 0;
            // 
            // TBNumeroCompra
            // 
            this.TBNumeroCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBNumeroCompra.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNumeroCompra.Location = new System.Drawing.Point(1199, 112);
            this.TBNumeroCompra.Margin = new System.Windows.Forms.Padding(2);
            this.TBNumeroCompra.Name = "TBNumeroCompra";
            this.TBNumeroCompra.ReadOnly = true;
            this.TBNumeroCompra.Size = new System.Drawing.Size(182, 29);
            this.TBNumeroCompra.TabIndex = 26;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 20;
            this.btnLimpiar.Location = new System.Drawing.Point(1343, 154);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(38, 29);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscarNroCompra
            // 
            this.btnBuscarNroCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarNroCompra.BackColor = System.Drawing.Color.White;
            this.btnBuscarNroCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarNroCompra.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarNroCompra.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarNroCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarNroCompra.IconSize = 20;
            this.btnBuscarNroCompra.Location = new System.Drawing.Point(1296, 154);
            this.btnBuscarNroCompra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBuscarNroCompra.Name = "btnBuscarNroCompra";
            this.btnBuscarNroCompra.Size = new System.Drawing.Size(38, 29);
            this.btnBuscarNroCompra.TabIndex = 24;
            this.btnBuscarNroCompra.UseVisualStyleBackColor = false;
            this.btnBuscarNroCompra.Click += new System.EventHandler(this.btnBuscarNroCompra_Click);
            // 
            // contenedorDetalleCompra
            // 
            this.contenedorDetalleCompra.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDetalleCompra.Controls.Add(this.LdetalleCompra);
            this.contenedorDetalleCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorDetalleCompra.Location = new System.Drawing.Point(0, 0);
            this.contenedorDetalleCompra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.contenedorDetalleCompra.Name = "contenedorDetalleCompra";
            this.contenedorDetalleCompra.Size = new System.Drawing.Size(1418, 62);
            this.contenedorDetalleCompra.TabIndex = 23;
            // 
            // LdetalleCompra
            // 
            this.LdetalleCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LdetalleCompra.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LdetalleCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.LdetalleCompra.Location = new System.Drawing.Point(0, 0);
            this.LdetalleCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LdetalleCompra.Name = "LdetalleCompra";
            this.LdetalleCompra.Size = new System.Drawing.Size(1418, 62);
            this.LdetalleCompra.TabIndex = 2;
            this.LdetalleCompra.Text = "Detalle Compra";
            this.LdetalleCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TBmontoTotal
            // 
            this.TBmontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBmontoTotal.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBmontoTotal.Location = new System.Drawing.Point(1052, 374);
            this.TBmontoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.TBmontoTotal.Name = "TBmontoTotal";
            this.TBmontoTotal.ReadOnly = true;
            this.TBmontoTotal.Size = new System.Drawing.Size(192, 29);
            this.TBmontoTotal.TabIndex = 11;
            this.TBmontoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TBrazonSocial);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TBcuit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(22, 272);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(815, 182);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Proveedor";
            // 
            // TBrazonSocial
            // 
            this.TBrazonSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBrazonSocial.Location = new System.Drawing.Point(454, 101);
            this.TBrazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.TBrazonSocial.Name = "TBrazonSocial";
            this.TBrazonSocial.ReadOnly = true;
            this.TBrazonSocial.Size = new System.Drawing.Size(243, 29);
            this.TBrazonSocial.TabIndex = 3;
            this.TBrazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razón Social:";
            // 
            // TBcuit
            // 
            this.TBcuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBcuit.Location = new System.Drawing.Point(132, 101);
            this.TBcuit.Margin = new System.Windows.Forms.Padding(2);
            this.TBcuit.Name = "TBcuit";
            this.TBcuit.ReadOnly = true;
            this.TBcuit.Size = new System.Drawing.Size(224, 29);
            this.TBcuit.TabIndex = 1;
            this.TBcuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cuit:";
            // 
            // LnumDoc
            // 
            this.LnumDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnumDoc.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnumDoc.ForeColor = System.Drawing.Color.DarkRed;
            this.LnumDoc.Location = new System.Drawing.Point(1199, 82);
            this.LnumDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LnumDoc.Name = "LnumDoc";
            this.LnumDoc.Size = new System.Drawing.Size(182, 29);
            this.LnumDoc.TabIndex = 3;
            this.LnumDoc.Text = "Número Compra:";
            this.LnumDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LmontoTotal
            // 
            this.LmontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LmontoTotal.AutoSize = true;
            this.LmontoTotal.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LmontoTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.LmontoTotal.Location = new System.Drawing.Point(1052, 348);
            this.LmontoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LmontoTotal.Name = "LmontoTotal";
            this.LmontoTotal.Size = new System.Drawing.Size(129, 21);
            this.LmontoTotal.TabIndex = 10;
            this.LmontoTotal.Text = "Monto Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TBNumFactura);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TBFecha);
            this.groupBox1.Controls.Add(this.Lusuario);
            this.groupBox1.Controls.Add(this.TBUsuario);
            this.groupBox1.Controls.Add(this.TBtipoDoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FechaCompraDetalle);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(22, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1115, 182);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra";
            // 
            // TBNumFactura
            // 
            this.TBNumFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBNumFactura.Location = new System.Drawing.Point(574, 96);
            this.TBNumFactura.Margin = new System.Windows.Forms.Padding(2);
            this.TBNumFactura.Name = "TBNumFactura";
            this.TBNumFactura.ReadOnly = true;
            this.TBNumFactura.Size = new System.Drawing.Size(194, 29);
            this.TBNumFactura.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número factura:";
            // 
            // TBFecha
            // 
            this.TBFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBFecha.Location = new System.Drawing.Point(107, 96);
            this.TBFecha.Margin = new System.Windows.Forms.Padding(2);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(185, 29);
            this.TBFecha.TabIndex = 7;
            // 
            // Lusuario
            // 
            this.Lusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lusuario.AutoSize = true;
            this.Lusuario.Location = new System.Drawing.Point(808, 71);
            this.Lusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lusuario.Name = "Lusuario";
            this.Lusuario.Size = new System.Drawing.Size(89, 21);
            this.Lusuario.TabIndex = 5;
            this.Lusuario.Text = "Usuario:";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBUsuario.Location = new System.Drawing.Point(808, 96);
            this.TBUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.ReadOnly = true;
            this.TBUsuario.Size = new System.Drawing.Size(185, 29);
            this.TBUsuario.TabIndex = 4;
            this.TBUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // TBtipoDoc
            // 
            this.TBtipoDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBtipoDoc.Location = new System.Drawing.Point(332, 96);
            this.TBtipoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.TBtipoDoc.Name = "TBtipoDoc";
            this.TBtipoDoc.ReadOnly = true;
            this.TBtipoDoc.Size = new System.Drawing.Size(202, 29);
            this.TBtipoDoc.TabIndex = 3;
            this.TBtipoDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo Documento:";
            // 
            // FechaCompraDetalle
            // 
            this.FechaCompraDetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FechaCompraDetalle.AutoSize = true;
            this.FechaCompraDetalle.Location = new System.Drawing.Point(107, 71);
            this.FechaCompraDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaCompraDetalle.Name = "FechaCompraDetalle";
            this.FechaCompraDetalle.Size = new System.Drawing.Size(71, 21);
            this.FechaCompraDetalle.TabIndex = 1;
            this.FechaCompraDetalle.Text = "Fecha:";
            // 
            // listadoCompras
            // 
            this.listadoCompras.AllowUserToAddRows = false;
            this.listadoCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listadoCompras.BackgroundColor = System.Drawing.Color.White;
            this.listadoCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoCodigo,
            this.ProductoNombre,
            this.PrecioCompra,
            this.Cantidad,
            this.Subtotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.listadoCompras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoCompras.Location = new System.Drawing.Point(0, 508);
            this.listadoCompras.Margin = new System.Windows.Forms.Padding(2);
            this.listadoCompras.Name = "listadoCompras";
            this.listadoCompras.ReadOnly = true;
            this.listadoCompras.RowHeadersWidth = 51;
            this.listadoCompras.Size = new System.Drawing.Size(1418, 231);
            this.listadoCompras.TabIndex = 1;
            // 
            // ProductoCodigo
            // 
            this.ProductoCodigo.DataPropertyName = "ProductoCodigo";
            this.ProductoCodigo.HeaderText = "Código";
            this.ProductoCodigo.MinimumWidth = 6;
            this.ProductoCodigo.Name = "ProductoCodigo";
            this.ProductoCodigo.ReadOnly = true;
            // 
            // ProductoNombre
            // 
            this.ProductoNombre.DataPropertyName = "ProductoNombre";
            this.ProductoNombre.HeaderText = "Producto";
            this.ProductoNombre.MinimumWidth = 6;
            this.ProductoNombre.Name = "ProductoNombre";
            this.ProductoNombre.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // detalleCompraBindingSource1
            // 
            this.detalleCompraBindingSource1.DataSource = typeof(FankyRecords.C_entidad.DetalleCompra);
            // 
            // detalleCompraBindingSource
            // 
            this.detalleCompraBindingSource.DataSource = typeof(FankyRecords.C_entidad.DetalleCompra);
            // 
            // detalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1418, 739);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listadoCompras);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "detalleCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "detalleCompra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contenedorDetalleCompra.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView listadoCompras;
        private System.Windows.Forms.Label LdetalleCompra;
        private System.Windows.Forms.Label LnumDoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label FechaCompraDetalle;
        private System.Windows.Forms.TextBox TBtipoDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBcuit;
        private System.Windows.Forms.TextBox TBrazonSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LmontoTotal;
        private System.Windows.Forms.TextBox TBmontoTotal;
        public System.Windows.Forms.Panel contenedorDetalleCompra;
        public FontAwesome.Sharp.IconButton btnBuscarNroCompra;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.TextBox TBFecha;
        private System.Windows.Forms.Label Lusuario;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBNumFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBNumeroCompra;
        private System.Windows.Forms.BindingSource detalleCompraBindingSource;
        private System.Windows.Forms.BindingSource detalleCompraBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}