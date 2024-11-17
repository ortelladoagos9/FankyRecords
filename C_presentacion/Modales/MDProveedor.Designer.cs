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
            this.iDproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.contenedorLista.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorLista.Name = "contenedorLista";
            this.contenedorLista.Size = new System.Drawing.Size(1067, 85);
            this.contenedorLista.TabIndex = 20;
            // 
            // LListaProveedor
            // 
            this.LListaProveedor.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LListaProveedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.LListaProveedor.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaProveedor.ForeColor = System.Drawing.Color.DarkRed;
            this.LListaProveedor.Location = new System.Drawing.Point(0, 0);
            this.LListaProveedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LListaProveedor.Name = "LListaProveedor";
            this.LListaProveedor.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.LListaProveedor.Size = new System.Drawing.Size(326, 85);
            this.LListaProveedor.TabIndex = 37;
            this.LListaProveedor.Text = "Lista de Proveedores";
            this.LListaProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBuscar
            // 
            this.LBuscar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.LBuscar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.LBuscar.Location = new System.Drawing.Point(663, 0);
            this.LBuscar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(121, 85);
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
            this.panel1.Location = new System.Drawing.Point(784, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 85);
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
            this.btnBuscar.Location = new System.Drawing.Point(204, 29);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // TBBuscador
            // 
            this.TBBuscador.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscador.ForeColor = System.Drawing.Color.Black;
            this.TBBuscador.Location = new System.Drawing.Point(12, 29);
            this.TBBuscador.Margin = new System.Windows.Forms.Padding(12, 4, 4, 4);
            this.TBBuscador.Name = "TBBuscador";
            this.TBBuscador.Size = new System.Drawing.Size(184, 28);
            this.TBBuscador.TabIndex = 33;
            this.TBBuscador.TextChanged += new System.EventHandler(this.TBBuscador_TextChanged);
            // 
            // listaproveedores
            // 
            this.listaproveedores.AutoGenerateColumns = false;
            this.listaproveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaproveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaproveedores.BackgroundColor = System.Drawing.Color.White;
            this.listaproveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaproveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaproveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaproveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDproveedorDataGridViewTextBoxColumn,
            this.cuit,
            this.razonSocial,
            this.estadoDataGridViewTextBoxColumn});
            this.listaproveedores.DataSource = this.proveedoresBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaproveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaproveedores.Location = new System.Drawing.Point(0, 85);
            this.listaproveedores.Margin = new System.Windows.Forms.Padding(4);
            this.listaproveedores.Name = "listaproveedores";
            this.listaproveedores.ReadOnly = true;
            this.listaproveedores.RowHeadersWidth = 51;
            this.listaproveedores.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.listaproveedores.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.listaproveedores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.listaproveedores.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listaproveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaproveedores.Size = new System.Drawing.Size(1067, 469);
            this.listaproveedores.TabIndex = 21;
            this.listaproveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGlistaproveedores_CellDoubleClick);
            // 
            // iDproveedorDataGridViewTextBoxColumn
            // 
            this.iDproveedorDataGridViewTextBoxColumn.DataPropertyName = "ID_proveedor";
            this.iDproveedorDataGridViewTextBoxColumn.HeaderText = "ID_proveedor";
            this.iDproveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDproveedorDataGridViewTextBoxColumn.Name = "iDproveedorDataGridViewTextBoxColumn";
            this.iDproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDproveedorDataGridViewTextBoxColumn.Visible = false;
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
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.MinimumWidth = 6;
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataSource = typeof(FankyRecords.C_entidad.Proveedores);
            // 
            // MDProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listaproveedores);
            this.Controls.Add(this.contenedorLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}