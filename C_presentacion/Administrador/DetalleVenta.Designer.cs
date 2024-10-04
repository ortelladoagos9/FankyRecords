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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contenedor = new System.Windows.Forms.Panel();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.TBNroDoc = new System.Windows.Forms.TextBox();
            this.LNroDoc = new System.Windows.Forms.Label();
            this.contenedorRegistrarVenta = new System.Windows.Forms.Panel();
            this.LDetalleVenta = new System.Windows.Forms.Label();
            this.TBCambio = new System.Windows.Forms.TextBox();
            this.TBRecibe = new System.Windows.Forms.TextBox();
            this.LCambio = new System.Windows.Forms.Label();
            this.LRecibe = new System.Windows.Forms.Label();
            this.TBTotalAPagar = new System.Windows.Forms.TextBox();
            this.LTotalAPagar = new System.Windows.Forms.Label();
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
            this.listadoVentas = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenedor.SuspendLayout();
            this.contenedorRegistrarVenta.SuspendLayout();
            this.gbInformacionCliente.SuspendLayout();
            this.gbInformacionVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedor.Controls.Add(this.btnLimpiar);
            this.contenedor.Controls.Add(this.btnBuscar);
            this.contenedor.Controls.Add(this.TBNroDoc);
            this.contenedor.Controls.Add(this.LNroDoc);
            this.contenedor.Controls.Add(this.contenedorRegistrarVenta);
            this.contenedor.Controls.Add(this.TBCambio);
            this.contenedor.Controls.Add(this.TBRecibe);
            this.contenedor.Controls.Add(this.LCambio);
            this.contenedor.Controls.Add(this.LRecibe);
            this.contenedor.Controls.Add(this.TBTotalAPagar);
            this.contenedor.Controls.Add(this.LTotalAPagar);
            this.contenedor.Controls.Add(this.gbInformacionCliente);
            this.contenedor.Controls.Add(this.gbInformacionVentas);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contenedor.ForeColor = System.Drawing.Color.DarkRed;
            this.contenedor.Location = new System.Drawing.Point(0, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1182, 654);
            this.contenedor.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 18;
            this.btnLimpiar.Location = new System.Drawing.Point(1099, 137);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(46, 26);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 18;
            this.btnBuscar.Location = new System.Drawing.Point(1041, 137);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 26);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // TBNroDoc
            // 
            this.TBNroDoc.Location = new System.Drawing.Point(945, 102);
            this.TBNroDoc.Name = "TBNroDoc";
            this.TBNroDoc.Size = new System.Drawing.Size(200, 28);
            this.TBNroDoc.TabIndex = 41;
            this.TBNroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // LNroDoc
            // 
            this.LNroDoc.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LNroDoc.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNroDoc.ForeColor = System.Drawing.Color.DarkRed;
            this.LNroDoc.Location = new System.Drawing.Point(945, 73);
            this.LNroDoc.Name = "LNroDoc";
            this.LNroDoc.Size = new System.Drawing.Size(204, 26);
            this.LNroDoc.TabIndex = 40;
            this.LNroDoc.Text = "Número Documento:";
            // 
            // contenedorRegistrarVenta
            // 
            this.contenedorRegistrarVenta.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorRegistrarVenta.Controls.Add(this.LDetalleVenta);
            this.contenedorRegistrarVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorRegistrarVenta.Location = new System.Drawing.Point(0, 0);
            this.contenedorRegistrarVenta.Name = "contenedorRegistrarVenta";
            this.contenedorRegistrarVenta.Size = new System.Drawing.Size(1182, 56);
            this.contenedorRegistrarVenta.TabIndex = 39;
            // 
            // LDetalleVenta
            // 
            this.LDetalleVenta.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LDetalleVenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.LDetalleVenta.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalleVenta.ForeColor = System.Drawing.Color.DarkRed;
            this.LDetalleVenta.Location = new System.Drawing.Point(0, 0);
            this.LDetalleVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDetalleVenta.Name = "LDetalleVenta";
            this.LDetalleVenta.Size = new System.Drawing.Size(330, 56);
            this.LDetalleVenta.TabIndex = 0;
            this.LDetalleVenta.Text = "Detalle Venta";
            this.LDetalleVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TBCambio
            // 
            this.TBCambio.Location = new System.Drawing.Point(1016, 377);
            this.TBCambio.Name = "TBCambio";
            this.TBCambio.ReadOnly = true;
            this.TBCambio.Size = new System.Drawing.Size(129, 28);
            this.TBCambio.TabIndex = 38;
            // 
            // TBRecibe
            // 
            this.TBRecibe.Location = new System.Drawing.Point(864, 377);
            this.TBRecibe.Name = "TBRecibe";
            this.TBRecibe.Size = new System.Drawing.Size(129, 28);
            this.TBRecibe.TabIndex = 37;
            this.TBRecibe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // LCambio
            // 
            this.LCambio.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LCambio.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCambio.ForeColor = System.Drawing.Color.DarkRed;
            this.LCambio.Location = new System.Drawing.Point(1016, 351);
            this.LCambio.Name = "LCambio";
            this.LCambio.Size = new System.Drawing.Size(129, 21);
            this.LCambio.TabIndex = 36;
            this.LCambio.Text = "Cambio:";
            // 
            // LRecibe
            // 
            this.LRecibe.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LRecibe.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRecibe.ForeColor = System.Drawing.Color.DarkRed;
            this.LRecibe.Location = new System.Drawing.Point(864, 351);
            this.LRecibe.Name = "LRecibe";
            this.LRecibe.Size = new System.Drawing.Size(129, 21);
            this.LRecibe.TabIndex = 35;
            this.LRecibe.Text = "Se recibe:";
            // 
            // TBTotalAPagar
            // 
            this.TBTotalAPagar.Location = new System.Drawing.Point(715, 377);
            this.TBTotalAPagar.Name = "TBTotalAPagar";
            this.TBTotalAPagar.ReadOnly = true;
            this.TBTotalAPagar.Size = new System.Drawing.Size(129, 28);
            this.TBTotalAPagar.TabIndex = 34;
            // 
            // LTotalAPagar
            // 
            this.LTotalAPagar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LTotalAPagar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalAPagar.ForeColor = System.Drawing.Color.DarkRed;
            this.LTotalAPagar.Location = new System.Drawing.Point(715, 351);
            this.LTotalAPagar.Name = "LTotalAPagar";
            this.LTotalAPagar.Size = new System.Drawing.Size(129, 21);
            this.LTotalAPagar.TabIndex = 33;
            this.LTotalAPagar.Text = "Total a pagar:";
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.gbInformacionCliente.Controls.Add(this.TBNombreCompleto);
            this.gbInformacionCliente.Controls.Add(this.TBNroDocumento);
            this.gbInformacionCliente.Controls.Add(this.LNombreCompleto);
            this.gbInformacionCliente.Controls.Add(this.LNroDocumento);
            this.gbInformacionCliente.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInformacionCliente.Location = new System.Drawing.Point(24, 261);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Size = new System.Drawing.Size(639, 144);
            this.gbInformacionCliente.TabIndex = 24;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "Información Cliente";
            // 
            // TBNombreCompleto
            // 
            this.TBNombreCompleto.Location = new System.Drawing.Point(341, 83);
            this.TBNombreCompleto.Name = "TBNombreCompleto";
            this.TBNombreCompleto.ReadOnly = true;
            this.TBNombreCompleto.Size = new System.Drawing.Size(204, 28);
            this.TBNombreCompleto.TabIndex = 5;
            // 
            // TBNroDocumento
            // 
            this.TBNroDocumento.Location = new System.Drawing.Point(108, 83);
            this.TBNroDocumento.Name = "TBNroDocumento";
            this.TBNroDocumento.ReadOnly = true;
            this.TBNroDocumento.Size = new System.Drawing.Size(191, 28);
            this.TBNroDocumento.TabIndex = 4;
            // 
            // LNombreCompleto
            // 
            this.LNombreCompleto.AutoSize = true;
            this.LNombreCompleto.Location = new System.Drawing.Point(341, 55);
            this.LNombreCompleto.Name = "LNombreCompleto";
            this.LNombreCompleto.Size = new System.Drawing.Size(154, 21);
            this.LNombreCompleto.TabIndex = 3;
            this.LNombreCompleto.Text = "Nombre Cliente:";
            // 
            // LNroDocumento
            // 
            this.LNroDocumento.AutoSize = true;
            this.LNroDocumento.Location = new System.Drawing.Point(108, 55);
            this.LNroDocumento.Name = "LNroDocumento";
            this.LNroDocumento.Size = new System.Drawing.Size(184, 21);
            this.LNroDocumento.TabIndex = 2;
            this.LNroDocumento.Text = "Documento Cliente:";
            // 
            // gbInformacionVentas
            // 
            this.gbInformacionVentas.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.gbInformacionVentas.Controls.Add(this.LUsuario);
            this.gbInformacionVentas.Controls.Add(this.TBUsuario);
            this.gbInformacionVentas.Controls.Add(this.TBTipoDoc);
            this.gbInformacionVentas.Controls.Add(this.TBFecha);
            this.gbInformacionVentas.Controls.Add(this.LTipoDoc);
            this.gbInformacionVentas.Controls.Add(this.LFecha);
            this.gbInformacionVentas.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionVentas.ForeColor = System.Drawing.Color.DarkRed;
            this.gbInformacionVentas.Location = new System.Drawing.Point(24, 108);
            this.gbInformacionVentas.Name = "gbInformacionVentas";
            this.gbInformacionVentas.Size = new System.Drawing.Size(872, 144);
            this.gbInformacionVentas.TabIndex = 23;
            this.gbInformacionVentas.TabStop = false;
            this.gbInformacionVentas.Text = "Información Venta";
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(595, 47);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(85, 21);
            this.LUsuario.TabIndex = 9;
            this.LUsuario.Text = "Usuario:";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(595, 74);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.ReadOnly = true;
            this.TBUsuario.Size = new System.Drawing.Size(210, 28);
            this.TBUsuario.TabIndex = 8;
            // 
            // TBTipoDoc
            // 
            this.TBTipoDoc.Location = new System.Drawing.Point(317, 74);
            this.TBTipoDoc.Name = "TBTipoDoc";
            this.TBTipoDoc.ReadOnly = true;
            this.TBTipoDoc.Size = new System.Drawing.Size(210, 28);
            this.TBTipoDoc.TabIndex = 7;
            // 
            // TBFecha
            // 
            this.TBFecha.Location = new System.Drawing.Point(85, 74);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(164, 28);
            this.TBFecha.TabIndex = 6;
            // 
            // LTipoDoc
            // 
            this.LTipoDoc.AutoSize = true;
            this.LTipoDoc.Location = new System.Drawing.Point(317, 47);
            this.LTipoDoc.Name = "LTipoDoc";
            this.LTipoDoc.Size = new System.Drawing.Size(158, 21);
            this.LTipoDoc.TabIndex = 3;
            this.LTipoDoc.Text = "Tipo Documento:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(85, 47);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(68, 21);
            this.LFecha.TabIndex = 2;
            this.LFecha.Text = "Fecha:";
            // 
            // listadoVentas
            // 
            this.listadoVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listadoVentas.BackgroundColor = System.Drawing.Color.White;
            this.listadoVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.precio,
            this.cantidad,
            this.subtotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.listadoVentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoVentas.Location = new System.Drawing.Point(0, 435);
            this.listadoVentas.Margin = new System.Windows.Forms.Padding(4);
            this.listadoVentas.Name = "listadoVentas";
            this.listadoVentas.RowHeadersWidth = 51;
            this.listadoVentas.Size = new System.Drawing.Size(1182, 219);
            this.listadoVentas.TabIndex = 21;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio Venta";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            // 
            // detalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.listadoVentas);
            this.Controls.Add(this.contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "detalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            this.contenedorRegistrarVenta.ResumeLayout(false);
            this.gbInformacionCliente.ResumeLayout(false);
            this.gbInformacionCliente.PerformLayout();
            this.gbInformacionVentas.ResumeLayout(false);
            this.gbInformacionVentas.PerformLayout();
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
        private System.Windows.Forms.TextBox TBCambio;
        private System.Windows.Forms.TextBox TBRecibe;
        private System.Windows.Forms.Label LCambio;
        private System.Windows.Forms.Label LRecibe;
        private System.Windows.Forms.TextBox TBTotalAPagar;
        private System.Windows.Forms.Label LTotalAPagar;
        public System.Windows.Forms.Panel contenedorRegistrarVenta;
        public System.Windows.Forms.Label LDetalleVenta;
        public FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox TBNroDoc;
        private System.Windows.Forms.Label LNroDoc;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBTipoDoc;
        private System.Windows.Forms.TextBox TBFecha;
        private System.Windows.Forms.Label LUsuario;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}