namespace FankyRecords.C_presentacion.Administrador
{
    partial class detalleCompra
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bbuscar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Blimpiar = new FontAwesome.Sharp.IconButton();
            this.TBnumCompra = new System.Windows.Forms.TextBox();
            this.LnumDoc = new System.Windows.Forms.Label();
            this.LdetalleCompra = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productoComprado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadComprada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.FechaCopraDetalle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBtipoDoc = new System.Windows.Forms.TextBox();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.Lusuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LmontoTotal = new System.Windows.Forms.Label();
            this.TBmontoTotal = new System.Windows.Forms.TextBox();
            this.BdescargarPDF = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BdescargarPDF);
            this.panel1.Controls.Add(this.TBmontoTotal);
            this.panel1.Controls.Add(this.LmontoTotal);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.Bbuscar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Blimpiar);
            this.panel1.Controls.Add(this.TBnumCompra);
            this.panel1.Controls.Add(this.LnumDoc);
            this.panel1.Controls.Add(this.LdetalleCompra);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(214, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 616);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(19, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 141);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Proveedor";
            // 
            // Bbuscar
            // 
            this.Bbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bbuscar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.Bbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.Bbuscar.IconColor = System.Drawing.Color.DarkRed;
            this.Bbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bbuscar.IconSize = 19;
            this.Bbuscar.Location = new System.Drawing.Point(433, 51);
            this.Bbuscar.Name = "Bbuscar";
            this.Bbuscar.Size = new System.Drawing.Size(104, 28);
            this.Bbuscar.TabIndex = 8;
            this.Bbuscar.Text = "Buscar";
            this.Bbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bbuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lusuario);
            this.groupBox1.Controls.Add(this.TBUsuario);
            this.groupBox1.Controls.Add(this.TBtipoDoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FechaCopraDetalle);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(19, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 152);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inormación Compra";
            // 
            // Blimpiar
            // 
            this.Blimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Blimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blimpiar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blimpiar.ForeColor = System.Drawing.Color.DarkRed;
            this.Blimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.Blimpiar.IconColor = System.Drawing.Color.DarkRed;
            this.Blimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Blimpiar.IconSize = 19;
            this.Blimpiar.Location = new System.Drawing.Point(543, 50);
            this.Blimpiar.Name = "Blimpiar";
            this.Blimpiar.Size = new System.Drawing.Size(104, 28);
            this.Blimpiar.TabIndex = 6;
            this.Blimpiar.Text = "Limpiar";
            this.Blimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Blimpiar.UseVisualStyleBackColor = true;
            // 
            // TBnumCompra
            // 
            this.TBnumCompra.Location = new System.Drawing.Point(327, 53);
            this.TBnumCompra.Name = "TBnumCompra";
            this.TBnumCompra.Size = new System.Drawing.Size(100, 26);
            this.TBnumCompra.TabIndex = 4;
            this.TBnumCompra.TextChanged += new System.EventHandler(this.TBnumCompra_TextChanged);
            this.TBnumCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // LnumDoc
            // 
            this.LnumDoc.AutoSize = true;
            this.LnumDoc.ForeColor = System.Drawing.Color.DarkRed;
            this.LnumDoc.Location = new System.Drawing.Point(186, 58);
            this.LnumDoc.Name = "LnumDoc";
            this.LnumDoc.Size = new System.Drawing.Size(142, 19);
            this.LnumDoc.TabIndex = 3;
            this.LnumDoc.Text = "Número Compra:";
            // 
            // LdetalleCompra
            // 
            this.LdetalleCompra.AutoSize = true;
            this.LdetalleCompra.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LdetalleCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.LdetalleCompra.Location = new System.Drawing.Point(15, 12);
            this.LdetalleCompra.Name = "LdetalleCompra";
            this.LdetalleCompra.Size = new System.Drawing.Size(167, 23);
            this.LdetalleCompra.TabIndex = 2;
            this.LdetalleCompra.Text = "Detalle Compra";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productoComprado,
            this.precioCompra,
            this.cantidadComprada,
            this.subtotal});
            this.dataGridView1.Location = new System.Drawing.Point(19, 416);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // productoComprado
            // 
            this.productoComprado.HeaderText = "Producto";
            this.productoComprado.Name = "productoComprado";
            this.productoComprado.Width = 250;
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio Compra";
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.Width = 150;
            // 
            // cantidadComprada
            // 
            this.cantidadComprada.HeaderText = "Cantidad";
            this.cantidadComprada.Name = "cantidadComprada";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(21, 83);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // FechaCopraDetalle
            // 
            this.FechaCopraDetalle.AutoSize = true;
            this.FechaCopraDetalle.Location = new System.Drawing.Point(17, 52);
            this.FechaCopraDetalle.Name = "FechaCopraDetalle";
            this.FechaCopraDetalle.Size = new System.Drawing.Size(56, 19);
            this.FechaCopraDetalle.TabIndex = 1;
            this.FechaCopraDetalle.Text = "Fecha";
            this.FechaCopraDetalle.Click += new System.EventHandler(this.FechaCopraDetalle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo Documento";
            // 
            // TBtipoDoc
            // 
            this.TBtipoDoc.Location = new System.Drawing.Point(171, 83);
            this.TBtipoDoc.Name = "TBtipoDoc";
            this.TBtipoDoc.Size = new System.Drawing.Size(183, 26);
            this.TBtipoDoc.TabIndex = 3;
            this.TBtipoDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(428, 83);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(181, 26);
            this.TBUsuario.TabIndex = 4;
            this.TBUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // Lusuario
            // 
            this.Lusuario.AutoSize = true;
            this.Lusuario.Location = new System.Drawing.Point(424, 52);
            this.Lusuario.Name = "Lusuario";
            this.Lusuario.Size = new System.Drawing.Size(71, 19);
            this.Lusuario.TabIndex = 5;
            this.Lusuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero Documento";
            // 
            // TB
            // 
            this.TB.Location = new System.Drawing.Point(21, 70);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(160, 26);
            this.TB.TabIndex = 1;
            this.TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razón Social";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // LmontoTotal
            // 
            this.LmontoTotal.AutoSize = true;
            this.LmontoTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.LmontoTotal.Location = new System.Drawing.Point(15, 582);
            this.LmontoTotal.Name = "LmontoTotal";
            this.LmontoTotal.Size = new System.Drawing.Size(106, 19);
            this.LmontoTotal.TabIndex = 10;
            this.LmontoTotal.Text = "Monto Total:";
            // 
            // TBmontoTotal
            // 
            this.TBmontoTotal.Location = new System.Drawing.Point(127, 579);
            this.TBmontoTotal.Name = "TBmontoTotal";
            this.TBmontoTotal.Size = new System.Drawing.Size(170, 26);
            this.TBmontoTotal.TabIndex = 11;
            this.TBmontoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // BdescargarPDF
            // 
            this.BdescargarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BdescargarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BdescargarPDF.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BdescargarPDF.ForeColor = System.Drawing.Color.DarkRed;
            this.BdescargarPDF.IconChar = FontAwesome.Sharp.IconChar.File;
            this.BdescargarPDF.IconColor = System.Drawing.Color.DarkRed;
            this.BdescargarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BdescargarPDF.IconSize = 19;
            this.BdescargarPDF.Location = new System.Drawing.Point(424, 577);
            this.BdescargarPDF.Name = "BdescargarPDF";
            this.BdescargarPDF.Size = new System.Drawing.Size(174, 31);
            this.BdescargarPDF.TabIndex = 12;
            this.BdescargarPDF.Text = "Descargar en PDF";
            this.BdescargarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BdescargarPDF.UseVisualStyleBackColor = true;
            // 
            // detalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "detalleCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "detalleCompra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoComprado;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadComprada;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Label LdetalleCompra;
        private System.Windows.Forms.Label LnumDoc;
        private FontAwesome.Sharp.IconButton Blimpiar;
        private System.Windows.Forms.TextBox TBnumCompra;
        private FontAwesome.Sharp.IconButton Bbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label FechaCopraDetalle;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox TBtipoDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.Label Lusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LmontoTotal;
        private FontAwesome.Sharp.IconButton BdescargarPDF;
        private System.Windows.Forms.TextBox TBmontoTotal;
    }
}