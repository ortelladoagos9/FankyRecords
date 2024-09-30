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
            this.BdescargarPDF = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bgenerar = new FontAwesome.Sharp.IconButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBnombreComprador = new System.Windows.Forms.TextBox();
            this.TBnumFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBtipoNC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BdescargarPDF);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(207, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 630);
            this.panel1.TabIndex = 0;
            // 
            // BdescargarPDF
            // 
            this.BdescargarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BdescargarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BdescargarPDF.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BdescargarPDF.IconChar = FontAwesome.Sharp.IconChar.File;
            this.BdescargarPDF.IconColor = System.Drawing.Color.DarkRed;
            this.BdescargarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BdescargarPDF.IconSize = 20;
            this.BdescargarPDF.Location = new System.Drawing.Point(554, 588);
            this.BdescargarPDF.Name = "BdescargarPDF";
            this.BdescargarPDF.Size = new System.Drawing.Size(145, 37);
            this.BdescargarPDF.TabIndex = 4;
            this.BdescargarPDF.Text = "Descargar PDF";
            this.BdescargarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BdescargarPDF.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.precio,
            this.cantidad,
            this.SubTotal});
            this.dataGridView1.Location = new System.Drawing.Point(17, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 228);
            this.dataGridView1.TabIndex = 3;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.Width = 250;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.Width = 120;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 120;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Bgenerar);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TBnombreComprador);
            this.groupBox2.Controls.Add(this.TBnumFactura);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de la Devolución";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Bgenerar
            // 
            this.Bgenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bgenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bgenerar.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.Bgenerar.IconColor = System.Drawing.Color.DarkRed;
            this.Bgenerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bgenerar.IconSize = 25;
            this.Bgenerar.Location = new System.Drawing.Point(381, 90);
            this.Bgenerar.Name = "Bgenerar";
            this.Bgenerar.Size = new System.Drawing.Size(183, 44);
            this.Bgenerar.TabIndex = 5;
            this.Bgenerar.Text = "Generar";
            this.Bgenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bgenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bgenerar.UseVisualStyleBackColor = true;
            this.Bgenerar.Click += new System.EventHandler(this.Bgenerar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(157, 23);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Devolver a stock";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre Comprador";
            // 
            // TBnombreComprador
            // 
            this.TBnombreComprador.Location = new System.Drawing.Point(354, 56);
            this.TBnombreComprador.Name = "TBnombreComprador";
            this.TBnombreComprador.Size = new System.Drawing.Size(265, 26);
            this.TBnombreComprador.TabIndex = 2;
            this.TBnombreComprador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // TBnumFactura
            // 
            this.TBnumFactura.Location = new System.Drawing.Point(31, 56);
            this.TBnumFactura.Name = "TBnumFactura";
            this.TBnumFactura.Size = new System.Drawing.Size(199, 26);
            this.TBnumFactura.TabIndex = 1;
            this.TBnumFactura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TBnumFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número factura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBtipoNC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la Devolución";
            // 
            // CBtipoNC
            // 
            this.CBtipoNC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBtipoNC.FormattingEnabled = true;
            this.CBtipoNC.Items.AddRange(new object[] {
            "Nota de crédito A",
            "Nota de crédito B",
            "Nota de crédito C"});
            this.CBtipoNC.Location = new System.Drawing.Point(381, 58);
            this.CBtipoNC.Name = "CBtipoNC";
            this.CBtipoNC.Size = new System.Drawing.Size(266, 27);
            this.CBtipoNC.TabIndex = 3;
            this.CBtipoNC.Text = "Nota de crédita A";
            this.CBtipoNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Nota de Crédito\r\n";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 58);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 9, 30, 13, 25, 37, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 26);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2024, 9, 30, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devoluciones";
            // 
            // devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "devoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "devoluciones";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBtipoNC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBnombreComprador;
        private System.Windows.Forms.TextBox TBnumFactura;
        private System.Windows.Forms.CheckBox checkBox1;
        private FontAwesome.Sharp.IconButton Bgenerar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton BdescargarPDF;
    }
}