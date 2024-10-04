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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CBproveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listadoReporteCompras = new System.Windows.Forms.DataGridView();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbBuscarVentas = new System.Windows.Forms.ComboBox();
            this.buscarReg = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerarGrafico = new FontAwesome.Sharp.IconButton();
            this.descExel = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.DTinicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DTfin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarFecha = new FontAwesome.Sharp.IconButton();
            this.TBBuscadorCompras = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoReporteCompras)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte Compras";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CBproveedor
            // 
            this.CBproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBproveedor.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBproveedor.ForeColor = System.Drawing.Color.Black;
            this.CBproveedor.FormattingEnabled = true;
            this.CBproveedor.Items.AddRange(new object[] {
            "Proveedor A",
            "Proveedor B"});
            this.CBproveedor.Location = new System.Drawing.Point(765, 54);
            this.CBproveedor.Name = "CBproveedor";
            this.CBproveedor.Size = new System.Drawing.Size(147, 27);
            this.CBproveedor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proveedor:";
            // 
            // listadoReporteCompras
            // 
            this.listadoReporteCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoReporteCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listadoReporteCompras.BackgroundColor = System.Drawing.Color.White;
            this.listadoReporteCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoReporteCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoReporteCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoReporteCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoReporteCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaRegistro,
            this.tipoDoc,
            this.razonSocial,
            this.cuitProveedor,
            this.codProducto,
            this.nomProducto,
            this.precioCompra,
            this.cantidad,
            this.montoTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoReporteCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.listadoReporteCompras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoReporteCompras.GridColor = System.Drawing.Color.White;
            this.listadoReporteCompras.Location = new System.Drawing.Point(0, 256);
            this.listadoReporteCompras.Name = "listadoReporteCompras";
            this.listadoReporteCompras.RowHeadersWidth = 51;
            this.listadoReporteCompras.Size = new System.Drawing.Size(1182, 398);
            this.listadoReporteCompras.TabIndex = 1;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "Fecha Registro";
            this.fechaRegistro.MinimumWidth = 6;
            this.fechaRegistro.Name = "fechaRegistro";
            // 
            // tipoDoc
            // 
            this.tipoDoc.HeaderText = "Tipo Documento";
            this.tipoDoc.MinimumWidth = 6;
            this.tipoDoc.Name = "tipoDoc";
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.MinimumWidth = 6;
            this.razonSocial.Name = "razonSocial";
            // 
            // cuitProveedor
            // 
            this.cuitProveedor.HeaderText = "Cuit Proveedor";
            this.cuitProveedor.MinimumWidth = 6;
            this.cuitProveedor.Name = "cuitProveedor";
            // 
            // codProducto
            // 
            this.codProducto.HeaderText = "Codigo Producto";
            this.codProducto.MinimumWidth = 6;
            this.codProducto.Name = "codProducto";
            // 
            // nomProducto
            // 
            this.nomProducto.HeaderText = "Nombre Producto";
            this.nomProducto.MinimumWidth = 6;
            this.nomProducto.Name = "nomProducto";
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio Compra";
            this.precioCompra.MinimumWidth = 6;
            this.precioCompra.Name = "precioCompra";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "Monto Total ";
            this.montoTotal.MinimumWidth = 6;
            this.montoTotal.Name = "montoTotal";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnGenerarGrafico);
            this.panel4.Controls.Add(this.descExel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1182, 53);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TBBuscadorCompras);
            this.panel5.Controls.Add(this.cbBuscarVentas);
            this.panel5.Controls.Add(this.buscarReg);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(625, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(557, 53);
            this.panel5.TabIndex = 8;
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
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 142);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha inicio:";
            // 
            // DTinicio
            // 
            this.DTinicio.CalendarFont = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTinicio.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.DTinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTinicio.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTinicio.Location = new System.Drawing.Point(185, 54);
            this.DTinicio.Margin = new System.Windows.Forms.Padding(2);
            this.DTinicio.MaxDate = new System.DateTime(2024, 10, 2, 0, 0, 0, 0);
            this.DTinicio.MinDate = new System.DateTime(2024, 10, 2, 0, 0, 0, 0);
            this.DTinicio.Name = "DTinicio";
            this.DTinicio.Size = new System.Drawing.Size(138, 28);
            this.DTinicio.TabIndex = 2;
            this.DTinicio.Value = new System.DateTime(2024, 10, 2, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha Fin: ";
            // 
            // DTfin
            // 
            this.DTfin.CalendarFont = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTfin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTfin.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTfin.Location = new System.Drawing.Point(468, 54);
            this.DTfin.Margin = new System.Windows.Forms.Padding(2);
            this.DTfin.MaxDate = new System.DateTime(2024, 10, 2, 0, 0, 0, 0);
            this.DTfin.MinDate = new System.DateTime(2024, 10, 2, 0, 0, 0, 0);
            this.DTfin.Name = "DTfin";
            this.DTfin.Size = new System.Drawing.Size(147, 28);
            this.DTfin.TabIndex = 4;
            this.DTfin.Value = new System.DateTime(2024, 10, 2, 0, 0, 0, 0);
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.BackColor = System.Drawing.Color.White;
            this.btnBuscarFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarFecha.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFecha.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarFecha.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarFecha.IconSize = 20;
            this.btnBuscarFecha.Location = new System.Drawing.Point(937, 54);
            this.btnBuscarFecha.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(106, 28);
            this.btnBuscarFecha.TabIndex = 5;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.buscarFecha_Click);
            // 
            // TBBuscadorCompras
            // 
            this.TBBuscadorCompras.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscadorCompras.ForeColor = System.Drawing.Color.Black;
            this.TBBuscadorCompras.Location = new System.Drawing.Point(291, 14);
            this.TBBuscadorCompras.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.TBBuscadorCompras.Name = "TBBuscadorCompras";
            this.TBBuscadorCompras.Size = new System.Drawing.Size(171, 28);
            this.TBBuscadorCompras.TabIndex = 34;
            // 
            // reporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listadoReporteCompras);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "reporteCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reporteCompras";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoReporteCompras)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBproveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView listadoReporteCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbBuscarVentas;
        private FontAwesome.Sharp.IconButton buscarReg;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnGenerarGrafico;
        private FontAwesome.Sharp.IconButton descExel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTinicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTfin;
        private FontAwesome.Sharp.IconButton btnBuscarFecha;
        public System.Windows.Forms.TextBox TBBuscadorCompras;
    }
}