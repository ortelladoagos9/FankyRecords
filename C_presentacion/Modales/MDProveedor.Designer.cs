namespace FankyRecords.C_presentacion.Modales
{
    partial class MDProveedor
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
            this.LListaProveedor = new System.Windows.Forms.Label();
            this.LBuscar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.TBBuscador = new System.Windows.Forms.TextBox();
            this.listaproveedores = new System.Windows.Forms.DataGridView();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenedorLista.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaproveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedorLista
            // 
            this.contenedorLista.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorLista.Controls.Add(this.LListaProveedor);
            this.contenedorLista.Controls.Add(this.LBuscar);
            this.contenedorLista.Controls.Add(this.panel1);
            this.contenedorLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorLista.Location = new System.Drawing.Point(0, 0);
            this.contenedorLista.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.contenedorLista.Name = "contenedorLista";
            this.contenedorLista.Size = new System.Drawing.Size(1067, 112);
            this.contenedorLista.TabIndex = 20;
            // 
            // LListaProveedor
            // 
            this.LListaProveedor.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LListaProveedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.LListaProveedor.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaProveedor.ForeColor = System.Drawing.Color.DarkRed;
            this.LListaProveedor.Location = new System.Drawing.Point(0, 0);
            this.LListaProveedor.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LListaProveedor.Name = "LListaProveedor";
            this.LListaProveedor.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.LListaProveedor.Size = new System.Drawing.Size(550, 112);
            this.LListaProveedor.TabIndex = 37;
            this.LListaProveedor.Text = "Lista de Proveedores";
            this.LListaProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBuscar
            // 
            this.LBuscar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.LBuscar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.LBuscar.Location = new System.Drawing.Point(634, 0);
            this.LBuscar.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(139, 112);
            this.LBuscar.TabIndex = 35;
            this.LBuscar.Text = "Buscar:";
            this.LBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel1.TabIndex = 36;
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
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
            // listaproveedores
            // 
            this.listaproveedores.AllowUserToAddRows = false;
            this.listaproveedores.AutoGenerateColumns = false;
            this.listaproveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaproveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaproveedores.BackgroundColor = System.Drawing.Color.White;
            this.listaproveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaproveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaproveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaproveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_proveedor,
            this.cuit,
            this.razonSocial,
            this.Estado});
            this.listaproveedores.DataSource = this.proveedoresBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaproveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaproveedores.Location = new System.Drawing.Point(0, 112);
            this.listaproveedores.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listaproveedores.Name = "listaproveedores";
            this.listaproveedores.ReadOnly = true;
            this.listaproveedores.RowHeadersWidth = 51;
            this.listaproveedores.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.listaproveedores.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.listaproveedores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.listaproveedores.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listaproveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaproveedores.Size = new System.Drawing.Size(1067, 442);
            this.listaproveedores.TabIndex = 21;
            this.listaproveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGlistaproveedores_CellDoubleClick);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataSource = typeof(FankyRecords.C_entidad.Proveedores);
            // 
            // ID_proveedor
            // 
            this.ID_proveedor.DataPropertyName = "ID_proveedor";
            this.ID_proveedor.HeaderText = "ID_proveedor";
            this.ID_proveedor.MinimumWidth = 6;
            this.ID_proveedor.Name = "ID_proveedor";
            this.ID_proveedor.ReadOnly = true;
            this.ID_proveedor.Visible = false;
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "Cuit";
            this.cuit.HeaderText = "Cuit";
            this.cuit.MinimumWidth = 6;
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // razonSocial
            // 
            this.razonSocial.DataPropertyName = "RazonSocial";
            this.razonSocial.HeaderText = "Razón Social";
            this.razonSocial.MinimumWidth = 6;
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // MDProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listaproveedores);
            this.Controls.Add(this.contenedorLista);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MDProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Proveedor";
            this.Load += new System.EventHandler(this.MDProveedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MDProveedor_KeyDown);
            this.contenedorLista.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaproveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedorLista;
        public System.Windows.Forms.DataGridView listaproveedores;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        public System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.Panel panel1;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public System.Windows.Forms.TextBox TBBuscador;
        public System.Windows.Forms.Label LListaProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}