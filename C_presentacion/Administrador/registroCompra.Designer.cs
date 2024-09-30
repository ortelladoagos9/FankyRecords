namespace FankyRecords.C_presentacion.Administrador
{
    partial class registroCompra
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
            this.subTotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenedorDatos = new System.Windows.Forms.Panel();
            this.gbInfoProducto = new System.Windows.Forms.GroupBox();
            this.cantProd = new System.Windows.Forms.NumericUpDown();
            this.LCantidad = new System.Windows.Forms.Label();
            this.LPrecio = new System.Windows.Forms.Label();
            this.TBprecio = new System.Windows.Forms.TextBox();
            this.TBproducto = new System.Windows.Forms.TextBox();
            this.LProducto = new System.Windows.Forms.Label();
            this.btnBuscarProd = new FontAwesome.Sharp.IconButton();
            this.TBcodProdunto = new System.Windows.Forms.TextBox();
            this.LCodProd = new System.Windows.Forms.Label();
            this.gbInfoProveedor = new System.Windows.Forms.GroupBox();
            this.btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.TBrazonSocial = new System.Windows.Forms.TextBox();
            this.TBcuit = new System.Windows.Forms.TextBox();
            this.LRazonSocial = new System.Windows.Forms.Label();
            this.LCuit = new System.Windows.Forms.Label();
            this.gbInfoCompra = new System.Windows.Forms.GroupBox();
            this.dtFechaCompra = new System.Windows.Forms.DateTimePicker();
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
            this.contenedorRegistrarCompra.Size = new System.Drawing.Size(1182, 56);
            this.contenedorRegistrarCompra.TabIndex = 0;
            // 
            // LRegistrarCompra
            // 
            this.LRegistrarCompra.Dock = System.Windows.Forms.DockStyle.Left;
            this.LRegistrarCompra.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistrarCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.LRegistrarCompra.Location = new System.Drawing.Point(0, 0);
            this.LRegistrarCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LRegistrarCompra.Name = "LRegistrarCompra";
            this.LRegistrarCompra.Size = new System.Drawing.Size(239, 56);
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
            this.contenedorBotones.Controls.Add(this.btnAgregarProd);
            this.contenedorBotones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contenedorBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.contenedorBotones.Location = new System.Drawing.Point(921, 56);
            this.contenedorBotones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorBotones.Name = "contenedorBotones";
            this.contenedorBotones.Size = new System.Drawing.Size(261, 598);
            this.contenedorBotones.TabIndex = 1;
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.BackColor = System.Drawing.Color.White;
            this.btnRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCompra.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnRegistrarCompra.IconColor = System.Drawing.Color.DarkRed;
            this.btnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(29, 529);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(182, 48);
            this.btnRegistrarCompra.TabIndex = 3;
            this.btnRegistrarCompra.Text = "Registrar";
            this.btnRegistrarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarCompra.UseVisualStyleBackColor = false;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.registrarCompra_Click);
            // 
            // TBtotalPagar
            // 
            this.TBtotalPagar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtotalPagar.Location = new System.Drawing.Point(29, 491);
            this.TBtotalPagar.Name = "TBtotalPagar";
            this.TBtotalPagar.Size = new System.Drawing.Size(182, 24);
            this.TBtotalPagar.TabIndex = 2;
            // 
            // LTotalPagar
            // 
            this.LTotalPagar.AutoSize = true;
            this.LTotalPagar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalPagar.ForeColor = System.Drawing.Color.DarkRed;
            this.LTotalPagar.Location = new System.Drawing.Point(25, 469);
            this.LTotalPagar.Name = "LTotalPagar";
            this.LTotalPagar.Size = new System.Drawing.Size(127, 21);
            this.LTotalPagar.TabIndex = 1;
            this.LTotalPagar.Text = "Total a Pagar";
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.BackColor = System.Drawing.Color.White;
            this.btnAgregarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProd.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAgregarProd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarProd.IconColor = System.Drawing.Color.DarkRed;
            this.btnAgregarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProd.Location = new System.Drawing.Point(48, 178);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(122, 94);
            this.btnAgregarProd.TabIndex = 0;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            this.btnAgregarProd.Click += new System.EventHandler(this.BAgregarProd_Click);
            // 
            // listaCompras
            // 
            this.listaCompras.BackgroundColor = System.Drawing.Color.White;
            this.listaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProducto,
            this.nombreProducto,
            this.precioCompra,
            this.cantidadProducto,
            this.subTotalProducto});
            this.listaCompras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaCompras.Location = new System.Drawing.Point(0, 445);
            this.listaCompras.Name = "listaCompras";
            this.listaCompras.RowHeadersWidth = 51;
            this.listaCompras.Size = new System.Drawing.Size(921, 209);
            this.listaCompras.TabIndex = 2;
            // 
            // panel3
            // 
            this.codigoProducto.HeaderText = "Código";
            this.codigoProducto.MinimumWidth = 6;
            this.codigoProducto.Name = "codigoProducto";
            this.codigoProducto.Width = 130;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.MinimumWidth = 6;
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Width = 300;
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio Compra";
            this.precioCompra.MinimumWidth = 6;
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.Width = 150;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "Cantidad";
            this.cantidadProducto.MinimumWidth = 6;
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.Width = 150;
            // 
            // subTotalProducto
            // 
            this.subTotalProducto.HeaderText = "Subtotal";
            this.subTotalProducto.MinimumWidth = 6;
            this.subTotalProducto.Name = "subTotalProducto";
            this.subTotalProducto.Width = 150;
            // 
            // contenedorDatos
            // 
            this.contenedorDatos.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDatos.Controls.Add(this.gbInfoProducto);
            this.contenedorDatos.Controls.Add(this.gbInfoProveedor);
            this.contenedorDatos.Controls.Add(this.gbInfoCompra);
            this.contenedorDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorDatos.Location = new System.Drawing.Point(0, 56);
            this.contenedorDatos.Name = "contenedorDatos";
            this.contenedorDatos.Size = new System.Drawing.Size(921, 389);
            this.contenedorDatos.TabIndex = 3;
            // 
            // gbInfoProducto
            // 
            this.gbInfoProducto.Controls.Add(this.cantProd);
            this.gbInfoProducto.Controls.Add(this.LCantidad);
            this.gbInfoProducto.Controls.Add(this.LPrecio);
            this.gbInfoProducto.Controls.Add(this.TBprecio);
            this.gbInfoProducto.Controls.Add(this.TBproducto);
            this.gbInfoProducto.Controls.Add(this.LProducto);
            this.gbInfoProducto.Controls.Add(this.btnBuscarProd);
            this.gbInfoProducto.Controls.Add(this.TBcodProdunto);
            this.gbInfoProducto.Controls.Add(this.LCodProd);
            this.gbInfoProducto.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProducto.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInfoProducto.Location = new System.Drawing.Point(9, 178);
            this.gbInfoProducto.Name = "gbInfoProducto";
            this.gbInfoProducto.Size = new System.Drawing.Size(884, 193);
            this.gbInfoProducto.TabIndex = 5;
            this.gbInfoProducto.TabStop = false;
            this.gbInfoProducto.Text = "Información de Productos";
            // 
            // cantProd
            // 
            this.cantProd.Location = new System.Drawing.Point(731, 84);
            this.cantProd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantProd.Name = "cantProd";
            this.cantProd.Size = new System.Drawing.Size(120, 24);
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
            this.LCantidad.Location = new System.Drawing.Point(736, 53);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(90, 21);
            this.LCantidad.TabIndex = 10;
            this.LCantidad.Text = "Cantidad";
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Location = new System.Drawing.Point(571, 53);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(67, 21);
            this.LPrecio.TabIndex = 9;
            this.LPrecio.Text = "Precio";
            // 
            // TBprecio
            // 
            this.TBprecio.Location = new System.Drawing.Point(575, 83);
            this.TBprecio.Name = "TBprecio";
            this.TBprecio.Size = new System.Drawing.Size(114, 24);
            this.TBprecio.TabIndex = 8;
            this.TBprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // TBproducto
            // 
            this.TBproducto.Location = new System.Drawing.Point(237, 84);
            this.TBproducto.Name = "TBproducto";
            this.TBproducto.ReadOnly = true;
            this.TBproducto.Size = new System.Drawing.Size(277, 28);
            this.TBproducto.TabIndex = 7;
            this.TBproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Location = new System.Drawing.Point(233, 53);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(91, 21);
            this.LProducto.TabIndex = 6;
            this.LProducto.Text = "Producto";
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.Color.White;
            this.btnBuscarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProd.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProd.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProd.IconSize = 20;
            this.btnBuscarProd.Location = new System.Drawing.Point(151, 83);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(34, 27);
            this.btnBuscarProd.TabIndex = 5;
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            // 
            // TBcodProdunto
            // 
            this.TBcodProdunto.Location = new System.Drawing.Point(10, 84);
            this.TBcodProdunto.Name = "TBcodProdunto";
            this.TBcodProdunto.Size = new System.Drawing.Size(135, 24);
            this.TBcodProdunto.TabIndex = 1;
            this.TBcodProdunto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LCodProd
            // 
            this.LCodProd.AutoSize = true;
            this.LCodProd.Location = new System.Drawing.Point(6, 53);
            this.LCodProd.Name = "LCodProd";
            this.LCodProd.Size = new System.Drawing.Size(156, 21);
            this.LCodProd.TabIndex = 0;
            this.LCodProd.Text = "Código Producto";
            // 
            // gbInfoProveedor
            // 
            this.gbInfoProveedor.Controls.Add(this.btnBuscarProveedor);
            this.gbInfoProveedor.Controls.Add(this.TBrazonSocial);
            this.gbInfoProveedor.Controls.Add(this.TBcuit);
            this.gbInfoProveedor.Controls.Add(this.LRazonSocial);
            this.gbInfoProveedor.Controls.Add(this.LCuit);
            this.gbInfoProveedor.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProveedor.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInfoProveedor.Location = new System.Drawing.Point(454, 17);
            this.gbInfoProveedor.Name = "gbInfoProveedor";
            this.gbInfoProveedor.Size = new System.Drawing.Size(445, 100);
            this.gbInfoProveedor.TabIndex = 4;
            this.gbInfoProveedor.TabStop = false;
            this.gbInfoProveedor.Text = "Información Proveedor";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProveedor.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProveedor.IconSize = 20;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(167, 54);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(34, 27);
            this.btnBuscarProveedor.TabIndex = 4;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            // 
            // TBrazonSocial
            // 
            this.TBrazonSocial.Location = new System.Drawing.Point(240, 54);
            this.TBrazonSocial.Name = "TBrazonSocial";
            this.TBrazonSocial.ReadOnly = true;
            this.TBrazonSocial.Size = new System.Drawing.Size(199, 24);
            this.TBrazonSocial.TabIndex = 3;
            this.TBrazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // TBcuit
            // 
            this.TBcuit.Location = new System.Drawing.Point(31, 54);
            this.TBcuit.Name = "TBcuit";
            this.TBcuit.Size = new System.Drawing.Size(130, 28);
            this.TBcuit.TabIndex = 2;
            this.TBcuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LRazonSocial
            // 
            this.LRazonSocial.AutoSize = true;
            this.LRazonSocial.Location = new System.Drawing.Point(236, 32);
            this.LRazonSocial.Name = "LRazonSocial";
            this.LRazonSocial.Size = new System.Drawing.Size(122, 21);
            this.LRazonSocial.TabIndex = 1;
            this.LRazonSocial.Text = "Razón Social";
            // 
            // LCuit
            // 
            this.LCuit.AutoSize = true;
            this.LCuit.Location = new System.Drawing.Point(27, 32);
            this.LCuit.Name = "LCuit";
            this.LCuit.Size = new System.Drawing.Size(48, 21);
            this.LCuit.TabIndex = 0;
            this.LCuit.Text = "Cuit";
            // 
            // gbInfoCompra
            // 
            this.gbInfoCompra.Controls.Add(this.dtFechaCompra);
            this.gbInfoCompra.Controls.Add(this.cbTipoDoc);
            this.gbInfoCompra.Controls.Add(this.LTipoDoc);
            this.gbInfoCompra.Controls.Add(this.LFechaCompra);
            this.gbInfoCompra.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInfoCompra.Location = new System.Drawing.Point(9, 17);
            this.gbInfoCompra.Name = "gbInfoCompra";
            this.gbInfoCompra.Size = new System.Drawing.Size(426, 100);
            this.gbInfoCompra.TabIndex = 3;
            this.gbInfoCompra.TabStop = false;
            this.gbInfoCompra.Text = "información compra";
            // 
            // dtFechaCompra
            // 
            this.dtFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaCompra.Location = new System.Drawing.Point(10, 57);
            this.dtFechaCompra.Name = "dtFechaCompra";
            this.dtFechaCompra.Size = new System.Drawing.Size(157, 28);
            this.dtFechaCompra.TabIndex = 6;
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Items.AddRange(new object[] {
            "Factura",
            "Remito"});
            this.cbTipoDoc.Location = new System.Drawing.Point(192, 54);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(157, 29);
            this.cbTipoDoc.TabIndex = 3;
            this.cbTipoDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // LTipoDoc
            // 
            this.LTipoDoc.AutoSize = true;
            this.LTipoDoc.Location = new System.Drawing.Point(188, 32);
            this.LTipoDoc.Name = "LTipoDoc";
            this.LTipoDoc.Size = new System.Drawing.Size(153, 21);
            this.LTipoDoc.TabIndex = 1;
            this.LTipoDoc.Text = "Tipo Documento";
            // 
            // LFechaCompra
            // 
            this.LFechaCompra.AutoSize = true;
            this.LFechaCompra.Location = new System.Drawing.Point(21, 32);
            this.LFechaCompra.Name = "LFechaCompra";
            this.LFechaCompra.Size = new System.Drawing.Size(63, 21);
            this.LFechaCompra.TabIndex = 0;
            this.LFechaCompra.Text = "Fecha";
            // 
            // registroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.contenedorDatos);
            this.Controls.Add(this.listaCompras);
            this.Controls.Add(this.contenedorBotones);
            this.Controls.Add(this.contenedorRegistrarCompra);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "registroCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private FontAwesome.Sharp.IconButton btnBuscarProd;
        private System.Windows.Forms.TextBox TBcodProdunto;
        private System.Windows.Forms.Label LCodProd;
        private System.Windows.Forms.NumericUpDown cantProd;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.TextBox TBprecio;
        private System.Windows.Forms.TextBox TBproducto;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.DateTimePicker dtFechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalProducto;
    }
}