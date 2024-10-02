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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bgenerar = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckbDevolverStock = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBnombreComprador = new System.Windows.Forms.TextBox();
            this.TBnumFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBtipoNC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.contenedorDevoluciones = new System.Windows.Forms.Panel();
            this.LDevoluciones = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contenedorDevoluciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.contenedorDevoluciones);
            this.panel1.Controls.Add(this.Bgenerar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.ckbDevolverStock);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 654);
            this.panel1.TabIndex = 0;
            // 
            // Bgenerar
            // 
            this.Bgenerar.BackColor = System.Drawing.Color.White;
            this.Bgenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bgenerar.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.Bgenerar.IconColor = System.Drawing.Color.DarkRed;
            this.Bgenerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bgenerar.IconSize = 25;
            this.Bgenerar.Location = new System.Drawing.Point(993, 364);
            this.Bgenerar.Margin = new System.Windows.Forms.Padding(2);
            this.Bgenerar.Name = "Bgenerar";
            this.Bgenerar.Size = new System.Drawing.Size(141, 36);
            this.Bgenerar.TabIndex = 5;
            this.Bgenerar.Text = "Generar";
            this.Bgenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bgenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bgenerar.UseVisualStyleBackColor = false;
            this.Bgenerar.Click += new System.EventHandler(this.Bgenerar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.precio,
            this.cantidad,
            this.SubTotal});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 415);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 239);
            this.dataGridView1.TabIndex = 3;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.Width = 250;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.Width = 120;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 120;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 150;
            // 
            // ckbDevolverStock
            // 
            this.ckbDevolverStock.AutoSize = true;
            this.ckbDevolverStock.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDevolverStock.Location = new System.Drawing.Point(983, 335);
            this.ckbDevolverStock.Margin = new System.Windows.Forms.Padding(2);
            this.ckbDevolverStock.Name = "ckbDevolverStock";
            this.ckbDevolverStock.Size = new System.Drawing.Size(177, 25);
            this.ckbDevolverStock.TabIndex = 4;
            this.ckbDevolverStock.Text = "Devolver a stock";
            this.ckbDevolverStock.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TBnombreComprador);
            this.groupBox2.Controls.Add(this.TBnumFactura);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(201, 235);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(768, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de la Devolución";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre Comprador";
            // 
            // TBnombreComprador
            // 
            this.TBnombreComprador.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombreComprador.Location = new System.Drawing.Point(390, 69);
            this.TBnombreComprador.Margin = new System.Windows.Forms.Padding(2);
            this.TBnombreComprador.Name = "TBnombreComprador";
            this.TBnombreComprador.Size = new System.Drawing.Size(205, 28);
            this.TBnombreComprador.TabIndex = 2;
            this.TBnombreComprador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // TBnumFactura
            // 
            this.TBnumFactura.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnumFactura.Location = new System.Drawing.Point(146, 69);
            this.TBnumFactura.Margin = new System.Windows.Forms.Padding(2);
            this.TBnumFactura.Name = "TBnumFactura";
            this.TBnumFactura.Size = new System.Drawing.Size(154, 28);
            this.TBnumFactura.TabIndex = 1;
            this.TBnumFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número factura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBtipoNC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(201, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(768, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la Devolución";
            // 
            // CBtipoNC
            // 
            this.CBtipoNC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBtipoNC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBtipoNC.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtipoNC.FormattingEnabled = true;
            this.CBtipoNC.Items.AddRange(new object[] {
            "Nota de crédito A",
            "Nota de crédito B",
            "Nota de crédito C"});
            this.CBtipoNC.Location = new System.Drawing.Point(390, 70);
            this.CBtipoNC.Margin = new System.Windows.Forms.Padding(2);
            this.CBtipoNC.Name = "CBtipoNC";
            this.CBtipoNC.Size = new System.Drawing.Size(206, 29);
            this.CBtipoNC.TabIndex = 3;
            this.CBtipoNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Nota de Crédito\r\n";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 71);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 10, 2, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 10, 2, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 28);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2024, 10, 2, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha";
            // 
            // contenedorDevoluciones
            // 
            this.contenedorDevoluciones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDevoluciones.Controls.Add(this.LDevoluciones);
            this.contenedorDevoluciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorDevoluciones.Location = new System.Drawing.Point(0, 0);
            this.contenedorDevoluciones.Name = "contenedorDevoluciones";
            this.contenedorDevoluciones.Size = new System.Drawing.Size(1182, 56);
            this.contenedorDevoluciones.TabIndex = 40;
            // 
            // LDevoluciones
            // 
            this.LDevoluciones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LDevoluciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.LDevoluciones.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDevoluciones.ForeColor = System.Drawing.Color.DarkRed;
            this.LDevoluciones.Location = new System.Drawing.Point(0, 0);
            this.LDevoluciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDevoluciones.Name = "LDevoluciones";
            this.LDevoluciones.Size = new System.Drawing.Size(330, 56);
            this.LDevoluciones.TabIndex = 0;
            this.LDevoluciones.Text = "Devoluciones";
            this.LDevoluciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "devoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "devoluciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contenedorDevoluciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBtipoNC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBnombreComprador;
        private System.Windows.Forms.TextBox TBnumFactura;
        private System.Windows.Forms.CheckBox ckbDevolverStock;
        private FontAwesome.Sharp.IconButton Bgenerar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        public System.Windows.Forms.Panel contenedorDevoluciones;
        public System.Windows.Forms.Label LDevoluciones;
    }
}