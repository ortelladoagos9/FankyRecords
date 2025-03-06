namespace FankyRecords.C_presentacion.Modales
{
    partial class MDVenta
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
            this.contenedorLista = new System.Windows.Forms.Panel();
            this.Lbuscar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBBuscador = new System.Windows.Forms.TextBox();
            this.LListaVentas = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.listadoVentas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenedorLista.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedorLista
            // 
            this.contenedorLista.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorLista.Controls.Add(this.Lbuscar);
            this.contenedorLista.Controls.Add(this.panel1);
            this.contenedorLista.Controls.Add(this.LListaVentas);
            this.contenedorLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorLista.Location = new System.Drawing.Point(0, 0);
            this.contenedorLista.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.contenedorLista.Name = "contenedorLista";
            this.contenedorLista.Size = new System.Drawing.Size(1067, 112);
            this.contenedorLista.TabIndex = 23;
            // 
            // Lbuscar
            // 
            this.Lbuscar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Lbuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lbuscar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbuscar.Location = new System.Drawing.Point(634, 0);
            this.Lbuscar.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 112);
            this.panel1.TabIndex = 37;
            // 
            // TBBuscador
            // 
            this.TBBuscador.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscador.ForeColor = System.Drawing.Color.Black;
            this.TBBuscador.Location = new System.Drawing.Point(18, 39);
            this.TBBuscador.Margin = new System.Windows.Forms.Padding(27, 7, 9, 7);
            this.TBBuscador.Name = "TBBuscador";
            this.TBBuscador.Size = new System.Drawing.Size(204, 35);
            this.TBBuscador.TabIndex = 33;
            this.TBBuscador.TextChanged += new System.EventHandler(this.TBBuscador_TextChanged);
            // 
            // LListaVentas
            // 
            this.LListaVentas.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.LListaVentas.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LListaVentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.LListaVentas.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaVentas.ForeColor = System.Drawing.Color.DarkRed;
            this.LListaVentas.Location = new System.Drawing.Point(0, 0);
            this.LListaVentas.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.LListaVentas.Name = "LListaVentas";
            this.LListaVentas.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.LListaVentas.Size = new System.Drawing.Size(550, 112);
            this.LListaVentas.TabIndex = 12;
            this.LListaVentas.Text = "Lista de Ventas";
            this.LListaVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // listadoVentas
            // 
            this.listadoVentas.AllowUserToAddRows = false;
            this.listadoVentas.AutoGenerateColumns = false;
            this.listadoVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listadoVentas.BackgroundColor = System.Drawing.Color.White;
            this.listadoVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ventas,
            this.NumeroFactura,
            this.MontoTotal,
            this.FechaVenta,
            this.dni,
            this.nombreCompleto,
            this.usuario,
            this.TipoDoc});
            this.listadoVentas.DataSource = this.ventaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.listadoVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoVentas.Location = new System.Drawing.Point(0, 112);
            this.listadoVentas.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.listadoVentas.Name = "listadoVentas";
            this.listadoVentas.ReadOnly = true;
            this.listadoVentas.RowHeadersWidth = 51;
            this.listadoVentas.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.listadoVentas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.listadoVentas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.listadoVentas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listadoVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoVentas.Size = new System.Drawing.Size(1067, 442);
            this.listadoVentas.TabIndex = 24;
            this.listadoVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoVentas_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Obj_cliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Obj_cliente";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(FankyRecords.C_entidad.Venta);
            // 
            // ID_ventas
            // 
            this.ID_ventas.DataPropertyName = "ID_ventas";
            this.ID_ventas.HeaderText = "ID_ventas";
            this.ID_ventas.MinimumWidth = 6;
            this.ID_ventas.Name = "ID_ventas";
            this.ID_ventas.ReadOnly = true;
            this.ID_ventas.Visible = false;
            // 
            // NumeroFactura
            // 
            this.NumeroFactura.DataPropertyName = "NumeroFactura";
            this.NumeroFactura.HeaderText = "Número Factura";
            this.NumeroFactura.MinimumWidth = 6;
            this.NumeroFactura.Name = "NumeroFactura";
            this.NumeroFactura.ReadOnly = true;
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
            // FechaVenta
            // 
            this.FechaVenta.DataPropertyName = "FechaVenta";
            this.FechaVenta.HeaderText = "Fecha Venta";
            this.FechaVenta.MinimumWidth = 6;
            this.FechaVenta.Name = "FechaVenta";
            this.FechaVenta.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "Obj_cliente";
            this.dni.HeaderText = "Obj_cliente";
            this.dni.MinimumWidth = 6;
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Visible = false;
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.DataPropertyName = "Obj_cliente";
            this.nombreCompleto.HeaderText = "Obj_cliente";
            this.nombreCompleto.MinimumWidth = 6;
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.ReadOnly = true;
            this.nombreCompleto.Visible = false;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "Obj_usuarios";
            this.usuario.HeaderText = "Obj_usuarios";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            // 
            // TipoDoc
            // 
            this.TipoDoc.DataPropertyName = "Obj_Tipo_Doc";
            this.TipoDoc.HeaderText = "Obj_Tipo_Doc";
            this.TipoDoc.MinimumWidth = 6;
            this.TipoDoc.Name = "TipoDoc";
            this.TipoDoc.ReadOnly = true;
            this.TipoDoc.Visible = false;
            // 
            // MDVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listadoVentas);
            this.Controls.Add(this.contenedorLista);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MDVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Ventas";
            this.Load += new System.EventHandler(this.MDVenta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MDVenta_KeyDown);
            this.contenedorLista.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel contenedorLista;
        public System.Windows.Forms.Label Lbuscar;
        private System.Windows.Forms.Panel panel1;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public System.Windows.Forms.TextBox TBBuscador;
        public System.Windows.Forms.Label LListaVentas;
        public System.Windows.Forms.DataGridView listadoVentas;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
    }
}