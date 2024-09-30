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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTinicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DTfin = new System.Windows.Forms.DateTimePicker();
            this.buscarFecha = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descExel = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.buscarPor = new System.Windows.Forms.ComboBox();
            this.buscarReg = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buscarFecha);
            this.panel1.Controls.Add(this.DTfin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DTinicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha inicio:";
            // 
            // DTinicio
            // 
            this.DTinicio.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.DTinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTinicio.Location = new System.Drawing.Point(166, 63);
            this.DTinicio.MaxDate = new System.DateTime(2024, 9, 30, 16, 27, 11, 0);
            this.DTinicio.Name = "DTinicio";
            this.DTinicio.Size = new System.Drawing.Size(99, 26);
            this.DTinicio.TabIndex = 2;
            this.DTinicio.Value = new System.DateTime(2024, 9, 30, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Fin: ";
            // 
            // DTfin
            // 
            this.DTfin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTfin.Location = new System.Drawing.Point(430, 64);
            this.DTfin.MaxDate = new System.DateTime(2024, 9, 30, 16, 27, 43, 0);
            this.DTfin.Name = "DTfin";
            this.DTfin.Size = new System.Drawing.Size(102, 26);
            this.DTfin.TabIndex = 4;
            this.DTfin.Value = new System.DateTime(2024, 9, 30, 0, 0, 0, 0);
            this.DTfin.ValueChanged += new System.EventHandler(this.DTfin_ValueChanged);
            // 
            // buscarFecha
            // 
            this.buscarFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarFecha.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarFecha.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.buscarFecha.IconColor = System.Drawing.Color.DarkRed;
            this.buscarFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buscarFecha.IconSize = 20;
            this.buscarFecha.Location = new System.Drawing.Point(571, 63);
            this.buscarFecha.Name = "buscarFecha";
            this.buscarFecha.Size = new System.Drawing.Size(102, 26);
            this.buscarFecha.TabIndex = 5;
            this.buscarFecha.Text = "Buscar";
            this.buscarFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscarFecha.UseVisualStyleBackColor = true;
            this.buscarFecha.Click += new System.EventHandler(this.buscarFecha_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaRegistro,
            this.tipoFactura,
            this.facturaNum,
            this.nomCliente,
            this.dniCliente,
            this.codProducto,
            this.nomProducto,
            this.categoria,
            this.precioVenta,
            this.cantidad,
            this.montoTotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1158, 464);
            this.dataGridView1.TabIndex = 1;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "Fecha Registro";
            this.fechaRegistro.Name = "fechaRegistro";
            // 
            // tipoFactura
            // 
            this.tipoFactura.HeaderText = "Tipo Factura";
            this.tipoFactura.Name = "tipoFactura";
            // 
            // facturaNum
            // 
            this.facturaNum.HeaderText = "Número Factura";
            this.facturaNum.Name = "facturaNum";
            // 
            // nomCliente
            // 
            this.nomCliente.HeaderText = "Nombre Cliente";
            this.nomCliente.Name = "nomCliente";
            this.nomCliente.Width = 110;
            // 
            // dniCliente
            // 
            this.dniCliente.HeaderText = "DNI";
            this.dniCliente.Name = "dniCliente";
            // 
            // codProducto
            // 
            this.codProducto.HeaderText = "Código Producto";
            this.codProducto.Name = "codProducto";
            // 
            // nomProducto
            // 
            this.nomProducto.HeaderText = "Nombre Producto";
            this.nomProducto.Name = "nomProducto";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.Name = "precioVenta";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "Monto Total";
            this.montoTotal.Name = "montoTotal";
            // 
            // descExel
            // 
            this.descExel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descExel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descExel.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descExel.IconChar = FontAwesome.Sharp.IconChar.File;
            this.descExel.IconColor = System.Drawing.Color.DarkRed;
            this.descExel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.descExel.IconSize = 20;
            this.descExel.Location = new System.Drawing.Point(58, 131);
            this.descExel.Name = "descExel";
            this.descExel.Size = new System.Drawing.Size(143, 29);
            this.descExel.TabIndex = 2;
            this.descExel.Text = "Descargar Exel";
            this.descExel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.descExel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Buscar por:";
            // 
            // buscarPor
            // 
            this.buscarPor.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarPor.ForeColor = System.Drawing.Color.DarkRed;
            this.buscarPor.FormattingEnabled = true;
            this.buscarPor.Items.AddRange(new object[] {
            "Fecha Registro",
            "Tipo Factura",
            "Número Factura",
            "Nombre Cliente",
            "DNI",
            "Código Producto",
            "Nombre Producto",
            "Categoria ",
            "Precio Venta"});
            this.buscarPor.Location = new System.Drawing.Point(722, 136);
            this.buscarPor.Name = "buscarPor";
            this.buscarPor.Size = new System.Drawing.Size(158, 24);
            this.buscarPor.TabIndex = 4;
            this.buscarPor.Text = "Fecha Registro";
            // 
            // buscarReg
            // 
            this.buscarReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarReg.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.buscarReg.IconColor = System.Drawing.Color.DarkRed;
            this.buscarReg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buscarReg.IconSize = 19;
            this.buscarReg.Location = new System.Drawing.Point(904, 136);
            this.buscarReg.Name = "buscarReg";
            this.buscarReg.Size = new System.Drawing.Size(30, 25);
            this.buscarReg.TabIndex = 5;
            this.buscarReg.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            this.iconButton1.IconColor = System.Drawing.Color.DarkRed;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(218, 131);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(176, 29);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Generar Gráfico";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // reporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.buscarReg);
            this.Controls.Add(this.buscarPor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descExel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "reporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reporteVentas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DTinicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton buscarFecha;
        private System.Windows.Forms.DateTimePicker DTfin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
        private FontAwesome.Sharp.IconButton descExel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox buscarPor;
        private FontAwesome.Sharp.IconButton buscarReg;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}