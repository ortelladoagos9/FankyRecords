namespace FankyRecords.C_presentacion.Administrador
{
    partial class GestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
            this.LGestionUsuarios = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LFechaNac = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.LDireccion = new System.Windows.Forms.Label();
            this.TBtelefono = new System.Windows.Forms.MaskedTextBox();
            this.DTFechanac = new System.Windows.Forms.DateTimePicker();
            this.TBdireccion = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.TBemail = new System.Windows.Forms.TextBox();
            this.LContraseña = new System.Windows.Forms.Label();
            this.LConfirmarContraseña = new System.Windows.Forms.Label();
            this.LRol = new System.Windows.Forms.Label();
            this.LEstado = new System.Windows.Forms.Label();
            this.TBclave = new System.Windows.Forms.TextBox();
            this.TBconfirmarClave = new System.Windows.Forms.TextBox();
            this.contenedorDatos = new System.Windows.Forms.Panel();
            this.rutaFoto = new System.Windows.Forms.TextBox();
            this.Bfoto = new System.Windows.Forms.Button();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.rBinactivo = new System.Windows.Forms.RadioButton();
            this.rBactivo = new System.Windows.Forms.RadioButton();
            this.listadoUsuarios = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LListaUsuarios = new System.Windows.Forms.Label();
            this.Lbuscar = new System.Windows.Forms.Label();
            this.CBbuscar = new System.Windows.Forms.ComboBox();
            this.contenedorFotoBotones = new System.Windows.Forms.Panel();
            this.picFotoUsuario = new System.Windows.Forms.PictureBox();
            this.contenedorLista = new System.Windows.Forms.Panel();
            this.TBBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.contenedorGestionUsuarios = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Beliminar = new FontAwesome.Sharp.IconButton();
            this.Beditar = new FontAwesome.Sharp.IconButton();
            this.Bguardar = new FontAwesome.Sharp.IconButton();
            this.contenedorDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoUsuarios)).BeginInit();
            this.contenedorFotoBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoUsuario)).BeginInit();
            this.contenedorLista.SuspendLayout();
            this.contenedorGestionUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // LGestionUsuarios
            // 
            this.LGestionUsuarios.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LGestionUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.LGestionUsuarios.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestionUsuarios.ForeColor = System.Drawing.Color.DarkRed;
            this.LGestionUsuarios.Location = new System.Drawing.Point(0, 0);
            this.LGestionUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LGestionUsuarios.Name = "LGestionUsuarios";
            this.LGestionUsuarios.Size = new System.Drawing.Size(264, 56);
            this.LGestionUsuarios.TabIndex = 0;
            this.LGestionUsuarios.Text = "Gestión de Usuarios";
            this.LGestionUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.DarkRed;
            this.LNombre.Location = new System.Drawing.Point(14, 25);
            this.LNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(80, 21);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(13, 90);
            this.LApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(82, 21);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(13, 155);
            this.LDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(46, 21);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI";
            // 
            // LFechaNac
            // 
            this.LFechaNac.AutoSize = true;
            this.LFechaNac.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaNac.Location = new System.Drawing.Point(14, 220);
            this.LFechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFechaNac.Name = "LFechaNac";
            this.LFechaNac.Size = new System.Drawing.Size(194, 21);
            this.LFechaNac.TabIndex = 3;
            this.LFechaNac.Text = "Fecha de Nacimiento";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(571, 25);
            this.LTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(87, 21);
            this.LTelefono.TabIndex = 4;
            this.LTelefono.Text = "Teléfono";
            // 
            // TBnombre
            // 
            this.TBnombre.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombre.Location = new System.Drawing.Point(17, 54);
            this.TBnombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(242, 28);
            this.TBnombre.TabIndex = 5;
            this.TBnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // TBapellido
            // 
            this.TBapellido.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBapellido.Location = new System.Drawing.Point(16, 120);
            this.TBapellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.Size = new System.Drawing.Size(243, 28);
            this.TBapellido.TabIndex = 6;
            this.TBapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // TBdni
            // 
            this.TBdni.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdni.Location = new System.Drawing.Point(16, 184);
            this.TBdni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBdni.MaxLength = 8;
            this.TBdni.Name = "TBdni";
            this.TBdni.Size = new System.Drawing.Size(242, 28);
            this.TBdni.TabIndex = 7;
            this.TBdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccion.Location = new System.Drawing.Point(293, 25);
            this.LDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(95, 21);
            this.LDireccion.TabIndex = 10;
            this.LDireccion.Text = "Dirección";
            // 
            // TBtelefono
            // 
            this.TBtelefono.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtelefono.Location = new System.Drawing.Point(574, 54);
            this.TBtelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBtelefono.Mask = "(000)0000000";
            this.TBtelefono.Name = "TBtelefono";
            this.TBtelefono.Size = new System.Drawing.Size(242, 28);
            this.TBtelefono.TabIndex = 11;
            // 
            // DTFechanac
            // 
            this.DTFechanac.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechanac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechanac.Location = new System.Drawing.Point(17, 249);
            this.DTFechanac.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DTFechanac.Name = "DTFechanac";
            this.DTFechanac.Size = new System.Drawing.Size(242, 28);
            this.DTFechanac.TabIndex = 15;
            this.DTFechanac.Value = new System.DateTime(2024, 9, 28, 0, 0, 0, 0);
            // 
            // TBdireccion
            // 
            this.TBdireccion.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdireccion.Location = new System.Drawing.Point(296, 54);
            this.TBdireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBdireccion.Name = "TBdireccion";
            this.TBdireccion.Size = new System.Drawing.Size(242, 28);
            this.TBdireccion.TabIndex = 16;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.Location = new System.Drawing.Point(293, 90);
            this.LEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(61, 21);
            this.LEmail.TabIndex = 17;
            this.LEmail.Text = "Email";
            // 
            // TBemail
            // 
            this.TBemail.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBemail.Location = new System.Drawing.Point(297, 120);
            this.TBemail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBemail.Name = "TBemail";
            this.TBemail.Size = new System.Drawing.Size(241, 28);
            this.TBemail.TabIndex = 18;
            // 
            // LContraseña
            // 
            this.LContraseña.AutoSize = true;
            this.LContraseña.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContraseña.Location = new System.Drawing.Point(293, 156);
            this.LContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(112, 21);
            this.LContraseña.TabIndex = 19;
            this.LContraseña.Text = "Contraseña";
            // 
            // LConfirmarContraseña
            // 
            this.LConfirmarContraseña.AutoSize = true;
            this.LConfirmarContraseña.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfirmarContraseña.Location = new System.Drawing.Point(293, 220);
            this.LConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LConfirmarContraseña.Name = "LConfirmarContraseña";
            this.LConfirmarContraseña.Size = new System.Drawing.Size(209, 21);
            this.LConfirmarContraseña.TabIndex = 20;
            this.LConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.Location = new System.Drawing.Point(571, 90);
            this.LRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(40, 21);
            this.LRol.TabIndex = 21;
            this.LRol.Text = "Rol";
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.Location = new System.Drawing.Point(571, 220);
            this.LEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(70, 21);
            this.LEstado.TabIndex = 22;
            this.LEstado.Text = "Estado";
            // 
            // TBclave
            // 
            this.TBclave.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBclave.Location = new System.Drawing.Point(296, 184);
            this.TBclave.MaxLength = 10;
            this.TBclave.Name = "TBclave";
            this.TBclave.Size = new System.Drawing.Size(242, 28);
            this.TBclave.TabIndex = 23;
            // 
            // TBconfirmarClave
            // 
            this.TBconfirmarClave.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBconfirmarClave.Location = new System.Drawing.Point(296, 249);
            this.TBconfirmarClave.MaxLength = 10;
            this.TBconfirmarClave.Name = "TBconfirmarClave";
            this.TBconfirmarClave.Size = new System.Drawing.Size(242, 28);
            this.TBconfirmarClave.TabIndex = 24;
            // 
            // contenedorDatos
            // 
            this.contenedorDatos.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDatos.Controls.Add(this.rutaFoto);
            this.contenedorDatos.Controls.Add(this.Bfoto);
            this.contenedorDatos.Controls.Add(this.CBRol);
            this.contenedorDatos.Controls.Add(this.rBinactivo);
            this.contenedorDatos.Controls.Add(this.rBactivo);
            this.contenedorDatos.Controls.Add(this.TBconfirmarClave);
            this.contenedorDatos.Controls.Add(this.TBclave);
            this.contenedorDatos.Controls.Add(this.LEstado);
            this.contenedorDatos.Controls.Add(this.LRol);
            this.contenedorDatos.Controls.Add(this.LConfirmarContraseña);
            this.contenedorDatos.Controls.Add(this.LContraseña);
            this.contenedorDatos.Controls.Add(this.TBemail);
            this.contenedorDatos.Controls.Add(this.LEmail);
            this.contenedorDatos.Controls.Add(this.TBdireccion);
            this.contenedorDatos.Controls.Add(this.DTFechanac);
            this.contenedorDatos.Controls.Add(this.TBtelefono);
            this.contenedorDatos.Controls.Add(this.LDireccion);
            this.contenedorDatos.Controls.Add(this.TBdni);
            this.contenedorDatos.Controls.Add(this.TBapellido);
            this.contenedorDatos.Controls.Add(this.TBnombre);
            this.contenedorDatos.Controls.Add(this.LTelefono);
            this.contenedorDatos.Controls.Add(this.LFechaNac);
            this.contenedorDatos.Controls.Add(this.LDni);
            this.contenedorDatos.Controls.Add(this.LApellido);
            this.contenedorDatos.Controls.Add(this.LNombre);
            this.contenedorDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorDatos.ForeColor = System.Drawing.Color.DarkRed;
            this.contenedorDatos.Location = new System.Drawing.Point(261, 56);
            this.contenedorDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorDatos.Name = "contenedorDatos";
            this.contenedorDatos.Size = new System.Drawing.Size(921, 354);
            this.contenedorDatos.TabIndex = 1;
            // 
            // rutaFoto
            // 
            this.rutaFoto.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutaFoto.Location = new System.Drawing.Point(670, 173);
            this.rutaFoto.Name = "rutaFoto";
            this.rutaFoto.Size = new System.Drawing.Size(146, 28);
            this.rutaFoto.TabIndex = 31;
            // 
            // Bfoto
            // 
            this.Bfoto.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bfoto.Location = new System.Drawing.Point(575, 172);
            this.Bfoto.Name = "Bfoto";
            this.Bfoto.Size = new System.Drawing.Size(89, 28);
            this.Bfoto.TabIndex = 30;
            this.Bfoto.Text = "Foto";
            this.Bfoto.UseVisualStyleBackColor = true;
            this.Bfoto.Click += new System.EventHandler(this.BFoto_Click);
            // 
            // CBRol
            // 
            this.CBRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRol.ForeColor = System.Drawing.Color.DarkRed;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Items.AddRange(new object[] {
            "Administrativo",
            "Vendedor",
            "Administrador"});
            this.CBRol.Location = new System.Drawing.Point(574, 120);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(242, 29);
            this.CBRol.TabIndex = 29;
            // 
            // rBinactivo
            // 
            this.rBinactivo.AutoSize = true;
            this.rBinactivo.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBinactivo.Location = new System.Drawing.Point(713, 253);
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
            this.rBactivo.Location = new System.Drawing.Point(615, 253);
            this.rBactivo.Name = "rBactivo";
            this.rBactivo.Size = new System.Drawing.Size(86, 25);
            this.rBactivo.TabIndex = 26;
            this.rBactivo.TabStop = true;
            this.rBactivo.Text = "Activo";
            this.rBactivo.UseVisualStyleBackColor = true;
            // 
            // listadoUsuarios
            // 
            this.listadoUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.listadoUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.dni,
            this.apellido,
            this.nombre,
            this.FechaNac,
            this.direccion,
            this.mail,
            this.telefono,
            this.clave,
            this.rol,
            this.Estado});
            this.listadoUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoUsuarios.Location = new System.Drawing.Point(0, 445);
            this.listadoUsuarios.Name = "listadoUsuarios";
            this.listadoUsuarios.RowHeadersWidth = 51;
            this.listadoUsuarios.Size = new System.Drawing.Size(1182, 209);
            this.listadoUsuarios.TabIndex = 11;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "ID ";
            this.id_usuario.MinimumWidth = 6;
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.Width = 45;
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
            // FechaNac
            // 
            this.FechaNac.HeaderText = "Fecha Nacimiento";
            this.FechaNac.MinimumWidth = 6;
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            this.FechaNac.Width = 125;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 130;
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
            // clave
            // 
            this.clave.HeaderText = "Contraseña";
            this.clave.MinimumWidth = 6;
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Visible = false;
            this.clave.Width = 125;
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol";
            this.rol.MinimumWidth = 6;
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            this.rol.Width = 115;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // LListaUsuarios
            // 
            this.LListaUsuarios.BackColor = System.Drawing.SystemColors.Window;
            this.LListaUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.LListaUsuarios.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaUsuarios.ForeColor = System.Drawing.Color.DarkRed;
            this.LListaUsuarios.Location = new System.Drawing.Point(0, 0);
            this.LListaUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LListaUsuarios.Name = "LListaUsuarios";
            this.LListaUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LListaUsuarios.Size = new System.Drawing.Size(261, 35);
            this.LListaUsuarios.TabIndex = 12;
            this.LListaUsuarios.Text = "Lista de Usuarios";
            this.LListaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbuscar
            // 
            this.Lbuscar.BackColor = System.Drawing.SystemColors.Window;
            this.Lbuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lbuscar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbuscar.Location = new System.Drawing.Point(626, 0);
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
            "Nro DNI",
            "Nro ID",
            "Apellido",
            "Nombre"});
            this.CBbuscar.Location = new System.Drawing.Point(741, 0);
            this.CBbuscar.Name = "CBbuscar";
            this.CBbuscar.Size = new System.Drawing.Size(156, 29);
            this.CBbuscar.TabIndex = 1;
            this.CBbuscar.Text = "Seleccione";
            // 
            // contenedorFotoBotones
            // 
            this.contenedorFotoBotones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorFotoBotones.Controls.Add(this.picFotoUsuario);
            this.contenedorFotoBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedorFotoBotones.ForeColor = System.Drawing.Color.Transparent;
            this.contenedorFotoBotones.Location = new System.Drawing.Point(0, 0);
            this.contenedorFotoBotones.Name = "contenedorFotoBotones";
            this.contenedorFotoBotones.Size = new System.Drawing.Size(261, 410);
            this.contenedorFotoBotones.TabIndex = 17;
            // 
            // picFotoUsuario
            // 
            this.picFotoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.picFotoUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFotoUsuario.BackgroundImage")));
            this.picFotoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFotoUsuario.Location = new System.Drawing.Point(46, 57);
            this.picFotoUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picFotoUsuario.Name = "picFotoUsuario";
            this.picFotoUsuario.Size = new System.Drawing.Size(183, 189);
            this.picFotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoUsuario.TabIndex = 2;
            this.picFotoUsuario.TabStop = false;
            // 
            // contenedorLista
            // 
            this.contenedorLista.BackColor = System.Drawing.Color.White;
            this.contenedorLista.Controls.Add(this.Lbuscar);
            this.contenedorLista.Controls.Add(this.CBbuscar);
            this.contenedorLista.Controls.Add(this.LListaUsuarios);
            this.contenedorLista.Controls.Add(this.TBBuscador);
            this.contenedorLista.Controls.Add(this.btnBuscar);
            this.contenedorLista.Controls.Add(this.btnLimpiar);
            this.contenedorLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contenedorLista.Location = new System.Drawing.Point(0, 410);
            this.contenedorLista.Name = "contenedorLista";
            this.contenedorLista.Size = new System.Drawing.Size(1182, 35);
            this.contenedorLista.TabIndex = 18;
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
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 18;
            this.btnBuscar.Location = new System.Drawing.Point(1068, 0);
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
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(57, 35);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // contenedorGestionUsuarios
            // 
            this.contenedorGestionUsuarios.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorGestionUsuarios.Controls.Add(this.LGestionUsuarios);
            this.contenedorGestionUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorGestionUsuarios.Location = new System.Drawing.Point(261, 0);
            this.contenedorGestionUsuarios.Name = "contenedorGestionUsuarios";
            this.contenedorGestionUsuarios.Size = new System.Drawing.Size(921, 56);
            this.contenedorGestionUsuarios.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.Beliminar.Location = new System.Drawing.Point(46, 336);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beliminar.Size = new System.Drawing.Size(183, 31);
            this.Beliminar.TabIndex = 10;
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
            this.Beditar.Location = new System.Drawing.Point(46, 300);
            this.Beditar.Name = "Beditar";
            this.Beditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beditar.Size = new System.Drawing.Size(183, 31);
            this.Beditar.TabIndex = 9;
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
            this.Bguardar.Location = new System.Drawing.Point(46, 264);
            this.Bguardar.Name = "Bguardar";
            this.Bguardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bguardar.Size = new System.Drawing.Size(183, 31);
            this.Bguardar.TabIndex = 7;
            this.Bguardar.Text = "Guardar";
            this.Bguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bguardar.UseVisualStyleBackColor = false;
            this.Bguardar.Click += new System.EventHandler(this.Bguardar_Click);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.contenedorDatos);
            this.Controls.Add(this.contenedorGestionUsuarios);
            this.Controls.Add(this.Beliminar);
            this.Controls.Add(this.Beditar);
            this.Controls.Add(this.Bguardar);
            this.Controls.Add(this.contenedorFotoBotones);
            this.Controls.Add(this.contenedorLista);
            this.Controls.Add(this.listadoUsuarios);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.contenedorDatos.ResumeLayout(false);
            this.contenedorDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoUsuarios)).EndInit();
            this.contenedorFotoBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoUsuario)).EndInit();
            this.contenedorLista.ResumeLayout(false);
            this.contenedorLista.PerformLayout();
            this.contenedorGestionUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox picFotoUsuario;
        public FontAwesome.Sharp.IconButton Bguardar;
        public FontAwesome.Sharp.IconButton Beditar;
        public FontAwesome.Sharp.IconButton Beliminar;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public System.Windows.Forms.Panel contenedorFotoBotones;
        public System.Windows.Forms.Panel contenedorGestionUsuarios;
        public System.Windows.Forms.DataGridView listadoUsuarios;
        public System.Windows.Forms.Panel contenedorLista;
        public System.Windows.Forms.Label Lbuscar;
        public System.Windows.Forms.ComboBox CBbuscar;
        public System.Windows.Forms.Panel contenedorDatos;
        public System.Windows.Forms.Label LListaUsuarios;
        public System.Windows.Forms.Label LGestionUsuarios;
        public System.Windows.Forms.Label LNombre;
        public System.Windows.Forms.Label LApellido;
        public System.Windows.Forms.Label LDni;
        public System.Windows.Forms.Label LFechaNac;
        public System.Windows.Forms.Label LTelefono;
        public System.Windows.Forms.TextBox TBnombre;
        public System.Windows.Forms.TextBox TBapellido;
        public System.Windows.Forms.TextBox TBdni;
        public System.Windows.Forms.Label LDireccion;
        public System.Windows.Forms.MaskedTextBox TBtelefono;
        public System.Windows.Forms.DateTimePicker DTFechanac;
        public System.Windows.Forms.TextBox TBdireccion;
        public System.Windows.Forms.Label LEmail;
        public System.Windows.Forms.TextBox TBemail;
        public System.Windows.Forms.Label LContraseña;
        public System.Windows.Forms.Label LConfirmarContraseña;
        public System.Windows.Forms.Label LRol;
        public System.Windows.Forms.Label LEstado;
        public System.Windows.Forms.TextBox TBclave;
        public System.Windows.Forms.TextBox TBconfirmarClave;
        public System.Windows.Forms.RadioButton rBactivo;
        public System.Windows.Forms.RadioButton rBinactivo;
        public System.Windows.Forms.ComboBox CBRol;
        public System.Windows.Forms.TextBox rutaFoto;
        public System.Windows.Forms.Button Bfoto;
        public System.Windows.Forms.TextBox TBBuscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}