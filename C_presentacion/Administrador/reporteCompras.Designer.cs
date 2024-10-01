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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Ldtinicio = new System.Windows.Forms.Label();
            this.DTinicio = new System.Windows.Forms.DateTimePicker();
            this.Ldtfin = new System.Windows.Forms.Label();
            this.DTfin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CBproveedor = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descargaExel = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buscar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.CBproveedor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DTfin);
            this.panel1.Controls.Add(this.Ldtfin);
            this.panel1.Controls.Add(this.DTinicio);
            this.panel1.Controls.Add(this.Ldtinicio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 89);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte Compras";
            // 
            // Ldtinicio
            // 
            this.Ldtinicio.AutoSize = true;
            this.Ldtinicio.Location = new System.Drawing.Point(46, 50);
            this.Ldtinicio.Name = "Ldtinicio";
            this.Ldtinicio.Size = new System.Drawing.Size(108, 19);
            this.Ldtinicio.TabIndex = 1;
            this.Ldtinicio.Text = "Fecha Inicio:";
            // 
            // DTinicio
            // 
            this.DTinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTinicio.Location = new System.Drawing.Point(160, 44);
            this.DTinicio.MaxDate = new System.DateTime(2024, 9, 30, 0, 0, 0, 0);
            this.DTinicio.Name = "DTinicio";
            this.DTinicio.Size = new System.Drawing.Size(107, 26);
            this.DTinicio.TabIndex = 2;
            this.DTinicio.Value = new System.DateTime(2024, 9, 30, 0, 0, 0, 0);
            // 
            // Ldtfin
            // 
            this.Ldtfin.AutoSize = true;
            this.Ldtfin.Location = new System.Drawing.Point(304, 50);
            this.Ldtfin.Name = "Ldtfin";
            this.Ldtfin.Size = new System.Drawing.Size(90, 19);
            this.Ldtfin.TabIndex = 3;
            this.Ldtfin.Text = "Fecha Fin:";
            // 
            // DTfin
            // 
            this.DTfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTfin.Location = new System.Drawing.Point(400, 44);
            this.DTfin.MaxDate = new System.DateTime(2024, 9, 30, 21, 8, 24, 0);
            this.DTfin.Name = "DTfin";
            this.DTfin.Size = new System.Drawing.Size(107, 26);
            this.DTfin.TabIndex = 3;
            this.DTfin.Value = new System.DateTime(2024, 9, 30, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proveedor:";
            // 
            // CBproveedor
            // 
            this.CBproveedor.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBproveedor.ForeColor = System.Drawing.Color.DarkRed;
            this.CBproveedor.FormattingEnabled = true;
            this.CBproveedor.Items.AddRange(new object[] {
            "Proveedor A",
            "Proveedor B"});
            this.CBproveedor.Location = new System.Drawing.Point(642, 46);
            this.CBproveedor.Name = "CBproveedor";
            this.CBproveedor.Size = new System.Drawing.Size(121, 24);
            this.CBproveedor.TabIndex = 5;
            this.CBproveedor.Text = "Todos";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.DarkRed;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(800, 41);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(104, 28);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaRegistro,
            this.tipoDoc,
            this.razonSocial,
            this.cuitProveedor,
            this.codProducto,
            this.nomProducto,
            this.precioCompra,
            this.cantidad,
            this.montoTotal});
            this.dataGridView1.Location = new System.Drawing.Point(62, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1244, 505);
            this.dataGridView1.TabIndex = 1;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "Fecha Registro";
            this.fechaRegistro.Name = "fechaRegistro";
            // 
            // tipoDoc
            // 
            this.tipoDoc.HeaderText = "Tipo Documento";
            this.tipoDoc.Name = "tipoDoc";
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.Width = 200;
            // 
            // cuitProveedor
            // 
            this.cuitProveedor.HeaderText = "Cuit Proveedor";
            this.cuitProveedor.Name = "cuitProveedor";
            this.cuitProveedor.Width = 150;
            // 
            // codProducto
            // 
            this.codProducto.HeaderText = "Codigo Producto";
            this.codProducto.Name = "codProducto";
            this.codProducto.Width = 150;
            // 
            // nomProducto
            // 
            this.nomProducto.HeaderText = "Nombre Producto";
            this.nomProducto.Name = "nomProducto";
            this.nomProducto.Width = 200;
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio Compra";
            this.precioCompra.Name = "precioCompra";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "Monto Total ";
            this.montoTotal.Name = "montoTotal";
            // 
            // descargaExel
            // 
            this.descargaExel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descargaExel.IconChar = FontAwesome.Sharp.IconChar.File;
            this.descargaExel.IconColor = System.Drawing.Color.DarkRed;
            this.descargaExel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.descargaExel.IconSize = 20;
            this.descargaExel.Location = new System.Drawing.Point(108, 144);
            this.descargaExel.Name = "descargaExel";
            this.descargaExel.Size = new System.Drawing.Size(188, 36);
            this.descargaExel.TabIndex = 2;
            this.descargaExel.Text = "Descargar Exel";
            this.descargaExel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.descargaExel.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconButton2.IconColor = System.Drawing.Color.DarkRed;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(319, 144);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(188, 36);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Generar Gráfico";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(849, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buscar por:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre Producto",
            "Nombre Proveedor",
            "Codigo Producto",
            "Precio Compra",
            "Fecha Registro",
            "Tipo Documento",
            "Razon Social",
            "Cuit Proveedor",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(964, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Fecha Registro";
            // 
            // buscar
            // 
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.buscar.IconColor = System.Drawing.Color.DarkRed;
            this.buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buscar.IconSize = 20;
            this.buscar.Location = new System.Drawing.Point(1134, 154);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(37, 23);
            this.buscar.TabIndex = 6;
            this.buscar.UseVisualStyleBackColor = true;
            // 
            // reporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.descargaExel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "reporteCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reporteCompras";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTfin;
        private System.Windows.Forms.Label Ldtfin;
        private System.Windows.Forms.DateTimePicker DTinicio;
        private System.Windows.Forms.Label Ldtinicio;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox CBproveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
        private FontAwesome.Sharp.IconButton descargaExel;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton buscar;
    }
}