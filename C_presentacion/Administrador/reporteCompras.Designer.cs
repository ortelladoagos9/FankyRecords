namespace FankyRecords.C_presentacion.Administrador
{
    partial class reporteCompras
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.LProveedor = new System.Windows.Forms.Label();
            this.CBproveedor = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGenerarGrafico = new FontAwesome.Sharp.IconButton();
            this.descargarExcel = new FontAwesome.Sharp.IconButton();
            this.LFechaInicio = new System.Windows.Forms.Label();
            this.DTinicio = new System.Windows.Forms.DateTimePicker();
            this.LFechaFin = new System.Windows.Forms.Label();
            this.DTfin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarFecha = new FontAwesome.Sharp.IconButton();
            this.listadoReporteCompras = new System.Windows.Forms.DataGridView();
            this.FechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuitProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoReporteCompras)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel3.Controls.Add(this.LProveedor);
            this.panel3.Controls.Add(this.CBproveedor);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.LFechaInicio);
            this.panel3.Controls.Add(this.DTinicio);
            this.panel3.Controls.Add(this.LFechaFin);
            this.panel3.Controls.Add(this.DTfin);
            this.panel3.Controls.Add(this.btnBuscarFecha);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 67);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1418, 232);
            this.panel3.TabIndex = 8;
            // 
            // LProveedor
            // 
            this.LProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LProveedor.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProveedor.ForeColor = System.Drawing.Color.DarkRed;
            this.LProveedor.Location = new System.Drawing.Point(864, 80);
            this.LProveedor.Name = "LProveedor";
            this.LProveedor.Size = new System.Drawing.Size(154, 35);
            this.LProveedor.TabIndex = 9;
            this.LProveedor.Text = "Proveedor:";
            // 
            // CBproveedor
            // 
            this.CBproveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBproveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBproveedor.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBproveedor.FormattingEnabled = true;
            this.CBproveedor.Location = new System.Drawing.Point(1022, 80);
            this.CBproveedor.Name = "CBproveedor";
            this.CBproveedor.Size = new System.Drawing.Size(232, 40);
            this.CBproveedor.TabIndex = 8;
            this.CBproveedor.SelectedIndexChanged += new System.EventHandler(this.CBproveedor_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnGenerarGrafico);
            this.panel4.Controls.Add(this.descargarExcel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 179);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1418, 53);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLimpiar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(970, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(448, 53);
            this.panel5.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 30;
            this.btnLimpiar.Location = new System.Drawing.Point(367, 0);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 53);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnGenerarGrafico
            // 
            this.btnGenerarGrafico.BackColor = System.Drawing.Color.White;
            this.btnGenerarGrafico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarGrafico.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenerarGrafico.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarGrafico.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGenerarGrafico.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            this.btnGenerarGrafico.IconColor = System.Drawing.Color.DarkRed;
            this.btnGenerarGrafico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarGrafico.IconSize = 30;
            this.btnGenerarGrafico.Location = new System.Drawing.Point(288, 0);
            this.btnGenerarGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarGrafico.Name = "btnGenerarGrafico";
            this.btnGenerarGrafico.Size = new System.Drawing.Size(284, 53);
            this.btnGenerarGrafico.TabIndex = 6;
            this.btnGenerarGrafico.Text = "Generar Gráfico";
            this.btnGenerarGrafico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarGrafico.UseVisualStyleBackColor = false;
            this.btnGenerarGrafico.Click += new System.EventHandler(this.btnGenerarGrafico_Click_1);
            // 
            // descargarExcel
            // 
            this.descargarExcel.BackColor = System.Drawing.Color.White;
            this.descargarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descargarExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.descargarExcel.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descargarExcel.ForeColor = System.Drawing.Color.DarkRed;
            this.descargarExcel.IconChar = FontAwesome.Sharp.IconChar.File;
            this.descargarExcel.IconColor = System.Drawing.Color.DarkRed;
            this.descargarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.descargarExcel.IconSize = 30;
            this.descargarExcel.Location = new System.Drawing.Point(0, 0);
            this.descargarExcel.Margin = new System.Windows.Forms.Padding(2);
            this.descargarExcel.Name = "descargarExcel";
            this.descargarExcel.Size = new System.Drawing.Size(288, 53);
            this.descargarExcel.TabIndex = 2;
            this.descargarExcel.Text = "Descargar Excel";
            this.descargarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.descargarExcel.UseVisualStyleBackColor = false;
            this.descargarExcel.Click += new System.EventHandler(this.descargarExcel_Click_1);
            // 
            // LFechaInicio
            // 
            this.LFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LFechaInicio.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaInicio.ForeColor = System.Drawing.Color.DarkRed;
            this.LFechaInicio.Location = new System.Drawing.Point(32, 80);
            this.LFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFechaInicio.Name = "LFechaInicio";
            this.LFechaInicio.Size = new System.Drawing.Size(180, 35);
            this.LFechaInicio.TabIndex = 1;
            this.LFechaInicio.Text = "Fecha Inicio:";
            this.LFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTinicio
            // 
            this.DTinicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTinicio.CalendarFont = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTinicio.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.DTinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTinicio.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTinicio.Location = new System.Drawing.Point(220, 80);
            this.DTinicio.Margin = new System.Windows.Forms.Padding(2);
            this.DTinicio.MaxDate = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            this.DTinicio.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.DTinicio.Name = "DTinicio";
            this.DTinicio.Size = new System.Drawing.Size(232, 40);
            this.DTinicio.TabIndex = 2;
            this.DTinicio.Value = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            // 
            // LFechaFin
            // 
            this.LFechaFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LFechaFin.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaFin.ForeColor = System.Drawing.Color.DarkRed;
            this.LFechaFin.Location = new System.Drawing.Point(464, 80);
            this.LFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFechaFin.Name = "LFechaFin";
            this.LFechaFin.Size = new System.Drawing.Size(151, 35);
            this.LFechaFin.TabIndex = 3;
            this.LFechaFin.Text = "Fecha Fin: ";
            this.LFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTfin
            // 
            this.DTfin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTfin.CalendarFont = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTfin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTfin.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTfin.Location = new System.Drawing.Point(620, 80);
            this.DTfin.Margin = new System.Windows.Forms.Padding(2);
            this.DTfin.MaxDate = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            this.DTfin.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.DTfin.Name = "DTfin";
            this.DTfin.Size = new System.Drawing.Size(232, 40);
            this.DTfin.TabIndex = 4;
            this.DTfin.Value = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarFecha.BackColor = System.Drawing.Color.White;
            this.btnBuscarFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarFecha.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFecha.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBuscarFecha.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarFecha.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarFecha.IconSize = 25;
            this.btnBuscarFecha.Location = new System.Drawing.Point(1266, 80);
            this.btnBuscarFecha.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(129, 35);
            this.btnBuscarFecha.TabIndex = 5;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // listadoReporteCompras
            // 
            this.listadoReporteCompras.AllowUserToAddRows = false;
            this.listadoReporteCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoReporteCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listadoReporteCompras.BackgroundColor = System.Drawing.Color.White;
            this.listadoReporteCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoReporteCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoReporteCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoReporteCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoReporteCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaCompra,
            this.NumeroCompra,
            this.NumeroFactura,
            this.TipoDoc,
            this.CodigoProducto,
            this.NombreProducto,
            this.DescripcionProducto,
            this.CuitProveedor,
            this.RazonSocial,
            this.PrecioCompra,
            this.Cantidad,
            this.MontoTotal,
            this.UsuarioRegistro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoReporteCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.listadoReporteCompras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoReporteCompras.Location = new System.Drawing.Point(0, 299);
            this.listadoReporteCompras.Margin = new System.Windows.Forms.Padding(2);
            this.listadoReporteCompras.Name = "listadoReporteCompras";
            this.listadoReporteCompras.ReadOnly = true;
            this.listadoReporteCompras.RowHeadersWidth = 51;
            this.listadoReporteCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoReporteCompras.Size = new System.Drawing.Size(1418, 440);
            this.listadoReporteCompras.TabIndex = 9;
            // 
            // FechaCompra
            // 
            this.FechaCompra.HeaderText = "Fecha Compra";
            this.FechaCompra.MinimumWidth = 6;
            this.FechaCompra.Name = "FechaCompra";
            this.FechaCompra.ReadOnly = true;
            // 
            // NumeroCompra
            // 
            this.NumeroCompra.HeaderText = "Número Compra";
            this.NumeroCompra.MinimumWidth = 6;
            this.NumeroCompra.Name = "NumeroCompra";
            this.NumeroCompra.ReadOnly = true;
            // 
            // NumeroFactura
            // 
            this.NumeroFactura.HeaderText = "Número Factura";
            this.NumeroFactura.MinimumWidth = 6;
            this.NumeroFactura.Name = "NumeroFactura";
            this.NumeroFactura.ReadOnly = true;
            // 
            // TipoDoc
            // 
            this.TipoDoc.HeaderText = "Tipo Documento";
            this.TipoDoc.MinimumWidth = 6;
            this.TipoDoc.Name = "TipoDoc";
            this.TipoDoc.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Código Producto";
            this.CodigoProducto.MinimumWidth = 6;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.HeaderText = "Descripción Producto";
            this.DescripcionProducto.MinimumWidth = 6;
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.ReadOnly = true;
            // 
            // CuitProveedor
            // 
            this.CuitProveedor.HeaderText = "Cuit Proveedor";
            this.CuitProveedor.MinimumWidth = 6;
            this.CuitProveedor.Name = "CuitProveedor";
            this.CuitProveedor.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razón Social";
            this.RazonSocial.MinimumWidth = 6;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
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
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.MinimumWidth = 6;
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.MinimumWidth = 6;
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1418, 67);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1418, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte Compras";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // reporteCompras
            // 
            this.ClientSize = new System.Drawing.Size(1418, 739);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listadoReporteCompras);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reporteCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.reporteCompras_Load_1);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoReporteCompras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }




        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnGenerarGrafico;
        private FontAwesome.Sharp.IconButton descargarExcel;
        private System.Windows.Forms.Label LFechaInicio;
        private System.Windows.Forms.DateTimePicker DTinicio;
        private System.Windows.Forms.Label LFechaFin;
        private System.Windows.Forms.DateTimePicker DTfin;
        private FontAwesome.Sharp.IconButton btnBuscarFecha;
        private System.Windows.Forms.DataGridView listadoReporteCompras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LProveedor;
        private System.Windows.Forms.ComboBox CBproveedor;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuitProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
    }   
}