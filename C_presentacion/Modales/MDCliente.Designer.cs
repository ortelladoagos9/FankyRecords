namespace FankyRecords.C_presentacion.Modales
{
    partial class MDCliente
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
            this.LListaClientes = new System.Windows.Forms.Label();
            this.LBuscar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.TBBuscador = new System.Windows.Forms.TextBox();
            this.listaClientes = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenedorLista.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedorLista
            // 
            this.contenedorLista.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorLista.Controls.Add(this.LListaClientes);
            this.contenedorLista.Controls.Add(this.LBuscar);
            this.contenedorLista.Controls.Add(this.panel1);
            this.contenedorLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorLista.Location = new System.Drawing.Point(0, 0);
            this.contenedorLista.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.contenedorLista.Name = "contenedorLista";
            this.contenedorLista.Size = new System.Drawing.Size(1067, 112);
            this.contenedorLista.TabIndex = 21;
            // 
            // LListaClientes
            // 
            this.LListaClientes.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LListaClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.LListaClientes.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaClientes.ForeColor = System.Drawing.Color.DarkRed;
            this.LListaClientes.Location = new System.Drawing.Point(0, 0);
            this.LListaClientes.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LListaClientes.Name = "LListaClientes";
            this.LListaClientes.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.LListaClientes.Size = new System.Drawing.Size(550, 112);
            this.LListaClientes.TabIndex = 37;
            this.LListaClientes.Text = "Lista de Clientes";
            this.LListaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // listaClientes
            // 
            this.listaClientes.AllowUserToAddRows = false;
            this.listaClientes.AutoGenerateColumns = false;
            this.listaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaClientes.BackgroundColor = System.Drawing.Color.White;
            this.listaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_cliente,
            this.documento,
            this.nombre,
            this.apellido,
            this.NombreCompleto,
            this.correo,
            this.telefono,
            this.estado});
            this.listaClientes.DataSource = this.clientesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaClientes.Location = new System.Drawing.Point(0, 109);
            this.listaClientes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.ReadOnly = true;
            this.listaClientes.RowHeadersWidth = 51;
            this.listaClientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.listaClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.listaClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.listaClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaClientes.Size = new System.Drawing.Size(1067, 446);
            this.listaClientes.TabIndex = 22;
            this.listaClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaClientes_CellDoubleClick);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(FankyRecords.C_entidad.Clientes);
            // 
            // ID_cliente
            // 
            this.ID_cliente.DataPropertyName = "ID_cliente";
            this.ID_cliente.HeaderText = "ID_cliente";
            this.ID_cliente.MinimumWidth = 6;
            this.ID_cliente.Name = "ID_cliente";
            this.ID_cliente.ReadOnly = true;
            this.ID_cliente.Visible = false;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "Documento";
            this.documento.HeaderText = "Documento";
            this.documento.MinimumWidth = 6;
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Visible = false;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "Apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Visible = false;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 6;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "Correo";
            this.correo.HeaderText = "Correo";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "Estado";
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // MDCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listaClientes);
            this.Controls.Add(this.contenedorLista);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Clientes";
            this.Load += new System.EventHandler(this.MDCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MDCliente_KeyDown);
            this.contenedorLista.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedorLista;
        public System.Windows.Forms.Label LListaClientes;
        public System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.Panel panel1;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public System.Windows.Forms.TextBox TBBuscador;
        public System.Windows.Forms.DataGridView listaClientes;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}