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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscarNroCompra = new FontAwesome.Sharp.IconButton();
            this.contenedorDetalleCompra = new System.Windows.Forms.Panel();
            this.LdetalleCompra = new System.Windows.Forms.Label();
            this.TBmontoTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LnumDoc = new System.Windows.Forms.Label();
            this.LmontoTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.Lusuario = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBtipoDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaCopraDetalle = new System.Windows.Forms.Label();
            this.TBnumCompra = new System.Windows.Forms.TextBox();
            this.listadoCompras = new System.Windows.Forms.DataGridView();
            this.productoComprado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadComprada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.contenedorDetalleCompra.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnBuscarNroCompra);
            this.panel1.Controls.Add(this.contenedorDetalleCompra);
            this.panel1.Controls.Add(this.TBmontoTotal);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.LnumDoc);
            this.panel1.Controls.Add(this.LmontoTotal);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.TBnumCompra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 435);
            this.panel1.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 18;
            this.btnLimpiar.Location = new System.Drawing.Point(1099, 137);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(46, 26);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBuscarNroCompra
            // 
            this.btnBuscarNroCompra.BackColor = System.Drawing.Color.White;
            this.btnBuscarNroCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarNroCompra.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarNroCompra.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarNroCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarNroCompra.IconSize = 18;
            this.btnBuscarNroCompra.Location = new System.Drawing.Point(1041, 137);
            this.btnBuscarNroCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarNroCompra.Name = "btnBuscarNroCompra";
            this.btnBuscarNroCompra.Size = new System.Drawing.Size(46, 26);
            this.btnBuscarNroCompra.TabIndex = 24;
            this.btnBuscarNroCompra.UseVisualStyleBackColor = false;
            // 
            // contenedorDetalleCompra
            // 
            this.contenedorDetalleCompra.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDetalleCompra.Controls.Add(this.LdetalleCompra);
            this.contenedorDetalleCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorDetalleCompra.Location = new System.Drawing.Point(0, 0);
            this.contenedorDetalleCompra.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorDetalleCompra.Name = "contenedorDetalleCompra";
            this.contenedorDetalleCompra.Size = new System.Drawing.Size(1182, 56);
            this.contenedorDetalleCompra.TabIndex = 23;
            // 
            // LdetalleCompra
            // 
            this.LdetalleCompra.Dock = System.Windows.Forms.DockStyle.Left;
            this.LdetalleCompra.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LdetalleCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.LdetalleCompra.Location = new System.Drawing.Point(0, 0);
            this.LdetalleCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LdetalleCompra.Name = "LdetalleCompra";
            this.LdetalleCompra.Size = new System.Drawing.Size(330, 56);
            this.LdetalleCompra.TabIndex = 2;
            this.LdetalleCompra.Text = "Detalle Compra";
            this.LdetalleCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TBmontoTotal
            // 
            this.TBmontoTotal.Location = new System.Drawing.Point(1016, 377);
            this.TBmontoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.TBmontoTotal.Name = "TBmontoTotal";
            this.TBmontoTotal.ReadOnly = true;
            this.TBmontoTotal.Size = new System.Drawing.Size(121, 26);
            this.TBmontoTotal.TabIndex = 11;
            this.TBmontoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(24, 261);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(872, 144);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Proveedor";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(517, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(203, 28);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razón Social:";
            // 
            // TB
            // 
            this.TB.Location = new System.Drawing.Point(136, 66);
            this.TB.Margin = new System.Windows.Forms.Padding(2);
            this.TB.Name = "TB";
            this.TB.ReadOnly = true;
            this.TB.Size = new System.Drawing.Size(187, 28);
            this.TB.TabIndex = 1;
            this.TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número Documento:";
            // 
            // LnumDoc
            // 
            this.LnumDoc.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnumDoc.ForeColor = System.Drawing.Color.DarkRed;
            this.LnumDoc.Location = new System.Drawing.Point(949, 73);
            this.LnumDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LnumDoc.Name = "LnumDoc";
            this.LnumDoc.Size = new System.Drawing.Size(161, 28);
            this.LnumDoc.TabIndex = 3;
            this.LnumDoc.Text = "Número Compra:";
            this.LnumDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LmontoTotal
            // 
            this.LmontoTotal.AutoSize = true;
            this.LmontoTotal.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LmontoTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.LmontoTotal.Location = new System.Drawing.Point(1016, 351);
            this.LmontoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LmontoTotal.Name = "LmontoTotal";
            this.LmontoTotal.Size = new System.Drawing.Size(121, 21);
            this.LmontoTotal.TabIndex = 10;
            this.LmontoTotal.Text = "Monto Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBFecha);
            this.groupBox1.Controls.Add(this.Lusuario);
            this.groupBox1.Controls.Add(this.TBUsuario);
            this.groupBox1.Controls.Add(this.TBtipoDoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FechaCopraDetalle);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(24, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(872, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra";
            // 
            // TBFecha
            // 
            this.TBFecha.Location = new System.Drawing.Point(86, 68);
            this.TBFecha.Margin = new System.Windows.Forms.Padding(2);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(155, 28);
            this.TBFecha.TabIndex = 7;
            // 
            // Lusuario
            // 
            this.Lusuario.AutoSize = true;
            this.Lusuario.Location = new System.Drawing.Point(615, 43);
            this.Lusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lusuario.Name = "Lusuario";
            this.Lusuario.Size = new System.Drawing.Size(85, 21);
            this.Lusuario.TabIndex = 5;
            this.Lusuario.Text = "Usuario:";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(615, 68);
            this.TBUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.ReadOnly = true;
            this.TBUsuario.Size = new System.Drawing.Size(155, 28);
            this.TBUsuario.TabIndex = 4;
            this.TBUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // TBtipoDoc
            // 
            this.TBtipoDoc.Location = new System.Drawing.Point(348, 68);
            this.TBtipoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.TBtipoDoc.Name = "TBtipoDoc";
            this.TBtipoDoc.ReadOnly = true;
            this.TBtipoDoc.Size = new System.Drawing.Size(155, 28);
            this.TBtipoDoc.TabIndex = 3;
            this.TBtipoDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabra_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo Documento:";
            // 
            // FechaCopraDetalle
            // 
            this.FechaCopraDetalle.AutoSize = true;
            this.FechaCopraDetalle.Location = new System.Drawing.Point(86, 43);
            this.FechaCopraDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaCopraDetalle.Name = "FechaCopraDetalle";
            this.FechaCopraDetalle.Size = new System.Drawing.Size(68, 21);
            this.FechaCopraDetalle.TabIndex = 1;
            this.FechaCopraDetalle.Text = "Fecha:";
            // 
            // TBnumCompra
            // 
            this.TBnumCompra.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnumCompra.Location = new System.Drawing.Point(949, 102);
            this.TBnumCompra.Margin = new System.Windows.Forms.Padding(2);
            this.TBnumCompra.Name = "TBnumCompra";
            this.TBnumCompra.Size = new System.Drawing.Size(196, 28);
            this.TBnumCompra.TabIndex = 4;
            this.TBnumCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // listadoCompras
            // 
            this.listadoCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listadoCompras.BackgroundColor = System.Drawing.Color.White;
            this.listadoCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productoComprado,
            this.precioCompra,
            this.cantidadComprada,
            this.subtotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.listadoCompras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoCompras.Location = new System.Drawing.Point(0, 435);
            this.listadoCompras.Margin = new System.Windows.Forms.Padding(2);
            this.listadoCompras.Name = "listadoCompras";
            this.listadoCompras.RowHeadersWidth = 51;
            this.listadoCompras.Size = new System.Drawing.Size(1182, 219);
            this.listadoCompras.TabIndex = 1;
            // 
            // productoComprado
            // 
            this.productoComprado.HeaderText = "Producto";
            this.productoComprado.MinimumWidth = 6;
            this.productoComprado.Name = "productoComprado";
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio Compra";
            this.precioCompra.MinimumWidth = 6;
            this.precioCompra.Name = "precioCompra";
            // 
            // cantidadComprada
            // 
            this.cantidadComprada.HeaderText = "Cantidad";
            this.cantidadComprada.MinimumWidth = 6;
            this.cantidadComprada.Name = "cantidadComprada";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            // 
            // detalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listadoCompras);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "detalleCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "detalleCompra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contenedorDetalleCompra.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView listadoCompras;
        private System.Windows.Forms.Label LdetalleCompra;
        private System.Windows.Forms.Label LnumDoc;
        private System.Windows.Forms.TextBox TBnumCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label FechaCopraDetalle;
        private System.Windows.Forms.TextBox TBtipoDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LmontoTotal;
        private System.Windows.Forms.TextBox TBmontoTotal;
        public System.Windows.Forms.Panel contenedorDetalleCompra;
        public FontAwesome.Sharp.IconButton btnBuscarNroCompra;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.TextBox TBFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoComprado;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadComprada;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Label Lusuario;
        private System.Windows.Forms.TextBox TBUsuario;
    }
}