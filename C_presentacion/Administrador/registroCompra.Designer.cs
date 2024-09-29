namespace FankyRecords.C_presentacion.Administrador
{
    partial class registroCompra
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.registrarCompra = new FontAwesome.Sharp.IconButton();
            this.TBtotalPagar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BAgregarProd = new FontAwesome.Sharp.IconButton();
            this.DGcompraProd = new System.Windows.Forms.DataGridView();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cantProd = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TBprecio = new System.Windows.Forms.TextBox();
            this.TBproduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.TBcodProdunto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.TBrazonSocial = new System.Windows.Forms.TextBox();
            this.TBcuil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipoDoc = new System.Windows.Forms.ComboBox();
            this.Fecha = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGcompraProd)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantProd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 56);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Compra";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel2.Controls.Add(this.registrarCompra);
            this.panel2.Controls.Add(this.TBtotalPagar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.BAgregarProd);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(921, 56);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 598);
            this.panel2.TabIndex = 1;
            // 
            // registrarCompra
            // 
            this.registrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.registrarCompra.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.registrarCompra.IconColor = System.Drawing.Color.DarkRed;
            this.registrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrarCompra.Location = new System.Drawing.Point(29, 529);
            this.registrarCompra.Name = "registrarCompra";
            this.registrarCompra.Size = new System.Drawing.Size(182, 48);
            this.registrarCompra.TabIndex = 3;
            this.registrarCompra.Text = "Registrar";
            this.registrarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.registrarCompra.UseVisualStyleBackColor = true;
            this.registrarCompra.Click += new System.EventHandler(this.registrarCompra_Click);
            // 
            // TBtotalPagar
            // 
            this.TBtotalPagar.Location = new System.Drawing.Point(29, 491);
            this.TBtotalPagar.Name = "TBtotalPagar";
            this.TBtotalPagar.Size = new System.Drawing.Size(182, 22);
            this.TBtotalPagar.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(25, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total a Pagar";
            // 
            // BAgregarProd
            // 
            this.BAgregarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregarProd.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarProd.ForeColor = System.Drawing.Color.DarkRed;
            this.BAgregarProd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BAgregarProd.IconColor = System.Drawing.Color.DarkRed;
            this.BAgregarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BAgregarProd.Location = new System.Drawing.Point(48, 216);
            this.BAgregarProd.Name = "BAgregarProd";
            this.BAgregarProd.Size = new System.Drawing.Size(144, 116);
            this.BAgregarProd.TabIndex = 0;
            this.BAgregarProd.Text = "Agregar";
            this.BAgregarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BAgregarProd.UseVisualStyleBackColor = true;
            this.BAgregarProd.Click += new System.EventHandler(this.BAgregarProd_Click);
            // 
            // DGcompraProd
            // 
            this.DGcompraProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGcompraProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProducto,
            this.nombreProducto,
            this.precioCompra,
            this.cantidadProducto,
            this.subTotalProducto});
            this.DGcompraProd.Location = new System.Drawing.Point(0, 445);
            this.DGcompraProd.Name = "DGcompraProd";
            this.DGcompraProd.Size = new System.Drawing.Size(921, 209);
            this.DGcompraProd.TabIndex = 2;
            // 
            // codigoProducto
            // 
            this.codigoProducto.HeaderText = "Código";
            this.codigoProducto.Name = "codigoProducto";
            this.codigoProducto.Width = 130;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Width = 300;
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio Compra";
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.Width = 150;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "Cantidad";
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.Width = 150;
            // 
            // subTotalProducto
            // 
            this.subTotalProducto.HeaderText = "Sub total";
            this.subTotalProducto.Name = "subTotalProducto";
            this.subTotalProducto.Width = 150;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(3, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(921, 389);
            this.panel3.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cantProd);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TBprecio);
            this.groupBox3.Controls.Add(this.TBproduct);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.iconButton3);
            this.groupBox3.Controls.Add(this.TBcodProdunto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Location = new System.Drawing.Point(9, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(884, 193);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de Productos";
            // 
            // cantProd
            // 
            this.cantProd.Location = new System.Drawing.Point(731, 84);
            this.cantProd.Name = "cantProd";
            this.cantProd.Size = new System.Drawing.Size(120, 26);
            this.cantProd.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(736, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(571, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Precio";
            // 
            // TBprecio
            // 
            this.TBprecio.Location = new System.Drawing.Point(575, 83);
            this.TBprecio.Name = "TBprecio";
            this.TBprecio.Size = new System.Drawing.Size(114, 26);
            this.TBprecio.TabIndex = 8;
            this.TBprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // TBproduct
            // 
            this.TBproduct.Location = new System.Drawing.Point(237, 84);
            this.TBproduct.Name = "TBproduct";
            this.TBproduct.Size = new System.Drawing.Size(277, 26);
            this.TBproduct.TabIndex = 7;
            this.TBproduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Producto";
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton3.IconColor = System.Drawing.Color.DarkRed;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.Location = new System.Drawing.Point(151, 83);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(34, 27);
            this.iconButton3.TabIndex = 5;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // TBcodProdunto
            // 
            this.TBcodProdunto.Location = new System.Drawing.Point(10, 84);
            this.TBcodProdunto.Name = "TBcodProdunto";
            this.TBcodProdunto.Size = new System.Drawing.Size(135, 26);
            this.TBcodProdunto.TabIndex = 1;
            this.TBcodProdunto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cdigo Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iconButton1);
            this.groupBox2.Controls.Add(this.TBrazonSocial);
            this.groupBox2.Controls.Add(this.TBcuil);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(454, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Proveedor";
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.DarkRed;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(167, 54);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(34, 27);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // TBrazonSocial
            // 
            this.TBrazonSocial.Location = new System.Drawing.Point(240, 54);
            this.TBrazonSocial.Name = "TBrazonSocial";
            this.TBrazonSocial.Size = new System.Drawing.Size(199, 26);
            this.TBrazonSocial.TabIndex = 3;
            this.TBrazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // TBcuil
            // 
            this.TBcuil.Location = new System.Drawing.Point(31, 54);
            this.TBcuil.Name = "TBcuil";
            this.TBcuil.Size = new System.Drawing.Size(130, 26);
            this.TBcuil.TabIndex = 2;
            this.TBcuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Razón Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cuit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipoDoc);
            this.groupBox1.Controls.Add(this.Fecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(9, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "información compra";
            // 
            // tipoDoc
            // 
            this.tipoDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tipoDoc.FormattingEnabled = true;
            this.tipoDoc.Items.AddRange(new object[] {
            "Factura",
            "Remito"});
            this.tipoDoc.Location = new System.Drawing.Point(192, 54);
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.Size = new System.Drawing.Size(157, 27);
            this.tipoDoc.TabIndex = 3;
            this.tipoDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(25, 54);
            this.Fecha.Mask = "00/00/0000";
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(122, 26);
            this.Fecha.TabIndex = 2;
            this.Fecha.ValidatingType = typeof(System.DateTime);
            this.Fecha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // registroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DGcompraProd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "registroCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGcompraProd)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantProd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGcompraProd;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton BAgregarProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Fecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox tipoDoc;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox TBrazonSocial;
        private System.Windows.Forms.TextBox TBcuil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton registrarCompra;
        private System.Windows.Forms.TextBox TBtotalPagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.TextBox TBcodProdunto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown cantProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBprecio;
        private System.Windows.Forms.TextBox TBproduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalProducto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}