namespace FankyRecords.C_presentacion.Administrador
{
    partial class reporteVentas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarFecha = new FontAwesome.Sharp.IconButton();
            this.DTfin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DTinicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.listadoReporteVentas = new System.Windows.Forms.DataGridView();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomero_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descExel = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBuscarVentas = new System.Windows.Forms.ComboBox();
            this.buscarReg = new FontAwesome.Sharp.IconButton();
            this.btnGenerarGrafico = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TBBuscadorVentas = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoReporteVentas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte Ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarFecha.BackColor = System.Drawing.Color.White;
            this.btnBuscarFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarFecha.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFecha.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarFecha.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarFecha.IconSize = 20;
            this.btnBuscarFecha.Location = new System.Drawing.Point(798, 58);
            this.btnBuscarFecha.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(106, 28);
            this.btnBuscarFecha.TabIndex = 5;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.buscarFecha_Click);
            // 
            // DTfin
            // 
            this.DTfin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTfin.CalendarFont = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTfin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTfin.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTfin.Location = new System.Drawing.Point(616, 58);
            this.DTfin.Margin = new System.Windows.Forms.Padding(2);
            this.DTfin.MaxDate = new System.DateTime(2024, 10, 4, 0, 0, 0, 0);
            this.DTfin.MinDate = new System.DateTime(2024, 10, 4, 0, 0, 0, 0);
            this.DTfin.Name = "DTfin";
            this.DTfin.Size = new System.Drawing.Size(147, 28);
            this.DTfin.TabIndex = 4;
            this.DTfin.Value = new System.DateTime(2024, 10, 4, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Fin: ";
            // 
            // DTinicio
            // 
            this.DTinicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTinicio.CalendarFont = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTinicio.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.DTinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTinicio.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTinicio.Location = new System.Drawing.Point(309, 58);
            this.DTinicio.Margin = new System.Windows.Forms.Padding(2);
            this.DTinicio.MaxDate = new System.DateTime(2024, 10, 4, 0, 0, 0, 0);
            this.DTinicio.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.DTinicio.Name = "DTinicio";
            this.DTinicio.Size = new System.Drawing.Size(138, 28);
            this.DTinicio.TabIndex = 2;
            this.DTinicio.Value = new System.DateTime(2024, 10, 4, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha inicio:";
            // 
            // listadoReporteVentas
            // 
            this.listadoReporteVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoReporteVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listadoReporteVentas.BackgroundColor = System.Drawing.Color.White;
            this.listadoReporteVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoReporteVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoReporteVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoReporteVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaRegistro,
            this.tipoFactura,
            this.facturaNum,
            this.nomCliente,
            this.dniCliente,
            this.codProducto,
            this.nomProducto,
            this.categoria,
            this.nomero_venta,
            this.precioVenta,
            this.cantidad,
            this.montoTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoReporteVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.listadoReporteVentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoReporteVentas.Location = new System.Drawing.Point(0, 256);
            this.listadoReporteVentas.Margin = new System.Windows.Forms.Padding(2);
            this.listadoReporteVentas.Name = "listadoReporteVentas";
            this.listadoReporteVentas.RowHeadersWidth = 51;
            this.listadoReporteVentas.Size = new System.Drawing.Size(1182, 398);
            this.listadoReporteVentas.TabIndex = 1;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "Fecha Registro";
            this.fechaRegistro.MinimumWidth = 6;
            this.fechaRegistro.Name = "fechaRegistro";
            // 
            // tipoFactura
            // 
            this.tipoFactura.HeaderText = "Tipo Factura";
            this.tipoFactura.MinimumWidth = 6;
            this.tipoFactura.Name = "tipoFactura";
            // 
            // facturaNum
            // 
            this.facturaNum.HeaderText = "Número Factura";
            this.facturaNum.MinimumWidth = 6;
            this.facturaNum.Name = "facturaNum";
            // 
            // nomCliente
            // 
            this.nomCliente.HeaderText = "Nombre Cliente";
            this.nomCliente.MinimumWidth = 6;
            this.nomCliente.Name = "nomCliente";
            // 
            // dniCliente
            // 
            this.dniCliente.HeaderText = "DNI";
            this.dniCliente.MinimumWidth = 6;
            this.dniCliente.Name = "dniCliente";
            // 
            // codProducto
            // 
            this.codProducto.HeaderText = "Código Producto";
            this.codProducto.MinimumWidth = 6;
            this.codProducto.Name = "codProducto";
            // 
            // nomProducto
            // 
            this.nomProducto.HeaderText = "Nombre Producto";
            this.nomProducto.MinimumWidth = 6;
            this.nomProducto.Name = "nomProducto";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoría";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            // 
            // nomero_venta
            // 
            this.nomero_venta.HeaderText = "Número venta";
            this.nomero_venta.MinimumWidth = 6;
            this.nomero_venta.Name = "nomero_venta";
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.MinimumWidth = 6;
            this.precioVenta.Name = "precioVenta";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "Monto Total";
            this.montoTotal.MinimumWidth = 6;
            this.montoTotal.Name = "montoTotal";
            // 
            // descExel
            // 
            this.descExel.BackColor = System.Drawing.Color.White;
            this.descExel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descExel.Dock = System.Windows.Forms.DockStyle.Left;
            this.descExel.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descExel.IconChar = FontAwesome.Sharp.IconChar.File;
            this.descExel.IconColor = System.Drawing.Color.DarkRed;
            this.descExel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.descExel.IconSize = 20;
            this.descExel.Location = new System.Drawing.Point(0, 0);
            this.descExel.Margin = new System.Windows.Forms.Padding(2);
            this.descExel.Name = "descExel";
            this.descExel.Size = new System.Drawing.Size(191, 53);
            this.descExel.TabIndex = 2;
            this.descExel.Text = "Descargar Excel";
            this.descExel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.descExel.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Buscar por:";
            // 
            // cbBuscarVentas
            // 
            this.cbBuscarVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarVentas.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarVentas.ForeColor = System.Drawing.Color.Black;
            this.cbBuscarVentas.FormattingEnabled = true;
            this.cbBuscarVentas.Items.AddRange(new object[] {
            "Fecha Registro",
            "Tipo Factura",
            "Número Factura",
            "Nombre Cliente",
            "DNI",
            "Código Producto",
            "Nombre Producto",
            "Categoria ",
            "Precio Venta"});
            this.cbBuscarVentas.Location = new System.Drawing.Point(123, 13);
            this.cbBuscarVentas.Margin = new System.Windows.Forms.Padding(2);
            this.cbBuscarVentas.Name = "cbBuscarVentas";
            this.cbBuscarVentas.Size = new System.Drawing.Size(156, 29);
            this.cbBuscarVentas.TabIndex = 4;
            // 
            // buscarReg
            // 
            this.buscarReg.BackColor = System.Drawing.Color.White;
            this.buscarReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarReg.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.buscarReg.IconColor = System.Drawing.Color.DarkRed;
            this.buscarReg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buscarReg.IconSize = 19;
            this.buscarReg.Location = new System.Drawing.Point(467, 13);
            this.buscarReg.Margin = new System.Windows.Forms.Padding(2);
            this.buscarReg.Name = "buscarReg";
            this.buscarReg.Size = new System.Drawing.Size(71, 29);
            this.buscarReg.TabIndex = 5;
            this.buscarReg.UseVisualStyleBackColor = false;
            this.buscarReg.Click += new System.EventHandler(this.buscarReg_Click);
            // 
            // btnGenerarGrafico
            // 
            this.btnGenerarGrafico.BackColor = System.Drawing.Color.White;
            this.btnGenerarGrafico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarGrafico.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenerarGrafico.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarGrafico.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            this.btnGenerarGrafico.IconColor = System.Drawing.Color.DarkRed;
            this.btnGenerarGrafico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarGrafico.IconSize = 20;
            this.btnGenerarGrafico.Location = new System.Drawing.Point(191, 0);
            this.btnGenerarGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarGrafico.Name = "btnGenerarGrafico";
            this.btnGenerarGrafico.Size = new System.Drawing.Size(196, 53);
            this.btnGenerarGrafico.TabIndex = 6;
            this.btnGenerarGrafico.Text = "Generar Gráfico";
            this.btnGenerarGrafico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarGrafico.UseVisualStyleBackColor = false;
            this.btnGenerarGrafico.Click += new System.EventHandler(this.btnGenerarGrafico_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 195);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.DTinicio);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.DTfin);
            this.panel3.Controls.Add(this.btnBuscarFecha);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 195);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnGenerarGrafico);
            this.panel4.Controls.Add(this.descExel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1182, 53);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TBBuscadorVentas);
            this.panel5.Controls.Add(this.cbBuscarVentas);
            this.panel5.Controls.Add(this.buscarReg);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(627, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(555, 53);
            this.panel5.TabIndex = 8;
            // 
            // TBBuscadorVentas
            // 
            this.TBBuscadorVentas.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscadorVentas.ForeColor = System.Drawing.Color.Black;
            this.TBBuscadorVentas.Location = new System.Drawing.Point(291, 14);
            this.TBBuscadorVentas.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.TBBuscadorVentas.Name = "TBBuscadorVentas";
            this.TBBuscadorVentas.Size = new System.Drawing.Size(171, 28);
            this.TBBuscadorVentas.TabIndex = 33;
            // 
            // reporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listadoReporteVentas);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "reporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reporteVentas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoReporteVentas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DTinicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnBuscarFecha;
        private System.Windows.Forms.DateTimePicker DTfin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView listadoReporteVentas;
        private FontAwesome.Sharp.IconButton descExel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBuscarVentas;
        private FontAwesome.Sharp.IconButton buscarReg;
        private FontAwesome.Sharp.IconButton btnGenerarGrafico;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox TBBuscadorVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomero_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
    }
}