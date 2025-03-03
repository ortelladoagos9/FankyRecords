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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CBproveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listadoReporteCompras = new System.Windows.Forms.DataGridView();
            this.fechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporteComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnGenerarGrafico = new FontAwesome.Sharp.IconButton();
            this.descargarExcel = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.DTinicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DTfin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarFecha = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoReporteCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteComprasBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1418, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1418, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte Compras";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CBproveedor
            // 
            this.CBproveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBproveedor.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBproveedor.ForeColor = System.Drawing.Color.Black;
            this.CBproveedor.FormattingEnabled = true;
            this.CBproveedor.Location = new System.Drawing.Point(1040, 70);
            this.CBproveedor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CBproveedor.Name = "CBproveedor";
            this.CBproveedor.Size = new System.Drawing.Size(185, 35);
            this.CBproveedor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(876, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proveedor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listadoReporteCompras
            // 
            this.listadoReporteCompras.AllowUserToAddRows = false;
            this.listadoReporteCompras.AutoGenerateColumns = false;
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
            this.fechaCompraDataGridViewTextBoxColumn,
            this.iDTipoDocDataGridViewTextBoxColumn,
            this.numeroCompraDataGridViewTextBoxColumn,
            this.montoTotalDataGridViewTextBoxColumn,
            this.usuarioRegistroDataGridViewTextBoxColumn,
            this.cuitProveedorDataGridViewTextBoxColumn,
            this.razonSocialDataGridViewTextBoxColumn,
            this.codigoProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.precioCompraDataGridViewTextBoxColumn,
            this.precioventaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn});
            this.listadoReporteCompras.DataSource = this.reporteComprasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoReporteCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.listadoReporteCompras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoReporteCompras.Location = new System.Drawing.Point(0, 299);
            this.listadoReporteCompras.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listadoReporteCompras.Name = "listadoReporteCompras";
            this.listadoReporteCompras.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoReporteCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listadoReporteCompras.RowHeadersWidth = 51;
            this.listadoReporteCompras.Size = new System.Drawing.Size(1418, 440);
            this.listadoReporteCompras.TabIndex = 1;
            // 
            // fechaCompra
            // 
            this.fechaCompra.DataPropertyName = "FechaCompra";
            this.fechaCompra.HeaderText = "FechaCompra";
            this.fechaCompra.Name = "fechaCompra";
            this.fechaCompra.ReadOnly = true;
            // 
            // iDTipoDoc
            // 
            this.iDTipoDoc.DataPropertyName = "ID_Tipo_Doc";
            this.iDTipoDoc.HeaderText = "ID_Tipo_Doc";
            this.iDTipoDoc.Name = "iDTipoDoc";
            this.iDTipoDoc.ReadOnly = true;
            // 
            // numeroCompra
            // 
            this.numeroCompra.DataPropertyName = "NumeroCompra";
            this.numeroCompra.HeaderText = "NumeroCompra";
            this.numeroCompra.Name = "numeroCompra";
            this.numeroCompra.ReadOnly = true;
            this.numeroCompra.Visible = false;
            // 
            // montoTotal
            // 
            this.montoTotal.DataPropertyName = "MontoTotal";
            this.montoTotal.HeaderText = "MontoTotal";
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.ReadOnly = true;
            // 
            // usuarioRegistro
            // 
            this.usuarioRegistro.DataPropertyName = "UsuarioRegistro";
            this.usuarioRegistro.HeaderText = "UsuarioRegistro";
            this.usuarioRegistro.Name = "usuarioRegistro";
            this.usuarioRegistro.ReadOnly = true;
            this.usuarioRegistro.Visible = false;
            // 
            // cuitProveedor
            // 
            this.cuitProveedor.DataPropertyName = "CuitProveedor";
            this.cuitProveedor.HeaderText = "CuitProveedor";
            this.cuitProveedor.Name = "cuitProveedor";
            this.cuitProveedor.ReadOnly = true;
            // 
            // razonSocial
            // 
            this.razonSocial.DataPropertyName = "RazonSocial";
            this.razonSocial.HeaderText = "RazonSocial";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            // 
            // codigoProducto
            // 
            this.codigoProducto.DataPropertyName = "CodigoProducto";
            this.codigoProducto.HeaderText = "CodigoProducto";
            this.codigoProducto.Name = "codigoProducto";
            this.codigoProducto.ReadOnly = true;
            // 
            // nombreProducto
            // 
            this.nombreProducto.DataPropertyName = "NombreProducto";
            this.nombreProducto.HeaderText = "NombreProducto";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "Categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Visible = false;
            // 
            // precioCompra
            // 
            this.precioCompra.DataPropertyName = "PrecioCompra";
            this.precioCompra.HeaderText = "PrecioCompra";
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.ReadOnly = true;
            // 
            // precioventa
            // 
            this.precioventa.DataPropertyName = "Precioventa";
            this.precioventa.HeaderText = "Precioventa";
            this.precioventa.Name = "precioventa";
            this.precioventa.ReadOnly = true;
            this.precioventa.Visible = false;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "Cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // subTotal
            // 
            this.subTotal.DataPropertyName = "SubTotal";
            this.subTotal.HeaderText = "SubTotal";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Visible = false;
            // 
            // reporteComprasBindingSource
            // 
            this.reporteComprasBindingSource.DataSource = typeof(FankyRecords.C_entidad.ReporteCompras);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnGenerarGrafico);
            this.panel4.Controls.Add(this.descargarExcel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 246);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1418, 53);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(987, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(431, 53);
            this.panel5.TabIndex = 8;
            // 
            // btnGenerarGrafico
            // 
            this.btnGenerarGrafico.BackColor = System.Drawing.Color.White;
            this.btnGenerarGrafico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarGrafico.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenerarGrafico.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarGrafico.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            this.btnGenerarGrafico.IconColor = System.Drawing.Color.DarkRed;
            this.btnGenerarGrafico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarGrafico.IconSize = 25;
            this.btnGenerarGrafico.Location = new System.Drawing.Point(263, 0);
            this.btnGenerarGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarGrafico.Name = "btnGenerarGrafico";
            this.btnGenerarGrafico.Size = new System.Drawing.Size(262, 53);
            this.btnGenerarGrafico.TabIndex = 6;
            this.btnGenerarGrafico.Text = "Generar Gráfico";
            this.btnGenerarGrafico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarGrafico.UseVisualStyleBackColor = false;
            this.btnGenerarGrafico.Click += new System.EventHandler(this.btnGenerarGrafico_Click);
            // 
            // descargarExcel
            // 
            this.descargarExcel.BackColor = System.Drawing.Color.White;
            this.descargarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descargarExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.descargarExcel.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descargarExcel.IconChar = FontAwesome.Sharp.IconChar.File;
            this.descargarExcel.IconColor = System.Drawing.Color.DarkRed;
            this.descargarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.descargarExcel.IconSize = 25;
            this.descargarExcel.Location = new System.Drawing.Point(0, 0);
            this.descargarExcel.Margin = new System.Windows.Forms.Padding(2);
            this.descargarExcel.Name = "descargarExcel";
            this.descargarExcel.Size = new System.Drawing.Size(263, 53);
            this.descargarExcel.TabIndex = 2;
            this.descargarExcel.Text = "Descargar Excel";
            this.descargarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.descargarExcel.UseVisualStyleBackColor = false;
            this.descargarExcel.Click += new System.EventHandler(this.descargarExcel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel3.Controls.Add(this.CBproveedor);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.DTinicio);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.DTfin);
            this.panel3.Controls.Add(this.btnBuscarFecha);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 67);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1418, 179);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha inicio:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTinicio
            // 
            this.DTinicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTinicio.CalendarFont = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTinicio.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.DTinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTinicio.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTinicio.Location = new System.Drawing.Point(243, 70);
            this.DTinicio.Margin = new System.Windows.Forms.Padding(2);
            this.DTinicio.MaxDate = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            this.DTinicio.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.DTinicio.Name = "DTinicio";
            this.DTinicio.Size = new System.Drawing.Size(232, 35);
            this.DTinicio.TabIndex = 2;
            this.DTinicio.Value = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(485, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 35);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha Fin: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTfin
            // 
            this.DTfin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTfin.CalendarFont = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTfin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTfin.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTfin.Location = new System.Drawing.Point(642, 70);
            this.DTfin.Margin = new System.Windows.Forms.Padding(2);
            this.DTfin.MaxDate = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            this.DTfin.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.DTfin.Name = "DTfin";
            this.DTfin.Size = new System.Drawing.Size(232, 35);
            this.DTfin.TabIndex = 4;
            this.DTfin.Value = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarFecha.BackColor = System.Drawing.Color.White;
            this.btnBuscarFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarFecha.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFecha.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarFecha.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarFecha.IconSize = 25;
            this.btnBuscarFecha.Location = new System.Drawing.Point(1248, 70);
            this.btnBuscarFecha.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(129, 35);
            this.btnBuscarFecha.TabIndex = 5;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.buscarFecha_Click);
            // 
            // reporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1418, 739);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listadoReporteCompras);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "reporteCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reporteCompras";
            this.Load += new System.EventHandler(this.reporteCompras_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoReporteCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteComprasBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBproveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView listadoReporteCompras;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnGenerarGrafico;
        private FontAwesome.Sharp.IconButton descargarExcel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTinicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTfin;
        private FontAwesome.Sharp.IconButton btnBuscarFecha;
        private System.Windows.Forms.BindingSource reporteComprasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
    }
}