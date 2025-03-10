namespace FankyRecords.C_presentacion.Administrador
{
    partial class reporteCategorias
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
            this.listadoReporteCategoria = new System.Windows.Forms.DataGridView();
            this.FechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDTipoDococ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LCategorias = new System.Windows.Forms.Label();
            this.CBcategoria = new System.Windows.Forms.ComboBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadoReporteCategoria)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listadoReporteCategoria
            // 
            this.listadoReporteCategoria.AllowUserToAddRows = false;
            this.listadoReporteCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoReporteCategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listadoReporteCategoria.BackgroundColor = System.Drawing.Color.White;
            this.listadoReporteCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoReporteCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoReporteCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoReporteCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoReporteCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaVenta,
            this.NumeroFactura,
            this.TipoDTipoDococ,
            this.Categoria,
            this.CodigoProducto,
            this.NombreProducto,
            this.DescripcionProducto,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.UsuarioRegistro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoReporteCategoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.listadoReporteCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoReporteCategoria.Location = new System.Drawing.Point(0, 299);
            this.listadoReporteCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.listadoReporteCategoria.Name = "listadoReporteCategoria";
            this.listadoReporteCategoria.ReadOnly = true;
            this.listadoReporteCategoria.RowHeadersWidth = 51;
            this.listadoReporteCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoReporteCategoria.Size = new System.Drawing.Size(1418, 440);
            this.listadoReporteCategoria.TabIndex = 10;
            // 
            // FechaVenta
            // 
            this.FechaVenta.HeaderText = "Fecha Venta";
            this.FechaVenta.MinimumWidth = 6;
            this.FechaVenta.Name = "FechaVenta";
            this.FechaVenta.ReadOnly = true;
            // 
            // NumeroFactura
            // 
            this.NumeroFactura.HeaderText = "Número Factura";
            this.NumeroFactura.MinimumWidth = 6;
            this.NumeroFactura.Name = "NumeroFactura";
            this.NumeroFactura.ReadOnly = true;
            // 
            // TipoDTipoDococ
            // 
            this.TipoDTipoDococ.HeaderText = "Tipo Documento";
            this.TipoDTipoDococ.MinimumWidth = 6;
            this.TipoDTipoDococ.Name = "TipoDTipoDococ";
            this.TipoDTipoDococ.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
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
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.MinimumWidth = 6;
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel3.Controls.Add(this.LCategorias);
            this.panel3.Controls.Add(this.CBcategoria);
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
            this.panel3.TabIndex = 11;
            // 
            // LCategorias
            // 
            this.LCategorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LCategorias.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategorias.ForeColor = System.Drawing.Color.DarkRed;
            this.LCategorias.Location = new System.Drawing.Point(864, 73);
            this.LCategorias.Name = "LCategorias";
            this.LCategorias.Size = new System.Drawing.Size(147, 35);
            this.LCategorias.TabIndex = 9;
            this.LCategorias.Text = "Categoría:";
            // 
            // CBcategoria
            // 
            this.CBcategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBcategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBcategoria.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBcategoria.FormattingEnabled = true;
            this.CBcategoria.Location = new System.Drawing.Point(1013, 73);
            this.CBcategoria.Name = "CBcategoria";
            this.CBcategoria.Size = new System.Drawing.Size(232, 40);
            this.CBcategoria.TabIndex = 8;
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
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnGenerarGrafico.Location = new System.Drawing.Point(290, 0);
            this.btnGenerarGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarGrafico.Name = "btnGenerarGrafico";
            this.btnGenerarGrafico.Size = new System.Drawing.Size(287, 53);
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
            this.descargarExcel.ForeColor = System.Drawing.Color.DarkRed;
            this.descargarExcel.IconChar = FontAwesome.Sharp.IconChar.File;
            this.descargarExcel.IconColor = System.Drawing.Color.DarkRed;
            this.descargarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.descargarExcel.IconSize = 30;
            this.descargarExcel.Location = new System.Drawing.Point(0, 0);
            this.descargarExcel.Margin = new System.Windows.Forms.Padding(2);
            this.descargarExcel.Name = "descargarExcel";
            this.descargarExcel.Size = new System.Drawing.Size(290, 53);
            this.descargarExcel.TabIndex = 2;
            this.descargarExcel.Text = "Descargar Excel";
            this.descargarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.descargarExcel.UseVisualStyleBackColor = false;
            this.descargarExcel.Click += new System.EventHandler(this.descargarExcel_Click);
            // 
            // LFechaInicio
            // 
            this.LFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LFechaInicio.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaInicio.ForeColor = System.Drawing.Color.DarkRed;
            this.LFechaInicio.Location = new System.Drawing.Point(23, 73);
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
            this.DTinicio.Location = new System.Drawing.Point(211, 73);
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
            this.LFechaFin.Location = new System.Drawing.Point(455, 73);
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
            this.DTfin.Location = new System.Drawing.Point(611, 73);
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
            this.btnBuscarFecha.Location = new System.Drawing.Point(1255, 73);
            this.btnBuscarFecha.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(129, 35);
            this.btnBuscarFecha.TabIndex = 5;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
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
            this.panel1.TabIndex = 12;
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
            this.label1.Text = "Reporte Categorías";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // reporteCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 739);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listadoReporteCategoria);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "reporteCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteCategorias";
            this.Load += new System.EventHandler(this.reporteCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoReporteCategoria)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoReporteCategoria;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LCategorias;
        private System.Windows.Forms.ComboBox CBcategoria;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGenerarGrafico;
        private FontAwesome.Sharp.IconButton descargarExcel;
        private System.Windows.Forms.Label LFechaInicio;
        private System.Windows.Forms.DateTimePicker DTinicio;
        private System.Windows.Forms.Label LFechaFin;
        private System.Windows.Forms.DateTimePicker DTfin;
        private FontAwesome.Sharp.IconButton btnBuscarFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDTipoDococ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
    }
}