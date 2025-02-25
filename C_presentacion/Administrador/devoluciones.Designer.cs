namespace FankyRecords.C_presentacion.Administrador
{
    partial class devoluciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Bgenerar = new FontAwesome.Sharp.IconButton();
            this.ckbDevolverStock = new System.Windows.Forms.CheckBox();
            this.contenedorDevoluciones = new System.Windows.Forms.Panel();
            this.LDevoluciones = new System.Windows.Forms.Label();
            this.listadoProductosDevolucion = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBnombreComprador = new System.Windows.Forms.TextBox();
            this.TBnumFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBtipoNC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DTFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contenedorDevoluciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductosDevolucion)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.contenedorDevoluciones);
            this.panel1.Controls.Add(this.listadoProductosDevolucion);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1418, 739);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.Bgenerar);
            this.panel2.Controls.Add(this.ckbDevolverStock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1042, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 446);
            this.panel2.TabIndex = 41;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButton1.IconColor = System.Drawing.Color.DarkRed;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(89, 228);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(186, 54);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Descargar PDF";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // Bgenerar
            // 
            this.Bgenerar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bgenerar.BackColor = System.Drawing.Color.White;
            this.Bgenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bgenerar.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bgenerar.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.Bgenerar.IconColor = System.Drawing.Color.DarkRed;
            this.Bgenerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bgenerar.IconSize = 25;
            this.Bgenerar.Location = new System.Drawing.Point(89, 174);
            this.Bgenerar.Margin = new System.Windows.Forms.Padding(2);
            this.Bgenerar.Name = "Bgenerar";
            this.Bgenerar.Size = new System.Drawing.Size(186, 39);
            this.Bgenerar.TabIndex = 5;
            this.Bgenerar.Text = "Guardar";
            this.Bgenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bgenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bgenerar.UseVisualStyleBackColor = false;
            this.Bgenerar.Click += new System.EventHandler(this.Bgenerar_Click);
            // 
            // ckbDevolverStock
            // 
            this.ckbDevolverStock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ckbDevolverStock.AutoSize = true;
            this.ckbDevolverStock.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDevolverStock.Location = new System.Drawing.Point(89, 127);
            this.ckbDevolverStock.Margin = new System.Windows.Forms.Padding(2);
            this.ckbDevolverStock.Name = "ckbDevolverStock";
            this.ckbDevolverStock.Size = new System.Drawing.Size(186, 25);
            this.ckbDevolverStock.TabIndex = 4;
            this.ckbDevolverStock.Text = "Devolver a stock";
            this.ckbDevolverStock.UseVisualStyleBackColor = true;
            // 
            // contenedorDevoluciones
            // 
            this.contenedorDevoluciones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDevoluciones.Controls.Add(this.LDevoluciones);
            this.contenedorDevoluciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorDevoluciones.Location = new System.Drawing.Point(0, 0);
            this.contenedorDevoluciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorDevoluciones.Name = "contenedorDevoluciones";
            this.contenedorDevoluciones.Size = new System.Drawing.Size(1418, 62);
            this.contenedorDevoluciones.TabIndex = 40;
            // 
            // LDevoluciones
            // 
            this.LDevoluciones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LDevoluciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LDevoluciones.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDevoluciones.ForeColor = System.Drawing.Color.DarkRed;
            this.LDevoluciones.Location = new System.Drawing.Point(0, 0);
            this.LDevoluciones.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LDevoluciones.Name = "LDevoluciones";
            this.LDevoluciones.Size = new System.Drawing.Size(1418, 62);
            this.LDevoluciones.TabIndex = 0;
            this.LDevoluciones.Text = "Devoluciones";
            this.LDevoluciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // listadoProductosDevolucion
            // 
            this.listadoProductosDevolucion.AllowUserToAddRows = false;
            this.listadoProductosDevolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoProductosDevolucion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listadoProductosDevolucion.BackgroundColor = System.Drawing.Color.White;
            this.listadoProductosDevolucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoProductosDevolucion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoProductosDevolucion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.listadoProductosDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoProductosDevolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.precio,
            this.cantidad,
            this.stock,
            this.SubTotal});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoProductosDevolucion.DefaultCellStyle = dataGridViewCellStyle12;
            this.listadoProductosDevolucion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoProductosDevolucion.Location = new System.Drawing.Point(0, 508);
            this.listadoProductosDevolucion.Margin = new System.Windows.Forms.Padding(2);
            this.listadoProductosDevolucion.Name = "listadoProductosDevolucion";
            this.listadoProductosDevolucion.ReadOnly = true;
            this.listadoProductosDevolucion.RowHeadersWidth = 51;
            this.listadoProductosDevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoProductosDevolucion.Size = new System.Drawing.Size(1418, 231);
            this.listadoProductosDevolucion.TabIndex = 3;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TBnombreComprador);
            this.groupBox2.Controls.Add(this.TBnumFactura);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(28, 291);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(985, 190);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de la Devolución";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(512, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre Comprador:";
            // 
            // TBnombreComprador
            // 
            this.TBnombreComprador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBnombreComprador.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombreComprador.Location = new System.Drawing.Point(512, 98);
            this.TBnombreComprador.Margin = new System.Windows.Forms.Padding(2);
            this.TBnombreComprador.Name = "TBnombreComprador";
            this.TBnombreComprador.ShortcutsEnabled = false;
            this.TBnombreComprador.Size = new System.Drawing.Size(238, 28);
            this.TBnombreComprador.TabIndex = 2;
            this.TBnombreComprador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // TBnumFactura
            // 
            this.TBnumFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBnumFactura.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnumFactura.Location = new System.Drawing.Point(212, 98);
            this.TBnumFactura.Margin = new System.Windows.Forms.Padding(2);
            this.TBnumFactura.Name = "TBnumFactura";
            this.TBnumFactura.ShortcutsEnabled = false;
            this.TBnumFactura.Size = new System.Drawing.Size(238, 28);
            this.TBnumFactura.TabIndex = 1;
            this.TBnumFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número factura:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CBtipoNC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DTFechaDevolucion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(28, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(985, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la Devolución";
            // 
            // CBtipoNC
            // 
            this.CBtipoNC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBtipoNC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBtipoNC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBtipoNC.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtipoNC.FormattingEnabled = true;
            this.CBtipoNC.Items.AddRange(new object[] {
            "Nota de crédito A",
            "Nota de crédito B",
            "Nota de crédito C"});
            this.CBtipoNC.Location = new System.Drawing.Point(512, 100);
            this.CBtipoNC.Margin = new System.Windows.Forms.Padding(2);
            this.CBtipoNC.Name = "CBtipoNC";
            this.CBtipoNC.Size = new System.Drawing.Size(238, 33);
            this.CBtipoNC.TabIndex = 3;
            this.CBtipoNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Nota de Crédito\r\n:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DTFechaDevolucion
            // 
            this.DTFechaDevolucion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTFechaDevolucion.CalendarFont = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaDevolucion.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaDevolucion.Location = new System.Drawing.Point(212, 101);
            this.DTFechaDevolucion.Margin = new System.Windows.Forms.Padding(2);
            this.DTFechaDevolucion.MaxDate = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            this.DTFechaDevolucion.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.DTFechaDevolucion.Name = "DTFechaDevolucion";
            this.DTFechaDevolucion.Size = new System.Drawing.Size(238, 32);
            this.DTFechaDevolucion.TabIndex = 1;
            this.DTFechaDevolucion.Value = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1418, 739);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "devoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "devoluciones";
            this.Load += new System.EventHandler(this.devoluciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contenedorDevoluciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductosDevolucion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBtipoNC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTFechaDevolucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBnombreComprador;
        private System.Windows.Forms.TextBox TBnumFactura;
        private System.Windows.Forms.CheckBox ckbDevolverStock;
        private FontAwesome.Sharp.IconButton Bgenerar;
        private System.Windows.Forms.DataGridView listadoProductosDevolucion;
        public System.Windows.Forms.Panel contenedorDevoluciones;
        public System.Windows.Forms.Label LDevoluciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}