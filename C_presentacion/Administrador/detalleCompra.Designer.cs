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
            this.detalleCompraBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ProductoCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.contenedorDetalleCompra.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource2)).BeginInit();
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
            this.TBNumeroCompra.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNumeroCompra.Location = new System.Drawing.Point(1165, 120);
            this.TBNumeroCompra.Margin = new System.Windows.Forms.Padding(2);
            this.TBNumeroCompra.Name = "TBNumeroCompra";
            this.TBNumeroCompra.ReadOnly = true;
            this.TBNumeroCompra.Size = new System.Drawing.Size(216, 35);
            this.TBNumeroCompra.TabIndex = 26;
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
            this.btnLimpiar.Location = new System.Drawing.Point(1333, 163);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(48, 35);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscarNroCompra
            // 
            this.btnBuscarNroCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarNroCompra.BackColor = System.Drawing.Color.White;
            this.btnBuscarNroCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarNroCompra.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNroCompra.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarNroCompra.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarNroCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarNroCompra.IconSize = 20;
            this.btnBuscarNroCompra.Location = new System.Drawing.Point(1280, 163);
            this.btnBuscarNroCompra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBuscarNroCompra.Name = "btnBuscarNroCompra";
            this.btnBuscarNroCompra.Size = new System.Drawing.Size(48, 35);
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
            this.LdetalleCompra.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TBmontoTotal.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBmontoTotal.Location = new System.Drawing.Point(1050, 374);
            this.TBmontoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.TBmontoTotal.Name = "TBmontoTotal";
            this.TBmontoTotal.ReadOnly = true;
            this.TBmontoTotal.Size = new System.Drawing.Size(192, 35);
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
            this.groupBox2.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TBrazonSocial.Location = new System.Drawing.Point(437, 102);
            this.TBrazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.TBrazonSocial.Name = "TBrazonSocial";
            this.TBrazonSocial.ReadOnly = true;
            this.TBrazonSocial.Size = new System.Drawing.Size(243, 35);
            this.TBrazonSocial.TabIndex = 3;
            this.TBrazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razón Social:";
            // 
            // TBcuit
            // 
            this.TBcuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBcuit.Location = new System.Drawing.Point(115, 102);
            this.TBcuit.Margin = new System.Windows.Forms.Padding(2);
            this.TBcuit.Name = "TBcuit";
            this.TBcuit.ReadOnly = true;
            this.TBcuit.Size = new System.Drawing.Size(224, 35);
            this.TBcuit.TabIndex = 1;
            this.TBcuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cuit:";
            // 
            // LnumDoc
            // 
            this.LnumDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnumDoc.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnumDoc.ForeColor = System.Drawing.Color.DarkRed;
            this.LnumDoc.Location = new System.Drawing.Point(1165, 82);
            this.LnumDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LnumDoc.Name = "LnumDoc";
            this.LnumDoc.Size = new System.Drawing.Size(251, 29);
            this.LnumDoc.TabIndex = 3;
            this.LnumDoc.Text = "Número Compra:";
            this.LnumDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LmontoTotal
            // 
            this.LmontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LmontoTotal.AutoSize = true;
            this.LmontoTotal.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LmontoTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.LmontoTotal.Location = new System.Drawing.Point(1050, 341);
            this.LmontoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LmontoTotal.Name = "LmontoTotal";
            this.LmontoTotal.Size = new System.Drawing.Size(165, 27);
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
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TBNumFactura.Location = new System.Drawing.Point(593, 98);
            this.TBNumFactura.Margin = new System.Windows.Forms.Padding(2);
            this.TBNumFactura.Name = "TBNumFactura";
            this.TBNumFactura.ReadOnly = true;
            this.TBNumFactura.Size = new System.Drawing.Size(209, 35);
            this.TBNumFactura.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número factura:";
            // 
            // TBFecha
            // 
            this.TBFecha.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TBFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBFecha.Location = new System.Drawing.Point(99, 98);
            this.TBFecha.Margin = new System.Windows.Forms.Padding(2);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(207, 35);
            this.TBFecha.TabIndex = 7;
            // 
            // Lusuario
            // 
            this.Lusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lusuario.AutoSize = true;
            this.Lusuario.Location = new System.Drawing.Point(836, 65);
            this.Lusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lusuario.Name = "Lusuario";
            this.Lusuario.Size = new System.Drawing.Size(114, 27);
            this.Lusuario.TabIndex = 5;
            this.Lusuario.Text = "Usuario:";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBUsuario.Location = new System.Drawing.Point(836, 98);
            this.TBUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.ReadOnly = true;
            this.TBUsuario.Size = new System.Drawing.Size(209, 35);
            this.TBUsuario.TabIndex = 4;
            this.TBUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // TBtipoDoc
            // 
            this.TBtipoDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBtipoDoc.Location = new System.Drawing.Point(340, 98);
            this.TBtipoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.TBtipoDoc.Name = "TBtipoDoc";
            this.TBtipoDoc.ReadOnly = true;
            this.TBtipoDoc.Size = new System.Drawing.Size(217, 35);
            this.TBtipoDoc.TabIndex = 3;
            this.TBtipoDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo Documento:";
            // 
            // FechaCompraDetalle
            // 
            this.FechaCompraDetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FechaCompraDetalle.AutoSize = true;
            this.FechaCompraDetalle.Location = new System.Drawing.Point(99, 65);
            this.FechaCompraDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaCompraDetalle.Name = "FechaCompraDetalle";
            this.FechaCompraDetalle.Size = new System.Drawing.Size(91, 27);
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
            this.nombre,
            this.descripcion,
            this.precioCompra,
            this.precioVenta,
            this.cantidad,
            this.subtotal});
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
            // detalleCompraBindingSource2
            // 
            this.detalleCompraBindingSource2.DataSource = typeof(FankyRecords.C_entidad.DetalleCompra);
            // 
            // ProductoCodigo
            // 
            this.ProductoCodigo.DataPropertyName = "Obj_producto";
            this.ProductoCodigo.HeaderText = "Codigo";
            this.ProductoCodigo.MinimumWidth = 6;
            this.ProductoCodigo.Name = "ProductoCodigo";
            this.ProductoCodigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio Compra";
            this.precioCompra.MinimumWidth = 6;
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.ReadOnly = true;
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.MinimumWidth = 6;
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource2)).EndInit();
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
        private System.Windows.Forms.BindingSource detalleCompraBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}