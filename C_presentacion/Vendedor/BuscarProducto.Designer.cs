namespace FankyRecords.C_presentacion.Vendedor
{
    partial class BuscarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listadoProductos = new System.Windows.Forms.DataGridView();
            this.cod_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenedorLista = new System.Windows.Forms.Panel();
            this.Lbuscar = new System.Windows.Forms.Label();
            this.CBbuscar = new System.Windows.Forms.ComboBox();
            this.LListaProductos = new System.Windows.Forms.Label();
            this.TBBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductos)).BeginInit();
            this.contenedorLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // listadoProductos
            // 
            this.listadoProductos.BackgroundColor = System.Drawing.Color.White;
            this.listadoProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_prod,
            this.nombre_prod,
            this.descripcion,
            this.categoria,
            this.precio_venta,
            this.Estado});
            this.listadoProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoProductos.Location = new System.Drawing.Point(0, 106);
            this.listadoProductos.Margin = new System.Windows.Forms.Padding(4);
            this.listadoProductos.Name = "listadoProductos";
            this.listadoProductos.RowHeadersWidth = 51;
            this.listadoProductos.Size = new System.Drawing.Size(1182, 548);
            this.listadoProductos.TabIndex = 21;
            // 
            // cod_prod
            // 
            this.cod_prod.HeaderText = "Codigo";
            this.cod_prod.MinimumWidth = 6;
            this.cod_prod.Name = "cod_prod";
            this.cod_prod.Width = 115;
            // 
            // nombre_prod
            // 
            this.nombre_prod.HeaderText = "Nombre";
            this.nombre_prod.MinimumWidth = 6;
            this.nombre_prod.Name = "nombre_prod";
            this.nombre_prod.ReadOnly = true;
            this.nombre_prod.Width = 115;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 140;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 125;
            // 
            // precio_venta
            // 
            this.precio_venta.HeaderText = "Precio Venta";
            this.precio_venta.MinimumWidth = 6;
            this.precio_venta.Name = "precio_venta";
            this.precio_venta.ReadOnly = true;
            this.precio_venta.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 115;
            // 
            // contenedorLista
            // 
            this.contenedorLista.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorLista.Controls.Add(this.TBBuscador);
            this.contenedorLista.Controls.Add(this.CBbuscar);
            this.contenedorLista.Controls.Add(this.Lbuscar);
            this.contenedorLista.Controls.Add(this.LListaProductos);
            this.contenedorLista.Controls.Add(this.btnBuscar);
            this.contenedorLista.Controls.Add(this.btnLimpiar);
            this.contenedorLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorLista.Location = new System.Drawing.Point(0, 0);
            this.contenedorLista.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorLista.Name = "contenedorLista";
            this.contenedorLista.Size = new System.Drawing.Size(1182, 106);
            this.contenedorLista.TabIndex = 22;
            // 
            // Lbuscar
            // 
            this.Lbuscar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Lbuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lbuscar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbuscar.Location = new System.Drawing.Point(549, 0);
            this.Lbuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbuscar.Name = "Lbuscar";
            this.Lbuscar.Size = new System.Drawing.Size(519, 106);
            this.Lbuscar.TabIndex = 0;
            this.Lbuscar.Text = "Buscar por:";
            this.Lbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBbuscar
            // 
            this.CBbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBbuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBbuscar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.CBbuscar.FormattingEnabled = true;
            this.CBbuscar.IntegralHeight = false;
            this.CBbuscar.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Categoria",
            "Estado"});
            this.CBbuscar.Location = new System.Drawing.Point(702, 42);
            this.CBbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.CBbuscar.Name = "CBbuscar";
            this.CBbuscar.Size = new System.Drawing.Size(171, 29);
            this.CBbuscar.TabIndex = 1;
            // 
            // LListaProductos
            // 
            this.LListaProductos.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LListaProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.LListaProductos.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaProductos.ForeColor = System.Drawing.Color.DarkRed;
            this.LListaProductos.Location = new System.Drawing.Point(0, 0);
            this.LListaProductos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LListaProductos.Name = "LListaProductos";
            this.LListaProductos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.LListaProductos.Size = new System.Drawing.Size(326, 106);
            this.LListaProductos.TabIndex = 12;
            this.LListaProductos.Text = "Lista de Productos";
            this.LListaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBBuscador
            // 
            this.TBBuscador.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscador.ForeColor = System.Drawing.Color.DarkRed;
            this.TBBuscador.Location = new System.Drawing.Point(889, 42);
            this.TBBuscador.Margin = new System.Windows.Forms.Padding(12, 4, 4, 4);
            this.TBBuscador.Name = "TBBuscador";
            this.TBBuscador.Size = new System.Drawing.Size(171, 28);
            this.TBBuscador.TabIndex = 33;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 18;
            this.btnBuscar.Location = new System.Drawing.Point(1068, 0);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 106);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 18;
            this.btnLimpiar.Location = new System.Drawing.Point(1125, 0);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(57, 106);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.listadoProductos);
            this.Controls.Add(this.contenedorLista);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BuscarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductos)).EndInit();
            this.contenedorLista.ResumeLayout(false);
            this.contenedorLista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView listadoProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        public System.Windows.Forms.Panel contenedorLista;
        public System.Windows.Forms.Label Lbuscar;
        public System.Windows.Forms.ComboBox CBbuscar;
        public System.Windows.Forms.Label LListaProductos;
        public System.Windows.Forms.TextBox TBBuscador;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public FontAwesome.Sharp.IconButton btnLimpiar;
    }
}