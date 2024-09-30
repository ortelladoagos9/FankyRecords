namespace FankyRecords.C_presentacion.Administrador
{
    partial class GestionCategorias
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
            this.contenedorDatos = new System.Windows.Forms.Panel();
            this.rBinactivo = new System.Windows.Forms.RadioButton();
            this.rBactivo = new System.Windows.Forms.RadioButton();
            this.LEstado = new System.Windows.Forms.Label();
            this.TBdescripcion = new System.Windows.Forms.TextBox();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.contenedorGestionCategorias = new System.Windows.Forms.Panel();
            this.LGestionCategorias = new System.Windows.Forms.Label();
            this.contenedorBotones = new System.Windows.Forms.Panel();
            this.Beliminar = new FontAwesome.Sharp.IconButton();
            this.Beditar = new FontAwesome.Sharp.IconButton();
            this.Bguardar = new FontAwesome.Sharp.IconButton();
            this.contenedorLista = new System.Windows.Forms.Panel();
            this.Lbuscar = new System.Windows.Forms.Label();
            this.CBbuscar = new System.Windows.Forms.ComboBox();
            this.LListaCategorias = new System.Windows.Forms.Label();
            this.TBBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.listadoCategorias = new System.Windows.Forms.DataGridView();
            this.Id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contenedorDatos.SuspendLayout();
            this.contenedorGestionCategorias.SuspendLayout();
            this.contenedorBotones.SuspendLayout();
            this.contenedorLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedorDatos
            // 
            this.contenedorDatos.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDatos.Controls.Add(this.rBinactivo);
            this.contenedorDatos.Controls.Add(this.rBactivo);
            this.contenedorDatos.Controls.Add(this.LEstado);
            this.contenedorDatos.Controls.Add(this.TBdescripcion);
            this.contenedorDatos.Controls.Add(this.LDescripcion);
            this.contenedorDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorDatos.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.contenedorDatos.ForeColor = System.Drawing.Color.DarkRed;
            this.contenedorDatos.Location = new System.Drawing.Point(261, 62);
            this.contenedorDatos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.contenedorDatos.Name = "contenedorDatos";
            this.contenedorDatos.Size = new System.Drawing.Size(921, 355);
            this.contenedorDatos.TabIndex = 28;
            // 
            // rBinactivo
            // 
            this.rBinactivo.AutoSize = true;
            this.rBinactivo.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBinactivo.Location = new System.Drawing.Point(592, 160);
            this.rBinactivo.Margin = new System.Windows.Forms.Padding(5);
            this.rBinactivo.Name = "rBinactivo";
            this.rBinactivo.Size = new System.Drawing.Size(103, 25);
            this.rBinactivo.TabIndex = 32;
            this.rBinactivo.TabStop = true;
            this.rBinactivo.Text = "Inactivo";
            this.rBinactivo.UseVisualStyleBackColor = true;
            // 
            // rBactivo
            // 
            this.rBactivo.AutoSize = true;
            this.rBactivo.Checked = true;
            this.rBactivo.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBactivo.Location = new System.Drawing.Point(488, 160);
            this.rBactivo.Margin = new System.Windows.Forms.Padding(5);
            this.rBactivo.Name = "rBactivo";
            this.rBactivo.Size = new System.Drawing.Size(86, 25);
            this.rBactivo.TabIndex = 31;
            this.rBactivo.TabStop = true;
            this.rBactivo.Text = "Activo";
            this.rBactivo.UseVisualStyleBackColor = true;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.Location = new System.Drawing.Point(463, 124);
            this.LEstado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(70, 21);
            this.LEstado.TabIndex = 30;
            this.LEstado.Text = "Estado";
            // 
            // TBdescripcion
            // 
            this.TBdescripcion.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdescripcion.Location = new System.Drawing.Point(162, 157);
            this.TBdescripcion.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TBdescripcion.MaxLength = 100;
            this.TBdescripcion.Name = "TBdescripcion";
            this.TBdescripcion.Size = new System.Drawing.Size(242, 28);
            this.TBdescripcion.TabIndex = 7;
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcion.Location = new System.Drawing.Point(162, 124);
            this.LDescripcion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(114, 21);
            this.LDescripcion.TabIndex = 2;
            this.LDescripcion.Text = "Descripción";
            // 
            // contenedorGestionCategorias
            // 
            this.contenedorGestionCategorias.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorGestionCategorias.Controls.Add(this.LGestionCategorias);
            this.contenedorGestionCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorGestionCategorias.Location = new System.Drawing.Point(261, 0);
            this.contenedorGestionCategorias.Margin = new System.Windows.Forms.Padding(5);
            this.contenedorGestionCategorias.Name = "contenedorGestionCategorias";
            this.contenedorGestionCategorias.Size = new System.Drawing.Size(921, 62);
            this.contenedorGestionCategorias.TabIndex = 27;
            // 
            // LGestionCategorias
            // 
            this.LGestionCategorias.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LGestionCategorias.Dock = System.Windows.Forms.DockStyle.Left;
            this.LGestionCategorias.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestionCategorias.ForeColor = System.Drawing.Color.DarkRed;
            this.LGestionCategorias.Location = new System.Drawing.Point(0, 0);
            this.LGestionCategorias.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LGestionCategorias.Name = "LGestionCategorias";
            this.LGestionCategorias.Size = new System.Drawing.Size(291, 62);
            this.LGestionCategorias.TabIndex = 0;
            this.LGestionCategorias.Text = "Gestión de Categorías";
            this.LGestionCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.contenedorBotones.Margin = new System.Windows.Forms.Padding(5);
            this.contenedorBotones.Name = "contenedorBotones";
            this.contenedorBotones.Size = new System.Drawing.Size(261, 417);
            this.contenedorBotones.TabIndex = 26;
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
            this.Beliminar.Location = new System.Drawing.Point(44, 241);
            this.Beliminar.Margin = new System.Windows.Forms.Padding(5);
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
            this.Beditar.Location = new System.Drawing.Point(44, 187);
            this.Beditar.Margin = new System.Windows.Forms.Padding(5);
            this.Beditar.Name = "Beditar";
            this.Beditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beditar.Size = new System.Drawing.Size(183, 31);
            this.Beditar.TabIndex = 12;
            this.Beditar.Text = "Editar";
            this.Beditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beditar.UseVisualStyleBackColor = false;
            this.Beditar.Click += new System.EventHandler(this.Beditar_Click);
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
            this.Bguardar.Margin = new System.Windows.Forms.Padding(5);
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
            // contenedorLista
            // 
            this.contenedorLista.BackColor = System.Drawing.Color.White;
            this.contenedorLista.Controls.Add(this.Lbuscar);
            this.contenedorLista.Controls.Add(this.CBbuscar);
            this.contenedorLista.Controls.Add(this.LListaCategorias);
            this.contenedorLista.Controls.Add(this.TBBuscador);
            this.contenedorLista.Controls.Add(this.btnBuscar);
            this.contenedorLista.Controls.Add(this.btnLimpiar);
            this.contenedorLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contenedorLista.Location = new System.Drawing.Point(0, 417);
            this.contenedorLista.Margin = new System.Windows.Forms.Padding(5);
            this.contenedorLista.Name = "contenedorLista";
            this.contenedorLista.Size = new System.Drawing.Size(1182, 28);
            this.contenedorLista.TabIndex = 24;
            // 
            // Lbuscar
            // 
            this.Lbuscar.BackColor = System.Drawing.SystemColors.Window;
            this.Lbuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lbuscar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbuscar.Location = new System.Drawing.Point(611, 0);
            this.Lbuscar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbuscar.Name = "Lbuscar";
            this.Lbuscar.Size = new System.Drawing.Size(115, 28);
            this.Lbuscar.TabIndex = 0;
            this.Lbuscar.Text = "Buscar por:";
            this.Lbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBbuscar
            // 
            this.CBbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBbuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.CBbuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBbuscar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.CBbuscar.FormattingEnabled = true;
            this.CBbuscar.IntegralHeight = false;
            this.CBbuscar.Items.AddRange(new object[] {
            "Descripción",
            "Estado"});
            this.CBbuscar.Location = new System.Drawing.Point(726, 0);
            this.CBbuscar.Margin = new System.Windows.Forms.Padding(5);
            this.CBbuscar.Name = "CBbuscar";
            this.CBbuscar.Size = new System.Drawing.Size(171, 29);
            this.CBbuscar.TabIndex = 1;
            // 
            // LListaCategorias
            // 
            this.LListaCategorias.BackColor = System.Drawing.SystemColors.Window;
            this.LListaCategorias.Dock = System.Windows.Forms.DockStyle.Left;
            this.LListaCategorias.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaCategorias.ForeColor = System.Drawing.Color.DarkRed;
            this.LListaCategorias.Location = new System.Drawing.Point(0, 0);
            this.LListaCategorias.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LListaCategorias.Name = "LListaCategorias";
            this.LListaCategorias.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.LListaCategorias.Size = new System.Drawing.Size(408, 28);
            this.LListaCategorias.TabIndex = 12;
            this.LListaCategorias.Text = "Lista de Categorías";
            // 
            // TBBuscador
            // 
            this.TBBuscador.Dock = System.Windows.Forms.DockStyle.Right;
            this.TBBuscador.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscador.ForeColor = System.Drawing.Color.DarkRed;
            this.TBBuscador.Location = new System.Drawing.Point(897, 0);
            this.TBBuscador.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.TBBuscador.Name = "TBBuscador";
            this.TBBuscador.Size = new System.Drawing.Size(171, 28);
            this.TBBuscador.TabIndex = 33;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 18;
            this.btnBuscar.Location = new System.Drawing.Point(1068, 0);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 18;
            this.btnLimpiar.Location = new System.Drawing.Point(1125, 0);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(57, 28);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // listadoCategorias
            // 
            this.listadoCategorias.AutoGenerateColumns = false;
            this.listadoCategorias.BackgroundColor = System.Drawing.Color.White;
            this.listadoCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_categoria,
            this.Descripcion,
            this.Estado});
            this.listadoCategorias.DataSource = this.categoriasBindingSource2;
            this.listadoCategorias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoCategorias.Location = new System.Drawing.Point(0, 445);
            this.listadoCategorias.Margin = new System.Windows.Forms.Padding(5);
            this.listadoCategorias.Name = "listadoCategorias";
            this.listadoCategorias.RowHeadersWidth = 51;
            this.listadoCategorias.Size = new System.Drawing.Size(1182, 209);
            this.listadoCategorias.TabIndex = 25;
            this.listadoCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoCategorias_CellClick);
            // 
            // Id_categoria
            // 
            this.Id_categoria.DataPropertyName = "Id_categoria";
            this.Id_categoria.HeaderText = "Id_categoria";
            this.Id_categoria.MinimumWidth = 6;
            this.Id_categoria.Name = "Id_categoria";
            this.Id_categoria.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // categoriasBindingSource2
            // 
            this.categoriasBindingSource2.DataSource = typeof(FankyRecords.C_entidad.Categorias);
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(FankyRecords.C_entidad.Categorias);
            // 
            // categoriasBindingSource1
            // 
            this.categoriasBindingSource1.DataSource = typeof(FankyRecords.C_entidad.Categorias);
            // 
            // GestionCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.contenedorDatos);
            this.Controls.Add(this.contenedorGestionCategorias);
            this.Controls.Add(this.contenedorBotones);
            this.Controls.Add(this.contenedorLista);
            this.Controls.Add(this.listadoCategorias);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionCategorias";
            this.Load += new System.EventHandler(this.GestionCategorias_Load);
            this.contenedorDatos.ResumeLayout(false);
            this.contenedorDatos.PerformLayout();
            this.contenedorGestionCategorias.ResumeLayout(false);
            this.contenedorBotones.ResumeLayout(false);
            this.contenedorLista.ResumeLayout(false);
            this.contenedorLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel contenedorDatos;
        public System.Windows.Forms.Label LDescripcion;
        public System.Windows.Forms.Panel contenedorGestionCategorias;
        public System.Windows.Forms.Label LGestionCategorias;
        public System.Windows.Forms.Panel contenedorBotones;
        public FontAwesome.Sharp.IconButton Beliminar;
        public FontAwesome.Sharp.IconButton Beditar;
        public FontAwesome.Sharp.IconButton Bguardar;
        public System.Windows.Forms.Panel contenedorLista;
        public System.Windows.Forms.Label Lbuscar;
        public System.Windows.Forms.ComboBox CBbuscar;
        public System.Windows.Forms.Label LListaCategorias;
        public System.Windows.Forms.TextBox TBBuscador;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        public System.Windows.Forms.DataGridView listadoCategorias;
        public System.Windows.Forms.TextBox TBdescripcion;
        public System.Windows.Forms.RadioButton rBinactivo;
        public System.Windows.Forms.RadioButton rBactivo;
        public System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.BindingSource categoriasBindingSource1;
        private System.Windows.Forms.BindingSource categoriasBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}