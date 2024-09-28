namespace FankyRecords.C_presentacion.Administrador
{
    partial class gestionProductos
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
            this.contenedorLista = new System.Windows.Forms.Panel();
            this.Lbuscar = new System.Windows.Forms.Label();
            this.CBbuscar = new System.Windows.Forms.ComboBox();
            this.LListaProductos = new System.Windows.Forms.Label();
            this.TBBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.listadoProductos = new System.Windows.Forms.DataGridView();
            this.cod_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenedorBotones = new System.Windows.Forms.Panel();
            this.Beliminar = new FontAwesome.Sharp.IconButton();
            this.Beditar = new FontAwesome.Sharp.IconButton();
            this.Bguardar = new FontAwesome.Sharp.IconButton();
            this.contenedorGestionProductos = new System.Windows.Forms.Panel();
            this.LGestionProductos = new System.Windows.Forms.Label();
            this.contenedorDatos = new System.Windows.Forms.Panel();
            this.CBcategoria = new System.Windows.Forms.ComboBox();
            this.rBinactivo = new System.Windows.Forms.RadioButton();
            this.rBactivo = new System.Windows.Forms.RadioButton();
            this.TBPrecio_Venta = new System.Windows.Forms.TextBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.LPrecio_Venta = new System.Windows.Forms.Label();
            this.TBPrecio_Compra = new System.Windows.Forms.TextBox();
            this.LPrecio_Compra = new System.Windows.Forms.Label();
            this.TBstock = new System.Windows.Forms.TextBox();
            this.LStock = new System.Windows.Forms.Label();
            this.TBdescripcion = new System.Windows.Forms.TextBox();
            this.TBcodigo_prod = new System.Windows.Forms.TextBox();
            this.TBnombre_prod = new System.Windows.Forms.TextBox();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.LCodigo_prod = new System.Windows.Forms.Label();
            this.LNombre_prod = new System.Windows.Forms.Label();
            this.contenedorLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductos)).BeginInit();
            this.contenedorBotones.SuspendLayout();
            this.contenedorGestionProductos.SuspendLayout();
            this.contenedorDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedorLista
            // 
            this.contenedorLista.BackColor = System.Drawing.Color.White;
            this.contenedorLista.Controls.Add(this.Lbuscar);
            this.contenedorLista.Controls.Add(this.CBbuscar);
            this.contenedorLista.Controls.Add(this.LListaProductos);
            this.contenedorLista.Controls.Add(this.TBBuscador);
            this.contenedorLista.Controls.Add(this.btnBuscar);
            this.contenedorLista.Controls.Add(this.btnLimpiar);
            this.contenedorLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contenedorLista.Location = new System.Drawing.Point(0, 410);
            this.contenedorLista.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorLista.Name = "contenedorLista";
            this.contenedorLista.Size = new System.Drawing.Size(1182, 35);
            this.contenedorLista.TabIndex = 19;
            // 
            // Lbuscar
            // 
            this.Lbuscar.BackColor = System.Drawing.SystemColors.Window;
            this.Lbuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lbuscar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbuscar.Location = new System.Drawing.Point(626, 0);
            this.Lbuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbuscar.Name = "Lbuscar";
            this.Lbuscar.Size = new System.Drawing.Size(115, 35);
            this.Lbuscar.TabIndex = 0;
            this.Lbuscar.Text = "Buscar por:";
            this.Lbuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CBbuscar
            // 
            this.CBbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBbuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.CBbuscar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.CBbuscar.FormattingEnabled = true;
            this.CBbuscar.IntegralHeight = false;
            this.CBbuscar.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Categoria",
            "Estado"});
            this.CBbuscar.Location = new System.Drawing.Point(741, 0);
            this.CBbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.CBbuscar.Name = "CBbuscar";
            this.CBbuscar.Size = new System.Drawing.Size(156, 29);
            this.CBbuscar.TabIndex = 1;
            this.CBbuscar.Text = "Seleccione";
            // 
            // LListaProductos
            // 
            this.LListaProductos.BackColor = System.Drawing.SystemColors.Window;
            this.LListaProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.LListaProductos.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaProductos.ForeColor = System.Drawing.Color.DarkRed;
            this.LListaProductos.Location = new System.Drawing.Point(0, 0);
            this.LListaProductos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LListaProductos.Name = "LListaProductos";
            this.LListaProductos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.LListaProductos.Size = new System.Drawing.Size(326, 35);
            this.LListaProductos.TabIndex = 12;
            this.LListaProductos.Text = "Lista de Productos";
            this.LListaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBBuscador
            // 
            this.TBBuscador.Dock = System.Windows.Forms.DockStyle.Right;
            this.TBBuscador.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscador.ForeColor = System.Drawing.Color.DarkRed;
            this.TBBuscador.Location = new System.Drawing.Point(897, 0);
            this.TBBuscador.Margin = new System.Windows.Forms.Padding(12, 4, 4, 4);
            this.TBBuscador.Name = "TBBuscador";
            this.TBBuscador.Size = new System.Drawing.Size(171, 28);
            this.TBBuscador.TabIndex = 33;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
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
            this.btnBuscar.Size = new System.Drawing.Size(57, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
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
            this.btnLimpiar.Size = new System.Drawing.Size(57, 35);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // listadoProductos
            // 
            this.listadoProductos.BackgroundColor = System.Drawing.Color.White;
            this.listadoProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_prod,
            this.nombre_prod,
            this.descripcion,
            this.categoria,
            this.stock,
            this.precio_compra,
            this.precio_venta,
            this.Estado});
            this.listadoProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoProductos.Location = new System.Drawing.Point(0, 445);
            this.listadoProductos.Margin = new System.Windows.Forms.Padding(4);
            this.listadoProductos.Name = "listadoProductos";
            this.listadoProductos.RowHeadersWidth = 51;
            this.listadoProductos.Size = new System.Drawing.Size(1182, 209);
            this.listadoProductos.TabIndex = 20;
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
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 125;
            // 
            // precio_compra
            // 
            this.precio_compra.HeaderText = "Precio Compra";
            this.precio_compra.MinimumWidth = 6;
            this.precio_compra.Name = "precio_compra";
            this.precio_compra.ReadOnly = true;
            this.precio_compra.Width = 130;
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
            // contenedorBotones
            // 
            this.contenedorBotones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorBotones.Controls.Add(this.Beliminar);
            this.contenedorBotones.Controls.Add(this.Beditar);
            this.contenedorBotones.Controls.Add(this.Bguardar);
            this.contenedorBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedorBotones.ForeColor = System.Drawing.Color.Transparent;
            this.contenedorBotones.Location = new System.Drawing.Point(0, 0);
            this.contenedorBotones.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorBotones.Name = "contenedorBotones";
            this.contenedorBotones.Size = new System.Drawing.Size(261, 410);
            this.contenedorBotones.TabIndex = 21;
            // 
            // Beliminar
            // 
            this.Beliminar.BackColor = System.Drawing.Color.DarkRed;
            this.Beliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Beliminar.ForeColor = System.Drawing.Color.White;
            this.Beliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.Beliminar.IconColor = System.Drawing.Color.White;
            this.Beliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Beliminar.IconSize = 21;
            this.Beliminar.Location = new System.Drawing.Point(44, 244);
            this.Beliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beliminar.Size = new System.Drawing.Size(183, 31);
            this.Beliminar.TabIndex = 13;
            this.Beliminar.Text = "Eliminar";
            this.Beliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beliminar.UseVisualStyleBackColor = false;
            this.Beliminar.Click += new System.EventHandler(this.Beliminar_Click);
            // 
            // Beditar
            // 
            this.Beditar.BackColor = System.Drawing.Color.Navy;
            this.Beditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Beditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Beditar.ForeColor = System.Drawing.Color.White;
            this.Beditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.Beditar.IconColor = System.Drawing.Color.White;
            this.Beditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Beditar.IconSize = 25;
            this.Beditar.Location = new System.Drawing.Point(44, 192);
            this.Beditar.Margin = new System.Windows.Forms.Padding(4);
            this.Beditar.Name = "Beditar";
            this.Beditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beditar.Size = new System.Drawing.Size(183, 31);
            this.Beditar.TabIndex = 12;
            this.Beditar.Text = "Editar";
            this.Beditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beditar.UseVisualStyleBackColor = false;
            // 
            // Bguardar
            // 
            this.Bguardar.BackColor = System.Drawing.Color.DarkGreen;
            this.Bguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bguardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Bguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bguardar.ForeColor = System.Drawing.Color.White;
            this.Bguardar.IconChar = FontAwesome.Sharp.IconChar.Laugh;
            this.Bguardar.IconColor = System.Drawing.Color.White;
            this.Bguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bguardar.IconSize = 25;
            this.Bguardar.Location = new System.Drawing.Point(44, 139);
            this.Bguardar.Margin = new System.Windows.Forms.Padding(4);
            this.Bguardar.Name = "Bguardar";
            this.Bguardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bguardar.Size = new System.Drawing.Size(183, 31);
            this.Bguardar.TabIndex = 11;
            this.Bguardar.Text = "Guardar";
            this.Bguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bguardar.UseVisualStyleBackColor = false;
            this.Bguardar.Click += new System.EventHandler(this.Bguardar_Click);
            // 
            // contenedorGestionProductos
            // 
            this.contenedorGestionProductos.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorGestionProductos.Controls.Add(this.LGestionProductos);
            this.contenedorGestionProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorGestionProductos.Location = new System.Drawing.Point(261, 0);
            this.contenedorGestionProductos.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorGestionProductos.Name = "contenedorGestionProductos";
            this.contenedorGestionProductos.Size = new System.Drawing.Size(921, 56);
            this.contenedorGestionProductos.TabIndex = 22;
            // 
            // LGestionProductos
            // 
            this.LGestionProductos.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LGestionProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.LGestionProductos.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestionProductos.ForeColor = System.Drawing.Color.DarkRed;
            this.LGestionProductos.Location = new System.Drawing.Point(0, 0);
            this.LGestionProductos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LGestionProductos.Name = "LGestionProductos";
            this.LGestionProductos.Size = new System.Drawing.Size(291, 56);
            this.LGestionProductos.TabIndex = 0;
            this.LGestionProductos.Text = "Gestión de Productos";
            this.LGestionProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contenedorDatos
            // 
            this.contenedorDatos.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDatos.Controls.Add(this.CBcategoria);
            this.contenedorDatos.Controls.Add(this.rBinactivo);
            this.contenedorDatos.Controls.Add(this.rBactivo);
            this.contenedorDatos.Controls.Add(this.TBPrecio_Venta);
            this.contenedorDatos.Controls.Add(this.LEstado);
            this.contenedorDatos.Controls.Add(this.LCategoria);
            this.contenedorDatos.Controls.Add(this.LPrecio_Venta);
            this.contenedorDatos.Controls.Add(this.TBPrecio_Compra);
            this.contenedorDatos.Controls.Add(this.LPrecio_Compra);
            this.contenedorDatos.Controls.Add(this.TBstock);
            this.contenedorDatos.Controls.Add(this.LStock);
            this.contenedorDatos.Controls.Add(this.TBdescripcion);
            this.contenedorDatos.Controls.Add(this.TBcodigo_prod);
            this.contenedorDatos.Controls.Add(this.TBnombre_prod);
            this.contenedorDatos.Controls.Add(this.LDescripcion);
            this.contenedorDatos.Controls.Add(this.LCodigo_prod);
            this.contenedorDatos.Controls.Add(this.LNombre_prod);
            this.contenedorDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorDatos.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.contenedorDatos.ForeColor = System.Drawing.Color.DarkRed;
            this.contenedorDatos.Location = new System.Drawing.Point(261, 56);
            this.contenedorDatos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.contenedorDatos.Name = "contenedorDatos";
            this.contenedorDatos.Size = new System.Drawing.Size(921, 354);
            this.contenedorDatos.TabIndex = 23;
            // 
            // CBcategoria
            // 
            this.CBcategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBcategoria.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBcategoria.ForeColor = System.Drawing.Color.DarkRed;
            this.CBcategoria.FormattingEnabled = true;
            this.CBcategoria.Items.AddRange(new object[] {
            "Rock Nacional",
            "Rock and Roll",
            "Pop",
            "Indie/Alternative"});
            this.CBcategoria.Location = new System.Drawing.Point(613, 66);
            this.CBcategoria.Margin = new System.Windows.Forms.Padding(4);
            this.CBcategoria.Name = "CBcategoria";
            this.CBcategoria.Size = new System.Drawing.Size(242, 29);
            this.CBcategoria.TabIndex = 29;
            this.CBcategoria.Text = "Seleccione una opcion";
            // 
            // rBinactivo
            // 
            this.rBinactivo.AutoSize = true;
            this.rBinactivo.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBinactivo.Location = new System.Drawing.Point(751, 149);
            this.rBinactivo.Margin = new System.Windows.Forms.Padding(4);
            this.rBinactivo.Name = "rBinactivo";
            this.rBinactivo.Size = new System.Drawing.Size(103, 25);
            this.rBinactivo.TabIndex = 27;
            this.rBinactivo.TabStop = true;
            this.rBinactivo.Text = "Inactivo";
            this.rBinactivo.UseVisualStyleBackColor = true;
            // 
            // rBactivo
            // 
            this.rBactivo.AutoSize = true;
            this.rBactivo.Checked = true;
            this.rBactivo.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBactivo.Location = new System.Drawing.Point(652, 149);
            this.rBactivo.Margin = new System.Windows.Forms.Padding(4);
            this.rBactivo.Name = "rBactivo";
            this.rBactivo.Size = new System.Drawing.Size(86, 25);
            this.rBactivo.TabIndex = 26;
            this.rBactivo.TabStop = true;
            this.rBactivo.Text = "Activo";
            this.rBactivo.UseVisualStyleBackColor = true;
            // 
            // TBPrecio_Venta
            // 
            this.TBPrecio_Venta.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecio_Venta.Location = new System.Drawing.Point(321, 226);
            this.TBPrecio_Venta.Margin = new System.Windows.Forms.Padding(4);
            this.TBPrecio_Venta.MaxLength = 10;
            this.TBPrecio_Venta.Name = "TBPrecio_Venta";
            this.TBPrecio_Venta.Size = new System.Drawing.Size(242, 28);
            this.TBPrecio_Venta.TabIndex = 24;
            this.TBPrecio_Venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.Location = new System.Drawing.Point(613, 111);
            this.LEstado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(70, 21);
            this.LEstado.TabIndex = 22;
            this.LEstado.Text = "Estado";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.Location = new System.Drawing.Point(613, 30);
            this.LCategoria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(95, 21);
            this.LCategoria.TabIndex = 21;
            this.LCategoria.Text = "Categoría";
            // 
            // LPrecio_Venta
            // 
            this.LPrecio_Venta.AutoSize = true;
            this.LPrecio_Venta.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio_Venta.Location = new System.Drawing.Point(321, 190);
            this.LPrecio_Venta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LPrecio_Venta.Name = "LPrecio_Venta";
            this.LPrecio_Venta.Size = new System.Drawing.Size(124, 21);
            this.LPrecio_Venta.TabIndex = 19;
            this.LPrecio_Venta.Text = "Precio Venta";
            // 
            // TBPrecio_Compra
            // 
            this.TBPrecio_Compra.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecio_Compra.Location = new System.Drawing.Point(321, 146);
            this.TBPrecio_Compra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBPrecio_Compra.Name = "TBPrecio_Compra";
            this.TBPrecio_Compra.Size = new System.Drawing.Size(242, 28);
            this.TBPrecio_Compra.TabIndex = 18;
            this.TBPrecio_Compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LPrecio_Compra
            // 
            this.LPrecio_Compra.AutoSize = true;
            this.LPrecio_Compra.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio_Compra.Location = new System.Drawing.Point(321, 110);
            this.LPrecio_Compra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LPrecio_Compra.Name = "LPrecio_Compra";
            this.LPrecio_Compra.Size = new System.Drawing.Size(140, 21);
            this.LPrecio_Compra.TabIndex = 17;
            this.LPrecio_Compra.Text = "Precio Compra";
            // 
            // TBstock
            // 
            this.TBstock.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBstock.Location = new System.Drawing.Point(321, 66);
            this.TBstock.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBstock.Name = "TBstock";
            this.TBstock.Size = new System.Drawing.Size(242, 28);
            this.TBstock.TabIndex = 16;
            this.TBstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.Location = new System.Drawing.Point(321, 30);
            this.LStock.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(58, 21);
            this.LStock.TabIndex = 10;
            this.LStock.Text = "Stock";
            // 
            // TBdescripcion
            // 
            this.TBdescripcion.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdescripcion.Location = new System.Drawing.Point(29, 226);
            this.TBdescripcion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBdescripcion.MaxLength = 8;
            this.TBdescripcion.Name = "TBdescripcion";
            this.TBdescripcion.Size = new System.Drawing.Size(242, 28);
            this.TBdescripcion.TabIndex = 7;
            // 
            // TBcodigo_prod
            // 
            this.TBcodigo_prod.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcodigo_prod.Location = new System.Drawing.Point(29, 66);
            this.TBcodigo_prod.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBcodigo_prod.Name = "TBcodigo_prod";
            this.TBcodigo_prod.Size = new System.Drawing.Size(242, 28);
            this.TBcodigo_prod.TabIndex = 6;
            this.TBcodigo_prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // TBnombre_prod
            // 
            this.TBnombre_prod.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombre_prod.Location = new System.Drawing.Point(29, 146);
            this.TBnombre_prod.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBnombre_prod.Name = "TBnombre_prod";
            this.TBnombre_prod.Size = new System.Drawing.Size(242, 28);
            this.TBnombre_prod.TabIndex = 5;
            this.TBnombre_prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcion.Location = new System.Drawing.Point(29, 190);
            this.LDescripcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(114, 21);
            this.LDescripcion.TabIndex = 2;
            this.LDescripcion.Text = "Descripción";
            // 
            // LCodigo_prod
            // 
            this.LCodigo_prod.AutoSize = true;
            this.LCodigo_prod.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigo_prod.Location = new System.Drawing.Point(29, 30);
            this.LCodigo_prod.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LCodigo_prod.Name = "LCodigo_prod";
            this.LCodigo_prod.Size = new System.Drawing.Size(70, 21);
            this.LCodigo_prod.TabIndex = 1;
            this.LCodigo_prod.Text = "Código";
            // 
            // LNombre_prod
            // 
            this.LNombre_prod.AutoSize = true;
            this.LNombre_prod.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre_prod.ForeColor = System.Drawing.Color.DarkRed;
            this.LNombre_prod.Location = new System.Drawing.Point(29, 110);
            this.LNombre_prod.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LNombre_prod.Name = "LNombre_prod";
            this.LNombre_prod.Size = new System.Drawing.Size(80, 21);
            this.LNombre_prod.TabIndex = 0;
            this.LNombre_prod.Text = "Nombre";
            // 
            // gestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.contenedorDatos);
            this.Controls.Add(this.contenedorGestionProductos);
            this.Controls.Add(this.contenedorBotones);
            this.Controls.Add(this.contenedorLista);
            this.Controls.Add(this.listadoProductos);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gestionProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gestionProductos";
            this.contenedorLista.ResumeLayout(false);
            this.contenedorLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductos)).EndInit();
            this.contenedorBotones.ResumeLayout(false);
            this.contenedorGestionProductos.ResumeLayout(false);
            this.contenedorDatos.ResumeLayout(false);
            this.contenedorDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel contenedorLista;
        public System.Windows.Forms.Label Lbuscar;
        public System.Windows.Forms.ComboBox CBbuscar;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        public System.Windows.Forms.Label LListaProductos;
        public System.Windows.Forms.DataGridView listadoProductos;
        public System.Windows.Forms.Panel contenedorBotones;
        public FontAwesome.Sharp.IconButton Beliminar;
        public FontAwesome.Sharp.IconButton Beditar;
        public FontAwesome.Sharp.IconButton Bguardar;
        public System.Windows.Forms.Panel contenedorGestionProductos;
        public System.Windows.Forms.Label LGestionProductos;
        public System.Windows.Forms.Panel contenedorDatos;
        public System.Windows.Forms.ComboBox CBcategoria;
        public System.Windows.Forms.RadioButton rBinactivo;
        public System.Windows.Forms.RadioButton rBactivo;
        public System.Windows.Forms.Label LEstado;
        public System.Windows.Forms.Label LCategoria;
        public System.Windows.Forms.Label LPrecio_Venta;
        public System.Windows.Forms.TextBox TBPrecio_Compra;
        public System.Windows.Forms.Label LPrecio_Compra;
        public System.Windows.Forms.TextBox TBstock;
        public System.Windows.Forms.Label LStock;
        public System.Windows.Forms.TextBox TBdescripcion;
        public System.Windows.Forms.TextBox TBcodigo_prod;
        public System.Windows.Forms.TextBox TBnombre_prod;
        public System.Windows.Forms.Label LDescripcion;
        public System.Windows.Forms.Label LCodigo_prod;
        public System.Windows.Forms.Label LNombre_prod;
        public System.Windows.Forms.TextBox TBBuscador;
        public System.Windows.Forms.TextBox TBPrecio_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}