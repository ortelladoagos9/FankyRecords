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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listadoClientes = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenedorGestionClientes = new System.Windows.Forms.Panel();
            this.LGestionClientes = new System.Windows.Forms.Label();
            this.contenedorLista = new System.Windows.Forms.Panel();
            this.Lbuscar = new System.Windows.Forms.Label();
            this.CBbuscar = new System.Windows.Forms.ComboBox();
            this.LListaClientes = new System.Windows.Forms.Label();
            this.TBBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.contenedorFotoBotones = new System.Windows.Forms.Panel();
            this.Beditar = new FontAwesome.Sharp.IconButton();
            this.Bguardar = new FontAwesome.Sharp.IconButton();
            this.Beliminar = new FontAwesome.Sharp.IconButton();
            this.contenedorDatos = new System.Windows.Forms.Panel();
            this.rBinactivo = new System.Windows.Forms.RadioButton();
            this.rBactivo = new System.Windows.Forms.RadioButton();
            this.LEstado = new System.Windows.Forms.Label();
            this.TBemail = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.TBtelefono = new System.Windows.Forms.MaskedTextBox();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).BeginInit();
            this.contenedorGestionClientes.SuspendLayout();
            this.contenedorLista.SuspendLayout();
            this.contenedorFotoBotones.SuspendLayout();
            this.contenedorDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listadoClientes
            // 
            this.listadoClientes.BackgroundColor = System.Drawing.Color.White;
            this.listadoClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.apellido,
            this.nombre,
            this.mail,
            this.telefono,
            this.Estado});
            this.listadoClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoClientes.Location = new System.Drawing.Point(0, 445);
            this.listadoClientes.Name = "listadoClientes";
            this.listadoClientes.RowHeadersWidth = 51;
            this.listadoClientes.Size = new System.Drawing.Size(1182, 209);
            this.listadoClientes.TabIndex = 12;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.MinimumWidth = 6;
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 110;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // mail
            // 
            this.mail.HeaderText = "Email";
            this.mail.MinimumWidth = 6;
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Width = 125;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 120;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // contenedorGestionClientes
            // 
            this.contenedorGestionClientes.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorGestionClientes.Controls.Add(this.LGestionClientes);
            this.contenedorGestionClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorGestionClientes.Location = new System.Drawing.Point(261, 0);
            this.contenedorGestionClientes.Name = "contenedorGestionClientes";
            this.contenedorGestionClientes.Size = new System.Drawing.Size(921, 62);
            this.contenedorGestionClientes.TabIndex = 20;
            // 
            // LGestionClientes
            // 
            this.LGestionClientes.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LGestionClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.LGestionClientes.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestionClientes.ForeColor = System.Drawing.Color.DarkRed;
            this.LGestionClientes.Location = new System.Drawing.Point(0, 0);
            this.LGestionClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LGestionClientes.Name = "LGestionClientes";
            this.LGestionClientes.Size = new System.Drawing.Size(264, 62);
            this.LGestionClientes.TabIndex = 0;
            this.LGestionClientes.Text = "Gestión de Clientes";
            this.LGestionClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // contenedorLista
            // 
            this.contenedorLista.BackColor = System.Drawing.Color.White;
            this.contenedorLista.Controls.Add(this.Lbuscar);
            this.contenedorLista.Controls.Add(this.CBbuscar);
            this.contenedorLista.Controls.Add(this.LListaClientes);
            this.contenedorLista.Controls.Add(this.TBBuscador);
            this.contenedorLista.Controls.Add(this.btnBuscar);
            this.contenedorLista.Controls.Add(this.btnLimpiar);
            this.contenedorLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contenedorLista.Location = new System.Drawing.Point(0, 417);
            this.contenedorLista.Name = "contenedorLista";
            this.contenedorLista.Size = new System.Drawing.Size(1182, 28);
            this.contenedorLista.TabIndex = 21;
            // 
            // Lbuscar
            // 
            this.Lbuscar.BackColor = System.Drawing.SystemColors.Window;
            this.Lbuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lbuscar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbuscar.Location = new System.Drawing.Point(611, 0);
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
            "DNI",
            "Apellido",
            "Nombre"});
            this.CBbuscar.Location = new System.Drawing.Point(726, 0);
            this.CBbuscar.Name = "CBbuscar";
            this.CBbuscar.Size = new System.Drawing.Size(171, 29);
            this.CBbuscar.TabIndex = 1;
            // 
            // LListaClientes
            // 
            this.LListaClientes.BackColor = System.Drawing.SystemColors.Window;
            this.LListaClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.LListaClientes.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaClientes.ForeColor = System.Drawing.Color.DarkRed;
            this.LListaClientes.Location = new System.Drawing.Point(0, 0);
            this.LListaClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LListaClientes.Name = "LListaClientes";
            this.LListaClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LListaClientes.Size = new System.Drawing.Size(261, 28);
            this.LListaClientes.TabIndex = 12;
            this.LListaClientes.Text = "Lista de Clientes";
            this.LListaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBBuscador
            // 
            this.TBBuscador.Dock = System.Windows.Forms.DockStyle.Right;
            this.TBBuscador.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscador.ForeColor = System.Drawing.Color.DarkRed;
            this.TBBuscador.Location = new System.Drawing.Point(897, 0);
            this.TBBuscador.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.TBBuscador.Name = "TBBuscador";
            this.TBBuscador.Size = new System.Drawing.Size(171, 28);
            this.TBBuscador.TabIndex = 32;
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
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(57, 28);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // contenedorFotoBotones
            // 
            this.contenedorFotoBotones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorFotoBotones.Controls.Add(this.Beditar);
            this.contenedorFotoBotones.Controls.Add(this.Bguardar);
            this.contenedorFotoBotones.Controls.Add(this.Beliminar);
            this.contenedorFotoBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedorFotoBotones.ForeColor = System.Drawing.Color.Transparent;
            this.contenedorFotoBotones.Location = new System.Drawing.Point(0, 0);
            this.contenedorFotoBotones.Name = "contenedorFotoBotones";
            this.contenedorFotoBotones.Size = new System.Drawing.Size(261, 417);
            this.contenedorFotoBotones.TabIndex = 22;
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
            this.Beditar.Location = new System.Drawing.Point(39, 193);
            this.Beditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Beditar.Name = "Beditar";
            this.Beditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beditar.Size = new System.Drawing.Size(183, 31);
            this.Beditar.TabIndex = 13;
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
            this.Bguardar.Location = new System.Drawing.Point(39, 140);
            this.Bguardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bguardar.Name = "Bguardar";
            this.Bguardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bguardar.Size = new System.Drawing.Size(183, 31);
            this.Bguardar.TabIndex = 12;
            this.Bguardar.Text = "Guardar";
            this.Bguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bguardar.UseVisualStyleBackColor = false;
            this.Bguardar.Click += new System.EventHandler(this.Bguardar_Click);
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
            this.Beliminar.Location = new System.Drawing.Point(39, 246);
            this.Beliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beliminar.Size = new System.Drawing.Size(183, 31);
            this.Beliminar.TabIndex = 14;
            this.Beliminar.Text = "Eliminar";
            this.Beliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beliminar.UseVisualStyleBackColor = false;
            this.Beliminar.Click += new System.EventHandler(this.Beliminar_Click);
            // 
            // contenedorDatos
            // 
            this.contenedorDatos.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDatos.Controls.Add(this.rBinactivo);
            this.contenedorDatos.Controls.Add(this.rBactivo);
            this.contenedorDatos.Controls.Add(this.LEstado);
            this.contenedorDatos.Controls.Add(this.TBemail);
            this.contenedorDatos.Controls.Add(this.LEmail);
            this.contenedorDatos.Controls.Add(this.TBtelefono);
            this.contenedorDatos.Controls.Add(this.TBdni);
            this.contenedorDatos.Controls.Add(this.TBapellido);
            this.contenedorDatos.Controls.Add(this.TBnombre);
            this.contenedorDatos.Controls.Add(this.LTelefono);
            this.contenedorDatos.Controls.Add(this.LDni);
            this.contenedorDatos.Controls.Add(this.LApellido);
            this.contenedorDatos.Controls.Add(this.LNombre);
            this.contenedorDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorDatos.ForeColor = System.Drawing.Color.DarkRed;
            this.contenedorDatos.Location = new System.Drawing.Point(261, 62);
            this.contenedorDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorDatos.Name = "contenedorDatos";
            this.contenedorDatos.Size = new System.Drawing.Size(921, 355);
            this.contenedorDatos.TabIndex = 23;
            // 
            // rBinactivo
            // 
            this.rBinactivo.AutoSize = true;
            this.rBinactivo.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBinactivo.Location = new System.Drawing.Point(603, 203);
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
            this.rBactivo.Location = new System.Drawing.Point(505, 203);
            this.rBactivo.Name = "rBactivo";
            this.rBactivo.Size = new System.Drawing.Size(86, 25);
            this.rBactivo.TabIndex = 26;
            this.rBactivo.TabStop = true;
            this.rBactivo.Text = "Activo";
            this.rBactivo.UseVisualStyleBackColor = true;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.Location = new System.Drawing.Point(472, 172);
            this.LEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(70, 21);
            this.LEstado.TabIndex = 22;
            this.LEstado.Text = "Estado";
            // 
            // TBemail
            // 
            this.TBemail.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBemail.Location = new System.Drawing.Point(472, 74);
            this.TBemail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBemail.MaxLength = 100;
            this.TBemail.Name = "TBemail";
            this.TBemail.Size = new System.Drawing.Size(241, 28);
            this.TBemail.TabIndex = 18;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.Location = new System.Drawing.Point(472, 46);
            this.LEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(61, 21);
            this.LEmail.TabIndex = 17;
            this.LEmail.Text = "Email";
            // 
            // TBtelefono
            // 
            this.TBtelefono.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtelefono.Location = new System.Drawing.Point(472, 137);
            this.TBtelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBtelefono.Mask = "(000)0000000";
            this.TBtelefono.Name = "TBtelefono";
            this.TBtelefono.Size = new System.Drawing.Size(242, 28);
            this.TBtelefono.TabIndex = 11;
            // 
            // TBdni
            // 
            this.TBdni.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdni.Location = new System.Drawing.Point(140, 200);
            this.TBdni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBdni.MaxLength = 8;
            this.TBdni.Name = "TBdni";
            this.TBdni.Size = new System.Drawing.Size(242, 28);
            this.TBdni.TabIndex = 7;
            this.TBdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // TBapellido
            // 
            this.TBapellido.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBapellido.Location = new System.Drawing.Point(140, 137);
            this.TBapellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBapellido.MaxLength = 100;
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.Size = new System.Drawing.Size(243, 28);
            this.TBapellido.TabIndex = 6;
            this.TBapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // TBnombre
            // 
            this.TBnombre.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombre.Location = new System.Drawing.Point(140, 74);
            this.TBnombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBnombre.MaxLength = 100;
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(242, 28);
            this.TBnombre.TabIndex = 5;
            this.TBnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(472, 109);
            this.LTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(87, 21);
            this.LTelefono.TabIndex = 4;
            this.LTelefono.Text = "Teléfono";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(140, 172);
            this.LDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(46, 21);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(140, 109);
            this.LApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(82, 21);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.DarkRed;
            this.LNombre.Location = new System.Drawing.Point(140, 46);
            this.LNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(80, 21);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre";
            // 
            // GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.contenedorDatos);
            this.Controls.Add(this.contenedorGestionClientes);
            this.Controls.Add(this.contenedorFotoBotones);
            this.Controls.Add(this.contenedorLista);
            this.Controls.Add(this.listadoClientes);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionClientes";
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).EndInit();
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
        public System.Windows.Forms.ComboBox CBbuscar;
        public System.Windows.Forms.Label LListaClientes;
        public System.Windows.Forms.TextBox TBBuscador;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        public System.Windows.Forms.Panel contenedorFotoBotones;
        public System.Windows.Forms.Panel contenedorDatos;
        public System.Windows.Forms.RadioButton rBinactivo;
        public System.Windows.Forms.RadioButton rBactivo;
        public System.Windows.Forms.Label LEstado;
        public System.Windows.Forms.TextBox TBemail;
        public System.Windows.Forms.Label LEmail;
        public System.Windows.Forms.MaskedTextBox TBtelefono;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}