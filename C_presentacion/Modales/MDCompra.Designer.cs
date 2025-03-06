namespace FankyRecords.C_presentacion.Modales
{
    partial class MDCompra
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listadoCompras = new System.Windows.Forms.DataGridView();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contenedorLista = new System.Windows.Forms.Panel();
            this.Lbuscar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.TBBuscador = new System.Windows.Forms.TextBox();
            this.LListaCompras = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            this.contenedorLista.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listadoCompras
            // 
            this.listadoCompras.AllowUserToAddRows = false;
            this.listadoCompras.AutoGenerateColumns = false;
            this.listadoCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listadoCompras.BackgroundColor = System.Drawing.Color.White;
            this.listadoCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroCompra,
            this.MontoTotal,
            this.NumeroFactura,
            this.FechaCompra,
            this.razonS,
            this.cuit,
            this.usuario,
            this.tipoDoc});
            this.listadoCompras.DataSource = this.compraBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.listadoCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoCompras.Location = new System.Drawing.Point(0, 112);
            this.listadoCompras.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listadoCompras.Name = "listadoCompras";
            this.listadoCompras.ReadOnly = true;
            this.listadoCompras.RowHeadersWidth = 51;
            this.listadoCompras.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.listadoCompras.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.listadoCompras.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.listadoCompras.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listadoCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoCompras.Size = new System.Drawing.Size(1067, 442);
            this.listadoCompras.TabIndex = 23;
            this.listadoCompras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoCompras_CellDoubleClick);
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataSource = typeof(FankyRecords.C_entidad.Compra);
            // 
            // contenedorLista
            // 
            this.contenedorLista.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorLista.Controls.Add(this.Lbuscar);
            this.contenedorLista.Controls.Add(this.panel1);
            this.contenedorLista.Controls.Add(this.LListaCompras);
            this.contenedorLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorLista.Location = new System.Drawing.Point(0, 0);
            this.contenedorLista.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.contenedorLista.Name = "contenedorLista";
            this.contenedorLista.Size = new System.Drawing.Size(1067, 112);
            this.contenedorLista.TabIndex = 22;
            // 
            // Lbuscar
            // 
            this.Lbuscar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Lbuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lbuscar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbuscar.Location = new System.Drawing.Point(634, 0);
            this.Lbuscar.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lbuscar.Name = "Lbuscar";
            this.Lbuscar.Size = new System.Drawing.Size(139, 112);
            this.Lbuscar.TabIndex = 0;
            this.Lbuscar.Text = "Buscar:";
            this.Lbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.TBBuscador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(773, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 112);
            this.panel1.TabIndex = 37;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(234, 39);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TBBuscador
            // 
            this.TBBuscador.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscador.ForeColor = System.Drawing.Color.Black;
            this.TBBuscador.Location = new System.Drawing.Point(18, 39);
            this.TBBuscador.Margin = new System.Windows.Forms.Padding(18, 5, 6, 5);
            this.TBBuscador.Name = "TBBuscador";
            this.TBBuscador.Size = new System.Drawing.Size(204, 35);
            this.TBBuscador.TabIndex = 33;
            this.TBBuscador.TextChanged += new System.EventHandler(this.TBBuscador_TextChanged);
            // 
            // LListaCompras
            // 
            this.LListaCompras.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LListaCompras.Dock = System.Windows.Forms.DockStyle.Left;
            this.LListaCompras.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaCompras.ForeColor = System.Drawing.Color.DarkRed;
            this.LListaCompras.Location = new System.Drawing.Point(0, 0);
            this.LListaCompras.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LListaCompras.Name = "LListaCompras";
            this.LListaCompras.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.LListaCompras.Size = new System.Drawing.Size(550, 112);
            this.LListaCompras.TabIndex = 12;
            this.LListaCompras.Text = "Lista de Compras";
            this.LListaCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Obj_proveedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "cuit";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 254;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Obj_proveedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Razon social";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 508;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Obj_proveedor";
            this.dataGridViewTextBoxColumn3.HeaderText = "cuit";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 508;
            // 
            // NumeroCompra
            // 
            this.NumeroCompra.DataPropertyName = "NumeroCompra";
            this.NumeroCompra.HeaderText = "Número Compra";
            this.NumeroCompra.MinimumWidth = 6;
            this.NumeroCompra.Name = "NumeroCompra";
            this.NumeroCompra.ReadOnly = true;
            // 
            // MontoTotal
            // 
            this.MontoTotal.DataPropertyName = "MontoTotal";
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.MinimumWidth = 6;
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            this.MontoTotal.Visible = false;
            // 
            // NumeroFactura
            // 
            this.NumeroFactura.DataPropertyName = "NumeroFactura";
            this.NumeroFactura.HeaderText = "Número Factura";
            this.NumeroFactura.MinimumWidth = 6;
            this.NumeroFactura.Name = "NumeroFactura";
            this.NumeroFactura.ReadOnly = true;
            // 
            // FechaCompra
            // 
            this.FechaCompra.DataPropertyName = "FechaCompra";
            this.FechaCompra.HeaderText = "Fecha Compra";
            this.FechaCompra.MinimumWidth = 6;
            this.FechaCompra.Name = "FechaCompra";
            this.FechaCompra.ReadOnly = true;
            // 
            // razonS
            // 
            this.razonS.DataPropertyName = "Obj_proveedor";
            this.razonS.HeaderText = "Razon social";
            this.razonS.MinimumWidth = 6;
            this.razonS.Name = "razonS";
            this.razonS.ReadOnly = true;
            this.razonS.Visible = false;
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "Obj_proveedor";
            this.cuit.HeaderText = "cuit";
            this.cuit.MinimumWidth = 6;
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            this.cuit.Visible = false;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "Obj_usuarios";
            this.usuario.HeaderText = "usuarios";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            // 
            // tipoDoc
            // 
            this.tipoDoc.DataPropertyName = "Obj_Tipo_Doc";
            this.tipoDoc.HeaderText = "Tipo_Doc";
            this.tipoDoc.MinimumWidth = 6;
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.ReadOnly = true;
            this.tipoDoc.Visible = false;
            // 
            // MDCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listadoCompras);
            this.Controls.Add(this.contenedorLista);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Compras";
            this.Load += new System.EventHandler(this.MDCompra_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MDCompra_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.listadoCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            this.contenedorLista.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView listadoCompras;
        public System.Windows.Forms.Panel contenedorLista;
        public System.Windows.Forms.Label Lbuscar;
        private System.Windows.Forms.Panel panel1;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public System.Windows.Forms.TextBox TBBuscador;
        public System.Windows.Forms.Label LListaCompras;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
    }
}