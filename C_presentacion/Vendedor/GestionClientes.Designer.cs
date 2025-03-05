namespace FankyRecords.C_presentacion.Vendedor
{
    partial class GestionClientes
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
            this.listadoClientes = new System.Windows.Forms.DataGridView();
            this.ID_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contenedorGestionClientes = new System.Windows.Forms.Panel();
            this.LGestionClientes = new System.Windows.Forms.Label();
            this.contenedorLista = new System.Windows.Forms.Panel();
            this.Lbuscar = new System.Windows.Forms.Label();
            this.LListaClientes = new System.Windows.Forms.Label();
            this.TBBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.contenedorFotoBotones = new System.Windows.Forms.Panel();
            this.Blimpiar = new FontAwesome.Sharp.IconButton();
            this.Beditar = new FontAwesome.Sharp.IconButton();
            this.Bguardar = new FontAwesome.Sharp.IconButton();
            this.Beliminar = new FontAwesome.Sharp.IconButton();
            this.contenedorDatos = new System.Windows.Forms.Panel();
            this.TBtelefono = new System.Windows.Forms.TextBox();
            this.rBinactivo = new System.Windows.Forms.RadioButton();
            this.rBactivo = new System.Windows.Forms.RadioButton();
            this.LEstado = new System.Windows.Forms.Label();
            this.TBemail = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.contenedorGestionClientes.SuspendLayout();
            this.contenedorLista.SuspendLayout();
            this.contenedorFotoBotones.SuspendLayout();
            this.contenedorDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listadoClientes
            // 
            this.listadoClientes.AllowUserToAddRows = false;
            this.listadoClientes.AutoGenerateColumns = false;
            this.listadoClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listadoClientes.BackgroundColor = System.Drawing.Color.White;
            this.listadoClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_cliente,
            this.Documento,
            this.Nombre,
            this.Apellido,
            this.Correo,
            this.Telefono,
            this.Estado});
            this.listadoClientes.DataSource = this.clientesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.listadoClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoClientes.Location = new System.Drawing.Point(0, 508);
            this.listadoClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listadoClientes.Name = "listadoClientes";
            this.listadoClientes.ReadOnly = true;
            this.listadoClientes.RowHeadersWidth = 51;
            this.listadoClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoClientes.Size = new System.Drawing.Size(1418, 231);
            this.listadoClientes.TabIndex = 12;
            this.listadoClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoClientes_CellClick);
            this.listadoClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoClientes_CellDoubleClick);
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
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(FankyRecords.C_entidad.Clientes);
            // 
            // contenedorGestionClientes
            // 
            this.contenedorGestionClientes.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorGestionClientes.Controls.Add(this.LGestionClientes);
            this.contenedorGestionClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorGestionClientes.Location = new System.Drawing.Point(359, 0);
            this.contenedorGestionClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorGestionClientes.Name = "contenedorGestionClientes";
            this.contenedorGestionClientes.Size = new System.Drawing.Size(1059, 69);
            this.contenedorGestionClientes.TabIndex = 20;
            // 
            // LGestionClientes
            // 
            this.LGestionClientes.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LGestionClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LGestionClientes.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestionClientes.ForeColor = System.Drawing.Color.DarkRed;
            this.LGestionClientes.Location = new System.Drawing.Point(0, 0);
            this.LGestionClientes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LGestionClientes.Name = "LGestionClientes";
            this.LGestionClientes.Size = new System.Drawing.Size(1059, 69);
            this.LGestionClientes.TabIndex = 0;
            this.LGestionClientes.Text = "Gestión de Clientes";
            this.LGestionClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // contenedorLista
            // 
            this.contenedorLista.BackColor = System.Drawing.Color.White;
            this.contenedorLista.Controls.Add(this.Lbuscar);
            this.contenedorLista.Controls.Add(this.LListaClientes);
            this.contenedorLista.Controls.Add(this.TBBuscador);
            this.contenedorLista.Controls.Add(this.btnBuscar);
            this.contenedorLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contenedorLista.Location = new System.Drawing.Point(0, 477);
            this.contenedorLista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorLista.Name = "contenedorLista";
            this.contenedorLista.Size = new System.Drawing.Size(1418, 31);
            this.contenedorLista.TabIndex = 21;
            // 
            // Lbuscar
            // 
            this.Lbuscar.BackColor = System.Drawing.SystemColors.Window;
            this.Lbuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lbuscar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbuscar.Location = new System.Drawing.Point(997, 0);
            this.Lbuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbuscar.Name = "Lbuscar";
            this.Lbuscar.Size = new System.Drawing.Size(138, 31);
            this.Lbuscar.TabIndex = 0;
            this.Lbuscar.Text = "Buscar:";
            this.Lbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LListaClientes
            // 
            this.LListaClientes.BackColor = System.Drawing.SystemColors.Window;
            this.LListaClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.LListaClientes.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaClientes.ForeColor = System.Drawing.Color.DarkRed;
            this.LListaClientes.Location = new System.Drawing.Point(0, 0);
            this.LListaClientes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LListaClientes.Name = "LListaClientes";
            this.LListaClientes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.LListaClientes.Size = new System.Drawing.Size(313, 31);
            this.LListaClientes.TabIndex = 12;
            this.LListaClientes.Text = "Lista de Clientes";
            this.LListaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBBuscador
            // 
            this.TBBuscador.Dock = System.Windows.Forms.DockStyle.Right;
            this.TBBuscador.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscador.ForeColor = System.Drawing.Color.Black;
            this.TBBuscador.Location = new System.Drawing.Point(1135, 0);
            this.TBBuscador.Margin = new System.Windows.Forms.Padding(12, 3, 4, 3);
            this.TBBuscador.Name = "TBBuscador";
            this.TBBuscador.Size = new System.Drawing.Size(204, 35);
            this.TBBuscador.TabIndex = 32;
            this.TBBuscador.TextChanged += new System.EventHandler(this.TBBuscador_TextChanged);
            this.TBBuscador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBBuscador_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(1339, 0);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 31);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // contenedorFotoBotones
            // 
            this.contenedorFotoBotones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorFotoBotones.Controls.Add(this.Blimpiar);
            this.contenedorFotoBotones.Controls.Add(this.Beditar);
            this.contenedorFotoBotones.Controls.Add(this.Bguardar);
            this.contenedorFotoBotones.Controls.Add(this.Beliminar);
            this.contenedorFotoBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedorFotoBotones.ForeColor = System.Drawing.Color.Transparent;
            this.contenedorFotoBotones.Location = new System.Drawing.Point(0, 0);
            this.contenedorFotoBotones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorFotoBotones.Name = "contenedorFotoBotones";
            this.contenedorFotoBotones.Size = new System.Drawing.Size(359, 477);
            this.contenedorFotoBotones.TabIndex = 22;
            // 
            // Blimpiar
            // 
            this.Blimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Blimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Blimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Blimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Blimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Blimpiar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blimpiar.ForeColor = System.Drawing.Color.White;
            this.Blimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.Blimpiar.IconColor = System.Drawing.Color.White;
            this.Blimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Blimpiar.IconSize = 21;
            this.Blimpiar.Location = new System.Drawing.Point(76, 322);
            this.Blimpiar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Blimpiar.Name = "Blimpiar";
            this.Blimpiar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Blimpiar.Size = new System.Drawing.Size(206, 46);
            this.Blimpiar.TabIndex = 15;
            this.Blimpiar.Text = "Limpiar";
            this.Blimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Blimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Blimpiar.UseVisualStyleBackColor = false;
            this.Blimpiar.Click += new System.EventHandler(this.Blimpiar_Click);
            // 
            // Beditar
            // 
            this.Beditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Beditar.BackColor = System.Drawing.Color.Navy;
            this.Beditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Beditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Beditar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beditar.ForeColor = System.Drawing.Color.White;
            this.Beditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.Beditar.IconColor = System.Drawing.Color.White;
            this.Beditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Beditar.IconSize = 25;
            this.Beditar.Location = new System.Drawing.Point(76, 204);
            this.Beditar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Beditar.Name = "Beditar";
            this.Beditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beditar.Size = new System.Drawing.Size(206, 46);
            this.Beditar.TabIndex = 13;
            this.Beditar.Text = "Editar";
            this.Beditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beditar.UseVisualStyleBackColor = false;
            this.Beditar.Click += new System.EventHandler(this.Beditar_Click);
            // 
            // Bguardar
            // 
            this.Bguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Bguardar.BackColor = System.Drawing.Color.DarkGreen;
            this.Bguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bguardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Bguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bguardar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bguardar.ForeColor = System.Drawing.Color.White;
            this.Bguardar.IconChar = FontAwesome.Sharp.IconChar.Laugh;
            this.Bguardar.IconColor = System.Drawing.Color.White;
            this.Bguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bguardar.IconSize = 25;
            this.Bguardar.Location = new System.Drawing.Point(76, 145);
            this.Bguardar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Bguardar.Name = "Bguardar";
            this.Bguardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bguardar.Size = new System.Drawing.Size(206, 46);
            this.Bguardar.TabIndex = 12;
            this.Bguardar.Text = "Guardar";
            this.Bguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bguardar.UseVisualStyleBackColor = false;
            this.Bguardar.Click += new System.EventHandler(this.Bguardar_Click);
            // 
            // Beliminar
            // 
            this.Beliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Beliminar.BackColor = System.Drawing.Color.DarkRed;
            this.Beliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Beliminar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beliminar.ForeColor = System.Drawing.Color.White;
            this.Beliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.Beliminar.IconColor = System.Drawing.Color.White;
            this.Beliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Beliminar.IconSize = 21;
            this.Beliminar.Location = new System.Drawing.Point(76, 263);
            this.Beliminar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beliminar.Size = new System.Drawing.Size(206, 46);
            this.Beliminar.TabIndex = 14;
            this.Beliminar.Text = "Desactivar";
            this.Beliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beliminar.UseVisualStyleBackColor = false;
            this.Beliminar.Click += new System.EventHandler(this.Beliminar_Click);
            // 
            // contenedorDatos
            // 
            this.contenedorDatos.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDatos.Controls.Add(this.TBtelefono);
            this.contenedorDatos.Controls.Add(this.rBinactivo);
            this.contenedorDatos.Controls.Add(this.rBactivo);
            this.contenedorDatos.Controls.Add(this.LEstado);
            this.contenedorDatos.Controls.Add(this.TBemail);
            this.contenedorDatos.Controls.Add(this.LEmail);
            this.contenedorDatos.Controls.Add(this.TBdni);
            this.contenedorDatos.Controls.Add(this.TBapellido);
            this.contenedorDatos.Controls.Add(this.TBnombre);
            this.contenedorDatos.Controls.Add(this.LTelefono);
            this.contenedorDatos.Controls.Add(this.LDni);
            this.contenedorDatos.Controls.Add(this.LApellido);
            this.contenedorDatos.Controls.Add(this.LNombre);
            this.contenedorDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorDatos.ForeColor = System.Drawing.Color.DarkRed;
            this.contenedorDatos.Location = new System.Drawing.Point(359, 69);
            this.contenedorDatos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.contenedorDatos.Name = "contenedorDatos";
            this.contenedorDatos.Size = new System.Drawing.Size(1059, 408);
            this.contenedorDatos.TabIndex = 23;
            // 
            // TBtelefono
            // 
            this.TBtelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBtelefono.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtelefono.Location = new System.Drawing.Point(611, 194);
            this.TBtelefono.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBtelefono.MaxLength = 10;
            this.TBtelefono.Name = "TBtelefono";
            this.TBtelefono.ShortcutsEnabled = false;
            this.TBtelefono.Size = new System.Drawing.Size(293, 35);
            this.TBtelefono.TabIndex = 28;
            this.TBtelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // rBinactivo
            // 
            this.rBinactivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBinactivo.AutoSize = true;
            this.rBinactivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBinactivo.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBinactivo.Location = new System.Drawing.Point(771, 285);
            this.rBinactivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rBinactivo.Name = "rBinactivo";
            this.rBinactivo.Size = new System.Drawing.Size(133, 31);
            this.rBinactivo.TabIndex = 27;
            this.rBinactivo.TabStop = true;
            this.rBinactivo.Text = "Inactivo";
            this.rBinactivo.UseVisualStyleBackColor = true;
            // 
            // rBactivo
            // 
            this.rBactivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBactivo.AutoSize = true;
            this.rBactivo.Checked = true;
            this.rBactivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBactivo.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBactivo.Location = new System.Drawing.Point(651, 285);
            this.rBactivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rBactivo.Name = "rBactivo";
            this.rBactivo.Size = new System.Drawing.Size(110, 31);
            this.rBactivo.TabIndex = 26;
            this.rBactivo.TabStop = true;
            this.rBactivo.Text = "Activo";
            this.rBactivo.UseVisualStyleBackColor = true;
            // 
            // LEstado
            // 
            this.LEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.Location = new System.Drawing.Point(611, 247);
            this.LEstado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(94, 27);
            this.LEstado.TabIndex = 22;
            this.LEstado.Text = "Estado";
            // 
            // TBemail
            // 
            this.TBemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBemail.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBemail.Location = new System.Drawing.Point(611, 111);
            this.TBemail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBemail.MaxLength = 100;
            this.TBemail.Name = "TBemail";
            this.TBemail.ShortcutsEnabled = false;
            this.TBemail.Size = new System.Drawing.Size(293, 35);
            this.TBemail.TabIndex = 18;
            // 
            // LEmail
            // 
            this.LEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.Location = new System.Drawing.Point(611, 79);
            this.LEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(82, 27);
            this.LEmail.TabIndex = 17;
            this.LEmail.Text = "Email";
            // 
            // TBdni
            // 
            this.TBdni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBdni.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdni.Location = new System.Drawing.Point(178, 281);
            this.TBdni.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBdni.MaxLength = 8;
            this.TBdni.Name = "TBdni";
            this.TBdni.ShortcutsEnabled = false;
            this.TBdni.Size = new System.Drawing.Size(293, 35);
            this.TBdni.TabIndex = 7;
            this.TBdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // TBapellido
            // 
            this.TBapellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBapellido.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBapellido.Location = new System.Drawing.Point(178, 194);
            this.TBapellido.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBapellido.MaxLength = 100;
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.ShortcutsEnabled = false;
            this.TBapellido.Size = new System.Drawing.Size(293, 35);
            this.TBapellido.TabIndex = 6;
            this.TBapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // TBnombre
            // 
            this.TBnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBnombre.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombre.Location = new System.Drawing.Point(178, 111);
            this.TBnombre.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBnombre.MaxLength = 100;
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.ShortcutsEnabled = false;
            this.TBnombre.Size = new System.Drawing.Size(293, 35);
            this.TBnombre.TabIndex = 5;
            this.TBnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // LTelefono
            // 
            this.LTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(611, 162);
            this.LTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(116, 27);
            this.LTelefono.TabIndex = 4;
            this.LTelefono.Text = "Teléfono";
            // 
            // LDni
            // 
            this.LDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(178, 247);
            this.LDni.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(60, 27);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI";
            // 
            // LApellido
            // 
            this.LApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(178, 162);
            this.LApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(111, 27);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            this.LNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.DarkRed;
            this.LNombre.Location = new System.Drawing.Point(178, 79);
            this.LNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(107, 27);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre";
            // 
            // GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 739);
            this.Controls.Add(this.contenedorDatos);
            this.Controls.Add(this.contenedorGestionClientes);
            this.Controls.Add(this.contenedorFotoBotones);
            this.Controls.Add(this.contenedorLista);
            this.Controls.Add(this.listadoClientes);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "GestionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionClientes";
            this.Load += new System.EventHandler(this.GestionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.contenedorGestionClientes.ResumeLayout(false);
            this.contenedorLista.ResumeLayout(false);
            this.contenedorLista.PerformLayout();
            this.contenedorFotoBotones.ResumeLayout(false);
            this.contenedorDatos.ResumeLayout(false);
            this.contenedorDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView listadoClientes;
        public System.Windows.Forms.Panel contenedorGestionClientes;
        public System.Windows.Forms.Label LGestionClientes;
        public System.Windows.Forms.Panel contenedorLista;
        public System.Windows.Forms.Label Lbuscar;
        public System.Windows.Forms.Label LListaClientes;
        public System.Windows.Forms.TextBox TBBuscador;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public System.Windows.Forms.Panel contenedorFotoBotones;
        public System.Windows.Forms.Panel contenedorDatos;
        public System.Windows.Forms.RadioButton rBinactivo;
        public System.Windows.Forms.RadioButton rBactivo;
        public System.Windows.Forms.Label LEstado;
        public System.Windows.Forms.TextBox TBemail;
        public System.Windows.Forms.Label LEmail;
        public System.Windows.Forms.TextBox TBdni;
        public System.Windows.Forms.TextBox TBapellido;
        public System.Windows.Forms.TextBox TBnombre;
        public System.Windows.Forms.Label LTelefono;
        public System.Windows.Forms.Label LDni;
        public System.Windows.Forms.Label LApellido;
        public System.Windows.Forms.Label LNombre;
        public FontAwesome.Sharp.IconButton Beditar;
        public FontAwesome.Sharp.IconButton Bguardar;
        public FontAwesome.Sharp.IconButton Beliminar;
        public FontAwesome.Sharp.IconButton Blimpiar;
        public System.Windows.Forms.TextBox TBtelefono;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}